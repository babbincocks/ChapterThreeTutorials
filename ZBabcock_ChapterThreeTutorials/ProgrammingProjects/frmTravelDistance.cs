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
    public partial class frmTravelDistance : Form
    {
        public frmTravelDistance()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {//Just a little error handling, putting all code for this button in a try block.
            try
            {
                /*
                 As I'm trying to calculate the distance a vehicle has traveled over several hours, all I need to do is
                 take the speed, and multiply it by the amount of hours, this case being 5, 8, and 12 hours. So I had
                 this control create 4 variables: the speed that the user put in (speed), the distance the vehicle has 
                 traveled after 5 hours (five), 8 hours (eight), and 12 hours (twelve). Then the results of five, eight,
                 and twelve are put into the fields on the right side of the form for their respective time frame.
                 */
                double speed = double.Parse(txtSpeed.Text);
                double five = speed * 5;
                double eight = speed * 8;
                double twelve = speed * 12;

                lbl5Distance.Text = five.ToString();
                lbl8Distance.Text = eight.ToString();
                lbl12Distance.Text = twelve.ToString();

            }
            catch
            {     //And here's the catch block and message that will show up in the event the user inputs something odd.
                MessageBox.Show("Incorrect format inserted into the Speed textbox. Just, y'know, put a number.");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        { /*
            This is the code for the Clear button, which sets the text fields of the input Speed field and the three
            output distance fields to a blank, null value.
          */
            txtSpeed.Text = "";
            lbl5Distance.Text = "";
            lbl8Distance.Text = "";
            lbl12Distance.Text = "";
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
            frmSalesTaxTotal a = new frmSalesTaxTotal();
            a.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        { //Here's the code for the Exit button. All it does is focuses on the scope of this form and tells it to close.
            this.Close();
        }
    }
}
