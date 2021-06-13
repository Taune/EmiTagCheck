using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Net;
using System.Windows.Forms;
using System.Drawing;
using System.Data.OleDb;
using System.IO;
using System.Threading;
using System.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Speech;
using System.Speech.Synthesis;



namespace Brikkesjekk
{
    public partial class MainMenu : Form
    {
        private bool _stop;
        private bool _stopLiveRes;
        public static string ActiveUsbPort;
        public static string MTRComPortOpen = "";
        public static string ECUComPortOpen = "";
        public string NavnScrollInfo = "";
        public string ecardRead;
        public bool _ecardfound;
        public bool _serialportfound;
        private bool _fileloaded = false;
        public static string SetValueForEmitag;
        public static string SetValueForLopsid;
        public static string SetValueForLopsNavn;
        public static string SetValueForStartNo;
        public static string SetValueForID;
        public string _LogfileName;
        public string _LiveResfileName;
        public double _batterylevel;
        public Color _batterycolor;
        public string _EcuCode;
        public string StartlistFilename;
        private int _blink = 0;
        DataTable GridTable = new DataTable();
        SerialPortManager _spManager;
        SpeechSynthesizer SpeechReader = new SpeechSynthesizer();

        public class Competition
        {
            public int id { get; set; }
            public string name { get; set; }
            public string organizer { get; set; }
            public string date { get; set; }
            public int timediff { get; set; }
            public int multidaystage { get; set; }
            public int multidayfirstday { get; set; }
        }

        public class RootObject
        {
            public List<Competition> competitions { get; set; }
        }

        public MainMenu()
        {
            InitializeComponent();
            UserInitialization();
        }

