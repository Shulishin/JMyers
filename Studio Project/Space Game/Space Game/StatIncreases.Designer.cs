namespace Space_Game
{
    partial class StatIncreases
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
            this.lblLvlUp = new System.Windows.Forms.Label();
            this.picboxClass = new System.Windows.Forms.PictureBox();
            this.btnDamage = new System.Windows.Forms.Button();
            this.btnDodge = new System.Windows.Forms.Button();
            this.btnHealth = new System.Windows.Forms.Button();
            this.lblDmgAmount = new System.Windows.Forms.Label();
            this.lblDodgeAmount = new System.Windows.Forms.Label();
            this.lblHealthAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClass)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLvlUp
            // 
            this.lblLvlUp.BackColor = System.Drawing.Color.Black;
            this.lblLvlUp.Font = new System.Drawing.Font("Quartz MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLvlUp.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblLvlUp.Location = new System.Drawing.Point(12, 9);
            this.lblLvlUp.Name = "lblLvlUp";
            this.lblLvlUp.Size = new System.Drawing.Size(240, 61);
            this.lblLvlUp.TabIndex = 0;
            this.lblLvlUp.Text = "You have gained a level! Select a stat from below to increase:";
            // 
            // picboxClass
            // 
            this.picboxClass.BackColor = System.Drawing.Color.Transparent;
            this.picboxClass.Image = global::Space_Game.Properties.Resources.NinjaMaleIcon;
            this.picboxClass.Location = new System.Drawing.Point(258, 12);
            this.picboxClass.Name = "picboxClass";
            this.picboxClass.Size = new System.Drawing.Size(48, 48);
            this.picboxClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxClass.TabIndex = 1;
            this.picboxClass.TabStop = false;
            // 
            // btnDamage
            // 
            this.btnDamage.BackColor = System.Drawing.Color.Black;
            this.btnDamage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDamage.Font = new System.Drawing.Font("Quartz MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDamage.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDamage.Location = new System.Drawing.Point(12, 109);
            this.btnDamage.Name = "btnDamage";
            this.btnDamage.Size = new System.Drawing.Size(84, 33);
            this.btnDamage.TabIndex = 2;
            this.btnDamage.Text = "Damage";
            this.btnDamage.UseVisualStyleBackColor = false;
            this.btnDamage.Click += new System.EventHandler(this.btnDamage_Click);
            // 
            // btnDodge
            // 
            this.btnDodge.BackColor = System.Drawing.Color.Black;
            this.btnDodge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodge.Font = new System.Drawing.Font("Quartz MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodge.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDodge.Location = new System.Drawing.Point(114, 109);
            this.btnDodge.Name = "btnDodge";
            this.btnDodge.Size = new System.Drawing.Size(84, 33);
            this.btnDodge.TabIndex = 3;
            this.btnDodge.Text = "Dodge";
            this.btnDodge.UseVisualStyleBackColor = false;
            this.btnDodge.Click += new System.EventHandler(this.btnDodge_Click);
            // 
            // btnHealth
            // 
            this.btnHealth.BackColor = System.Drawing.Color.Black;
            this.btnHealth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHealth.Font = new System.Drawing.Font("Quartz MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHealth.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnHealth.Location = new System.Drawing.Point(217, 110);
            this.btnHealth.Name = "btnHealth";
            this.btnHealth.Size = new System.Drawing.Size(84, 33);
            this.btnHealth.TabIndex = 4;
            this.btnHealth.Text = "Health";
            this.btnHealth.UseVisualStyleBackColor = false;
            this.btnHealth.Click += new System.EventHandler(this.btnHealth_Click);
            // 
            // lblDmgAmount
            // 
            this.lblDmgAmount.AutoSize = true;
            this.lblDmgAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblDmgAmount.Font = new System.Drawing.Font("Quartz MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDmgAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDmgAmount.Location = new System.Drawing.Point(29, 81);
            this.lblDmgAmount.Name = "lblDmgAmount";
            this.lblDmgAmount.Size = new System.Drawing.Size(47, 19);
            this.lblDmgAmount.TabIndex = 5;
            this.lblDmgAmount.Text = "null";
            // 
            // lblDodgeAmount
            // 
            this.lblDodgeAmount.AutoSize = true;
            this.lblDodgeAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblDodgeAmount.Font = new System.Drawing.Font("Quartz MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodgeAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDodgeAmount.Location = new System.Drawing.Point(135, 81);
            this.lblDodgeAmount.Name = "lblDodgeAmount";
            this.lblDodgeAmount.Size = new System.Drawing.Size(47, 19);
            this.lblDodgeAmount.TabIndex = 6;
            this.lblDodgeAmount.Text = "null";
            // 
            // lblHealthAmount
            // 
            this.lblHealthAmount.AutoSize = true;
            this.lblHealthAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblHealthAmount.Font = new System.Drawing.Font("Quartz MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealthAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHealthAmount.Location = new System.Drawing.Point(236, 81);
            this.lblHealthAmount.Name = "lblHealthAmount";
            this.lblHealthAmount.Size = new System.Drawing.Size(47, 19);
            this.lblHealthAmount.TabIndex = 7;
            this.lblHealthAmount.Text = "null";
            // 
            // StatIncreases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Space_Game.Properties.Resources.LogoBG;
            this.ClientSize = new System.Drawing.Size(316, 168);
            this.Controls.Add(this.lblHealthAmount);
            this.Controls.Add(this.lblDodgeAmount);
            this.Controls.Add(this.lblDmgAmount);
            this.Controls.Add(this.btnHealth);
            this.Controls.Add(this.btnDodge);
            this.Controls.Add(this.btnDamage);
            this.Controls.Add(this.picboxClass);
            this.Controls.Add(this.lblLvlUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatIncreases";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level Up!";
            this.Load += new System.EventHandler(this.StatIncreases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLvlUp;
        private System.Windows.Forms.PictureBox picboxClass;
        private System.Windows.Forms.Button btnDamage;
        private System.Windows.Forms.Button btnDodge;
        private System.Windows.Forms.Button btnHealth;
        private System.Windows.Forms.Label lblDmgAmount;
        private System.Windows.Forms.Label lblDodgeAmount;
        private System.Windows.Forms.Label lblHealthAmount;
    }
}