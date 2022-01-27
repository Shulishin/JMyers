namespace Space_Game
{
    partial class WinScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinScreen));
            this.lblWinText = new System.Windows.Forms.Label();
            this.lblSpaceConquest = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblCreditsName = new System.Windows.Forms.Label();
            this.lblYouWin = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWinText
            // 
            this.lblWinText.BackColor = System.Drawing.Color.Transparent;
            this.lblWinText.Font = new System.Drawing.Font("Quartz MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinText.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWinText.Location = new System.Drawing.Point(68, 345);
            this.lblWinText.Name = "lblWinText";
            this.lblWinText.Size = new System.Drawing.Size(384, 295);
            this.lblWinText.TabIndex = 0;
            this.lblWinText.Text = resources.GetString("lblWinText.Text");
            this.lblWinText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWinText.Visible = false;
            // 
            // lblSpaceConquest
            // 
            this.lblSpaceConquest.BackColor = System.Drawing.Color.Transparent;
            this.lblSpaceConquest.Font = new System.Drawing.Font("Quartz MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpaceConquest.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSpaceConquest.Location = new System.Drawing.Point(43, 332);
            this.lblSpaceConquest.Name = "lblSpaceConquest";
            this.lblSpaceConquest.Size = new System.Drawing.Size(434, 58);
            this.lblSpaceConquest.TabIndex = 3;
            this.lblSpaceConquest.Text = "Space Conquest!";
            this.lblSpaceConquest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSpaceConquest.Visible = false;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.BackColor = System.Drawing.Color.Transparent;
            this.lblCredits.Font = new System.Drawing.Font("Quartz MS", 12F);
            this.lblCredits.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCredits.Location = new System.Drawing.Point(131, 377);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(258, 513);
            this.lblCredits.TabIndex = 4;
            this.lblCredits.Text = resources.GetString("lblCredits.Text");
            this.lblCredits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCredits.Visible = false;
            // 
            // lblCreditsName
            // 
            this.lblCreditsName.BackColor = System.Drawing.Color.Transparent;
            this.lblCreditsName.Font = new System.Drawing.Font("Quartz MS", 30F);
            this.lblCreditsName.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCreditsName.Location = new System.Drawing.Point(43, 335);
            this.lblCreditsName.Name = "lblCreditsName";
            this.lblCreditsName.Size = new System.Drawing.Size(434, 58);
            this.lblCreditsName.TabIndex = 5;
            this.lblCreditsName.Text = "Credits:";
            this.lblCreditsName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCreditsName.Visible = false;
            // 
            // lblYouWin
            // 
            this.lblYouWin.AutoSize = true;
            this.lblYouWin.BackColor = System.Drawing.Color.Transparent;
            this.lblYouWin.Font = new System.Drawing.Font("Quartz MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouWin.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblYouWin.Location = new System.Drawing.Point(163, 63);
            this.lblYouWin.Name = "lblYouWin";
            this.lblYouWin.Size = new System.Drawing.Size(194, 49);
            this.lblYouWin.TabIndex = 6;
            this.lblYouWin.Text = "You Win!";
            this.lblYouWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYouWin.Visible = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Quartz MS", 18F);
            this.btnRestart.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRestart.Location = new System.Drawing.Point(53, 166);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(144, 66);
            this.btnRestart.TabIndex = 16;
            this.btnRestart.TabStop = false;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Black;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Quartz MS", 30F);
            this.btnQuit.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnQuit.Location = new System.Drawing.Point(308, 166);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(144, 66);
            this.btnQuit.TabIndex = 17;
            this.btnQuit.TabStop = false;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Visible = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // WinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Space_Game.Properties.Resources.galaxy;
            this.ClientSize = new System.Drawing.Size(520, 399);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblYouWin);
            this.Controls.Add(this.lblCreditsName);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblSpaceConquest);
            this.Controls.Add(this.lblWinText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WinScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Conquest!";
            this.Load += new System.EventHandler(this.WinScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWinText;
        private System.Windows.Forms.Label lblSpaceConquest;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblCreditsName;
        private System.Windows.Forms.Label lblYouWin;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnQuit;
    }
}