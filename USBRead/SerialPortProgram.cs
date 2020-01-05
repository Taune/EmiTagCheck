using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.Diagnostics;

namespace USBRead
{
    class SerialPortProgram
    {

        public SerialPortProgram(string mActiveUsb)
        {
            SerialPort mySerialPort = new SerialPort(mActiveUsb);

            mySerialPort.BaudRate = 115200;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.RtsEnable = true;
            mySerialPort.DtrEnable = true;

            //mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            mySerialPort.Open();
            MainMenu mnu = new MainMenu();

            //mnu.UsbOut
            //  ActiveUsbPort = ("Open comm....\n");

            int count = 0;
            string tempdata;
            string Test11 = " ";

            do
            {
                tempdata = mySerialPort.ReadLine();

                Debug.Print(Convert.ToString(tempdata));
                mnu.UpdateTextBox(Convert.ToString(tempdata));
                EmitagMessage(tempdata, Test11);
                count++;
            }
            while (count < 10);

            mySerialPort.Close();
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Debug.Print("Data Received:");
            Debug.Print(indata);
            MainMenu mnu = new MainMenu();
            mnu.ActiveUsbPort = indata;

        }

        public void EmitagMessage(string ecbMessage, string ecbReturn)
        {
            //Statusmelding fra ECU (ikke lest brikke):
            //IECU - HW1 - SW5 - V1.72  M1 - 103  Y878100473 W12:00:42.216   C253 X7
            //Brikke lest fra ECU:
            //D-02 05	N3903382	Y878100473	W12:00:36.391	V301-2082	S3903382	RemiTag II	L0112	X7
            int AntallFelt;

            string[] ecbText = ecbMessage.Split(new[] { "\t" }, StringSplitOptions.None);
            AntallFelt = ecbText.Length;

            foreach (string s in ecbText)
            {
                Debug.Print(s);
                parseMessage(s, ecbReturn);
            }

        }

        void parseMessage(string m, string ecbTextReturn)
        {
            char type = m[0];
            string info = m.Substring(1);

            switch (type)
            {
                case 'N':
                    {          // EmiTag-No
                        ecbTextReturn = info;
                        break;
                    }
                case 'W':
                    {           // Clock - when the message was sent
                        ecbTextReturn = info;
                        break;
                    }

            }
        }
    }
}
 