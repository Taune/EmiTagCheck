
namespace Brikkesjekk
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
            this.CloseMessage_btn = new System.Windows.Forms.Button();
            this.Meldinger_listBox = new System.Windows.Forms.ListBox();
            this.Comment_box = new System.Windows.Forms.TextBox();
            this.SendMessage_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseMessage_btn
            // 
            this.CloseMessage_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.CloseMessage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseMessage_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseMessage_btn.ForeColor = System.Drawing.Color.White;
            this.CloseMessage_btn.Location = new System.Drawing.Point(48, 296);
            this.CloseMessage_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseMessage_btn.Name = "CloseMessage_btn";
            this.CloseMessage_btn.Size = new System.Drawing.Size(125, 43);
            this.CloseMessage_btn.TabIndex = 0;
            this.CloseMessage_btn.Text = "AVBRYT";
            this.CloseMessage_btn.UseVisualStyleBackColor = false;
            this.CloseMessage_btn.Click += new System.EventHandler(this.CloseMessage_btn_Click);
            // 
            // Meldinger_listBox
            // 
            this.Meldinger_listBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meldinger_listBox.FormattingEnabled = true;
            this.Meldinger_listBox.ItemHeight = 25;
            this.Meldinger_listBox.Items.AddRange(new object[] {
            "Startnr * fikk ny starttid *",
            "Startnr * byttet klasse til *",
            "Startnr * gikk med startnr *"});
            this.Meldinger_listBox.Location = new System.Drawing.Point(21, 92);
            this.Meldinger_listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Meldinger_listBox.Name = "Meldinger_listBox";
            this.Meldinger_listBox.Size = new System.Drawing.Size(347, 79);
            this.Meldinger_listBox.TabIndex = 1;
            this.Meldinger_listBox.SelectedIndexChanged += new System.EventHandler(this.Meldinger_listBox_SelectedIndexChanged);
            // 
            // Comment_box
            // 
            this.Comment_box.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment_box.Location = new System.Drawing.Point(21, 226);
            this.Comment_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Comment_box.Name = "Comment_box";
            this.Comment_box.Size = new System.Drawing.Size(347, 31);
            this.Comment_box.TabIndex = 2;
            // 
            // SendMessage_btn
            // 
            this.SendMessage_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.SendMessage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendMessage_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMessage_btn.ForeColor = System.Drawing.Color.White;
            this.SendMessage_btn.Location = new System.Drawing.Point(213, 296);
            this.SendMessage_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SendMessage_btn.Name = "SendMessage_btn";
            this.SendMessage_btn.Size = new System.Drawing.Size(125, 43);
            this.SendMessage_btn.TabIndex = 3;
            this.SendMessage_btn.Text = "SEND";
            this.SendMessage_btn.UseVisualStyleBackColor = false;
            this.SendMessage_btn.Click += new System.EventHandler(this.SendMessage_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Standardkommentarer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kommentar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(19, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Oppgi tilstrekkelig info; startnr, starttidspunkt mm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Send melding til LiveRes meldingstjeneste";
            // 
            // SendMessage_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 363);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendMessage_btn);
            this.Controls.Add(this.Comment_box);
            this.Controls.Add(this.Meldinger_listBox);
            this.Controls.Add(this.CloseMessage_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SendMessage_form";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send melding";
            this.Load += new System.EventHandler(this.SendMessage_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseMessage_btn;
        private System.Windows.Forms.ListBox Meldinger_listBox;
        private System.Windows.Forms.TextBox Comment_box;
        private System.Windows.Forms.Button SendMessage_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}