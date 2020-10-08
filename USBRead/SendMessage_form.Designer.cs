namespace USBRead
{
    partial class SendMessage_form
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
            this.SendMessage_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Comment_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Meldinger_listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendMessage_btn
            // 
            this.SendMessage_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMessage_btn.Location = new System.Drawing.Point(130, 180);
            this.SendMessage_btn.Margin = new System.Windows.Forms.Padding(2);
            this.SendMessage_btn.Name = "SendMessage_btn";
            this.SendMessage_btn.Size = new System.Drawing.Size(92, 25);
            this.SendMessage_btn.TabIndex = 2;
            this.SendMessage_btn.Text = "Send melding";
            this.SendMessage_btn.UseVisualStyleBackColor = true;
            this.SendMessage_btn.Click += new System.EventHandler(this.SendMessage_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.Location = new System.Drawing.Point(12, 181);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(92, 24);
            this.Close_btn.TabIndex = 4;
            this.Close_btn.Text = "Avbryt";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Standardkommentarer";
            // 
            // Comment_box
            // 
            this.Comment_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment_box.Location = new System.Drawing.Point(12, 131);
            this.Comment_box.Margin = new System.Windows.Forms.Padding(2);
            this.Comment_box.Name = "Comment_box";
            this.Comment_box.Size = new System.Drawing.Size(242, 23);
            this.Comment_box.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kommentar";
            // 
            // Meldinger_listBox
            // 
            this.Meldinger_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meldinger_listBox.FormattingEnabled = true;
            this.Meldinger_listBox.ItemHeight = 17;
            this.Meldinger_listBox.Items.AddRange(new object[] {
            "Startnr * fikk ny starttid *",
            "Startnr * byttet klasse til *",
            "Startnr * gikk med startnr *"});
            this.Meldinger_listBox.Location = new System.Drawing.Point(13, 28);
            this.Meldinger_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.Meldinger_listBox.Name = "Meldinger_listBox";
            this.Meldinger_listBox.Size = new System.Drawing.Size(241, 72);
            this.Meldinger_listBox.TabIndex = 11;
            this.Meldinger_listBox.SelectedIndexChanged += new System.EventHandler(this.Meldinger_listBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Oppgi tilstrekkelig info; startnr, starttidspunkt mm";
            // 
            // SendMessage_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 215);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Meldinger_listBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Comment_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.SendMessage_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SendMessage_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send melding til LiveRes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SendMessage_btn;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Comment_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Meldinger_listBox;
        private System.Windows.Forms.Label label1;
    }
}