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
            this.NewStartNo_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SendMessage_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Comment_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NewEcard_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewStartNo_box
            // 
            this.NewStartNo_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewStartNo_box.Location = new System.Drawing.Point(173, 37);
            this.NewStartNo_box.Name = "NewStartNo_box";
            this.NewStartNo_box.Size = new System.Drawing.Size(123, 27);
            this.NewStartNo_box.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nytt startnr";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SendMessage_btn
            // 
            this.SendMessage_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMessage_btn.Location = new System.Drawing.Point(173, 146);
            this.SendMessage_btn.Name = "SendMessage_btn";
            this.SendMessage_btn.Size = new System.Drawing.Size(123, 31);
            this.SendMessage_btn.TabIndex = 2;
            this.SendMessage_btn.Text = "Send melding";
            this.SendMessage_btn.UseVisualStyleBackColor = true;
            this.SendMessage_btn.Click += new System.EventHandler(this.SendMessage_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.Location = new System.Drawing.Point(16, 147);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(123, 30);
            this.Close_btn.TabIndex = 4;
            this.Close_btn.Text = "Avbryt";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ukjent brikke -->>";
            // 
            // Comment_box
            // 
            this.Comment_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment_box.Location = new System.Drawing.Point(16, 103);
            this.Comment_box.Name = "Comment_box";
            this.Comment_box.Size = new System.Drawing.Size(280, 27);
            this.Comment_box.TabIndex = 8;
            this.Comment_box.Text = "Ukjent brikke";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kommentar";
            // 
            // NewEcard_Box
            // 
            this.NewEcard_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEcard_Box.ForeColor = System.Drawing.Color.Red;
            this.NewEcard_Box.Location = new System.Drawing.Point(16, 37);
            this.NewEcard_Box.Name = "NewEcard_Box";
            this.NewEcard_Box.Size = new System.Drawing.Size(123, 27);
            this.NewEcard_Box.TabIndex = 10;
            // 
            // SendMessage_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 192);
            this.Controls.Add(this.NewEcard_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Comment_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.SendMessage_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewStartNo_box);
            this.Name = "SendMessage_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tildel brikke";
            this.Load += new System.EventHandler(this.SendMessage_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewStartNo_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendMessage_btn;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Comment_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewEcard_Box;
    }
}