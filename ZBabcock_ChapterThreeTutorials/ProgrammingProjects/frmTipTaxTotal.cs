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
        { /*
            So this problem is to calculate the tip (15% of purchase) and tax (7% of purchase) for a purchase amount, 
            and then add those together for the total. The initial price is put into a variable from what the user puts
            in for the price of their meal. The tip is then calculated by multiplying the price by 0.15 (getting 15%),
            and the tax is calculated by doing the same, but 0.07 instead. One final variable is created by adding the
            three previous values together, and the text field for the tip gets the tip value, the tax field gets tax,
            and the total field gets the total.
            */
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
        {/*
            This is the code for the Clear button, where it will turn the text value for the input field and the 
            output fields into a null value.
          */
            txtMeal.Text = "";
            lblTip.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";
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
            frmTravelDistance a = new frmTravelDistance();
            a.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        { //Here's the code for the Exit button. All it does is focuses on the scope of this form and tells it to close.
            this.Close();
        }
    }
}
