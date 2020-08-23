using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Xml.Serialization;
using MTRSerial.Enumerations;
using MTRSerial.ValueObjects;

namespace MTRSerial
{
    //for listening to reads and writes
    public class MTRCommandEventArgs : EventArgs
    {
        public MTRCommandEventArgs()
        {
            var timeStampString = (DateTime.Now.Ticks / DefaultValues.SystemTickDivider).ToString();
            var startIndex = Math.Max(0, timeStampString.Length - 8);
            TimeStamp = timeStampString.Substring(startIndex);
        }

        public string TimeStamp { get; set; }
        public string Identifier { get; set; }
        public string Command { get; set; }
        public string DebugText { get; set; }
        public string Data { get; set; }
    }

    public class MTRSerialPort
    {
        //for listening to reads and writes
        public event EventHandler<MTRCommandEventArgs> MTRCommunication;
        public event EventHandler<EventArgs> CommsErrorCountChanged;
        public event EventHandler<EventArgs> SerialPortOpened;
        public event EventHandler<EventArgs> SerialPortClosed;
        public event EventHandler EmitDataReceived;


        private volatile int _communicationErrorsCount;               // Counter for communication errors
        private volatile bool _waitAck;
        private readonly object _commLock = new object();
        private SerialPort _serialPort;
        public MTRResponse EmitDataMtrResponse = null;
        private int _lastEmitRead = 0;
        private const int xorDF = 223; // Hexadecimal = "DF";


        private List<int> buffer = new List<int>();

        protected virtual void OnEmitDataChanged()
        {
            if (EmitDataReceived != null) EmitDataReceived(this, EventArgs.Empty);
        }

        public MTRSerialPort()
        {
            _serialPort = new SerialPort();
        }

        public string GetComPortName => _serialPort.PortName;

        /// <summary>
        /// Send command to the MTR
        /// </summary>
        /// <param name="command">Command to send</param>
        /// <param name="binary">Some commands needs extra binarydata. If it is needed and no binary data given an exception will throw</param>
        public void AskFromMTR(CommandsToMTR.CommandName command, byte[] binary = null)
        {
            var cmd = GetCommand(command, binary);
            SendData(cmd);
        }

        /// <summary>
        /// In some cases to "reboot" connection it need to close and reopen
        /// </summary>
        /// <returns></returns>
        public bool CloseAndReopenSerialPort()
        {
            CloseSerialPort();
            Thread.Sleep(500);// The best practice for any application is to wait for some amount of time after calling the Close method before attempting to call the Open method, as the port may not be closed instantly. From:https://msdn.microsoft.com/en-us/library/system.io.ports.serialport.close.aspx
            return OpenSerialPort();
        }

        /// <summary>
        /// Closes the Serial port and stop communication
        /// </summary>
        public void CloseSerialPort()
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                try
                {
                    _serialPort.Close();
                    if (MTRCommunication != null)
                    {
                        var infoArgs = CreateInfoArgs(@"Serial port closed");
                        MTRCommunication(this, infoArgs);
                    }
                }
                catch (Exception)
                {
                    if (MTRCommunication != null)
                    {
                        var infoArgs = CreateInfoArgs(@"Serial port closing failed, check exception from application log");
                        MTRCommunication(this, infoArgs);
                    }
                    // TODO Some logging
                    //Logger.AddMessageToLogQueue(@"Serial port closing failed");
                    //Logger.FlushLogQueue();
                    return;
                }
            }

            SerialPortClosed?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Opens the Serial port and enables the communication
        /// </summary>
        /// <returns></returns>
        public bool OpenSerialPort()
        {
            // Init the serial port and communications log
            var success = InitSerialPort();
            if (_serialPort != null && success)
            {
                ResetCommunicationErrorsCount();

                SerialPortOpened?.Invoke(this, EventArgs.Empty);

                if (MTRCommunication != null)
                {
                    var infoArgs = CreateInfoArgs(@"Serial port opened");
                    MTRCommunication(this, infoArgs);
                }
            }
            return success;
        }

