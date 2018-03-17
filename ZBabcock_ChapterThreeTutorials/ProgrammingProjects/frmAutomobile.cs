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
    public partial class frmAutomobile : Form
    {
        public frmAutomobile()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPaintJob a = new frmPaintJob();
            a.ShowDialog();
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double maintain = double.Parse(txtMaintenance.Text);
                double loan = double.Parse(txtLoan.Text);
                double insure = double.Parse(txtInsurance.Text);
                double gas = double.Parse(txtGas.Text);
                double oil = double.Parse(txtOil.Text);
                double tires = double.Parse(txtTires.Text);
                double monthly = maintain + loan + insure + gas + oil + tires;
                double yearly = monthly * 12;

                lblMonthly.Text = monthly.ToString("c");
                lblYearly.Text = yearly.ToString("c");
            }
            catch
            {
                MessageBox.Show("There seems to have been something wrong with what you put in. Make sure all of the values you inserted were purely numeric.");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGas.Text = "";
            txtInsurance.Text = "";
            txtLoan.Text = "";
            txtMaintenance.Text = "";
            txtOil.Text = "";
            txtTires.Text = "";
            lblMonthly.Text = "";
            lblYearly.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
