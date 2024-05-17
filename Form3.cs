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
    public partial class Form3 : Form
    {

        PictureBox[] pictures = new PictureBox[4];

        public Form3()
        {
            InitializeComponent();
            pictureBox2.Hide();
            label1.Hide();
            button1.Hide();
            for (int i = 0; i < 4; i++)
            {
                pictures[i] = new PictureBox();
                pictures[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pictures[i].AllowDrop = true;
                pictures[i].DragEnter += new DragEventHandler(pictures_DragEnter);
                pictures[i].DragDrop += new DragEventHandler(pictures_DragDrop);
                tblCodeArea.Controls.Add(pictures[i]);
            }
        }
            private void codeBlock_MouseDown(object sender, MouseEventArgs e)
            {
                PictureBox codeBlock = sender as PictureBox;
                DataObject dragImage = new DataObject();
                dragImage.SetData(DataFormats.Bitmap, true, codeBlock.Image);
                dragImage.SetData(DataFormats.Text, true, codeBlock.Tag);
                DoDragDrop(dragImage, DragDropEffects.Copy);
            }           

                private void pictures_DragEnter(object sender, DragEventArgs e)
                {
                    e.Effect = e.AllowedEffect;
                }

        private void pictures_DragDrop(object sender, DragEventArgs e)
        {
            int[] tyrellLoc = { 205, 205 };

            PictureBox picture = sender as PictureBox;

            picture.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            picture.Tag = e.Data.GetData(TextDataFormat.Text.ToString());

            lblList.Text = "";

            foreach (PictureBox pb in pictures)
            {
                if (pb.Tag != null)
                { 
                    lblList.Text = String.Format("{0}\n{1}", lblList.Text, pb.Tag.ToString());
                    
                    tyrellLoc = MoveTyrell(tyrellLoc, pb.Tag.ToString());
                }
            }

            pbTyrell.Location = new Point(tyrellLoc[0], tyrellLoc[1]);

            if (tyrellLoc[0] == 605 && tyrellLoc[1] == 205)
            {             
                label1.Show();
                button1.Show();
                pictureBox2.Show();
            }
        }
                       
        private int[] MoveTyrell(int[] tyrell, string arrow)
    {
            if (arrow == "Up")       
            {
                tyrell[1] -= 200;
            }
            else if (arrow == "Down")
            {
                tyrell[1] += 200;
            }
            else if (arrow == "Right")
            {
                 tyrell[0] += 200;
            }
            else if (arrow == "Left")
            {
                 tyrell[0] -= 200;
            }
            return tyrell;
    }        
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }
    }
  
}


        
 