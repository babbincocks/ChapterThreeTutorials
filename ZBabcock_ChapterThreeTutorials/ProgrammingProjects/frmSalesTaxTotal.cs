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
    public partial class frmSalesTaxTotal : Form
    {
        public frmSalesTaxTotal()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = double.Parse(txtPurchase.Text);
                double state = amount * 0.04;
                double county = amount * 0.02;
                double tax = state + county;
                double total = tax + amount;

                lblState.Text = state.ToString("c");
                lblCounty.Text = county.ToString("c");
                lblTax.Text = tax.ToString("c");
                lblTotal.Text = total.ToString("c");
            }
            catch
            {
                MessageBox.Show("It seems that there was something wrong with what you entered. :c");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPurchase.Text = "";
            lblState.Text = "";
            lblCounty.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTempConverter a = new frmTempConverter();
            a.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
