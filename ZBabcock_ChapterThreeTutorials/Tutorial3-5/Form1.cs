using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tutorial3_5
{
    public partial class frmChange : Form
    {
        public frmChange()
        {
            InitializeComponent();
        }

        const decimal FIVE_CENTS = 0.05m;
        const decimal TEN_CENTS = 0.10m;
        const decimal TWENTY_FIVE_CENTS = 0.25m;
        const decimal FIFTY_CENTS = 0.50m;

        private decimal total = 0m;

        private void pbFiveCent_Click(object sender, EventArgs e)
        {
            total += FIVE_CENTS;

            lblTotal.Text = total.ToString("c");
        }

        private void pbTenCent_Click(object sender, EventArgs e)
        {
            total += TEN_CENTS;

            lblTotal.Text = total.ToString("c");
        }

        private void pbTwentyFiveCent_Click(object sender, EventArgs e)
        {
            total += TWENTY_FIVE_CENTS;

            lblTotal.Text = total.ToString("c");
        }

        private void pbFiftyCent_Click(object sender, EventArgs e)
        {
            total += FIFTY_CENTS;

            lblTotal.Text = total.ToString("c");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "";
            total = 0m;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
