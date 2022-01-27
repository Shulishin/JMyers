using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Space_Game.Properties;

namespace Space_Game
{
    public partial class PlanetCombat : Form
    {
        string PlayerAction;

        Random rnd = new Random();

        int EnemyAIAction, EnemyAIDodgeChance, PlayerRandom, CurrentTimerValue = 5, EndWait = 1, EnemyHPPercent, SpecialMeter, HealZoneTurns, VolleyTurns, AmplifyTurns;

        bool TimersRunning, Dead, HealZoneActive, VolleyActive, AmplifyActive;

        System.Threading.Timer timerTurn, timerEndCountdown;

        double HealAmount;

        List<Form> DisposeForms = new List<Form>();


        public PlanetCombat()
        {
            InitializeComponent();
        }

        private void PlanetCombat_Load(object sender, EventArgs e)
        {
            Dead = false;
            PlayerAction = null;
            HealZoneActive = false;
            VolleyActive = false;

            if (Variables.SoundOn == true)
            {
                Variables.Music.Stop();
                Variables.Music.Stream = Resources.Fly;
                Variables.Music.PlayLooping();
            }

            switch (Variables.PlanetCombatBG)
            {
                case "AlphaCenturiCombatMap":
                    this.BackgroundImage = Resources.AlphaCenturiCombatMap;
                    break;

                case "PolluxCombatMap":
                    this.BackgroundImage = Resources.PolluxCombatMap;
                    break;
                case "FormalhautCombatMap":
                    this.BackgroundImage = Resources.FormalhautCombatMap;
                    break;
                case "KeplerCombatMap":
                    this.BackgroundImage = Resources.KeplerCombatMap;
                    break;
                case "CetusCombatMap":
                    this.BackgroundImage = Resources.CetusCombatMap;
                    break;
                case "PyxisCombatMap":
                    this.BackgroundImage = Resources.PyxisCombatMap;
                    break;
            }

            btnSpecial.Text = Variables.Special;

            if (Variables.isBoss == true)
            {
                btnRun.BackColor = Color.DimGray;
                Variables.EnemyDodgeChance = 50;
            }

            else
            {
                btnRun.BackColor = Color.Black;
                Variables.EnemyDodgeChance = 35;
            }

            SpecialMeter = 0;

            switch (Variables.Class)
            {
                case "Ninja":
                    prgbarSpecialMeter.ForeColor = Color.Orange;
                    break;
                case "Warrior":
                    prgbarSpecialMeter.ForeColor = Color.Red;
                    break;
                case "Magician":
                    prgbarSpecialMeter.ForeColor = Color.Blue;
                    prgbarSpecialMeter.Style = ProgressBarStyle.Continuous;
                    break;
                case "Healer":
                    prgbarSpecialMeter.ForeColor = Color.Blue;
                    prgbarSpecialMeter.Style = ProgressBarStyle.Continuous;
                    break;
                case "Ranger":
                    prgbarSpecialMeter.ForeColor = Color.Orange;
                    break;
            }

            btnSpecial.Font = new Font(Variables.CustomFont.Families[0], btnSpecial.Font.Size);
            btnFight.Font = new Font(Variables.CustomFont.Families[0], btnFight.Font.Size);
            btnRun.Font = new Font(Variables.CustomFont.Families[0], btnRun.Font.Size);
            btnDodge.Font = new Font(Variables.CustomFont.Families[0], btnDodge.Font.Size);
            lblSpecialMeter.Font = new Font(Variables.CustomFont.Families[0], lblSpecialMeter.Font.Size);
            lblOutput.Font = new Font(Variables.CustomFont.Families[0], lblOutput.Font.Size);
            lblEnemyName.Font = new Font(Variables.CustomFont.Families[0], lblEnemyName.Font.Size);
            lblDamage.Font = new Font(Variables.CustomFont.Families[0], lblDamage.Font.Size);
            lblDmgValue.Font = new Font(Variables.CustomFont.Families[0], lblDmgValue.Font.Size);
            lblDodge.Font = new Font(Variables.CustomFont.Families[0], lblDodge.Font.Size);
            lblDodgeValue.Font = new Font(Variables.CustomFont.Families[0], lblDodgeValue.Font.Size);
            lblEDamage.Font = new Font(Variables.CustomFont.Families[0], lblEDamage.Font.Size);
            lblEDmgValue.Font = new Font(Variables.CustomFont.Families[0], lblEDmgValue.Font.Size);
            lblEHPValue.Font = new Font(Variables.CustomFont.Families[0], lblEHPValue.Font.Size);
            lblEnemyHp.Font = new Font(Variables.CustomFont.Families[0], lblEnemyHp.Font.Size);
            lblEnemyName.Font = new Font(Variables.CustomFont.Families[0], lblEnemyName.Font.Size);
            lblHPValue.Font = new Font(Variables.CustomFont.Families[0], lblHPValue.Font.Size);
            lblMove.Font = new Font(Variables.CustomFont.Families[0], lblMove.Font.Size);
            lblMoveSelected.Font = new Font(Variables.CustomFont.Families[0], lblMoveSelected.Font.Size);
            lblPlayerHP.Font = new Font(Variables.CustomFont.Families[0], lblPlayerHP.Font.Size);
            lblPlayerName.Font = new Font(Variables.CustomFont.Families[0], lblPlayerName.Font.Size);
            lblTimer.Font = new Font(Variables.CustomFont.Families[0], lblTimer.Font.Size);
            lblTimerValue.Font = new Font(Variables.CustomFont.Families[0], lblTimerValue.Font.Size);

            switch (Variables.Class)
            {
                case ("Ninja"):
                    btnFight.Text = "Attack";
                    break;
                case ("Warrior"):
                    btnFight.Text = "Attack";
                    break;
                case ("Magician"):
                    btnFight.Text = "Fireball";
                    break;
                case ("Healer"):
                    btnFight.Text = "Smite";
                    break;
                case ("Ranger"):
                    btnFight.Text = "Attack";
                    break;
            }
            lblEnemyName.Text = Variables.EnemyName;
            lblPlayerName.Text = Variables.Class;
            lblDmgValue.Text = Variables.PlayerDamage.ToString();
            lblDodgeValue.Text = Variables.PlayerDodgeChance + "%";
            lblEDmgValue.Text = Variables.EnemyDamage.ToString();
            lblEDodgeValue.Text = Variables.EnemyDodgeChance.ToString() +"%";
            lblOutput.Text = "Pick a move: -------->";
            lblMoveSelected.Text = "None";
            lblHPValue.Text = Variables.PlayerHP.ToString();
            lblEHPValue.Text = Variables.EnemyHP.ToString();
            prgbarEnemyHP.Maximum = Variables.EnemyHP;
            prgbarPlayerHP.Maximum = Variables.PlayerHP;
            prgbarEnemyHP.Value = Variables.EnemyHP;
            prgbarPlayerHP.Value = Variables.PlayerHP;
            Variables.BattleOutcome = null;
            picboxPlayer.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[12]);
            picboxEnemy.Image = Variables.EnemyIcon;

