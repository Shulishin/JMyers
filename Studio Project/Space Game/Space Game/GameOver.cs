using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Collections;
using Space_Game.Properties;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Windows;

namespace Space_Game
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            lblGameOver.Font = new Font(Variables.CustomFont.Families[0], lblGameOver.Font.Size);
            btnLoad.Font = new Font(Variables.CustomFont.Families[0], btnLoad.Font.Size);
            btnQuit.Font = new Font(Variables.CustomFont.Families[0], btnQuit.Font.Size);
            btnRestart.Font = new Font(Variables.CustomFont.Families[0], btnRestart.Font.Size);

            if (Variables.SoundOn == true)
            {
                Variables.Music.Stop();
                Variables.Music.Stream = Resources.Game_Over_II;
                Variables.Music.Play();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Saves\\Save1.SAV"))
            {
                string[] LoadedLines = System.IO.File.ReadAllLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Saves\\Save1.SAV");

                Variables.ShipColor = LoadedLines[1];
                Variables.Class = LoadedLines[2];
                Variables.Stage = Int32.Parse(LoadedLines[3]);
                Variables.SoundOn = bool.Parse(LoadedLines[4]);
                Variables.PlanetVisible = bool.Parse(LoadedLines[5]);
                Variables.OnPlanet = bool.Parse(LoadedLines[6]);
                Variables.Orientation = LoadedLines[7];
                Variables.PlayerNewX = Int32.Parse(LoadedLines[8]);
                Variables.PlayerNewY = Int32.Parse(LoadedLines[9]);
                Variables.ShipNewX = Int32.Parse(LoadedLines[10]);
                Variables.ShipNewY = Int32.Parse(LoadedLines[11]);
                Variables.CurrentForm = LoadedLines[12];
                Variables.GameWasLoaded = true;

                Variables.Music.Stop();
                //Variables.Music.Stream = Resources.through_space;
                //if (Variables.SoundOn == true) Variables.Music.PlayLooping();

                Type CAType = Type.GetType("Space_Game." + Variables.CurrentForm);
                Form CurrentForm = (Form)Activator.CreateInstance(CAType);
                CurrentForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No save file exists.", "No Save File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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

            foreach (Form f in Application.OpenForms)
                if (f is MainMenu) f.Show();

            this.Dispose();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
