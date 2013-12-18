namespace SampleUsage
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Online", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Offline", System.Windows.Forms.HorizontalAlignment.Left);
            this.cmsGames = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gameDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpXLProfile = new System.Windows.Forms.TabPage();
            this.cmdGetData = new System.Windows.Forms.Button();
            this.txtGamerTag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpProfile = new System.Windows.Forms.TabPage();
            this.gbActivity = new System.Windows.Forms.GroupBox();
            this.lsvActivity = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblBiography = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.lblPresence = new System.Windows.Forms.Label();
            this.lblRep = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGamerTag = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.tpGames = new System.Windows.Forms.TabPage();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblTotalGames = new System.Windows.Forms.Label();
            this.lblAchievements = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvGames = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpFriends = new System.Windows.Forms.TabPage();
            this.lsvFriends = new System.Windows.Forms.ListView();
            this.chGamerTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastSeen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.lnkBrowser = new System.Windows.Forms.LinkLabel();
            this.gbSearchResults = new System.Windows.Forms.GroupBox();
            this.lsvSearchResults = new System.Windows.Forms.ListView();
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDownloadType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdSearch = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.lblQuery = new System.Windows.Forms.Label();
            this.cmsGames.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpXLProfile.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpProfile.SuspendLayout();
            this.gbActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.tpGames.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpFriends.SuspendLayout();
            this.tpSearch.SuspendLayout();
            this.gbSearchResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsGames
            // 
            this.cmsGames.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameDetailsToolStripMenuItem});
            this.cmsGames.Name = "cmsGames";
            this.cmsGames.Size = new System.Drawing.Size(144, 26);
            // 
            // gameDetailsToolStripMenuItem
            // 
            this.gameDetailsToolStripMenuItem.Name = "gameDetailsToolStripMenuItem";
            this.gameDetailsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.gameDetailsToolStripMenuItem.Text = "&Game Details";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpXLProfile);
            this.tabControl1.Controls.Add(this.tpSearch);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 393);
            this.tabControl1.TabIndex = 1;
            // 
            // tpXLProfile
            // 
            this.tpXLProfile.BackColor = System.Drawing.SystemColors.Control;
            this.tpXLProfile.Controls.Add(this.cmdGetData);
            this.tpXLProfile.Controls.Add(this.txtGamerTag);
            this.tpXLProfile.Controls.Add(this.label1);
            this.tpXLProfile.Controls.Add(this.tabControl2);
            this.tpXLProfile.Location = new System.Drawing.Point(4, 22);
            this.tpXLProfile.Name = "tpXLProfile";
            this.tpXLProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tpXLProfile.Size = new System.Drawing.Size(531, 367);
            this.tpXLProfile.TabIndex = 0;
            this.tpXLProfile.Text = "Xbox Live Profile";
            // 
            // cmdGetData
            // 
            this.cmdGetData.Location = new System.Drawing.Point(294, 7);
            this.cmdGetData.Name = "cmdGetData";
            this.cmdGetData.Size = new System.Drawing.Size(75, 23);
            this.cmdGetData.TabIndex = 7;
            this.cmdGetData.Text = "&Get Data";
            this.cmdGetData.UseVisualStyleBackColor = true;
            // 
            // txtGamerTag
            // 
            this.txtGamerTag.Location = new System.Drawing.Point(75, 9);
            this.txtGamerTag.Name = "txtGamerTag";
            this.txtGamerTag.Size = new System.Drawing.Size(213, 20);
            this.txtGamerTag.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "GamerTag:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpProfile);
            this.tabControl2.Controls.Add(this.tpGames);
            this.tabControl2.Controls.Add(this.tpFriends);
            this.tabControl2.Location = new System.Drawing.Point(8, 36);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(518, 328);
            this.tabControl2.TabIndex = 4;
            // 
            // tpProfile
            // 
            this.tpProfile.BackColor = System.Drawing.SystemColors.Control;
            this.tpProfile.Controls.Add(this.gbActivity);
            this.tpProfile.Controls.Add(this.lblBiography);
            this.tpProfile.Controls.Add(this.lblLocation);
            this.tpProfile.Controls.Add(this.lblOnline);
            this.tpProfile.Controls.Add(this.lblPresence);
            this.tpProfile.Controls.Add(this.lblRep);
            this.tpProfile.Controls.Add(this.lblScore);
            this.tpProfile.Controls.Add(this.lblGamerTag);
            this.tpProfile.Controls.Add(this.pbAvatar);
            this.tpProfile.Location = new System.Drawing.Point(4, 22);
            this.tpProfile.Name = "tpProfile";
            this.tpProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tpProfile.Size = new System.Drawing.Size(510, 302);
            this.tpProfile.TabIndex = 0;
            this.tpProfile.Text = "Profile";
            // 
            // gbActivity
            // 
            this.gbActivity.Controls.Add(this.lsvActivity);
            this.gbActivity.Location = new System.Drawing.Point(160, 185);
            this.gbActivity.Name = "gbActivity";
            this.gbActivity.Size = new System.Drawing.Size(344, 111);
            this.gbActivity.TabIndex = 8;
            this.gbActivity.TabStop = false;
            this.gbActivity.Text = "Recent Activity";
            // 
            // lsvActivity
            // 
            this.lsvActivity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvActivity.FullRowSelect = true;
            this.lsvActivity.GridLines = true;
            this.lsvActivity.Location = new System.Drawing.Point(3, 16);
            this.lsvActivity.Name = "lsvActivity";
            this.lsvActivity.Size = new System.Drawing.Size(338, 92);
            this.lsvActivity.TabIndex = 0;
            this.lsvActivity.UseCompatibleStateImageBehavior = false;
            this.lsvActivity.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 159;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Played";
            this.columnHeader2.Width = 166;
            // 
            // lblBiography
            // 
            this.lblBiography.AutoSize = true;
            this.lblBiography.Location = new System.Drawing.Point(172, 150);
            this.lblBiography.Name = "lblBiography";
            this.lblBiography.Size = new System.Drawing.Size(57, 13);
            this.lblBiography.TabIndex = 7;
            this.lblBiography.Text = "Biography:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(178, 126);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 13);
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "Location:";
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Location = new System.Drawing.Point(186, 102);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(43, 13);
            this.lblOnline.TabIndex = 5;
            this.lblOnline.Text = "Online: ";
            // 
            // lblPresence
            // 
            this.lblPresence.AutoSize = true;
            this.lblPresence.Location = new System.Drawing.Point(177, 78);
            this.lblPresence.Name = "lblPresence";
            this.lblPresence.Size = new System.Drawing.Size(52, 13);
            this.lblPresence.TabIndex = 4;
            this.lblPresence.Text = "Presence";
            // 
            // lblRep
            // 
            this.lblRep.AutoSize = true;
            this.lblRep.Location = new System.Drawing.Point(167, 54);
            this.lblRep.Name = "lblRep";
            this.lblRep.Size = new System.Drawing.Size(62, 13);
            this.lblRep.TabIndex = 3;
            this.lblRep.Text = "Reputation:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(157, 30);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(72, 13);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Gamer Score:";
            // 
            // lblGamerTag
            // 
            this.lblGamerTag.AutoSize = true;
            this.lblGamerTag.Location = new System.Drawing.Point(169, 6);
            this.lblGamerTag.Name = "lblGamerTag";
            this.lblGamerTag.Size = new System.Drawing.Size(60, 13);
            this.lblGamerTag.TabIndex = 1;
            this.lblGamerTag.Text = "GamerTag:";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(6, 6);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(145, 290);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            // 
            // tpGames
            // 
            this.tpGames.BackColor = System.Drawing.SystemColors.Control;
            this.tpGames.Controls.Add(this.lblProgress);
            this.tpGames.Controls.Add(this.lblTotalGames);
            this.tpGames.Controls.Add(this.lblAchievements);
            this.tpGames.Controls.Add(this.groupBox1);
            this.tpGames.Location = new System.Drawing.Point(4, 22);
            this.tpGames.Name = "tpGames";
            this.tpGames.Padding = new System.Windows.Forms.Padding(3);
            this.tpGames.Size = new System.Drawing.Size(510, 302);
            this.tpGames.TabIndex = 1;
            this.tpGames.Text = "Games";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(33, 61);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(51, 13);
            this.lblProgress.TabIndex = 3;
            this.lblProgress.Text = "Progress:";
            // 
            // lblTotalGames
            // 
            this.lblTotalGames.AutoSize = true;
            this.lblTotalGames.Location = new System.Drawing.Point(6, 37);
            this.lblTotalGames.Name = "lblTotalGames";
            this.lblTotalGames.Size = new System.Drawing.Size(78, 13);
            this.lblTotalGames.TabIndex = 2;
            this.lblTotalGames.Text = "Games Played:";
            // 
            // lblAchievements
            // 
            this.lblAchievements.AutoSize = true;
            this.lblAchievements.Location = new System.Drawing.Point(7, 13);
            this.lblAchievements.Name = "lblAchievements";
            this.lblAchievements.Size = new System.Drawing.Size(77, 13);
            this.lblAchievements.TabIndex = 1;
            this.lblAchievements.Text = "Achievements:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvGames);
            this.groupBox1.Location = new System.Drawing.Point(6, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Played Games";
            // 
            // lsvGames
            // 
            this.lsvGames.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lsvGames.ContextMenuStrip = this.cmsGames;
            this.lsvGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvGames.FullRowSelect = true;
            this.lsvGames.GridLines = true;
            this.lsvGames.Location = new System.Drawing.Point(3, 16);
            this.lsvGames.Name = "lsvGames";
            this.lsvGames.Size = new System.Drawing.Size(492, 188);
            this.lsvGames.TabIndex = 1;
            this.lsvGames.UseCompatibleStateImageBehavior = false;
            this.lsvGames.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Title";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gamer Score";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Achievements";
            this.columnHeader5.Width = 101;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Progress";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Last Played";
            this.columnHeader7.Width = 137;
            // 
            // tpFriends
            // 
            this.tpFriends.BackColor = System.Drawing.SystemColors.Control;
            this.tpFriends.Controls.Add(this.lsvFriends);
            this.tpFriends.Location = new System.Drawing.Point(4, 22);
            this.tpFriends.Name = "tpFriends";
            this.tpFriends.Padding = new System.Windows.Forms.Padding(3);
            this.tpFriends.Size = new System.Drawing.Size(510, 302);
            this.tpFriends.TabIndex = 2;
            this.tpFriends.Text = "Friends";
            // 
            // lsvFriends
            // 
            this.lsvFriends.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chGamerTag,
            this.chStatus,
            this.chLastSeen});
            this.lsvFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "Online";
            listViewGroup1.Name = "lsvgOnline";
            listViewGroup2.Header = "Offline";
            listViewGroup2.Name = "lsvgOffline";
            this.lsvFriends.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lsvFriends.Location = new System.Drawing.Point(3, 3);
            this.lsvFriends.Name = "lsvFriends";
            this.lsvFriends.Size = new System.Drawing.Size(504, 296);
            this.lsvFriends.TabIndex = 0;
            this.lsvFriends.UseCompatibleStateImageBehavior = false;
            this.lsvFriends.View = System.Windows.Forms.View.Details;
            // 
            // chGamerTag
            // 
            this.chGamerTag.Text = "Gamer Tag";
            this.chGamerTag.Width = 158;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.Width = 204;
            // 
            // chLastSeen
            // 
            this.chLastSeen.Text = "Last Seen";
            this.chLastSeen.Width = 131;
            // 
            // tpSearch
            // 
            this.tpSearch.BackColor = System.Drawing.SystemColors.Control;
            this.tpSearch.Controls.Add(this.lnkBrowser);
            this.tpSearch.Controls.Add(this.gbSearchResults);
            this.tpSearch.Controls.Add(this.cmdSearch);
            this.tpSearch.Controls.Add(this.txtQuery);
            this.tpSearch.Controls.Add(this.lblQuery);
            this.tpSearch.Location = new System.Drawing.Point(4, 22);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(531, 367);
            this.tpSearch.TabIndex = 1;
            this.tpSearch.Text = "Search XBox Live";
            // 
            // lnkBrowser
            // 
            this.lnkBrowser.AutoSize = true;
            this.lnkBrowser.Enabled = false;
            this.lnkBrowser.Location = new System.Drawing.Point(414, 351);
            this.lnkBrowser.Name = "lnkBrowser";
            this.lnkBrowser.Size = new System.Drawing.Size(114, 13);
            this.lnkBrowser.TabIndex = 4;
            this.lnkBrowser.TabStop = true;
            this.lnkBrowser.Text = "View Query In Browser";
            // 
            // gbSearchResults
            // 
            this.gbSearchResults.Controls.Add(this.lsvSearchResults);
            this.gbSearchResults.Location = new System.Drawing.Point(9, 37);
            this.gbSearchResults.Name = "gbSearchResults";
            this.gbSearchResults.Size = new System.Drawing.Size(516, 311);
            this.gbSearchResults.TabIndex = 3;
            this.gbSearchResults.TabStop = false;
            this.gbSearchResults.Text = "&Search Results";
            // 
            // lsvSearchResults
            // 
            this.lsvSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitle,
            this.chDownloadType,
            this.chPrice});
            this.lsvSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvSearchResults.FullRowSelect = true;
            this.lsvSearchResults.GridLines = true;
            this.lsvSearchResults.Location = new System.Drawing.Point(3, 16);
            this.lsvSearchResults.Name = "lsvSearchResults";
            this.lsvSearchResults.Size = new System.Drawing.Size(510, 292);
            this.lsvSearchResults.TabIndex = 0;
            this.lsvSearchResults.UseCompatibleStateImageBehavior = false;
            this.lsvSearchResults.View = System.Windows.Forms.View.Details;
            // 
            // chTitle
            // 
            this.chTitle.Text = "Title";
            this.chTitle.Width = 286;
            // 
            // chDownloadType
            // 
            this.chDownloadType.Text = "Download Type";
            this.chDownloadType.Width = 105;
            // 
            // chPrice
            // 
            this.chPrice.Text = "Price";
            this.chPrice.Width = 112;
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(312, 9);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(75, 23);
            this.cmdSearch.TabIndex = 2;
            this.cmdSearch.Text = "&Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(50, 11);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(256, 20);
            this.txtQuery.TabIndex = 1;
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Location = new System.Drawing.Point(6, 14);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(38, 13);
            this.lblQuery.TabIndex = 0;
            this.lblQuery.Text = "Query:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 409);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XboxLeader API Sample";
            this.cmsGames.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpXLProfile.ResumeLayout(false);
            this.tpXLProfile.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tpProfile.ResumeLayout(false);
            this.tpProfile.PerformLayout();
            this.gbActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.tpGames.ResumeLayout(false);
            this.tpGames.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tpFriends.ResumeLayout(false);
            this.tpSearch.ResumeLayout(false);
            this.tpSearch.PerformLayout();
            this.gbSearchResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsGames;
        private System.Windows.Forms.ToolStripMenuItem gameDetailsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpXLProfile;
        private System.Windows.Forms.Button cmdGetData;
        private System.Windows.Forms.TextBox txtGamerTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpProfile;
        private System.Windows.Forms.GroupBox gbActivity;
        private System.Windows.Forms.ListView lsvActivity;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblBiography;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Label lblPresence;
        private System.Windows.Forms.Label lblRep;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGamerTag;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.TabPage tpGames;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblTotalGames;
        private System.Windows.Forms.Label lblAchievements;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvGames;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TabPage tpFriends;
        private System.Windows.Forms.ListView lsvFriends;
        private System.Windows.Forms.ColumnHeader chGamerTag;
        private System.Windows.Forms.ColumnHeader chStatus;
        private System.Windows.Forms.ColumnHeader chLastSeen;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.GroupBox gbSearchResults;
        private System.Windows.Forms.ListView lsvSearchResults;
        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.ColumnHeader chDownloadType;
        private System.Windows.Forms.ColumnHeader chPrice;
        private System.Windows.Forms.LinkLabel lnkBrowser;

    }
}

