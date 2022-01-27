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
    public partial class StatIncreases : Form
    {
        public StatIncreases()
        {
            InitializeComponent();
        }

        private void StatIncreases_Load(object sender, EventArgs e)
        {
            lblDmgAmount.Text = Variables.PlayerDamage + " + 5";
            lblDodgeAmount.Text = Variables.PlayerDodgeChance + " + 5%";
            lblHealthAmount.Text = Variables.PlayerHP + " + 50";
            picboxClass.Image = (Image)Properties.Resources.ResourceManager.GetObject(Variables.ResourceNameCharacter[12]);

            if (Variables.PlayerDodgeChance == 90)
            {
                btnDodge.BackColor = Color.DimGray;
                btnDodge.Enabled = false;
            }
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            Variables.PlayerDamage += 5;
            this.Dispose();
        }

        private void btnDodge_Click(object sender, EventArgs e)
        {
            Variables.PlayerDodgeChance += 5;
            this.Dispose();
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            Variables.PlayerHP += 50;
            this.Dispose();
        }

        private void StatIncreases_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
