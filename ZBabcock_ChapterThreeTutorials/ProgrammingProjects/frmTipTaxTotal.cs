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
    public partial class frmTipTaxTotal : Form
    {
        public frmTipTaxTotal()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double price = double.Parse(txtMeal.Text);
                double tip = price * 0.15;
                double tax = price * 0.07;
                double total = price + tip + tax;

                lblTip.Text = tip.ToString("c");
                lblTax.Text = tax.ToString("c");
                lblTotal.Text = total.ToString("c");
            }
            catch
            {
                MessageBox.Show("There was an issue calculating this. Make sure that all you entered were numbers.");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMeal.Text = "";
            lblTip.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTravelDistance a = new frmTravelDistance();
            a.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
