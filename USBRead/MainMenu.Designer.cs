namespace Brikkesjekk
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.UsbPort_listBox = new System.Windows.Forms.ListBox();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Clock_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchCard_btn = new System.Windows.Forms.Button();
            this.SearchCard_Txtbox = new System.Windows.Forms.TextBox();
            this.UsbRead_listBox = new System.Windows.Forms.ListBox();
            this.StartNr_box = new System.Windows.Forms.TextBox();
            this.Navn_box = new System.Windows.Forms.TextBox();
            this.Klubb_box = new System.Windows.Forms.TextBox();
            this.Klasse_box = new System.Windows.Forms.TextBox();
            this.Ecard_box = new System.Windows.Forms.TextBox();
            this.Ecard2_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SendMessage_btn = new System.Windows.Forms.Button();
            this.lopsid_box = new System.Windows.Forms.TextBox();
            this.lopsnavn_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LiveRes_groupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lopsdato_box = new System.Windows.Forms.TextBox();
            this.comboBoxLiveRes = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RefreshUsbPort_btn = new System.Windows.Forms.Button();
            this.readLiveResfil_btn = new System.Windows.Forms.Button();
            this.readBrikkesjekkfil_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Løperinfo = new System.Windows.Forms.GroupBox();
            this.Starttid_Box = new System.Windows.Forms.TextBox();
            this.EmitCard_picture = new System.Windows.Forms.PictureBox();
            this.EmiTag_picture = new System.Windows.Forms.PictureBox();
            this.ChangeEcardNo_btn = new System.Windows.Forms.Button();
            this.NotStared_btn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ID_box = new System.Windows.Forms.TextBox();
            this.Battery_box = new System.Windows.Forms.TextBox();
            this.folderLogfile_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnStartMTR = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Code251_radioButton = new System.Windows.Forms.RadioButton();
            this.Code70_radioButton = new System.Windows.Forms.RadioButton();
            this.readECUcode_box = new System.Windows.Forms.TextBox();
            this.ReadEcu_btn = new System.Windows.Forms.Button();
            this.LiveRes_checkBox = new System.Windows.Forms.CheckBox();
            this.WarningSoundNotFound_checkBox = new System.Windows.Forms.CheckBox();
            this.version = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GetFolderButton = new System.Windows.Forms.Button();
            this.WarningSoundFound_checkBox = new System.Windows.Forms.CheckBox();
            this.TextToSpeechFound_checkBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SearchName_Box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LiveresMessages_btn = new System.Windows.Forms.Button();
            this.OppdaterFrekvens_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TimerStartliste = new System.Windows.Forms.Timer(this.components);
            this.TimerStartliste_lbl = new System.Windows.Forms.Label();
            this.MTR_read_led = new Brikkesjekk.LedBulb();
            this.ECU_read_led = new Brikkesjekk.LedBulb();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.LiveRes_groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Løperinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmitCard_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmiTag_picture)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsbPort_listBox
            // 
            this.UsbPort_listBox.BackColor = System.Drawing.SystemColors.Window;
            this.UsbPort_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsbPort_listBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsbPort_listBox.FormattingEnabled = true;
            this.UsbPort_listBox.ItemHeight = 23;
            this.UsbPort_listBox.Location = new System.Drawing.Point(16, 22);
            this.UsbPort_listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsbPort_listBox.Name = "UsbPort_listBox";
            this.UsbPort_listBox.Size = new System.Drawing.Size(143, 115);
            this.UsbPort_listBox.Sorted = true;
            this.UsbPort_listBox.TabIndex = 2;
            this.UsbPort_listBox.SelectedIndexChanged += new System.EventHandler(this.UsbPort_listBox_SelectedIndexChanged);
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.ForeColor = System.Drawing.Color.White;
            this.Close_btn.Location = new System.Drawing.Point(15, 10);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(213, 39);
            this.Close_btn.TabIndex = 4;
            this.Close_btn.Text = "AVSLUTT PROGRAM";
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Clock_lbl
            // 
            this.Clock_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Clock_lbl.AutoSize = true;
            this.Clock_lbl.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Clock_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Clock_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock_lbl.ForeColor = System.Drawing.Color.White;
            this.Clock_lbl.Location = new System.Drawing.Point(1343, 15);
            this.Clock_lbl.Name = "Clock_lbl";
            this.Clock_lbl.Size = new System.Drawing.Size(129, 34);
            this.Clock_lbl.TabIndex = 9;
            this.Clock_lbl.Text = "00:00:00";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(617, 516);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(869, 252);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SearchCard_btn
            // 
            this.SearchCard_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.SearchCard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchCard_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCard_btn.ForeColor = System.Drawing.Color.White;
            this.SearchCard_btn.Location = new System.Drawing.Point(464, 10);
            this.SearchCard_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchCard_btn.Name = "SearchCard_btn";
            this.SearchCard_btn.Size = new System.Drawing.Size(231, 39);
            this.SearchCard_btn.TabIndex = 12;
            this.SearchCard_btn.Text = "SØK BRIKKE MANUELT";
            this.SearchCard_btn.UseVisualStyleBackColor = false;
            this.SearchCard_btn.Click += new System.EventHandler(this.SearchCard_btn_Click);
            // 
            // SearchCard_Txtbox
            // 
            this.SearchCard_Txtbox.BackColor = System.Drawing.SystemColors.Window;
            this.SearchCard_Txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchCard_Txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCard_Txtbox.Location = new System.Drawing.Point(701, 15);
            this.SearchCard_Txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchCard_Txtbox.Name = "SearchCard_Txtbox";
            this.SearchCard_Txtbox.Size = new System.Drawing.Size(153, 30);
            this.SearchCard_Txtbox.TabIndex = 13;
            this.SearchCard_Txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchCard_Txtbox_KeyPress);
            // 
            // UsbRead_listBox
            // 
            this.UsbRead_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UsbRead_listBox.BackColor = System.Drawing.SystemColors.Info;
            this.UsbRead_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsbRead_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsbRead_listBox.FormattingEnabled = true;
            this.UsbRead_listBox.ItemHeight = 18;
            this.UsbRead_listBox.Location = new System.Drawing.Point(15, 516);
            this.UsbRead_listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsbRead_listBox.Name = "UsbRead_listBox";
            this.UsbRead_listBox.Size = new System.Drawing.Size(581, 252);
            this.UsbRead_listBox.TabIndex = 25;
            // 
            // StartNr_box
            // 
            this.StartNr_box.BackColor = System.Drawing.SystemColors.Window;
            this.StartNr_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartNr_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartNr_box.ForeColor = System.Drawing.Color.Red;
            this.StartNr_box.Location = new System.Drawing.Point(16, 43);
            this.StartNr_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartNr_box.Name = "StartNr_box";
            this.StartNr_box.Size = new System.Drawing.Size(278, 98);
            this.StartNr_box.TabIndex = 18;
            this.StartNr_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartNr_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartNr_box_KeyPress);
            // 
            // Navn_box
            // 
            this.Navn_box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Navn_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Navn_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Navn_box.ForeColor = System.Drawing.Color.Green;
            this.Navn_box.Location = new System.Drawing.Point(16, 178);
            this.Navn_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Navn_box.Name = "Navn_box";
            this.Navn_box.ReadOnly = true;
            this.Navn_box.Size = new System.Drawing.Size(993, 80);
            this.Navn_box.TabIndex = 19;
            // 
            // Klubb_box
            // 
            this.Klubb_box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Klubb_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Klubb_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klubb_box.ForeColor = System.Drawing.Color.Red;
            this.Klubb_box.Location = new System.Drawing.Point(16, 272);
            this.Klubb_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Klubb_box.Multiline = true;
            this.Klubb_box.Name = "Klubb_box";
            this.Klubb_box.ReadOnly = true;
            this.Klubb_box.Size = new System.Drawing.Size(993, 49);
            this.Klubb_box.TabIndex = 20;
            // 
            // Klasse_box
            // 
            this.Klasse_box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Klasse_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Klasse_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klasse_box.ForeColor = System.Drawing.Color.Red;
            this.Klasse_box.Location = new System.Drawing.Point(16, 327);
            this.Klasse_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Klasse_box.Name = "Klasse_box";
            this.Klasse_box.ReadOnly = true;
            this.Klasse_box.Size = new System.Drawing.Size(766, 42);
            this.Klasse_box.TabIndex = 21;
            // 
            // Ecard_box
            // 
            this.Ecard_box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Ecard_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ecard_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecard_box.ForeColor = System.Drawing.Color.Blue;
            this.Ecard_box.Location = new System.Drawing.Point(303, 43);
            this.Ecard_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ecard_box.Name = "Ecard_box";
            this.Ecard_box.ReadOnly = true;
            this.Ecard_box.Size = new System.Drawing.Size(219, 38);
            this.Ecard_box.TabIndex = 22;
            // 
            // Ecard2_box
            // 
            this.Ecard2_box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Ecard2_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ecard2_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecard2_box.ForeColor = System.Drawing.Color.Blue;
            this.Ecard2_box.Location = new System.Drawing.Point(303, 108);
            this.Ecard2_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ecard2_box.Name = "Ecard2_box";
            this.Ecard2_box.ReadOnly = true;
            this.Ecard2_box.Size = new System.Drawing.Size(219, 38);
            this.Ecard2_box.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Brikke 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Brikke 2";
            // 
            // SendMessage_btn
            // 
            this.SendMessage_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.SendMessage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMessage_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMessage_btn.ForeColor = System.Drawing.Color.White;
            this.SendMessage_btn.Location = new System.Drawing.Point(764, 121);
            this.SendMessage_btn.Margin = new System.Windows.Forms.Padding(4);
            this.SendMessage_btn.Name = "SendMessage_btn";
            this.SendMessage_btn.Size = new System.Drawing.Size(244, 39);
            this.SendMessage_btn.TabIndex = 29;
            this.SendMessage_btn.Text = "MELDING TIL LIVERES";
            this.SendMessage_btn.UseVisualStyleBackColor = false;
            this.SendMessage_btn.Click += new System.EventHandler(this.SendMessage_btn_Click);
            // 
            // lopsid_box
            // 
            this.lopsid_box.BackColor = System.Drawing.SystemColors.Menu;
            this.lopsid_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lopsid_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopsid_box.Location = new System.Drawing.Point(79, 30);
            this.lopsid_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lopsid_box.Name = "lopsid_box";
            this.lopsid_box.ReadOnly = true;
            this.lopsid_box.Size = new System.Drawing.Size(110, 27);
            this.lopsid_box.TabIndex = 30;
            // 
            // lopsnavn_box
            // 
            this.lopsnavn_box.BackColor = System.Drawing.SystemColors.Menu;
            this.lopsnavn_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lopsnavn_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopsnavn_box.Location = new System.Drawing.Point(79, 102);
            this.lopsnavn_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lopsnavn_box.Name = "lopsnavn_box";
            this.lopsnavn_box.ReadOnly = true;
            this.lopsnavn_box.Size = new System.Drawing.Size(326, 27);
            this.lopsnavn_box.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Navn";
            // 
            // LiveRes_groupBox
            // 
            this.LiveRes_groupBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LiveRes_groupBox.Controls.Add(this.label2);
            this.LiveRes_groupBox.Controls.Add(this.lopsdato_box);
            this.LiveRes_groupBox.Controls.Add(this.comboBoxLiveRes);
            this.LiveRes_groupBox.Controls.Add(this.label7);
            this.LiveRes_groupBox.Controls.Add(this.label6);
            this.LiveRes_groupBox.Controls.Add(this.lopsnavn_box);
            this.LiveRes_groupBox.Controls.Add(this.lopsid_box);
            this.LiveRes_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiveRes_groupBox.Location = new System.Drawing.Point(15, 302);
            this.LiveRes_groupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LiveRes_groupBox.Name = "LiveRes_groupBox";
            this.LiveRes_groupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LiveRes_groupBox.Size = new System.Drawing.Size(421, 139);
            this.LiveRes_groupBox.TabIndex = 34;
            this.LiveRes_groupBox.TabStop = false;
            this.LiveRes_groupBox.Text = "Arrangementsinfo LiveRes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Dato";
            // 
            // lopsdato_box
            // 
            this.lopsdato_box.BackColor = System.Drawing.SystemColors.Menu;
            this.lopsdato_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lopsdato_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopsdato_box.Location = new System.Drawing.Point(79, 66);
            this.lopsdato_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lopsdato_box.Name = "lopsdato_box";
            this.lopsdato_box.ReadOnly = true;
            this.lopsdato_box.Size = new System.Drawing.Size(110, 27);
            this.lopsdato_box.TabIndex = 39;
            this.lopsdato_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxLiveRes
            // 
            this.comboBoxLiveRes.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxLiveRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLiveRes.DropDownWidth = 400;
            this.comboBoxLiveRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLiveRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLiveRes.FormattingEnabled = true;
            this.comboBoxLiveRes.ItemHeight = 20;
            this.comboBoxLiveRes.Location = new System.Drawing.Point(196, 28);
            this.comboBoxLiveRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLiveRes.Name = "comboBoxLiveRes";
            this.comboBoxLiveRes.Size = new System.Drawing.Size(209, 28);
            this.comboBoxLiveRes.TabIndex = 38;
            this.comboBoxLiveRes.SelectionChangeCommitted += new System.EventHandler(this.comboBoxLiveRes_SelectedValueChanged);
            this.comboBoxLiveRes.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxLiveRes_Format);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UsbPort_listBox);
            this.groupBox2.Controls.Add(this.RefreshUsbPort_btn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(264, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(172, 194);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Velg Port";
            // 
            // RefreshUsbPort_btn
            // 
            this.RefreshUsbPort_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.RefreshUsbPort_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshUsbPort_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshUsbPort_btn.ForeColor = System.Drawing.Color.White;
            this.RefreshUsbPort_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefreshUsbPort_btn.Location = new System.Drawing.Point(16, 145);
            this.RefreshUsbPort_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshUsbPort_btn.Name = "RefreshUsbPort_btn";
            this.RefreshUsbPort_btn.Size = new System.Drawing.Size(141, 43);
            this.RefreshUsbPort_btn.TabIndex = 3;
            this.RefreshUsbPort_btn.Text = "OPPFRISK";
            this.RefreshUsbPort_btn.UseVisualStyleBackColor = false;
            this.RefreshUsbPort_btn.Click += new System.EventHandler(this.RefreshUsbPort_btn_Click);
            // 
            // readLiveResfil_btn
            // 
            this.readLiveResfil_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.readLiveResfil_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readLiveResfil_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readLiveResfil_btn.ForeColor = System.Drawing.Color.White;
            this.readLiveResfil_btn.Location = new System.Drawing.Point(883, 469);
            this.readLiveResfil_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readLiveResfil_btn.Name = "readLiveResfil_btn";
            this.readLiveResfil_btn.Size = new System.Drawing.Size(260, 39);
            this.readLiveResfil_btn.TabIndex = 37;
            this.readLiveResfil_btn.Text = "LES STARTLISTE LIVERES";
            this.readLiveResfil_btn.UseVisualStyleBackColor = false;
            this.readLiveResfil_btn.Click += new System.EventHandler(this.readLiveResfil_btn_Click);
            // 
            // readBrikkesjekkfil_btn
            // 
            this.readBrikkesjekkfil_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.readBrikkesjekkfil_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readBrikkesjekkfil_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBrikkesjekkfil_btn.ForeColor = System.Drawing.Color.White;
            this.readBrikkesjekkfil_btn.Location = new System.Drawing.Point(617, 469);
            this.readBrikkesjekkfil_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readBrikkesjekkfil_btn.Name = "readBrikkesjekkfil_btn";
            this.readBrikkesjekkfil_btn.Size = new System.Drawing.Size(260, 39);
            this.readBrikkesjekkfil_btn.TabIndex = 39;
            this.readBrikkesjekkfil_btn.Text = "LES STARTLISTE ETIMING";
            this.readBrikkesjekkfil_btn.UseVisualStyleBackColor = false;
            this.readBrikkesjekkfil_btn.Click += new System.EventHandler(this.readBrikkesjekkfil_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Stopp kommunikasjon før Avslutt";
            // 
            // Løperinfo
            // 
            this.Løperinfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Løperinfo.Controls.Add(this.Starttid_Box);
            this.Løperinfo.Controls.Add(this.EmitCard_picture);
            this.Løperinfo.Controls.Add(this.EmiTag_picture);
            this.Løperinfo.Controls.Add(this.ChangeEcardNo_btn);
            this.Løperinfo.Controls.Add(this.NotStared_btn);
            this.Løperinfo.Controls.Add(this.label12);
            this.Løperinfo.Controls.Add(this.label11);
            this.Løperinfo.Controls.Add(this.ID_box);
            this.Løperinfo.Controls.Add(this.Battery_box);
            this.Løperinfo.Controls.Add(this.label5);
            this.Løperinfo.Controls.Add(this.label4);
            this.Løperinfo.Controls.Add(this.Ecard2_box);
            this.Løperinfo.Controls.Add(this.Ecard_box);
            this.Løperinfo.Controls.Add(this.Klasse_box);
            this.Løperinfo.Controls.Add(this.Klubb_box);
            this.Løperinfo.Controls.Add(this.SendMessage_btn);
            this.Løperinfo.Controls.Add(this.Navn_box);
            this.Løperinfo.Controls.Add(this.StartNr_box);
            this.Løperinfo.Location = new System.Drawing.Point(464, 62);
            this.Løperinfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Løperinfo.Name = "Løperinfo";
            this.Løperinfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Løperinfo.Size = new System.Drawing.Size(1023, 378);
            this.Løperinfo.TabIndex = 41;
            this.Løperinfo.TabStop = false;
            this.Løperinfo.Text = "Løperinfo";
            // 
            // Starttid_Box
            // 
            this.Starttid_Box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Starttid_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Starttid_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Starttid_Box.ForeColor = System.Drawing.Color.Red;
            this.Starttid_Box.Location = new System.Drawing.Point(802, 327);
            this.Starttid_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Starttid_Box.Name = "Starttid_Box";
            this.Starttid_Box.ReadOnly = true;
            this.Starttid_Box.Size = new System.Drawing.Size(207, 42);
            this.Starttid_Box.TabIndex = 38;
            // 
            // EmitCard_picture
            // 
            this.EmitCard_picture.Image = ((System.Drawing.Image)(resources.GetObject("EmitCard_picture.Image")));
            this.EmitCard_picture.InitialImage = null;
            this.EmitCard_picture.Location = new System.Drawing.Point(677, 66);
            this.EmitCard_picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmitCard_picture.Name = "EmitCard_picture";
            this.EmitCard_picture.Size = new System.Drawing.Size(50, 50);
            this.EmitCard_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.EmitCard_picture.TabIndex = 37;
            this.EmitCard_picture.TabStop = false;
            this.EmitCard_picture.Visible = false;
            // 
            // EmiTag_picture
            // 
            this.EmiTag_picture.Image = ((System.Drawing.Image)(resources.GetObject("EmiTag_picture.Image")));
            this.EmiTag_picture.Location = new System.Drawing.Point(677, 66);
            this.EmiTag_picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmiTag_picture.Name = "EmiTag_picture";
            this.EmiTag_picture.Size = new System.Drawing.Size(50, 50);
            this.EmiTag_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.EmiTag_picture.TabIndex = 36;
            this.EmiTag_picture.TabStop = false;
            this.EmiTag_picture.Visible = false;
            // 
            // ChangeEcardNo_btn
            // 
            this.ChangeEcardNo_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.ChangeEcardNo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeEcardNo_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeEcardNo_btn.ForeColor = System.Drawing.Color.White;
            this.ChangeEcardNo_btn.Location = new System.Drawing.Point(764, 20);
            this.ChangeEcardNo_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeEcardNo_btn.Name = "ChangeEcardNo_btn";
            this.ChangeEcardNo_btn.Size = new System.Drawing.Size(244, 39);
            this.ChangeEcardNo_btn.TabIndex = 34;
            this.ChangeEcardNo_btn.Text = "ENDRE BRIKKENUMMER";
            this.ChangeEcardNo_btn.UseVisualStyleBackColor = false;
            this.ChangeEcardNo_btn.Click += new System.EventHandler(this.ChangeEcardNo_btn_Click);
            // 
            // NotStared_btn
            // 
            this.NotStared_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.NotStared_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotStared_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotStared_btn.ForeColor = System.Drawing.Color.White;
            this.NotStared_btn.Location = new System.Drawing.Point(764, 69);
            this.NotStared_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NotStared_btn.Name = "NotStared_btn";
            this.NotStared_btn.Size = new System.Drawing.Size(244, 39);
            this.NotStared_btn.TabIndex = 33;
            this.NotStared_btn.Text = "STARTNR IKKE STARTET";
            this.NotStared_btn.UseVisualStyleBackColor = false;
            this.NotStared_btn.Click += new System.EventHandler(this.NotStarted_btn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(539, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 18);
            this.label12.TabIndex = 32;
            this.label12.Text = "Batteri EmiTag";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 18);
            this.label11.TabIndex = 31;
            this.label11.Text = "Startnummer";
            // 
            // ID_box
            // 
            this.ID_box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ID_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ID_box.Enabled = false;
            this.ID_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_box.ForeColor = System.Drawing.SystemColors.Menu;
            this.ID_box.Location = new System.Drawing.Point(540, 46);
            this.ID_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID_box.Name = "ID_box";
            this.ID_box.Size = new System.Drawing.Size(115, 39);
            this.ID_box.TabIndex = 30;
            this.ID_box.Visible = false;
            // 
            // Battery_box
            // 
            this.Battery_box.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Battery_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Battery_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Battery_box.ForeColor = System.Drawing.Color.Blue;
            this.Battery_box.Location = new System.Drawing.Point(540, 114);
            this.Battery_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Battery_box.Name = "Battery_box";
            this.Battery_box.ReadOnly = true;
            this.Battery_box.Size = new System.Drawing.Size(99, 31);
            this.Battery_box.TabIndex = 29;
            // 
            // folderLogfile_box
            // 
            this.folderLogfile_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.folderLogfile_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folderLogfile_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderLogfile_box.Location = new System.Drawing.Point(175, 801);
            this.folderLogfile_box.Margin = new System.Windows.Forms.Padding(5, 2, 3, 2);
            this.folderLogfile_box.Name = "folderLogfile_box";
            this.folderLogfile_box.Size = new System.Drawing.Size(245, 27);
            this.folderLogfile_box.TabIndex = 42;
            this.folderLogfile_box.Leave += new System.EventHandler(this.folderLogfile_box_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 800);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Katalog for log-fil";
            // 
            // btnStartMTR
            // 
            this.btnStartMTR.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStartMTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartMTR.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMTR.ForeColor = System.Drawing.Color.White;
            this.btnStartMTR.Location = new System.Drawing.Point(227, 463);
            this.btnStartMTR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartMTR.Name = "btnStartMTR";
            this.btnStartMTR.Size = new System.Drawing.Size(132, 39);
            this.btnStartMTR.TabIndex = 44;
            this.btnStartMTR.Text = "START MTR";
            this.btnStartMTR.UseVisualStyleBackColor = false;
            this.btnStartMTR.Click += new System.EventHandler(this.btnReadMTR_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Controls.Add(this.Code251_radioButton);
            this.groupBox3.Controls.Add(this.Code70_radioButton);
            this.groupBox3.Controls.Add(this.readECUcode_box);
            this.groupBox3.Location = new System.Drawing.Point(15, 209);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(421, 81);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kode ECU brikkeleser";
            // 
            // Code251_radioButton
            // 
            this.Code251_radioButton.AutoSize = true;
            this.Code251_radioButton.Location = new System.Drawing.Point(21, 50);
            this.Code251_radioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Code251_radioButton.Name = "Code251_radioButton";
            this.Code251_radioButton.Size = new System.Drawing.Size(272, 21);
            this.Code251_radioButton.TabIndex = 52;
            this.Code251_radioButton.TabStop = true;
            this.Code251_radioButton.Text = "Kode 251 - Med batteristatus (tregere)";
            this.Code251_radioButton.UseVisualStyleBackColor = true;
            this.Code251_radioButton.CheckedChanged += new System.EventHandler(this.Code70_radioButton_CheckedChanged);
            // 
            // Code70_radioButton
            // 
            this.Code70_radioButton.AutoSize = true;
            this.Code70_radioButton.Location = new System.Drawing.Point(21, 23);
            this.Code70_radioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Code70_radioButton.Name = "Code70_radioButton";
            this.Code70_radioButton.Size = new System.Drawing.Size(133, 21);
            this.Code70_radioButton.TabIndex = 51;
            this.Code70_radioButton.TabStop = true;
            this.Code70_radioButton.Text = "Kode 70 - Hurtig";
            this.Code70_radioButton.UseVisualStyleBackColor = true;
            this.Code70_radioButton.CheckedChanged += new System.EventHandler(this.Code70_radioButton_CheckedChanged);
            // 
            // readECUcode_box
            // 
            this.readECUcode_box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.readECUcode_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readECUcode_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readECUcode_box.ForeColor = System.Drawing.Color.Red;
            this.readECUcode_box.Location = new System.Drawing.Point(333, 34);
            this.readECUcode_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readECUcode_box.Name = "readECUcode_box";
            this.readECUcode_box.Size = new System.Drawing.Size(73, 20);
            this.readECUcode_box.TabIndex = 49;
            // 
            // ReadEcu_btn
            // 
            this.ReadEcu_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.ReadEcu_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReadEcu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReadEcu_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadEcu_btn.ForeColor = System.Drawing.Color.White;
            this.ReadEcu_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReadEcu_btn.Location = new System.Drawing.Point(15, 463);
            this.ReadEcu_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReadEcu_btn.Name = "ReadEcu_btn";
            this.ReadEcu_btn.Size = new System.Drawing.Size(133, 39);
            this.ReadEcu_btn.TabIndex = 49;
            this.ReadEcu_btn.Text = "START ECU";
            this.ReadEcu_btn.UseVisualStyleBackColor = false;
            this.ReadEcu_btn.Click += new System.EventHandler(this.btnStartECU_Click);
            // 
            // LiveRes_checkBox
            // 
            this.LiveRes_checkBox.AutoSize = true;
            this.LiveRes_checkBox.Location = new System.Drawing.Point(19, 89);
            this.LiveRes_checkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LiveRes_checkBox.Name = "LiveRes_checkBox";
            this.LiveRes_checkBox.Size = new System.Drawing.Size(219, 21);
            this.LiveRes_checkBox.TabIndex = 30;
            this.LiveRes_checkBox.Text = "Kommunikasjon med LiveRes ";
            this.LiveRes_checkBox.UseVisualStyleBackColor = true;
            this.LiveRes_checkBox.CheckedChanged += new System.EventHandler(this.LiveRes_checkBox_CheckedChanged);
            // 
            // WarningSoundNotFound_checkBox
            // 
            this.WarningSoundNotFound_checkBox.AutoSize = true;
            this.WarningSoundNotFound_checkBox.Location = new System.Drawing.Point(19, 114);
            this.WarningSoundNotFound_checkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WarningSoundNotFound_checkBox.Name = "WarningSoundNotFound_checkBox";
            this.WarningSoundNotFound_checkBox.Size = new System.Drawing.Size(204, 21);
            this.WarningSoundNotFound_checkBox.TabIndex = 51;
            this.WarningSoundNotFound_checkBox.Text = "Lydvarsel på - ukjent brikke";
            this.WarningSoundNotFound_checkBox.UseVisualStyleBackColor = true;
            // 
            // version
            // 
            this.version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.version.AutoSize = true;
            this.version.ForeColor = System.Drawing.SystemColors.Highlight;
            this.version.Location = new System.Drawing.Point(497, 807);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(106, 17);
            this.version.TabIndex = 52;
            this.version.Text = "Ver 20.07.2023";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(617, 801);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(380, 22);
            this.progressBar1.Step = 5;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 53;
            // 
            // GetFolderButton
            // 
            this.GetFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GetFolderButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.GetFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetFolderButton.ForeColor = System.Drawing.Color.White;
            this.GetFolderButton.Location = new System.Drawing.Point(439, 794);
            this.GetFolderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetFolderButton.Name = "GetFolderButton";
            this.GetFolderButton.Size = new System.Drawing.Size(53, 39);
            this.GetFolderButton.TabIndex = 54;
            this.GetFolderButton.Text = "...";
            this.GetFolderButton.UseVisualStyleBackColor = false;
            this.GetFolderButton.Click += new System.EventHandler(this.GetFolderButton_Click);
            // 
            // WarningSoundFound_checkBox
            // 
            this.WarningSoundFound_checkBox.AutoSize = true;
            this.WarningSoundFound_checkBox.Location = new System.Drawing.Point(19, 142);
            this.WarningSoundFound_checkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WarningSoundFound_checkBox.Name = "WarningSoundFound_checkBox";
            this.WarningSoundFound_checkBox.Size = new System.Drawing.Size(186, 21);
            this.WarningSoundFound_checkBox.TabIndex = 55;
            this.WarningSoundFound_checkBox.Text = "Lydvarsel på - brikke OK";
            this.WarningSoundFound_checkBox.UseVisualStyleBackColor = true;
            this.WarningSoundFound_checkBox.CheckedChanged += new System.EventHandler(this.WarningSoundFound_checkBox_CheckedChanged);
            // 
            // TextToSpeechFound_checkBox
            // 
            this.TextToSpeechFound_checkBox.AutoSize = true;
            this.TextToSpeechFound_checkBox.Location = new System.Drawing.Point(19, 169);
            this.TextToSpeechFound_checkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextToSpeechFound_checkBox.Name = "TextToSpeechFound_checkBox";
            this.TextToSpeechFound_checkBox.Size = new System.Drawing.Size(193, 21);
            this.TextToSpeechFound_checkBox.TabIndex = 56;
            this.TextToSpeechFound_checkBox.Text = "Opplesing av startnr/navn";
            this.TextToSpeechFound_checkBox.UseVisualStyleBackColor = true;
            this.TextToSpeechFound_checkBox.CheckedChanged += new System.EventHandler(this.TextToSpeechFound_checkBox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(904, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 19);
            this.label8.TabIndex = 59;
            this.label8.Text = "F2 - Gå til startnrfelt   F3 - Endre brikkenr";
            // 
            // SearchName_Box
            // 
            this.SearchName_Box.BackColor = System.Drawing.SystemColors.Window;
            this.SearchName_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchName_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchName_Box.Location = new System.Drawing.Point(1164, 475);
            this.SearchName_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchName_Box.Name = "SearchName_Box";
            this.SearchName_Box.Size = new System.Drawing.Size(322, 28);
            this.SearchName_Box.TabIndex = 60;
            this.SearchName_Box.TextChanged += new System.EventHandler(this.SearchName_Box_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1160, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 61;
            this.label10.Text = "Søk etter navn";
            // 
            // LiveresMessages_btn
            // 
            this.LiveresMessages_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LiveresMessages_btn.AutoSize = true;
            this.LiveresMessages_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.LiveresMessages_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LiveresMessages_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiveresMessages_btn.ForeColor = System.Drawing.Color.White;
            this.LiveresMessages_btn.Location = new System.Drawing.Point(1228, 794);
            this.LiveresMessages_btn.Margin = new System.Windows.Forms.Padding(4);
            this.LiveresMessages_btn.Name = "LiveresMessages_btn";
            this.LiveresMessages_btn.Size = new System.Drawing.Size(244, 39);
            this.LiveresMessages_btn.TabIndex = 39;
            this.LiveresMessages_btn.Text = "LIVERES MELDINGSERVER";
            this.LiveresMessages_btn.UseVisualStyleBackColor = false;
            this.LiveresMessages_btn.Click += new System.EventHandler(this.LiveresMessages_btn_Click);
            // 
            // OppdaterFrekvens_box
            // 
            this.OppdaterFrekvens_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OppdaterFrekvens_box.BackColor = System.Drawing.SystemColors.Window;
            this.OppdaterFrekvens_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OppdaterFrekvens_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OppdaterFrekvens_box.Location = new System.Drawing.Point(1113, 799);
            this.OppdaterFrekvens_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OppdaterFrekvens_box.Name = "OppdaterFrekvens_box";
            this.OppdaterFrekvens_box.Size = new System.Drawing.Size(43, 28);
            this.OppdaterFrekvens_box.TabIndex = 62;
            this.OppdaterFrekvens_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.OppdaterFrekvens_box, "Ant minutter mellom hver oppdatering av LiveRes startlste.");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1022, 792);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 42);
            this.label3.TabIndex = 63;
            this.label3.Text = "Startliste oppdatering";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1164, 804);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 17);
            this.label13.TabIndex = 64;
            this.label13.Text = "minutt";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // TimerStartliste
            // 
            this.TimerStartliste.Interval = 1000;
            this.TimerStartliste.Tick += new System.EventHandler(this.TimerStartliste_Tick);
            // 
            // TimerStartliste_lbl
            // 
            this.TimerStartliste_lbl.AutoSize = true;
            this.TimerStartliste_lbl.Location = new System.Drawing.Point(614, 781);
            this.TimerStartliste_lbl.Name = "TimerStartliste_lbl";
            this.TimerStartliste_lbl.Size = new System.Drawing.Size(188, 17);
            this.TimerStartliste_lbl.TabIndex = 65;
            this.TimerStartliste_lbl.Text = "Lesing av startliste ikke aktiv";
            // 
            // MTR_read_led
            // 
            this.MTR_read_led.Color = System.Drawing.Color.Red;
            this.MTR_read_led.Location = new System.Drawing.Point(364, 465);
            this.MTR_read_led.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MTR_read_led.Name = "MTR_read_led";
            this.MTR_read_led.On = true;
            this.MTR_read_led.Size = new System.Drawing.Size(35, 34);
            this.MTR_read_led.TabIndex = 58;
            this.MTR_read_led.Text = "ledBulb1";
            // 
            // ECU_read_led
            // 
            this.ECU_read_led.Color = System.Drawing.Color.Red;
            this.ECU_read_led.Location = new System.Drawing.Point(161, 465);
            this.ECU_read_led.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ECU_read_led.Name = "ECU_read_led";
            this.ECU_read_led.On = true;
            this.ECU_read_led.Size = new System.Drawing.Size(35, 34);
            this.ECU_read_led.TabIndex = 57;
            this.ECU_read_led.Text = "ledBulb1";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1504, 846);
            this.Controls.Add(this.TimerStartliste_lbl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OppdaterFrekvens_box);
            this.Controls.Add(this.LiveresMessages_btn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SearchName_Box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MTR_read_led);
            this.Controls.Add(this.ECU_read_led);
            this.Controls.Add(this.TextToSpeechFound_checkBox);
            this.Controls.Add(this.WarningSoundFound_checkBox);
            this.Controls.Add(this.GetFolderButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.version);
            this.Controls.Add(this.WarningSoundNotFound_checkBox);
            this.Controls.Add(this.LiveRes_checkBox);
            this.Controls.Add(this.ReadEcu_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnStartMTR);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.folderLogfile_box);
            this.Controls.Add(this.Løperinfo);
            this.Controls.Add(this.Clock_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readBrikkesjekkfil_btn);
            this.Controls.Add(this.readLiveResfil_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LiveRes_groupBox);
            this.Controls.Add(this.UsbRead_listBox);
            this.Controls.Add(this.SearchCard_Txtbox);
            this.Controls.Add(this.SearchCard_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Close_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "Brikkesjekk";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.LiveRes_groupBox.ResumeLayout(false);
            this.LiveRes_groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.Løperinfo.ResumeLayout(false);
            this.Løperinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmitCard_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmiTag_picture)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox UsbPort_listBox;
        private System.Windows.Forms.Button RefreshUsbPort_btn;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Label Clock_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchCard_btn;
        private System.Windows.Forms.ListBox UsbRead_listBox;
        private System.Windows.Forms.TextBox Navn_box;
        private System.Windows.Forms.TextBox Klubb_box;
        private System.Windows.Forms.TextBox Klasse_box;
        private System.Windows.Forms.TextBox Ecard_box;
        private System.Windows.Forms.TextBox Ecard2_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SendMessage_btn;
        private System.Windows.Forms.TextBox lopsid_box;
        private System.Windows.Forms.TextBox lopsnavn_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox LiveRes_groupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button readLiveResfil_btn;
        private System.Windows.Forms.Button readBrikkesjekkfil_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Løperinfo;
        private System.Windows.Forms.TextBox folderLogfile_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Battery_box;
        private System.Windows.Forms.Button btnStartMTR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ReadEcu_btn;
        private System.Windows.Forms.CheckBox LiveRes_checkBox;
        private System.Windows.Forms.TextBox readECUcode_box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button NotStared_btn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ChangeEcardNo_btn;
        private System.Windows.Forms.TextBox ID_box;
        private System.Windows.Forms.CheckBox WarningSoundNotFound_checkBox;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button GetFolderButton;
        private System.Windows.Forms.ComboBox comboBoxLiveRes;
        private System.Windows.Forms.CheckBox WarningSoundFound_checkBox;
        private System.Windows.Forms.RadioButton Code251_radioButton;
        private System.Windows.Forms.RadioButton Code70_radioButton;
        private System.Windows.Forms.CheckBox TextToSpeechFound_checkBox;
        public System.Windows.Forms.TextBox StartNr_box;
        public System.Windows.Forms.TextBox SearchCard_Txtbox;
        private Brikkesjekk.LedBulb ECU_read_led;
        private LedBulb MTR_read_led;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox SearchName_Box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox EmiTag_picture;
        private System.Windows.Forms.PictureBox EmitCard_picture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lopsdato_box;
        private System.Windows.Forms.TextBox Starttid_Box;
        private System.Windows.Forms.Button LiveresMessages_btn;
        public System.Windows.Forms.TextBox OppdaterFrekvens_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer TimerStartliste;
        private System.Windows.Forms.Label TimerStartliste_lbl;
    }
}

