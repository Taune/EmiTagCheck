namespace USBRead
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
            this.UsbPort_listBox = new System.Windows.Forms.ListBox();
            this.RefreshUsbPort_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.UnknownEcard_btn = new System.Windows.Forms.Button();
            this.lopsid_box = new System.Windows.Forms.TextBox();
            this.lopsnavn_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LiveRes_groupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.readLiveResfil_btn = new System.Windows.Forms.Button();
            this.readBrikkesjekkfil_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Løperinfo = new System.Windows.Forms.GroupBox();
            this.Battery_box = new System.Windows.Forms.TextBox();
            this.folderLogfile_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnStartMTR = new System.Windows.Forms.Button();
            this.ecuCode_box = new System.Windows.Forms.TextBox();
            this.ChangeEcuCode_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ReadEcu_btn = new System.Windows.Forms.Button();
            this.LiveRes_checkBox = new System.Windows.Forms.CheckBox();
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
            this.UsbPort_listBox.Location = new System.Drawing.Point(16, 24);
            this.UsbPort_listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsbPort_listBox.Name = "UsbPort_listBox";
            this.UsbPort_listBox.Size = new System.Drawing.Size(142, 104);
            this.UsbPort_listBox.Sorted = true;
            this.UsbPort_listBox.TabIndex = 2;
            this.UsbPort_listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // RefreshUsbPort_btn
            // 
            this.RefreshUsbPort_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshUsbPort_btn.Location = new System.Drawing.Point(16, 137);
            this.RefreshUsbPort_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshUsbPort_btn.Name = "RefreshUsbPort_btn";
            this.RefreshUsbPort_btn.Size = new System.Drawing.Size(142, 34);
            this.RefreshUsbPort_btn.TabIndex = 3;
            this.RefreshUsbPort_btn.Text = "Oppfrisk";
            this.RefreshUsbPort_btn.UseVisualStyleBackColor = true;
            this.RefreshUsbPort_btn.Click += new System.EventHandler(this.RefreshUsbPort_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.Location = new System.Drawing.Point(15, 14);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(142, 34);
            this.Close_btn.TabIndex = 4;
            this.Close_btn.Text = "Avslutt program";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(660, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Deltakere";
            // 
            // Clock_lbl
            // 
            this.Clock_lbl.AutoSize = true;
            this.Clock_lbl.BackColor = System.Drawing.SystemColors.Info;
            this.Clock_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Clock_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock_lbl.Location = new System.Drawing.Point(1330, 11);
            this.Clock_lbl.Name = "Clock_lbl";
            this.Clock_lbl.Size = new System.Drawing.Size(129, 34);
            this.Clock_lbl.TabIndex = 9;
            this.Clock_lbl.Text = "00:00:00";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(664, 514);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 289);
            this.dataGridView1.TabIndex = 11;
            // 
            // SearchCard_btn
            // 
            this.SearchCard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCard_btn.Location = new System.Drawing.Point(464, 11);
            this.SearchCard_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchCard_btn.Name = "SearchCard_btn";
            this.SearchCard_btn.Size = new System.Drawing.Size(194, 34);
            this.SearchCard_btn.TabIndex = 12;
            this.SearchCard_btn.Text = "Søk brikke manuelt";
            this.SearchCard_btn.UseVisualStyleBackColor = true;
            this.SearchCard_btn.Click += new System.EventHandler(this.SearchCard_btn_Click);
            // 
            // SearchCard_Txtbox
            // 
            this.SearchCard_Txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCard_Txtbox.Location = new System.Drawing.Point(664, 13);
            this.SearchCard_Txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchCard_Txtbox.Name = "SearchCard_Txtbox";
            this.SearchCard_Txtbox.Size = new System.Drawing.Size(154, 30);
            this.SearchCard_Txtbox.TabIndex = 13;
            // 
            // UsbRead_listBox
            // 
            this.UsbRead_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsbRead_listBox.FormattingEnabled = true;
            this.UsbRead_listBox.ItemHeight = 15;
            this.UsbRead_listBox.Location = new System.Drawing.Point(15, 514);
            this.UsbRead_listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsbRead_listBox.Name = "UsbRead_listBox";
            this.UsbRead_listBox.Size = new System.Drawing.Size(628, 289);
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
            this.StartNr_box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StartNr_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartNr_box.ForeColor = System.Drawing.Color.Red;
            this.StartNr_box.Location = new System.Drawing.Point(16, 23);
            this.StartNr_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartNr_box.Name = "StartNr_box";
            this.StartNr_box.ReadOnly = true;
            this.StartNr_box.Size = new System.Drawing.Size(243, 98);
            this.StartNr_box.TabIndex = 18;
            // 
            // Navn_box
            // 
            this.Navn_box.BackColor = System.Drawing.SystemColors.Control;
            this.Navn_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Navn_box.ForeColor = System.Drawing.Color.Red;
            this.Navn_box.Location = new System.Drawing.Point(16, 135);
            this.Navn_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Navn_box.Name = "Navn_box";
            this.Navn_box.ReadOnly = true;
            this.Navn_box.Size = new System.Drawing.Size(994, 98);
            this.Navn_box.TabIndex = 19;
            // 
            // Klubb_box
            // 
            this.Klubb_box.BackColor = System.Drawing.SystemColors.Control;
            this.Klubb_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klubb_box.ForeColor = System.Drawing.Color.Red;
            this.Klubb_box.Location = new System.Drawing.Point(16, 253);
            this.Klubb_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Klubb_box.Name = "Klubb_box";
            this.Klubb_box.ReadOnly = true;
            this.Klubb_box.Size = new System.Drawing.Size(994, 49);
            this.Klubb_box.TabIndex = 20;
            // 
            // Klasse_box
            // 
            this.Klasse_box.BackColor = System.Drawing.SystemColors.Control;
            this.Klasse_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klasse_box.ForeColor = System.Drawing.Color.Red;
            this.Klasse_box.Location = new System.Drawing.Point(16, 315);
            this.Klasse_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Klasse_box.Name = "Klasse_box";
            this.Klasse_box.ReadOnly = true;
            this.Klasse_box.Size = new System.Drawing.Size(994, 49);
            this.Klasse_box.TabIndex = 21;
            // 
            // Ecard_box
            // 
            this.Ecard_box.BackColor = System.Drawing.SystemColors.Control;
            this.Ecard_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecard_box.ForeColor = System.Drawing.Color.Blue;
            this.Ecard_box.Location = new System.Drawing.Point(419, 72);
            this.Ecard_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ecard_box.Name = "Ecard_box";
            this.Ecard_box.ReadOnly = true;
            this.Ecard_box.Size = new System.Drawing.Size(219, 49);
            this.Ecard_box.TabIndex = 22;
            // 
            // Ecard2_box
            // 
            this.Ecard2_box.BackColor = System.Drawing.SystemColors.Control;
            this.Ecard2_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecard2_box.ForeColor = System.Drawing.Color.Blue;
            this.Ecard2_box.Location = new System.Drawing.Point(658, 72);
            this.Ecard2_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ecard2_box.Name = "Ecard2_box";
            this.Ecard2_box.ReadOnly = true;
            this.Ecard2_box.Size = new System.Drawing.Size(219, 49);
            this.Ecard2_box.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(415, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Brikke 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(654, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Brikke 2";
            // 
            // UnknownEcard_btn
            // 
            this.UnknownEcard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnknownEcard_btn.Location = new System.Drawing.Point(1000, 10);
            this.UnknownEcard_btn.Margin = new System.Windows.Forms.Padding(4);
            this.UnknownEcard_btn.Name = "UnknownEcard_btn";
            this.UnknownEcard_btn.Size = new System.Drawing.Size(276, 34);
            this.UnknownEcard_btn.TabIndex = 29;
            this.UnknownEcard_btn.Text = "Koble ukjent brikke til startnr";
            this.UnknownEcard_btn.UseVisualStyleBackColor = true;
            this.UnknownEcard_btn.Click += new System.EventHandler(this.UnknownEcard_btn_Click_1);
            // 
            // lopsid_box
            // 
            this.lopsid_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopsid_box.Location = new System.Drawing.Point(79, 61);
            this.lopsid_box.Name = "lopsid_box";
            this.lopsid_box.Size = new System.Drawing.Size(328, 27);
            this.lopsid_box.TabIndex = 30;
            // 
            // lopsnavn_box
            // 
            this.lopsnavn_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopsnavn_box.Location = new System.Drawing.Point(79, 94);
            this.lopsnavn_box.Name = "lopsnavn_box";
            this.lopsnavn_box.Size = new System.Drawing.Size(328, 27);
            this.lopsnavn_box.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Navn";
            // 
            // LiveRes_groupBox
            // 
            this.LiveRes_groupBox.Controls.Add(this.label8);
            this.LiveRes_groupBox.Controls.Add(this.label7);
            this.LiveRes_groupBox.Controls.Add(this.label6);
            this.LiveRes_groupBox.Controls.Add(this.lopsnavn_box);
            this.LiveRes_groupBox.Controls.Add(this.lopsid_box);
            this.LiveRes_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiveRes_groupBox.Location = new System.Drawing.Point(15, 303);
            this.LiveRes_groupBox.Name = "LiveRes_groupBox";
            this.LiveRes_groupBox.Size = new System.Drawing.Size(421, 137);
            this.LiveRes_groupBox.TabIndex = 34;
            this.LiveRes_groupBox.TabStop = false;
            this.LiveRes_groupBox.Text = "Arrangementsinfo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Benyttes for Liveres meldingstjeneste";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UsbPort_listBox);
            this.groupBox2.Controls.Add(this.RefreshUsbPort_btn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(264, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 184);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Velg Port";
            // 
            // readLiveResfil_btn
            // 
            this.readLiveResfil_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readLiveResfil_btn.Location = new System.Drawing.Point(1187, 469);
            this.readLiveResfil_btn.Name = "readLiveResfil_btn";
            this.readLiveResfil_btn.Size = new System.Drawing.Size(272, 40);
            this.readLiveResfil_btn.TabIndex = 37;
            this.readLiveResfil_btn.Text = "Les startliste fra LiveRes";
            this.readLiveResfil_btn.UseVisualStyleBackColor = true;
            this.readLiveResfil_btn.Click += new System.EventHandler(this.readLiveResfil_btn_Click);
            // 
            // readBrikkesjekkfil_btn
            // 
            this.readBrikkesjekkfil_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBrikkesjekkfil_btn.Location = new System.Drawing.Point(894, 469);
            this.readBrikkesjekkfil_btn.Name = "readBrikkesjekkfil_btn";
            this.readBrikkesjekkfil_btn.Size = new System.Drawing.Size(272, 40);
            this.readBrikkesjekkfil_btn.TabIndex = 39;
            this.readBrikkesjekkfil_btn.Text = "Les startliste fra Brikkesjekkfil";
            this.readBrikkesjekkfil_btn.UseVisualStyleBackColor = true;
            this.readBrikkesjekkfil_btn.Click += new System.EventHandler(this.readBrikkesjekkfil_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Stopp kommunikasjon før Avslutt";
            // 
            // Løperinfo
            // 
            this.Løperinfo.BackColor = System.Drawing.SystemColors.Control;
            this.Løperinfo.Controls.Add(this.Battery_box);
            this.Løperinfo.Controls.Add(this.label5);
            this.Løperinfo.Controls.Add(this.label4);
            this.Løperinfo.Controls.Add(this.Ecard2_box);
            this.Løperinfo.Controls.Add(this.Ecard_box);
            this.Løperinfo.Controls.Add(this.Klasse_box);
            this.Løperinfo.Controls.Add(this.Klubb_box);
            this.Løperinfo.Controls.Add(this.Navn_box);
            this.Løperinfo.Controls.Add(this.StartNr_box);
            this.Løperinfo.Location = new System.Drawing.Point(456, 56);
            this.Løperinfo.Name = "Løperinfo";
            this.Løperinfo.Size = new System.Drawing.Size(1023, 384);
            this.Løperinfo.TabIndex = 41;
            this.Løperinfo.TabStop = false;
            this.Løperinfo.Text = "Løperinfo";
            // 
            // Battery_box
            // 
            this.Battery_box.BackColor = System.Drawing.SystemColors.Control;
            this.Battery_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Battery_box.ForeColor = System.Drawing.Color.Blue;
            this.Battery_box.Location = new System.Drawing.Point(896, 80);
            this.Battery_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Battery_box.Name = "Battery_box";
            this.Battery_box.ReadOnly = true;
            this.Battery_box.Size = new System.Drawing.Size(114, 41);
            this.Battery_box.TabIndex = 29;
            // 
            // folderLogfile_box
            // 
            this.folderLogfile_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderLogfile_box.Location = new System.Drawing.Point(170, 812);
            this.folderLogfile_box.Name = "folderLogfile_box";
            this.folderLogfile_box.Size = new System.Drawing.Size(266, 27);
            this.folderLogfile_box.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 815);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Katalog for log-fil";
            // 
            // btnStartMTR
            // 
            this.btnStartMTR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStartMTR.Location = new System.Drawing.Point(320, 467);
            this.btnStartMTR.Name = "btnStartMTR";
            this.btnStartMTR.Size = new System.Drawing.Size(116, 42);
            this.btnStartMTR.TabIndex = 44;
            this.btnStartMTR.Text = "Start MTR";
            this.btnStartMTR.UseVisualStyleBackColor = false;
            this.btnStartMTR.Click += new System.EventHandler(this.btnReadMTR_Click);
            // 
            // ecuCode_box
            // 
            this.ecuCode_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecuCode_box.Location = new System.Drawing.Point(14, 24);
            this.ecuCode_box.Name = "ecuCode_box";
            this.ecuCode_box.Size = new System.Drawing.Size(100, 27);
            this.ecuCode_box.TabIndex = 45;
            // 
            // ChangeEcuCode_btn
            // 
            this.ChangeEcuCode_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeEcuCode_btn.Location = new System.Drawing.Point(126, 24);
            this.ChangeEcuCode_btn.Name = "ChangeEcuCode_btn";
            this.ChangeEcuCode_btn.Size = new System.Drawing.Size(106, 32);
            this.ChangeEcuCode_btn.TabIndex = 47;
            this.ChangeEcuCode_btn.Text = "Ny kode";
            this.ChangeEcuCode_btn.UseVisualStyleBackColor = true;
            this.ChangeEcuCode_btn.Click += new System.EventHandler(this.ChangeEcuCode_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.ChangeEcuCode_btn);
            this.groupBox3.Controls.Add(this.ecuCode_box);
            this.groupBox3.Location = new System.Drawing.Point(15, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 81);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kode brikkeleser";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(15, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(372, 17);
            this.label10.TabIndex = 48;
            this.label10.Text = "Kode 70-76 for brikkesjekk Kode 251-253 for batterisjekk ";
            // 
            // ReadEcu_btn
            // 
            this.ReadEcu_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ReadEcu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadEcu_btn.Location = new System.Drawing.Point(136, 467);
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
            this.LiveRes_checkBox.Location = new System.Drawing.Point(19, 95);
            this.LiveRes_checkBox.Name = "LiveRes_checkBox";
            this.LiveRes_checkBox.Size = new System.Drawing.Size(188, 21);
            this.LiveRes_checkBox.TabIndex = 30;
            this.LiveRes_checkBox.Text = "Kommunikasjon LiveRes ";
            this.LiveRes_checkBox.UseVisualStyleBackColor = true;
            this.LiveRes_checkBox.CheckedChanged += new System.EventHandler(this.LiveRes_checkBox_CheckedChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 853);
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
            this.Controls.Add(this.UnknownEcard_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsbRead_listBox);
            this.Controls.Add(this.SearchCard_Txtbox);
            this.Controls.Add(this.SearchCard_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Clock_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Close_btn);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Clock_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchCard_btn;
        private System.Windows.Forms.TextBox SearchCard_Txtbox;
        private System.Windows.Forms.ListBox UsbRead_listBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StartNr_box;
        private System.Windows.Forms.TextBox Navn_box;
        private System.Windows.Forms.TextBox Klubb_box;
        private System.Windows.Forms.TextBox Klasse_box;
        private System.Windows.Forms.TextBox Ecard_box;
        private System.Windows.Forms.TextBox Ecard2_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UnknownEcard_btn;
        private System.Windows.Forms.TextBox lopsid_box;
        private System.Windows.Forms.TextBox lopsnavn_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox LiveRes_groupBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button readLiveResfil_btn;
        private System.Windows.Forms.Button readBrikkesjekkfil_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Løperinfo;
        private System.Windows.Forms.TextBox folderLogfile_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Battery_box;
        private System.Windows.Forms.Button btnStartMTR;
        private System.Windows.Forms.TextBox ecuCode_box;
        private System.Windows.Forms.Button ChangeEcuCode_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ReadEcu_btn;
        private System.Windows.Forms.CheckBox LiveRes_checkBox;
    }
}

