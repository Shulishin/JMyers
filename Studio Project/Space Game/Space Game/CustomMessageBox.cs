using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Space_Game
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            lblMessage.Font = new Font(Variables.CustomFont.Families[0], lblMessage.Font.Size);
            btnContinue.Font = new Font(Variables.CustomFont.Families[0], btnContinue.Font.Size);

            if (Variables.MessageBoxOutput == "GameSaved")
            {
                this.Text = "Game Saved!";
                lblMessage.Text = "The game has been saved!";
                Variables.MessageBoxOutput = null;
            }

            else if (Variables.MessageBoxOutput == "NoSaveFile")
            {
                this.Text = "No Save File";
                lblMessage.Text = "No save file exists!";
                Variables.MessageBoxOutput = null;
            }

            else if (Variables.MessageBoxOutput == "Boss1")
            {
                this.Text = Variables.EnemyName;
                lblMessage.Text = "Now you face a real challenge, prepare yourself!";
            }

            else if (Variables.MessageBoxOutput == "Boss2")
            {
                this.Text = Variables.EnemyName;
                lblMessage.Text = "This is as far as you go, worm.!";
            }

            else if (Variables.MessageBoxOutput == "Boss3")
            {
                this.Text = Variables.EnemyName;
                lblMessage.Text = "Everything before now has been a test, the real fight starts now!";
            }

            else if (Variables.MessageBoxOutput == "Boss4")
            {
                this.Text = Variables.EnemyName;
                lblMessage.Text = "Rek'lo steglo! Kree so mal tera moor! (Best left untranslated)";
            }

            else if (Variables.MessageBoxOutput == "Boss5")
            {
                this.Text = Variables.EnemyName;
                lblMessage.Text = "You face Zix now! Zix destroy, Zix kill!";
            }

            else if (Variables.MessageBoxOutput == "Boss6")
            {
                this.Text = Variables.EnemyName;
                lblMessage.Text = "The Zix'xi will remain strong. We shall not faulter! Now... you die!";
            }

            else if (Variables.MessageBoxOutput == "CheatsEnabled")
            {
                this.Text = "Cheats Enabled!";
                lblMessage.Text = "Cheats are now enabled. I certainly hope your name is Joe Myers or god help you...";
            }

            else
            {
                if (Variables.ItemFound == "Damage")
                    lblMessage.Text = "You have found a lost artifact that increases your damage!";

                else if (Variables.ItemFound == "Health")
                    lblMessage.Text = "You have found a lost artifact that increases your health!";

                else if (Variables.ItemFound == "Dodge")
                    lblMessage.Text = "You have found a lost artifact that increases your dodge chance!";

                else if (Variables.ItemFound == "Secret")
                    lblMessage.Text = "You have found the treasure hold of a lost civilisation. Your stats all increase!";
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
