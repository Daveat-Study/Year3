using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentPopulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProStudentPop_Click(object sender, EventArgs e)
        {
            decimal convert = Convert.ToDecimal(txtNumberOfStudentsToday.Text);
            //convert *= 2m;

            decimal result = (convert * Convert.ToDecimal(txtAnlGrowthRate.Text)) / Convert.ToDecimal(txtNumOfYear.Text);
            txtNumberOfProjectedStudents.Text = result.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
