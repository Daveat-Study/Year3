﻿using System;
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
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            initPaymentData();
            initExpirationDate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isValidateData())
            {
                this.saveData(); ;
            }
        }

        private void rdBtnCeditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCreditCard.Checked)
            {
                enableControls();
            }
            else
            {
                disableComtrols();
            }
        }

        /* Additional function */

        private void initPaymentData()
        {
            lstCreditCardType.Items.Add("Visa");
            lstCreditCardType.Items.Add("Mastercard");
            lstCreditCardType.Items.Add("American Express");
            lstCreditCardType.SelectedIndex = 0;

        }

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
                cboExpirationMonth.Items.Add(month);
            }
            cboExpirationMonth.SelectedIndex = 0;

            int year = DateTime.Today.Year;
            int endYear = year + 8;
            cboExpirationYear.Items.Add("Select a year...");
            while (year < endYear)
            {
                cboExpirationYear.Items.Add(year);
                year++;
            }
            cboExpirationYear.SelectedIndex = 0;
        }

        private void clearLstBox()
        {
            lstCreditCardType.Items.Clear();
            lstCreditCardType.Items.Add("Visa");
            lstCreditCardType.Items.Add("Mastercard");
            lstCreditCardType.Items.Add("American Express");
            lstCreditCardType.SelectedIndex = 0;;
        }

        private void getComBoAndListBoxInfo()
        {
            int expYearIndex = cboExpirationYear.SelectedIndex;
            string expYearText = cboExpirationYear.Text;
            int expYearValue = (int)cboExpirationYear.SelectedItem;
            String expMonthValue = cboExpirationMonth.Items[1].ToString();
        }

        private bool isValidateData()
        {
            if (rdoCreditCard.Checked)
            {
                if (lstCreditCardType.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "You must select a credit card type.",
                        "Entry Error"
                    );
                    lstCreditCardType.Focus();
                    return false;
                }

                if (txtCardNumber.Text == "")
                {
                    MessageBox.Show(
                        "You must enter a credit card number.",
                        "Entry Error"
                    );
                    txtCardNumber.Focus();
                    return false;
                }
                if (cboExpirationMonth.SelectedIndex == 0)
                {
                    MessageBox.Show(
                        "You must select a month.",
                        "Entry Error"
                    );
                    cboExpirationMonth.Focus();
                    return false;
                }
                if (cboExpirationYear.SelectedIndex == 0)
                {
                    MessageBox.Show(
                        "You must select a year.",
                        "Entry Error"
                    );
                    cboExpirationYear.Focus();
                    return false;
                }
            }
            return true;
        }

        private void saveData()
        {
            string msg = null;
            if (rdoCreditCard.Checked == true)
            {
                msg += "Charge to credit card.\n\n";
                msg += "Card type: " + lstCreditCardType.Text + "\n";
                msg += "Card number:" + txtCardNumber.Text + "\n";
                msg += "Expireation date: " + cboExpirationMonth.Text + "/" + cboExpirationYear.Text + "\n";
            }
            else
            {
                msg += "Send bill to customer." + "\n\n";
            }
            msg += "Default billing: " + chkDefault.Checked;
            this.Tag = msg;
            this.DialogResult = DialogResult.OK;
        }

        private void enableControls()
        {
            lstCreditCardType.Enabled = true;
            txtCardNumber.Enabled = true;
            cboExpirationMonth.Enabled = true;
            cboExpirationYear.Enabled = true;
        }
        private void disableComtrols()
        {
            lstCreditCardType.Enabled = false;
            txtCardNumber.Enabled = false;
            cboExpirationMonth.Enabled = false;
            cboExpirationYear.Enabled = false;
        }
    }
}
