using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shippingAndHandling
{
    public partial class frmShippingAndHandling : Form
    {
        public frmShippingAndHandling()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalGrandTotal_Click(object sender, EventArgs e)
        {
            decimal convert = Convert.ToDecimal(txtOrderTotal.Text);
            decimal tax = 7m;
            decimal shippingCost = Convert.ToDecimal("0");
            if (txtCusType.Text.ToUpper() != "P")
            {
                if (convert >= 0m && convert <= 25m) 
                {
                    shippingCost = 5m;
                } else if (convert >= 25.01m && convert <= 500m)
                {
                    shippingCost = 8m;

                } else if (convert >= 500.01m && convert <= 1000m)
                {
                    shippingCost = 10m;

                } else if (convert >= 1000.01m && convert <= 5000m)
                {
                    shippingCost = 15m;

                } else if (convert >= 5000.01m)
                {
                    shippingCost = 20m;
                }
            }
            txtShippingCost.Text = shippingCost.ToString("p1");
            txtSaleTax.Text = tax.ToString("c");

            decimal gTotal = (convert + tax)  + shippingCost;

            txtGrandTotal.Text = gTotal.ToString("c2");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
