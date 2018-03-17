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
    public partial class frmInsurance : Form
    {
        public frmInsurance()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCookies a = new frmCookies();
            a.ShowDialog();
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double cost = double.Parse(txtCost.Text);
                double insure = cost * 0.8;

                lblInsurance.Text = insure.ToString("c");
            }
            catch
            {
                MessageBox.Show("There was an issue with the value you put in. Ensure that it's a purely-numeric value that you put in.");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCost.Text = "";
            lblInsurance.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
