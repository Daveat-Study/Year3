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
            decimal tax = Convert.ToDecimal("7.00");
            decimal shippingCost = Convert.ToDecimal("0.00");
            txtShippingCost.Text = shippingCost.ToString("c");
            txtSaleTax.Text = tax.ToString("c");

            decimal gTotal = convert + tax;

            txtGrandTotal.Text = gTotal.ToString("c");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
