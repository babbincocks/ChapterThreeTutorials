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
        {
            this.Close();
        }
    }
}
