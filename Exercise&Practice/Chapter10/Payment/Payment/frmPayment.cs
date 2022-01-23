using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payment
{
    public partial class frmPayment : Form
    {
        string[] cboNames;
        public frmPayment()
        {
            InitializeComponent();
            initExpirationDate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstBxCeditCardType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /* Additional method */


        private void initExpirationDate()
        {
            string[] months =
            {
                "Select a month...",
                "January", "Febuary", "March", "April",
                "May", "Jun", "July", "August", "September", "October", "November", "December"
            };

            foreach (string month in months)
            {
                cmbBoxSelectMonth.Items.Add(month);
            }

            int year = DateTime.Today.Year;
            int endYear = year + 8;
            cmbBoxSelectMonth.Items.Add("Select a year...");
            while (year < endYear)
            {
                cmbBoxSelectMonth.Items.Add(year);
                year++;
            }
        }

        private void clearLstBox()
        {
            lstBxCeditCardType.Items.Clear();
            lstBxCeditCardType.Items.Add("Visa");
            lstBxCeditCardType.Items.Add("Mastercard");
            lstBxCeditCardType.Items.Add("American Express");
            lstBxCeditCardType.SelectedIndex = 0;;
        }

        private void getComBoAndListBoxInfo()
        {
            int expYearIndex = cmbBoxSelectYear.SelectedIndex;
            string expYearText = cmbBoxSelectYear.Text;
            int expYearValue = (int)cmbBoxSelectYear.SelectedItem;
            String expMonthValue = cmbBoxSelectMonth.Items[1].ToString();
        }

        private void comBoxName()
        {
            string[] names = { "Doug Lowe", "Anne Boehm", "Ed Koop" };
            foreach(string name in names)
            {
                //cboName.Item
            }
        }

        private void rdBtnCeditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtnCeditCard.Checked)
            {
                enableControls();
            } else
            {
                disableComtrols();
            }
        }

        private void enableControls()
        {

        }
        private void disableComtrols()
        {

        }

        private void rdBtnBillCustomer_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
