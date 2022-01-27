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

namespace Space_Game
{
    public partial class Planet4 : Form
    {
        System.Threading.Timer timerWalkAnim, timerEnemy1Walk, timerEnemy2Walk, timerEnemy3Walk, timerEnemy4Walk, timerBossWalk;

        Point PlayerStartLocation = new Point();

        int Anim, enemyRndInt,
            enemy1LocY, enemy1LocX, oldenemy1LocX, oldenemy1LocY, enemy1TickCounter, enemy1Anim,
            enemy2LocY, enemy2LocX, oldenemy2LocX, oldenemy2LocY, enemy2TickCounter, enemy2Anim,
            enemy3LocY, enemy3LocX, oldenemy3LocX, oldenemy3LocY, enemy3TickCounter, enemy3Anim,
            enemy4LocY, enemy4LocX, oldenemy4LocX, oldenemy4LocY, enemy4TickCounter, enemy4Anim,
            enemyBossLocY, enemyBossLocX, oldenemyBossLocX, oldenemyBossLocY, enemyBossTickCounter, enemyBossAnim;

        bool ReverseAnim, enemy1ReverseAnim, enemy2ReverseAnim, enemy3ReverseAnim, enemy4ReverseAnim, enemyBossReverseAnim,
            isAPressed, isWPressed, isSPressed, isDPressed,
            Item1Found;

        string enemy1Direction, enemy2Direction, enemy3Direction, enemy4Direction, enemyBossDirection,
            enemy1Image01, enemy1Image02, enemy1Image03,
            enemy2Image01, enemy2Image02, enemy2Image03,
            enemy3Image01, enemy3Image02, enemy3Image03,
            enemy4Image01, enemy4Image02, enemy4Image03,
            enemyBossImage01, enemyBossImage02, enemyBossImage03;

        PictureBox[] ActiveImpassables = new PictureBox[15], ActiveHazards = new PictureBox[3];

        Random rnd = new Random();

        public Planet4()
        {
            InitializeComponent();
        }   

        private void Planet4_Load(object sender, EventArgs e)
        {
            PlayerStartLocation = picboxPlayer.Location;

            enemy1TickCounter = 0;
            enemy2TickCounter = 0;
            enemy3TickCounter = 0;
            enemy4TickCounter = 0;
            enemyBossTickCounter = 0;
            enemy1Anim = 0;
            enemy2Anim = 0;
            enemy3Anim = 0;
            enemy4Anim = 0;

            timerWalkAnim = new System.Threading.Timer(new TimerCallback(timerSpriteAnim_Tick), null, 0, 150);
            timerEnemy1Walk = new System.Threading.Timer(new TimerCallback(timerEnemy1Walk_Tick), null, 25, 300);
            timerEnemy2Walk = new System.Threading.Timer(new TimerCallback(timerEnemy2Walk_Tick), null, 50, 300);
            timerEnemy3Walk = new System.Threading.Timer(new TimerCallback(timerEnemy3Walk_Tick), null, 75, 300);
            timerEnemy4Walk = new System.Threading.Timer(new TimerCallback(timerEnemy4Walk_Tick), null, 100, 300);
            timerBossWalk = new System.Threading.Timer(new TimerCallback(timerBossWalk_Tick), null, 125, 600);


            Variables.CurrentForm = "Planet4";
            Variables.OnPlanet = true;
            this.KeyDown += new KeyEventHandler(Planet4_KeyDown);
            this.KeyUp += new KeyEventHandler(Planet4_KeyUp);

            picboxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[1]);
            picboxShip.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameShip[0]);

            if (Variables.SoundOn == true)
            {
                Variables.Music.Stop();
                Variables.Music.Stream = Resources.Planetrise_v1_0_0;
                Variables.Music.PlayLooping();
            }

            if (Variables.GameWasLoaded == true)
            {
                Variables.GameWasLoaded = false;
                picboxPlayer.Location = new Point(Variables.PlayerNewX, Variables.PlayerNewY);
            }

            ActiveImpassables[0] = picboxImpassable1;
            ActiveImpassables[1] = picboxImpassable2;
            ActiveImpassables[2] = picboxImpassable3;
            ActiveImpassables[3] = picboxImpassable4;
            ActiveImpassables[4] = picboxImpassable5;
            ActiveImpassables[5] = picboxImpassable6;
            ActiveImpassables[6] = picboxImpassable7;
            ActiveImpassables[7] = picboxImpassable8;
            ActiveImpassables[8] = picboxImpassable9;
            ActiveImpassables[9] = picboxImpassable10;
            ActiveImpassables[10] = picboxImpassable11;
            ActiveImpassables[11] = picboxImpassable12;
            ActiveImpassables[12] = picboxImpassable13;
            ActiveImpassables[13] = picboxImpassable14;
            ActiveImpassables[14] = picboxImpassable15;

            ActiveHazards[0] = picboxHazard1;
            ActiveHazards[1] = picboxHazard2;
            ActiveHazards[2] = picboxHazard3;

