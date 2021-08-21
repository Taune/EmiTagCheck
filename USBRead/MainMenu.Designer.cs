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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.UsbPort_listBox = new System.Windows.Forms.ListBox();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Clock_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchCard_btn = new System.Windows.Forms.Button();
            this.SearchCard_Txtbox = new System.Windows.Forms.TextBox();
            this.UsbRead_listBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.comboBoxLiveRes = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RefreshUsbPort_btn = new System.Windows.Forms.Button();
            this.readLiveResfil_btn = new System.Windows.Forms.Button();
            this.readBrikkesjekkfil_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Løperinfo = new System.Windows.Forms.GroupBox();
            this.ledBulb_funnet = new Brikkesjekk.LedBulb();
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
            this.MTR_read_led = new Brikkesjekk.LedBulb();
            this.ECU_read_led = new Brikkesjekk.LedBulb();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.LiveRes_groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Løperinfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsbPort_listBox
            // 
            this.UsbPort_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsbPort_listBox.FormattingEnabled = true;
            this.UsbPort_listBox.ItemHeight = 20;
            this.UsbPort_listBox.Location = new System.Drawing.Point(16, 28);
            this.UsbPort_listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsbPort_listBox.Name = "UsbPort_listBox";
            this.UsbPort_listBox.Size = new System.Drawing.Size(143, 104);
            this.UsbPort_listBox.Sorted = true;
            this.UsbPort_listBox.TabIndex = 2;
            this.UsbPort_listBox.SelectedIndexChanged += new System.EventHandler(this.UsbPort_listBox_SelectedIndexChanged);
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.Location = new System.Drawing.Point(15, 14);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(141, 34);
            this.Close_btn.TabIndex = 4;
            this.Close_btn.Text = "Avslutt program";
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Clock_lbl
            // 
            this.Clock_lbl.AutoSize = true;
            this.Clock_lbl.BackColor = System.Drawing.Color.DarkRed;
            this.Clock_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Clock_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock_lbl.ForeColor = System.Drawing.Color.Yellow;
            this.Clock_lbl.Location = new System.Drawing.Point(1331, 11);
            this.Clock_lbl.Name = "Clock_lbl";
            this.Clock_lbl.Size = new System.Drawing.Size(129, 34);
            this.Clock_lbl.TabIndex = 9;
            this.Clock_lbl.Text = "00:00:00";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(617, 516);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(843, 263);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SearchCard_btn
            // 
            this.SearchCard_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchCard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCard_btn.Location = new System.Drawing.Point(464, 9);
            this.SearchCard_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchCard_btn.Name = "SearchCard_btn";
            this.SearchCard_btn.Size = new System.Drawing.Size(195, 34);
            this.SearchCard_btn.TabIndex = 12;
            this.SearchCard_btn.Text = "Søk brikke manuelt";
            this.SearchCard_btn.UseVisualStyleBackColor = false;
            this.SearchCard_btn.Click += new System.EventHandler(this.SearchCard_btn_Click);
            // 
            // SearchCard_Txtbox
            // 
            this.SearchCard_Txtbox.BackColor = System.Drawing.SystemColors.Info;
            this.SearchCard_Txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCard_Txtbox.Location = new System.Drawing.Point(664, 12);
            this.SearchCard_Txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchCard_Txtbox.Name = "SearchCard_Txtbox";
            this.SearchCard_Txtbox.Size = new System.Drawing.Size(153, 30);
            this.SearchCard_Txtbox.TabIndex = 13;
            this.SearchCard_Txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchCard_Txtbox_KeyPress);
            // 
            // UsbRead_listBox
            // 
            this.UsbRead_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsbRead_listBox.FormattingEnabled = true;
            this.UsbRead_listBox.ItemHeight = 18;
            this.UsbRead_listBox.Location = new System.Drawing.Point(15, 516);
            this.UsbRead_listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsbRead_listBox.Name = "UsbRead_listBox";
            this.UsbRead_listBox.Size = new System.Drawing.Size(581, 274);
            this.UsbRead_listBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "EmiTag Log";
            // 
            // StartNr_box
            // 
            this.StartNr_box.BackColor = System.Drawing.SystemColors.Info;
            this.StartNr_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartNr_box.ForeColor = System.Drawing.Color.Red;
            this.StartNr_box.Location = new System.Drawing.Point(16, 43);
            this.StartNr_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartNr_box.Name = "StartNr_box";
            this.StartNr_box.Size = new System.Drawing.Size(243, 109);
            this.StartNr_box.TabIndex = 18;
            this.StartNr_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartNr_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartNr_box_KeyPress);
            // 
            // Navn_box
            // 
            this.Navn_box.BackColor = System.Drawing.SystemColors.Control;
            this.Navn_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Navn_box.ForeColor = System.Drawing.Color.Green;
            this.Navn_box.Location = new System.Drawing.Point(16, 179);
            this.Navn_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Navn_box.Name = "Navn_box";
            this.Navn_box.ReadOnly = true;
            this.Navn_box.Size = new System.Drawing.Size(993, 87);
            this.Navn_box.TabIndex = 19;
            // 
            // Klubb_box
            // 
            this.Klubb_box.BackColor = System.Drawing.SystemColors.Control;
            this.Klubb_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klubb_box.ForeColor = System.Drawing.Color.Red;
            this.Klubb_box.Location = new System.Drawing.Point(16, 275);
            this.Klubb_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Klubb_box.Name = "Klubb_box";
            this.Klubb_box.ReadOnly = true;
            this.Klubb_box.Size = new System.Drawing.Size(993, 49);
            this.Klubb_box.TabIndex = 20;
            // 
            // Klasse_box
            // 
            this.Klasse_box.BackColor = System.Drawing.SystemColors.Control;
            this.Klasse_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klasse_box.ForeColor = System.Drawing.Color.Red;
            this.Klasse_box.Location = new System.Drawing.Point(16, 332);
            this.Klasse_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Klasse_box.Name = "Klasse_box";
            this.Klasse_box.ReadOnly = true;
            this.Klasse_box.Size = new System.Drawing.Size(993, 49);
            this.Klasse_box.TabIndex = 21;
            // 
            // Ecard_box
            // 
            this.Ecard_box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Ecard_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecard_box.ForeColor = System.Drawing.Color.Blue;
            this.Ecard_box.Location = new System.Drawing.Point(280, 43);
            this.Ecard_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ecard_box.Name = "Ecard_box";
            this.Ecard_box.ReadOnly = true;
            this.Ecard_box.Size = new System.Drawing.Size(219, 45);
            this.Ecard_box.TabIndex = 22;
            // 
            // Ecard2_box
            // 
            this.Ecard2_box.BackColor = System.Drawing.SystemColors.Control;
            this.Ecard2_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecard2_box.ForeColor = System.Drawing.Color.Blue;
            this.Ecard2_box.Location = new System.Drawing.Point(280, 108);
            this.Ecard2_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ecard2_box.Name = "Ecard2_box";
            this.Ecard2_box.ReadOnly = true;
            this.Ecard2_box.Size = new System.Drawing.Size(219, 45);
            this.Ecard2_box.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Brikke 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Brikke 2";
            // 
            // SendMessage_btn
            // 
            this.SendMessage_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SendMessage_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMessage_btn.Location = new System.Drawing.Point(764, 133);
            this.SendMessage_btn.Margin = new System.Windows.Forms.Padding(4);
            this.SendMessage_btn.Name = "SendMessage_btn";
            this.SendMessage_btn.Size = new System.Drawing.Size(244, 39);
            this.SendMessage_btn.TabIndex = 29;
            this.SendMessage_btn.Text = "Melding til LiveRes";
            this.SendMessage_btn.UseVisualStyleBackColor = false;
            this.SendMessage_btn.Click += new System.EventHandler(this.SendMessage_btn_Click);
            // 
            // lopsid_box
            // 
            this.lopsid_box.BackColor = System.Drawing.SystemColors.Control;
            this.lopsid_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopsid_box.Location = new System.Drawing.Point(79, 35);
            this.lopsid_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lopsid_box.Name = "lopsid_box";
            this.lopsid_box.ReadOnly = true;
            this.lopsid_box.Size = new System.Drawing.Size(111, 27);
            this.lopsid_box.TabIndex = 30;
            // 
            // lopsnavn_box
            // 
            this.lopsnavn_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopsnavn_box.Location = new System.Drawing.Point(79, 70);
            this.lopsnavn_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lopsnavn_box.Name = "lopsnavn_box";
            this.lopsnavn_box.ReadOnly = true;
            this.lopsnavn_box.Size = new System.Drawing.Size(327, 27);
            this.lopsnavn_box.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Navn";
            // 
            // LiveRes_groupBox
            // 
            this.LiveRes_groupBox.Controls.Add(this.comboBoxLiveRes);
            this.LiveRes_groupBox.Controls.Add(this.label7);
            this.LiveRes_groupBox.Controls.Add(this.label6);
            this.LiveRes_groupBox.Controls.Add(this.lopsnavn_box);
            this.LiveRes_groupBox.Controls.Add(this.lopsid_box);
            this.LiveRes_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiveRes_groupBox.Location = new System.Drawing.Point(15, 317);
            this.LiveRes_groupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LiveRes_groupBox.Name = "LiveRes_groupBox";
            this.LiveRes_groupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LiveRes_groupBox.Size = new System.Drawing.Size(421, 123);
            this.LiveRes_groupBox.TabIndex = 34;
            this.LiveRes_groupBox.TabStop = false;
            this.LiveRes_groupBox.Text = "Arrangementsinfo LiveRes";
            // 
            // comboBoxLiveRes
            // 
            this.comboBoxLiveRes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBoxLiveRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLiveRes.DropDownWidth = 400;
            this.comboBoxLiveRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLiveRes.FormattingEnabled = true;
            this.comboBoxLiveRes.ItemHeight = 20;
            this.comboBoxLiveRes.Location = new System.Drawing.Point(196, 34);
            this.comboBoxLiveRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLiveRes.Name = "comboBoxLiveRes";
            this.comboBoxLiveRes.Size = new System.Drawing.Size(210, 28);
            this.comboBoxLiveRes.TabIndex = 38;
            this.comboBoxLiveRes.SelectionChangeCommitted += new System.EventHandler(this.comboBoxLiveRes_SelectedValueChanged);
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
            this.groupBox2.Size = new System.Drawing.Size(172, 185);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Velg Port";
            // 
            // RefreshUsbPort_btn
            // 
            this.RefreshUsbPort_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RefreshUsbPort_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshUsbPort_btn.Image = global::Brikkesjekk.Properties.Resources.reload_button11;
            this.RefreshUsbPort_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefreshUsbPort_btn.Location = new System.Drawing.Point(16, 132);
            this.RefreshUsbPort_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshUsbPort_btn.Name = "RefreshUsbPort_btn";
            this.RefreshUsbPort_btn.Size = new System.Drawing.Size(141, 43);
            this.RefreshUsbPort_btn.TabIndex = 3;
            this.RefreshUsbPort_btn.Text = "Oppfrisk";
            this.RefreshUsbPort_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RefreshUsbPort_btn.UseVisualStyleBackColor = false;
            this.RefreshUsbPort_btn.Click += new System.EventHandler(this.RefreshUsbPort_btn_Click);
            // 
            // readLiveResfil_btn
            // 
            this.readLiveResfil_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.readLiveResfil_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readLiveResfil_btn.Location = new System.Drawing.Point(885, 460);
            this.readLiveResfil_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readLiveResfil_btn.Name = "readLiveResfil_btn";
            this.readLiveResfil_btn.Size = new System.Drawing.Size(240, 39);
            this.readLiveResfil_btn.TabIndex = 37;
            this.readLiveResfil_btn.Text = "Les startliste LiveRes";
            this.readLiveResfil_btn.UseVisualStyleBackColor = false;
            this.readLiveResfil_btn.Click += new System.EventHandler(this.readLiveResfil_btn_Click);
            // 
            // readBrikkesjekkfil_btn
            // 
            this.readBrikkesjekkfil_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.readBrikkesjekkfil_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBrikkesjekkfil_btn.Location = new System.Drawing.Point(617, 459);
            this.readBrikkesjekkfil_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readBrikkesjekkfil_btn.Name = "readBrikkesjekkfil_btn";
            this.readBrikkesjekkfil_btn.Size = new System.Drawing.Size(252, 39);
            this.readBrikkesjekkfil_btn.TabIndex = 39;
            this.readBrikkesjekkfil_btn.Text = "Les startliste Brikkesjekkfil";
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
            this.Løperinfo.BackColor = System.Drawing.SystemColors.Control;
            this.Løperinfo.Controls.Add(this.ledBulb_funnet);
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
            this.Løperinfo.Location = new System.Drawing.Point(456, 49);
            this.Løperinfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Løperinfo.Name = "Løperinfo";
            this.Løperinfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Løperinfo.Size = new System.Drawing.Size(1023, 392);
            this.Løperinfo.TabIndex = 41;
            this.Løperinfo.TabStop = false;
            this.Løperinfo.Text = "Løperinfo";
            // 
            // ledBulb_funnet
            // 
            this.ledBulb_funnet.Location = new System.Drawing.Point(671, 66);
            this.ledBulb_funnet.Name = "ledBulb_funnet";
            this.ledBulb_funnet.On = false;
            this.ledBulb_funnet.Size = new System.Drawing.Size(60, 60);
            this.ledBulb_funnet.TabIndex = 35;
            this.ledBulb_funnet.Text = "ledBulb1";
            // 
            // ChangeEcardNo_btn
            // 
            this.ChangeEcardNo_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChangeEcardNo_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeEcardNo_btn.Location = new System.Drawing.Point(764, 14);
            this.ChangeEcardNo_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeEcardNo_btn.Name = "ChangeEcardNo_btn";
            this.ChangeEcardNo_btn.Size = new System.Drawing.Size(244, 69);
            this.ChangeEcardNo_btn.TabIndex = 34;
            this.ChangeEcardNo_btn.Text = "Endre brikkenummer";
            this.ChangeEcardNo_btn.UseVisualStyleBackColor = false;
            this.ChangeEcardNo_btn.Click += new System.EventHandler(this.ChangeEcardNo_btn_Click);
            // 
            // NotStared_btn
            // 
            this.NotStared_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NotStared_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotStared_btn.Location = new System.Drawing.Point(764, 88);
            this.NotStared_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NotStared_btn.Name = "NotStared_btn";
            this.NotStared_btn.Size = new System.Drawing.Size(244, 40);
            this.NotStared_btn.TabIndex = 33;
            this.NotStared_btn.Text = "Startnr ikke startet";
            this.NotStared_btn.UseVisualStyleBackColor = false;
            this.NotStared_btn.Click += new System.EventHandler(this.NotStared_btn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(515, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 18);
            this.label12.TabIndex = 32;
            this.label12.Text = "Batteristatus";
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
            this.ID_box.BackColor = System.Drawing.SystemColors.Menu;
            this.ID_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ID_box.Enabled = false;
            this.ID_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_box.ForeColor = System.Drawing.SystemColors.Menu;
            this.ID_box.Location = new System.Drawing.Point(517, 45);
            this.ID_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID_box.Name = "ID_box";
            this.ID_box.Size = new System.Drawing.Size(115, 39);
            this.ID_box.TabIndex = 30;
            // 
            // Battery_box
            // 
            this.Battery_box.BackColor = System.Drawing.SystemColors.Control;
            this.Battery_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Battery_box.ForeColor = System.Drawing.Color.Blue;
            this.Battery_box.Location = new System.Drawing.Point(517, 108);
            this.Battery_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Battery_box.Name = "Battery_box";
            this.Battery_box.ReadOnly = true;
            this.Battery_box.Size = new System.Drawing.Size(113, 45);
            this.Battery_box.TabIndex = 29;
            // 
            // folderLogfile_box
            // 
            this.folderLogfile_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderLogfile_box.Location = new System.Drawing.Point(171, 798);
            this.folderLogfile_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.folderLogfile_box.Name = "folderLogfile_box";
            this.folderLogfile_box.Size = new System.Drawing.Size(265, 27);
            this.folderLogfile_box.TabIndex = 42;
            this.folderLogfile_box.Leave += new System.EventHandler(this.folderLogfile_box_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 799);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Katalog for log-fil";
            // 
            // btnStartMTR
            // 
            this.btnStartMTR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStartMTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMTR.Location = new System.Drawing.Point(348, 466);
            this.btnStartMTR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartMTR.Name = "btnStartMTR";
            this.btnStartMTR.Size = new System.Drawing.Size(123, 42);
            this.btnStartMTR.TabIndex = 44;
            this.btnStartMTR.Text = "Start MTR";
            this.btnStartMTR.UseVisualStyleBackColor = false;
            this.btnStartMTR.Click += new System.EventHandler(this.btnReadMTR_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Code251_radioButton);
            this.groupBox3.Controls.Add(this.Code70_radioButton);
            this.groupBox3.Controls.Add(this.readECUcode_box);
            this.groupBox3.Location = new System.Drawing.Point(15, 216);
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
            this.Code251_radioButton.Location = new System.Drawing.Point(22, 50);
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
            this.Code70_radioButton.Location = new System.Drawing.Point(22, 23);
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
            this.readECUcode_box.BackColor = System.Drawing.SystemColors.Menu;
            this.readECUcode_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readECUcode_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readECUcode_box.ForeColor = System.Drawing.Color.Red;
            this.readECUcode_box.Location = new System.Drawing.Point(333, 35);
            this.readECUcode_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readECUcode_box.Name = "readECUcode_box";
            this.readECUcode_box.Size = new System.Drawing.Size(73, 20);
            this.readECUcode_box.TabIndex = 49;
            // 
            // ReadEcu_btn
            // 
            this.ReadEcu_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReadEcu_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReadEcu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadEcu_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReadEcu_btn.Location = new System.Drawing.Point(136, 466);
            this.ReadEcu_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReadEcu_btn.Name = "ReadEcu_btn";
            this.ReadEcu_btn.Size = new System.Drawing.Size(133, 42);
            this.ReadEcu_btn.TabIndex = 49;
            this.ReadEcu_btn.Text = "Start ECU";
            this.ReadEcu_btn.UseVisualStyleBackColor = false;
            this.ReadEcu_btn.Click += new System.EventHandler(this.btnStartECU_Click);
            // 
            // LiveRes_checkBox
            // 
            this.LiveRes_checkBox.AutoSize = true;
            this.LiveRes_checkBox.Location = new System.Drawing.Point(19, 88);
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
            this.WarningSoundNotFound_checkBox.Location = new System.Drawing.Point(19, 115);
            this.WarningSoundNotFound_checkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WarningSoundNotFound_checkBox.Name = "WarningSoundNotFound_checkBox";
            this.WarningSoundNotFound_checkBox.Size = new System.Drawing.Size(204, 21);
            this.WarningSoundNotFound_checkBox.TabIndex = 51;
            this.WarningSoundNotFound_checkBox.Text = "Lydvarsel på - ukjent brikke";
            this.WarningSoundNotFound_checkBox.UseVisualStyleBackColor = true;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.ForeColor = System.Drawing.SystemColors.Highlight;
            this.version.Location = new System.Drawing.Point(489, 807);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(106, 17);
            this.version.TabIndex = 52;
            this.version.Text = "Ver 21.08.2021";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(617, 502);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(841, 10);
            this.progressBar1.TabIndex = 53;
            // 
            // GetFolderButton
            // 
            this.GetFolderButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GetFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetFolderButton.Location = new System.Drawing.Point(441, 798);
            this.GetFolderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GetFolderButton.Name = "GetFolderButton";
            this.GetFolderButton.Size = new System.Drawing.Size(43, 28);
            this.GetFolderButton.TabIndex = 54;
            this.GetFolderButton.Text = "...";
            this.GetFolderButton.UseVisualStyleBackColor = false;
            this.GetFolderButton.Click += new System.EventHandler(this.GetFolderButton_Click);
            // 
            // WarningSoundFound_checkBox
            // 
            this.WarningSoundFound_checkBox.AutoSize = true;
            this.WarningSoundFound_checkBox.Location = new System.Drawing.Point(19, 142);
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
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(837, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(268, 17);
            this.label8.TabIndex = 59;
            this.label8.Text = "F2 - Gå til startnrfelt   F3 - Endre brikkenr";
            // 
            // SearchName_Box
            // 
            this.SearchName_Box.BackColor = System.Drawing.SystemColors.Info;
            this.SearchName_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchName_Box.Location = new System.Drawing.Point(1144, 468);
            this.SearchName_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchName_Box.Name = "SearchName_Box";
            this.SearchName_Box.Size = new System.Drawing.Size(316, 27);
            this.SearchName_Box.TabIndex = 60;
            this.SearchName_Box.TextChanged += new System.EventHandler(this.SearchName_Box_TextChanged);
            // 
            // MTR_read_led
            // 
            this.MTR_read_led.Color = System.Drawing.Color.Red;
            this.MTR_read_led.Location = new System.Drawing.Point(486, 469);
            this.MTR_read_led.Name = "MTR_read_led";
            this.MTR_read_led.On = true;
            this.MTR_read_led.Size = new System.Drawing.Size(35, 35);
            this.MTR_read_led.TabIndex = 58;
            this.MTR_read_led.Text = "ledBulb1";
            // 
            // ECU_read_led
            // 
            this.ECU_read_led.Color = System.Drawing.Color.Red;
            this.ECU_read_led.Location = new System.Drawing.Point(283, 469);
            this.ECU_read_led.Name = "ECU_read_led";
            this.ECU_read_led.On = true;
            this.ECU_read_led.Size = new System.Drawing.Size(35, 35);
            this.ECU_read_led.TabIndex = 57;
            this.ECU_read_led.Text = "ledBulb1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1142, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 61;
            this.label10.Text = "Søk etter navn";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 846);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readBrikkesjekkfil_btn);
            this.Controls.Add(this.readLiveResfil_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LiveRes_groupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsbRead_listBox);
            this.Controls.Add(this.SearchCard_Txtbox);
            this.Controls.Add(this.SearchCard_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Clock_lbl);
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
        private System.Windows.Forms.Label label3;
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
        private LedBulb ledBulb_funnet;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox SearchName_Box;
        private System.Windows.Forms.Label label10;
    }
}

