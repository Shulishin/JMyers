using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Space_Game.Properties;
using System.Threading;
using System.Timers;


namespace Space_Game
{
    public partial class Space1 : Form
    {
        int Anim, enemyRndInt,
           asteroid1LocY, asteroid1LocX, oldasteroid1LocX, oldasteroid1LocY, asteroid1TickCounter,
           asteroid2LocY, asteroid2LocX, oldasteroid2LocX, oldasteroid2LocY, asteroid2TickCounter,
           asteroid3LocY, asteroid3LocX, oldasteroid3LocX, oldasteroid3LocY, asteroid3TickCounter,
           asteroid4LocY, asteroid4LocX, oldasteroid4LocX, oldasteroid4LocY, asteroid4TickCounter;

        System.Threading.Timer timerDeath, timerAsteroid1Move, timerAsteroid2Move, timerAsteroid3Move, timerAsteroid4Move;

        string asteroid1Direction, asteroid2Direction, asteroid3Direction, asteroid4Direction;

        Random rnd = new Random();

        public Space1()
        {
            InitializeComponent();
        }

        private void Space1_Load(object sender, EventArgs e)
        {
            Anim = 0;

            Variables.CurrentForm = "Space1";
            this.KeyDown += new KeyEventHandler(Space1_KeyDown);
            this.KeyUp += new KeyEventHandler(Space1_KeyUp);

            if (Variables.GameWasLoaded == false)
            {
                if (Variables.OnPlanet == true)
                {
                    Variables.OnPlanet = false;
                    picboxShip.Location = new Point(Variables.ShipOldX, Variables.ShipOldY);
                    picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[0]);
                    picboxPlanet1.Show();
                    picboxPlanet1.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.PlanetImage);
                }

