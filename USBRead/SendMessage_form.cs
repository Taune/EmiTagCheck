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

        MainMenu _MainMenuManager;

        public SendMessage_form()
        {
            InitializeComponent();
            //System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["MainMenu"];
        }


        private void SendMessage_btn_Click(object sender, EventArgs e)
        {
            _MainMenuManager = new MainMenu();
            using (var client = new WebClient())
            {
                var lopid = MainMenu.SetValueForLopsid;
                var startnr = 0;
                var melding = Comment_box.Text;

                try 
                {
                        var result1 = client.DownloadString(string.Format("https://api.freidig.idrett.no/messageapi.php?method=sendmessage&comp={0}&dbid={1}&message={2}",
lopid, startnr, melding));
                        Console.WriteLine(result1);
                }
                catch
                {
                    MessageBox.Show("Ingen internettforbindelse!! Koble PC til internett", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Meldinger_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comment_box.Text = Meldinger_listBox.GetItemText(Meldinger_listBox.SelectedItem);
        }

    }
}
