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
    public partial class frmPaintJob : Form
    {
        public frmPaintJob()
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
            frmPropertyTax a = new frmPropertyTax();
            a.ShowDialog();
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double wallspace = double.Parse(txtWallSpace.Text);
                double paintprice = double.Parse(txtBasePaint.Text);
                double gallonsneeded = Math.Ceiling(wallspace / 115);
                double laborhours = Math.Ceiling((wallspace / 115) * 8);
                double paintcost = gallonsneeded * paintprice;
                double laborcost = laborhours * 20.00;
                double totalcost = laborcost + paintcost;


                lblGallonNumber.Text = gallonsneeded.ToString();
                lblLaborHours.Text = laborhours.ToString();
                lblPaintCost.Text = paintcost.ToString("c");
                lblLaborCost.Text = laborcost.ToString("c");
                lblTotalCost.Text = totalcost.ToString("c");
            }
            catch
            {
                MessageBox.Show("There seems to have been an error with your input. Be sure to fill in both boxes on the left, and to only use numeric values.");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBasePaint.Text = "";
            txtWallSpace.Text = "";
            lblGallonNumber.Text = "";
            lblLaborHours.Text = "";
            lblLaborCost.Text = "";
            lblPaintCost.Text = "";
            lblTotalCost.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        { //Here's the code for the Exit button. All it does is focuses on the scope of this form and tells it to close.
            this.Close();
        }
    }
}
