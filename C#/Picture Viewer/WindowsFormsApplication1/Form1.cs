using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showbuton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //when the user clicks ok
            {
                pictureBox1.Load(openFileDialog1.FileName);  //picture box is the selected file
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null; //clears the box
        }

        private void backgroundbutton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) //show the dialog box, and if user clicks ok
            {
                pictureBox1.BackColor = colorDialog1.Color; //makes the background the selected picture
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close(); //close the form
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) //if checked
            {
                
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //streches the image
            }

            else //if unchecked
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal; //puts the image normally
            }
        }
    }
}
