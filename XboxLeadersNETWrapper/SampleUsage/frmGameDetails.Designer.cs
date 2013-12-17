namespace SampleUsage
{
    partial class frmGameDetails
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
            this.pbArtwork = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGamerScore = new System.Windows.Forms.Label();
            this.lblAchievements = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblLastPlayed = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvAchievements = new System.Windows.Forms.ListView();
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGamerScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbArtwork)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbArtwork
            // 
            this.pbArtwork.Location = new System.Drawing.Point(129, 12);
            this.pbArtwork.Name = "pbArtwork";
            this.pbArtwork.Size = new System.Drawing.Size(142, 188);
            this.pbArtwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArtwork.TabIndex = 0;
            this.pbArtwork.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 213);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(376, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Game Name Goes Here";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGamerScore
            // 
            this.lblGamerScore.AutoSize = true;
            this.lblGamerScore.Location = new System.Drawing.Point(127, 239);
            this.lblGamerScore.Name = "lblGamerScore";
            this.lblGamerScore.Size = new System.Drawing.Size(72, 13);
            this.lblGamerScore.TabIndex = 2;
            this.lblGamerScore.Text = "Gamer Score:";
            // 
            // lblAchievements
            // 
            this.lblAchievements.AutoSize = true;
            this.lblAchievements.Location = new System.Drawing.Point(122, 261);
            this.lblAchievements.Name = "lblAchievements";
            this.lblAchievements.Size = new System.Drawing.Size(77, 13);
            this.lblAchievements.TabIndex = 3;
            this.lblAchievements.Text = "Achievements:";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(148, 283);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(51, 13);
            this.lblProgress.TabIndex = 4;
            this.lblProgress.Text = "Progress:";
            // 
            // lblLastPlayed
            // 
            this.lblLastPlayed.AutoSize = true;
            this.lblLastPlayed.Location = new System.Drawing.Point(134, 305);
            this.lblLastPlayed.Name = "lblLastPlayed";
            this.lblLastPlayed.Size = new System.Drawing.Size(65, 13);
            this.lblLastPlayed.TabIndex = 5;
            this.lblLastPlayed.Text = "Last Played:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvAchievements);
            this.groupBox1.Location = new System.Drawing.Point(15, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 217);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Achievements";
            // 
            // lsvAchievements
            // 
            this.lsvAchievements.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitle,
            this.chDescription,
            this.chGamerScore});
            this.lsvAchievements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvAchievements.FullRowSelect = true;
            this.lsvAchievements.GridLines = true;
            this.lsvAchievements.Location = new System.Drawing.Point(3, 16);
            this.lsvAchievements.Name = "lsvAchievements";
            this.lsvAchievements.Size = new System.Drawing.Size(367, 198);
            this.lsvAchievements.TabIndex = 0;
            this.lsvAchievements.UseCompatibleStateImageBehavior = false;
            this.lsvAchievements.View = System.Windows.Forms.View.Details;
            // 
            // chTitle
            // 
            this.chTitle.Text = "Title";
            this.chTitle.Width = 133;
            // 
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.Width = 147;
            // 
            // chGamerScore
            // 
            this.chGamerScore.Text = "GamerScore";
            this.chGamerScore.Width = 83;
            // 
            // frmGameDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLastPlayed);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblAchievements);
            this.Controls.Add(this.lblGamerScore);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbArtwork);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGameDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Details";
            ((System.ComponentModel.ISupportInitialize)(this.pbArtwork)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbArtwork;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGamerScore;
        private System.Windows.Forms.Label lblAchievements;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblLastPlayed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvAchievements;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.ColumnHeader chGamerScore;
    }
}