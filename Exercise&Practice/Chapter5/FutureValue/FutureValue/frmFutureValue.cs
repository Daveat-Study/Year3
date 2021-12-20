using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class frmFutureValue : Form
    {
        decimal futureValue = 0m;
        public frmFutureValue()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInterestRate = Convert.ToDecimal(txtYearlyInterestRate.Text);
            decimal monthlyPayment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            for (int i = 0; i< 12; i++)
            {
                futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);
            }

            txtFutureValue.Text = futureValue.ToString("c2");
        }
    }
}
