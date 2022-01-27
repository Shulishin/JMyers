using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Space_Game.Properties;
using System.IO;

namespace Space_Game
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            lblPause.Font = new Font(Variables.CustomFont.Families[0], lblPause.Font.Size);
            btnExit.Font = new Font(Variables.CustomFont.Families[0], btnExit.Font.Size);
            btnRestart.Font = new Font(Variables.CustomFont.Families[0], btnRestart.Font.Size);
            btnResume.Font = new Font(Variables.CustomFont.Families[0], btnResume.Font.Size);
            btnSave.Font = new Font(Variables.CustomFont.Families[0], btnSave.Font.Size);
            btnSound.Font = new Font(Variables.CustomFont.Families[0], btnSound.Font.Size);

            this.KeyDown += new KeyEventHandler(Options_KeyDown);

            if (Variables.SoundOn == false)
            {
                btnSound.Text = "Sound: Off";
            }
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            if (Variables.SoundOn == false)
            {
                Variables.SoundOn = true;
                Variables.Music.Stream = Resources.through_space;
                Variables.Music.PlayLooping();
                btnSound.Text = "Sound: On";
            }

            else if (Variables.SoundOn == true)
            {
                Variables.SoundOn = false;
                Variables.Music.Stop();
                btnSound.Text = "Sound: Off";
            }
        }

        public void Options_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Variables.Pause = false;
                this.Dispose();
            }
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            Variables.Pause = false;
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Variables.SaveVariables = "**Do not edit unless you know what you are doing.**\r\n"
                + Variables.ShipColor + "\r\n" + Variables.Class + "\r\n" + Variables.Stage + "\r\n"
                + Variables.SoundOn + "\r\n" + Variables.PlanetVisible + "\r\n" + Variables.OnPlanet
                + "\r\n" + Variables.Orientation + "\r\n" + Variables.CurrentForm + "\r\n"
                + Variables.PlayerHP + "\r\n" + Variables.PlayerDamage + "\r\n" + Variables.PlayerDodgeChance;

            Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Saves");

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Saves\\Save1.SAV");
            SaveFile.WriteLine(Variables.SaveVariables);

            SaveFile.Close();

            Variables.MessageBoxOutput = "GameSaved";
            Form CustomMessageBox = new CustomMessageBox();
            CustomMessageBox.ShowDialog();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if (Variables.SoundOn == true)
            {
                Variables.Music.Stream = Resources.Space_intro;
                Variables.Music.PlayLooping();
            }

            Variables.Stage = 1;
            Variables.Pause = false;
            Variables.OnPlanet = false;
            Variables.GameWasLoaded = false;
            Variables.ShipColor = null;
            Variables.Class = null;

            List<Form> DisposeForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                DisposeForms.Add(f);

            foreach (Form f in DisposeForms)
            {
                if (f.Name == "MainMenu")
                    f.Show();

                else f.Dispose();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Variables.Pause = false;
        }
    }
}