        /// <summary>
        /// The amount of communication errors increase if there occurs some errors. This method returns the amount of the errors. It can be reset by using "ResetCommunicationErrorsCount"
        /// </summary>
        /// <returns></returns>
        public int GetAmountOfCommunicationErrors()
        {
            return _communicationErrorsCount;
        }

        /// <summary>
        /// This resets the number of the communication errors
        /// </summary> 
        private void ResetCommunicationErrorsCount()
        {
            _communicationErrorsCount = 0;
            CommsErrorCountChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// This returns true if the the Serial port connection is open
        /// </summary>
        /// <returns>True if open, otherwise false</returns>
        public bool IsSerialPortOpen()
        {
            return _serialPort != null && _serialPort.IsOpen;
        }

        /// <summary>
        /// Event handler when some data received from the serial port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void DataReceivedMTR(object sender, SerialDataReceivedEventArgs e)
        {
            if (string.IsNullOrEmpty(Thread.CurrentThread.Name))
            {
                Thread.CurrentThread.Name = "SerialPortRXThread";
                Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;
            }
            lock (_commLock)
            {
                int lastReadByte = 0;
                var startFound = false;
                var stopReading = false;
                while (stopReading == false)
                {
                    try
                    {
                        var readByteXor = _serialPort.ReadByte() ^ xorDF;

                        if (lastReadByte.Equals(255) && readByteXor.Equals(255))
                        {
                            buffer.Add(lastReadByte);
                            startFound = true;
                        }
                        if (startFound)
                        {
                            buffer.Add(readByteXor);
                            if (buffer.Count > 217) stopReading = true;
                        }
                        else
                        {
                            lastReadByte = readByteXor;
                        }
                    }
                    catch
                    {
                        stopReading = true;
                    }
                }

                Console.WriteLine(buffer.Count);
                ParseRxString(buffer);
                buffer.Clear();
            }
        }

        private string GetCommand(CommandsToMTR.CommandName command, byte[] binary = null)
        {
            if (command == CommandsToMTR.CommandName.SpoolBinary ||
               command == CommandsToMTR.CommandName.GetMessageBinary ||
               command == CommandsToMTR.CommandName.SetClock
                && binary == null)
            {
                throw new Exception("Binary content missing.");
            }

            switch (command)
            {
                case CommandsToMTR.CommandName.Status: return "/ST";
                case CommandsToMTR.CommandName.Spool: return "/SA";
                case CommandsToMTR.CommandName.SpoolBinary: return "/SB" + binary;
                case CommandsToMTR.CommandName.NewSession: return "/NS";
                case CommandsToMTR.CommandName.GetMessageBinary: return "/GB" + binary;
                case CommandsToMTR.CommandName.SetClock: return "/SC" + binary;
                case CommandsToMTR.CommandName.ClearRingbuffer: return "/CL";
                default: return string.Empty;
            }
        }   

        private void SendData(string cmd)
        {
            if (string.IsNullOrEmpty(cmd)) return;

            WaitForReply(cmd);

            _waitAck = true;

            try
            {
                _serialPort.Write(cmd + @"\r");
            }
            catch (Exception)
            {
                if (MTRCommunication != null)
                {
                    var infoArgs = CreateInfoArgs(@"Serial port data sending failed for the command beneath this line, check exception from application log");
                    MTRCommunication(this, infoArgs);
                }
                // TODO some logging
                //Logger.AddMessageToLogQueue(@"Serial port data sending failed");
                //Logger.FlushLogQueue();
                return;
            }

            if (MTRCommunication != null)
            {
                var command = cmd.Substring(0, 1);
                var data = string.Empty;
                if (cmd.Length > 1) data = cmd.Substring(1);
                var eventArgs = new MTRCommandEventArgs { Command = command, Data = data, Identifier = @"OUT", DebugText = "debug" };
                MTRCommunication(this, eventArgs);
            }
        }

        private void WaitForReply(string cmd)
        {
            var waitCount = 0;
            while (_waitAck)
            {
                if (waitCount++ >= 200 && cmd.Length >= 1)
                {
                    _waitAck = false;
                    IncreaseCommunicationErrorsCount();
                    break;
                }
                Thread.Sleep(1);
            }
        }

        private void IncreaseCommunicationErrorsCount()
        {
            _communicationErrorsCount++;
            CommsErrorCountChanged?.Invoke(this, EventArgs.Empty);

            if (MTRCommunication != null)
            {
                var infoArgs = CreateInfoArgs(string.Format(@"Communication error count increased, count is now {0}", _communicationErrorsCount));
                MTRCommunication(this, infoArgs);
            }
        }

        private void ParseRxString(List<int> rxByteList)
        {
            if (rxByteList.Count <= 1)
            {
                IncreaseCommunicationErrorsCount();
                return;
            }

            if (rxByteList[0].Equals(255) && rxByteList[1].Equals(255))
            {
                if (rxByteList[2].Equals(255) && rxByteList[3].Equals(255))
                {
                    // Response
                    var size = rxByteList[5];
                    var cmd = rxByteList[6];

                    var data = string.Join(",", rxByteList);
                    if (MTRCommunication != null)
                    {
                        var eventArgs = new MTRCommandEventArgs { Command = cmd.ToString(), Data = data, Identifier = @"IN", DebugText = "debug" };
                        MTRCommunication(this, eventArgs);
                    }

                    switch (cmd)
                    {
                        case 77: // 'M':
                            if (rxByteList.Count < 230 || size != 230) return;
                            HandleMTRDataMessage(data);
                            break;
                        case 83: //'S':
                            if (rxByteList.Count < 59 || size != 59) return;
                            HandleMTRStatusMessage(data);
                            break;
                        default:
                            IncreaseCommunicationErrorsCount();
                            break;
                    }
                }
                else
                {
                    if (rxByteList.Count < 217) return;
                    HandleMTRResponseMessage(rxByteList);
                }
            }
        }

        private void HandleMTRDataMessage(string data)
        {
            //MTR--datamessage
            //    ----------------
            //Fieldname     # bytes
            //Preamble      4 FFFFFFFF(hex)(4 "FF"'s never occur "inside" a message).
            //Package -size 1 number of bytes excluding preamble(= 230)
            //Package -type 1 'M' as "MTR-datamessage".
            //MTR - id      2 Serial number of MTR2; Least significant byte first
            //Timestamp     6 Binary Year, Month, Day, Hour, Minute, Second
            //TS - [ms]     2 Milliseconds NOT YET USED, WILL BE 0 IN THIS VERSION
            //Package#      4 Binary Counter, from 1 and up; Least sign byte first
            //Card - id     3 Binary, Least sign byte first
            //Producweek 1  0 - 53; 0 when package is retrived from "history"
            //Producyear 1  94 - 99,0 -..X; 0 when package is retrived from "history"
            //ECardHeadSum  1 Headchecksum from card; 0 when package is retrived from "history"

            //The following fields are repeated 50 times:
            //CodeN         1 ControlCode; unused positions have 0
            //TimeN         2 Time binary seconds.Least sign. first, Most sign. last; unused: 0
            //ASCII string  56 Various info depending on ECard - type; 20h when retr.from "history"(See ASCIIstring)
            //Checksum      1 Binary SUM(MOD 256) of all bytes including Preamble
            //NULL - Filler 1 Binary 0(to avoid potential 5 FF's. Making it easier to haunt PREAMBLE
            //    ----------------------------------------
            //Size 234


            var MTRDataStrings = new MTRDataMessageString();
            MTRDataStrings.Preamble = data.Substring(0, 4); // Ensure the message start with preamble
            MTRDataStrings.PackageSize = data.Substring(4); // Packet size, should be 230 when datamessage
            MTRDataStrings.PackageType = data.Substring(5); // Packet type, should be M as MTR message
            MTRDataStrings.MtrSerialNo = data.Substring(6, 2); //serialNumber of the MTR reader
            MTRDataStrings.TimeStamp = data.Substring(8, 6); // binary year, month day, hour, minute, second
            MTRDataStrings.Time_ms = data.Substring(14, 2); // Time is not yet in use
            MTRDataStrings.PackageNo = data.Substring(15, 4); // counter from 1 to up
            MTRDataStrings.CardId = data.Substring(19, 3); // binary, least sign first
            // Next tree is used when data retrived from history
            //MTRData.ProductWeek = data.Substring(22, 53);
            //MTRData.ProductYear = data.Substring(94,5);
            //MTRData.ECardHeadSum = data.Substring(100);

            List<MTRDataCheckPoint> checkPoints = new List<MTRDataCheckPoint>();

            for (int checkPointNo = 0; checkPointNo < 50; checkPointNo++)
            {
                var checkPointDataPosition = 61 * checkPointNo;
                var checkPoint = new MTRDataCheckPoint();
                var codeN = data.Substring(100 + checkPointDataPosition, 1);
                var timeN = data.Substring(102 + checkPointDataPosition, 2);
                var info = data.Substring(103 + checkPointDataPosition, 56);
                var checkSum = data.Substring(159 + checkPointDataPosition, 1);
                var filler = data.Substring(160 + checkPointDataPosition, 1);

                MTRDataStrings.CheckPoints.Add(new[] { codeN, timeN, info, checkSum, filler });
            }

            var mtrData = ConvertDataStringToTypeData(MTRDataStrings);
            //var listDatas = new List<MTRData>();
            //listDatas.Add(mtrData);
            //WriteValuesToFile(listDatas);
        }

        private void HandleMTRStatusMessage(string data)
        {
            //MTR--datamessage
            //    ----------------
            //Fieldname     # bytes
            //Preamble      4 FFFFFFFF(hex)(4 "FF"'s never occur "inside" a message).
            //Package -size 1 number of bytes excluding preamble(= 230)
            //Package -type 1 'M' as "MTR-datamessage".
            //MTR - id      2 Serial number of MTR2; Least significant byte first
            //Timestamp     6 Binary Year, Month, Day, Hour, Minute, Second
            //TS - [ms]     2 Milliseconds NOT YET USED, WILL BE 0 IN THIS VERSION
            //Package#      4 Binary Counter, from 1 and up; Least sign byte first
            //Card - id     3 Binary, Least sign byte first
            //Producweek 1  0 - 53; 0 when package is retrived from "history"
            //Producyear 1  94 - 99,0 -..X; 0 when package is retrived from "history"
            //ECardHeadSum  1 Headchecksum from card; 0 when package is retrived from "history"

            //The following fields are repeated 50 times:
            //CodeN         1 ControlCode; unused positions have 0
            //TimeN         2 Time binary seconds.Least sign. first, Most sign. last; unused: 0
            //ASCII string  56 Various info depending on ECard - type; 20h when retr.from "history"(See ASCIIstring)
            //Checksum      1 Binary SUM(MOD 256) of all bytes including Preamble
            //NULL - Filler 1 Binary 0(to avoid potential 5 FF's. Making it easier to haunt PREAMBLE
            //    ----------------------------------------
            //Size 234


            var MTRDataStrings = new MTRDataMessageString();
            MTRDataStrings.Preamble = data.Substring(0, 4); // Ensure the message start with preamble
            MTRDataStrings.PackageSize = data.Substring(4); // Packet size, should be 230 when datamessage
            MTRDataStrings.PackageType = data.Substring(5); // Packet type, should be M as MTR message
            MTRDataStrings.MtrSerialNo = data.Substring(6, 2); //serialNumber of the MTR reader
            MTRDataStrings.TimeStamp = data.Substring(8, 6); // binary year, month day, hour, minute, second
            MTRDataStrings.Time_ms = data.Substring(14, 2); // Time is not yet in use
            MTRDataStrings.PackageNo = data.Substring(15, 4); // counter from 1 to up
            MTRDataStrings.CardId = data.Substring(19, 3); // binary, least sign first
            // Next tree is used when data retrived from history
            //MTRData.ProductWeek = data.Substring(22, 53);
            //MTRData.ProductYear = data.Substring(94,5);
            //MTRData.ECardHeadSum = data.Substring(100);

            List<MTRDataCheckPoint> checkPoints = new List<MTRDataCheckPoint>();

            for (int checkPointNo = 0; checkPointNo < 50; checkPointNo++)
            {
                var checkPointDataPosition = 61 * checkPointNo;
                var checkPoint = new MTRDataCheckPoint();
                var codeN = data.Substring(100 + checkPointDataPosition, 1);
                var timeN = data.Substring(102 + checkPointDataPosition, 2);
                var info = data.Substring(103 + checkPointDataPosition, 56);
                var checkSum = data.Substring(159 + checkPointDataPosition, 1);
                var filler = data.Substring(160 + checkPointDataPosition, 1);

                MTRDataStrings.CheckPoints.Add(new[] { codeN, timeN, info, checkSum, filler });
            }

            var mtrData = ConvertDataStringToTypeData(MTRDataStrings);
            var listDatas = new List<MTRDataMessage>();
            listDatas.Add(mtrData);
            //WriteValuesToFile(listDatas);
        }

        private void HandleMTRResponseMessage(List<int> rxByteList)
        {
            SaveToFile();

            var emit = rxByteList[4].ToString("X") + rxByteList[3].ToString("X") + rxByteList[2].ToString("X");
            MTRResponse mtrResponse = new MTRResponse
            {
                EmitCardNumber = int.Parse(emit, NumberStyles.HexNumber),
                NotInUse1 = rxByteList[5],
                EmitCardProdWeek = rxByteList[6],
                EmitCardProdYear = rxByteList[7],
                NotInUse2 = rxByteList[8]
            };
            var cardCheckByte = rxByteList[9];

            if (!CheckModulo(rxByteList.GetRange(2, 8)))
            {
                IncreaseCommunicationErrorsCount();
                throw new Exception("Emit card checksum failed");
            }

            List<MTRDataCheckPoint> checkPoints = new List<MTRDataCheckPoint>();

            // Try to find starting zeros
            // ie. three zeros in a row
            var moveBitsFromStart = 10;
            if (rxByteList[10] == 0 && rxByteList[11] == 0 && rxByteList[12] == 0)
                moveBitsFromStart = 10;
            else if (rxByteList[11] == 0 && rxByteList[12] == 0 && rxByteList[13] == 0)
                moveBitsFromStart = 11;
            else if (rxByteList[12] == 0 && rxByteList[13] == 0 && rxByteList[14] == 0)
                moveBitsFromStart = 12;

            for (int checkPointNo = 0; checkPointNo < 50; checkPointNo++)
            {
                Console.WriteLine("Move bits = " + moveBitsFromStart);
                var checkPointDataPosition = 3 * checkPointNo + moveBitsFromStart;
                var codeN = rxByteList[checkPointDataPosition];
                var timeN = int.Parse(rxByteList[checkPointDataPosition + 2].ToString("X") + rxByteList[checkPointDataPosition + 1].ToString("X"), NumberStyles.HexNumber);

                Console.WriteLine(">>" + codeN);
                if (codeN == 100)
                    mtrResponse.FinalResult = timeN;
                checkPoints.Add(new MTRDataCheckPoint { CodeN = codeN, TimeN_s = timeN });
            }

            if (_lastEmitRead != mtrResponse.EmitCardNumber)
            {
                mtrResponse.CheckPoints = checkPoints;
                EmitDataMtrResponse = mtrResponse;
                OnEmitDataChanged();
            }
            else
            {
                _lastEmitRead = mtrResponse.EmitCardNumber;
            }
        }

        private MTRDataMessage ConvertDataStringToTypeData(MTRDataMessageString dataString)
        {
            var mtrData = new MTRDataMessage();
            try
            {
                mtrData.Preamble = int.Parse(dataString.Preamble); // Ensure the message start with preamble
                mtrData.PackageSize = int.Parse(dataString.PackageSize); // Packet size, should be 230 when datamessage
                mtrData.PackageType = dataString.PackageType[0]; // Packet type, should be M as MTR message
                mtrData.MtrSerialNo = int.Parse(dataString.MtrSerialNo); //serialNumber of the MTR reader
                mtrData.TimeStamp = DateTime.Parse(dataString.TimeStamp); // binary year, month day, hour, minute, second
                mtrData.Time_ms = long.Parse(dataString.Time_ms); // Time is not yet in use
                mtrData.PackageNo = int.Parse(dataString.PackageNo); // counter from 1 to up
                mtrData.CardId = int.Parse(dataString.CardId); // binary, least sign first
                // Next tree is used when data retrived from history
                //mtrData.ProductWeek = dataString.ProductWeek;
                //mtrData.ProductYear = dataString.ProductYear;
                //mtrData.ECardHeadSum = dataString.ECardHeadSum;

                foreach (string[] checkPonit_s in dataString.CheckPoints)
                {
                    var checkPoint = new MTRDataCheckPoint();
                    checkPoint.CodeN = int.Parse(checkPonit_s[0]);
                    checkPoint.TimeN_s = int.Parse(checkPonit_s[1]);
                    checkPoint.InfoField = checkPonit_s[2];
                    checkPoint.CheckSum = int.Parse(checkPonit_s[3]);
                    checkPoint.FillerNull = int.Parse(checkPonit_s[4]);
                    mtrData.CheckPoints.Add(checkPoint);
                }
            }
            catch (Exception)
            {
                return null;
            }

            return mtrData;
        }

        private bool CheckModulo(List<int> itemsToCheck)
        {
            var sum = 0;
            foreach (var item in itemsToCheck)
            {
                sum += item;
            }

            if (sum % 256 == 0) return true;
            return false;
        }

        private bool InitSerialPort()
        {
            // LOGException serialPort.IsOpen
            if (_serialPort != null && _serialPort.IsOpen)
                return true;

            // LOGException serialPort.IsOpen
            var serialPortNames = SerialPort.GetPortNames().ToArray();
            // TODO logging
            //Logger.AddMessageToLogQueue(@"Found serial ports: " + string.Join(@", ", serialPortNames));
            //Logger.FlushLogQueue();
            if (serialPortNames.Length < 1)
            {
                return false;
            }

            //try opening ports starting from highest port
            var success = false;
            for (var portIndex = serialPortNames.Length - 1; portIndex >= 0 && !success; portIndex--)
            {
                // LOGException new serialPort instance
                _serialPort = new SerialPort(serialPortNames[portIndex])
                {
                    BaudRate = ComSettingsMTR.BaudRate,
                    DataBits = ComSettingsMTR.DataBits,
                    Parity = ComSettingsMTR.Parity,
                    StopBits = ComSettingsMTR.StopBits,
                };
                try
                {
                    // LOGException serialPort.Open / IsOpen
                    _serialPort.DtrEnable = true;
                    _serialPort.Open();
                    if (_serialPort.IsOpen)
                    {
                        _serialPort.DataReceived += DataReceivedMTR;
                        //_serialPort.ErrorReceived += SerialPortErrorReceived; // TODO Need some error handling

                        success = true;
                    }
                    if (!success && _serialPort.IsOpen)
                    {
                        // LOGException serialPort.Close
                        _serialPort.Close();
                    }
                }
                catch (Exception)
                {
                    success = false;
                }
            }
            return success;
        }


        private void SaveToFile()
        {
            var serializerObj4 = new XmlSerializer(typeof(List<int>));
            TextWriter writeFileStream4 = new StreamWriter(@"C:\Users\Public\temp.xml");
            serializerObj4.Serialize(writeFileStream4, buffer);
            writeFileStream4.Close();
        }
        private MTRCommandEventArgs CreateInfoArgs(string message)
        {
            return new MTRCommandEventArgs
            {
                Identifier = @"INFO",
                Command = string.Empty,
                Data = message,
                DebugText = "debug data"
            };
        }
    }
}