                else
                {

                    if (Variables.Orientation == "E")
                    {
                        picboxShip.Location = new Point(08, Variables.ShipOldY);
                        picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[0]);
                    }
                    else if (Variables.Orientation == "W")
                    {
                        picboxShip.Location = new Point(478, Variables.ShipOldY);
                        picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[0]);
                    }
                    else if (Variables.Orientation == "N")
                    {
                        picboxShip.Location = new Point(Variables.ShipOldX, 356);
                        picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[0]);
                    }
                    else if (Variables.Orientation == "S")
                    {
                        picboxShip.Location = new Point(Variables.ShipOldX, 08);
                    }

                    if (Variables.Stage == 1)
                    {

                        Random rnd = new Random();
                        int Chance = rnd.Next(1, 3);

                        if (Chance == 1)
                        {
                            Variables.PlanetImage = "_1_Alpha_Centuri";
                            picboxPlanet1.Image = Resources._1_Alpha_Centuri;
                            picboxPlanet1.Show();
                            Variables.PlanetVisible = true;
                            Variables.AsteroidsVisible = false;
                        }

                        else
                        {
                            picboxAsteroid1.Show();
                            picboxAsteroid2.Show();
                            picboxAsteroid3.Show();
                            picboxAsteroid4.Show();

                            timerAsteroid1Move = new System.Threading.Timer(new TimerCallback(timerAsteroid1Move_Tick), null, 25, 300);
                            timerAsteroid2Move = new System.Threading.Timer(new TimerCallback(timerAsteroid2Move_Tick), null, 25, 300);
                            timerAsteroid3Move = new System.Threading.Timer(new TimerCallback(timerAsteroid3Move_Tick), null, 25, 300);
                            timerAsteroid4Move = new System.Threading.Timer(new TimerCallback(timerAsteroid4Move_Tick), null, 25, 300);

                            Variables.AsteroidsVisible = true;
                            Variables.PlanetVisible = false;
                        }
                    }

                    else if (Variables.Stage == 2)
                    {
                        Random rnd = new Random();
                        int Chance = rnd.Next(1, 4);

                        if (Chance == 1)
                        {
                            Variables.PlanetImage = "_2_Pollux";
                            picboxPlanet1.Image = Resources._2_Pollux;
                            picboxPlanet1.Show();
                            Variables.PlanetVisible = true;
                            Variables.AsteroidsVisible = false;
                        }

                        else
                        {
                            picboxAsteroid1.Show();
                            picboxAsteroid2.Show();
                            picboxAsteroid3.Show();
                            picboxAsteroid4.Show();

                            timerAsteroid1Move = new System.Threading.Timer(new TimerCallback(timerAsteroid1Move_Tick), null, 25, 300);
                            timerAsteroid2Move = new System.Threading.Timer(new TimerCallback(timerAsteroid2Move_Tick), null, 25, 300);
                            timerAsteroid3Move = new System.Threading.Timer(new TimerCallback(timerAsteroid3Move_Tick), null, 25, 300);
                            timerAsteroid4Move = new System.Threading.Timer(new TimerCallback(timerAsteroid4Move_Tick), null, 25, 300);

                            Variables.AsteroidsVisible = true;
                            Variables.PlanetVisible = false;
                        }
                    }

                    else if (Variables.Stage == 3)
                    {
                        Random rnd = new Random();
                        int Chance = rnd.Next(1, 5);

                        if (Chance == 1)
                        {
                            Variables.PlanetImage = "_3_Formalhaut";
                            picboxPlanet1.Image = Resources._3_Formalhaut;
                            picboxPlanet1.Show();
                            Variables.PlanetVisible = true;
                            Variables.AsteroidsVisible = false;
                        }

                        else
                        {
                            picboxAsteroid1.Show();
                            picboxAsteroid2.Show();
                            picboxAsteroid3.Show();
                            picboxAsteroid4.Show();

                            timerAsteroid1Move = new System.Threading.Timer(new TimerCallback(timerAsteroid1Move_Tick), null, 25, 300);
                            timerAsteroid2Move = new System.Threading.Timer(new TimerCallback(timerAsteroid2Move_Tick), null, 25, 300);
                            timerAsteroid3Move = new System.Threading.Timer(new TimerCallback(timerAsteroid3Move_Tick), null, 25, 300);
                            timerAsteroid4Move = new System.Threading.Timer(new TimerCallback(timerAsteroid4Move_Tick), null, 25, 300);

                            Variables.AsteroidsVisible = true;
                            Variables.PlanetVisible = false;
                        }
                    }

                    else if (Variables.Stage == 4)
                    {
                        Random rnd = new Random();
                        int Chance = rnd.Next(1, 5);

                        if (Chance == 1)
                        {
                            Variables.PlanetImage = "_4_Kepler";
                            picboxPlanet1.Image = Resources._4_Kepler;
                            picboxPlanet1.Show();
                            Variables.PlanetVisible = true;
                            Variables.AsteroidsVisible = false;
                        }

                        else
                        {
                            picboxAsteroid1.Show();
                            picboxAsteroid2.Show();
                            picboxAsteroid3.Show();
                            picboxAsteroid4.Show();

                            timerAsteroid1Move = new System.Threading.Timer(new TimerCallback(timerAsteroid1Move_Tick), null, 25, 300);
                            timerAsteroid2Move = new System.Threading.Timer(new TimerCallback(timerAsteroid2Move_Tick), null, 25, 300);
                            timerAsteroid3Move = new System.Threading.Timer(new TimerCallback(timerAsteroid3Move_Tick), null, 25, 300);
                            timerAsteroid4Move = new System.Threading.Timer(new TimerCallback(timerAsteroid4Move_Tick), null, 25, 300);

                            Variables.AsteroidsVisible = true;
                            Variables.PlanetVisible = false;
                        }
                    }

                    else if (Variables.Stage == 5)
                    {
                        Random rnd = new Random();
                        int Chance = rnd.Next(1, 5);

                        if (Chance == 1)
                        {
                            Variables.PlanetImage = "_5_Cetus";
                            picboxPlanet1.Image = Resources._5_Cetus;
                            picboxPlanet1.Show();
                            Variables.PlanetVisible = true;
                            Variables.AsteroidsVisible = false;
                        }

                        else
                        {
                            picboxAsteroid1.Show();
                            picboxAsteroid2.Show();
                            picboxAsteroid3.Show();
                            picboxAsteroid4.Show();

                            timerAsteroid1Move = new System.Threading.Timer(new TimerCallback(timerAsteroid1Move_Tick), null, 25, 300);
                            timerAsteroid2Move = new System.Threading.Timer(new TimerCallback(timerAsteroid2Move_Tick), null, 25, 300);
                            timerAsteroid3Move = new System.Threading.Timer(new TimerCallback(timerAsteroid3Move_Tick), null, 25, 300);
                            timerAsteroid4Move = new System.Threading.Timer(new TimerCallback(timerAsteroid4Move_Tick), null, 25, 300);

                            Variables.AsteroidsVisible = true;
                            Variables.PlanetVisible = false;

                        }
                    }

                    else if (Variables.Stage == 6)
                    {
                        Random rnd = new Random();
                        int Chance = rnd.Next(1, 5);

                        if (Chance == 1)
                        {
                            Variables.PlanetImage = "_6_Pyxis";
                            picboxPlanet1.Image = Resources._6_Pyxis;
                            picboxPlanet1.Show();
                            Variables.PlanetVisible = true;
                            Variables.AsteroidsVisible = false;
                        }

                        else
                        {
                            picboxAsteroid1.Show();
                            picboxAsteroid2.Show();
                            picboxAsteroid3.Show();
                            picboxAsteroid4.Show();

                            timerAsteroid1Move = new System.Threading.Timer(new TimerCallback(timerAsteroid1Move_Tick), null, 25, 300);
                            timerAsteroid2Move = new System.Threading.Timer(new TimerCallback(timerAsteroid2Move_Tick), null, 25, 300);
                            timerAsteroid3Move = new System.Threading.Timer(new TimerCallback(timerAsteroid3Move_Tick), null, 25, 300);
                            timerAsteroid4Move = new System.Threading.Timer(new TimerCallback(timerAsteroid4Move_Tick), null, 25, 300);

                            Variables.AsteroidsVisible = true;
                            Variables.PlanetVisible = false;
                        }
                    }

                    else if (Variables.Stage == 7)
                    {
                        Form WinScreen = new WinScreen();
                        WinScreen.Show();
                        this.Dispose();
                    }
                }
            }

            else
            {
                Variables.GameWasLoaded = false;

                if (Variables.PlanetVisible == true)
                {
                    picboxPlanet1.Show();
                }

                else
                {
                    picboxAsteroid1.Show();
                    picboxAsteroid2.Show();
                    picboxAsteroid3.Show();
                    picboxAsteroid4.Show();

                    timerAsteroid1Move = new System.Threading.Timer(new TimerCallback(timerAsteroid1Move_Tick), null, 25, 300);
                    timerAsteroid2Move = new System.Threading.Timer(new TimerCallback(timerAsteroid2Move_Tick), null, 25, 300);
                    timerAsteroid3Move = new System.Threading.Timer(new TimerCallback(timerAsteroid3Move_Tick), null, 25, 300);
                    timerAsteroid4Move = new System.Threading.Timer(new TimerCallback(timerAsteroid4Move_Tick), null, 25, 300);

                    Variables.AsteroidsVisible = true;
                    Variables.PlanetVisible = false;
                }

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

                picboxShip.Location = new Point(Variables.ShipNewX, Variables.ShipNewY);
            }
        }

        private void Space1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Variables.Pause == false)
            {
                if (e.KeyCode == Keys.L)
                {
                    if (Variables.CheatsEnabled == true)
                        Variables.Stage++;
                }

                if (e.KeyCode == Keys.Escape)
                {
                    Variables.Pause = true;

                    Form Options = new Options();
                    Options.ShowDialog();
                }

                if (e.KeyCode == Keys.D || e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.W)
                {
                    Variables.ShipOldX = picboxShip.Location.X;
                    Variables.ShipOldY = picboxShip.Location.Y;

                    Variables.ShipNewX = picboxShip.Location.X; //remove this to enable warping through planets (lol)
                    Variables.ShipNewY = picboxShip.Location.Y; //remove this to enable warping through planets (lol)


                    if (e.KeyCode == Keys.D)
                    {
                        picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[2]);
                        Variables.ShipNewX += 3;
                        picboxShip.Location = new Point(Variables.ShipNewX, Variables.ShipNewY);
                        Variables.Orientation = "E";
                    }

                    else if (e.KeyCode == Keys.A)
                    {
                        picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[4]);
                        Variables.ShipNewX -= 3;
                        picboxShip.Location = new Point(Variables.ShipNewX, Variables.ShipNewY);
                        Variables.Orientation = "W";
                    }
                    else if (e.KeyCode == Keys.W)
                    {
                        picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[1]);
                        Variables.ShipNewY -= 3;
                        picboxShip.Location = new Point(Variables.ShipNewX, Variables.ShipNewY);
                        Variables.Orientation = "N";
                    }
                    else if (e.KeyCode == Keys.S)
                    {
                        picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[3]);
                        Variables.ShipNewY += 3;
                        picboxShip.Location = new Point(Variables.ShipNewX, Variables.ShipNewY);
                        Variables.Orientation = "S";
                    }

                    picboxShip.Location = new Point(Variables.ShipNewX, Variables.ShipNewY);

                    if (picboxShip.Bounds.IntersectsWith(EdgeBottom.Bounds))
                    {
                        if (Variables.AsteroidsVisible)
                        {
                            timerAsteroid1Move.Dispose();
                            timerAsteroid2Move.Dispose();
                            timerAsteroid3Move.Dispose();
                            timerAsteroid4Move.Dispose();
                        }

                        Variables.Orientation = "S";
                        Form Space1 = new Space1();
                        Space1.Show();
                        this.Dispose();
                    }

                    else if (picboxShip.Bounds.IntersectsWith(EdgeTop.Bounds))
                    {
                        if (Variables.AsteroidsVisible)
                        {
                            timerAsteroid1Move.Dispose();
                            timerAsteroid2Move.Dispose();
                            timerAsteroid3Move.Dispose();
                            timerAsteroid4Move.Dispose();
                        }

                        Variables.Orientation = "N";
                        Form Space1 = new Space1();
                        Space1.Show();
                        this.Dispose();
                    }

                    else if (picboxShip.Bounds.IntersectsWith(EdgeLeft.Bounds))
                    {
                        if (Variables.AsteroidsVisible)
                        {
                            timerAsteroid1Move.Dispose();
                            timerAsteroid2Move.Dispose();
                            timerAsteroid3Move.Dispose();
                            timerAsteroid4Move.Dispose();
                        }

                        Variables.Orientation = "W";
                        Form Space1 = new Space1();
                        Space1.Show();
                        this.Dispose();
                    }

                    else if (picboxShip.Bounds.IntersectsWith(EdgeRight.Bounds))
                    {
                        if (Variables.AsteroidsVisible)
                        {
                            timerAsteroid1Move.Dispose();
                            timerAsteroid2Move.Dispose();
                            timerAsteroid3Move.Dispose();
                            timerAsteroid4Move.Dispose();
                        }

                        Variables.Orientation = "E";
                        Form Space1 = new Space1();
                        Space1.Show();
                        this.Dispose();
                    }

                    else if (picboxShip.Bounds.IntersectsWith(picboxPlanet1.Bounds))
                    {
                        if (picboxPlanet1.Visible == true)
                        {
                            Variables.Orientation = "P";

                            if (Variables.Stage == 1)
                            {
                                Form Planet1 = new Planet1();
                                Planet1.Show();
                            }

                            else if (Variables.Stage == 2)
                            {
                                Form Planet2 = new Planet2();
                                Planet2.Show();
                            }

                            else if (Variables.Stage == 3)
                            {
                                Form Planet3 = new Planet3();
                                Planet3.Show();
                            }

                            this.Dispose();
                        }
                    }

                    else if (picboxShip.Bounds.IntersectsWith(picboxAsteroid1.Bounds) || picboxShip.Bounds.IntersectsWith(picboxAsteroid2.Bounds) || picboxShip.Bounds.IntersectsWith(picboxAsteroid3.Bounds) || picboxShip.Bounds.IntersectsWith(picboxAsteroid4.Bounds))
                    {
                        if (Variables.AsteroidsVisible == true)
                        {
                            if (Variables.SoundOn == true)
                            {
                                Variables.Music.Stop();
                                Variables.Music.Stream = Resources._8bit_bomb_explosion;
                                Variables.Music.Play();
                            }
                            Variables.Pause = true;
                            timerDeath = new System.Threading.Timer(new TimerCallback(timerDeath_Tick), null, 0, 100);
                            picboxShip.Image = Variables.Explosion[0];
                        }
                    }
                }
            }
        }

        private void Space1_KeyUp(object sender, KeyEventArgs e)
        {
            if (Variables.Pause == false)
            {
                //resets the image to the "stationary" one upon releasing keys
                if (e.KeyCode == Keys.D) picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[5]);
                else if (e.KeyCode == Keys.A) picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[7]);
                else if (e.KeyCode == Keys.W) picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[0]);
                else if (e.KeyCode == Keys.S) picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[6]);
            }
        }

        private void timerAsteroid1Move_Tick(object obj)
        {
            if (Variables.Pause == false)
            {

                oldasteroid1LocX = picboxAsteroid1.Location.X;
                oldasteroid1LocY = picboxAsteroid1.Location.Y;
                asteroid1LocX = picboxAsteroid1.Location.X;
                asteroid1LocY = picboxAsteroid1.Location.Y;

                if (asteroid1TickCounter == 0)
                {
                    enemyRndInt = rnd.Next(1, 6);

                    if (enemyRndInt == 1)
                        asteroid1Direction = "Up";
                    else if (enemyRndInt == 2 || enemyRndInt == 3)
                        asteroid1Direction = "Down";
                    else if (enemyRndInt == 4)
                        asteroid1Direction = "Left";
                    else if (enemyRndInt == 5 || enemyRndInt == 6)
                        asteroid1Direction = "Right";

                    asteroid1TickCounter++;
                }

                else if (asteroid1TickCounter == 3)
                {
                    asteroid1TickCounter = 0;
                }

                else if (asteroid1TickCounter == 1 || asteroid1TickCounter == 2)
                {
                    asteroid1TickCounter++;
                }

                if (asteroid1Direction == "Up")
                    asteroid1LocY = asteroid1LocY - 3;
                else if (asteroid1Direction == "Down")
                    asteroid1LocY = asteroid1LocY + 3;
                else if (asteroid1Direction == "Left")
                    asteroid1LocX = asteroid1LocX - 3;
                else if (asteroid1Direction == "Right")
                    asteroid1LocX = asteroid1LocX + 3;

                picboxAsteroid1.Invoke((MethodInvoker)(() => picboxAsteroid1.Location = new Point(asteroid1LocX, asteroid1LocY)));

                if (picboxAsteroid1.Bounds.IntersectsWith(EdgeBottom.Bounds) || picboxAsteroid1.Bounds.IntersectsWith(EdgeLeft.Bounds) || picboxAsteroid1.Bounds.IntersectsWith(EdgeRight.Bounds) || picboxAsteroid1.Bounds.IntersectsWith(EdgeTop.Bounds) || picboxAsteroid1.Bounds.IntersectsWith(picboxAsteroid2.Bounds) || picboxAsteroid1.Bounds.IntersectsWith(picboxAsteroid3.Bounds) || picboxAsteroid1.Bounds.IntersectsWith(picboxAsteroid4.Bounds))
                    picboxAsteroid1.Invoke((MethodInvoker)(() => picboxAsteroid1.Location = new Point(oldasteroid1LocX, oldasteroid1LocY)));
            }
        }

        private void timerAsteroid2Move_Tick(object obj)
        {
            if (Variables.Pause == false)
            {
                oldasteroid2LocX = picboxAsteroid2.Location.X;
                oldasteroid2LocY = picboxAsteroid2.Location.Y;
                asteroid2LocX = picboxAsteroid2.Location.X;
                asteroid2LocY = picboxAsteroid2.Location.Y;

                if (asteroid2TickCounter == 0)
                {
                    enemyRndInt = rnd.Next(1, 6);

                    if (enemyRndInt == 1)
                        asteroid2Direction = "Up";
                    else if (enemyRndInt == 2 || enemyRndInt == 3)
                        asteroid2Direction = "Down";
                    else if (enemyRndInt == 4)
                        asteroid2Direction = "Left";
                    else if (enemyRndInt == 5 || enemyRndInt == 6)
                        asteroid2Direction = "Right";

                    asteroid2TickCounter++;
                }

                else if (asteroid2TickCounter == 3)
                {
                    asteroid2TickCounter = 0;
                }

                else if (asteroid2TickCounter == 1 || asteroid2TickCounter == 2)
                {
                    asteroid2TickCounter++;
                }

                if (asteroid2Direction == "Up")
                    asteroid2LocY = asteroid2LocY - 3;
                else if (asteroid2Direction == "Down")
                    asteroid2LocY = asteroid2LocY + 3;
                else if (asteroid2Direction == "Left")
                    asteroid2LocX = asteroid2LocX - 3;
                else if (asteroid2Direction == "Right")
                    asteroid2LocX = asteroid2LocX + 3;

                picboxAsteroid2.Invoke((MethodInvoker)(() => picboxAsteroid2.Location = new Point(asteroid2LocX, asteroid2LocY)));

                if (picboxAsteroid2.Bounds.IntersectsWith(EdgeBottom.Bounds) || picboxAsteroid2.Bounds.IntersectsWith(EdgeLeft.Bounds) || picboxAsteroid2.Bounds.IntersectsWith(EdgeRight.Bounds) || picboxAsteroid2.Bounds.IntersectsWith(EdgeTop.Bounds) || picboxAsteroid2.Bounds.IntersectsWith(picboxAsteroid3.Bounds) || picboxAsteroid2.Bounds.IntersectsWith(picboxAsteroid4.Bounds))
                    picboxAsteroid2.Invoke((MethodInvoker)(() => picboxAsteroid2.Location = new Point(oldasteroid2LocX, oldasteroid2LocY)));
            }
        }

        private void timerAsteroid3Move_Tick(object obj)
        {
            if (Variables.Pause == false)
            {

                oldasteroid3LocX = picboxAsteroid3.Location.X;
                oldasteroid3LocY = picboxAsteroid3.Location.Y;
                asteroid3LocX = picboxAsteroid3.Location.X;
                asteroid3LocY = picboxAsteroid3.Location.Y;

                if (asteroid3TickCounter == 0)
                {
                    enemyRndInt = rnd.Next(1, 6);

                    if (enemyRndInt == 1)
                        asteroid3Direction = "Up";
                    else if (enemyRndInt == 2 || enemyRndInt == 3)
                        asteroid3Direction = "Down";
                    else if (enemyRndInt == 4)
                        asteroid3Direction = "Left";
                    else if (enemyRndInt == 5 || enemyRndInt == 6)
                        asteroid3Direction = "Right";

                    asteroid3TickCounter++;
                }

                else if (asteroid3TickCounter == 3)
                {
                    asteroid3TickCounter = 0;
                }

                else if (asteroid3TickCounter == 1 || asteroid3TickCounter == 2)
                {
                    asteroid3TickCounter++;
                }

                if (asteroid3Direction == "Up")
                    asteroid3LocY = asteroid3LocY - 3;
                else if (asteroid3Direction == "Down")
                    asteroid3LocY = asteroid3LocY + 3;
                else if (asteroid3Direction == "Left")
                    asteroid3LocX = asteroid3LocX - 3;
                else if (asteroid3Direction == "Right")
                    asteroid3LocX = asteroid3LocX + 3;

                picboxAsteroid3.Invoke((MethodInvoker)(() => picboxAsteroid3.Location = new Point(asteroid3LocX, asteroid3LocY)));

                if (picboxAsteroid3.Bounds.IntersectsWith(EdgeBottom.Bounds) || picboxAsteroid3.Bounds.IntersectsWith(EdgeLeft.Bounds) || picboxAsteroid3.Bounds.IntersectsWith(EdgeRight.Bounds) || picboxAsteroid3.Bounds.IntersectsWith(EdgeTop.Bounds) || picboxAsteroid3.Bounds.IntersectsWith(picboxAsteroid4.Bounds))
                    picboxAsteroid3.Invoke((MethodInvoker)(() => picboxAsteroid3.Location = new Point(oldasteroid3LocX, oldasteroid3LocY)));
            }
        }

        private void timerAsteroid4Move_Tick(object obj)
        {
            if (Variables.Pause == false)
            {

                oldasteroid4LocX = picboxAsteroid4.Location.X;
                oldasteroid4LocY = picboxAsteroid4.Location.Y;
                asteroid4LocX = picboxAsteroid4.Location.X;
                asteroid4LocY = picboxAsteroid4.Location.Y;

                if (asteroid4TickCounter == 0)
                {
                    enemyRndInt = rnd.Next(1, 6);

                    if (enemyRndInt == 1)
                        asteroid4Direction = "Up";
                    else if (enemyRndInt == 2 || enemyRndInt == 3)
                        asteroid4Direction = "Down";
                    else if (enemyRndInt == 4)
                        asteroid4Direction = "Left";
                    else if (enemyRndInt == 5 || enemyRndInt == 6)
                        asteroid4Direction = "Right";

                    asteroid4TickCounter++;
                }

                else if (asteroid4TickCounter == 3)
                {
                    asteroid4TickCounter = 0;
                }

                else if (asteroid4TickCounter == 1 || asteroid4TickCounter == 2)
                {
                    asteroid4TickCounter++;
                }

                if (asteroid4Direction == "Up")
                    asteroid4LocY = asteroid4LocY - 3;
                else if (asteroid4Direction == "Down")
                    asteroid4LocY = asteroid4LocY + 3;
                else if (asteroid1Direction == "Left")
                    asteroid4LocX = asteroid4LocX - 3;
                else if (asteroid1Direction == "Right")
                    asteroid4LocX = asteroid4LocX + 3;

                picboxAsteroid4.Invoke((MethodInvoker)(() => picboxAsteroid4.Location = new Point(asteroid4LocX, asteroid4LocY)));

                if (picboxAsteroid4.Bounds.IntersectsWith(EdgeBottom.Bounds) || picboxAsteroid4.Bounds.IntersectsWith(EdgeLeft.Bounds) || picboxAsteroid4.Bounds.IntersectsWith(EdgeRight.Bounds) || picboxAsteroid4.Bounds.IntersectsWith(EdgeTop.Bounds))
                    picboxAsteroid4.Invoke((MethodInvoker)(() => picboxAsteroid4.Location = new Point(oldasteroid4LocX, oldasteroid4LocY)));
            }
        }

        private void timerDeath_Tick(object obj)
        {
            if (Anim <= 6)
            {
                picboxShip.Image = Variables.Explosion[Anim];
                Anim++;
            }

            else
            {
                this.Invoke(new Action(() => ShowGameOver()));
                timerDeath.Dispose();
            }
        }

        private void ShowGameOver()
        {
            Form GameOver = new GameOver();
            GameOver.Show();
            this.Hide();

            timerAsteroid1Move.Dispose();
            timerAsteroid2Move.Dispose();
            timerAsteroid3Move.Dispose();
            timerAsteroid4Move.Dispose();
            timerReleaseThreads.Start();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void timerReleaseThreads_Tick(object sender, EventArgs e)
        {
            timerReleaseThreads.Stop();
            this.Dispose();
        }
    }
}
