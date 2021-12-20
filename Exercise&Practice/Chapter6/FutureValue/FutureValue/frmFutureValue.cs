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
        public frmFutureValue()
        {
            InitializeComponent();
        }

        private void CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            decimal totalRate = 0m;
            for (int i = 0; i < months; i++)
            {
                totalRate = (futureValue + monthlyInvestment) * monthlyInterestRate;
                futureValue = totalRate + (futureValue + monthlyInvestment);

                //futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
        }

        private void ClearFutureValue(object msender, EventArgs e)
        {
            txtFutureValue.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal yearlyInterestRate = Convert.ToDecimal(txtYearlyInterestRate.Text);
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            int years = Convert.ToInt32(txtNumberOfYears.Text);
            int month = years * 12;

            decimal monthyInterestRate = yearlyInterestRate / 12 / monthlyInvestment;
            //decimal totalRate = 0m;

            decimal futureValue = 0m;
            this.CalculateFutureValue(monthlyInvestment, monthyInterestRate, month, ref futureValue);

            txtFutureValue.Text = futureValue.ToString("c2");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