            Variables.PlanetCombatBG = "KeplerCombatMap";
        }

        private void Planet4_KeyDown(object sender, KeyEventArgs e)
        {
            if (Variables.Pause == false)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    Variables.Pause = true;

                    Form Options = new Options();
                    Options.ShowDialog();
                }

                if (e.KeyCode == Keys.D || e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.W)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.A:
                            ReverseAnim = false;
                            Anim = 0;
                            isAPressed = true;
                            break;
                        case Keys.S:
                            ReverseAnim = false;
                            Anim = 0;
                            isSPressed = true;
                            break;
                        case Keys.W:
                            ReverseAnim = false;
                            Anim = 0;
                            isWPressed = true;
                            break;
                        case Keys.D:
                            ReverseAnim = false;
                            Anim = 0;
                            isDPressed = true;
                            break;
                    }
                }
            }
        }

        private void Planet4_KeyUp(object sender, KeyEventArgs e)
        {
            //resets the image to the "stationary" one upon releasing keys
            switch (e.KeyCode)
            {
                case Keys.A:
                    picboxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[7]);
                    isAPressed = false;
                    break;
                case Keys.S:
                    picboxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[1]);
                    isSPressed = false;
                    break;
                case Keys.W:
                    picboxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[4]);
                    isWPressed = false;
                    break;
                case Keys.D:
                    picboxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[10]);
                    isDPressed = false;
                    break;
            }
        }

        private void timerSpriteAnim_Tick(object obj)
        {
            if (this.Visible == true)
            {
                if (Variables.Pause == false)
                {
                    Variables.PlayerOldX = picboxPlayer.Location.X;
                    Variables.PlayerOldY = picboxPlayer.Location.Y;

                    Variables.PlayerNewX = picboxPlayer.Location.X;
                    Variables.PlayerNewY = picboxPlayer.Location.Y;

                    if (isAPressed)
                    {
                        Variables.PlayerNewX -= 5;

                        if (Anim == 0)
                        {
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[6])));
                            Anim = 1;
                            ReverseAnim = false;
                        }

                        else if (Anim == 1)
                        {
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[7])));

                            if (ReverseAnim == false)
                                Anim = 2;

                            else if (ReverseAnim == true)
                                Anim = 0;
                        }

                        else if (Anim == 2)
                        {
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[8])));
                            Anim = 1;
                            ReverseAnim = true;
                        }
                    }

                    else if (isSPressed)
                    {
                        Variables.PlayerNewY += 5;

                        if (Anim == 0)
                        {
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[0])));
                            Anim = 1;
                            ReverseAnim = false;
                        }

                        else if (Anim == 1)
                        {
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[1])));

                            if (ReverseAnim == false)
                                Anim = 2;

                            else if (ReverseAnim == true)
                                Anim = 0;
                        }

                        else if (Anim == 2)
                        {
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[2])));
                            Anim = 1;
                            ReverseAnim = true;
                        }
                    }

                    else if (isDPressed)
                    {
                        Variables.PlayerNewX += 5;

                        if (Anim == 0)
                        {
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[9])));
                            Anim = 1;
                            ReverseAnim = false;
                        }

                        else if (Anim == 1)
                        {
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[10])));

                            if (ReverseAnim == false)
                                Anim = 2;

                            else if (ReverseAnim == true)
                                Anim = 0;
                        }

                        else if (Anim == 2)
                        {
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[11])));
                            Anim = 1;
                            ReverseAnim = true;
                        }
                    }

                    else if (isWPressed)
                    {
                        Variables.PlayerNewY -= 5;

                        if (Anim == 0)
                        {
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[3])));
                            Anim = 1;
                            ReverseAnim = false;
                        }

                        else if (Anim == 1)
                        {
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[4])));

                            if (ReverseAnim == false)
                                Anim = 2;

                            else if (ReverseAnim == true)
                                Anim = 0;
                        }

                        else if (Anim == 2)
                        {
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[5])));
                            Anim = 1;
                            ReverseAnim = true;
                        }
                    }

                    picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Location = new Point(Variables.PlayerNewX, Variables.PlayerNewY)));

                    foreach (PictureBox i in ActiveImpassables)
                    {
                        if (picboxPlayer.Bounds.IntersectsWith(i.Bounds))
                        {
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Location = new Point(Variables.PlayerOldX, Variables.PlayerOldY)));
                        }
                    }

                    foreach (PictureBox i in ActiveHazards)
                    {
                        if (picboxPlayer.Bounds.IntersectsWith(i.Bounds))
                        {
                            if (Variables.Pause == false)
                            {
                                Variables.Pause = true;
                                this.Invoke((MethodInvoker)(() =>
                                {
                                    Form GameOver = new GameOver();
                                    GameOver.Show();
                                    this.Hide();
                                    timerEnemy1Walk.Dispose();
                                    timerEnemy2Walk.Dispose();
                                    timerEnemy3Walk.Dispose();
                                    timerEnemy4Walk.Dispose();
                                    timerBossWalk.Dispose();
                                    timerWalkAnim.Dispose();
                                    timerReleaseThreads.Start();
                                }));
                            }
                        }
                    }
                    
                    if (picboxPlayer.Bounds.IntersectsWith(picboxSpecial1.Bounds))
                    {
                        if (Item1Found == false)
                        {
                            isAPressed = false;
                            isWPressed = false;
                            isSPressed = false;
                            isDPressed = false;
                            Variables.ItemFound = "Dodge";
                            Variables.PlayerDodgeChance += 10;
                            Variables.Pause = true;
                            Form CustomMessageBox = new CustomMessageBox();
                            CustomMessageBox.ShowDialog();
                            Variables.Pause = false;
                            Item1Found = true;
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Location = new Point(Variables.PlayerOldX, Variables.PlayerOldY)));
                        }
                        else
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Location = new Point(Variables.PlayerOldX, Variables.PlayerOldY)));
                    }

                    if (picboxPlayer.Bounds.IntersectsWith(EdgeBottom.Bounds) || picboxPlayer.Bounds.IntersectsWith(EdgeTop.Bounds) ||
                        picboxPlayer.Bounds.IntersectsWith(EdgeRight.Bounds) || picboxPlayer.Bounds.IntersectsWith(EdgeLeft.Bounds))
                    {
                        picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Location = new Point(Variables.PlayerOldX, Variables.PlayerOldY)));
                    }

                    else if (picboxPlayer.Bounds.IntersectsWith(picboxShip.Bounds))
                    {
                        Variables.Orientation = "P";
                        this.Invoke((MethodInvoker)(() =>
                        {
                            Form Space1 = new Space1();
                            Space1.Show();
                            this.Hide();
                            timerEnemy1Walk.Dispose();
                            timerEnemy2Walk.Dispose();
                            timerEnemy3Walk.Dispose();
                            timerEnemy4Walk.Dispose();
                            timerBossWalk.Dispose();
                            timerWalkAnim.Dispose();
                            timerReleaseThreads.Start();
                        }));
                    }

                    else if (picboxPlayer.Bounds.IntersectsWith(picboxEnemy1.Bounds))
                    {
                        if (picboxEnemy1.Visible == true)
                        {
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Location = new Point(Variables.PlayerOldX, Variables.PlayerOldY)));

                            Variables.EnemyName = "Kepler Grunt";
                            Variables.EnemyHP = 400;
                            Variables.EnemyDamage = 8;

                            Variables.EnemyIcon = Resources.ZombieDown02;
                            Variables.Pause = true;

                            this.Invoke((MethodInvoker)(() =>
                            {
                                this.Hide();
                                Form PlanetCombat = new PlanetCombat();
                                PlanetCombat.ShowDialog();
                                this.Show();

                                if (Variables.SoundOn == true)
                                {
                                    Variables.Music.Stop();
                                    Variables.Music.Stream = Resources.Planetrise_v1_0_0;
                                    Variables.Music.PlayLooping();
                                }

                                isAPressed = false;
                                isWPressed = false;
                                isSPressed = false;
                                isDPressed = false;

                                if (Variables.BattleOutcome == "Won")
                                {
                                    picboxEnemy1.Visible = false;
                                    timerEnemy1Walk.Dispose();
                                }

                                else if (Variables.BattleOutcome == "Ran")
                                    picboxPlayer.Location = PlayerStartLocation;

                            }));
                            Variables.Pause = false;
                        }
                    }

                    else if (picboxPlayer.Bounds.IntersectsWith(picboxEnemy2.Bounds))
                    {
                        if (picboxEnemy2.Visible == true)
                        {
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Location = new Point(Variables.PlayerOldX, Variables.PlayerOldY)));

                            Variables.EnemyName = "Kepler Grunt";
                            Variables.EnemyHP = 400;
                            Variables.EnemyDamage = 12;

                            Variables.EnemyIcon = Resources.ZombieDown02;
                            Variables.Pause = true;

                            this.Invoke((MethodInvoker)(() =>
                            {
                                this.Hide();
                                Form PlanetCombat = new PlanetCombat();
                                PlanetCombat.ShowDialog();
                                this.Show();

                                if (Variables.SoundOn == true)
                                {
                                    Variables.Music.Stop();
                                    Variables.Music.Stream = Resources.Planetrise_v1_0_0;
                                    Variables.Music.PlayLooping();
                                }

                                isAPressed = false;
                                isWPressed = false;
                                isSPressed = false;
                                isDPressed = false;
                                if (Variables.BattleOutcome == "Won")
                                {
                                    picboxEnemy2.Visible = false;
                                    timerEnemy2Walk.Dispose();
                                }

                                else if (Variables.BattleOutcome == "Ran")
                                    picboxPlayer.Location = PlayerStartLocation;
                            }));
                            Variables.Pause = false;
                        }
                    }

                    else if (picboxPlayer.Bounds.IntersectsWith(picboxEnemy3.Bounds))
                    {
                        if (picboxEnemy3.Visible == true)
                        {
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Location = new Point(Variables.PlayerOldX, Variables.PlayerOldY)));

                            Variables.EnemyName = "Kepler Grunt";
                            Variables.EnemyHP = 400;
                            Variables.EnemyDamage = 16;

                            Variables.EnemyIcon = Resources.ZombieDown02;
                            Variables.Pause = true;

                            this.Invoke((MethodInvoker)(() =>
                            {
                                this.Hide();
                                Form PlanetCombat = new PlanetCombat();
                                PlanetCombat.ShowDialog();
                                this.Show();

                                if (Variables.SoundOn == true)
                                {
                                    Variables.Music.Stop();
                                    Variables.Music.Stream = Resources.Planetrise_v1_0_0;
                                    Variables.Music.PlayLooping();
                                }

                                isAPressed = false;
                                isWPressed = false;
                                isSPressed = false;
                                isDPressed = false;
                                if (Variables.BattleOutcome == "Won")
                                {
                                    picboxEnemy3.Visible = false;
                                    timerEnemy3Walk.Dispose();
                                }

                                else if (Variables.BattleOutcome == "Ran")
                                    picboxPlayer.Location = PlayerStartLocation;
                            }));
                            Variables.Pause = false;
                        }
                    }

                    else if (picboxPlayer.Bounds.IntersectsWith(picboxEnemy4.Bounds))
                    {
                        if (picboxEnemy4.Visible == true)
                        {
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Location = new Point(Variables.PlayerOldX, Variables.PlayerOldY)));

                            Variables.EnemyName = "Kepler Grunt";
                            Variables.EnemyHP = 400;
                            Variables.EnemyDamage = 25;

                            Variables.EnemyIcon = Resources.ZombieDown02;
                            Variables.Pause = true;

                            this.Invoke((MethodInvoker)(() =>
                            {
                                this.Hide();
                                Form PlanetCombat = new PlanetCombat();
                                PlanetCombat.ShowDialog();
                                this.Show();

                                if (Variables.SoundOn == true)
                                {
                                    Variables.Music.Stop();
                                    Variables.Music.Stream = Resources.Planetrise_v1_0_0;
                                    Variables.Music.PlayLooping();
                                }

                                isAPressed = false;
                                isWPressed = false;
                                isSPressed = false;
                                isDPressed = false;
                                if (Variables.BattleOutcome == "Won")
                                {
                                    picboxEnemy4.Visible = false;
                                    timerEnemy4Walk.Dispose();
                                }

                                else if (Variables.BattleOutcome == "Ran")
                                    picboxPlayer.Location = PlayerStartLocation;
                            }));
                            Variables.Pause = false;
                        }
                    }

                    else if (picboxPlayer.Bounds.IntersectsWith(picboxBoss.Bounds))
                    {
                        if (picboxBoss.Visible == true)
                        {
                            picboxPlayer.Invoke((MethodInvoker)(() => picboxPlayer.Location = new Point(Variables.PlayerOldX, Variables.PlayerOldY)));

                            Variables.EnemyName = "G'rok";
                            Variables.EnemyHP = 400;
                            Variables.EnemyDamage = 40;

                            Variables.EnemyIcon = Resources.SkeletonDown02;
                            Variables.Pause = true;
                            Variables.isBoss = true;

                            Form CustomMessageBox = new CustomMessageBox();
                            Variables.MessageBoxOutput = "Boss4";
                            CustomMessageBox.ShowDialog();

                            this.Invoke((MethodInvoker)(() =>
                            {
                                this.Hide();
                                Form PlanetCombat = new PlanetCombat();
                                PlanetCombat.ShowDialog();
                                this.Show();

                                if (Variables.SoundOn == true)
                                {
                                    Variables.Music.Stop();
                                    Variables.Music.Stream = Resources.Planetrise_v1_0_0;
                                    Variables.Music.PlayLooping();
                                }

                                isAPressed = false;
                                isWPressed = false;
                                isSPressed = false;
                                isDPressed = false;

                                if (Variables.BattleOutcome == "Won")
                                {
                                    picboxBoss.Visible = false;
                                    timerBossWalk.Dispose();
                                    Variables.Stage++;
                                }
                            }));
                            Variables.isBoss = false;
                            Variables.Pause = false;
                        }
                    }
                }
            }
        }

        private void timerEnemy1Walk_Tick(object obj)
        {
            if (this.Visible == true)
            {

                if (Variables.Pause == false)
                {

                    oldenemy1LocX = picboxEnemy1.Location.X;
                    oldenemy1LocY = picboxEnemy1.Location.Y;
                    enemy1LocX = picboxEnemy1.Location.X;
                    enemy1LocY = picboxEnemy1.Location.Y;

                    if (enemy1TickCounter == 0)
                    {
                        enemyRndInt = rnd.Next(1, 6);

                        if (enemyRndInt == 1)
                            enemy1Direction = "Up";
                        else if (enemyRndInt == 2 || enemyRndInt == 3)
                            enemy1Direction = "Down";
                        else if (enemyRndInt == 4)
                            enemy1Direction = "Left";
                        else if (enemyRndInt == 5 || enemyRndInt == 6)
                            enemy1Direction = "Right";

                        enemy1TickCounter++;
                    }

                    else if (enemy1TickCounter == 3)
                    {
                        enemy1TickCounter = 0;
                    }

                    else if (enemy1TickCounter == 1 || enemy1TickCounter == 2)
                    {
                        enemy1TickCounter++;
                    }

                    enemy1Image01 = "Zombie" + enemy1Direction + "01";
                    enemy1Image02 = "Zombie" + enemy1Direction + "02";
                    enemy1Image03 = "Zombie" + enemy1Direction + "03";

                    if (enemy1Anim == 0)
                    {
                        picboxEnemy1.Invoke((MethodInvoker)(() => picboxEnemy1.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemy1Image01)));
                        enemy1ReverseAnim = false;
                        enemy1Anim++;
                    }

                    else if (enemy1Anim == 1)
                    {
                        picboxEnemy1.Invoke((MethodInvoker)(() => picboxEnemy1.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemy1Image02)));

                        if (enemy1ReverseAnim == true)
                            enemy1Anim--;
                        else if (enemy1ReverseAnim == false)
                            enemy1Anim++;
                    }

                    else if (enemy1Anim == 2)
                    {
                        picboxEnemy1.Invoke((MethodInvoker)(() => picboxEnemy1.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemy1Image03)));
                        enemy1Anim--;
                        enemy1ReverseAnim = true;
                    }

                    if (enemy1Direction == "Up")
                        enemy1LocY = enemy1LocY - 3;
                    else if (enemy1Direction == "Down")
                        enemy1LocY = enemy1LocY + 3;
                    else if (enemy1Direction == "Left")
                        enemy1LocX = enemy1LocX - 3;
                    else if (enemy1Direction == "Right")
                        enemy1LocX = enemy1LocX + 3;

                    picboxEnemy1.Invoke((MethodInvoker)(() => picboxEnemy1.Location = new Point(enemy1LocX, enemy1LocY)));

                    foreach (PictureBox i in ActiveImpassables)
                    {
                        if (picboxEnemy1.Bounds.IntersectsWith(i.Bounds))
                        {
                            picboxEnemy1.Invoke((MethodInvoker)(() => picboxEnemy1.Location = new Point(oldenemy1LocX, oldenemy1LocY)));
                        }
                    }

                    if (picboxEnemy1.Bounds.IntersectsWith(EdgeBottom.Bounds) || picboxEnemy1.Bounds.IntersectsWith(EdgeLeft.Bounds) || 
                        picboxEnemy1.Bounds.IntersectsWith(EdgeRight.Bounds) || picboxEnemy1.Bounds.IntersectsWith(EdgeTop.Bounds) || 
                        picboxEnemy1.Bounds.IntersectsWith(picboxEnemy2.Bounds) || picboxEnemy1.Bounds.IntersectsWith(picboxEnemy3.Bounds) || 
                        picboxEnemy1.Bounds.IntersectsWith(picboxEnemy4.Bounds) || picboxEnemy1.Bounds.IntersectsWith(picboxBoss.Bounds) ||
                        picboxEnemy1.Bounds.IntersectsWith(picboxShip.Bounds))
                        picboxEnemy1.Invoke((MethodInvoker)(() => picboxEnemy1.Location = new Point(oldenemy1LocX, oldenemy1LocY)));
                }
            }
        }

        private void timerEnemy2Walk_Tick(object obj)
        {
            if (this.Visible == true)
            {

                if (Variables.Pause == false)
                {

                    oldenemy2LocX = picboxEnemy2.Location.X;
                    oldenemy2LocY = picboxEnemy2.Location.Y;
                    enemy2LocX = picboxEnemy2.Location.X;
                    enemy2LocY = picboxEnemy2.Location.Y;

                    if (enemy2TickCounter == 0)
                    {
                        enemyRndInt = rnd.Next(1, 6);

                        if (enemyRndInt == 1)
                            enemy2Direction = "Up";
                        else if (enemyRndInt == 2 || enemyRndInt == 3)
                            enemy2Direction = "Down";
                        else if (enemyRndInt == 4)
                            enemy2Direction = "Left";
                        else if (enemyRndInt == 5 || enemyRndInt == 6)
                            enemy2Direction = "Right";

                        enemy2TickCounter++;
                    }

                    else if (enemy2TickCounter == 3)
                    {
                        enemy2TickCounter = 0;
                    }

                    else if (enemy2TickCounter == 1 || enemy2TickCounter == 2)
                    {
                        enemy2TickCounter++;
                    }

                    enemy2Image01 = "Zombie" + enemy2Direction + "01";
                    enemy2Image02 = "Zombie" + enemy2Direction + "02";
                    enemy2Image03 = "Zombie" + enemy2Direction + "03";

                    if (enemy2Anim == 0)
                    {
                        picboxEnemy2.Invoke((MethodInvoker)(() => picboxEnemy2.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemy2Image01)));
                        enemy2ReverseAnim = false;
                        enemy2Anim++;
                    }

                    else if (enemy2Anim == 1)
                    {
                        picboxEnemy2.Invoke((MethodInvoker)(() => picboxEnemy2.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemy2Image02)));

                        if (enemy2ReverseAnim == true)
                            enemy2Anim--;
                        else if (enemy2ReverseAnim == false)
                            enemy2Anim++;
                    }

                    else if (enemy2Anim == 2)
                    {
                        picboxEnemy2.Invoke((MethodInvoker)(() => picboxEnemy2.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemy2Image03)));
                        enemy2Anim--;
                        enemy2ReverseAnim = true;
                    }

                    if (enemy2Direction == "Up")
                        enemy2LocY = enemy2LocY - 3;
                    else if (enemy2Direction == "Down")
                        enemy2LocY = enemy2LocY + 3;
                    else if (enemy2Direction == "Left")
                        enemy2LocX = enemy2LocX - 3;
                    else if (enemy2Direction == "Right")
                        enemy2LocX = enemy2LocX + 3;

                    picboxEnemy2.Invoke((MethodInvoker)(() => picboxEnemy2.Location = new Point(enemy2LocX, enemy2LocY)));

                    foreach (PictureBox i in ActiveImpassables)
                    {
                        if (picboxEnemy2.Bounds.IntersectsWith(i.Bounds))
                        {
                            picboxEnemy2.Invoke((MethodInvoker)(() => picboxEnemy2.Location = new Point(oldenemy2LocX, oldenemy2LocY)));
                        }
                    }

                    if (picboxEnemy2.Bounds.IntersectsWith(EdgeBottom.Bounds) || picboxEnemy2.Bounds.IntersectsWith(EdgeLeft.Bounds) ||
                        picboxEnemy2.Bounds.IntersectsWith(EdgeRight.Bounds) || picboxEnemy2.Bounds.IntersectsWith(EdgeTop.Bounds) || 
                        picboxEnemy2.Bounds.IntersectsWith(picboxEnemy1.Bounds) || picboxEnemy2.Bounds.IntersectsWith(picboxEnemy3.Bounds) || 
                        picboxEnemy2.Bounds.IntersectsWith(picboxEnemy4.Bounds) || picboxEnemy2.Bounds.IntersectsWith(picboxBoss.Bounds) || 
                        picboxEnemy2.Bounds.IntersectsWith(picboxShip.Bounds))
                        picboxEnemy2.Invoke((MethodInvoker)(() => picboxEnemy2.Location = new Point(oldenemy2LocX, oldenemy2LocY)));
                }
            }
        }

        private void timerEnemy3Walk_Tick(object obj)
        {
            if (this.Visible == true)
            {

                if (Variables.Pause == false)
                {

                    oldenemy3LocX = picboxEnemy3.Location.X;
                    oldenemy3LocY = picboxEnemy3.Location.Y;
                    enemy3LocX = picboxEnemy3.Location.X;
                    enemy3LocY = picboxEnemy3.Location.Y;

                    if (enemy3TickCounter == 0)
                    {
                        enemyRndInt = rnd.Next(1, 6);

                        if (enemyRndInt == 1)
                            enemy3Direction = "Up";
                        else if (enemyRndInt == 2 || enemyRndInt == 3)
                            enemy3Direction = "Down";
                        else if (enemyRndInt == 4)
                            enemy3Direction = "Left";
                        else if (enemyRndInt == 5 || enemyRndInt == 6)
                            enemy3Direction = "Right";

                        enemy3TickCounter++;
                    }

                    else if (enemy3TickCounter == 3)
                    {
                        enemy3TickCounter = 0;
                    }

                    else if (enemy3TickCounter == 1 || enemy2TickCounter == 2)
                    {
                        enemy3TickCounter++;
                    }

                    enemy3Image01 = "Zombie" + enemy3Direction + "01";
                    enemy3Image02 = "Zombie" + enemy3Direction + "02";
                    enemy3Image03 = "Zombie" + enemy3Direction + "03";

                    if (enemy3Anim == 0)
                    {
                        picboxEnemy3.Invoke((MethodInvoker)(() => picboxEnemy3.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemy3Image01)));
                        enemy3ReverseAnim = false;
                        enemy3Anim++;
                    }

                    else if (enemy3Anim == 1)
                    {
                        picboxEnemy3.Invoke((MethodInvoker)(() => picboxEnemy3.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemy3Image02)));

                        if (enemy3ReverseAnim == true)
                            enemy3Anim--;
                        else if (enemy3ReverseAnim == false)
                            enemy3Anim++;
                    }

                    else if (enemy3Anim == 2)
                    {
                        picboxEnemy3.Invoke((MethodInvoker)(() => picboxEnemy3.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemy3Image03)));
                        enemy3Anim--;
                        enemy3ReverseAnim = true;
                    }

                    if (enemy3Direction == "Up")
                        enemy3LocY = enemy3LocY - 3;
                    else if (enemy1Direction == "Down")
                        enemy3LocY = enemy3LocY + 3;
                    else if (enemy3Direction == "Left")
                        enemy3LocX = enemy3LocX - 3;
                    else if (enemy3Direction == "Right")
                        enemy3LocX = enemy3LocX + 3;

                    picboxEnemy3.Invoke((MethodInvoker)(() => picboxEnemy3.Location = new Point(enemy3LocX, enemy3LocY)));

                    foreach (PictureBox i in ActiveImpassables)
                    {
                        if (picboxEnemy3.Bounds.IntersectsWith(i.Bounds))
                        {
                            picboxEnemy3.Invoke((MethodInvoker)(() => picboxEnemy3.Location = new Point(oldenemy3LocX, oldenemy3LocY)));
                        }
                    }

                    if (picboxEnemy3.Bounds.IntersectsWith(EdgeBottom.Bounds) || picboxEnemy3.Bounds.IntersectsWith(EdgeLeft.Bounds) || 
                        picboxEnemy3.Bounds.IntersectsWith(EdgeRight.Bounds) || picboxEnemy3.Bounds.IntersectsWith(EdgeTop.Bounds) || 
                        picboxEnemy3.Bounds.IntersectsWith(picboxEnemy1.Bounds) || picboxEnemy3.Bounds.IntersectsWith(picboxEnemy2.Bounds) || 
                        picboxEnemy3.Bounds.IntersectsWith(picboxEnemy4.Bounds) || picboxEnemy3.Bounds.IntersectsWith(picboxBoss.Bounds) || 
                        picboxEnemy3.Bounds.IntersectsWith(picboxShip.Bounds))
                        picboxEnemy3.Invoke((MethodInvoker)(() => picboxEnemy3.Location = new Point(oldenemy3LocX, oldenemy3LocY)));
                }
            }
        }

        private void timerEnemy4Walk_Tick(object obj)
        {
            if (this.Visible == true)
            {

                if (Variables.Pause == false)
                {

                    oldenemy4LocX = picboxEnemy4.Location.X;
                    oldenemy4LocY = picboxEnemy4.Location.Y;
                    enemy4LocX = picboxEnemy4.Location.X;
                    enemy4LocY = picboxEnemy4.Location.Y;

                    if (enemy4TickCounter == 0)
                    {
                        enemyRndInt = rnd.Next(1, 6);

                        if (enemyRndInt == 1)
                            enemy4Direction = "Up";
                        else if (enemyRndInt == 2 || enemyRndInt == 3)
                            enemy4Direction = "Down";
                        else if (enemyRndInt == 4)
                            enemy4Direction = "Left";
                        else if (enemyRndInt == 5 || enemyRndInt == 6)
                            enemy4Direction = "Right";

                        enemy4TickCounter++;
                    }

                    else if (enemy4TickCounter == 3)
                    {
                        enemy4TickCounter = 0;
                    }

                    else if (enemy4TickCounter == 1 || enemy4TickCounter == 2)
                    {
                        enemy4TickCounter++;
                    }

                    enemy4Image01 = "Zombie" + enemy4Direction + "01";
                    enemy4Image02 = "Zombie" + enemy4Direction + "02";
                    enemy4Image03 = "Zombie" + enemy4Direction + "03";

                    if (enemy4Anim == 0)
                    {
                        picboxEnemy4.Invoke((MethodInvoker)(() => picboxEnemy4.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemy4Image01)));
                        enemy4ReverseAnim = false;
                        enemy4Anim++;
                    }

                    else if (enemy4Anim == 1)
                    {
                        picboxEnemy4.Invoke((MethodInvoker)(() => picboxEnemy4.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemy4Image02)));

                        if (enemy4ReverseAnim == true)
                            enemy4Anim--;
                        else if (enemy4ReverseAnim == false)
                            enemy4Anim++;
                    }

                    else if (enemy4Anim == 2)
                    {
                        picboxEnemy4.Invoke((MethodInvoker)(() => picboxEnemy4.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemy4Image03)));
                        enemy4Anim--;
                        enemy4ReverseAnim = true;
                    }

                    if (enemy4Direction == "Up")
                        enemy4LocY = enemy4LocY - 3;
                    else if (enemy4Direction == "Down")
                        enemy4LocY = enemy4LocY + 3;
                    else if (enemy4Direction == "Left")
                        enemy4LocX = enemy4LocX - 3;
                    else if (enemy4Direction == "Right")
                        enemy4LocX = enemy4LocX + 3;

                    picboxEnemy4.Invoke((MethodInvoker)(() => picboxEnemy4.Location = new Point(enemy4LocX, enemy4LocY)));

                    foreach (PictureBox i in ActiveImpassables)
                    {
                        if (picboxEnemy4.Bounds.IntersectsWith(i.Bounds))
                        {
                            picboxEnemy4.Invoke((MethodInvoker)(() => picboxEnemy4.Location = new Point(oldenemy4LocX, oldenemy4LocY)));
                        }
                    }

                    if (picboxEnemy4.Bounds.IntersectsWith(EdgeBottom.Bounds) || picboxEnemy4.Bounds.IntersectsWith(EdgeLeft.Bounds) || 
                        picboxEnemy4.Bounds.IntersectsWith(EdgeRight.Bounds) || picboxEnemy4.Bounds.IntersectsWith(EdgeTop.Bounds) || 
                        picboxEnemy4.Bounds.IntersectsWith(picboxEnemy1.Bounds) || picboxEnemy4.Bounds.IntersectsWith(picboxEnemy2.Bounds) || 
                        picboxEnemy4.Bounds.IntersectsWith(picboxEnemy3.Bounds) || picboxEnemy4.Bounds.IntersectsWith(picboxBoss.Bounds) || 
                        picboxEnemy4.Bounds.IntersectsWith(picboxShip.Bounds))
                        picboxEnemy4.Invoke((MethodInvoker)(() => picboxEnemy4.Location = new Point(oldenemy4LocX, oldenemy4LocY)));
                }
            }
        }

        private void timerBossWalk_Tick(object obj)
        {
            if (this.Visible == true)
            {

                if (Variables.Pause == false)
                {

                    oldenemyBossLocX = picboxBoss.Location.X;
                    oldenemyBossLocY = picboxBoss.Location.Y;
                    enemyBossLocX = picboxBoss.Location.X;
                    enemyBossLocY = picboxBoss.Location.Y;

                    if (enemyBossTickCounter == 0)
                    {
                        enemyRndInt = rnd.Next(1, 6);

                        if (enemyRndInt == 1)
                            enemyBossDirection = "Up";
                        else if (enemyRndInt == 2 || enemyRndInt == 3)
                            enemyBossDirection = "Down";
                        else if (enemyRndInt == 4)
                            enemyBossDirection = "Left";
                        else if (enemyRndInt == 5 || enemyRndInt == 6)
                            enemyBossDirection = "Right";

                        enemyBossTickCounter++;
                    }

                    else if (enemyBossTickCounter == 3)
                    {
                        enemyBossTickCounter = 0;
                    }

                    else if (enemyBossTickCounter == 1 || enemyBossTickCounter == 2)
                    {
                        enemyBossTickCounter++;
                    }

                    enemyBossImage01 = "Skeleton" + enemyBossDirection + "01";
                    enemyBossImage02 = "Skeleton" + enemyBossDirection + "02";
                    enemyBossImage03 = "Skeleton" + enemyBossDirection + "03";

                    if (enemyBossAnim == 0)
                    {
                        picboxBoss.Invoke((MethodInvoker)(() => picboxBoss.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemyBossImage01)));
                        enemyBossReverseAnim = false;
                        enemyBossAnim++;
                    }

                    else if (enemyBossAnim == 1)
                    {
                        picboxBoss.Invoke((MethodInvoker)(() => picboxBoss.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemyBossImage02)));

                        if (enemyBossReverseAnim == true)
                            enemyBossAnim--;
                        else if (enemyBossReverseAnim == false)
                            enemyBossAnim++;
                    }

                    else if (enemyBossAnim == 2)
                    {
                        picboxBoss.Invoke((MethodInvoker)(() => picboxBoss.Image = (Image)Properties.Resources.ResourceManager.GetObject(enemyBossImage03)));
                        enemyBossAnim--;
                        enemyBossReverseAnim = true;
                    }

                    if (enemyBossDirection == "Up")
                        enemyBossLocY = enemyBossLocY - 3;
                    else if (enemyBossDirection == "Down")
                        enemyBossLocY = enemyBossLocY + 3;
                    else if (enemyBossDirection == "Left")
                        enemyBossLocX = enemyBossLocX - 3;
                    else if (enemyBossDirection == "Right")
                        enemyBossLocX = enemyBossLocX + 3;

                    picboxBoss.Invoke((MethodInvoker)(() => picboxBoss.Location = new Point(enemyBossLocX, enemyBossLocY)));

                    foreach (PictureBox i in ActiveImpassables)
                    {
                        if (picboxBoss.Bounds.IntersectsWith(i.Bounds))
                        {
                            picboxBoss.Invoke((MethodInvoker)(() => picboxBoss.Location = new Point(oldenemyBossLocX, oldenemyBossLocY)));
                        }
                    }

                    if (picboxBoss.Bounds.IntersectsWith(EdgeBottom.Bounds) || picboxBoss.Bounds.IntersectsWith(EdgeLeft.Bounds) || 
                        picboxBoss.Bounds.IntersectsWith(EdgeRight.Bounds) || picboxBoss.Bounds.IntersectsWith(EdgeTop.Bounds) || 
                        picboxBoss.Bounds.IntersectsWith(picboxEnemy1.Bounds) || picboxBoss.Bounds.IntersectsWith(picboxEnemy2.Bounds) || 
                        picboxBoss.Bounds.IntersectsWith(picboxEnemy3.Bounds) || picboxBoss.Bounds.IntersectsWith(picboxEnemy4.Bounds) || 
                        picboxBoss.Bounds.IntersectsWith(picboxShip.Bounds))
                        picboxBoss.Invoke((MethodInvoker)(() => picboxBoss.Location = new Point(oldenemyBossLocX, oldenemyBossLocY)));
                }
            }
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
