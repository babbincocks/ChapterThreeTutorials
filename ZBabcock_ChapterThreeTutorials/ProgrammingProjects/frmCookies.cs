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
    public partial class frmCookies : Form
    {
        public frmCookies()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCalories a = new frmCalories();
            a.ShowDialog();
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double calories = double.Parse(txtCookies.Text) * 75;

                lblCalories.Text = calories.ToString();
            }
            catch
            {
                MessageBox.Show("There seems to be something wrong with your input.");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCookies.Text = "";
            lblCalories.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
