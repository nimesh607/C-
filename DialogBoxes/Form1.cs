using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog.Color = button1.BackColor;//set the initial color
            DialogResult dr=colorDialog.ShowDialog();
           
            if(dr ==DialogResult.OK)
            {
                button1.BackColor = colorDialog.Color;//set the color to picture box
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            fontDialog1.Font = button2.Font;//set the initial font
            DialogResult dr=fontDialog1.ShowDialog();
           
            if(dr==DialogResult.OK)
            {
                button2.Font = fontDialog1.Font;//set the font to button2
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPEG Images| *.jpg | PNG Images |*.png |Icon Images|*.ico|Bitmap Images|*.bmp|All Files|*.*";//JPEG Images| *.jpg one filter you can add n number of filter like this
            DialogResult dr = openFileDialog1.ShowDialog();
            //two ways to load images
           /* if(dr==DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }*/
           if(dr == DialogResult.OK)
            {
                string imgPath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = imgPath;
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "JPEG Images| *.jpg | PNG Images |*.png |Icon Images|*.ico|Bitmap Images|*.bmp|All Files|*.*";//JPEG Images| *.jpg one filter you can add n number of filter like this
            DialogResult dr =saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string imgPath = saveFileDialog1.FileName;
                pictureBox1.Image.Save(imgPath);
            }
        }
    }
}
