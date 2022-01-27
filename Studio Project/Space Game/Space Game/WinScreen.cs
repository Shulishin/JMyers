using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Space_Game.Properties;
using System.Windows.Forms;
using System.Threading;

namespace Space_Game
{
    public partial class WinScreen : Form
    {
        int LocLblY1, LocLblY2, LocLblY3, LocLblY4;
        bool WinMsgOn1, WinMsgOn2, FirstTimerTick;

        System.Threading.Timer timerWin1, timerWin2;

        public WinScreen()
        {
            InitializeComponent();
        }

        private void WinScreen_Load(object sender, EventArgs e)
        {
            lblWinText.Font = new Font(Variables.CustomFont.Families[0], lblWinText.Font.Size);
            lblSpaceConquest.Font = new Font(Variables.CustomFont.Families[0], lblSpaceConquest.Font.Size);
            lblCreditsName.Font = new Font(Variables.CustomFont.Families[0], lblCreditsName.Font.Size);
            lblCredits.Font = new Font(Variables.CustomFont.Families[0], lblCredits.Font.Size);
            lblYouWin.Font = new Font(Variables.CustomFont.Families[0], lblYouWin.Font.Size);
            btnQuit.Font = new Font(Variables.CustomFont.Families[0], btnQuit.Font.Size);
            btnRestart.Font = new Font(Variables.CustomFont.Families[0], btnRestart.Font.Size);

            this.KeyDown += new KeyEventHandler(WinScreen_KeyDown);

            if (Variables.SoundOn == true)
            {
                Variables.Music.Stop();
                Variables.Music.Stream = Resources.Single_Ply_Prison;
                Variables.Music.Play();
            }

            if (Variables.Cheated == true)
            {
                lblWinText.Text = "CHEATER CHEATER CHEATER CHEATER \n CHEATER CHEATER CHEATER CHEATER \n CHEATER CHEATER CHEATER \n CHEATER CHEATER CHEATER \n CHEATER \n CHEATER CHEATER CHEATER CHEATER \n CHEATER CHEATER";
                lblSpaceConquest.Text = "CHEATER!!!!";
                lblCreditsName.Text = "DAMN CHEATER!!!";
                lblCredits.Text = "DAMN DIRTY CHEATER! \n DON'T CHEAT! \n IT'S NOT LIKE THE GAME \n IS HARD OR ANYTHING \n \n \n \n JUST DO IT! \n I PUT A LOT OF WORK \n INTO THIS GAME! \n\n Please?";
                lblYouWin.Text = "YOU CHEATED!";
            }

            Variables.CurrentForm = "WinScreen";

            LocLblY1 = lblWinText.Location.Y;
            LocLblY1 += 90;

            lblWinText.Location = new Point(lblWinText.Location.X, LocLblY1);
            lblWinText.Show();
            WinMsgOn1 = true;
            timerWin1 = new System.Threading.Timer(new TimerCallback(timerWin1_Tick), null, 14000, 50);

            LocLblY2 = lblSpaceConquest.Location.Y;
            LocLblY2 += 110;

            lblSpaceConquest.Location = new Point(lblSpaceConquest.Location.X, LocLblY2);
            lblSpaceConquest.Visible = true;

            LocLblY3 = lblCreditsName.Location.Y;
            LocLblY3 += 100;

            lblCreditsName.Location = new Point(lblCreditsName.Location.X, LocLblY3);
            lblCreditsName.Visible = true;

            LocLblY4 = lblCredits.Location.Y;
            LocLblY4 += 160;

            lblCredits.Location = new Point(lblCredits.Location.X, LocLblY4);
            lblCredits.Visible = true;
        }

        private void WinScreen_KeyDown(object sender, KeyEventArgs e)
        {
            lblYouWin.Show();
            btnQuit.Show();
            btnRestart.Show();
            lblWinText.Hide();
            lblCreditsName.Hide();
            lblCredits.Hide();
            timerWin1.Dispose();
            timerWin2.Dispose();

        }
        private void timerWin1_Tick(object obj)
        {
            if (WinMsgOn1 == true)
            {
                LocLblY1 -= 1;
                lblWinText.Invoke((MethodInvoker)(() => lblWinText.Location = new Point(lblWinText.Location.X, LocLblY1)));

                if (lblWinText.Location.Y == 50)
                {
                    timerWin2 = new System.Threading.Timer(new TimerCallback(timerWin2_Tick), null, 50, 50);
                    WinMsgOn2 = true;
                }
            }

            else if (WinMsgOn1 == false)
            {
                if (FirstTimerTick == true)
                {
                    FirstTimerTick = false;
                    Variables.Music.Stop();
                    Variables.Music.Stream = Resources.technogeek;
                    Variables.Music.Play();
                }

                LocLblY3 -= 1;
                lblCreditsName.Invoke((MethodInvoker)(() => lblCreditsName.Location = new Point(lblCreditsName.Location.X, LocLblY3)));
            }
        }

        private void timerWin2_Tick(object obj)
        {
            if (WinMsgOn2 == true)
            {
                LocLblY2 -= 1;
                lblSpaceConquest.Invoke((MethodInvoker)(() => lblSpaceConquest.Location = new Point(lblSpaceConquest.Location.X, LocLblY2)));

                if (lblSpaceConquest.Location.Y == -10)
                {
                    WinMsgOn1 = false;
                    WinMsgOn2 = false;
                    FirstTimerTick = true;
                }
            }

            else if (WinMsgOn2 == false)
            {
                LocLblY4 -= 1;
                lblCredits.Invoke((MethodInvoker)(() => lblCredits.Location = new Point(lblCredits.Location.X, LocLblY4)));

                if (lblCredits.Location.Y == -500)
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        lblYouWin.Show();
                        btnQuit.Show();
                        btnRestart.Show();
                        lblWinText.Hide();
                        lblCreditsName.Hide();
                        lblCredits.Hide();
                        timerWin1.Dispose();
                        timerWin2.Dispose();
                    }));

                }
            }
        }

        protected override void OnClosing(CancelEventArgs e)
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

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
