using System;
using System.Text;
using System.IO.Ports;
using System.Collections.Generic;
using MTRSerial.ValueObjects;
using MTRSerial;

namespace USBRead
{
    class SerialPortManager : IDisposable
    {
        ~SerialPortManager()
        {
            Dispose(false);
        }

        #region Fields
        public SerialPort _serialPortA;
        public SerialPort _serialPortB;
        private string _latestRecieved = String.Empty;
        public event EventHandler<SerialDataEventArgs> NewSerialDataRecievedECU;
        public event EventHandler<SerialDataEventArgs> NewSerialDataRecievedMTR;
        private const int xorDF = 223; // Hexadecimal = "DF";
        private List<int> buffer = new List<int>();
        //public event EventHandler<MTRCommandEventArgs> MTRCommunication;
        #endregion


        void _serialPort_DataReceivedMTR(object sender, SerialDataReceivedEventArgs e)
        {
            int lastReadByte = 0;
            var startFound = false;
            var stopReading = false;
            //string data = _serialPortB.ReadLine();

            while (stopReading == false)
            {
                try
                {
                    var readByteXor = _serialPortB.ReadByte() ^ xorDF;

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
            byte[] _InputBytes = Encoding.ASCII.GetBytes("hei");

            ParseRxString(buffer);
            // Send data to whom ever interested
            if (NewSerialDataRecievedMTR != null)
                NewSerialDataRecievedMTR(this, new SerialDataEventArgs(_InputBytes));

            buffer.Clear();
        }

        void _serialPort_DataReceivedECU(object sender, SerialDataReceivedEventArgs e)
        {
            int dataLength = _serialPortA.BytesToRead;
            string data = _serialPortA.ReadLine();
            char[] charsToTrim = { ' ', '\'', '\u0003' };
            string strTrim = data.Trim(charsToTrim);

            byte[] _InputBytes = Encoding.ASCII.GetBytes(data);
 
            // Send data to whom ever interested
            if (NewSerialDataRecievedECU != null)
                NewSerialDataRecievedECU(this, new SerialDataEventArgs(_InputBytes));
        }

        /// Connects to a serial port for ECU. Settings defind in ComSettings
        public void StartListeningECU()
        {
            // Closing serial port if it is open
            if (_serialPortA != null && _serialPortA.IsOpen)
                _serialPortA.Close();

            // Setting serial port settings
            _serialPortA = new SerialPort();
            _serialPortA.PortName = MainMenu.ActiveUsbPort;
            _serialPortA.BaudRate = ComSettingsECU.BaudRate;
            _serialPortA.Parity = ComSettingsECU.Parity;
            _serialPortA.StopBits = ComSettingsECU.StopBits;
            _serialPortA.DataBits = ComSettingsECU.DataBits;
            _serialPortA.Handshake = ComSettingsECU.hShake;

            // Subscribe to event and open serial port for data
            _serialPortA.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceivedECU);
            _serialPortA.Open();
        }

        /// Connects to a serial port for MTR. Settings defind in ComSettings
        public void StartListeningMTR()
        {
            // Closing serial port if it is open
            if (_serialPortB != null && _serialPortB.IsOpen)
                _serialPortB.Close();

            // Setting serial port settings
            _serialPortB = new SerialPort();
            _serialPortB.PortName = MainMenu.ActiveUsbPort;
            _serialPortB.BaudRate = ComSettingsMTR.BaudRate;
            _serialPortB.Parity = ComSettingsMTR.Parity;
            _serialPortB.StopBits = ComSettingsMTR.StopBits;
            _serialPortB.DataBits = ComSettingsMTR.DataBits;
            _serialPortB.Handshake = ComSettingsMTR.hShake;

            // Subscribe to event and open serial port for data
            _serialPortB.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceivedMTR);
            _serialPortB.Open();
        }

        // Closes the serial port
        public void StopListeningECU()
        {
            _serialPortA.Close();
        }

        public void StopListeningMTR()
        {
            _serialPortB.Close();
        }

        // Call to release serial port
        public void Dispose()
        {
                Dispose(true);
        }

        // Part of basic design pattern for implementing Dispose
        protected virtual void Dispose(bool disposing)
        {
            if (disposing) 
            {    
                try 
                {_serialPortA.DataReceived -= new SerialDataReceivedEventHandler(_serialPort_DataReceivedECU);}
                catch 
                { }
            }
            // Releasing serial port (and other unmanaged objects)
            if (_serialPortA != null)
            {
                if (_serialPortA.IsOpen)
                    _serialPortA.Close();

                _serialPortA.Dispose();
            }
        }

        private void ParseRxString(List<int> rxByteList)
        {
            if (rxByteList.Count <= 1)
            {
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
                    //if (MTRCommunication != null)
                    //{
                    //    var eventArgs = new MTRCommandEventArgs { Command = cmd.ToString(), Data = data, Identifier = @"IN", DebugText = "debug" };
                    //    MTRCommunication(this, eventArgs);
                    //}

                    switch (cmd)
                    {
                        case 77: // 'M':
                            if (rxByteList.Count < 230 || size != 230) return;
                            HandleMTRDataMessage(data);
                            break;
                        case 83: //'S':
                            if (rxByteList.Count < 59 || size != 59) return;
                            //HandleMTRStatusMessage(data);
                            break;
                        default:
                            //IncreaseCommunicationErrorsCount();
                            break;
                    }
                }
                else
                {
                    if (rxByteList.Count < 217) return;
                    //HandleMTRResponseMessage(rxByteList);
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

            //List<MTRDataCheckPoint> checkPoints = new List<MTRDataCheckPoint>();

            //for (int checkPointNo = 0; checkPointNo < 50; checkPointNo++)
            //{
            //    var checkPointDataPosition = 61 * checkPointNo;
            //    var checkPoint = new MTRDataCheckPoint();
            //    var codeN = data.Substring(100 + checkPointDataPosition, 1);
            //    var timeN = data.Substring(102 + checkPointDataPosition, 2);
            //    var info = data.Substring(103 + checkPointDataPosition, 56);
            //    var checkSum = data.Substring(159 + checkPointDataPosition, 1);
            //    var filler = data.Substring(160 + checkPointDataPosition, 1);

            //    MTRDataStrings.CheckPoints.Add(new[] { codeN, timeN, info, checkSum, filler });
            //}

            //HER MÅ DET INN EN LINK TIL if (NewSerialDataRecieved != null)
            //NewSerialDataRecieved(this, new SerialDataEventArgs(_InputBytes));
            //var mtrData = ConvertDataStringToTypeData(MTRDataStrings);
            //var listDatas = new List<MTRData>();
            //listDatas.Add(mtrData);
            //WriteValuesToFile(listDatas);
        }
    }

    // EventArgs used to send bytes recieved on serial port
    public class SerialDataEventArgs : EventArgs
    {
        public SerialDataEventArgs(byte[] dataInByteArray)
        {
            Data = dataInByteArray;
        }

        /// Byte array containing data from serial port
        public byte[] Data;
    }


}
