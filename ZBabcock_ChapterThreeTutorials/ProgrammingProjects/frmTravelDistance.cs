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
        {
            try
            {
                double speed = double.Parse(txtSpeed.Text);
                double five = speed * 5;
                double eight = speed * 8;
                double twelve = speed * 12;

                lbl5Distance.Text = five.ToString();
                lbl8Distance.Text = eight.ToString();
                lbl12Distance.Text = twelve.ToString();

            }
            catch
            {
                MessageBox.Show("Incorrect format inserted into the Speed textbox.");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSpeed.Text = "";
            lbl5Distance.Text = "";
            lbl8Distance.Text = "";
            lbl12Distance.Text = "";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalesTaxTotal a = new frmSalesTaxTotal();
            a.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
