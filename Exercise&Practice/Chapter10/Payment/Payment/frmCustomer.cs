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
    public partial class frmCustomer : Form
    {
        bool isDataSaved = false;
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnSelectPayment_Click(object sender, EventArgs e)
        {
            Form paymentForm = new frmPayment();
            DialogResult selectedButton = paymentForm.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                lblPayment.Text = (string) paymentForm.Tag;
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValidateData())
            {
                saveData();
            }
        }

        private void saveData()
        {
            cboNames.SelectedIndex = -1;
            lblPayment.Text = "";
            isDataSaved = true;
            cboNames.Focus();
        }

        private bool isValidateData()
        {
            if (cboNames.SelectedIndex == -1) {
                MessageBox.Show(
                    "You must select a customer.",
                    "Entry Error"
                );
                cboNames.Focus();
                return false;
            }
            if (lblPayment.Text == "")
            {
                MessageBox.Show(
                    "You must enter a payment.",
                    "Entry Error"
                );
                return false;
            }
            return true;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            string[] names = { "Doug Lowe", "Anne Boehm", "Ed Koop" };
            foreach(string name in names)
            {
                cboNames.Items.Add(name);
            }
            cboNames.Items.Insert(0, "Joel Murach");
            cboNames.Items.RemoveAt(3);
            cboNames.SelectedIndex = 1;
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            unSavedDataCheck(e);
        }

        private void unSavedDataCheck(FormClosingEventArgs e)
        {

            if (isDataSaved == false)
            {
                string message = "This form contains unsaved data.\n\n" + "Do you want to save it?";

                DialogResult button = MessageBox.Show(
                    message,
                    "Customer",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );
                if (button == DialogResult.Yes)
                {
                    if (isValidateData())
                    {
                        this.saveData();
                    }
                    else e.Cancel = true;
                }


                if (button == DialogResult.Cancel)
                {
                    e.Cancel = false;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
