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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
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
            this.FindLiveRes_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.readLiveResfil_btn = new System.Windows.Forms.Button();
            this.readBrikkesjekkfil_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Løperinfo = new System.Windows.Forms.GroupBox();
            this.ChangeEcardNo_btn = new System.Windows.Forms.Button();
            this.NotStared_btn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ID_box = new System.Windows.Forms.TextBox();
            this.Battery_box = new System.Windows.Forms.TextBox();
            this.folderLogfile_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnStartMTR = new System.Windows.Forms.Button();
            this.ecuCode_box = new System.Windows.Forms.TextBox();
            this.ChangeEcuCode_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.readECUcode_box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ReadEcu_btn = new System.Windows.Forms.Button();
            this.LiveRes_checkBox = new System.Windows.Forms.CheckBox();
            this.WarningSound_checkBox = new System.Windows.Forms.CheckBox();
            this.version = new System.Windows.Forms.Label();
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
            this.UsbPort_listBox.Location = new System.Drawing.Point(16, 25);
            this.UsbPort_listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsbPort_listBox.Name = "UsbPort_listBox";
            this.UsbPort_listBox.Size = new System.Drawing.Size(143, 84);
            this.UsbPort_listBox.Sorted = true;
            this.UsbPort_listBox.TabIndex = 2;
            this.UsbPort_listBox.SelectedIndexChanged += new System.EventHandler(this.UsbPort_listBox_SelectedIndexChanged);
            // 
            // RefreshUsbPort_btn
            // 
            this.RefreshUsbPort_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshUsbPort_btn.Location = new System.Drawing.Point(16, 137);
            this.RefreshUsbPort_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RefreshUsbPort_btn.Name = "RefreshUsbPort_btn";
            this.RefreshUsbPort_btn.Size = new System.Drawing.Size(141, 34);
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
            this.Close_btn.Size = new System.Drawing.Size(141, 34);
            this.Close_btn.TabIndex = 4;
            this.Close_btn.Text = "Avslutt program";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Deltakere";
            // 
            // Clock_lbl
            // 
            this.Clock_lbl.AutoSize = true;
            this.Clock_lbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Clock_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Clock_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(617, 514);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(842, 289);
            this.dataGridView1.TabIndex = 11;
            // 
            // SearchCard_btn
            // 
            this.SearchCard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCard_btn.Location = new System.Drawing.Point(464, 11);
            this.SearchCard_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchCard_btn.Name = "SearchCard_btn";
            this.SearchCard_btn.Size = new System.Drawing.Size(195, 34);
            this.SearchCard_btn.TabIndex = 12;
            this.SearchCard_btn.Text = "Søk brikke manuelt";
            this.SearchCard_btn.UseVisualStyleBackColor = true;
            this.SearchCard_btn.Click += new System.EventHandler(this.SearchCard_btn_Click);
            // 
            // SearchCard_Txtbox
            // 
            this.SearchCard_Txtbox.BackColor = System.Drawing.SystemColors.Info;
            this.SearchCard_Txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCard_Txtbox.Location = new System.Drawing.Point(664, 14);
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
            this.UsbRead_listBox.Location = new System.Drawing.Point(15, 514);
            this.UsbRead_listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsbRead_listBox.Name = "UsbRead_listBox";
            this.UsbRead_listBox.Size = new System.Drawing.Size(581, 292);
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
            this.StartNr_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartNr_box.ForeColor = System.Drawing.Color.Red;
            this.StartNr_box.Location = new System.Drawing.Point(16, 55);
            this.StartNr_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartNr_box.Name = "StartNr_box";
            this.StartNr_box.Size = new System.Drawing.Size(243, 98);
            this.StartNr_box.TabIndex = 18;
            this.StartNr_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartNr_box_KeyPress);
            // 
            // Navn_box
            // 
            this.Navn_box.BackColor = System.Drawing.SystemColors.Control;
            this.Navn_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Navn_box.ForeColor = System.Drawing.Color.Red;
            this.Navn_box.Location = new System.Drawing.Point(16, 174);
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
            this.Klubb_box.Location = new System.Drawing.Point(16, 272);
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
            this.Klasse_box.Location = new System.Drawing.Point(16, 329);
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
            this.Ecard_box.Location = new System.Drawing.Point(280, 36);
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
            this.label4.Location = new System.Drawing.Point(276, 15);
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
            // UnknownEcard_btn
            // 
            this.UnknownEcard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnknownEcard_btn.Location = new System.Drawing.Point(764, 108);
            this.UnknownEcard_btn.Margin = new System.Windows.Forms.Padding(4);
            this.UnknownEcard_btn.Name = "UnknownEcard_btn";
            this.UnknownEcard_btn.Size = new System.Drawing.Size(244, 39);
            this.UnknownEcard_btn.TabIndex = 29;
            this.UnknownEcard_btn.Text = "Melding til LiveRes";
            this.UnknownEcard_btn.UseVisualStyleBackColor = true;
            this.UnknownEcard_btn.Click += new System.EventHandler(this.UnknownEcard_btn_Click_1);
            // 
            // lopsid_box
            // 
            this.lopsid_box.BackColor = System.Drawing.SystemColors.Info;
            this.lopsid_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopsid_box.Location = new System.Drawing.Point(79, 62);
            this.lopsid_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lopsid_box.Name = "lopsid_box";
            this.lopsid_box.Size = new System.Drawing.Size(153, 27);
            this.lopsid_box.TabIndex = 30;
            // 
            // lopsnavn_box
            // 
            this.lopsnavn_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopsnavn_box.Location = new System.Drawing.Point(79, 94);
            this.lopsnavn_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lopsnavn_box.Name = "lopsnavn_box";
            this.lopsnavn_box.ReadOnly = true;
            this.lopsnavn_box.Size = new System.Drawing.Size(328, 27);
            this.lopsnavn_box.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Navn";
            // 
            // LiveRes_groupBox
            // 
            this.LiveRes_groupBox.Controls.Add(this.FindLiveRes_btn);
            this.LiveRes_groupBox.Controls.Add(this.label8);
            this.LiveRes_groupBox.Controls.Add(this.label7);
            this.LiveRes_groupBox.Controls.Add(this.label6);
            this.LiveRes_groupBox.Controls.Add(this.lopsnavn_box);
            this.LiveRes_groupBox.Controls.Add(this.lopsid_box);
            this.LiveRes_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiveRes_groupBox.Location = new System.Drawing.Point(15, 303);
            this.LiveRes_groupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LiveRes_groupBox.Name = "LiveRes_groupBox";
            this.LiveRes_groupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LiveRes_groupBox.Size = new System.Drawing.Size(421, 137);
            this.LiveRes_groupBox.TabIndex = 34;
            this.LiveRes_groupBox.TabStop = false;
            this.LiveRes_groupBox.Text = "Arrangementsinfo";
            // 
            // FindLiveRes_btn
            // 
            this.FindLiveRes_btn.Location = new System.Drawing.Point(237, 62);
            this.FindLiveRes_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindLiveRes_btn.Name = "FindLiveRes_btn";
            this.FindLiveRes_btn.Size = new System.Drawing.Size(169, 27);
            this.FindLiveRes_btn.TabIndex = 36;
            this.FindLiveRes_btn.Text = "Finn Arrangement";
            this.FindLiveRes_btn.UseVisualStyleBackColor = true;
            this.FindLiveRes_btn.Click += new System.EventHandler(this.FindLiveRes_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 27);
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
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(172, 185);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Velg Port";
            // 
            // readLiveResfil_btn
            // 
            this.readLiveResfil_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readLiveResfil_btn.Location = new System.Drawing.Point(1187, 469);
            this.readLiveResfil_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readLiveResfil_btn.Name = "readLiveResfil_btn";
            this.readLiveResfil_btn.Size = new System.Drawing.Size(272, 39);
            this.readLiveResfil_btn.TabIndex = 37;
            this.readLiveResfil_btn.Text = "Les startliste fra LiveRes";
            this.readLiveResfil_btn.UseVisualStyleBackColor = true;
            this.readLiveResfil_btn.Click += new System.EventHandler(this.readLiveResfil_btn_Click);
            // 
            // readBrikkesjekkfil_btn
            // 
            this.readBrikkesjekkfil_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBrikkesjekkfil_btn.Location = new System.Drawing.Point(893, 469);
            this.readBrikkesjekkfil_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readBrikkesjekkfil_btn.Name = "readBrikkesjekkfil_btn";
            this.readBrikkesjekkfil_btn.Size = new System.Drawing.Size(272, 39);
            this.readBrikkesjekkfil_btn.TabIndex = 39;
            this.readBrikkesjekkfil_btn.Text = "Les startliste fra Brikkesjekkfil";
            this.readBrikkesjekkfil_btn.UseVisualStyleBackColor = true;
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
            this.Løperinfo.Controls.Add(this.UnknownEcard_btn);
            this.Løperinfo.Controls.Add(this.Navn_box);
            this.Løperinfo.Controls.Add(this.StartNr_box);
            this.Løperinfo.Location = new System.Drawing.Point(456, 57);
            this.Løperinfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Løperinfo.Name = "Løperinfo";
            this.Løperinfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Løperinfo.Size = new System.Drawing.Size(1023, 384);
            this.Løperinfo.TabIndex = 41;
            this.Løperinfo.TabStop = false;
            this.Løperinfo.Text = "Løperinfo";
            // 
            // ChangeEcardNo_btn
            // 
            this.ChangeEcardNo_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeEcardNo_btn.Location = new System.Drawing.Point(764, 19);
            this.ChangeEcardNo_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeEcardNo_btn.Name = "ChangeEcardNo_btn";
            this.ChangeEcardNo_btn.Size = new System.Drawing.Size(244, 34);
            this.ChangeEcardNo_btn.TabIndex = 34;
            this.ChangeEcardNo_btn.Text = "Endre brikkenummer";
            this.ChangeEcardNo_btn.UseVisualStyleBackColor = true;
            this.ChangeEcardNo_btn.Click += new System.EventHandler(this.ChangeEcardNo_btn_Click);
            // 
            // NotStared_btn
            // 
            this.NotStared_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotStared_btn.Location = new System.Drawing.Point(764, 65);
            this.NotStared_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NotStared_btn.Name = "NotStared_btn";
            this.NotStared_btn.Size = new System.Drawing.Size(244, 34);
            this.NotStared_btn.TabIndex = 33;
            this.NotStared_btn.Text = "Startnr ikke startet";
            this.NotStared_btn.UseVisualStyleBackColor = true;
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
            this.label11.Location = new System.Drawing.Point(12, 34);
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
            this.ID_box.Location = new System.Drawing.Point(517, 37);
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
            this.folderLogfile_box.Location = new System.Drawing.Point(171, 812);
            this.folderLogfile_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.folderLogfile_box.Name = "folderLogfile_box";
            this.folderLogfile_box.Size = new System.Drawing.Size(265, 27);
            this.folderLogfile_box.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 814);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "Katalog for log-fil";
            // 
            // btnStartMTR
            // 
            this.btnStartMTR.BackColor = System.Drawing.Color.LightGray;
            this.btnStartMTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartMTR.Location = new System.Drawing.Point(314, 466);
            this.btnStartMTR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartMTR.Name = "btnStartMTR";
            this.btnStartMTR.Size = new System.Drawing.Size(122, 42);
            this.btnStartMTR.TabIndex = 44;
            this.btnStartMTR.Text = "Start MTR";
            this.btnStartMTR.UseVisualStyleBackColor = false;
            this.btnStartMTR.Click += new System.EventHandler(this.btnReadMTR_Click);
            // 
            // ecuCode_box
            // 
            this.ecuCode_box.BackColor = System.Drawing.SystemColors.Info;
            this.ecuCode_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecuCode_box.Location = new System.Drawing.Point(13, 25);
            this.ecuCode_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ecuCode_box.Name = "ecuCode_box";
            this.ecuCode_box.Size = new System.Drawing.Size(100, 27);
            this.ecuCode_box.TabIndex = 45;
            // 
            // ChangeEcuCode_btn
            // 
            this.ChangeEcuCode_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeEcuCode_btn.Location = new System.Drawing.Point(125, 25);
            this.ChangeEcuCode_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeEcuCode_btn.Name = "ChangeEcuCode_btn";
            this.ChangeEcuCode_btn.Size = new System.Drawing.Size(107, 32);
            this.ChangeEcuCode_btn.TabIndex = 47;
            this.ChangeEcuCode_btn.Text = "Ny kode";
            this.ChangeEcuCode_btn.UseVisualStyleBackColor = true;
            this.ChangeEcuCode_btn.Click += new System.EventHandler(this.ChangeEcuCode_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.readECUcode_box);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.ChangeEcuCode_btn);
            this.groupBox3.Controls.Add(this.ecuCode_box);
            this.groupBox3.Location = new System.Drawing.Point(15, 206);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(421, 81);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kode ECU brikkeleser";
            // 
            // readECUcode_box
            // 
            this.readECUcode_box.BackColor = System.Drawing.SystemColors.Menu;
            this.readECUcode_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readECUcode_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readECUcode_box.ForeColor = System.Drawing.Color.Red;
            this.readECUcode_box.Location = new System.Drawing.Point(249, 30);
            this.readECUcode_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readECUcode_box.Name = "readECUcode_box";
            this.readECUcode_box.Size = new System.Drawing.Size(73, 20);
            this.readECUcode_box.TabIndex = 49;
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
            this.ReadEcu_btn.BackColor = System.Drawing.Color.LightGray;
            this.ReadEcu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.LiveRes_checkBox.Location = new System.Drawing.Point(19, 95);
            this.LiveRes_checkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LiveRes_checkBox.Name = "LiveRes_checkBox";
            this.LiveRes_checkBox.Size = new System.Drawing.Size(219, 21);
            this.LiveRes_checkBox.TabIndex = 30;
            this.LiveRes_checkBox.Text = "Kommunikasjon med LiveRes ";
            this.LiveRes_checkBox.UseVisualStyleBackColor = true;
            this.LiveRes_checkBox.CheckedChanged += new System.EventHandler(this.LiveRes_checkBox_CheckedChanged);
            // 
            // WarningSound_checkBox
            // 
            this.WarningSound_checkBox.AutoSize = true;
            this.WarningSound_checkBox.Location = new System.Drawing.Point(19, 122);
            this.WarningSound_checkBox.Name = "WarningSound_checkBox";
            this.WarningSound_checkBox.Size = new System.Drawing.Size(222, 21);
            this.WarningSound_checkBox.TabIndex = 51;
            this.WarningSound_checkBox.Text = "Lydvarsel på ved ukjent brikke";
            this.WarningSound_checkBox.UseVisualStyleBackColor = true;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.ForeColor = System.Drawing.SystemColors.Highlight;
            this.version.Location = new System.Drawing.Point(490, 822);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(106, 17);
            this.version.TabIndex = 52;
            this.version.Text = "Ver 20.10.2020";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 861);
            this.Controls.Add(this.version);
            this.Controls.Add(this.WarningSound_checkBox);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Close_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button FindLiveRes_btn;
        private System.Windows.Forms.TextBox readECUcode_box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button NotStared_btn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ChangeEcardNo_btn;
        private System.Windows.Forms.TextBox ID_box;
        private System.Windows.Forms.CheckBox WarningSound_checkBox;
        private System.Windows.Forms.Label version;
    }
}

