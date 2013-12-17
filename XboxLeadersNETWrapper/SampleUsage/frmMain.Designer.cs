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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpProfile = new System.Windows.Forms.TabPage();
            this.tpGames = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGamerTag = new System.Windows.Forms.TextBox();
            this.cmdGetData = new System.Windows.Forms.Button();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lblGamerTag = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblRep = new System.Windows.Forms.Label();
            this.lblPresence = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblBiography = new System.Windows.Forms.Label();
            this.gbActivity = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tpProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpProfile);
            this.tabControl1.Controls.Add(this.tpGames);
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 328);
            this.tabControl1.TabIndex = 0;
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
            // tpGames
            // 
            this.tpGames.BackColor = System.Drawing.SystemColors.Control;
            this.tpGames.Location = new System.Drawing.Point(4, 22);
            this.tpGames.Name = "tpGames";
            this.tpGames.Padding = new System.Windows.Forms.Padding(3);
            this.tpGames.Size = new System.Drawing.Size(510, 323);
            this.tpGames.TabIndex = 1;
            this.tpGames.Text = "Games";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GamerTag:";
            // 
            // txtGamerTag
            // 
            this.txtGamerTag.Location = new System.Drawing.Point(79, 6);
            this.txtGamerTag.Name = "txtGamerTag";
            this.txtGamerTag.Size = new System.Drawing.Size(213, 20);
            this.txtGamerTag.TabIndex = 2;
            // 
            // cmdGetData
            // 
            this.cmdGetData.Location = new System.Drawing.Point(298, 4);
            this.cmdGetData.Name = "cmdGetData";
            this.cmdGetData.Size = new System.Drawing.Size(75, 23);
            this.cmdGetData.TabIndex = 3;
            this.cmdGetData.Text = "&Get Data";
            this.cmdGetData.UseVisualStyleBackColor = true;
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
            // lblGamerTag
            // 
            this.lblGamerTag.AutoSize = true;
            this.lblGamerTag.Location = new System.Drawing.Point(169, 6);
            this.lblGamerTag.Name = "lblGamerTag";
            this.lblGamerTag.Size = new System.Drawing.Size(60, 13);
            this.lblGamerTag.TabIndex = 1;
            this.lblGamerTag.Text = "GamerTag:";
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
            // lblRep
            // 
            this.lblRep.AutoSize = true;
            this.lblRep.Location = new System.Drawing.Point(167, 54);
            this.lblRep.Name = "lblRep";
            this.lblRep.Size = new System.Drawing.Size(62, 13);
            this.lblRep.TabIndex = 3;
            this.lblRep.Text = "Reputation:";
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
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Location = new System.Drawing.Point(186, 102);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(43, 13);
            this.lblOnline.TabIndex = 5;
            this.lblOnline.Text = "Online: ";
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
            // lblBiography
            // 
            this.lblBiography.AutoSize = true;
            this.lblBiography.Location = new System.Drawing.Point(172, 150);
            this.lblBiography.Name = "lblBiography";
            this.lblBiography.Size = new System.Drawing.Size(57, 13);
            this.lblBiography.TabIndex = 7;
            this.lblBiography.Text = "Biography:";
            // 
            // gbActivity
            // 
            this.gbActivity.Location = new System.Drawing.Point(160, 185);
            this.gbActivity.Name = "gbActivity";
            this.gbActivity.Size = new System.Drawing.Size(344, 111);
            this.gbActivity.TabIndex = 8;
            this.gbActivity.TabStop = false;
            this.gbActivity.Text = "Recent Activity";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 373);
            this.Controls.Add(this.cmdGetData);
            this.Controls.Add(this.txtGamerTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XboxLeader API Sample";
            this.tabControl1.ResumeLayout(false);
            this.tpProfile.ResumeLayout(false);
            this.tpProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpProfile;
        private System.Windows.Forms.TabPage tpGames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGamerTag;
        private System.Windows.Forms.Button cmdGetData;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.GroupBox gbActivity;
        private System.Windows.Forms.Label lblBiography;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Label lblPresence;
        private System.Windows.Forms.Label lblRep;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGamerTag;

    }
}