            timerTurn = new System.Threading.Timer(new TimerCallback(timerTurn_Tick), null, Timeout.Infinite, Timeout.Infinite);
            timerEndCountdown = new System.Threading.Timer(new TimerCallback(timerEndCountdown_Tick), null, Timeout.Infinite, Timeout.Infinite);

            lblTimerValue.Text = "5";
        }

        private void BeginTimers()
        {
            timerTurn = new System.Threading.Timer(new TimerCallback(timerTurn_Tick), null, 1000, 1000);
            lblOutput.Text = "The battle has begun!";
            TimersRunning = true;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (Variables.isBoss == false)
            {
                if (Dead == false)
                {
                    if (Variables.SoundOn == true)
                    {
                        Variables.Music.Stop();
                        Variables.Music.Stream = Resources.Planetrise_v1_0_0;
                        Variables.Music.PlayLooping();
                    }
                    if (TimersRunning == true)
                        timerTurn.Dispose();

                    timerEndCountdown.Dispose();
                    this.Dispose();
                    Variables.BattleOutcome = "Ran";
                }
            }

            else if (Variables.isBoss == true)
                lblOutput.Text = "You cannot run from a boss fight!";
        }

        private void btnFight_Click(object sender, EventArgs e)
        {
            if (TimersRunning == false)
                BeginTimers();

            PlayerAction = "Attack";

            lblMoveSelected.Text = btnFight.Text;
        }

