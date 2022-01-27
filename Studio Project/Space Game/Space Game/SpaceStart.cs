using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Space_Game.Properties;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;

namespace Space_Game
{
    public partial class SpaceStart : Form
    {
        int LocLblY1, LocLblY2;

        bool IntroOn1, IntroOn2, cheatS1, cheatS2, cheatS3, cheatS4;

        System.Threading.Timer timerIntroText1, timerIntroText2;

        public SpaceStart()
        {
            InitializeComponent();
        }

        private void SpaceStart_Load(object sender, EventArgs e)
        {
            cheatS1 = false;
            cheatS2 = false;
            cheatS3 = false;
            cheatS4 = false;

            Variables.CurrentForm = "SpaceStart";
            this.KeyDown += new KeyEventHandler(SpaceStart_KeyDown);
            this.KeyUp += new KeyEventHandler(SpaceStart_KeyUp);

            if (Variables.GameWasLoaded == false)
            {
                LocLblY1 = lblIntro2.Location.Y;

                LocLblY1 += 90;

                lblIntro1.Location = new Point(lblIntro1.Location.X, LocLblY1);
                lblIntro1.Visible = true;
                timerIntroText1 = new System.Threading.Timer(new TimerCallback(timerIntroText1_Tick), null, 50, 50); //sets a timer and it's call-to method
                IntroOn1 = true;

                LocLblY2 = lblIntro1.Location.Y;

                LocLblY2 += 110;

                lblIntro2.Location = new Point(lblIntro2.Location.X, LocLblY2);
                lblIntro2.Visible = true;
                timerIntroText2 = new System.Threading.Timer(new TimerCallback(timerIntroText1_Tick), null, Timeout.Infinite, Timeout.Infinite);

                picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[0]);
            }

