using System;
using System.Net;
using System.Configuration;
using System.Windows.Forms;

namespace Brikkesjekk
{
    public partial class ChangeEcard_form : Form
    {
        public bool SendMessage = false;
        
        MainMenu _MainMenuManager;

        public ChangeEcard_form(MainMenu frm1)
        {
            InitializeComponent();
            this._MainMenuManager = frm1;
        }


        private void SendMessage_btn_Click(object sender, EventArgs e)
        {
            SendMessage = true;
            this.Close();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendMessage_form_Load(object sender, EventArgs e)
        {
            SendMessage = false;
            MainMenu form = new MainMenu();
            ByttStartnrBox.Text = _MainMenuManager.StartNr_box.Text;
            ByttBrikkeBox.Text = _MainMenuManager.SearchCard_Txtbox.Text;
        }

     }
}
