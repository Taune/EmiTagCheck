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
            this.ReadUsb_btn = new System.Windows.Forms.Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.readLiveResfil_btn = new System.Windows.Forms.Button();
            this.readBrikkesjekkfil_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReadUsb_btn
            // 
            this.ReadUsb_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadUsb_btn.Location = new System.Drawing.Point(275, 421);
            this.ReadUsb_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReadUsb_btn.Name = "ReadUsb_btn";
            this.ReadUsb_btn.Size = new System.Drawing.Size(163, 30);
            this.ReadUsb_btn.TabIndex = 0;
            this.ReadUsb_btn.Text = "Start";
            this.ReadUsb_btn.UseVisualStyleBackColor = true;
            this.ReadUsb_btn.Click += new System.EventHandler(this.ReadUsb_btn_Click);
            // 
            // UsbPort_listBox
            // 
            this.UsbPort_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsbPort_listBox.FormattingEnabled = true;
            this.UsbPort_listBox.ItemHeight = 20;
            this.UsbPort_listBox.Location = new System.Drawing.Point(16, 34);
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
            this.RefreshUsbPort_btn.Location = new System.Drawing.Point(16, 147);
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
            this.label2.Location = new System.Drawing.Point(460, 426);
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
            this.dataGridView1.Location = new System.Drawing.Point(464, 465);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(995, 361);
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
            this.UsbRead_listBox.FormattingEnabled = true;
            this.UsbRead_listBox.ItemHeight = 16;
            this.UsbRead_listBox.Location = new System.Drawing.Point(15, 465);
            this.UsbRead_listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsbRead_listBox.Name = "UsbRead_listBox";
            this.UsbRead_listBox.Size = new System.Drawing.Size(421, 356);
            this.UsbRead_listBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "EmiTag Log";
            // 
            // StartNr_box
            // 
            this.StartNr_box.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StartNr_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StartNr_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartNr_box.ForeColor = System.Drawing.Color.Red;
            this.StartNr_box.Location = new System.Drawing.Point(464, 56);
            this.StartNr_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartNr_box.Name = "StartNr_box";
            this.StartNr_box.Size = new System.Drawing.Size(243, 91);
            this.StartNr_box.TabIndex = 18;
            // 
            // Navn_box
            // 
            this.Navn_box.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Navn_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Navn_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Navn_box.ForeColor = System.Drawing.Color.Red;
            this.Navn_box.Location = new System.Drawing.Point(464, 158);
            this.Navn_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Navn_box.Name = "Navn_box";
            this.Navn_box.Size = new System.Drawing.Size(994, 91);
            this.Navn_box.TabIndex = 19;
            // 
            // Klubb_box
            // 
            this.Klubb_box.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Klubb_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Klubb_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klubb_box.ForeColor = System.Drawing.Color.Red;
            this.Klubb_box.Location = new System.Drawing.Point(464, 266);
            this.Klubb_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Klubb_box.Name = "Klubb_box";
            this.Klubb_box.Size = new System.Drawing.Size(994, 39);
            this.Klubb_box.TabIndex = 20;
            // 
            // Klasse_box
            // 
            this.Klasse_box.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Klasse_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Klasse_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klasse_box.ForeColor = System.Drawing.Color.Red;
            this.Klasse_box.Location = new System.Drawing.Point(464, 323);
            this.Klasse_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Klasse_box.Name = "Klasse_box";
            this.Klasse_box.Size = new System.Drawing.Size(994, 39);
            this.Klasse_box.TabIndex = 21;
            // 
            // Ecard_box
            // 
            this.Ecard_box.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Ecard_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ecard_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecard_box.ForeColor = System.Drawing.Color.Blue;
            this.Ecard_box.Location = new System.Drawing.Point(1000, 101);
            this.Ecard_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ecard_box.Name = "Ecard_box";
            this.Ecard_box.Size = new System.Drawing.Size(219, 39);
            this.Ecard_box.TabIndex = 22;
            // 
            // Ecard2_box
            // 
            this.Ecard2_box.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Ecard2_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ecard2_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecard2_box.ForeColor = System.Drawing.Color.Blue;
            this.Ecard2_box.Location = new System.Drawing.Point(1239, 101);
            this.Ecard2_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ecard2_box.Name = "Ecard2_box";
            this.Ecard2_box.Size = new System.Drawing.Size(219, 39);
            this.Ecard2_box.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(996, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Brikke 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1235, 78);
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
            this.UnknownEcard_btn.Size = new System.Drawing.Size(248, 34);
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
            this.lopsid_box.Size = new System.Drawing.Size(336, 27);
            this.lopsid_box.TabIndex = 30;
            // 
            // lopsnavn_box
            // 
            this.lopsnavn_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopsnavn_box.Location = new System.Drawing.Point(79, 94);
            this.lopsnavn_box.Name = "lopsnavn_box";
            this.lopsnavn_box.Size = new System.Drawing.Size(336, 27);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lopsnavn_box);
            this.groupBox1.Controls.Add(this.lopsid_box);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 137);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arrangementsinfo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Benyttes for meldingstjeneste";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UsbPort_listBox);
            this.groupBox2.Controls.Add(this.RefreshUsbPort_btn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(264, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 199);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Velg Port";
            // 
            // readLiveResfil_btn
            // 
            this.readLiveResfil_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readLiveResfil_btn.Location = new System.Drawing.Point(1187, 421);
            this.readLiveResfil_btn.Name = "readLiveResfil_btn";
            this.readLiveResfil_btn.Size = new System.Drawing.Size(272, 30);
            this.readLiveResfil_btn.TabIndex = 37;
            this.readLiveResfil_btn.Text = "Les startliste fra LiveRes";
            this.readLiveResfil_btn.UseVisualStyleBackColor = true;
            this.readLiveResfil_btn.Click += new System.EventHandler(this.readLiveResfil_btn_Click);
            // 
            // readBrikkesjekkfil_btn
            // 
            this.readBrikkesjekkfil_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBrikkesjekkfil_btn.Location = new System.Drawing.Point(894, 421);
            this.readBrikkesjekkfil_btn.Name = "readBrikkesjekkfil_btn";
            this.readBrikkesjekkfil_btn.Size = new System.Drawing.Size(272, 30);
            this.readBrikkesjekkfil_btn.TabIndex = 39;
            this.readBrikkesjekkfil_btn.Text = "Les startliste fra Brikkesjekkfil";
            this.readBrikkesjekkfil_btn.UseVisualStyleBackColor = true;
            this.readBrikkesjekkfil_btn.Click += new System.EventHandler(this.readBrikkesjekkfil_btn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 836);
            this.Controls.Add(this.readBrikkesjekkfil_btn);
            this.Controls.Add(this.readLiveResfil_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UnknownEcard_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsbRead_listBox);
            this.Controls.Add(this.Ecard2_box);
            this.Controls.Add(this.Ecard_box);
            this.Controls.Add(this.Klasse_box);
            this.Controls.Add(this.Klubb_box);
            this.Controls.Add(this.Navn_box);
            this.Controls.Add(this.StartNr_box);
            this.Controls.Add(this.SearchCard_Txtbox);
            this.Controls.Add(this.SearchCard_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Clock_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.ReadUsb_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "Brikkesjekk";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadUsb_btn;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button readLiveResfil_btn;
        private System.Windows.Forms.Button readBrikkesjekkfil_btn;
    }
}

