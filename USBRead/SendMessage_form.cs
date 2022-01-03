using System;
using System.Net;
using System.Configuration;
using System.Windows.Forms;

namespace Brikkesjekk
{
    public partial class SendMessage_form : Form
    {
        MainMenu _MainMenuManager;

        public SendMessage_form()
        {
            InitializeComponent();
        }

        private void SendMessage_form_Load(object sender, EventArgs e)
        {

        }

        private void CloseMessage_btn_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    var result1 = client.DownloadString(string.Format(ConfigurationManager.AppSettings.Get("LiveResURL") + "messageapi.php?method=sendmessage&comp={0}&dbid={1}&message={2}",
lopid, startnr, melding));
                }
                catch
                {
                    MessageBox.Show("Ingen internettforbindelse!! Koble PC til internett", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }

        private void Meldinger_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comment_box.Text = Meldinger_listBox.GetItemText(Meldinger_listBox.SelectedItem);
        }
    }
}
