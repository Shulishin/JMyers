using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Space_Game
{
    public partial class ClassDescription : Form
    {
        public ClassDescription()
        {
            InitializeComponent();
        }

        private void ClassDescription_Load(object sender, EventArgs e)
        {
            lblClassDescription.Font = new Font(Variables.CustomFont.Families[0], lblClassDescription.Font.Size);
            lblClassName.Font = new Font(Variables.CustomFont.Families[0], lblClassName.Font.Size);
            btnRepick.Font = new Font(Variables.CustomFont.Families[0], btnRepick.Font.Size);
            btnSelect.Font = new Font(Variables.CustomFont.Families[0], btnSelect.Font.Size);

            picboxClass.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.Class + Variables.Gender + "Icon");
            lblClassName.Text = Variables.Class + ":";

            switch (Variables.Class)
            {
                case "Ninja":
                    lblClassDescription.Text = "A low hp, high dodge chance, medium-high damage class. Uses the special move 'Backstab' to dodge an attack and deal damage.";
                    break;

                case "Warrior":
                    lblClassDescription.Text = "A high hp, medium dodge chance, medium-low damage class. Uses the special move 'Reflect' to return damage dealt.";
                    break;

                case "Magician":
                    lblClassDescription.Text = "A low hp, low dodge chance, high damage class. Uses the special move 'Amplify' to increase damage dealt to the enemy.";
                    break;

                case "Healer":
                    lblClassDescription.Text = "A medium hp, medium-low dodge chance, medium-low damage class. Uses the special move 'Healzone' to heal damage taken when attacked.";
                    break;

                case "Ranger":
                    lblClassDescription.Text = "A medium-low hp, medium-high dodge chance, medium-high damage class. Uses the special move 'Volley' to attack from range.";
                    break;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Variables.ClassChosen = true;
            this.Dispose();
        }

        private void btnRepick_Click(object sender, EventArgs e)
        {
            Variables.ClassChosen = false;
            this.Dispose();
        }
    }
}