            else
            {
                Variables.GameWasLoaded = false;

                if (Variables.Orientation == "E")
                {
                    picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[8]);
                }
                else if (Variables.Orientation == "W")
                {
                    picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[5]);
                }
                else if (Variables.Orientation == "N")
                {
                    picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[6]);
                }
                else if (Variables.Orientation == "S")
                {
                    picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[0]);
                }

                else if (Variables.Orientation == "P")
                {
                    picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[0]);
                }

                else
                {
                    picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[0]);
                }

                picboxEarth.Show();
                picboxShip.Show();
                picboxShip.Location = new Point(Variables.ShipNewX, Variables.ShipNewY);
            }
        }

        private void SpaceStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (Variables.Pause == false)
            {
                if (e.KeyCode == Keys.D2)
                {

                    if (cheatS3 == false && cheatS2 == true)
                        cheatS3 = true;
                    if (cheatS2 == false && cheatS1 == true)
                        cheatS2 = true;

                    if (cheatS1 == false)
                        cheatS1 = true;
                }

                if (e.KeyCode == Keys.D4)
                {
                    if (cheatS3 == true && cheatS1 == true && cheatS2 == true)
                    {
                        cheatS4 = true;
                    }

                    if (cheatS1 == true && cheatS2 == true && cheatS3 == true && cheatS4 == true)
                    {
                        Variables.Cheated = true;
                        Variables.CheatsEnabled = true;
                        Variables.MessageBoxOutput = "CheatsEnabled";
                        Form CustomMessageBox = new CustomMessageBox();
                        CustomMessageBox.ShowDialog();
                    }
                }

                if (e.KeyCode == Keys.L)
                {
                    if (Variables.CheatsEnabled == true)
                        Variables.Stage++;
                }

                if (e.KeyCode == Keys.Escape)
                {
                    Variables.Pause = true;

                    if (IntroOn1 == true)
                        timerIntroText1.Change(Timeout.Infinite, Timeout.Infinite);

                    if (IntroOn2 == true)
                        timerIntroText2.Change(Timeout.Infinite, Timeout.Infinite);

                    Variables.Pause = true;

                    Form Options = new Options();
                    Options.ShowDialog();

                    if (IntroOn1 == true) timerIntroText1.Change(50, 50);
                    if (IntroOn2 == true) timerIntroText2.Change(50, 50);
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                if (IntroOn1 == true || IntroOn2 == true)
                {
                    timerIntroText1.Change(Timeout.Infinite, Timeout.Infinite);
                    timerIntroText2.Change(Timeout.Infinite, Timeout.Infinite);
                    IntroOn1 = false;
                    IntroOn2 = false;

                    lblIntro2.Visible = false;
                    lblIntro1.Visible = false;
                    picboxEarth.Show();
                    picboxShip.Show();
                }
            }

            if (e.KeyCode == Keys.F1)
            {
                if (picboxShip.Visible == true)
                    MessageBox.Show("Instructions:\n \n Use WASD to move around. \n Use Space to fire.", "Instructions", MessageBoxButtons.OK);
            }

            if (e.KeyCode == Keys.D || e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.W)
            {
                if (lblIntro1.Visible == false || lblIntro2.Visible == false)
                {
                    Variables.ShipOldX = picboxShip.Location.X;
                    Variables.ShipOldY = picboxShip.Location.Y;

                    Variables.ShipNewX = picboxShip.Location.X; //remove this to enable warping through planets (lol)
                    Variables.ShipNewY = picboxShip.Location.Y; //remove this to enable warping through planets (lol)

                    if (e.KeyCode == Keys.D)
                    {
                        picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[2]);
                        Variables.ShipNewX += 3;
                        Variables.Orientation = "E";
                    }

                    else if (e.KeyCode == Keys.A)
                    {
                        picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[4]);
                        Variables.ShipNewX -= 3;
                        Variables.Orientation = "W";
                    }
                    else if (e.KeyCode == Keys.W)
                    {
                        picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[1]);
                        Variables.ShipNewY -= 3;
                        Variables.Orientation = "N";
                    }
                    else if (e.KeyCode == Keys.S)
                    {
                        picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[3]);
                        Variables.ShipNewY += 3;
                        Variables.Orientation = "S";
                    }

                    picboxShip.Location = new Point(Variables.ShipNewX, Variables.ShipNewY);

                    if (picboxShip.Bounds.IntersectsWith(picboxEarth.Bounds))
                    {
                        picboxShip.Location = new Point(Variables.ShipOldX, Variables.ShipOldY);
                    }

                    else if (picboxShip.Bounds.IntersectsWith(EdgeBottom.Bounds))
                    {
                        picboxShip.Location = new Point(Variables.ShipOldX, Variables.ShipOldY);
                    }

                    else if (picboxShip.Bounds.IntersectsWith(EdgeRight.Bounds))
                    {
                        if (Variables.SoundOn == true)
                        {
                            Variables.Music.Stop();
                            Variables.Music.Stream = Resources.technicko;
                            Variables.Music.PlayLooping();
                        }

                        Variables.Orientation = "E";
                        Form Space1 = new Space1();
                        Space1.Show();
                        this.Dispose();
                    }

                    else if (picboxShip.Bounds.IntersectsWith(EdgeTop.Bounds))
                    {
                        if (Variables.SoundOn == true)
                        {
                            Variables.Music.Stop();
                            Variables.Music.Stream = Resources.technicko;
                            Variables.Music.PlayLooping();
                        }

                        Variables.Orientation = "N";
                        Form Space1 = new Space1();
                        Space1.Show();
                        this.Dispose();
                    }

                    else if (picboxShip.Bounds.IntersectsWith(EdgeLeft.Bounds))
                    {
                        if (Variables.SoundOn == true)
                        {
                            Variables.Music.Stop();
                            Variables.Music.Stream = Resources.technicko;
                            Variables.Music.PlayLooping();
                        }

                        Variables.Orientation = "E";
                        Form Space1 = new Space1();
                        Space1.Show();
                        this.Dispose();
                    }
                }
            }
        }

        private void SpaceStart_KeyUp(object sender, KeyEventArgs e)
        {
            if (lblIntro1.Visible == false || lblIntro2.Visible == false)
            {
                //resets the image to the "stationary" one upon releasing keys
                if (e.KeyCode == Keys.D) picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[5]);
                else if (e.KeyCode == Keys.A) picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[7]);
                else if (e.KeyCode == Keys.W) picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[0]);
                else if (e.KeyCode == Keys.S) picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[6]);
            }
        }

        private void timerIntroText1_Tick(object obj) //intro timer
        {
            LocLblY1 -= 1;
            lblIntro1.Invoke((MethodInvoker)(() => lblIntro1.Location = new Point(lblIntro1.Location.X, LocLblY1)));

            if (lblIntro1.Location.Y == 50)
            {
                timerIntroText2 = new System.Threading.Timer(new TimerCallback(timerIntroText2_Tick), null, 50, 50);
                IntroOn2 = true;
            }

        }

        public void timerIntroText2_Tick(object obj) //intro timer
        {
            LocLblY2 -= 1;
            lblIntro2.Invoke((MethodInvoker)(() => lblIntro2.Location = new Point(lblIntro2.Location.X, LocLblY2)));

            if (lblIntro2.Location.Y == -10)
            {
                timerIntroText1.Dispose();
                timerIntroText2.Dispose();
                IntroOn1 = false;
                IntroOn2 = false;

                lblIntro2.Invoke((MethodInvoker)(() => lblIntro2.Hide()));
                lblIntro1.Invoke((MethodInvoker)(() => lblIntro1.Hide()));
                picboxEarth.Invoke((MethodInvoker)(() => picboxEarth.Show()));
                picboxShip.Invoke((MethodInvoker)(() => picboxShip.Show()));

            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
