using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Net;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using System.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace USBRead
{
    public partial class MainMenu : Form
    {

        static SerialPort mySerialPort;
        private bool _stop;
        public string ActiveUsbPort;
        public string ecardRead;
        private bool _ecardfound;
        private bool _serialportfound;
        private bool _fileloaded = false;
        public static string SetValueForEmitag;
        public static string SetValueForLopsid;
        public static string SetValueForLopsNavn;


        public MainMenu()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        public string StartlistFilename;
        public string messageText;
 
        private void button1_Click(object sender, EventArgs e)
        {
            SerialPortProgram usb = new SerialPortProgram(messageText);
            //UsbOutText.Text = messageText;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Read a keys from the config file            
            lopsid_box.Text = ConfigurationManager.AppSettings.Get("lopid");
            lopsnavn_box.Text = ConfigurationManager.AppSettings.Get("lopnavn");

            //Starter klokke
            t.Interval = 1000; //Tidsintervall for klokke
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();

            string[] ports = SerialPort.GetPortNames();
            if (ports != null && ports.Length != 0)
            {
                UsbPort_listBox.Items.AddRange(ports);
                UsbPort_listBox.SelectedIndex = 0;
                _serialportfound = true;
            }
            else
            {
                UsbPort_listBox.Items.Add("COM-port ikke funnet");
                _serialportfound = false;
            }
            Close_btn.Enabled = true;
        }


        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            Clock_lbl.Text = time;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //Velger ønsket Usb Port
        {
            ActiveUsbPort = UsbPort_listBox.GetItemText(UsbPort_listBox.SelectedItem);
        }

        private void RefreshUsbPort_btn_Click(object sender, EventArgs e) //Oppdaterer Usb Port-liste
        {
            UsbPort_listBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            if (ports != null && ports.Length != 0)
            {
                _serialportfound = true;
                UsbPort_listBox.Items.AddRange(ports);
                UsbPort_listBox.SelectedIndex = 0;
            }
            else
            {
                _serialportfound = false;
                UsbPort_listBox.Items.Add("COM-port ikke funnet");
            }
            //Close_btn.Enabled = false;
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            if (_stop == false)
            {
                MessageBox.Show("Stopp kommunikasjon før program avsluttes!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _stop = true;
                if (_serialportfound == true)
                {
                    try
                    {
                        mySerialPort.Close();
                    }
                    catch
                    {
                    }
                }
            }

            //Update config file when exit
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection app = config.AppSettings;
            config.AppSettings.Settings["lopid"].Value = lopsid_box.Text;
            config.AppSettings.Settings["lopnavn"].Value = lopsnavn_box.Text;
            config.Save(ConfigurationSaveMode.Modified);

            System.Windows.Forms.Application.ExitThread(); 
            this.Close();
        }


        private void ReadUsb_btn_Click(object sender, EventArgs e)
        {
            if (ActiveUsbPort == null)
            {
                MessageBox.Show("Brikkeleser ikke funnet! Koble til brikkeleser og trykk 'Oppfrisk'", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ReadUsb_btn.Text == "Start")
                {
                    ReadUsb_btn.Text = "Stop";
                    UsbRead_listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm:ss") + "  Open Communication");
                    _stop = false;
                    SerialPortProgram2();
                }
                else
                {
                    ReadUsb_btn.Text = "Start";
                    UsbRead_listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm:ss") + "  Communication Closed");
                    _stop = true;
                }
            }
        }

          
        private void ReadStartList_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        StartlistFilename = ofd.FileName;
                        dataGridView1.DataSource = ReadCsv();
                        _fileloaded = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _fileloaded = false;
            }
        }

        public DataTable ReadCsv()
        {
            DataTable ds = new DataTable("Data");
            var connString = string.Format(@"Provider=Microsoft.Jet.OleDb.4.0; Data Source={0};Extended Properties=""Text;HDR=YES;FMT=Delimited""",
                                            Path.GetDirectoryName(StartlistFilename));
            using (var cn = new OleDbConnection(connString))
            {
                cn.Open();
                var query = "SELECT * FROM [" + Path.GetFileName(StartlistFilename) + "]";
                using (var adapter = new OleDbDataAdapter(query, cn))
                {
                    adapter.Fill(ds);
                }
            }
            return ds;
        }

        private void SearchCard_btn_Click(object sender, EventArgs e)
        {
            if (SearchCard_Txtbox.Text != "")
            { 
                if (dataGridView1.Rows.Count > 1 && dataGridView1.Rows != null)
                {
                    string expression;
                    expression = SearchCard_Txtbox.Text;
                    SearchEcard(expression);
                }
                else
                {
                    MessageBox.Show("Les inn startliste!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Brikkefelt er tomt!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchEcard(string _ecardNo)
        {
            // Get the DataTable of a DataSet.
            DataTable csvTable;
            csvTable = ReadCsv();

            Boolean EcardFoundOK = false;
            DataRow[] foundRows;

            // Use the Select method to find all rows matching the filter.
            foundRows = csvTable.Select("ecard =" + _ecardNo);
            if (foundRows.Length > 0)
            {
                EcardFoundOK = true;
            }

            if (EcardFoundOK == false)
            {
                foundRows = csvTable.Select("ecard2 =" + _ecardNo);
                if (foundRows.Length > 0) EcardFoundOK = true;
            }

            if (EcardFoundOK == true)
            {

                for (int i = 0; i < foundRows.Length; i++)
                {
                    var StartNr = foundRows[i][7];
                    var Fornavn = foundRows[i][1];
                    var Etternavn = foundRows[i][2];
                    var Klubb = foundRows[i][4];
                    var Klasse = foundRows[i][3];
                    var Ecard1 = foundRows[i][5];
                    var Ecard2 = foundRows[i][6];

                    if (StartNr_box != null && !StartNr_box.IsDisposed)
                    {
                        StartNr_box.BeginInvoke(new MethodInvoker(delegate
                        {
                            StartNr_box.Text = StartNr.ToString();
                        }));
                    }
                    if (Navn_box != null && !Navn_box.IsDisposed)
                    {
                        Navn_box.BeginInvoke(new MethodInvoker(delegate
                        {
                            Navn_box.Text = Fornavn.ToString() + " " + Etternavn.ToString();
                        }));
                    }
                    if (Klubb_box != null && !Klubb_box.IsDisposed)
                    {
                        Klubb_box.BeginInvoke(new MethodInvoker(delegate
                        {
                            Klubb_box.Text = Klubb.ToString();
                        }));
                    }
                    if (Klasse_box != null && !Klasse_box.IsDisposed)
                    {
                        Klasse_box.BeginInvoke(new MethodInvoker(delegate
                        {
                            Klasse_box.Text = Klasse.ToString();
                        }));
                    }
                    if (Ecard_box != null && !Ecard_box.IsDisposed)
                    {
                        Ecard_box.BeginInvoke(new MethodInvoker(delegate
                        {
                            Ecard_box.Text = Ecard1.ToString();
                        }));
                    }
                    if (Ecard2_box != null && !Ecard2_box.IsDisposed)
                    {
                        Ecard2_box.BeginInvoke(new MethodInvoker(delegate
                        {
                            Ecard2_box.Text = Ecard2.ToString();
                        }));
                    }
               }
            }
            else
            {
                UnknownEcard(_ecardNo);
           }
        }

        private void UnknownEcard(string ecardname)
        {
            if (StartNr_box != null && !StartNr_box.IsDisposed)
            {
                StartNr_box.BeginInvoke(new MethodInvoker(delegate
                {
                    StartNr_box.Text = "XX";
                }));
            }
            if (Ecard_box != null && !Ecard_box.IsDisposed)
            {
                Ecard_box.BeginInvoke(new MethodInvoker(delegate
                {
                    Ecard_box.Text = ecardname;
                }));
            }

            if (Navn_box != null && !Navn_box.IsDisposed)
            {
                Navn_box.BeginInvoke(new MethodInvoker(delegate
                {
                    Navn_box.Text = "Ukjent brikke";
                    if (File.Exists(@"c:\temp\ringout.wav"))
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\temp\ringout.wav");
                        player.Play();
                    }
                }));
            }

        }

        public void SerialPortProgram2()
        {
            _ecardfound = false;
            Thread readThreadUsb = new Thread(ReadUsb);
            readThreadUsb.Start();
        }

        public void ReadUsb()
        {
            mySerialPort = new SerialPort();
            mySerialPort.PortName = ActiveUsbPort;
            mySerialPort.BaudRate = 115200;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.RtsEnable = false;
            mySerialPort.DtrEnable = true;
            mySerialPort.ReadTimeout = 5000;
            mySerialPort.WriteTimeout = 200;
            mySerialPort.Open();

            while (!_stop)
            {
                try
                {
                    string usbMessage = mySerialPort.ReadLine();
                    //Console.WriteLine(usbMessage);
                    EmitagParser(usbMessage);
                    if (_ecardfound == true && _fileloaded == true)
                    {
                        usbMessage = ecardRead;
                        SearchEcard(ecardRead);
                        _ecardfound = false;
                    }
                    if (_ecardfound == true && _fileloaded == false)
                    {
                        usbMessage = ecardRead;
                        UnknownEcard(ecardRead);
                        _ecardfound = false;
                    }

                    if (!this.IsHandleCreated)
                    {
                        this.CreateHandle();
                    }

                    if (UsbRead_listBox != null && !UsbRead_listBox.IsDisposed)
                    {
                        UsbRead_listBox.BeginInvoke(new MethodInvoker(delegate
                        {
                            UsbRead_listBox.Items.Insert(0, DateTime.Now.ToString("HH:mm:ss") + " " + usbMessage);
                        }));
                    }
                    else
                    {
                        
                    }
                }
                catch (TimeoutException) {
                    Console.WriteLine("USB read timed out. Check the flux capacitor");
                }
                Thread.Sleep(100);
            }
            mySerialPort.Close();
        }

        private void UnknownEcard_btn_Click_1(object sender, EventArgs e)
        {
            SetValueForEmitag = Ecard_box.Text;
            SetValueForLopsid = lopsid_box.Text;
            SetValueForLopsNavn = lopsnavn_box.Text;
            SendMessage_form f2 = new SendMessage_form();
            f2.Show();
        }
 
        public void EmitagParser(string ecbMessage)
        {
            //Statusmelding fra ECU (ikke lest brikke):
            //IECU - HW1 - SW5 - V1.72  M1 - 103  Y878100473 W12:00:42.216   C253 X7
            //Brikke lest fra ECU:
            //D-02 05	N3903382	Y878100473	W12:00:36.391	V301-2082	S3903382	RemiTag II	L0112	X7

            string[] ecbText = ecbMessage.Split(new[] { "\t" }, StringSplitOptions.None);

            foreach (string s in ecbText)
            {
                char type = s[0];
                string info = s.Substring(1);
                switch (type)
                {
                    case 'M':
                    {           // number of messages today
                            ecardRead = ecbMessage;
                            break;
                    }
                    case 'I':
                    {           // unit info (HW/SW)
                        ecardRead = info;
                        break;
                    }
                    case 'N':
                    {          // EmiTag-No
                        ecardRead = info;
                        _ecardfound = true;
                        break;
                    }
                    case 'W':
                    {           // Clock - when the message was sent
                        break;
                    }
                    case 'A':
                    { // unit health
                        break;
                    }
                    case 'V':
                    {   //EmitagInternalInfo
                        break;
                    }
                }
            }
        }
        public void Read250()
        {
            mySerialPort = new SerialPort();
            mySerialPort.PortName = ActiveUsbPort;
            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.RtsEnable = false;
            mySerialPort.DtrEnable = true;
            mySerialPort.ReadTimeout = 7000;
            mySerialPort.WriteTimeout = 200;
            mySerialPort.Open();

            while (!_stop)
            {
                try
                {
                    int length = mySerialPort.BytesToRead;
                    byte[] buf = new byte[length];

                    mySerialPort.Read(buf, 0, length);
                    System.Diagnostics.Debug.WriteLine("Received Data:" + buf);



                    //byte[] data = new byte[mySerialPort.BytesToRead];
                    //mySerialPort.Read(data, 0, data.Length);
                    //string usbMessage = Encoding.UTF32.GetString(data, 0, data.Length);

                    //string usbMessage = data.ToString();
                    //Console.WriteLine(usbMessage);
                }
                catch (TimeoutException)
                {
                    Console.WriteLine("USB read timed out. Check the flux capacitor");
                    mySerialPort.Close();
                }
            }
            mySerialPort.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Read250();
        }

        public class Startliste
        {
            public string bib;
            public string name;
            public string club;
            public string klasse;
            public string ecard1;
            public string ecard2;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            WebClient client = new WebClient();
            string downloadString = client.DownloadString("http://api.freidig.idrett.no/api.php?method=getrunners&comp=10002");

            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(downloadString);
            DataTable dataTable = dataSet.Tables["runners"];
            Console.WriteLine(dataTable.Rows.Count);

            //DataTable dtValue = (DataTable)JsonConvert.DeserializeObject(downloadString, (typeof(DataTable)));
            //var data = JsonConvert.DeserializeObject<DataTable>(downloadString);
            //DataTable dataTable = data.["Runners"];
 
        }
    }
}