using System;
using System.Windows.Forms;
using XboxLeadersNETWrapper;

namespace SampleUsage
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            cmdGetData.Click += cmdGetData_Click;
        }

        private void cmdGetData_Click(object sender, EventArgs e)
        {
            Profile pProfile = new Profile();
            Games gGames = new Games();

            pProfile = XboxLeadersAPI.DownloadProfileData(txtGamerTag.Text);
            //gGames = XboxLeadersAPI.DownloadGameData(txtGamerTag.Text);

            pbAvatar.Image = pProfile.Avatar;
            lblGamerTag.Text = "GamerTag: " + pProfile.GamerTag;
            lblScore.Text = "Gamer Score: " + pProfile.GamerScore.ToString();
            lblRep.Text = "Reputation: " + pProfile.Reputation.ToString();
            lblPresence.Text = "Presence: " + pProfile.Presence;
            lblOnline.Text = "Online: " + pProfile.Online.ToString();
            lblLocation.Text = "Location: " + pProfile.Location;
            lblBiography.Text = "Biography: " + pProfile.Biography;
        }
    }
}
