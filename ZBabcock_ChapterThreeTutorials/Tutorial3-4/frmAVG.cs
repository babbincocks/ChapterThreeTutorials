using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial3_4
{
    public partial class frmAVG : Form
    {
        public frmAVG()
        {
            InitializeComponent();
        }

        private void btnCalcAVG_Click(object sender, EventArgs e)
        {
            try
            {
                double testOne = double.Parse(txtTest1.Text);
                double testTwo = double.Parse(txtTest2.Text);
                double testThree = double.Parse(txtTest3.Text);

                double average = (testOne + testTwo + testThree) / 3.0;

                lblAVGResult.Text = average.ToString("n1");
            }

            catch
            {
                MessageBox.Show("One of your values seem to be invalid. Make sure they are all purely numeric (decimals are allowed).");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtTest1.Text = "";
                txtTest2.Text = "";
                txtTest3.Text = "";
                lblAVGResult.Text = "";
            }
            catch
            {
                MessageBox.Show("Not sure how you broke this, unless you got rid of one of the controls, to which I say congratulations, you git.");

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
