using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Telephone_Numbers
{
    public partial class telephoneNumbers : Form
    {
        public telephoneNumbers()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Regex numberOnlyRegEx = new Regex(@"[^0-9]+", RegexOptions.Compiled);
            String convert = txtAlphanumericNumber.Text;
            long result = Convert.ToInt64(Regex.Replace(convert, @"\D", ""));//new String(convert.Where(Char.IsNumber).ToArray());

            txtNumOnly.Text = result.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
