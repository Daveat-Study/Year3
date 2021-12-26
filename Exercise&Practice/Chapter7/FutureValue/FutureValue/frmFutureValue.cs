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

        // Validator Method
        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            } catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal " + "value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);

            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min.ToString() + " and " + max.ToString() + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsInt32(TextBox textBox, string name)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            } catch (FormatException)
            {
                MessageBox.Show(name + " must be an integrer." + "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsValidateData()
        {
            return 
            // Validate the monthly investment text box
            IsPresent(txtMonthlyInvestment, "Monthly Investment") &&
            IsDecimal(txtMonthlyInvestment, "Monthly Investment") &&
            IsWithinRange(txtMonthlyInvestment, "Monthly Investment", 1, 1000) &&

            // Validate the monthly interest rate text box
            IsPresent(txtYearlyInterestRate, "Interest Rate") &&
            IsDecimal(txtYearlyInterestRate, "Interest Rate") &&
            IsWithinRange(txtYearlyInterestRate, "Interest Rate", 1, 20) &&

            // Validate the yearly Numer rate text box
            IsPresent(txtNumberOfYears, "Number Of Years") &&
            IsDecimal(txtNumberOfYears, "Number Of Years");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidateData())
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
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Entry Error");
                txtMonthlyInvestment.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Overflow error: Please enter smaller values", "Entry Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
