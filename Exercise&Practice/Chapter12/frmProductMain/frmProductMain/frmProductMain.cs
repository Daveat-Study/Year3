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


    public partial class frmProductMain : Form
    {

        private List<Product> products = null;
        public frmProductMain()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductMain_Load(object sender, EventArgs e)
        {

            products = ProductsDB.GetListProducts();
            FillProductListBox();
        }

        void FillProductListBox()
        {

            //Product product1, product2;
            //product1 = new Product("CS10", "Murach's C# 2010", 54.50m);
            //product2 = new Product("VB10", "Murach's Visual Basic", 54.50m);

            lstProducts.Items.Clear();
            foreach (Product p in products)
            {
                lstProducts.Items.Add(p.GetDisplayText("\t"));
            }
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmNewProduct newProductForm = new frmNewProduct();
            Product product = newProductForm.GetNewProduct();
            if (product != null)
            {
                products.Add(product);
                ProductsDB.SaveProducts(products);
                FillProductListBox();
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int i = lstProducts.SelectedIndex;
            if (i != -1)
            {
                Product product = products[i];
                string message = "Are you sure you want to delete " + product.getDescription + "?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    products.Remove(product);
                    ProductsDB.SaveProducts(products);
                    FillProductListBox();
                }
            }
        }
    }
}
