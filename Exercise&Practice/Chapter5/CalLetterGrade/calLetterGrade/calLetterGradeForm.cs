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

            if (convert <= 100)
            {
                if (convert >= 90 && convert <= 100)
                {
                    lblLetterGrade.Text = "A";
                }
                else if (convert >= 80 && convert <= 89)
                {
                    lblLetterGrade.Text = "B";
                }
                else if (convert >= 70 && convert <= 79)
                {
                    lblLetterGrade.Text = "C";
                }
                else if (convert >= 60 && convert <= 69)
                {
                    lblLetterGrade.Text = "E";
                }
                else if (convert < 60)
                {
                    lblLetterGrade.Text = "F";
                }
            }
        }
    }
}