        private void btnDodge_Click(object sender, EventArgs e)
        {
            if (TimersRunning == false)
                BeginTimers();

            PlayerAction = "Dodge";
            lblMoveSelected.Text = PlayerAction;
        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            if (TimersRunning == false)
                BeginTimers();

            if (HealZoneActive == true || VolleyActive == true || AmplifyActive == true)
                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "'" + Variables.Special + "' is already active!\nChoose another move."));

            if (SpecialMeter >= 5)
            {
                PlayerAction = "Special";
                lblMoveSelected.Text = btnSpecial.Text;
            }

            else
            {
                switch (Variables.Class)
                {
                    case "Ninja":
                        lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "'Backstab' isn't ready yet!\nYou must dodge more."));
                        break;
                    case "Warrior":
                        lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "'Reflect' isn't ready yet!\nYou must be attacked more."));
                        break;
                    case "Magician":
                        lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "'Amplify' isn't ready yet!\nYou must wait more turns."));
                        break;
                    case "Healer":
                        lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "'Healzone' isn't ready yet!\nYou must wait more turns."));
                        break;
                    case "Ranger":
                        lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "'Volley' isn't ready yet!\nYou must attack more."));
                        break;
                }
            }
        }

        private void timerTurn_Tick(object obj)
        {
            CurrentTimerValue--;

            lblTimerValue.Invoke((MethodInvoker)(() => lblTimerValue.Text = CurrentTimerValue.ToString()));

            if (CurrentTimerValue == 2)
            {
                if (HealZoneActive == true || VolleyActive == true || AmplifyActive == true)
                {
                    if (HealZoneTurns == 4)
                    {
                        lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "'Healzone' has been active for 3 turns.\nThe effect withers away."));
                        HealZoneActive = false;
                    }

                    if (VolleyTurns == 4)
                    {
                        lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "'Volley' has been active for 3 turns.\nYou return to melee range."));
                        VolleyActive = false;
                    }

                    if (AmplifyTurns == 4)
                    {
                        lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "'Amplify' has been active for 3 turns.\nThe effect withers away."));
                        AmplifyActive = false;
                    }

                    else
                        lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = ""));
                }
                else
                    lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = ""));
            }

            else if (CurrentTimerValue == 0)
            {
                CurrentTimerValue = 5;

                EnemyAIAction = rnd.Next(1, 4);

                EnemyHPPercent = (prgbarEnemyHP.Value / prgbarEnemyHP.Maximum) * 100;

                if (VolleyActive == true && PlayerAction == "Attack")
                {
                    if (prgbarEnemyHP.Value < Variables.PlayerDamage * 1.5)
                        prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));

                    else
                        prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.PlayerDamage * (int)1.5));

                    lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "'Volley' is active, letting you attack from range.\nYou deal extra damage!"));

                    VolleyTurns++;

                }

                else if (AmplifyActive == true && PlayerAction == "Attack")
                {
                    if (EnemyHPPercent <= 30)
                    {
                        if (EnemyAIAction == 1)
                        {
                            if (prgbarEnemyHP.Value < Variables.PlayerDamage * (int)3.5)
                                prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));

                            else if (prgbarEnemyHP.Value >= Variables.PlayerDamage * (int)3.5)
                                prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.PlayerDamage + 5));

                            if (prgbarPlayerHP.Value < Variables.EnemyDamage + 5)
                                prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value = 0));

                            else if (prgbarPlayerHP.Value >= Variables.EnemyDamage + 5)
                                prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value -= Variables.EnemyDamage + 5));

                            lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You both attack; enemy is affected by 'Amplify'!\nYou both take extra damage!"));
                        }

                        else
                        {
                            EnemyAIDodgeChance = rnd.Next(1, 2);

                            if (EnemyAIDodgeChance == 1)
                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You attack!\nThe enemy dodges!"));
                            else if (EnemyAIDodgeChance == 2)
                            {
                                if (prgbarEnemyHP.Value < Variables.PlayerDamage * (int)3.5)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));
                                else if (prgbarEnemyHP.Value >= Variables.PlayerDamage * 5)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.PlayerDamage));

                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You attack; enemy is affected by 'Amplify'!\nThe enemy's attempted dodge fails, taking damage!"));

                            }
                        }
                    }

                    else
                    {
                        if (EnemyAIAction == 1 || EnemyAIAction == 2 || EnemyAIAction == 3)
                        {
                            if (prgbarEnemyHP.Value < Variables.PlayerDamage * (int)3.5)
                                prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));

                            else if (prgbarEnemyHP.Value >= Variables.PlayerDamage * (int)3.5)
                                prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.PlayerDamage + 5));

                            if (prgbarPlayerHP.Value < Variables.EnemyDamage + 5)
                                prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value = 0));

                            else if (prgbarPlayerHP.Value >= Variables.EnemyDamage + 5)
                                prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value -= Variables.EnemyDamage + 5));

                            lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You both attack; enemy is affected by 'Amplify'!\nYou both take extra damage!"));
                        }

                        else
                        {
                            EnemyAIDodgeChance = rnd.Next(1, 2);

                            if (EnemyAIDodgeChance == 1)
                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You attack!\nThe enemy dodges!"));
                            else if (EnemyAIDodgeChance == 2)
                            {
                                if (prgbarEnemyHP.Value < Variables.PlayerDamage * (int)3.5)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));
                                else if (prgbarEnemyHP.Value >= Variables.PlayerDamage * 5)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.PlayerDamage));

                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You attack; enemy is affected by 'Amplify'!\nThe enemy's attempted dodge fails, taking damage!"));

                            }
                        }
                    }
                    AmplifyTurns++;
                }

                else if (EnemyHPPercent <= 30) //enemy hp is less than 30%
                {
                    if (EnemyAIAction == 1) //enemy action is attack
                    {
                        if (HealZoneActive == true)
                        {
                            HealAmount = Variables.EnemyDamage * 0.9;
                            prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value += (int)(prgbarPlayerHP.Value + HealAmount)));
                            HealZoneTurns++;
                        }

                        if (PlayerAction == "Attack")
                        {
                            if (prgbarEnemyHP.Value < Variables.PlayerDamage + 5)
                                prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));

                            else if (prgbarEnemyHP.Value >= Variables.PlayerDamage + 5)
                                prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.PlayerDamage + 5));

                            if (prgbarPlayerHP.Value < Variables.EnemyDamage + 5)
                                prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value = 0));

                            else if (prgbarPlayerHP.Value >= Variables.EnemyDamage + 5)
                                prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value -= Variables.EnemyDamage + 5));

                            lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You both attack!\nYou both take extra damage!"));

                            if (Variables.Class == "Warrior")
                                SpecialMeter++;
                            else if (Variables.Class == "Ranger" && VolleyActive == false)
                                SpecialMeter++;
                        }

                        else if (PlayerAction == "Dodge")
                        {
                            PlayerRandom = rnd.Next(0, 100);

                            if (PlayerRandom <= Variables.PlayerDodgeChance)
                            {
                                if (prgbarPlayerHP.Value < Variables.EnemyDamage)
                                    prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value = 0));

                                else if (prgbarPlayerHP.Value >= Variables.EnemyDamage)
                                    prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value -= Variables.EnemyDamage));

                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "Enemy attacks!\nYour dodge failed, taking damage!"));
                                if (Variables.Class == "Warrior")
                                    SpecialMeter++;
                            }

                            else if (PlayerRandom > Variables.PlayerDodgeChance)
                            {
                                if (Variables.Class == "Ninja")
                                    SpecialMeter++;

                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "Enemy attacks!\nYou dodge!"));
                            }
                        }

                        else if (PlayerAction == "Special")
                        {
                            SpecialMeter = 0;
                            prgbarSpecialMeter.Invoke((MethodInvoker)(() => prgbarSpecialMeter.Value = 0));

                            if (Variables.Special == "Backstab")
                            {
                                if (prgbarEnemyHP.Value < Variables.PlayerDamage * 3)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));
                                else if (prgbarEnemyHP.Value >= Variables.PlayerDamage * 2)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.PlayerDamage * 2));

                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You used 'Backstab'!\nThe enemy takes a deadly blow!"));
                                SpecialMeter = 0;
                            }

                            else if (Variables.Special == "Reflect")
                            {
                                if (prgbarEnemyHP.Value < Variables.EnemyDamage * 3 && prgbarPlayerHP.Value < Variables.EnemyDamage)
                                {
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));
                                    prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value = 0));
                                }

                                else if (prgbarPlayerHP.Value < Variables.EnemyDamage)
                                    prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value = 0));

                                else if (prgbarEnemyHP.Value < Variables.EnemyDamage * 3)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));

                                else if (prgbarEnemyHP.Value >= Variables.EnemyDamage * 3)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.EnemyDamage * 3));

                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You used 'Reflect'!\nThe enemy attacks, taking deadly damage to itself too!"));
                                SpecialMeter = 0;
                            }

                            else if (Variables.Special == "Amplify")
                            {
                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You cast 'Amplify'!\nThe enemy now takes additional damage from attacks for 3 turns."));
                                AmplifyActive = true;
                                AmplifyTurns = 0;
                            }

                            else if (Variables.Special == "Healzone")
                            {
                                if (prgbarPlayerHP.Value + Variables.EnemyDamage >= prgbarPlayerHP.Value)
                                {
                                    prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Maximum = prgbarPlayerHP.Value + Variables.EnemyDamage));
                                }

                                prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value = prgbarPlayerHP.Value + Variables.EnemyDamage));
                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You cast 'Healzone'!\nEnemy attacks now heal you for 3 turns."));
                                HealZoneTurns = 0;
                                HealZoneActive = true;
                            }

                            else if (Variables.Special == "Volley")
                            {
                                if (prgbarEnemyHP.Value < Variables.PlayerDamage * 1.5)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));

                                else
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.PlayerDamage * (int)1.5));

                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You activate 'Volley'!\nYou now attack from range for 3 turns."));
                                VolleyActive = true;
                                VolleyTurns = 0;
                            }
                        }

                        else if (PlayerAction == null)
                        {
                            if (prgbarPlayerHP.Value < Variables.EnemyDamage + 10)
                                prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value = 0));

                            else if (prgbarPlayerHP.Value >= Variables.EnemyDamage + 10)
                                prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value -= Variables.EnemyDamage + 10));

                            lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "Enemy attacks!\nYou didn't select anything; enemy deals a devastating blow!"));

                            if (Variables.Class == "Warrior")
                                SpecialMeter++;
                        }
                    }

                    else if (EnemyAIAction == 2 || EnemyAIAction == 3 || EnemyAIAction == 4)
                    {
                        EnemyAIDodgeChance = rnd.Next(1, 2);

                        if (PlayerAction == "Attack")
                        {
                            if (EnemyAIDodgeChance == 1)
                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You attack!\nThe enemy dodges!"));
                            else if (EnemyAIDodgeChance == 2)
                            {
                                if (prgbarEnemyHP.Value < Variables.PlayerDamage)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));
                                else if (prgbarEnemyHP.Value >= Variables.PlayerDamage)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.PlayerDamage));

                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You attack!\nThe enemy's attempted dodge fails, taking damage!"));

                                if (Variables.Class == "Ranger")
                                    SpecialMeter++;
                            }
                        }
                        else if (PlayerAction == "Dodge")
                        {
                            lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You both dodge!\nNothing happens..."));
                        }

                        else if (PlayerAction == "Special")
                        {
                            SpecialMeter = 0;
                            prgbarSpecialMeter.Invoke((MethodInvoker)(() => prgbarSpecialMeter.Value = 0));

                            if (Variables.Special == "Backstab")
                            {
                                if (prgbarEnemyHP.Value < Variables.PlayerDamage * 3)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));
                                else if (prgbarEnemyHP.Value >= Variables.PlayerDamage * 2)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.PlayerDamage * 2));

                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You used 'Backstab'!\nThe enemy takes a deadly blow!"));
                                SpecialMeter = 0;
                            }

                            else if (Variables.Special == "Reflect")
                            {
                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You used 'Reflect'!\nThe enemy attempts to dodge. Nothing happens..."));
                            }

                            else if (Variables.Special == "Amplify")
                            {
                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You cast 'Amplify'!\nThe enemy now takes additional damage from attacks for 3 turns."));
                                AmplifyActive = true;
                                AmplifyTurns = 0;
                            }

                            else if (Variables.Special == "Healzone")
                            {
                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You cast 'Healzone'!\nEnemy attacks now heal you for 3 turns."));
                                HealZoneTurns = 0;
                                HealZoneActive = true;
                            }

                            else if (Variables.Special == "Volley")
                            {
                                if (prgbarEnemyHP.Value < Variables.PlayerDamage * 1.5)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));

                                else
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.PlayerDamage * (int)1.5));

                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You activate 'Volley'!\nYou now attack from range for 3 turns."));
                                VolleyActive = true;
                                VolleyTurns = 0;
                            }
                        }

                        else if (PlayerAction == null)
                        {
                            if (prgbarPlayerHP.Value < Variables.EnemyDamage + 10)
                                prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value = 0));
                            else if (prgbarPlayerHP.Value >= Variables.EnemyDamage + 10)
                                prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value -= Variables.EnemyDamage + 10));

                            lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "Enemy attacks!\nYou didn't select anything; enemy deals massive damage!"));
                        }
                    }
                }

                else if (EnemyHPPercent > 30) //enemy hp more than 30%
                {
                    if (EnemyAIAction == 1 || EnemyAIAction == 2 || EnemyAIAction == 3) //enemy action is attack
                    {
                        if (HealZoneActive == true)
                        {
                            HealAmount = Variables.EnemyDamage * 0.9;
                            prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value += (int)(prgbarPlayerHP.Value + HealAmount)));
                            HealZoneTurns++;
                        }

                        if (PlayerAction == "Attack")
                        {
                            if (prgbarEnemyHP.Value < Variables.PlayerDamage + 5)
                                prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));

                            else if (prgbarEnemyHP.Value >= Variables.PlayerDamage + 5)
                                prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.PlayerDamage + 5));

                            if (prgbarPlayerHP.Value < Variables.EnemyDamage + 5)
                                prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value = 0));

                            else if (prgbarPlayerHP.Value >= Variables.EnemyDamage + 5)
                                prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value -= Variables.EnemyDamage + 5));

                            lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You both attack!\nYou both take extra damage!"));

                            if (Variables.Class == "Warrior")
                                SpecialMeter++;
                            else if (Variables.Class == "Ranger" && VolleyActive == false)
                                SpecialMeter++;
                        }

                        else if (PlayerAction == "Dodge")
                        {
                            PlayerRandom = rnd.Next(0, 100);

                            if (PlayerRandom <= Variables.PlayerDodgeChance)
                            {
                                if (prgbarPlayerHP.Value < Variables.EnemyDamage)
                                    prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value = 0));

                                else if (prgbarPlayerHP.Value >= Variables.EnemyDamage)
                                    prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value -= Variables.EnemyDamage));

                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "Enemy attacks!\nYour dodge failed, taking damage!"));
                                if (Variables.Class == "Warrior")
                                    SpecialMeter++;
                            }

                            else if (PlayerRandom > Variables.PlayerDodgeChance)
                            {
                                if (Variables.Class == "Ninja")
                                    SpecialMeter++;

                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "Enemy attacks!\nYou dodge!"));
                            }
                        }

                        else if (PlayerAction == "Special")
                        {
                            SpecialMeter = 0;
                            prgbarSpecialMeter.Invoke((MethodInvoker)(() => prgbarSpecialMeter.Value = 0));

                            if (Variables.Special == "Backstab")
                            {
                                if (prgbarEnemyHP.Value < Variables.PlayerDamage * 3)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));
                                else if (prgbarEnemyHP.Value >= Variables.PlayerDamage * 2)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.PlayerDamage * 2));

                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You used 'Backstab'!\nThe enemy takes a deadly blow!"));
                                SpecialMeter = 0;
                            }

                            else if (Variables.Special == "Reflect")
                            {
                                if (prgbarEnemyHP.Value < Variables.EnemyDamage * 3 && prgbarPlayerHP.Value < Variables.EnemyDamage)
                                {
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));
                                    prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value = 0));
                                }

                                else if (prgbarPlayerHP.Value < Variables.EnemyDamage)
                                    prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value = 0));

                                else if (prgbarEnemyHP.Value < Variables.EnemyDamage * 3)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));

                                else if (prgbarEnemyHP.Value >= Variables.EnemyDamage * 3)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.EnemyDamage * 3));

                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You used 'Reflect'!\nThe enemy attacks, taking deadly damage to itself too!"));
                                SpecialMeter = 0;
                            }

                            else if (Variables.Special == "Amplify")
                            {
                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You cast 'Amplify'!\nThe enemy now takes additional damage from attacks for 3 turns."));
                                AmplifyActive = true;
                                AmplifyTurns = 0;
                            }

                            else if (Variables.Special == "Healzone")
                            {
                                if (prgbarPlayerHP.Value + Variables.EnemyDamage >= prgbarPlayerHP.Value)
                                {
                                    prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Maximum = prgbarPlayerHP.Value + Variables.EnemyDamage));
                                }

                                prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value = prgbarPlayerHP.Value + Variables.EnemyDamage));
                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You cast 'Healzone'!\nEnemy attacks now heal you for 3 turns."));
                                HealZoneTurns = 0;
                                HealZoneActive = true;
                            }

                            else if (Variables.Special == "Volley")
                            {
                                if (prgbarEnemyHP.Value < Variables.PlayerDamage * 1.5)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));

                                else
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.PlayerDamage * (int)1.5));

                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You activate 'Volley'!\nYou now attack from range for 3 turns."));
                                VolleyActive = true;
                                VolleyTurns = 0;
                            }
                        }

                        else if (PlayerAction == null)
                        {
                            if (prgbarPlayerHP.Value < Variables.EnemyDamage + 10)
                                prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value = 0));

                            else if (prgbarPlayerHP.Value >= Variables.EnemyDamage + 10)
                                prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value -= Variables.EnemyDamage + 10));

                            lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "Enemy attacks!\nYou didn't select anything; enemy deals a devastating blow!"));

                            if (Variables.Class == "Warrior")
                                SpecialMeter++;
                        }
                    }

                    else if (EnemyAIAction == 4)
                    {
                        EnemyAIDodgeChance = rnd.Next(1, 2);

                        if (PlayerAction == "Attack")
                        {
                            if (EnemyAIDodgeChance == 1)
                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You attack!\nThe enemy dodges!"));
                            else if (EnemyAIDodgeChance == 2)
                            {
                                if (prgbarEnemyHP.Value < Variables.PlayerDamage)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));
                                else if (prgbarEnemyHP.Value >= Variables.PlayerDamage)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.PlayerDamage));

                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You attack!\nThe enemy's attempted dodge fails, taking damage!"));

                                if (Variables.Class == "Ranger")
                                    SpecialMeter++;
                            }
                        }
                        else if (PlayerAction == "Dodge")
                        {
                            lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You both dodge!\nNothing happens..."));
                        }

                        else if (PlayerAction == "Special")
                        {
                            SpecialMeter = 0;
                            prgbarSpecialMeter.Invoke((MethodInvoker)(() => prgbarSpecialMeter.Value = 0));

                            if (Variables.Special == "Backstab")
                            {
                                if (prgbarEnemyHP.Value < Variables.PlayerDamage * 3)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));
                                else if (prgbarEnemyHP.Value >= Variables.PlayerDamage * 2)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.PlayerDamage * 2));

                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You used 'Backstab'!\nThe enemy takes a deadly blow!"));
                                SpecialMeter = 0;
                            }

                            else if (Variables.Special == "Reflect")
                            {
                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You used 'Reflect'!\nThe enemy attempts to dodge. Nothing happens..."));
                            }

                            else if (Variables.Special == "Amplify")
                            {
                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You cast 'Amplify'!\nThe enemy now takes additional damage from attacks for 3 turns."));
                                AmplifyActive = true;
                                AmplifyTurns = 0;
                            }

                            else if (Variables.Special == "Healzone")
                            {
                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You cast 'Healzone'!\nEnemy attacks now heal you for 3 turns."));
                                HealZoneTurns = 0;
                                HealZoneActive = true;
                            }

                            else if (Variables.Special == "Volley")
                            {
                                if (prgbarEnemyHP.Value < Variables.PlayerDamage * 1.5)
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value = 0));

                                else
                                    prgbarEnemyHP.Invoke((MethodInvoker)(() => prgbarEnemyHP.Value -= Variables.PlayerDamage * (int)1.5));

                                lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You activate 'Volley'!\nYou now attack from range for 3 turns."));
                                VolleyActive = true;
                                VolleyTurns = 0;
                            }
                        }

                        else if (PlayerAction == null)
                        {
                            if (prgbarPlayerHP.Value < Variables.EnemyDamage + 10)
                                prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value = 0));
                            else if (prgbarPlayerHP.Value >= Variables.EnemyDamage + 10)
                                prgbarPlayerHP.Invoke((MethodInvoker)(() => prgbarPlayerHP.Value -= Variables.EnemyDamage + 10));

                            lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "Enemy attacks!\nYou didn't select anything; enemy deals massive damage!"));
                        }
                    }
                }

                if (Variables.Class == "Magician")
                    if (AmplifyActive == false && SpecialMeter != 5)
                        SpecialMeter++;

                if (Variables.Class == "Healer")
                    if (HealZoneActive == false && SpecialMeter != 5)
                        SpecialMeter++;

                if (SpecialMeter == 5)
                    prgbarSpecialMeter.Invoke((MethodInvoker)(() => prgbarSpecialMeter.Value = 5));

                else
                    prgbarSpecialMeter.Invoke((MethodInvoker)(() => prgbarSpecialMeter.Value = SpecialMeter));
                
                PlayerAction = null;
                lblMoveSelected.Invoke((MethodInvoker)(() => lblMoveSelected.Text = "None"));
                lblEHPValue.Invoke((MethodInvoker)(() => lblEHPValue.Text = prgbarEnemyHP.Value.ToString()));
                lblHPValue.Invoke((MethodInvoker)(() => lblHPValue.Text = prgbarPlayerHP.Value.ToString()));

                if (prgbarEnemyHP.Value == 0 || prgbarPlayerHP.Value == 0)
                {
                    Dead = true;
                    timerEndCountdown = new System.Threading.Timer(new TimerCallback(timerEndCountdown_Tick), null, 5000, 5000);
                    timerEndCountdown.Change(5000, 5000);
                    timerTurn.Dispose();
                }
            }
        }

        private void timerEndCountdown_Tick(object obj)
        {
            if (prgbarEnemyHP.Value == 0 && prgbarPlayerHP.Value == 0)
            {
                if (EndWait == 1)
                {
                    Variables.BattleOutcome = "Lost";
                    EndWait++;
                    lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "Double KO!\nAt least you managed to take one of them down with you!"));
                }

                else
                        this.Invoke(new Action(() => DisposeAllButMainForm()));           
            }

            else if (prgbarEnemyHP.Value == 0)
            {
                if (EndWait == 1)
                {
                    lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You won!\nYou have leveled up!!"));
                    EndWait++;
                    Variables.BattleOutcome = "Won";

                    Form StatIncreases = new StatIncreases();
                    StatIncreases.ShowDialog();

                    this.Invoke((MethodInvoker)(() =>
                    {
                        prgbarPlayerHP.Maximum = Variables.PlayerHP;
                        prgbarPlayerHP.Value = Variables.PlayerHP;
                        lblHPValue.Text = Variables.PlayerHP.ToString();
                        lblDmgValue.Text = Variables.PlayerDamage.ToString();
                        lblDodgeValue.Text = Variables.PlayerDodgeChance.ToString();
                    }));
                }

                else
                        this.Invoke(new Action(() => DisposeForm()));
            }

            else if (prgbarPlayerHP.Value == 0)
            {
                if (EndWait == 1)
                {
                    Variables.BattleOutcome = "Lost";
                    EndWait++;
                    lblOutput.Invoke((MethodInvoker)(() => lblOutput.Text = "You lost!\nYour hope for revenge dies with you!"));
                }

                else
                    this.Invoke(new Action(() => DisposeAllButMainForm()));

            }
        }

        public void DisposeForm()
        {
            timerEndCountdown.Dispose();
            timerTurn.Dispose();
            timerReleaseThreads.Start();
        }

        public void DisposeAllButMainForm()
        {
            foreach (Form f in Application.OpenForms)
                DisposeForms.Add(f);

            Form GameOver = new GameOver();
            GameOver.Show();

            timerReleaseThreads.Start();
        }

        private void PlanetCombat_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void timerReleaseThreads_Tick(object sender, EventArgs e)
        {
            foreach (Form f in DisposeForms)
            {
                if (f.Name != "MainMenu")
                    f.Dispose();
            }

            timerReleaseThreads.Stop();
            this.Dispose(); 
        }
    }
}