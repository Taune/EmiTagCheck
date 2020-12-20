using System;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections.Generic;
using MTRSerial.ValueObjects;
using System.Threading.Tasks;
using System.Threading;

namespace Brikkesjekk
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
        private List<int> message = new List<int>();
        private List<int> message_start = new List<int>();
        private string msgObj = "0";
        public bool _MtrEcardfound;
        #endregion

        void _serialPort_DataReceivedMTR(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(300);
            int dataLength = _serialPortB.BytesToRead;
            byte[] data = new byte[dataLength];
            int nbrDataRead = _serialPortB.Read(data, 0, dataLength);

            for (int i = 0; i < dataLength; i++)
            {
                if (message_start.Count < 4)
                {
                    if (data[i] == 0xFF)
                    {
                        message_start.Add(data[i]);
                    }
                    else
                    {
                        message_start.Clear();
                    }
                }
                else
                {
                    message.Add(data[i]);
                    if (message[0] == message.Count)
                    {
                        mtrParseMsg(message);
                        message_start.Clear();
                        message.Clear();
                    }
                }
            }
            byte[] _InputBytes1 = Encoding.ASCII.GetBytes(msgObj);

            // Send data to whom ever interested
            if (NewSerialDataRecievedMTR != null)
                NewSerialDataRecievedMTR(this, new SerialDataEventArgs(_InputBytes1));
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

            try 
            { 
                // Setting serial port settings
                _serialPortA = new SerialPort();
                _serialPortA.PortName = MainMenu.ActiveUsbPort;
                _serialPortA.BaudRate = ComSettingsECU.BaudRate;
                _serialPortA.Parity = ComSettingsECU.Parity;
                _serialPortA.StopBits = ComSettingsECU.StopBits;
                _serialPortA.DataBits = ComSettingsECU.DataBits;
                _serialPortA.Handshake = ComSettingsECU.hShake;
                MainMenu.ECUComPortOpen = MainMenu.ActiveUsbPort;

                // Subscribe to event and open serial port for data
                _serialPortA.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceivedECU);
                _serialPortA.Open();
            }
            catch 
            {
                MessageBox.Show("COM-port " + MainMenu.ActiveUsbPort + " i bruk. Velg annen COM-port!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// Connects to a serial port for MTR. Settings defind in ComSettings
        public void StartListeningMTR()
        {
            // Closing serial port if it is open
            if (_serialPortB != null && _serialPortB.IsOpen)
                _serialPortB.Close();

            try
            { 
                // Setting serial port settings
                _serialPortB = new SerialPort();
                _serialPortB.PortName = MainMenu.ActiveUsbPort;
                _serialPortB.BaudRate = ComSettingsMTR.BaudRate;
                _serialPortB.Parity = ComSettingsMTR.Parity;
                _serialPortB.StopBits = ComSettingsMTR.StopBits;
                _serialPortB.DataBits = ComSettingsMTR.DataBits;
                _serialPortB.Handshake = ComSettingsMTR.hShake;
                _serialPortB.RtsEnable = true;
                MainMenu.MTRComPortOpen = MainMenu.ActiveUsbPort;

                // Subscribe to event and open serial port for data
                _serialPortB.Open();
                _serialPortB.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceivedMTR);
            }
            catch
            {
                MessageBox.Show("COM-port " + MainMenu.ActiveUsbPort + " i bruk. Velg annen COM-port!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                { _serialPortA.DataReceived -= new SerialDataReceivedEventHandler(_serialPort_DataReceivedECU); }
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

        void mtrParseMsg(List<int> msg)
        {
            _MtrEcardfound = false;
            int MtrEcardNo = 0;
            int checksum = 0xFF + 0xFF + 0xFF + 0xFF;

            for (int j = 0; j < (msg.Count - 2); j++)
            {
                checksum += msg[j];
            }
            checksum %= 256;

            if (checksum == msg[msg.Count - 2])
            {
                MtrEcardNo = msg[16] + (msg[17] * 256) + (msg[18] * 256 * 256);
                _MtrEcardfound = true;
            }
            else
            {
                MtrEcardNo = 0;
            }
            //return msgObj; 
            msgObj = MtrEcardNo.ToString();

        }


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