namespace Space_Game
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPause = new System.Windows.Forms.Label();
            this.btnSound = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Quartz MS", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSave.Location = new System.Drawing.Point(25, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 42);
            this.btnSave.TabIndex = 0;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.Black;
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResume.Font = new System.Drawing.Font("Quartz MS", 10F);
            this.btnResume.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnResume.Location = new System.Drawing.Point(85, 70);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(75, 42);
            this.btnResume.TabIndex = 1;
            this.btnResume.TabStop = false;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Quartz MS", 10F);
            this.btnExit.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnExit.Location = new System.Drawing.Point(144, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.BackColor = System.Drawing.Color.Transparent;
            this.lblPause.Font = new System.Drawing.Font("Quartz MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPause.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPause.Location = new System.Drawing.Point(65, 9);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(115, 33);
            this.lblPause.TabIndex = 3;
            this.lblPause.Text = "Paused";
            // 
            // btnSound
            // 
            this.btnSound.BackColor = System.Drawing.Color.Black;
            this.btnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSound.Font = new System.Drawing.Font("Quartz MS", 9F);
            this.btnSound.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSound.Location = new System.Drawing.Point(144, 135);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(75, 42);
            this.btnSound.TabIndex = 4;
            this.btnSound.TabStop = false;
            this.btnSound.Text = "Sound: On";
            this.btnSound.UseVisualStyleBackColor = false;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Quartz MS", 9F);
            this.btnRestart.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRestart.Location = new System.Drawing.Point(25, 205);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 42);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.TabStop = false;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Space_Game.Properties.Resources.LogoBG;
            this.ClientSize = new System.Drawing.Size(245, 270);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Button btnRestart;
    }
}