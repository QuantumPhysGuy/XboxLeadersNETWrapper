using System;
using System.Windows.Forms;
using XboxLeadersNETWrapper;

namespace SampleUsage
{
    public partial class frmMain : Form
    {
        private Profile pProfile = new Profile();
        private Friends fFriends = new Friends();
        private Games gGames = new Games();

        public frmMain()
        {
            InitializeComponent();

            cmdGetData.Click += cmdGetData_Click;
            cmdSearch.Click += cmdSearch_Click;

            gameDetailsToolStripMenuItem.Click += gameDetailsToolStripMenuItem_Click;

            lnkBrowser.Click += lnkBrowser_Click;
        }
        
        private void cmdGetData_Click(object sender, EventArgs e)
        {
            ListViewItem lsvItem;

            pProfile = XboxLeadersAPI.DownloadProfileData(txtGamerTag.Text);
            gGames = XboxLeadersAPI.DownloadGameData(txtGamerTag.Text);
            fFriends = XboxLeadersAPI.DownloadFriendList(txtGamerTag.Text);

            pbAvatar.Image = pProfile.Avatar;
            lblGamerTag.Text = "GamerTag: " + pProfile.GamerTag;
            lblScore.Text = "Gamer Score: " + pProfile.GamerScore.ToString();
            lblRep.Text = "Reputation: " + pProfile.Reputation.ToString();
            lblPresence.Text = "Presence: " + pProfile.Presence;
            lblOnline.Text = "Online: " + pProfile.Online.ToString();
            lblLocation.Text = "Location: " + pProfile.Location;
            lblBiography.Text = "Biography: " + pProfile.Biography;

            foreach (Activity aActivity in pProfile.RecentActivity)
            {
                lsvItem = new ListViewItem(aActivity.Title);
                lsvItem.SubItems.Add(aActivity.LastPlayed.ToLocalTime().ToString());

                lsvActivity.Items.Add(lsvItem);
            }

            lblAchievements.Text = String.Format("Achievements: {0}/{1}", gGames.Achievements.Current, gGames.Achievements.Total);
            lblTotalGames.Text = "Games Played: " + gGames.TotalGames.ToString();
            lblProgress.Text = String.Format("Progress: {0}%", gGames.Progress);

            foreach (Game gGame in gGames.PlayedGames)
            {
                lsvItem = new ListViewItem(gGame.Title);
                lsvItem.SubItems.Add(String.Format("{0}/{1}", gGame.GamerScore.Current, gGame.GamerScore.Total));
                lsvItem.SubItems.Add(String.Format("{0}/{1}", gGame.Achievements.Current, gGame.Achievements.Total));
                lsvItem.SubItems.Add(String.Format("{0}%", gGame.Progress));
                lsvItem.SubItems.Add(gGame.LastPlayed.ToLocalTime().ToString());

                lsvGames.Items.Add(lsvItem);
            }

            foreach (Friend fFriend in fFriends.GamerFriends)
            {
                lsvItem = new ListViewItem(fFriend.GamerTag);

                if (fFriend.Online)
                {
                    lsvItem.Group = lsvFriends.Groups[0];
                }
                else
                {
                    lsvItem.Group = lsvFriends.Groups[1];
                }

                lsvItem.SubItems.Add(fFriend.Status);
                lsvItem.SubItems.Add(fFriend.LastSeen.ToLocalTime().ToString());

                lsvFriends.Items.Add(lsvItem);
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            Search sSearch = XboxLeadersAPI.DownloadSearchResults(txtQuery.Text);

            foreach (SearchResult srResult in sSearch.Results)
            {
                ListViewItem lsvItem = new ListViewItem(srResult.Title);

                lsvItem.SubItems.Add(srResult.DownloadType.Class);
                lsvItem.SubItems.Add(String.Format("Silver: {0} Gold: {0}", srResult.Prices.Silver, srResult.Prices.Gold));

                lsvSearchResults.Items.Add(lsvItem);
            }

            lnkBrowser.Tag = sSearch.ResultsLink.ToString();
            lnkBrowser.Enabled = true;
        }
        
        private void lnkBrowser_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lnkBrowser.Tag.ToString());
        }

        private void gameDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmGameDetails(gGames.PlayedGames[lsvGames.SelectedItems[0].Index], pProfile.GamerTag).ShowDialog();            
        }
    }
}