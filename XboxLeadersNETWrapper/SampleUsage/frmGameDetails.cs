using System;
using System.Windows.Forms;
using XboxLeadersNETWrapper;

namespace SampleUsage
{
    public partial class frmGameDetails : Form
    {
        private Game gGame;
        private String sGamerTag;

        public frmGameDetails(Game gGame, String sGamerTag)
        {
            InitializeComponent();

            this.gGame = gGame;
            this.sGamerTag = sGamerTag;

            this.Shown += frmGameDetails_Shown;    
        }

        private void frmGameDetails_Shown(object sender, EventArgs e)
        {
            GameAchievements gaAchievements;
            ListViewItem lsvItem;

            pbArtwork.Image = gGame.Artwork;
            lblTitle.Text = gGame.Title;
            lblGamerScore.Text = String.Format("GamerScore: {0}/{1}", gGame.GamerScore.Current, gGame.GamerScore.Total);
            lblAchievements.Text = String.Format("Achievements: {0}/{1}", gGame.Achievements.Current, gGame.Achievements.Total);
            lblProgress.Text = String.Format("Progress: {0}%", gGame.Progress);
            lblLastPlayed.Text = "Last Played: " + gGame.LastPlayed.ToLocalTime().ToString();

            gaAchievements = XboxLeadersAPI.DownloadGameAchievements(sGamerTag, gGame.ID);

            foreach (Achievement aAchievement in gaAchievements.AchievementList)
            {
                if (aAchievement.Unlocked)
                {
                    lsvItem = new ListViewItem(aAchievement.Title);
                    lsvItem.SubItems.Add(aAchievement.Description);
                    lsvItem.SubItems.Add(aAchievement.GamerScore.ToString());

                    lsvAchievements.Items.Add(lsvItem);
                }
            }
        }

    }
}
