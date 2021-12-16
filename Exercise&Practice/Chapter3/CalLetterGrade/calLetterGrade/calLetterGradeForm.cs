using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calLetterGrade
{
    public partial class calculateLetterGrade : Form
    {
        public calculateLetterGrade()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalLetterGrade_Click(object sender, EventArgs e)
        {
            decimal convert = Convert.ToDecimal(txtNumericGrade.Text);

            int intt = Convert.ToInt32(convert);

            lblLetterGrade.Text = (Convert.ToChar(intt)).ToString();
        }
    }
}
