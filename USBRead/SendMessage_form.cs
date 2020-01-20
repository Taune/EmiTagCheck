using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace USBRead
{
    public partial class SendMessage_form : Form
    {
        public SendMessage_form()
        {
            InitializeComponent();
            //System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["MainMenu"];
        }


        private void SendMessage_btn_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                var lopid = 14872;
                var tidsp = DateTime.Now.ToString("hh:mm:ss");
                var Melding = "Brikke 999 til startnr 222";
                var result = client.DownloadString(string.Format("http://liveres.freidig.idrett.no/liveres_helpers/log.php?lopid={0}&Melding={1}", 
                    lopid, Melding));
                Console.WriteLine(result);
            }
            this.Close();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendMessage_form_Load(object sender, EventArgs e)
        {
            label2.Text = MainMenu.SetValueForEmitag +" -->>";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
