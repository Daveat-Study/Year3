using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmProductMain
{
    public partial class frmNewProduct : Form
    {
        private Product product = null;

        public Product GetNewProduct()
        {
            this.ShowDialog();
            return product;
        }
        public frmNewProduct()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidateData())
            {
                product = new Product(txtCode.Text, txtDescription.Text, Convert.ToDecimal(txtPrice.Text));
                this.Close();
            }
        }

        private bool IsValidateData()
        {
            return Validator.IsPresent(txtCode) &&
                Validator.IsPresent(txtDescription) &&
                Validator.IsPresent(txtPrice) &&
                Validator.IsDecimal(txtPrice);
        }
    }
}
