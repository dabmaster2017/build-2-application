using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUILD_2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            btnNext.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (rbCorrect.Checked == true)
            {
                txbOutput.Text = "Correct!!";
                btnNext.Show();
            }
            else
            {
                txbOutput.Text = "Wrong :( Try again.";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }
    }
}
