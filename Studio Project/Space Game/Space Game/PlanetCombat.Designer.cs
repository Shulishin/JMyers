using System.Threading;

namespace Space_Game
{
    partial class PlanetCombat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanetCombat));
            this.btnRun = new System.Windows.Forms.Button();
            this.btnFight = new System.Windows.Forms.Button();
            this.picboxPlayer = new System.Windows.Forms.PictureBox();
            this.picboxEnemy = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHPValue = new System.Windows.Forms.Label();
            this.lblDodgeValue = new System.Windows.Forms.Label();
            this.lblDmgValue = new System.Windows.Forms.Label();
            this.lblDodge = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.prgbarPlayerHP = new System.Windows.Forms.ProgressBar();
            this.lblPlayerHP = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEHPValue = new System.Windows.Forms.Label();
            this.lblEDodgeValue = new System.Windows.Forms.Label();
            this.lblEDodge = new System.Windows.Forms.Label();
            this.lblEDmgValue = new System.Windows.Forms.Label();
            this.lblEDamage = new System.Windows.Forms.Label();
            this.prgbarEnemyHP = new System.Windows.Forms.ProgressBar();
            this.lblEnemyHp = new System.Windows.Forms.Label();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSpecial = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnDodge = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTimerValue = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMoveSelected = new System.Windows.Forms.Label();
            this.lblMove = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.prgbarSpecialMeter = new System.Windows.Forms.ProgressBar();
            this.lblSpecialMeter = new System.Windows.Forms.Label();
            this.timerReleaseThreads = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEnemy)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Quartz MS", 12F);
            this.btnRun.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRun.Location = new System.Drawing.Point(428, 54);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(72, 30);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnFight
            // 
            this.btnFight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFight.Font = new System.Drawing.Font("Quartz MS", 10F);
            this.btnFight.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnFight.Location = new System.Drawing.Point(326, 15);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(72, 30);
            this.btnFight.TabIndex = 2;
            this.btnFight.Text = "Attack";
            this.btnFight.UseVisualStyleBackColor = false;
            this.btnFight.Click += new System.EventHandler(this.btnFight_Click);
            // 
            // picboxPlayer
            // 
            this.picboxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picboxPlayer.Image = global::Space_Game.Properties.Resources.NinjaMaleIcon;
            this.picboxPlayer.Location = new System.Drawing.Point(112, 238);
            this.picboxPlayer.Name = "picboxPlayer";
            this.picboxPlayer.Size = new System.Drawing.Size(48, 48);
            this.picboxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picboxPlayer.TabIndex = 3;
            this.picboxPlayer.TabStop = false;
            // 
            // picboxEnemy
            // 
            this.picboxEnemy.BackColor = System.Drawing.Color.Transparent;
            this.picboxEnemy.Image = global::Space_Game.Properties.Resources.ZombieDown02;
            this.picboxEnemy.Location = new System.Drawing.Point(365, 42);
            this.picboxEnemy.Name = "picboxEnemy";
            this.picboxEnemy.Size = new System.Drawing.Size(30, 41);
            this.picboxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxEnemy.TabIndex = 4;
            this.picboxEnemy.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHPValue);
            this.panel1.Controls.Add(this.lblDodgeValue);
            this.panel1.Controls.Add(this.lblDmgValue);
            this.panel1.Controls.Add(this.lblDodge);
            this.panel1.Controls.Add(this.lblDamage);
            this.panel1.Controls.Add(this.prgbarPlayerHP);
            this.panel1.Controls.Add(this.lblPlayerHP);
            this.panel1.Controls.Add(this.lblPlayerName);
            this.panel1.Location = new System.Drawing.Point(310, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 5;
            // 
            // lblHPValue
            // 
            this.lblHPValue.AutoSize = true;
            this.lblHPValue.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHPValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblHPValue.Location = new System.Drawing.Point(163, 38);
            this.lblHPValue.Name = "lblHPValue";
            this.lblHPValue.Size = new System.Drawing.Size(33, 14);
            this.lblHPValue.TabIndex = 8;
            this.lblHPValue.Text = "null";
            // 
            // lblDodgeValue
            // 
            this.lblDodgeValue.AutoSize = true;
            this.lblDodgeValue.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodgeValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDodgeValue.Location = new System.Drawing.Point(156, 78);
            this.lblDodgeValue.Name = "lblDodgeValue";
            this.lblDodgeValue.Size = new System.Drawing.Size(33, 14);
            this.lblDodgeValue.TabIndex = 7;
            this.lblDodgeValue.Text = "null";
            // 
            // lblDmgValue
            // 
            this.lblDmgValue.AutoSize = true;
            this.lblDmgValue.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDmgValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDmgValue.Location = new System.Drawing.Point(54, 64);
            this.lblDmgValue.Name = "lblDmgValue";
            this.lblDmgValue.Size = new System.Drawing.Size(33, 14);
            this.lblDmgValue.TabIndex = 6;
            this.lblDmgValue.Text = "null";
            // 
            // lblDodge
            // 
            this.lblDodge.AutoSize = true;
            this.lblDodge.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDodge.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDodge.Location = new System.Drawing.Point(74, 78);
            this.lblDodge.Name = "lblDodge";
            this.lblDodge.Size = new System.Drawing.Size(86, 14);
            this.lblDodge.TabIndex = 5;
            this.lblDodge.Text = "Dodge Chance:";
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamage.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDamage.Location = new System.Drawing.Point(3, 64);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(55, 14);
            this.lblDamage.TabIndex = 4;
            this.lblDamage.Text = "Damage:";
            // 
            // prgbarPlayerHP
            // 
            this.prgbarPlayerHP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prgbarPlayerHP.ForeColor = System.Drawing.Color.Green;
            this.prgbarPlayerHP.Location = new System.Drawing.Point(57, 32);
            this.prgbarPlayerHP.Name = "prgbarPlayerHP";
            this.prgbarPlayerHP.Size = new System.Drawing.Size(100, 24);
            this.prgbarPlayerHP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgbarPlayerHP.TabIndex = 3;
            this.prgbarPlayerHP.Value = 100;
            // 
            // lblPlayerHP
            // 
            this.lblPlayerHP.AutoSize = true;
            this.lblPlayerHP.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHP.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPlayerHP.Location = new System.Drawing.Point(3, 37);
            this.lblPlayerHP.Name = "lblPlayerHP";
            this.lblPlayerHP.Size = new System.Drawing.Size(50, 14);
            this.lblPlayerHP.TabIndex = 2;
            this.lblPlayerHP.Text = "Health:";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPlayerName.Location = new System.Drawing.Point(39, 10);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(33, 14);
            this.lblPlayerName.TabIndex = 1;
            this.lblPlayerName.Text = "Null";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblEHPValue);
            this.panel2.Controls.Add(this.lblEDodgeValue);
            this.panel2.Controls.Add(this.lblEDodge);
            this.panel2.Controls.Add(this.lblEDmgValue);
            this.panel2.Controls.Add(this.lblEDamage);
            this.panel2.Controls.Add(this.prgbarEnemyHP);
            this.panel2.Controls.Add(this.lblEnemyHp);
            this.panel2.Controls.Add(this.lblEnemyName);
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 6;
            // 
            // lblEHPValue
            // 
            this.lblEHPValue.AutoSize = true;
            this.lblEHPValue.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEHPValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEHPValue.Location = new System.Drawing.Point(162, 35);
            this.lblEHPValue.Name = "lblEHPValue";
            this.lblEHPValue.Size = new System.Drawing.Size(33, 14);
            this.lblEHPValue.TabIndex = 11;
            this.lblEHPValue.Text = "null";
            // 
            // lblEDodgeValue
            // 
            this.lblEDodgeValue.AutoSize = true;
            this.lblEDodgeValue.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEDodgeValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEDodgeValue.Location = new System.Drawing.Point(157, 80);
            this.lblEDodgeValue.Name = "lblEDodgeValue";
            this.lblEDodgeValue.Size = new System.Drawing.Size(33, 14);
            this.lblEDodgeValue.TabIndex = 10;
            this.lblEDodgeValue.Text = "null";
            // 
            // lblEDodge
            // 
            this.lblEDodge.AutoSize = true;
            this.lblEDodge.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEDodge.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEDodge.Location = new System.Drawing.Point(75, 80);
            this.lblEDodge.Name = "lblEDodge";
            this.lblEDodge.Size = new System.Drawing.Size(86, 14);
            this.lblEDodge.TabIndex = 9;
            this.lblEDodge.Text = "Dodge Chance:";
            // 
            // lblEDmgValue
            // 
            this.lblEDmgValue.AutoSize = true;
            this.lblEDmgValue.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEDmgValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEDmgValue.Location = new System.Drawing.Point(53, 66);
            this.lblEDmgValue.Name = "lblEDmgValue";
            this.lblEDmgValue.Size = new System.Drawing.Size(33, 14);
            this.lblEDmgValue.TabIndex = 8;
            this.lblEDmgValue.Text = "null";
            // 
            // lblEDamage
            // 
            this.lblEDamage.AutoSize = true;
            this.lblEDamage.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEDamage.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEDamage.Location = new System.Drawing.Point(2, 66);
            this.lblEDamage.Name = "lblEDamage";
            this.lblEDamage.Size = new System.Drawing.Size(55, 14);
            this.lblEDamage.TabIndex = 7;
            this.lblEDamage.Text = "Damage:";
            // 
            // prgbarEnemyHP
            // 
            this.prgbarEnemyHP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prgbarEnemyHP.ForeColor = System.Drawing.Color.Green;
            this.prgbarEnemyHP.Location = new System.Drawing.Point(56, 30);
            this.prgbarEnemyHP.Name = "prgbarEnemyHP";
            this.prgbarEnemyHP.Size = new System.Drawing.Size(100, 24);
            this.prgbarEnemyHP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgbarEnemyHP.TabIndex = 6;
            this.prgbarEnemyHP.Value = 100;
            // 
            // lblEnemyHp
            // 
            this.lblEnemyHp.AutoSize = true;
            this.lblEnemyHp.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyHp.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEnemyHp.Location = new System.Drawing.Point(2, 35);
            this.lblEnemyHp.Name = "lblEnemyHp";
            this.lblEnemyHp.Size = new System.Drawing.Size(50, 14);
            this.lblEnemyHp.TabIndex = 5;
            this.lblEnemyHp.Text = "Health:";
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.AutoSize = true;
            this.lblEnemyName.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyName.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEnemyName.Location = new System.Drawing.Point(37, 8);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(33, 14);
            this.lblEnemyName.TabIndex = 4;
            this.lblEnemyName.Text = "Null";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSpecial);
            this.panel3.Controls.Add(this.lblOutput);
            this.panel3.Controls.Add(this.btnDodge);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btnRun);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btnFight);
            this.panel3.Location = new System.Drawing.Point(-3, 304);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(523, 102);
            this.panel3.TabIndex = 7;
            // 
            // btnSpecial
            // 
            this.btnSpecial.BackColor = System.Drawing.Color.DimGray;
            this.btnSpecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecial.Font = new System.Drawing.Font("Quartz MS", 8F);
            this.btnSpecial.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSpecial.Location = new System.Drawing.Point(428, 16);
            this.btnSpecial.Name = "btnSpecial";
            this.btnSpecial.Size = new System.Drawing.Size(71, 30);
            this.btnSpecial.TabIndex = 10;
            this.btnSpecial.Text = "Backstab";
            this.btnSpecial.UseVisualStyleBackColor = false;
            this.btnSpecial.Click += new System.EventHandler(this.btnSpecial_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Quartz MS", 12F);
            this.lblOutput.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblOutput.Location = new System.Drawing.Point(16, 16);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(273, 59);
            this.lblOutput.TabIndex = 9;
            this.lblOutput.Text = "null";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDodge
            // 
            this.btnDodge.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodge.Font = new System.Drawing.Font("Quartz MS", 10F);
            this.btnDodge.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDodge.Location = new System.Drawing.Point(326, 54);
            this.btnDodge.Name = "btnDodge";
            this.btnDodge.Size = new System.Drawing.Size(72, 30);
            this.btnDodge.TabIndex = 8;
            this.btnDodge.Text = "Dodge!";
            this.btnDodge.UseVisualStyleBackColor = false;
            this.btnDodge.Click += new System.EventHandler(this.btnDodge_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 91);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(517, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(14, 91);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(2, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(521, 10);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(3, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(521, 15);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(295, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 91);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Quartz MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTimer.Location = new System.Drawing.Point(20, 1);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(108, 19);
            this.lblTimer.TabIndex = 8;
            this.lblTimer.Text = "Turn Timer:";
            // 
            // lblTimerValue
            // 
            this.lblTimerValue.AutoSize = true;
            this.lblTimerValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTimerValue.Font = new System.Drawing.Font("Quartz MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTimerValue.Location = new System.Drawing.Point(65, 18);
            this.lblTimerValue.Name = "lblTimerValue";
            this.lblTimerValue.Size = new System.Drawing.Size(19, 19);
            this.lblTimerValue.TabIndex = 9;
            this.lblTimerValue.Text = "0";
            this.lblTimerValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblMoveSelected);
            this.panel4.Controls.Add(this.lblMove);
            this.panel4.Controls.Add(this.lblTimerValue);
            this.panel4.Controls.Add(this.lblTimer);
            this.panel4.Location = new System.Drawing.Point(186, 113);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 82);
            this.panel4.TabIndex = 10;
            // 
            // lblMoveSelected
            // 
            this.lblMoveSelected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMoveSelected.Font = new System.Drawing.Font("Quartz MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveSelected.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMoveSelected.Location = new System.Drawing.Point(15, 58);
            this.lblMoveSelected.Name = "lblMoveSelected";
            this.lblMoveSelected.Size = new System.Drawing.Size(119, 23);
            this.lblMoveSelected.TabIndex = 11;
            this.lblMoveSelected.Text = "Null";
            this.lblMoveSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.BackColor = System.Drawing.Color.Transparent;
            this.lblMove.Font = new System.Drawing.Font("Quartz MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMove.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMove.Location = new System.Drawing.Point(5, 38);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(138, 19);
            this.lblMove.TabIndex = 10;
            this.lblMove.Text = "Move Selected:";
            this.lblMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.prgbarSpecialMeter);
            this.panel5.Controls.Add(this.lblSpecialMeter);
            this.panel5.Location = new System.Drawing.Point(85, 191);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 41);
            this.panel5.TabIndex = 11;
            // 
            // prgbarSpecialMeter
            // 
            this.prgbarSpecialMeter.BackColor = System.Drawing.Color.White;
            this.prgbarSpecialMeter.ForeColor = System.Drawing.Color.Green;
            this.prgbarSpecialMeter.Location = new System.Drawing.Point(2, 20);
            this.prgbarSpecialMeter.Maximum = 5;
            this.prgbarSpecialMeter.Name = "prgbarSpecialMeter";
            this.prgbarSpecialMeter.Size = new System.Drawing.Size(96, 16);
            this.prgbarSpecialMeter.TabIndex = 9;
            // 
            // lblSpecialMeter
            // 
            this.lblSpecialMeter.AutoSize = true;
            this.lblSpecialMeter.Font = new System.Drawing.Font("Quartz MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialMeter.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSpecialMeter.Location = new System.Drawing.Point(3, 3);
            this.lblSpecialMeter.Name = "lblSpecialMeter";
            this.lblSpecialMeter.Size = new System.Drawing.Size(92, 14);
            this.lblSpecialMeter.TabIndex = 9;
            this.lblSpecialMeter.Text = "Special Meter:";
            // 
            // timerReleaseThreads
            // 
            this.timerReleaseThreads.Interval = 1000;
            this.timerReleaseThreads.Tick += new System.EventHandler(this.timerReleaseThreads_Tick);
            // 
            // PlanetCombat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Space_Game.Properties.Resources.AlphaCenturiCombatMap;
            this.ClientSize = new System.Drawing.Size(520, 399);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picboxEnemy);
            this.Controls.Add(this.picboxPlayer);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "PlanetCombat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Conquest!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlanetCombat_FormClosing);
            this.Load += new System.EventHandler(this.PlanetCombat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxEnemy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.PictureBox picboxPlayer;
        private System.Windows.Forms.PictureBox picboxEnemy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar prgbarPlayerHP;
        private System.Windows.Forms.Label lblPlayerHP;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar prgbarEnemyHP;
        private System.Windows.Forms.Label lblEnemyHp;
        private System.Windows.Forms.Label lblEnemyName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDodge;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblDodgeValue;
        private System.Windows.Forms.Label lblDmgValue;
        private System.Windows.Forms.Label lblDodge;
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.Label lblEDodgeValue;
        private System.Windows.Forms.Label lblEDodge;
        private System.Windows.Forms.Label lblEDmgValue;
        private System.Windows.Forms.Label lblEDamage;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTimerValue;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblHPValue;
        private System.Windows.Forms.Label lblEHPValue;
        private System.Windows.Forms.Label lblMoveSelected;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.Button btnSpecial;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ProgressBar prgbarSpecialMeter;
        private System.Windows.Forms.Label lblSpecialMeter;
        private System.Windows.Forms.Timer timerReleaseThreads;
    }
}