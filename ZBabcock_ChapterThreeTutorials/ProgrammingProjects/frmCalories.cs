using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProjects
{
    public partial class frmCalories : Form
    {
        public frmCalories()
        {
            InitializeComponent();
        }

        int calories = 0;

        private void pbApple_Click(object sender, EventArgs e)
        {
            calories = calories + 80;
            lblOutput.Text = calories.ToString();
        }

        private void pbBanana_Click(object sender, EventArgs e)
        {
            calories = calories + 115;
            lblOutput.Text = calories.ToString();
        }

        private void pbOrange_Click(object sender, EventArgs e)
        {
            calories = calories + 90;
            lblOutput.Text = calories.ToString();
        }

        private void pbPear_Click(object sender, EventArgs e)
        {
            calories = calories + 120;
            lblOutput.Text = calories.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAutomobile a = new frmAutomobile();
            a.ShowDialog();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            calories = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
