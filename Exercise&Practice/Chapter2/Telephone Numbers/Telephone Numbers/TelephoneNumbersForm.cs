using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Numbers
{
    public partial class telephoneNumbers : Form
    {
        public telephoneNumbers()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            Console.WriteLine("COnvert");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Exit" +
                "");
        }
    }
}
