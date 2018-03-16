using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial3_3
{
    public partial class frmSalesCalc : Form
    {
        public frmSalesCalc()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal startPrice = decimal.Parse(originalPriceTextBox.Text);
                decimal discPercent = decimal.Parse(discountPercentageTextBox.Text);
                discPercent = discPercent / 100;
                decimal discAmount = startPrice * discPercent;
                decimal salePrice = startPrice - discAmount;
                salePriceLabel.Text = salePrice.ToString("c");
            }
            catch
            {
                MessageBox.Show("There was an error while calculating. Did you fill in both of the boxes with the appropriate data?");

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
