namespace Brikkesjekk
{
    partial class ChangeEcard_form
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
            this.ByttStartnrBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ByttBrikkeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendMessage_btn
            // 
            this.SendMessage_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.SendMessage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMessage_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMessage_btn.ForeColor = System.Drawing.Color.White;
            this.SendMessage_btn.Location = new System.Drawing.Point(218, 219);
            this.SendMessage_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SendMessage_btn.Name = "SendMessage_btn";
            this.SendMessage_btn.Size = new System.Drawing.Size(94, 35);
            this.SendMessage_btn.TabIndex = 2;
            this.SendMessage_btn.Text = "OK";
            this.SendMessage_btn.UseVisualStyleBackColor = false;
            this.SendMessage_btn.Click += new System.EventHandler(this.SendMessage_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_btn.ForeColor = System.Drawing.Color.White;
            this.Close_btn.Location = new System.Drawing.Point(100, 219);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(94, 35);
            this.Close_btn.TabIndex = 4;
            this.Close_btn.Text = "AVBRYT";
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Send melding om at startnummer";
            // 
            // ByttStartnrBox
            // 
            this.ByttStartnrBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ByttStartnrBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ByttStartnrBox.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByttStartnrBox.ForeColor = System.Drawing.Color.Red;
            this.ByttStartnrBox.Location = new System.Drawing.Point(63, 50);
            this.ByttStartnrBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ByttStartnrBox.Name = "ByttStartnrBox";
            this.ByttStartnrBox.Size = new System.Drawing.Size(278, 64);
            this.ByttStartnrBox.TabIndex = 13;
            this.ByttStartnrBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "bytter brikke til";
            // 
            // ByttBrikkeBox
            // 
            this.ByttBrikkeBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ByttBrikkeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ByttBrikkeBox.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByttBrikkeBox.ForeColor = System.Drawing.Color.Blue;
            this.ByttBrikkeBox.Location = new System.Drawing.Point(63, 147);
            this.ByttBrikkeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ByttBrikkeBox.Name = "ByttBrikkeBox";
            this.ByttBrikkeBox.Size = new System.Drawing.Size(278, 64);
            this.ByttBrikkeBox.TabIndex = 15;
            this.ByttBrikkeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChangeEcard_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(417, 292);
            this.Controls.Add(this.ByttBrikkeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ByttStartnrBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.SendMessage_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChangeEcard_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bytte brikke";
            this.Load += new System.EventHandler(this.SendMessage_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ByttStartnrBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ByttBrikkeBox;
        public System.Windows.Forms.Button SendMessage_btn;
    }
}