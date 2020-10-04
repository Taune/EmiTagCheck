using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
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


namespace USBRead
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
        public double _batterylevel;
        public Color _batterycolor;
        public string _EcuCode;
        public string StartlistFilename;
        public string messageText;
        SerialPortManager _spManager;

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
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_serialportfound == true)
            {
                _spManager.Dispose();
            }
            else
            {
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
                        ReadEcu_btn.BackColor = Color.LightGreen;
                        UsbRead_listBox.Items.Insert(0, "ECU - " + DateTime.Now.ToString("HH:mm:ss") + "  Open Communication");
                        _spManager.StartListeningECU();
                        _stop = false;
                    }
                }
                else
                {
                    ReadEcu_btn.Text = "Start ECU";
                    ReadEcu_btn.BackColor = Color.LightCoral;
                    _spManager.StopListeningECU();
                    UsbRead_listBox.Items.Insert(0, "ECU - " + DateTime.Now.ToString("HH:mm:ss") + "  Communication Closed");
                    _stop = true;
                    ECUComPortOpen = "";
                }
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
                        btnStartMTR.BackColor = Color.LightGreen;
                        UsbRead_listBox.Items.Insert(0, "MTR - " + DateTime.Now.ToString("HH:mm:ss") + "  Open Communication");
                        _spManager.StartListeningMTR();
                        _stop = false;
                    }
                }
                else
                {
                    btnStartMTR.Text = "Start MTR";
                    btnStartMTR.BackColor = Color.LightCoral;
                    _spManager.StopListeningMTR();
                    UsbRead_listBox.Items.Insert(0, "MTR - " + DateTime.Now.ToString("HH:mm:ss") + "  Communication Closed");
                    MTRComPortOpen = "";
                    _stop = true;
                }
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            bool _LiveRes = true;
            // Read a keys from the config file            
            lopsid_box.Text = ConfigurationManager.AppSettings.Get("lopid");
            lopsnavn_box.Text = ConfigurationManager.AppSettings.Get("lopnavn");
            folderLogfile_box.Text = ConfigurationManager.AppSettings.Get("logfolder");
            if (ConfigurationManager.AppSettings.Get("liveresCheckBox") == "False")
            {
                _LiveRes = false;
            }
            LiveRes_checkBox.Checked = _LiveRes;
            if (LiveRes_checkBox.Checked == true)
            {
                readLiveResfil_btn.Enabled = true;
                UnknownEcard_btn.Enabled = true;
                LiveRes_groupBox.Enabled = true;
            }
            if (LiveRes_checkBox.Checked == false)
            {
                readLiveResfil_btn.Enabled = false;
                UnknownEcard_btn.Enabled = false;
                LiveRes_groupBox.Enabled = false;
            }

            _stop = true;

            _LogfileName = @folderLogfile_box.Text + "brikkesjekk " + DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            //Create a log-file for todays race
            if (!File.Exists(_LogfileName))
            {
                // Create a file to write to.
                using (StreamWriter logfile = File.CreateText(_LogfileName))
                {
                    logfile.WriteLine("Log created: " + DateTime.Now.ToString("hh:MM:ss"));
                }
            }

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

            if (hh < 10) { time += "0" + hh; }
            else { time += hh; }
            time += ":";

            if (mm < 10) { time += "0" + mm; }
            else { time += mm; }
            time += ":";

            if (ss < 10) { time += "0" + ss; }
            else { time += ss; }

            Clock_lbl.Text = time;
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
                    if (File.Exists(@"ringout.wav"))
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"ringout.wav");
                        player.Play();
                    }
                }));
            }
            if (Klubb_box != null && !Klubb_box.IsDisposed)
            {
                Klubb_box.BeginInvoke(new MethodInvoker(delegate
                {
                    Klubb_box.Text = "XX";
                }));
            }
            if (Klasse_box != null && !Klasse_box.IsDisposed)
            {
                Klasse_box.BeginInvoke(new MethodInvoker(delegate
                {
                    Klasse_box.Text = "XX";
                }));
            }
            if (Ecard2_box != null && !Ecard2_box.IsDisposed)
            {
                Ecard2_box.BeginInvoke(new MethodInvoker(delegate
                {
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
            if (ActiveUsbPort == null)
            {
                MessageBox.Show("Brikkeleser ikke funnet! Koble til brikkeleser og trykk 'Oppfrisk'", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string cmd = "/CD" + ecuCode_box.Text + "\r\n";
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
            SendMessage_form f2 = new SendMessage_form();
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
            if (readLiveResfil_btn.Text == "Les startliste fra LiveRes")
            {
                readLiveResfil_btn.Text = "Stopp startliste fra LiveRes";
                _stopLiveRes = false;
                CancellationTokenSource tokenSource = new CancellationTokenSource();
                Task timerTask = RunPeriodically(TimeSpan.FromMinutes(10), tokenSource.Token);
                _fileloaded = true;
            }
            else
            {
                readLiveResfil_btn.Text = "Les startliste fra LiveRes";
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
            try
            {
                WebClient client = new WebClient();
                string downloadString = client.DownloadString("http://api.freidig.idrett.no/api.php?method=getrunners&comp=" + lopsid_box.Text);

                var objects = JsonConvert.DeserializeObject<dynamic>(downloadString);
                if (objects.status == "OK")
                {
                    JArray items = (JArray)objects["runners"];

                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    dataGridView1.ColumnCount = 7;
                    dataGridView1.Columns[0].Name = "bib";
                    dataGridView1.Columns[1].Name = "name";
                    dataGridView1.Columns[2].Name = "club";
                    dataGridView1.Columns[3].Name = "class";
                    dataGridView1.Columns[4].Name = "ecard";
                    dataGridView1.Columns[5].Name = "ecard2";
                    dataGridView1.Columns[6].Name = "id";

                    foreach (JObject element in items)
                    {
                        var NameConv = element["name"].ToString();
                        var ClubConv = element["club"].ToString();
                        var ClassConv = element["class"].ToString();
                        byte[] bytes = Encoding.Default.GetBytes(NameConv);

                        NameConv = Encoding.UTF8.GetString(bytes);
                        byte[] bytes1 = Encoding.Default.GetBytes(ClubConv);
                        try
                        {
                            string[] Nameresult = NameConv.Split(')');
                            NameConv = Nameresult[1].Trim();
                        }
                        catch
                        {
                        }
                        ClubConv = Encoding.UTF8.GetString(bytes1);
                        byte[] bytes2 = Encoding.Default.GetBytes(ClassConv);
                        ClassConv = Encoding.UTF8.GetString(bytes2);

                        dataGridView1.Rows.Add(element["bib"], NameConv, ClubConv, ClassConv, element["ecard1"], element["ecard2"], element["dbid"]);
                        //Console.WriteLine(element["name"]);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ingen internettforbindelse!! Koble PC til internett", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchEcard(string searchString) //Search for Ecard in "Ecard" and "Ecard2"
        {
            var MaxRows = dataGridView1.Rows.Count;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                bool _valueFound = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((row.Cells["ecard"].Value.ToString().Equals(searchString)) || (row.Cells["ecard2"].Value.ToString().Equals(searchString)))
                    {
                        dataGridView1.Rows[row.Index].Selected = true;
                        if (StartNr_box != null && !StartNr_box.IsDisposed)
                        {
                            StartNr_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                StartNr_box.Text = dataGridView1.Rows[row.Index].Cells[0].Value.ToString();
                            }));
                        }
                        if (Navn_box != null && !Navn_box.IsDisposed)
                        {
                            Navn_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                Navn_box.Text = dataGridView1.Rows[row.Index].Cells[1].Value.ToString();
                            }));
                        }
                        if (Klubb_box != null && !Klubb_box.IsDisposed)
                        {
                            Klubb_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                Klubb_box.Text = dataGridView1.Rows[row.Index].Cells[2].Value.ToString();
                            }));
                        }
                        if (Klasse_box != null && !Klasse_box.IsDisposed)
                        {
                            Klasse_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                Klasse_box.Text = dataGridView1.Rows[row.Index].Cells[3].Value.ToString();
                            }));
                        }
                        if (Ecard_box != null && !Ecard_box.IsDisposed)
                        {
                            Ecard_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                Ecard_box.Text = dataGridView1.Rows[row.Index].Cells[4].Value.ToString();
                            }));
                        }
                        if (Ecard2_box != null && !Ecard2_box.IsDisposed)
                        {
                            Ecard2_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                Ecard2_box.Text = dataGridView1.Rows[row.Index].Cells[5].Value.ToString();
                            }));
                        }
                        if (ID_box != null && !ID_box.IsDisposed)
                        {
                            ID_box.BeginInvoke(new MethodInvoker(delegate
                            {
                                ID_box.Text = dataGridView1.Rows[row.Index].Cells[6].Value.ToString();
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
                        _valueFound = true;

                        NavnScrollInfo = " - (" + dataGridView1.Rows[row.Index].Cells[0].Value.ToString() + ") " +
                                       dataGridView1.Rows[row.Index].Cells[1].Value.ToString();

                        //Sender melding til LiveRes om at brikke er sjekket
                        if (LiveRes_checkBox.Enabled == true)
                        {
                            using (var client = new WebClient())
                            {
                                var lopid = int.Parse(lopsid_box.Text);
                                var id_no = int.Parse(dataGridView1.Rows[row.Index].Cells[6].Value.ToString());
                                try
                                {
                                    var result1 = client.DownloadString(string.Format("https://api.freidig.idrett.no/messageapi.php?method=setecardchecked&comp={0}&dbid={1}", 
                                lopid, id_no));
                                    Console.WriteLine(result1);
                                }
                                catch { }
                            }
                        }

                        using (StreamWriter sr = File.AppendText(_LogfileName))
                        {
                            sr.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "\t" + searchString + "\t" +
                                dataGridView1.Rows[row.Index].Cells[0].Value.ToString() + "\t" +
                                dataGridView1.Rows[row.Index].Cells[1].Value.ToString());
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
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "bib";
            dataGridView1.Columns[1].Name = "name";
            dataGridView1.Columns[2].Name = "club";
            dataGridView1.Columns[3].Name = "class";
            dataGridView1.Columns[4].Name = "ecard";
            dataGridView1.Columns[5].Name = "ecard2";
            dataGridView1.Columns[6].Name = "id";

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

                foreach (DataRow row in ds.Rows)
                {
                    var nyttnavn = row["id"];
                    dataGridView1.Rows.Add(row["startno"], row["name"] + " " + row["ename"], row["name_1"], row["class"], row["ecard"], row["ecard2"], row["id"]);
                }
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
                InputValue = Int16.Parse(ecuCode_box.Text);
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
                readLiveResfil_btn.Enabled = true;
                UnknownEcard_btn.Enabled = true;
                LiveRes_groupBox.Enabled = true;
            }
            if (LiveRes_checkBox.Checked == false)
            {
                readLiveResfil_btn.Enabled = false;
                UnknownEcard_btn.Enabled = false;
                LiveRes_groupBox.Enabled = false;
            }

        }

        public void FindID_no(string StartNoSearch)
        {
            var MaxRows = dataGridView1.Rows.Count;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                foreach (DataGridViewRow row1 in dataGridView1.Rows)
                {
                    if (row1.Cells["id"].Value.ToString().Equals(StartNoSearch))
                    {
                        //                       dataGridView1.Rows[row.Index].Selected = true;
                        SetValueForID = dataGridView1.Rows[row1.Index].Cells[6].Value.ToString();
                        break;
                    }
                }
            }
            catch
            {
            }
        }

        private void FindLiveResName() //Find the competition name from LiveRes database
        {
            try
            {
                WebClient client = new WebClient();
                string downloadString = client.DownloadString("http://api.freidig.idrett.no/api.php?method=getcompetitioninfo&comp=" + lopsid_box.Text);

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
    }
}