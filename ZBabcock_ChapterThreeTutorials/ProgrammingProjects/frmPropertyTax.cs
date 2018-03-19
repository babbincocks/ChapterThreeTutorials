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


        /*
        This bit of code below sets the functionality of the Next Problem button. It starts off with hiding this window,
        so as to more seamlessly transition. Then it creates a new form of the next problem in the book, and shows it.
        The reason I used ShowDialog, as opposed to just Show is that I wanted to switch over to the next problem with
        no remnants of the previous so it can be properly closed, and using ShowDialog shows the new form modally 
        (making it so directly returning to the previous form [so... THIS form] is impossible), as opposed to Show's 
        nonmodal format. Using Show makes it so the next line of code that is supposed to just close this form instead 
        closes all forms. Still not 100% certain why, but yeah, that happens.
        */
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
        { //Here's the code for the Exit button. All it does is focuses on the scope of this form and tells it to close.
            this.Close();
        }
    }
}