        private void UserInitialization()
        {
            _spManager = new SerialPortManager();
            _spManager.NewSerialDataRecievedECU += new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecievedECU);
            _spManager.NewSerialDataRecievedMTR += new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecievedMTR);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyEvent);
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Update config file when exit
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection app = config.AppSettings;
            config.AppSettings.Settings["lopid"].Value = lopsid_box.Text;
            config.AppSettings.Settings["lopnavn"].Value = lopsnavn_box.Text;
            config.AppSettings.Settings["logfolder"].Value = folderLogfile_box.Text;
            config.AppSettings.Settings["liveresCheckBox"].Value = LiveRes_checkBox.Checked.ToString();
            config.AppSettings.Settings["SoundCheckBox_NotFound"].Value = WarningSoundNotFound_checkBox.Checked.ToString();
            config.AppSettings.Settings["SoundCheckBox_Found"].Value = WarningSoundFound_checkBox.Checked.ToString();
            config.AppSettings.Settings["TextToSpeechBox"].Value = TextToSpeechFound_checkBox.Checked.ToString();
            config.Save(ConfigurationSaveMode.Modified);

            if (_serialportfound == true)
            {
                _spManager.Dispose();
            }
            else
            {
            }

            //this.Close();
        }

        private void KeyEvent(object sender, KeyEventArgs e) //Keyup Event 
        {

            if (e.KeyCode == Keys.F2)
            {
                StartNr_box.Select();
            }
            if (e.KeyCode == Keys.F3)
            {
                ChangeEcardNo_btn.PerformClick();
            }
        }
        void _spManager_NewSerialDataRecievedECU(object sender, SerialDataEventArgs e)
        {
            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecievedECU), new object[] { sender, e });
                return;
            }
            string strMessage = Encoding.ASCII.GetString(e.Data);

            EmitagParser(strMessage);
            if (_ecardfound == true && _fileloaded == true)
            {
                strMessage = ecardRead;
                SearchEcard(ecardRead);
                UsbRead_listBox.Items.Insert(0, "ECU - " + DateTime.Now.ToString("HH:mm:ss") + " " + strMessage + NavnScrollInfo);
                _ecardfound = false;
            }
            if (_ecardfound == true && _fileloaded == false)
            {
                strMessage = ecardRead;
                UnknownEcard(ecardRead);
                UsbRead_listBox.Items.Insert(0, "ECU - " + DateTime.Now.ToString("HH:mm:ss") + " " + strMessage + " - brikkesjekkfil ikke lest");
                _ecardfound = false;
            }
        }

        void _spManager_NewSerialDataRecievedMTR(object sender, SerialDataEventArgs e)
        {

            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecievedMTR), new object[] { sender, e });
                return;
            }
            string strMessage = Encoding.ASCII.GetString(e.Data);

            if (_spManager._MtrEcardfound == true && _fileloaded == true)
            {
                //strMessage = ecardRead;
                SearchEcard(strMessage);
                UsbRead_listBox.Items.Insert(0, "MTR - " + DateTime.Now.ToString("HH:mm:ss") + " " + strMessage + NavnScrollInfo);
                _spManager._MtrEcardfound = false;
            }
            if (_spManager._MtrEcardfound == true && _fileloaded == false)
            {
                //strMessage = ecardRead;
                UnknownEcard(strMessage);
                UsbRead_listBox.Items.Insert(0, "MTR - " + DateTime.Now.ToString("HH:mm:ss") + " " + strMessage + " - brikkesjekkfil ikke lest");
                _spManager._MtrEcardfound = false;
            }
        }

        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        // Start listening to the ECU-unit
        private void btnStartECU_Click(object sender, EventArgs e)
        {
            if (ActiveUsbPort == null)
            {
                MessageBox.Show("Brikkeleser ikke funnet! Koble til brikkeleser og trykk 'Oppfrisk'", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (ReadEcu_btn.Text == "Start ECU")
                {
                    //Check if COM-port already opened
                    if (MTRComPortOpen == ActiveUsbPort)
                    {
                        MessageBox.Show("COM-port " + ActiveUsbPort + " i bruk. Velg annen COM-port!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        ReadEcu_btn.Text = "Stop ECU";
                        //ReadEcu_btn.BackColor = Color.LightGreen;
                        UsbRead_listBox.Items.Insert(0, "ECU - " + DateTime.Now.ToString("HH:mm:ss") + "  Open Communication");
                        ECU_read_led.Color = Color.FromArgb(153, 255, 54); //LightGreen
                        ECU_read_led_blink(ECU_read_led, new EventArgs());
                        _spManager.StartListeningECU();
                        _stop = false;
                        
                    }
                }
                else
                {
                    ReadEcu_btn.Text = "Start ECU";
                    //ReadEcu_btn.BackColor = Color.LightCoral;
                    _spManager.StopListeningECU();
                    UsbRead_listBox.Items.Insert(0, "ECU - " + DateTime.Now.ToString("HH:mm:ss") + "  Communication Closed");
                    _stop = true;
                    ECUComPortOpen = "";
                    ECU_read_led.Color = Color.Red;
                    ECU_read_led_blink(ECU_read_led, new EventArgs());
                    ECU_read_led.On = true;
                }
            }

            if (dataGridView1.Rows.Count < 1 && ReadEcu_btn.Text == "Stop ECU")
            {
                MessageBox.Show("Startliste er ikke lest inn!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReadMTR_Click(object sender, EventArgs e) //Read MTR
        {
            if (ActiveUsbPort == null)
            {
                MessageBox.Show("Brikkeleser ikke funnet! Koble til brikkeleser og trykk 'Oppfrisk'", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (btnStartMTR.Text == "Start MTR")
                {
                    //Check if COM-port already opened 
                    if (ECUComPortOpen == ActiveUsbPort)
                    {
                        MessageBox.Show("COM-port " + ActiveUsbPort + " i bruk. Velg annen COM-port!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        btnStartMTR.Text = "Stop MTR";
                        //btnStartMTR.BackColor = Color.LightGreen;
                        UsbRead_listBox.Items.Insert(0, "MTR - " + DateTime.Now.ToString("HH:mm:ss") + "  Open Communication");
                        MTR_read_led.Color = Color.FromArgb(153, 255, 54); //LightGreen
                        MTR_read_led_Click(MTR_read_led, new EventArgs());
                        _spManager.StartListeningMTR();
                        _stop = false;
                    }
                }
                else
                {
                    btnStartMTR.Text = "Start MTR";
                    //btnStartMTR.BackColor = Color.LightCoral;
                    _spManager.StopListeningMTR();
                    UsbRead_listBox.Items.Insert(0, "MTR - " + DateTime.Now.ToString("HH:mm:ss") + "  Communication Closed");
                    MTRComPortOpen = "";
                    _stop = true;
                    MTR_read_led.Color = Color.Red;
                    MTR_read_led_Click(MTR_read_led, new EventArgs());
                    MTR_read_led.On = true;
                }
            }
            if (dataGridView1.Rows.Count < 1 && btnStartMTR.Text == "Stop MTR")
            {
                MessageBox.Show("Startliste er ikke lest inn!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            bool _LiveRes = true;
            bool _SoundOnNotFound = true;
            bool _SoundOnFound = true;
            bool _TextTSpeech = true;

            // Read a keys from the config file            
            lopsid_box.Text = ConfigurationManager.AppSettings.Get("lopid");
            lopsnavn_box.Text = ConfigurationManager.AppSettings.Get("lopnavn");
            folderLogfile_box.Text = ConfigurationManager.AppSettings.Get("logfolder");
            if (ConfigurationManager.AppSettings.Get("SoundCheckBox_Found") == "False")
            {
                _SoundOnFound = false;
            }
            WarningSoundFound_checkBox.Checked = _SoundOnFound;

            if (ConfigurationManager.AppSettings.Get("SoundCheckBox_NotFound") == "False")
            {
                _SoundOnNotFound= false;
            }
            WarningSoundNotFound_checkBox.Checked = _SoundOnNotFound;

            if (ConfigurationManager.AppSettings.Get("TextToSpeechBox") == "False")
            {
                _TextTSpeech = false;
            }
            TextToSpeechFound_checkBox.Checked = _TextTSpeech;

            if (ConfigurationManager.AppSettings.Get("liveresCheckBox") == "False")
            {
                _LiveRes = false;
            }
            LiveRes_checkBox.Checked = _LiveRes;
            if (LiveRes_checkBox.Checked == true)
            {
                ReadLiveResRaces();
                readLiveResfil_btn.Enabled = true;
                SendMessage_btn.Enabled = true;
                LiveRes_groupBox.Enabled = true;
                NotStared_btn.Enabled = true;
                ChangeEcardNo_btn.Enabled = true;
            }
            if (LiveRes_checkBox.Checked == false)
            {
                readLiveResfil_btn.Enabled = false;
                SendMessage_btn.Enabled = false;
                LiveRes_groupBox.Enabled = false;
                NotStared_btn.Enabled = false;
                ChangeEcardNo_btn.Enabled = false;
            }

            _stop = true;

            if (@folderLogfile_box.Text.Substring(@folderLogfile_box.Text.Length-1,1) != @"\")
            {
                _LogfileName = @folderLogfile_box.Text + @"\" + "brikkesjekk " + DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            }
            else
            {
                _LogfileName = @folderLogfile_box.Text + "brikkesjekk " + DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            }
            //Create a log-file for todays race
            if (!File.Exists(_LogfileName))
            {
                // Create a file to write to.
                try
                {
                    using (StreamWriter logfile = File.CreateText(_LogfileName))
                    {
                        logfile.WriteLine("Log created: " + DateTime.Now.ToString("HH:mm:ss"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //Starter klokke
            t.Interval = 700; //Tidsintervall for klokke
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

            if (hh < 10) { time += "0" + hh; }
            else { time += hh; }
            time += ":";

            if (mm < 10) { time += "0" + mm; }
            else { time += mm; }
            time += ":";

            if (ss < 10) { time += "0" + ss; }
            else { time += ss; }

            Clock_lbl.Text = time;

            //Lager blinkende knapp ved lesing av ECU og MTR
        //    if ((ReadEcu_btn.BackColor == SystemColors.ButtonHighlight) && (ReadEcu_btn.Text == "Stop ECU"))
        //    {
        //        ReadEcu_btn.BackColor = Color.LightGreen;
        //    }
        //    else
        //    {
        //        ReadEcu_btn.BackColor = SystemColors.ButtonHighlight;
        //    }
        //    if ((btnStartMTR.BackColor == SystemColors.ButtonHighlight) && (btnStartMTR.Text == "Stop MTR"))
        //    {
        //        btnStartMTR.BackColor = Color.LightGreen;
        //    }
        //    else
        //    {
        //        btnStartMTR.BackColor = SystemColors.ButtonHighlight; ;
        //    }
        }
         
        private void UsbPort_listBox_SelectedIndexChanged(object sender, EventArgs e) //Velger ønsket Usb Port
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

        private void Close_btn_Click(object sender, EventArgs e) //Close MainMenu form
        {
            if (_stop == false)
            {
                //                MessageBox.Show("Stopp kommunikasjon før program avsluttes!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                _stop = true;
                if (_serialportfound == true)
                {
                    Thread.Sleep(10); //Stops thread to ensure USB-reading is ended
                    try
                    {
                        _spManager.Dispose();
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
            config.AppSettings.Settings["logfolder"].Value = folderLogfile_box.Text;
            config.AppSettings.Settings["liveresCheckBox"].Value = LiveRes_checkBox.Checked.ToString();
            config.AppSettings.Settings["SoundCheckBox_NotFound"].Value = WarningSoundNotFound_checkBox.Checked.ToString();
            config.AppSettings.Settings["SoundCheckBox_Found"].Value = WarningSoundFound_checkBox.Checked.ToString();
            config.AppSettings.Settings["TextToSpeechBox"].Value = TextToSpeechFound_checkBox.Checked.ToString();
            config.Save(ConfigurationSaveMode.Modified);

            System.Windows.Forms.Application.ExitThread();
            this.Close();
        }

        private void SearchCard_btn_Click(object sender, EventArgs e) //Manually search after ecard number
        {
            if (SearchCard_Txtbox.Text != "")
            {
                if (dataGridView1.Rows.Count > 1 && dataGridView1.Rows != null)
                {
                    string expression;
                    expression = SearchCard_Txtbox.Text;
                    _batterylevel = 0;
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

        private void UnknownEcard(string ecardname) //Ecard not found - Write "Ukjent brikke"
        {
            ledBulb_funnet.On = true;
            ledBulb_funnet.Color = Color.Red;
            if (StartNr_box != null && !StartNr_box.IsDisposed)
            {
                StartNr_box.BeginInvoke(new MethodInvoker(delegate
                {
                    StartNr_box.ForeColor = Color.Red;
                    StartNr_box.Text = "XX";
                }));
            }
            if (Ecard_box != null && !Ecard_box.IsDisposed)
            {
                Ecard_box.BeginInvoke(new MethodInvoker(delegate
                {
                    Ecard_box.ForeColor = Color.Red;
                    Ecard_box.Text = ecardname;
                }));
            }
            if (SearchCard_Txtbox != null && !SearchCard_Txtbox.IsDisposed)
            {
                SearchCard_Txtbox.BeginInvoke(new MethodInvoker(delegate
                {
                    SearchCard_Txtbox.Text = ecardname;
                }));
            }
            if (Navn_box != null && !Navn_box.IsDisposed)
            {
                Navn_box.BeginInvoke(new MethodInvoker(delegate
                {
                    Navn_box.ForeColor = Color.Red;
                    Navn_box.Text = "Ukjent brikke";
                    if ((File.Exists(@"ukjentbrikke.wav")) && (WarningSoundNotFound_checkBox.Checked))
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"ukjentbrikke.wav");
                        player.Play();
                    }
                }));
            }
            if (Klubb_box != null && !Klubb_box.IsDisposed)
            {
                Klubb_box.BeginInvoke(new MethodInvoker(delegate
                {
                    Klubb_box.ForeColor = Color.Red;
                    Klubb_box.Text = "XX";
                }));
            }
            if (Klasse_box != null && !Klasse_box.IsDisposed)
            {
                Klasse_box.BeginInvoke(new MethodInvoker(delegate
                {
                    Klasse_box.ForeColor = Color.Red;
                    Klasse_box.Text = "XX";
                }));
            }
            if (Ecard2_box != null && !Ecard2_box.IsDisposed)
            {
                Ecard2_box.BeginInvoke(new MethodInvoker(delegate
                {
                    Ecard2_box.ForeColor = Color.Red;
                    Ecard2_box.Text = "";
                }));
            }
            if (Battery_box != null && !Battery_box.IsDisposed)
            {
                if (_batterylevel > 3) { _batterycolor = Color.Green; }
                if (_batterylevel > 2.95 && _batterylevel <= 3) { _batterycolor = Color.Yellow; }
                if (_batterylevel <= 2.95) { _batterycolor = Color.Red; }
                if (_batterylevel == 0) { _batterycolor = Color.LightGray; }

                Battery_box.BeginInvoke(new MethodInvoker(delegate
                {
                    Battery_box.Text = _batterylevel.ToString() + "V";
                    Battery_box.BackColor = _batterycolor;
                }));
            }

            using (StreamWriter sr = File.AppendText(_LogfileName))
            {
                sr.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "\t" + ecardname + "\tXX" + "\tUkjent brikke");
            }
        }

        public void ChangeEcuCode() //Change code on ECU reader
        {
            string cmd = "";

            if (ActiveUsbPort == null)
            {
                MessageBox.Show("Brikkeleser ikke funnet! Koble til brikkeleser og trykk 'Oppfrisk'", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //cmd = "/CD" + ecuCode_comboBox.SelectedItem + "\r\n";
            if (Code70_radioButton.Checked == true)
            {
                cmd = "/CD70\r\n";
            }
            if (Code251_radioButton.Checked == true)
            {
                cmd = "/CD251\r\n";
            }

            byte[] bytes = Encoding.ASCII.GetBytes(cmd);

            if (_stop)
            {
                MessageBox.Show("Start kommunikasjon med brikkeleser", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);                //mySerialPort.PortName = ActiveUsbPort;
            }

            if (!_stop)
            {
                int chunksize = 1;
                for (int i = 0; i < bytes.Length; i += chunksize)
                {
                    _spManager._serialPortA.Write(bytes, i, chunksize);
                    Thread.Sleep(5);
                }
            }
        }

        private void UnknownEcard_btn_Click_1(object sender, EventArgs e)
        {
            SetValueForEmitag = Ecard_box.Text;
            SetValueForLopsid = lopsid_box.Text;
            SetValueForLopsNavn = lopsnavn_box.Text;
            SetValueForStartNo = StartNr_box.Text;
            SetValueForID = ID_box.Text;
            ChangeEcard_form f2 = new ChangeEcard_form(this);
            f2.Show();
        }

        public void EmitagParser(string ecbMessage) //Split the message from ECU and find Ecard number
        {
            //Statusmelding fra ECU (ikke lest brikke):
            //IECU - HW1 - SW5 - V1.72  M1 - 103  Y878100473 W12:00:42.216   C253 X7
            //Brikke lest fra ECU:
            //D-02 05	N3903382	Y878100473	W12:00:36.391	V301-2082	S3903382	RemiTag II	L0112	X7
            string _batteryVolt;

            string[] ecbText = ecbMessage.Split(new[] { "\t" }, StringSplitOptions.None);

            foreach (string s in ecbText)
            {
                char type = s[0];
                string info = s.Substring(1);
                switch (type)
                {
                    case 'M':
                        {           // number of messages today
                            //ecardRead = ecbMessage;
                            break;
                        }
                    case 'I':
                        {           // unit info (HW/SW)
                            //ecardRead = info;
                            break;
                        }
                    case 'N':
                        {          // EmiTag-No
                            ecardRead = info;
                            _ecardfound = true;
                            break;
                        }
                    case 'C':
                        {           // ECU internal code
                            _EcuCode = info;
                            readECUcode_box.Text = _EcuCode;
                            if (_EcuCode == "70")
                            {
                                Code70_radioButton.Checked = true;
                            }
                            if (_EcuCode == "251")
                            {
                                Code251_radioButton.Checked = true;
                            }
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
                        {   //Battery status
                            _batteryVolt = info.Substring(0, 1) + "," + info.Substring(1, 2);
                            _batterylevel = Convert.ToDouble(_batteryVolt);
                            break;
                        }
                }
            }
        }

        private void readLiveResfil_btn_Click(object sender, EventArgs e) //Start reading startlist from LiveRes
        {
            if (readLiveResfil_btn.Text == "Les startliste LiveRes")
            {
                if (GridTable != null)
                {
                    GridTable.Columns.Clear();
                    GridTable.Rows.Clear();
                    dataGridView1.Refresh();
                }
                readLiveResfil_btn.Text = "Stopp startliste LiveRes";
                readLiveResfil_btn.BackColor = Color.LightGreen;
                _stopLiveRes = false;
                CancellationTokenSource tokenSource = new CancellationTokenSource();
                Task timerTask = RunPeriodically(TimeSpan.FromMinutes(10), tokenSource.Token);
                _fileloaded = true;
            }
            else
            {
                readLiveResfil_btn.Text = "Les startliste LiveRes";
                readLiveResfil_btn.BackColor = SystemColors.ButtonHighlight;
                _stopLiveRes = true;
            }

        }

        async Task RunPeriodically(TimeSpan interval, CancellationToken token) //read start list from LiveRes every 5 min
        {
            while (true && _stopLiveRes == false)
            {
                readLiveResfil();
                await Task.Delay(interval, token);
            }
        }

        private void readLiveResfil() //Read start list from LiveRes
        {

            Cursor.Current = Cursors.WaitCursor;
            int i = 1;
            progressBar1.Minimum = 0;

            //File for saving startlist from LiveRes local on computer
            _LiveResfileName = @folderLogfile_box.Text + @"\" + "LiveResStartlist" + DateTime.Now.ToString("yyyy-MM-dd") + ".csv";

            using (StreamWriter logfile = new StreamWriter(File.Open(_LiveResfileName, FileMode.Create), Encoding.Default))
            {
                logfile.WriteLine("id,name,class,name_1,ecard1,ecard2,startno,ename");
            }

            try
            {
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string downloadString = client.DownloadString(ConfigurationManager.AppSettings.Get("LiveResURL") + "api.php?method=getrunners&comp=" + lopsid_box.Text);
                var objects = JsonConvert.DeserializeObject<dynamic>(downloadString);
                if (objects.status == "OK")
                {
                    JArray items = (JArray)objects["runners"];
                    GridTable = JsonConvert.DeserializeObject<DataTable>(items.ToString());
                    dataGridView1.DataSource = GridTable;
                    progressBar1.Maximum = items.Count+1;

                    //dataGridView1.Rows.Clear();
                    //dataGridView1.Refresh();
                    //dataGridView1.ColumnCount = 7;
                    //dataGridView1.Columns[0].Name = "bib";
                    //dataGridView1.Columns[1].Name = "name";
                    //dataGridView1.Columns[2].Name = "club";
                    //dataGridView1.Columns[3].Name = "class";
                    //dataGridView1.Columns[4].Name = "ecard";
                    //dataGridView1.Columns[5].Name = "ecard2";
                    //dataGridView1.Columns[6].Name = "id";

                    //foreach (JObject element in items)
                    //{
                    //    progressBar1.Value = ++i;
                    //    var NameConv = element["name"].ToString();
                    //    var ClubConv = element["club"].ToString();
                    //    var ClassConv = element["class"].ToString();
                    //    var StartNoConv = "";
                    //    //byte[] bytes = Encoding.Default.GetBytes(NameConv);
                    //    //NameConv = Encoding.UTF8.GetString(bytes);
                    //    //byte[] bytes1 = Encoding.Default.GetBytes(ClubConv);
                    //    try
                    //    {
                    //        string[] Nameresult = NameConv.Split(')');
                    //        NameConv = Nameresult[1].Trim();
                    //    }
                    //    catch
                    //    {
                    //    }
                    //    //ClubConv = Encoding.UTF8.GetString(bytes1);
                    //    //byte[] bytes2 = Encoding.Default.GetBytes(ClassConv);
                    //    //ClassConv = Encoding.UTF8.GetString(bytes2);

                    //    if (element["bib"].ToString().Substring(0, 1) == "-")  //Startnr ved stafett -16003
                    //    {
                    //        switch (element["bib"].ToString().Length)
                    //        {
                    //            case 6: //3-sifret startnr
                    //                {
                    //                    StartNoConv = element["bib"].ToString().Substring(1, 5);
                    //                    break;
                    //                }
                    //            case 5: //2-sifret startnr
                    //                {
                    //                    StartNoConv = element["bib"].ToString().Substring(1, 4);
                    //                    break;
                    //                }
                    //            case 4: //1-sifret startnr 
                    //                {
                    //                    StartNoConv = element["bib"].ToString().Substring(1, 3);
                    //                    break;
                    //                }
                    //        }
                    //    }
                    //    else
                    //    {
                    //        StartNoConv = element["bib"].ToString();
                    //    }
                    //    dataGridView1.Rows.Add(StartNoConv, NameConv, ClubConv, ClassConv, element["ecard1"], element["ecard2"], element["dbid"]);
                        
                    //    using (StreamWriter logfile = new StreamWriter(File.Open(_LiveResfileName, FileMode.Append), Encoding.Default))
                    //    {
                    //        logfile.WriteLine(element["dbid"] + "," + NameConv + "," + ClassConv + "," + ClubConv + "," +
                    //            element["ecard1"] + "," + element["ecard2"] + "," + StartNoConv);
                    //        //logfile.Close;
                    //    }
                    //}
                }

            }
            catch
            {
                MessageBox.Show("Ingen internettforbindelse!! Koble PC til internett", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void SearchEcard(string searchString) //Search for Ecard in "Ecard1" and "Ecard2"
        {
            SearchName_Box.Clear();
            var MaxRows = dataGridView1.Rows.Count;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                bool _valueFound = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((row.Cells["ecard1"].Value.ToString().Equals(searchString)) || (row.Cells["ecard2"].Value.ToString().Equals(searchString)))
                    {
                        ledBulb_funnet.On = true;
                        ledBulb_funnet.Color = Color.FromArgb(153, 255, 54); //LightGreen
                        dataGridView1.Rows[row.Index].Selected = true;
                        if (StartNr_box != null && !StartNr_box.IsDisposed)
                        {
                            StartNr_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                StartNr_box.ForeColor = Color.Green;
                                StartNr_box.Text = dataGridView1.Rows[row.Index].Cells[1].Value.ToString();
                            }));
                        }
                        if (Navn_box != null && !Navn_box.IsDisposed)
                        {
                            Navn_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                Navn_box.ForeColor = Color.Green; 
                                Navn_box.Text = dataGridView1.Rows[row.Index].Cells[3].Value.ToString();
                            }));
                        }
                        if (Klubb_box != null && !Klubb_box.IsDisposed)
                        {
                            Klubb_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                Klubb_box.ForeColor = Color.Green;
                                Klubb_box.Text = dataGridView1.Rows[row.Index].Cells[4].Value.ToString();
                            }));
                        }
                        if (Klasse_box != null && !Klasse_box.IsDisposed)
                        {
                            Klasse_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                Klasse_box.ForeColor = Color.Green; 
                                Klasse_box.Text = dataGridView1.Rows[row.Index].Cells[6].Value.ToString();
                            }));
                        }
                        if (Ecard_box != null && !Ecard_box.IsDisposed)
                        {
                            Ecard_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                Ecard_box.ForeColor = Color.Green;
                                Ecard_box.Text = dataGridView1.Rows[row.Index].Cells[7].Value.ToString();
                            }));
                        }
                        if (Ecard2_box != null && !Ecard2_box.IsDisposed)
                        {
                            Ecard2_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                Ecard2_box.ForeColor = Color.Green;
                                Ecard2_box.Text = dataGridView1.Rows[row.Index].Cells[8].Value.ToString();
                            }));
                        }
                        if (ID_box != null && !ID_box.IsDisposed)
                        {
                            ID_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                ID_box.Text = dataGridView1.Rows[row.Index].Cells[0].Value.ToString();
                            }));
                        }
                        if (Battery_box != null && !Battery_box.IsDisposed)
                        {
                            if (_batterylevel > 3) { _batterycolor = Color.Green; }
                            if (_batterylevel > 2.95 && _batterylevel <= 3) { _batterycolor = Color.Yellow; }
                            if (_batterylevel <= 2.95) { _batterycolor = Color.Red; }
                            if (_batterylevel == 0) { _batterycolor = Color.LightGray; }

                            Battery_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                Battery_box.Text = _batterylevel.ToString() + "V";
                                Battery_box.ForeColor = _batterycolor;
                            }));
                        }
                        _valueFound = true;

                        if ((File.Exists(@"brikkeOK.wav")) && (WarningSoundFound_checkBox.Checked))
                        {
                            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"brikkeOK.wav");
                            player.Play();
                        }

                        if (TextToSpeechFound_checkBox.Checked)
                        {
                            TextToSpeech("Startnummer " + dataGridView1.Rows[row.Index].Cells[1].Value.ToString() + " "+ dataGridView1.Rows[row.Index].Cells[3].Value.ToString());
                        }

                        NavnScrollInfo = " - (" + dataGridView1.Rows[row.Index].Cells[1].Value.ToString() + ") " +
                                       dataGridView1.Rows[row.Index].Cells[3].Value.ToString();

                        //Sender melding til LiveRes om at brikke er sjekket
                        if (LiveRes_checkBox.Checked)
                        {
                            using (var client = new WebClient())
                            {
                                var lopid = int.Parse(lopsid_box.Text);
                                var id_no = int.Parse(dataGridView1.Rows[row.Index].Cells[0].Value.ToString());
                                try
                                {
                                    var result1 = client.DownloadString(string.Format(ConfigurationManager.AppSettings.Get("LiveResURL") + "messageapi.php?method=setecardchecked&comp={0}&dbid={1}",
                                lopid, id_no));
                                    Console.WriteLine(result1);
                                }
                                catch { }
                            }
                        }

                        using (StreamWriter sr = File.AppendText(_LogfileName))
                        {
                            sr.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "\t" + searchString + "\t" +
                                dataGridView1.Rows[row.Index].Cells[1].Value.ToString() + "\t" +
                                dataGridView1.Rows[row.Index].Cells[3].Value.ToString());
                        }

                        break;
                    }
                }
                if (_valueFound == false)
                {
                    UnknownEcard(searchString);
                    NavnScrollInfo = " - Ukjent brikke";
                }
            }
            catch (Exception) //Ecard not found in datagrid
            {
                UnknownEcard(searchString);
                NavnScrollInfo = " - Ukjent brikke";
            }
        }

        private void readBrikkesjekkfil_btn_Click(object sender, EventArgs e) //Read startlist from "brikkesjekkfil"
        {
            int i = 0;
            progressBar1.Minimum = 0;

            if (readLiveResfil_btn.Text == "Stopp startliste LiveRes")
            {
                readLiveResfil_btn.Text = "Les startliste LiveRes";
                readLiveResfil_btn.BackColor = SystemColors.ButtonHighlight; ;
                _stopLiveRes = true;
            }

            //Delete existing data i datatable and clear datagridview.
            if (GridTable != null)
            {
                GridTable.Columns.Clear();
                GridTable.Rows.Clear();
                dataGridView1.Refresh();
            }

            //dataGridView1.Rows.Clear();
            //dataGridView1.Refresh();
            //dataGridView1.ColumnCount = 7;
            //dataGridView1.Columns[0].Name = "bib";
            //dataGridView1.Columns[1].Name = "name";
            //dataGridView1.Columns[2].Name = "club";
            //dataGridView1.Columns[3].Name = "class";
            //dataGridView1.Columns[4].Name = "ecard";
            //dataGridView1.Columns[5].Name = "ecard2";
            //dataGridView1.Columns[6].Name = "id";

            try
            {
                DataTable ds = new DataTable("Data");
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        StartlistFilename = ofd.FileName;
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
                        _fileloaded = true;
                    }
                }

                progressBar1.Maximum = ds.Rows.Count;


                GridTable.Columns.AddRange(new DataColumn[9] { new DataColumn("dbid", typeof(string)),
                        new DataColumn("bib", typeof(string)),
                        new DataColumn("status",typeof(string)), new DataColumn("name", typeof(string)), 
                        new DataColumn("club", typeof(string)), new DataColumn("start", typeof(string)), 
                        new DataColumn("class", typeof(string)), new DataColumn("ecard1", typeof(string)),
                        new DataColumn("ecard2", typeof(string)),});

                foreach (DataRow row in ds.Rows)
                {
                    
                    progressBar1.Value = ++i;
                    //dataGridView1.Rows.Add(row["startno"], row["name"] + " " + row["ename"], row["name_1"], row["class"], row["ecard"], row["ecard2"], row["id"]);
                    GridTable.Rows.Add(row["id"], row["startno"], "0", row["name"] + " " + row["ename"], row["name_1"], "", row["class"], row["ecard"], row["ecard2"]);
                }
                dataGridView1.DataSource = GridTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _fileloaded = false;
            }

        }

        private void ChangeEcuCode_btn_Click(object sender, EventArgs e)
        {
            int InputValue = 0;
            try
            {
                //InputValue = Int16.Parse(ecuCode_comboBox.SelectedItem.ToString());
                //InputValue = Int16.Parse(ecuCode_box.Text);
            }
            catch (Exception)
            { }

            if (InputValue >= 65 && InputValue <= 253)
            {
                ChangeEcuCode();
            }
            else
            {
                MessageBox.Show("Kode må være mellom 65 og 253!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LiveRes_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LiveRes_checkBox.Checked == true)
            {
                ReadLiveResRaces();
                readLiveResfil_btn.Enabled = true;
                SendMessage_btn.Enabled = true;
                LiveRes_groupBox.Enabled = true;
                NotStared_btn.Enabled = true;
                ChangeEcardNo_btn.Enabled = true;
            }
            if (LiveRes_checkBox.Checked == false)
            {
                if (readLiveResfil_btn.Text == "Stopp startliste LiveRes")
                {
                    readLiveResfil_btn.Text = "Les startliste LiveRes";
                    readLiveResfil_btn.BackColor = Color.LightGray;
                    _stopLiveRes = true;
                }
                readLiveResfil_btn.Enabled = false;
                SendMessage_btn.Enabled = false;
                LiveRes_groupBox.Enabled = false;
                NotStared_btn.Enabled = false;
                ChangeEcardNo_btn.Enabled = false;
            }

        }

        public void FindID_no(int StartNoSearch)
        {
            var MaxRows = dataGridView1.Rows.Count;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string searchStringStr = StartNoSearch.ToString();

            try
            {
                foreach (DataGridViewRow row1 in dataGridView1.Rows)
                {
                    if (row1.Cells["bib"].Value.ToString().Equals(searchStringStr))
                    {
                        SetValueForID = dataGridView1.Rows[row1.Index].Cells[0].Value.ToString();
                        break;
                    }
                    else
                    {
                        SetValueForID = "99999";
                    }
                }
            }
            catch
            {
            }
        }

        private void SearchStartno(int searchString) //Search for startno in datagrid
        {
            var MaxRows = dataGridView1.Rows.Count;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string searchStringStr = searchString.ToString();
            bool _startnofound = false;

            try
            {
                foreach (DataGridViewRow row2 in dataGridView1.Rows)
                {                    
                    if (row2.Cells["bib"].Value.ToString().Equals(searchStringStr))
                    {
                        _startnofound = true;
                        dataGridView1.Rows[row2.Index].Selected = true;
                        if (Navn_box != null && !Navn_box.IsDisposed)
                        {
                            Navn_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                Navn_box.Text = dataGridView1.Rows[row2.Index].Cells[1].Value.ToString();
                            }));
                        }
                        if (Klubb_box != null && !Klubb_box.IsDisposed)
                        {
                            Klubb_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                Klubb_box.Text = dataGridView1.Rows[row2.Index].Cells[2].Value.ToString();
                            }));
                        }
                        if (Klasse_box != null && !Klasse_box.IsDisposed)
                        {
                            Klasse_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                Klasse_box.Text = dataGridView1.Rows[row2.Index].Cells[3].Value.ToString();
                            }));
                        }
                        if (Ecard_box != null && !Ecard_box.IsDisposed)
                        {
                            Ecard_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                Ecard_box.Text = dataGridView1.Rows[row2.Index].Cells[4].Value.ToString();
                            }));
                        }
                        if (Ecard2_box != null && !Ecard2_box.IsDisposed)
                        {
                            Ecard2_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                Ecard2_box.Text = dataGridView1.Rows[row2.Index].Cells[5].Value.ToString();
                            }));
                        }
                        if (ID_box != null && !ID_box.IsDisposed)
                        {
                            ID_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                ID_box.Text = dataGridView1.Rows[row2.Index].Cells[6].Value.ToString();
                            }));
                        }
                        break;
                    }
                }
            }
            catch
            {
                if (_startnofound == false)
                {
                    if (Navn_box != null && !Navn_box.IsDisposed)
                    {
                        Navn_box.BeginInvoke(new MethodInvoker(delegate
                        {
                            Navn_box.Text = "Ukjent nr";
                        }));
                    }
                    if (Klubb_box != null && !Klubb_box.IsDisposed)
                    {
                        Klubb_box.BeginInvoke(new MethodInvoker(delegate
                        {
                            Klubb_box.Text = null;
                        }));
                    }
                    if (Klasse_box != null && !Klasse_box.IsDisposed)
                    {
                        Klasse_box.BeginInvoke(new MethodInvoker(delegate
                        {
                            Klasse_box.Text = null;
                        }));
                    }
                    if (Ecard_box != null && !Ecard_box.IsDisposed)
                    {
                        Ecard_box.BeginInvoke(new MethodInvoker(delegate
                        {
                            Ecard_box.Text = null;
                        }));
                    }
                    if (Ecard2_box != null && !Ecard2_box.IsDisposed)
                    {
                        Ecard2_box.BeginInvoke(new MethodInvoker(delegate
                        {
                            Ecard2_box.Text = null;
                        }));
                    }
                }

            }
        }

        private void FindLiveResName() //Find the competition name from LiveRes database
        {
            try
            {
                WebClient client = new WebClient();
                string downloadString = client.DownloadString(ConfigurationManager.AppSettings.Get("LiveResURL") + "api.php?method=getcompetitioninfo&comp=" + lopsid_box.Text);

                var objects = JsonConvert.DeserializeObject<dynamic>(downloadString);

                if (objects.name != null && objects.id == lopsid_box.Text)
                {
                    var ArrConv = objects.name.ToString();
                    byte[] bytes = Encoding.Default.GetBytes(ArrConv);
                    ArrConv = Encoding.UTF8.GetString(bytes);

                    lopsnavn_box.Text = ArrConv;
                }
                else
                {
                    lopsnavn_box.Text = "Ukjent løp";
                }
            }
            catch
            {
                MessageBox.Show("Ingen internettforbindelse!! Koble PC til internett", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FindLiveRes_btn_Click(object sender, EventArgs e)
        {
            FindLiveResName();
        }

        private void NotStared_btn_Click(object sender, EventArgs e)
        {
            int IntStartNo;
            if (int.TryParse(StartNr_box.Text, out IntStartNo))
            {
                var result = MessageBox.Show("Vil du sende melding om at startnr **" + IntStartNo + "** ikke starter?", "Sett ikke startet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    FindID_no(IntStartNo);
                    var lopid = lopsid_box.Text;

                    if ((SetValueForID != "99999") && (SetValueForID != null))
                    {
                        var dbidNo = int.Parse(SetValueForID);
                        using (var client = new WebClient())
                        {
                            try
                            {
                                var result1 = client.DownloadString(string.Format(ConfigurationManager.AppSettings.Get("LiveResURL") + "messageapi.php?method=sendmessage&comp={0}&dbid={1}&dns=1&message=ikke startet",
        lopid, dbidNo));
                                Console.WriteLine(result1);
                                using (StreamWriter sr = File.AppendText(_LogfileName))
                                {
                                    sr.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "\t" + "Sendt melding: Startnr " + IntStartNo + " ikke startet");
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Ingen internettforbindelse!! Koble PC til internett", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(StartNr_box.Text + " ikke gyldig startnummer", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeEcardNo_btn_Click(object sender, EventArgs e)
        {
            int IntStartNo;
            int IntBrikkeNo;
            bool DialogSendMelding = false;

            if ((int.TryParse(StartNr_box.Text, out IntStartNo)) && (int.TryParse(Ecard_box.Text, out IntBrikkeNo)))
            {
                if (StartNr_box.Text == "" || SearchCard_Txtbox.Text == "")
                {
                    MessageBox.Show("please don't leave any textbox is empty");
                }
                else
                {
                    ChangeEcard_form frm2 = new ChangeEcard_form(this);
                    frm2.ShowDialog();
                    DialogSendMelding = frm2.SendMessage;
                }

                if (DialogSendMelding == true)
                    {
                    var lopid = lopsid_box.Text;
                    var brikkenr = int.Parse(SearchCard_Txtbox.Text);
                    var startnr = int.Parse(StartNr_box.Text);

                    using (var client = new WebClient())
                    {
                        try
                        {
                            var id_no = ID_box.Text;

                            var result1 = client.DownloadString(string.Format(ConfigurationManager.AppSettings.Get("LiveResURL") + "messageapi.php?method=sendmessage&comp={0}&dbid=-{1}&ecardchange=1&message=startnummer:{2}",
    lopid, brikkenr, startnr));
                        //    var result2 = client.DownloadString(string.Format(ConfigurationManager.AppSettings.Get("LiveResURL") + "messageapi.php?method=setecardchecked&comp={0}&bib={1}",
                        //lopid, startnr));
                            var result3 = client.DownloadString(string.Format(ConfigurationManager.AppSettings.Get("LiveResURL") + "messageapi.php?method=setecardchecked&comp={0}&dbid={1}",
lopid, id_no));



                            Console.WriteLine(result1);
                            Console.WriteLine(result3);
                            using (StreamWriter sr = File.AppendText(_LogfileName))
                            {
                                sr.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "\t" + "Sendt melding: Startnr " + startnr + " byttet brikke til " + brikkenr);
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Ingen internettforbindelse!! Koble PC til internett", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ikke gyldig startnummer eller brikkenummer" , "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SearchCard_Txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchName_Box.Clear();
                e.Handled = true;
                SearchCard_btn.PerformClick();
            }
        }

        private void folderLogfile_box_TextChanged(object sender, EventArgs e)
        {
            if (!Directory.Exists(@folderLogfile_box.Text))
            {
                MessageBox.Show(@folderLogfile_box.Text + " eksisterer ikke. Velg korrekt katalog!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetFolderButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    @folderLogfile_box.Text = fbd.SelectedPath;
                }
            }
        }


        private void ReadLiveResRaces()
        {
            try
            {
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;

                string downloadString = client.DownloadString(ConfigurationManager.AppSettings.Get("LiveResURL") + "api.php?method=getcompetitions");
                var objects = JsonConvert.DeserializeObject<RootObject>(downloadString);

                comboBoxLiveRes.DataSource = objects.competitions;                
                comboBoxLiveRes.DisplayMember = "Name";
                comboBoxLiveRes.ValueMember = "id";
                comboBoxLiveRes.SelectedValue = int.Parse(lopsid_box.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void comboBoxLiveRes_SelectedValueChanged(object sender, EventArgs e)
        {
            //int ValgtIndex = comboBoxLiveRes.SelectedIndex;
            //var ValgtItem = comboBoxLiveRes.SelectedItem;
            var SelectedValue = comboBoxLiveRes.SelectedValue;
            lopsid_box.Text = SelectedValue.ToString();
            var ArrConv = comboBoxLiveRes.Text.ToString();
            //byte[] bytes = Encoding.Default.GetBytes(ArrConv);
            //ArrConv = Encoding.UTF8.GetString(bytes);

            lopsnavn_box.Text = ArrConv;
        }

        private void Code70_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton RD = sender as RadioButton;

            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    // Only one radio button will be checked
                    ChangeEcuCode();
                    Console.WriteLine("Changed: " + rb.Name);
                }
            }
        }

        private void TextToSpeech(string text)
        {
            if (text != "")
            {
                SpeechReader.Dispose();
                SpeechReader = new SpeechSynthesizer();
                foreach (var voice in SpeechReader.GetInstalledVoices())
                {
                    var test = voice.VoiceInfo.Name;
                    Console.WriteLine(voice.VoiceInfo.Gender + voice.VoiceInfo.Id + voice.VoiceInfo.Name);
                }
                SpeechReader.Volume = 100;
                try 
                {
                    SpeechReader.SelectVoice("Microsoft Jon");
                    SpeechReader.SpeakAsync(text);
                }
                catch 
                {
                    return;
                }
            }
        }

        private void TextToSpeechFound_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TextToSpeechFound_checkBox.Checked == true && WarningSoundFound_checkBox.Checked == true)
            {
                WarningSoundFound_checkBox.Checked = false;
            }
        }

        private void WarningSoundFound_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TextToSpeechFound_checkBox.Checked == true && WarningSoundFound_checkBox.Checked == true)
            {
                TextToSpeechFound_checkBox.Checked = false;
            }
        }

        private void SendMessage_btn_Click(object sender, EventArgs e)
        {
            SetValueForLopsid = lopsid_box.Text;
            SendMessage_form f1 = new SendMessage_form();
            f1.Show();
        }

        private void ECU_read_led_blink(object sender, EventArgs e)
        {
            //((LedBulb)sender).On = !((LedBulb)sender).On;
            if (_blink == 0) _blink = 500;
            else _blink = 0;
            ((LedBulb)sender).Blink(_blink);

        }

        private void ECU_read_led_Click(object sender, EventArgs e)
        {
            ((LedBulb)sender).On = !((LedBulb)sender).On;
            if (_blink == 0) _blink = 500;
            else _blink = 0;
            ((LedBulb)sender).Blink(_blink);

        }

        private void MTR_read_led_Click(object sender, EventArgs e)
        {
            if (_blink == 0) _blink = 500;
            else _blink = 0;
            ((LedBulb)sender).Blink(_blink);
        }

        private void SearchName_Box_TextChanged(object sender, EventArgs e)
        {
           if (GridTable != null && GridTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = GridTable;
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("name LIKE '%{0}%'", SearchName_Box.Text);
                }
        }

        private void StartNr_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchName_Box.Clear();
                e.Handled = true;
                if (GridTable != null && GridTable.Rows.Count > 0)
                {
                    var MaxRows = dataGridView1.Rows.Count;
                    dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    var searchStringStr = StartNr_box.Text;

                    try
                    {
                        foreach (DataGridViewRow row1 in dataGridView1.Rows)
                        {
                            if (row1.Cells["bib"].Value.ToString().Equals(searchStringStr))
                            {
                                Navn_box.Text = dataGridView1.Rows[row1.Index].Cells[3].Value.ToString();
                                Klubb_box.Text = dataGridView1.Rows[row1.Index].Cells[4].Value.ToString();
                                Klasse_box.Text = dataGridView1.Rows[row1.Index].Cells[6].Value.ToString();
                                Ecard_box.Text = dataGridView1.Rows[row1.Index].Cells[7].Value.ToString();
                                Ecard2_box.Text = dataGridView1.Rows[row1.Index].Cells[8].Value.ToString();
                                break;
                            }
                            else
                            {
                                Navn_box.Text = "";
                                Klubb_box.Text = "";
                                Klasse_box.Text = "";
                                Ecard_box.Text = "";
                                Ecard2_box.Text = "";
                            }
                        }
                    }
                    catch
                    {
                    }
                }

            }

        }
    }
}