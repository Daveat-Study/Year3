using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        decimal subtotal;
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /***************************************

            * this method calculates the total 

            * for an invoice depending on a 

            * discount that's based on the subtotal

            ****************************************/


            if (txtSubTotal.Text != "")
            {
                // get the subtotal amount from the Subtotal text box
                decimal subtotal = Convert.ToDecimal(txtSubTotal.Text);

                // set the discountPercent variable based
                // on the value of the subtotal variable
                decimal discountPercent = 0m; // the m indicates a decimal value
                if (txtCustomerType.Text.ToUpper() == "R")
                {
                    if (subtotal < 100)
                    {
                        discountPercent = .0m;
                    }
                    else if (subtotal >= 100 && subtotal < 250)
                    {
                        discountPercent = .1m;
                    }
                    else if (subtotal >= 250 && subtotal < 500)
                    {
                        discountPercent = .25m;
                    } else if (subtotal >= 500)
                    {
                        discountPercent = .30m;
                    }
                } else if (txtCustomerType.Text.ToUpper() == "C")
                {
                    discountPercent = .20m;
                } else if (txtCustomerType.Text.ToUpper() == "T")
                {
                    if (subtotal < 500)
                    {
                        discountPercent = .40m;
                    } else if (subtotal >= 500)
                    {
                        discountPercent = .50m;
                    }
                }
                else
                {
                    discountPercent = .10m;
                }
                // calculate and assign the values for the 
                // discountAmount and invoiceTotal variables
                decimal discountAmount = subtotal * discountPercent;
                decimal invoiceTotal = subtotal - discountAmount;

                // format the values and display them in their text boxes
                txtDiscountPercent.Text = discountPercent.ToString("p1"); // percent format with 1 decimal place
                txtDiscountAmount.Text = discountAmount.ToString("c"); // currency format
                txtTotal.Text = invoiceTotal.ToString("c");

                // move the focus to the Subtotal text box
                txtSubTotal.Focus();
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
