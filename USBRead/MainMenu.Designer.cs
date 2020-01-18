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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Clock_lbl = new System.Windows.Forms.Label();
            this.ReadStartList_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchCard_btn = new System.Windows.Forms.Button();
            this.SearchCard_Txtbox = new System.Windows.Forms.TextBox();
            this.StartNr_box = new System.Windows.Forms.TextBox();
            this.Navn_box = new System.Windows.Forms.TextBox();
            this.Klubb_box = new System.Windows.Forms.TextBox();
            this.Klasse_box = new System.Windows.Forms.TextBox();
            this.Ecard_box = new System.Windows.Forms.TextBox();
            this.Ecard2_box = new System.Windows.Forms.TextBox();
            this.ActiveUsb_box = new System.Windows.Forms.TextBox();
            this.UsbRead_listBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadUsb_btn
            // 
            this.ReadUsb_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadUsb_btn.Location = new System.Drawing.Point(215, 283);
            this.ReadUsb_btn.Margin = new System.Windows.Forms.Padding(2);
            this.ReadUsb_btn.Name = "ReadUsb_btn";
            this.ReadUsb_btn.Size = new System.Drawing.Size(122, 24);
            this.ReadUsb_btn.TabIndex = 0;
            this.ReadUsb_btn.Text = "Start";
            this.ReadUsb_btn.UseVisualStyleBackColor = true;
            this.ReadUsb_btn.Click += new System.EventHandler(this.ReadUsb_btn_Click);
            // 
            // UsbPort_listBox
            // 
            this.UsbPort_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsbPort_listBox.FormattingEnabled = true;
            this.UsbPort_listBox.ItemHeight = 17;
            this.UsbPort_listBox.Location = new System.Drawing.Point(20, 72);
            this.UsbPort_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsbPort_listBox.Name = "UsbPort_listBox";
            this.UsbPort_listBox.Size = new System.Drawing.Size(137, 89);
            this.UsbPort_listBox.Sorted = true;
            this.UsbPort_listBox.TabIndex = 2;
            this.UsbPort_listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // RefreshUsbPort_btn
            // 
            this.RefreshUsbPort_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshUsbPort_btn.Location = new System.Drawing.Point(173, 72);
            this.RefreshUsbPort_btn.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshUsbPort_btn.Name = "RefreshUsbPort_btn";
            this.RefreshUsbPort_btn.Size = new System.Drawing.Size(90, 28);
            this.RefreshUsbPort_btn.TabIndex = 3;
            this.RefreshUsbPort_btn.Text = "Oppfrisk";
            this.RefreshUsbPort_btn.UseVisualStyleBackColor = true;
            this.RefreshUsbPort_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.Location = new System.Drawing.Point(173, 104);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(90, 28);
            this.Close_btn.TabIndex = 4;
            this.Close_btn.Text = "Lukk";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Velg port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Deltakere";
            // 
            // Clock_lbl
            // 
            this.Clock_lbl.AutoSize = true;
            this.Clock_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.Clock_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Clock_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock_lbl.Location = new System.Drawing.Point(173, 11);
            this.Clock_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Clock_lbl.Name = "Clock_lbl";
            this.Clock_lbl.Size = new System.Drawing.Size(82, 26);
            this.Clock_lbl.TabIndex = 9;
            this.Clock_lbl.Text = "00:00:00";
            // 
            // ReadStartList_btn
            // 
            this.ReadStartList_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadStartList_btn.Location = new System.Drawing.Point(827, 283);
            this.ReadStartList_btn.Margin = new System.Windows.Forms.Padding(2);
            this.ReadStartList_btn.Name = "ReadStartList_btn";
            this.ReadStartList_btn.Size = new System.Drawing.Size(152, 24);
            this.ReadStartList_btn.TabIndex = 10;
            this.ReadStartList_btn.Text = "Les Startliste";
            this.ReadStartList_btn.UseVisualStyleBackColor = true;
            this.ReadStartList_btn.Click += new System.EventHandler(this.ReadStartList_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(357, 312);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(622, 228);
            this.dataGridView1.TabIndex = 11;
            // 
            // SearchCard_btn
            // 
            this.SearchCard_btn.Location = new System.Drawing.Point(325, 20);
            this.SearchCard_btn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchCard_btn.Name = "SearchCard_btn";
            this.SearchCard_btn.Size = new System.Drawing.Size(85, 19);
            this.SearchCard_btn.TabIndex = 12;
            this.SearchCard_btn.Text = "Søk brikke";
            this.SearchCard_btn.UseVisualStyleBackColor = true;
            this.SearchCard_btn.Click += new System.EventHandler(this.SearchCard_btn_Click);
            // 
            // SearchCard_Txtbox
            // 
            this.SearchCard_Txtbox.Location = new System.Drawing.Point(325, 38);
            this.SearchCard_Txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchCard_Txtbox.Name = "SearchCard_Txtbox";
            this.SearchCard_Txtbox.Size = new System.Drawing.Size(76, 20);
            this.SearchCard_Txtbox.TabIndex = 13;
            // 
            // StartNr_box
            // 
            this.StartNr_box.BackColor = System.Drawing.SystemColors.Control;
            this.StartNr_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartNr_box.ForeColor = System.Drawing.Color.Red;
            this.StartNr_box.Location = new System.Drawing.Point(431, 9);
            this.StartNr_box.Margin = new System.Windows.Forms.Padding(2);
            this.StartNr_box.Name = "StartNr_box";
            this.StartNr_box.Size = new System.Drawing.Size(106, 49);
            this.StartNr_box.TabIndex = 18;
            this.StartNr_box.TextChanged += new System.EventHandler(this.StartNr_box_TextChanged);
            // 
            // Navn_box
            // 
            this.Navn_box.BackColor = System.Drawing.SystemColors.Control;
            this.Navn_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Navn_box.ForeColor = System.Drawing.Color.Red;
            this.Navn_box.Location = new System.Drawing.Point(431, 67);
            this.Navn_box.Margin = new System.Windows.Forms.Padding(2);
            this.Navn_box.Name = "Navn_box";
            this.Navn_box.Size = new System.Drawing.Size(548, 62);
            this.Navn_box.TabIndex = 19;
            // 
            // Klubb_box
            // 
            this.Klubb_box.BackColor = System.Drawing.SystemColors.Control;
            this.Klubb_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klubb_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Klubb_box.Location = new System.Drawing.Point(431, 137);
            this.Klubb_box.Margin = new System.Windows.Forms.Padding(2);
            this.Klubb_box.Name = "Klubb_box";
            this.Klubb_box.Size = new System.Drawing.Size(548, 38);
            this.Klubb_box.TabIndex = 20;
            // 
            // Klasse_box
            // 
            this.Klasse_box.BackColor = System.Drawing.SystemColors.Control;
            this.Klasse_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klasse_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Klasse_box.Location = new System.Drawing.Point(431, 183);
            this.Klasse_box.Margin = new System.Windows.Forms.Padding(2);
            this.Klasse_box.Name = "Klasse_box";
            this.Klasse_box.Size = new System.Drawing.Size(548, 38);
            this.Klasse_box.TabIndex = 21;
            // 
            // Ecard_box
            // 
            this.Ecard_box.BackColor = System.Drawing.SystemColors.Control;
            this.Ecard_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecard_box.ForeColor = System.Drawing.Color.Blue;
            this.Ecard_box.Location = new System.Drawing.Point(635, 26);
            this.Ecard_box.Margin = new System.Windows.Forms.Padding(2);
            this.Ecard_box.Name = "Ecard_box";
            this.Ecard_box.Size = new System.Drawing.Size(165, 32);
            this.Ecard_box.TabIndex = 22;
            // 
            // Ecard2_box
            // 
            this.Ecard2_box.BackColor = System.Drawing.SystemColors.Control;
            this.Ecard2_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecard2_box.ForeColor = System.Drawing.Color.Blue;
            this.Ecard2_box.Location = new System.Drawing.Point(814, 26);
            this.Ecard2_box.Margin = new System.Windows.Forms.Padding(2);
            this.Ecard2_box.Name = "Ecard2_box";
            this.Ecard2_box.Size = new System.Drawing.Size(165, 32);
            this.Ecard2_box.TabIndex = 23;
            // 
            // ActiveUsb_box
            // 
            this.ActiveUsb_box.Location = new System.Drawing.Point(173, 137);
            this.ActiveUsb_box.Margin = new System.Windows.Forms.Padding(2);
            this.ActiveUsb_box.Name = "ActiveUsb_box";
            this.ActiveUsb_box.Size = new System.Drawing.Size(90, 20);
            this.ActiveUsb_box.TabIndex = 24;
            // 
            // UsbRead_listBox
            // 
            this.UsbRead_listBox.FormattingEnabled = true;
            this.UsbRead_listBox.Location = new System.Drawing.Point(20, 312);
            this.UsbRead_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsbRead_listBox.Name = "UsbRead_listBox";
            this.UsbRead_listBox.Size = new System.Drawing.Size(317, 225);
            this.UsbRead_listBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "EmiTag Log";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(632, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Brikke 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(811, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Brikke 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Koble ukjent brikke til startnr";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsbRead_listBox);
            this.Controls.Add(this.ActiveUsb_box);
            this.Controls.Add(this.Ecard2_box);
            this.Controls.Add(this.Ecard_box);
            this.Controls.Add(this.Klasse_box);
            this.Controls.Add(this.Klubb_box);
            this.Controls.Add(this.Navn_box);
            this.Controls.Add(this.StartNr_box);
            this.Controls.Add(this.SearchCard_Txtbox);
            this.Controls.Add(this.SearchCard_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ReadStartList_btn);
            this.Controls.Add(this.Clock_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.RefreshUsbPort_btn);
            this.Controls.Add(this.UsbPort_listBox);
            this.Controls.Add(this.ReadUsb_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadUsb_btn;
        private System.Windows.Forms.ListBox UsbPort_listBox;
        private System.Windows.Forms.Button RefreshUsbPort_btn;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Clock_lbl;
        private System.Windows.Forms.Button ReadStartList_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchCard_btn;
        private System.Windows.Forms.TextBox SearchCard_Txtbox;
        private System.Windows.Forms.TextBox StartNr_box;
        private System.Windows.Forms.TextBox Navn_box;
        private System.Windows.Forms.TextBox Klubb_box;
        private System.Windows.Forms.TextBox Klasse_box;
        private System.Windows.Forms.TextBox Ecard_box;
        private System.Windows.Forms.TextBox Ecard2_box;
        private System.Windows.Forms.TextBox ActiveUsb_box;
        private System.Windows.Forms.ListBox UsbRead_listBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

