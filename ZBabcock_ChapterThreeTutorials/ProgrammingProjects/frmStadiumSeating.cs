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
    public partial class frmStadiumSeating : Form
    {
        public frmStadiumSeating()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtClassA.Text) * 15;
                double b = double.Parse(txtClassB.Text) * 12;
                double c = double.Parse(txtClassC.Text) * 9;
                double total = a + b + c;

                lblClassA.Text = a.ToString("c");
                lblClassB.Text = b.ToString("c");
                lblClassC.Text = c.ToString("c");
                lblTotal.Text = total.ToString("c");
            }
            catch
            {
                MessageBox.Show("The values you inputted seem to be invalid, and raised an error. Why'd you go and do that, huh?");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClassA.Text = "";
            txtClassB.Text = "";
            txtClassC.Text = "";
            lblClassA.Text = "";
            lblClassB.Text = "";
            lblClassC.Text = "";
            lblTotal.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        { //Here's the code for the Exit button. All it does is focuses on the scope of this form and tells it to close.
            this.Close();
        }
    }
}
