using System;
namespace Space_Game
{
    partial class Planet1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planet1));
            this.picboxShip = new System.Windows.Forms.PictureBox();
            this.picboxSpecial2 = new System.Windows.Forms.PictureBox();
            this.picboxPlayer = new System.Windows.Forms.PictureBox();
            this.EdgeTop = new System.Windows.Forms.PictureBox();
            this.EdgeBottom = new System.Windows.Forms.PictureBox();
            this.EdgeRight = new System.Windows.Forms.PictureBox();
            this.EdgeLeft = new System.Windows.Forms.PictureBox();
            this.picboxEnemy4 = new System.Windows.Forms.PictureBox();
            this.picboxEnemy1 = new System.Windows.Forms.PictureBox();
            this.picboxEnemy3 = new System.Windows.Forms.PictureBox();
            this.picboxEnemy2 = new System.Windows.Forms.PictureBox();
            this.picboxBoss = new System.Windows.Forms.PictureBox();
            this.picboxImpassable1 = new System.Windows.Forms.PictureBox();
            this.picboxImpassable4 = new System.Windows.Forms.PictureBox();
            this.picboxImpassable2 = new System.Windows.Forms.PictureBox();
            this.picboxImpassable3 = new System.Windows.Forms.PictureBox();
            this.picboxSpecial1 = new System.Windows.Forms.PictureBox();
            this.timerReleaseThreads = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picboxShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSpecial2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEnemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEnemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEnemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEnemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxBoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImpassable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImpassable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImpassable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImpassable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSpecial1)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxShip
            // 
            this.picboxShip.BackColor = System.Drawing.Color.Transparent;
            this.picboxShip.Image = global::Space_Game.Properties.Resources.Human_Blue_01;
            this.picboxShip.Location = new System.Drawing.Point(222, 334);
            this.picboxShip.Name = "picboxShip";
            this.picboxShip.Size = new System.Drawing.Size(70, 53);
            this.picboxShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picboxShip.TabIndex = 0;
            this.picboxShip.TabStop = false;
            // 
            // picboxSpecial2
            // 
            this.picboxSpecial2.BackColor = System.Drawing.Color.Transparent;
            this.picboxSpecial2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxSpecial2.Location = new System.Drawing.Point(413, 51);
            this.picboxSpecial2.Name = "picboxSpecial2";
            this.picboxSpecial2.Size = new System.Drawing.Size(38, 65);
            this.picboxSpecial2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxSpecial2.TabIndex = 2;
            this.picboxSpecial2.TabStop = false;
            this.picboxSpecial2.Visible = false;
            // 
            // picboxPlayer
            // 
            this.picboxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picboxPlayer.Image = global::Space_Game.Properties.Resources.NinjaMaleDown02;
            this.picboxPlayer.Location = new System.Drawing.Point(253, 310);
            this.picboxPlayer.Name = "picboxPlayer";
            this.picboxPlayer.Size = new System.Drawing.Size(14, 18);
            this.picboxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxPlayer.TabIndex = 3;
            this.picboxPlayer.TabStop = false;
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
            // picboxEnemy4
            // 
            this.picboxEnemy4.BackColor = System.Drawing.Color.Transparent;
            this.picboxEnemy4.Image = global::Space_Game.Properties.Resources.ZombieDown02;
            this.picboxEnemy4.Location = new System.Drawing.Point(248, 126);
            this.picboxEnemy4.Name = "picboxEnemy4";
            this.picboxEnemy4.Size = new System.Drawing.Size(15, 20);
            this.picboxEnemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxEnemy4.TabIndex = 13;
            this.picboxEnemy4.TabStop = false;
            // 
            // picboxEnemy1
            // 
            this.picboxEnemy1.BackColor = System.Drawing.Color.Transparent;
            this.picboxEnemy1.Image = global::Space_Game.Properties.Resources.ZombieDown02;
            this.picboxEnemy1.Location = new System.Drawing.Point(253, 222);
            this.picboxEnemy1.Name = "picboxEnemy1";
            this.picboxEnemy1.Size = new System.Drawing.Size(15, 20);
            this.picboxEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxEnemy1.TabIndex = 14;
            this.picboxEnemy1.TabStop = false;
            // 
            // picboxEnemy3
            // 
            this.picboxEnemy3.BackColor = System.Drawing.Color.Transparent;
            this.picboxEnemy3.Image = global::Space_Game.Properties.Resources.ZombieDown02;
            this.picboxEnemy3.Location = new System.Drawing.Point(423, 195);
            this.picboxEnemy3.Name = "picboxEnemy3";
            this.picboxEnemy3.Size = new System.Drawing.Size(15, 20);
            this.picboxEnemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxEnemy3.TabIndex = 15;
            this.picboxEnemy3.TabStop = false;
            // 
            // picboxEnemy2
            // 
            this.picboxEnemy2.BackColor = System.Drawing.Color.Transparent;
            this.picboxEnemy2.Image = global::Space_Game.Properties.Resources.ZombieDown02;
            this.picboxEnemy2.Location = new System.Drawing.Point(94, 195);
            this.picboxEnemy2.Name = "picboxEnemy2";
            this.picboxEnemy2.Size = new System.Drawing.Size(15, 20);
            this.picboxEnemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxEnemy2.TabIndex = 16;
            this.picboxEnemy2.TabStop = false;
            // 
            // picboxBoss
            // 
            this.picboxBoss.BackColor = System.Drawing.Color.Transparent;
            this.picboxBoss.Image = global::Space_Game.Properties.Resources.SkeletonDown02;
            this.picboxBoss.Location = new System.Drawing.Point(248, 30);
            this.picboxBoss.Name = "picboxBoss";
            this.picboxBoss.Size = new System.Drawing.Size(24, 36);
            this.picboxBoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxBoss.TabIndex = 17;
            this.picboxBoss.TabStop = false;
            // 
            // picboxImpassable1
            // 
            this.picboxImpassable1.BackColor = System.Drawing.Color.Transparent;
            this.picboxImpassable1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxImpassable1.Location = new System.Drawing.Point(62, 21);
            this.picboxImpassable1.Name = "picboxImpassable1";
            this.picboxImpassable1.Size = new System.Drawing.Size(47, 65);
            this.picboxImpassable1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxImpassable1.TabIndex = 1;
            this.picboxImpassable1.TabStop = false;
            this.picboxImpassable1.Visible = false;
            // 
            // picboxImpassable4
            // 
            this.picboxImpassable4.BackColor = System.Drawing.Color.Transparent;
            this.picboxImpassable4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxImpassable4.Location = new System.Drawing.Point(308, 263);
            this.picboxImpassable4.Name = "picboxImpassable4";
            this.picboxImpassable4.Size = new System.Drawing.Size(61, 74);
            this.picboxImpassable4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxImpassable4.TabIndex = 18;
            this.picboxImpassable4.TabStop = false;
            this.picboxImpassable4.Visible = false;
            // 
            // picboxImpassable2
            // 
            this.picboxImpassable2.BackColor = System.Drawing.Color.Transparent;
            this.picboxImpassable2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxImpassable2.Location = new System.Drawing.Point(176, 100);
            this.picboxImpassable2.Name = "picboxImpassable2";
            this.picboxImpassable2.Size = new System.Drawing.Size(35, 62);
            this.picboxImpassable2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxImpassable2.TabIndex = 19;
            this.picboxImpassable2.TabStop = false;
            this.picboxImpassable2.Visible = false;
            // 
            // picboxImpassable3
            // 
            this.picboxImpassable3.BackColor = System.Drawing.Color.Transparent;
            this.picboxImpassable3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxImpassable3.Location = new System.Drawing.Point(308, 106);
            this.picboxImpassable3.Name = "picboxImpassable3";
            this.picboxImpassable3.Size = new System.Drawing.Size(35, 57);
            this.picboxImpassable3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxImpassable3.TabIndex = 20;
            this.picboxImpassable3.TabStop = false;
            this.picboxImpassable3.Visible = false;
            // 
            // picboxSpecial1
            // 
            this.picboxSpecial1.BackColor = System.Drawing.Color.Transparent;
            this.picboxSpecial1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxSpecial1.Location = new System.Drawing.Point(11, 176);
            this.picboxSpecial1.Name = "picboxSpecial1";
            this.picboxSpecial1.Size = new System.Drawing.Size(39, 53);
            this.picboxSpecial1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxSpecial1.TabIndex = 21;
            this.picboxSpecial1.TabStop = false;
            this.picboxSpecial1.Visible = false;
            // 
            // timerReleaseThreads
            // 
            this.timerReleaseThreads.Interval = 1000;
            this.timerReleaseThreads.Tick += new System.EventHandler(this.timerReleaseThreads_Tick);
            // 
            // Planet1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Space_Game.Properties.Resources.AlphaCenturiLevelMap;
            this.ClientSize = new System.Drawing.Size(520, 399);
            this.Controls.Add(this.picboxSpecial1);
            this.Controls.Add(this.picboxImpassable3);
            this.Controls.Add(this.picboxImpassable2);
            this.Controls.Add(this.picboxImpassable4);
            this.Controls.Add(this.picboxBoss);
            this.Controls.Add(this.picboxEnemy2);
            this.Controls.Add(this.picboxEnemy3);
            this.Controls.Add(this.picboxEnemy1);
            this.Controls.Add(this.picboxEnemy4);
            this.Controls.Add(this.EdgeTop);
            this.Controls.Add(this.EdgeBottom);
            this.Controls.Add(this.EdgeRight);
            this.Controls.Add(this.EdgeLeft);
            this.Controls.Add(this.picboxPlayer);
            this.Controls.Add(this.picboxSpecial2);
            this.Controls.Add(this.picboxImpassable1);
            this.Controls.Add(this.picboxShip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Planet1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Conquest! - Alpha Centuri";
            this.Load += new System.EventHandler(this.Planet1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSpecial2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdgeLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEnemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEnemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEnemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEnemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxBoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImpassable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImpassable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImpassable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImpassable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSpecial1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxShip;
        private System.Windows.Forms.PictureBox picboxSpecial2;
        private System.Windows.Forms.PictureBox picboxPlayer;
        private System.Windows.Forms.PictureBox EdgeTop;
        private System.Windows.Forms.PictureBox EdgeBottom;
        private System.Windows.Forms.PictureBox EdgeRight;
        private System.Windows.Forms.PictureBox EdgeLeft;
        private System.Windows.Forms.PictureBox picboxEnemy4;
        private System.Windows.Forms.PictureBox picboxEnemy1;
        private System.Windows.Forms.PictureBox picboxEnemy3;
        private System.Windows.Forms.PictureBox picboxEnemy2;
        private System.Windows.Forms.PictureBox picboxBoss;
        private System.Windows.Forms.PictureBox picboxImpassable1;
        private System.Windows.Forms.PictureBox picboxImpassable4;
        private System.Windows.Forms.PictureBox picboxImpassable2;
        private System.Windows.Forms.PictureBox picboxImpassable3;
        private System.Windows.Forms.PictureBox picboxSpecial1;
        private System.Windows.Forms.Timer timerReleaseThreads;
    }
}