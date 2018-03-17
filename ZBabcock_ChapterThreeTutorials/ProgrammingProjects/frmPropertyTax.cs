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
    public partial class frmPropertyTax : Form
    {
        public frmPropertyTax()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStadiumSeating a = new frmStadiumSeating();
            a.ShowDialog();
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double tax = (double.Parse(txtPropValue.Text) / 100) * 0.64;

                lblPropTax.Text = tax.ToString();
            }
            catch
            {
                MessageBox.Show("There was a problem calculating the property tax. Make sure it was a numeric value you inserted.")
                    
                    ;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPropValue.Text = "";
            lblPropTax.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
