namespace Space_Game
{
    partial class ClassDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassDescription));
            this.picboxClass = new System.Windows.Forms.PictureBox();
            this.lblClassDescription = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblClassName = new System.Windows.Forms.Label();
            this.btnRepick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClass)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxClass
            // 
            this.picboxClass.BackColor = System.Drawing.Color.Transparent;
            this.picboxClass.Image = global::Space_Game.Properties.Resources.NinjaMaleIcon;
            this.picboxClass.Location = new System.Drawing.Point(12, 12);
            this.picboxClass.Name = "picboxClass";
            this.picboxClass.Size = new System.Drawing.Size(48, 48);
            this.picboxClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxClass.TabIndex = 0;
            this.picboxClass.TabStop = false;
            // 
            // lblClassDescription
            // 
            this.lblClassDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblClassDescription.Font = new System.Drawing.Font("Quartz MS", 10F);
            this.lblClassDescription.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblClassDescription.Location = new System.Drawing.Point(12, 63);
            this.lblClassDescription.Name = "lblClassDescription";
            this.lblClassDescription.Size = new System.Drawing.Size(215, 105);
            this.lblClassDescription.TabIndex = 3;
            this.lblClassDescription.Text = "null";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Black;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Quartz MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSelect.Location = new System.Drawing.Point(233, 19);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(77, 33);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblClassName
            // 
            this.lblClassName.BackColor = System.Drawing.Color.Transparent;
            this.lblClassName.Font = new System.Drawing.Font("Quartz MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblClassName.Location = new System.Drawing.Point(77, 19);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(121, 41);
            this.lblClassName.TabIndex = 3;
            this.lblClassName.Text = "null";
            // 
            // btnRepick
            // 
            this.btnRepick.BackColor = System.Drawing.Color.Black;
            this.btnRepick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepick.Font = new System.Drawing.Font("Quartz MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepick.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRepick.Location = new System.Drawing.Point(233, 135);
            this.btnRepick.Name = "btnRepick";
            this.btnRepick.Size = new System.Drawing.Size(77, 33);
            this.btnRepick.TabIndex = 4;
            this.btnRepick.Text = "Repick";
            this.btnRepick.UseVisualStyleBackColor = false;
            this.btnRepick.Click += new System.EventHandler(this.btnRepick_Click);
            // 
            // ClassDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Space_Game.Properties.Resources.LogoBG;
            this.ClientSize = new System.Drawing.Size(322, 174);
            this.Controls.Add(this.btnRepick);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblClassDescription);
            this.Controls.Add(this.picboxClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClassDescription";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Description:";
            this.Load += new System.EventHandler(this.ClassDescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxClass;
        private System.Windows.Forms.Label lblClassDescription;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Button btnRepick;
    }
}