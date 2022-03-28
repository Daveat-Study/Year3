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

    public class Product
    {
        private string code;
        private string description;
        private decimal price;

        public Product() { }
        public Product (string code, string des, decimal price)
        {
            this.code = code;
            this.description = des;
            this.price = price;
        }

        public string getCode
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public string getDescription
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public decimal getPrice
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string GetDisplayText(string sep)
        {
            return code + sep + price.ToString("c") + sep + description;
        }
    } 
    public partial class frmProductMain : Form
    {
        public frmProductMain()
        {
            Product product1, product2;
            product1 = new Product("CS10", "Murach's C# 2010", 54.50m);
            product2 = new Product("VB10", "Murach's Visual Basic", 54.50m);
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
