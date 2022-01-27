namespace Space_Game
{
    partial class Space1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Space1));
            this.picboxShip = new System.Windows.Forms.PictureBox();
            this.EdgeTop = new System.Windows.Forms.PictureBox();
            this.EdgeBottom = new System.Windows.Forms.PictureBox();
            this.EdgeRight = new System.Windows.Forms.PictureBox();
            this.EdgeLeft = new System.Windows.Forms.PictureBox();
            this.picboxPlanet1 = new System.Windows.Forms.PictureBox();
            this.picboxAsteroid1 = new System.Windows.Forms.PictureBox();
            this.picboxAsteroid2 = new System.Windows.Forms.PictureBox();
            this.picboxAsteroid3 = new System.Windows.Forms.PictureBox();
            this.picboxAsteroid4 = new System.Windows.Forms.PictureBox();
            this.timerReleaseThreads = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picboxShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlanet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAsteroid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAsteroid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAsteroid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAsteroid4)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxShip
            // 
            this.picboxShip.BackColor = System.Drawing.Color.Transparent;
            this.picboxShip.Image = global::Space_Game.Properties.Resources.Human_Blue_01;
            this.picboxShip.Location = new System.Drawing.Point(237, 353);
            this.picboxShip.Name = "picboxShip";
            this.picboxShip.Size = new System.Drawing.Size(35, 35);
            this.picboxShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxShip.TabIndex = 5;
            this.picboxShip.TabStop = false;
            // 
            // EdgeTop
            // 
            this.EdgeTop.BackColor = System.Drawing.Color.Red;
            this.EdgeTop.Location = new System.Drawing.Point(-1, -5);
            this.EdgeTop.Name = "EdgeTop";
            this.EdgeTop.Size = new System.Drawing.Size(522, 10);
            this.EdgeTop.TabIndex = 12;
            this.EdgeTop.TabStop = false;
            this.EdgeTop.Visible = false;
            // 
            // EdgeBottom
            // 
            this.EdgeBottom.BackColor = System.Drawing.Color.Red;
            this.EdgeBottom.Location = new System.Drawing.Point(-1, 394);
            this.EdgeBottom.Name = "EdgeBottom";
            this.EdgeBottom.Size = new System.Drawing.Size(522, 10);
            this.EdgeBottom.TabIndex = 11;
            this.EdgeBottom.TabStop = false;
            this.EdgeBottom.Visible = false;
            // 
            // EdgeRight
            // 
            this.EdgeRight.BackColor = System.Drawing.Color.Red;
            this.EdgeRight.Location = new System.Drawing.Point(516, 0);
            this.EdgeRight.Name = "EdgeRight";
            this.EdgeRight.Size = new System.Drawing.Size(10, 401);
            this.EdgeRight.TabIndex = 10;
            this.EdgeRight.TabStop = false;
            this.EdgeRight.Visible = false;
            // 
            // EdgeLeft
            // 
            this.EdgeLeft.BackColor = System.Drawing.Color.Red;
            this.EdgeLeft.Location = new System.Drawing.Point(-5, 0);
            this.EdgeLeft.Name = "EdgeLeft";
            this.EdgeLeft.Size = new System.Drawing.Size(10, 401);
            this.EdgeLeft.TabIndex = 9;
            this.EdgeLeft.TabStop = false;
            this.EdgeLeft.Visible = false;
            // 
            // picboxPlanet1
            // 
            this.picboxPlanet1.BackColor = System.Drawing.Color.Transparent;
            this.picboxPlanet1.Image = ((System.Drawing.Image)(resources.GetObject("picboxPlanet1.Image")));
            this.picboxPlanet1.Location = new System.Drawing.Point(218, 167);
            this.picboxPlanet1.Name = "picboxPlanet1";
            this.picboxPlanet1.Size = new System.Drawing.Size(70, 70);
            this.picboxPlanet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPlanet1.TabIndex = 13;
            this.picboxPlanet1.TabStop = false;
            this.picboxPlanet1.Visible = false;
            // 
            // picboxAsteroid1
            // 
            this.picboxAsteroid1.BackColor = System.Drawing.Color.Transparent;
            this.picboxAsteroid1.Image = global::Space_Game.Properties.Resources.Astroid_01;
            this.picboxAsteroid1.Location = new System.Drawing.Point(115, 214);
            this.picboxAsteroid1.Name = "picboxAsteroid1";
            this.picboxAsteroid1.Size = new System.Drawing.Size(48, 47);
            this.picboxAsteroid1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxAsteroid1.TabIndex = 14;
            this.picboxAsteroid1.TabStop = false;
            this.picboxAsteroid1.Visible = false;
            // 
            // picboxAsteroid2
            // 
            this.picboxAsteroid2.BackColor = System.Drawing.Color.Transparent;
            this.picboxAsteroid2.Image = global::Space_Game.Properties.Resources.Astroid_01;
            this.picboxAsteroid2.Location = new System.Drawing.Point(355, 286);
            this.picboxAsteroid2.Name = "picboxAsteroid2";
            this.picboxAsteroid2.Size = new System.Drawing.Size(48, 47);
            this.picboxAsteroid2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxAsteroid2.TabIndex = 15;
            this.picboxAsteroid2.TabStop = false;
            this.picboxAsteroid2.Visible = false;
            // 
            // picboxAsteroid3
            // 
            this.picboxAsteroid3.BackColor = System.Drawing.Color.Transparent;
            this.picboxAsteroid3.Image = global::Space_Game.Properties.Resources.Astroid_01;
            this.picboxAsteroid3.Location = new System.Drawing.Point(268, 58);
            this.picboxAsteroid3.Name = "picboxAsteroid3";
            this.picboxAsteroid3.Size = new System.Drawing.Size(48, 47);
            this.picboxAsteroid3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxAsteroid3.TabIndex = 16;
            this.picboxAsteroid3.TabStop = false;
            this.picboxAsteroid3.Visible = false;
            // 
            // picboxAsteroid4
            // 
            this.picboxAsteroid4.BackColor = System.Drawing.Color.Transparent;
            this.picboxAsteroid4.Image = global::Space_Game.Properties.Resources.Astroid_01;
            this.picboxAsteroid4.Location = new System.Drawing.Point(386, 138);
            this.picboxAsteroid4.Name = "picboxAsteroid4";
            this.picboxAsteroid4.Size = new System.Drawing.Size(48, 47);
            this.picboxAsteroid4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxAsteroid4.TabIndex = 17;
            this.picboxAsteroid4.TabStop = false;
            this.picboxAsteroid4.Visible = false;
            // 
            // timerReleaseThreads
            // 
            this.timerReleaseThreads.Interval = 1000;
            // 
            // Space1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Space_Game.Properties.Resources.galaxy_1;
            this.ClientSize = new System.Drawing.Size(520, 399);
            this.Controls.Add(this.picboxAsteroid4);
            this.Controls.Add(this.picboxAsteroid3);
            this.Controls.Add(this.picboxAsteroid2);
            this.Controls.Add(this.picboxAsteroid1);
            this.Controls.Add(this.picboxPlanet1);
            this.Controls.Add(this.EdgeTop);
            this.Controls.Add(this.EdgeBottom);
            this.Controls.Add(this.EdgeRight);
            this.Controls.Add(this.EdgeLeft);
            this.Controls.Add(this.picboxShip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Space1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Conquest!";
            this.Load += new System.EventHandler(this.Space1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlanet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAsteroid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAsteroid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAsteroid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxAsteroid4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxShip;
        private System.Windows.Forms.PictureBox EdgeTop;
        private System.Windows.Forms.PictureBox EdgeBottom;
        private System.Windows.Forms.PictureBox EdgeRight;
        private System.Windows.Forms.PictureBox EdgeLeft;
        private System.Windows.Forms.PictureBox picboxPlanet1;
        private System.Windows.Forms.PictureBox picboxAsteroid1;
        private System.Windows.Forms.PictureBox picboxAsteroid2;
        private System.Windows.Forms.PictureBox picboxAsteroid3;
        private System.Windows.Forms.PictureBox picboxAsteroid4;
        private System.Windows.Forms.Timer timerReleaseThreads;
    }
}