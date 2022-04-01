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
