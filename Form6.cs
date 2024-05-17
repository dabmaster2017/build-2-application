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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            btnEnd.Hide();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (rbCorrect.Checked == true)
            {
                txbOutput.Text = "Correct!!";
                btnEnd.Show();
                lblCongrats.Show();
            }
            else
            {
                txbOutput.Text = "Wrong :( Try again.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
