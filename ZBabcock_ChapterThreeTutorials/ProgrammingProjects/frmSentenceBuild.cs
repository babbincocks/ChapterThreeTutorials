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
    public partial class frmSentenceBuild : Form
    {
        public frmSentenceBuild()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "A";
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "a";
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "An";
        }

        private void btn_an_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "an";
        }

        private void btnThe_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "The";
        }

        private void btn_the_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "the";
        }

        private void btnMan_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "man";
        }

        private void btnWoman_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "woman";
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "dog";
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "cat";
        }

        private void btnBird_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "bird";
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "car";
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "train";
        }

        private void btnHuge_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "huge";
        }

        private void btnEerie_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "eerie";
        }

        private void btnSmelly_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "smelly";
        }

        private void btnPretty_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "pretty";
        }

        private void btnHandsome_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "handsome";
        }

        private void btnTiny_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "tiny";
        }

        private void btnRanInto_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "ran into";
        }

        private void btnTalkedTo_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "talked to";
        }

        private void btnBeseeched_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "beseeched";
        }

        private void btnGreeted_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "greeted";
        }

        private void btnDrove_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "drove";
        }

        private void btnLaughedAt_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "laughed at";
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + " ";
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + ".";
        }

        private void btnExclamation_Click(object sender, EventArgs e)
        {
            lblOutput.Text = lblOutput.Text + "!";
        }

        private void btnNextProblem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInsurance a = new frmInsurance();
            a.ShowDialog();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
