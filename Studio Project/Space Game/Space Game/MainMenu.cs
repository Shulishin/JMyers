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
using System.Drawing.Text;

namespace Space_Game
{
    public partial class MainMenu : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]

        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
           IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        public MainMenu()
        {
            InitializeComponent();

            //setting up custom font
            try
            {
                unsafe
                {
                    fixed (byte* pFontData = Properties.Resources.QuartzMS)
                    {
                        uint dummy = 0;
                        Variables.CustomFont.AddMemoryFont((IntPtr)pFontData, Properties.Resources.QuartzMS.Length);
                        AddFontMemResourceEx((IntPtr)pFontData, (uint)Properties.Resources.QuartzMS.Length, IntPtr.Zero, ref dummy);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Font does not correctly appear");

            }
        }

        public void MainMenu_Load(object sender, EventArgs e)
        {
            //making sure buttons and labels all display correct font
            btnPlay.Font = new Font(Variables.CustomFont.Families[0], btnPlay.Font.Size);
            btnLoad.Font = new Font(Variables.CustomFont.Families[0], btnLoad.Font.Size);
            btnQuit.Font = new Font(Variables.CustomFont.Families[0], btnQuit.Font.Size);
            btnSound.Font = new Font(Variables.CustomFont.Families[0], btnSound.Font.Size);
            lblFemale.Font = new Font(Variables.CustomFont.Families[0], lblFemale.Font.Size);
            lblMale.Font = new Font(Variables.CustomFont.Families[0], lblMale.Font.Size);
            lblNinja.Font = new Font(Variables.CustomFont.Families[0], lblNinja.Font.Size);
            lblWarrior.Font = new Font(Variables.CustomFont.Families[0], lblWarrior.Font.Size);
            lblRanger.Font = new Font(Variables.CustomFont.Families[0], lblRanger.Font.Size);
            lblMagician.Font = new Font(Variables.CustomFont.Families[0], lblMagician.Font.Size);
            lblSelections.Font = new Font(Variables.CustomFont.Families[0], lblSelections.Font.Size);

            //setting up music
            Variables.Music.Stream = Resources.Space_intro;
            Variables.Music.PlayLooping();
            Variables.SoundOn = true;

            //key event handler for pressing a button
            this.KeyDown += new KeyEventHandler(MainMenu_KeyDown);
        }

        public void picboxBlue_Click(object sender, EventArgs e)
        {
            Variables.ShipColor = "Blue"; //changes color to blue, then activates next method to use
            ChangeToCharacterSelect();
        }

        public void picboxGreen_Click(object sender, EventArgs e)
        {
            Variables.ShipColor = "Green";
            ChangeToCharacterSelect();
        }

        public void picboxRed_Click(object sender, EventArgs e)
        {
            Variables.ShipColor = "Red";
            ChangeToCharacterSelect();
        }

        public void picboxYellow_Click(object sender, EventArgs e)
        {
            Variables.ShipColor = "Yellow";
            ChangeToCharacterSelect();
        }

        private void ChangeToCharacterSelect()
        {
            picboxShipYellow.Hide();
            picboxShipRed.Hide();
            picboxShipBlue.Hide();
            picboxShipGreen.Hide();
            lblSelections.Text = "Select a character:";
            picboxNinjaMale.Show();
            picboxNinjaFemale.Show();
            picboxMagicianFemale.Show();
            picboxMagicianMale.Show();
            picboxWarriorFemale.Show();
            picboxWarriorMale.Show();
            picboxHealerFemale.Show();
            picboxHealerMale.Show();
            picboxRangerMale.Show();
            picboxRangerFemale.Show();
            lblFemale.Show();
            lblMale.Show();
            lblMagician.Show();
            lblNinja.Show();
            lblWarrior.Show();
            lblRanger.Show();
            lblHealer.Show();

        }

        public void picboxSelectNinjaMale_Click(object sender, EventArgs e)
        {
            Variables.Class = "Ninja";
            Variables.Gender = "Male";
            Variables.Special = "Backstab";
            Variables.PlayerDamage = 7;
            Variables.PlayerDodgeChance = 40;
            Variables.PlayerHP = 50;

            Form ClassDescription = new ClassDescription();
            ClassDescription.ShowDialog(); //show dialog to keep the origianl window active but unusable

            if (Variables.ClassChosen == true)
            {
                ChangeToSpaceForm();
            }
        }

        private void picboxNinjaFemale_Click(object sender, EventArgs e)
        {
            Variables.Class = "Ninja";
            Variables.Gender = "Female";
            Variables.Special = "Backstab";
            Variables.PlayerDamage = 7;
            Variables.PlayerDodgeChance = 40;
            Variables.PlayerHP = 50;

            Form ClassDescription = new ClassDescription();
            ClassDescription.ShowDialog();

            if (Variables.ClassChosen == true)
            {
                ChangeToSpaceForm();
            }
        }

        private void picboxWarriorMale_Click(object sender, EventArgs e)
        {
            Variables.Class = "Warrior";
            Variables.Gender = "Male";
            Variables.Special = "Reflect";
            Variables.PlayerDamage = 5;
            Variables.PlayerDodgeChance = 25;
            Variables.PlayerHP = 150;

            Form ClassDescription = new ClassDescription();
            ClassDescription.ShowDialog();

            if (Variables.ClassChosen == true)
            {
                ChangeToSpaceForm();
            }
        }

        private void picboxWarriorFemale_Click(object sender, EventArgs e)
        {
            Variables.Class = "Warrior";
            Variables.Gender = "Female";
            Variables.Special = "Reflect";
            Variables.PlayerDamage = 5;
            Variables.PlayerDodgeChance = 25;
            Variables.PlayerHP = 150;

            Form ClassDescription = new ClassDescription();
            ClassDescription.ShowDialog();

            if (Variables.ClassChosen == true)
            {
                ChangeToSpaceForm();
            }
        }

        private void picboxHealerMale_Click(object sender, EventArgs e)
        {
            Variables.Class = "Healer";
            Variables.Gender = "Male";
            Variables.Special = "Healzone";
            Variables.PlayerDamage = 3;
            Variables.PlayerDodgeChance = 15;
            Variables.PlayerHP = 100;

            Form ClassDescription = new ClassDescription();
            ClassDescription.ShowDialog();

            if (Variables.ClassChosen == true)
            {
                ChangeToSpaceForm();
            }
        }

        private void picboxHealerFemale_Click(object sender, EventArgs e)
        {
            Variables.Class = "Healer";
            Variables.Gender = "Female";
            Variables.Special = "Healzone";
            Variables.PlayerDamage = 3;
            Variables.PlayerDodgeChance = 15;
            Variables.PlayerHP = 100;

            Form ClassDescription = new ClassDescription();
            ClassDescription.ShowDialog();

            if (Variables.ClassChosen == true)
            {
                ChangeToSpaceForm();
            }
        }

        private void picboxMagicianMale_Click(object sender, EventArgs e)
        {
            Variables.Class = "Magician";
            Variables.Gender = "Male";
            Variables.Special = "Amplify";
            Variables.PlayerDamage = 9;
            Variables.PlayerDodgeChance = 5;
            Variables.PlayerHP = 50;

            Form ClassDescription = new ClassDescription();
            ClassDescription.ShowDialog();

            if (Variables.ClassChosen == true)
            {
                ChangeToSpaceForm();
            }
        }

        private void picboxMagicianFemale_Click(object sender, EventArgs e)
        {
            Variables.Class = "Magician";
            Variables.Gender = "Female";
            Variables.Special = "Amplify";
            Variables.PlayerDamage = 9;
            Variables.PlayerDodgeChance = 5;
            Variables.PlayerHP = 50;

            Form ClassDescription = new ClassDescription();
            ClassDescription.ShowDialog();

            if (Variables.ClassChosen == true)
            {
                ChangeToSpaceForm();
            }
        }

        private void picboxRangerMale_Click(object sender, EventArgs e)
        {
            Variables.Class = "Ranger";
            Variables.Gender = "Male";
            Variables.Special = "Volley";
            Variables.PlayerDamage = 7;
            Variables.PlayerDodgeChance = 30;
            Variables.PlayerHP = 30;

            Form ClassDescription = new ClassDescription();
            ClassDescription.ShowDialog();

            if (Variables.ClassChosen == true)
            {
                ChangeToSpaceForm();
            }
        }

        private void picboxRangerFemale_Click(object sender, EventArgs e)
        {
            Variables.Class = "Ranger";
            Variables.Gender = "Female";
            Variables.Special = "Volley";
            Variables.PlayerDamage = 7;
            Variables.PlayerDodgeChance = 30;
            Variables.PlayerHP = 75;

            Form ClassDescription = new ClassDescription();
            ClassDescription.ShowDialog();

            if (Variables.ClassChosen == true)
            {
                ChangeToSpaceForm();
            }
        }

        public void ChangeToSpaceForm()
        {
            lblSelections.Hide();
            picboxNinjaMale.Hide();
            picboxNinjaFemale.Hide();
            picboxMagicianFemale.Hide();
            picboxMagicianMale.Hide();
            picboxWarriorFemale.Hide();
            picboxWarriorMale.Hide();
            picboxHealerFemale.Hide();
            picboxHealerMale.Hide();
            picboxRangerFemale.Hide();
            picboxRangerMale.Hide();
            lblMale.Hide();
            lblFemale.Hide();
            lblMagician.Hide();
            lblNinja.Hide();
            lblWarrior.Hide();
            lblRanger.Hide();
            lblHealer.Hide();

            btnPlay.Show();
            btnQuit.Show();
            btnLoad.Show();
            btnSound.Show();

            SetResourceNames();
            Variables.Music.Stop();
            Variables.Music.Stream = Resources.Dark_Intro_0;
            if (Variables.SoundOn == true) Variables.Music.PlayLooping();
            SpaceStart Space = new SpaceStart();
            Space.Show();
            this.Hide();
        }

        public void SetResourceNames()
        {
            //declaring resource names for use
            Variables.ResourceNameShip[0] = "Human_" + Variables.ShipColor + "_01";
            Variables.ResourceNameShip[1] = "Human_" + Variables.ShipColor + "_02";
            Variables.ResourceNameShip[2] = "Human_" + Variables.ShipColor + "_03";
            Variables.ResourceNameShip[3] = "Human_" + Variables.ShipColor + "_04";
            Variables.ResourceNameShip[4] = "Human_" + Variables.ShipColor + "_05";
            Variables.ResourceNameShip[5] = "Human_" + Variables.ShipColor + "_06";
            Variables.ResourceNameShip[6] = "Human_" + Variables.ShipColor + "_07";
            Variables.ResourceNameShip[7] = "Human_" + Variables.ShipColor + "_08";

            Variables.ResourceNameCharacter[0] = Variables.Class + Variables.Gender + "Down01";
            Variables.ResourceNameCharacter[1] = Variables.Class + Variables.Gender + "Down02";
            Variables.ResourceNameCharacter[2] = Variables.Class + Variables.Gender + "Down03";
            Variables.ResourceNameCharacter[3] = Variables.Class + Variables.Gender + "Up01";
            Variables.ResourceNameCharacter[4] = Variables.Class + Variables.Gender + "Up02";
            Variables.ResourceNameCharacter[5] = Variables.Class + Variables.Gender + "Up03";
            Variables.ResourceNameCharacter[6] = Variables.Class + Variables.Gender + "Left01";
            Variables.ResourceNameCharacter[7] = Variables.Class + Variables.Gender + "Left02";
            Variables.ResourceNameCharacter[8] = Variables.Class + Variables.Gender + "Left03";
            Variables.ResourceNameCharacter[9] = Variables.Class + Variables.Gender + "Right01";
            Variables.ResourceNameCharacter[10] = Variables.Class + Variables.Gender + "Right02";
            Variables.ResourceNameCharacter[11] = Variables.Class + Variables.Gender + "Right03";
            Variables.ResourceNameCharacter[12] = Variables.Class + Variables.Gender + "Icon";

            Variables.Explosion[0] = Resources.Explosion1;
            Variables.Explosion[1] = Resources.Explosion2;
            Variables.Explosion[2] = Resources.Explosion3;
            Variables.Explosion[3] = Resources.Explosion4;
            Variables.Explosion[4] = Resources.Explosion5;
            Variables.Explosion[5] = Resources.Explosion6;
            Variables.Explosion[6] = Resources.Explosion7;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Hide();
            btnQuit.Hide();
            btnSound.Hide();
            btnLoad.Hide();
            lblSelections.Show();
            picboxShipBlue.Show();
            picboxShipGreen.Show();
            picboxShipRed.Show();
            picboxShipYellow.Show();
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            if (Variables.SoundOn == true)
            {
                Variables.SoundOn = false;
                Variables.Music.Stop();
                btnSound.Text = "Sound: Off";
            }

            else
            {
                Variables.SoundOn = true;
                btnSound.Text = "Sound: On";
                Variables.Music.PlayLooping();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //code to load a file 'save'
            if (File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Saves\\Save1.SAV")) //checks if a save fle iexists
            {
                string[] LoadedLines = System.IO.File.ReadAllLines(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Saves\\Save1.SAV"); //loads all lines in save file to be added into string array

                Variables.ShipColor = LoadedLines[1];
                Variables.Class = LoadedLines[2];
                Variables.Stage = Int32.Parse(LoadedLines[3]);
                Variables.SoundOn = bool.Parse(LoadedLines[4]);
                Variables.PlanetVisible = bool.Parse(LoadedLines[5]);
                Variables.OnPlanet = bool.Parse(LoadedLines[6]);
                Variables.Orientation = LoadedLines[7];
                Variables.CurrentForm = LoadedLines[8];
                Variables.PlayerHP = Int32.Parse(LoadedLines[9]);
                Variables.PlayerDamage = Int32.Parse(LoadedLines[10]);
                Variables.PlayerDodgeChance = Int32.Parse(LoadedLines[11]);
                Variables.GameWasLoaded = true;

                SetResourceNames();

                if (Variables.SoundOn == true)
                {
                    Variables.Music.PlayLooping();
                    btnSound.Text = "Sound:On";
                }

                else
                    btnSound.Text = "Sound: Off";

                Type CAType = Type.GetType("Space_Game." + Variables.CurrentForm); //saves form name to a usable format
                Form CurrentForm = (Form)Activator.CreateInstance(CAType);
                CurrentForm.Show();
                this.Hide();
            }
            else
            {
                Variables.MessageBoxOutput = "NoSaveFile";
                Form CustomMessageBox = new CustomMessageBox();
                CustomMessageBox.ShowDialog();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Environment.Exit(0);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Variables.Cheated = true;
            Form WinTest = new WinScreen();
            WinTest.Show();
            this.Hide();
        }
    }
}




