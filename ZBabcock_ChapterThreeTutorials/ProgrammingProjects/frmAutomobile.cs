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
            frmPaintJob a = new frmPaintJob();
            a.ShowDialog();
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {   /*
               This one is a very basic calculation for automobile costs. I created a variable for each of the different
               elements (maintenance, loan, insurance, gas, oil, and tires) which draws their values from their
               respective fields. The values are all added together to get the monthly cost (which is put into another
               variable), and then it's multiplied by 12 to get the yearly cost (yet another variable). Those last two
               variables are put into the two respective output text boxes.
            */
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
        { /*
            This is the code for the Clear button, where it will turn the text value for all of the input fields and the 
            output fields into a null value.
          */
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
        { //Here's the code for the Exit button. All it does is focuses on the scope of this form and tells it to close.
            this.Close();
        }
    }
}
