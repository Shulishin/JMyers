namespace Space_Game
{
    partial class SpaceStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceStart));
            this.lblIntro1 = new System.Windows.Forms.Label();
            this.lblIntro2 = new System.Windows.Forms.Label();
            this.picboxEarth = new System.Windows.Forms.PictureBox();
            this.picboxShip = new System.Windows.Forms.PictureBox();
            this.EdgeLeft = new System.Windows.Forms.PictureBox();
            this.EdgeRight = new System.Windows.Forms.PictureBox();
            this.EdgeBottom = new System.Windows.Forms.PictureBox();
            this.EdgeTop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEarth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeTop)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIntro1
            // 
            this.lblIntro1.AutoSize = true;
            this.lblIntro1.BackColor = System.Drawing.Color.Transparent;
            this.lblIntro1.Font = new System.Drawing.Font("Quartz MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblIntro1.Location = new System.Drawing.Point(59, 366);
            this.lblIntro1.Name = "lblIntro1";
            this.lblIntro1.Size = new System.Drawing.Size(402, 342);
            this.lblIntro1.TabIndex = 1;
            this.lblIntro1.Text = resources.GetString("lblIntro1.Text");
            this.lblIntro1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIntro1.Visible = false;
            // 
            // lblIntro2
            // 
            this.lblIntro2.AutoSize = true;
            this.lblIntro2.BackColor = System.Drawing.Color.Transparent;
            this.lblIntro2.Font = new System.Drawing.Font("Quartz MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro2.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblIntro2.Location = new System.Drawing.Point(43, 333);
            this.lblIntro2.Name = "lblIntro2";
            this.lblIntro2.Size = new System.Drawing.Size(434, 58);
            this.lblIntro2.TabIndex = 2;
            this.lblIntro2.Text = "Space Conquest!";
            this.lblIntro2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIntro2.Visible = false;
            // 
            // picboxEarth
            // 
            this.picboxEarth.BackColor = System.Drawing.Color.Transparent;
            this.picboxEarth.Image = ((System.Drawing.Image)(resources.GetObject("picboxEarth.Image")));
            this.picboxEarth.Location = new System.Drawing.Point(226, 317);
            this.picboxEarth.Name = "picboxEarth";
            this.picboxEarth.Size = new System.Drawing.Size(70, 70);
            this.picboxEarth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxEarth.TabIndex = 3;
            this.picboxEarth.TabStop = false;
            this.picboxEarth.Visible = false;
            // 
            // picboxShip
            // 
            this.picboxShip.BackColor = System.Drawing.Color.Transparent;
            this.picboxShip.Location = new System.Drawing.Point(244, 276);
            this.picboxShip.Name = "picboxShip";
            this.picboxShip.Size = new System.Drawing.Size(35, 35);
            this.picboxShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxShip.TabIndex = 4;
            this.picboxShip.TabStop = false;
            this.picboxShip.Visible = false;
            // 
            // EdgeLeft
            // 
            this.EdgeLeft.BackColor = System.Drawing.Color.Red;
            this.EdgeLeft.Location = new System.Drawing.Point(-5, 0);
            this.EdgeLeft.Name = "EdgeLeft";
            this.EdgeLeft.Size = new System.Drawing.Size(10, 401);
            this.EdgeLeft.TabIndex = 5;
            this.EdgeLeft.TabStop = false;
            this.EdgeLeft.Visible = false;
            // 
            // EdgeRight
            // 
            this.EdgeRight.BackColor = System.Drawing.Color.Red;
            this.EdgeRight.Location = new System.Drawing.Point(516, 0);
            this.EdgeRight.Name = "EdgeRight";
            this.EdgeRight.Size = new System.Drawing.Size(10, 401);
            this.EdgeRight.TabIndex = 6;
            this.EdgeRight.TabStop = false;
            this.EdgeRight.Visible = false;
            // 
            // EdgeBottom
            // 
            this.EdgeBottom.BackColor = System.Drawing.Color.Red;
            this.EdgeBottom.Location = new System.Drawing.Point(-1, 394);
            this.EdgeBottom.Name = "EdgeBottom";
            this.EdgeBottom.Size = new System.Drawing.Size(522, 10);
            this.EdgeBottom.TabIndex = 7;
            this.EdgeBottom.TabStop = false;
            this.EdgeBottom.Visible = false;
            // 
            // EdgeTop
            // 
            this.EdgeTop.BackColor = System.Drawing.Color.Red;
            this.EdgeTop.Location = new System.Drawing.Point(-1, -5);
            this.EdgeTop.Name = "EdgeTop";
            this.EdgeTop.Size = new System.Drawing.Size(522, 10);
            this.EdgeTop.TabIndex = 8;
            this.EdgeTop.TabStop = false;
            this.EdgeTop.Visible = false;
            // 
            // SpaceStart
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Space_Game.Properties.Resources.galaxy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(520, 399);
            this.Controls.Add(this.EdgeTop);
            this.Controls.Add(this.EdgeBottom);
            this.Controls.Add(this.EdgeRight);
            this.Controls.Add(this.EdgeLeft);
            this.Controls.Add(this.picboxShip);
            this.Controls.Add(this.picboxEarth);
            this.Controls.Add(this.lblIntro2);
            this.Controls.Add(this.lblIntro1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "SpaceStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Conquest!";
            this.Load += new System.EventHandler(this.SpaceStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxEarth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntro1;
        private System.Windows.Forms.Label lblIntro2;
        private System.Windows.Forms.PictureBox picboxEarth;
        private System.Windows.Forms.PictureBox picboxShip;
        private System.Windows.Forms.PictureBox EdgeLeft;
        private System.Windows.Forms.PictureBox EdgeRight;
        private System.Windows.Forms.PictureBox EdgeBottom;
        private System.Windows.Forms.PictureBox EdgeTop;
    }
}
