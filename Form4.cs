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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int count = -1;
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            lblStart.Hide();
            if (count < 6)
            {
                count++;
            }
            label2.Text = (count + 1).ToString();
            pictureBox1.Image = imageList1.Images[count];

            if (label2.Text == "6")
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Hide();
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show(); 
            this.Hide();
        }
    }
}
