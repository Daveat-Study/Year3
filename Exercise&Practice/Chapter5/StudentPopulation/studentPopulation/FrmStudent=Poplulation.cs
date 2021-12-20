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
            double convert = Convert.ToDouble(txtNumberOfStudentsToday.Text);
            double growthRate = Convert.ToDouble(txtAnlGrowthRate.Text);
            int years = Convert.ToInt32(txtNumOfYear.Text);
            //convert *= 2m;
            double r = Math.Pow((1 + (growthRate/100)), years);
            double popGrowth = convert * r;

            txtNumberOfProjectedStudents.Text = popGrowth.ToString("n2");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumberOfStudentsToday_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
