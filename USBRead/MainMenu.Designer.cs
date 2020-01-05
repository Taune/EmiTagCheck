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
            this.UsbOutText = new System.Windows.Forms.TextBox();
            this.UsbPort_listBox = new System.Windows.Forms.ListBox();
            this.RefreshUsbPort_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.OpenComm_btn = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadUsb_btn
            // 
            this.ReadUsb_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadUsb_btn.Location = new System.Drawing.Point(27, 203);
            this.ReadUsb_btn.Name = "ReadUsb_btn";
            this.ReadUsb_btn.Size = new System.Drawing.Size(162, 55);
            this.ReadUsb_btn.TabIndex = 0;
            this.ReadUsb_btn.Text = "Les data";
            this.ReadUsb_btn.UseVisualStyleBackColor = true;
            this.ReadUsb_btn.Click += new System.EventHandler(this.ReadUsb_btn_Click);
            // 
            // UsbOutText
            // 
            this.UsbOutText.Location = new System.Drawing.Point(27, 264);
            this.UsbOutText.Multiline = true;
            this.UsbOutText.Name = "UsbOutText";
            this.UsbOutText.Size = new System.Drawing.Size(249, 180);
            this.UsbOutText.TabIndex = 1;
            this.UsbOutText.TextChanged += new System.EventHandler(this.UsbOutText_TextChanged);
            // 
            // UsbPort_listBox
            // 
            this.UsbPort_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsbPort_listBox.FormattingEnabled = true;
            this.UsbPort_listBox.ItemHeight = 20;
            this.UsbPort_listBox.Location = new System.Drawing.Point(27, 43);
            this.UsbPort_listBox.Name = "UsbPort_listBox";
            this.UsbPort_listBox.Size = new System.Drawing.Size(181, 84);
            this.UsbPort_listBox.Sorted = true;
            this.UsbPort_listBox.TabIndex = 2;
            this.UsbPort_listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // RefreshUsbPort_btn
            // 
            this.RefreshUsbPort_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshUsbPort_btn.Location = new System.Drawing.Point(27, 133);
            this.RefreshUsbPort_btn.Name = "RefreshUsbPort_btn";
            this.RefreshUsbPort_btn.Size = new System.Drawing.Size(120, 34);
            this.RefreshUsbPort_btn.TabIndex = 3;
            this.RefreshUsbPort_btn.Text = "Oppfrisk";
            this.RefreshUsbPort_btn.UseVisualStyleBackColor = true;
            this.RefreshUsbPort_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.Location = new System.Drawing.Point(231, 32);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(136, 34);
            this.Close_btn.TabIndex = 4;
            this.Close_btn.Text = "Lukk";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // OpenComm_btn
            // 
            this.OpenComm_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenComm_btn.Location = new System.Drawing.Point(231, 72);
            this.OpenComm_btn.Name = "OpenComm_btn";
            this.OpenComm_btn.Size = new System.Drawing.Size(136, 33);
            this.OpenComm_btn.TabIndex = 5;
            this.OpenComm_btn.Text = "Open Port";
            this.OpenComm_btn.UseVisualStyleBackColor = true;
            this.OpenComm_btn.Click += new System.EventHandler(this.OpenComm_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Velg port";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Deltakere";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Clock_lbl
            // 
            this.Clock_lbl.AutoSize = true;
            this.Clock_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.Clock_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Clock_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock_lbl.Location = new System.Drawing.Point(27, 453);
            this.Clock_lbl.Name = "Clock_lbl";
            this.Clock_lbl.Size = new System.Drawing.Size(105, 31);
            this.Clock_lbl.TabIndex = 9;
            this.Clock_lbl.Text = "00:00:00";
            // 
            // ReadStartList_btn
            // 
            this.ReadStartList_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadStartList_btn.Location = new System.Drawing.Point(643, 168);
            this.ReadStartList_btn.Name = "ReadStartList_btn";
            this.ReadStartList_btn.Size = new System.Drawing.Size(129, 29);
            this.ReadStartList_btn.TabIndex = 10;
            this.ReadStartList_btn.Text = "Les Startliste";
            this.ReadStartList_btn.UseVisualStyleBackColor = true;
            this.ReadStartList_btn.Click += new System.EventHandler(this.ReadStartList_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(535, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(771, 281);
            this.dataGridView1.TabIndex = 11;
            // 
            // SearchCard_btn
            // 
            this.SearchCard_btn.Location = new System.Drawing.Point(532, 17);
            this.SearchCard_btn.Name = "SearchCard_btn";
            this.SearchCard_btn.Size = new System.Drawing.Size(113, 23);
            this.SearchCard_btn.TabIndex = 12;
            this.SearchCard_btn.Text = "Søk brikke";
            this.SearchCard_btn.UseVisualStyleBackColor = true;
            this.SearchCard_btn.Click += new System.EventHandler(this.SearchCard_btn_Click);
            // 
            // SearchCard_Txtbox
            // 
            this.SearchCard_Txtbox.Location = new System.Drawing.Point(532, 39);
            this.SearchCard_Txtbox.Name = "SearchCard_Txtbox";
            this.SearchCard_Txtbox.Size = new System.Drawing.Size(100, 22);
            this.SearchCard_Txtbox.TabIndex = 13;
            // 
            // StartNr_box
            // 
            this.StartNr_box.BackColor = System.Drawing.SystemColors.Control;
            this.StartNr_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartNr_box.ForeColor = System.Drawing.Color.Red;
            this.StartNr_box.Location = new System.Drawing.Point(826, 5);
            this.StartNr_box.Name = "StartNr_box";
            this.StartNr_box.Size = new System.Drawing.Size(85, 49);
            this.StartNr_box.TabIndex = 18;
            this.StartNr_box.TextChanged += new System.EventHandler(this.StartNr_box_TextChanged);
            // 
            // Navn_box
            // 
            this.Navn_box.BackColor = System.Drawing.SystemColors.Control;
            this.Navn_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Navn_box.ForeColor = System.Drawing.Color.Red;
            this.Navn_box.Location = new System.Drawing.Point(917, 5);
            this.Navn_box.Name = "Navn_box";
            this.Navn_box.Size = new System.Drawing.Size(389, 45);
            this.Navn_box.TabIndex = 19;
            // 
            // Klubb_box
            // 
            this.Klubb_box.BackColor = System.Drawing.SystemColors.Control;
            this.Klubb_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klubb_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Klubb_box.Location = new System.Drawing.Point(917, 56);
            this.Klubb_box.Name = "Klubb_box";
            this.Klubb_box.Size = new System.Drawing.Size(389, 38);
            this.Klubb_box.TabIndex = 20;
            // 
            // Klasse_box
            // 
            this.Klasse_box.BackColor = System.Drawing.SystemColors.Control;
            this.Klasse_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Klasse_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Klasse_box.Location = new System.Drawing.Point(917, 100);
            this.Klasse_box.Name = "Klasse_box";
            this.Klasse_box.Size = new System.Drawing.Size(389, 38);
            this.Klasse_box.TabIndex = 21;
            // 
            // Ecard_box
            // 
            this.Ecard_box.BackColor = System.Drawing.SystemColors.Control;
            this.Ecard_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecard_box.ForeColor = System.Drawing.Color.Blue;
            this.Ecard_box.Location = new System.Drawing.Point(692, 56);
            this.Ecard_box.Name = "Ecard_box";
            this.Ecard_box.Size = new System.Drawing.Size(219, 38);
            this.Ecard_box.TabIndex = 22;
            // 
            // Ecard2_box
            // 
            this.Ecard2_box.BackColor = System.Drawing.SystemColors.Control;
            this.Ecard2_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ecard2_box.ForeColor = System.Drawing.Color.Blue;
            this.Ecard2_box.Location = new System.Drawing.Point(692, 100);
            this.Ecard2_box.Name = "Ecard2_box";
            this.Ecard2_box.Size = new System.Drawing.Size(219, 38);
            this.Ecard2_box.TabIndex = 23;
            // 
            // ActiveUsb_box
            // 
            this.ActiveUsb_box.Location = new System.Drawing.Point(231, 133);
            this.ActiveUsb_box.Name = "ActiveUsb_box";
            this.ActiveUsb_box.Size = new System.Drawing.Size(100, 22);
            this.ActiveUsb_box.TabIndex = 24;
            // 
            // UsbRead_listBox
            // 
            this.UsbRead_listBox.FormattingEnabled = true;
            this.UsbRead_listBox.ItemHeight = 16;
            this.UsbRead_listBox.Location = new System.Drawing.Point(298, 264);
            this.UsbRead_listBox.Name = "UsbRead_listBox";
            this.UsbRead_listBox.Size = new System.Drawing.Size(207, 180);
            this.UsbRead_listBox.TabIndex = 25;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 511);
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
            this.Controls.Add(this.OpenComm_btn);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.RefreshUsbPort_btn);
            this.Controls.Add(this.UsbPort_listBox);
            this.Controls.Add(this.UsbOutText);
            this.Controls.Add(this.ReadUsb_btn);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadUsb_btn;
        private System.Windows.Forms.TextBox UsbOutText;
        private System.Windows.Forms.ListBox UsbPort_listBox;
        private System.Windows.Forms.Button RefreshUsbPort_btn;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Button OpenComm_btn;
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
    }
}

