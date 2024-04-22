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
        int x;
        int r1;
        int r2;
        int r3;
        int r4;
        int r5;
        int r6;
        int r7;
        int h1;
        int h2;
        int h3;
        int h4;
        int h5;
        int h6;
        int win1;
        int win2;
        int win3;
        int win4;
        int win5;
        int win6;
        int win7;
        int win8;
        int win9;
        int win10;
        int win11;
        int win12;
        int win13;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
            
        private void pictureBox43_Click(object sender, EventArgs e)
        {
            if (x % 2 == 0)
            {
                Controls["pictureBox" + (42 + r1)].BackgroundImage = Properties.Resources.Black;
                r1 = r1 - 7;
                win1 = win1 + 1;
                x++;
            }
            else if (x % 2 == 1)
            {
                Controls["pictureBox" + (42 + r1)].BackgroundImage = Properties.Resources.Red;
                r1 = r1 - 7;
                win1 = win1 - 1;
                x--;
            }
            
            if (win1 == 4)
            {
                MessageBox.Show("W");
            }
            else if (win1 == -4)
            {
                MessageBox.Show("L");
            }

       
        }
        private void pictureBox43_MouseEnter(object sender, EventArgs e)
        {

            if (x % 2 == 0)
            {
                pictureBox43.BackgroundImage = Properties.Resources.Black;
            }
            else if (x % 2 == 1)
            {
                pictureBox43.BackgroundImage = Properties.Resources.Red;
            }
        }
        private void pictureBox43_MouseLeave(object sender, EventArgs e)
        {
            pictureBox43.BackgroundImage = null;
        }


        private void pictureBox44_Click(object sender, EventArgs e)
        {
            if (x % 2 == 0)
            {
                Controls["pictureBox" + (41 + r2)].BackgroundImage = Properties.Resources.Black;
                r2 = r2 - 7;
                win2 = win2 + 1;
                x++;
            }
            else if (x % 2 == 1)
            {
                Controls["pictureBox" + (41 + r2)].BackgroundImage = Properties.Resources.Red;
               r2 = r2 - 7;
               win2 = win2 - 1;
                x--;
            }

            if (win2 == 4)
            {
                MessageBox.Show("W");
            }
            else if (win2 == -4)
            {
                MessageBox.Show("L");
            }
        }
        private void pictureBox44_MouseEnter(object sender, EventArgs e)
        {

            if (x % 2 == 0)
            {
                pictureBox44.BackgroundImage = Properties.Resources.Black;
            }
            else if (x % 2 == 1)
            {
                pictureBox44.BackgroundImage = Properties.Resources.Red;
            }
        }
        private void pictureBox44_MouseLeave(object sender, EventArgs e)
        {
            pictureBox44.BackgroundImage = null;
        }


        private void pictureBox45_Click(object sender, EventArgs e)
        {
            if (x % 2 == 0)
            {
                Controls["pictureBox" + (40 + r3)].BackgroundImage = Properties.Resources.Black;
                r3 = r3 - 7;
                win3 = win3 + 1;
                x++;
            }
            else if (x % 2 == 1)
            {
                Controls["pictureBox" + (40 + r3)].BackgroundImage = Properties.Resources.Red;
                r3 = r3 - 7;
                win3 = win3 - 1;
                x--;
            }

            if (win3 == 4)
            {
                MessageBox.Show("W");
            }
            else if (win3 == -4)
            {
                MessageBox.Show("L");
            }
        }
        private void pictureBox45_MouseEnter(object sender, EventArgs e)
        {

            if (x % 2 == 0)
            {
                pictureBox45.BackgroundImage = Properties.Resources.Black;
            }
            else if (x % 2 == 1)
            {
                pictureBox45.BackgroundImage = Properties.Resources.Red;
            }

        }
        private void pictureBox45_MouseLeave(object sender, EventArgs e)
        {
            pictureBox45.BackgroundImage = null;
        }


        private void pictureBox46_Click(object sender, EventArgs e)
        {
            if (x % 2 == 0)
            {
                Controls["pictureBox" + (39 + r4)].BackgroundImage = Properties.Resources.Black;
                r4 = r4 - 7;
                win4 = win4 + 1;
                x++;
            }
            else if (x % 2 == 1)
            {
                Controls["pictureBox" + (39 + r4)].BackgroundImage = Properties.Resources.Red;
                r4 = r4 - 7;
                win4 = win4 - 1;
                x--;
            }

            if (win4 == 4)
            {
                MessageBox.Show("W");
            }
            else if (win4 == -4)
            {
                MessageBox.Show("L");
            }
        }
        private void pictureBox46_MouseEnter(object sender, EventArgs e)
        {

            if (x % 2 == 0)
            {
                pictureBox46.BackgroundImage = Properties.Resources.Black;
            }
            else if (x % 2 == 1)
            {
                pictureBox46.BackgroundImage = Properties.Resources.Red;
            }
        }
        private void pictureBox46_MouseLeave(object sender, EventArgs e)
        {
            pictureBox46.BackgroundImage = null;
        }


        private void pictureBox47_Click(object sender, EventArgs e)
        {
            if (x % 2 == 0)
            {
                Controls["pictureBox" + (38 + r5)].BackgroundImage = Properties.Resources.Black;
                r5 = r5 - 7;
                win5 = win5 + 1;
                x++;
            }
            else if (x % 2 == 1)
            {
                Controls["pictureBox" + (38 + r5)].BackgroundImage = Properties.Resources.Red;
                r5 = r5 - 7;
                win5 = win5 - 1;
                x--;
            }

            if (win5 == 4)
            {
                MessageBox.Show("W");
            }
            else if (win5 == -4)
            {
                MessageBox.Show("L");
            }
        }
        private void pictureBox47_MouseEnter(object sender, EventArgs e)
        {

            if (x % 2 == 0)
            {
                pictureBox47.BackgroundImage = Properties.Resources.Black;
            }
            else if (x % 2 == 1)
            {
                pictureBox47.BackgroundImage = Properties.Resources.Red;
            }
        }
        private void pictureBox47_MouseLeave(object sender, EventArgs e)
        {
            pictureBox47.BackgroundImage = null;
        }


        private void pictureBox48_Click(object sender, EventArgs e)
        {
            if (x % 2 == 0)
            {
                Controls["pictureBox" + (37 + r6)].BackgroundImage = Properties.Resources.Black;
                r6 = r6 - 7;
                win6 = win6 + 1;
                x++;
            }
            else if (x % 2 == 1)
            {
                Controls["pictureBox" + (37 + r6)].BackgroundImage = Properties.Resources.Red;
                r6 = r6 - 7;
                win6 = win6 - 1;
                x--;
            }

            if (win6 == 4)
            {
                MessageBox.Show("W");
            }
            else if (win6 == -4)
            {
                MessageBox.Show("L");
            }
        }
        private void pictureBox48_MouseEnter(object sender, EventArgs e)
        {

            if (x % 2 == 0)
            {
                pictureBox48.BackgroundImage = Properties.Resources.Black;
            }
            else if (x % 2 == 1)
            {
                pictureBox48.BackgroundImage = Properties.Resources.Red;
            }
        }
        private void pictureBox48_MouseLeave(object sender, EventArgs e)
        {
            pictureBox48.BackgroundImage = null;
        }


        private void pictureBox49_Click(object sender, EventArgs e)
        {
            if (x % 2 == 0)
            {
                Controls["pictureBox" + (36 + r7)].BackgroundImage = Properties.Resources.Black;
                r7 = r7 - 7;
                win7 = win7 + 1;
                x++;
            }
            else if (x % 2 == 1)
            {
                Controls["pictureBox" + (36 + r7)].BackgroundImage = Properties.Resources.Red;
                r7 = r7 - 7;
                win7 = win7 - 1;
                x--;
            }

            if (win7 == 4)
            {
                MessageBox.Show("W");
            }
            else if (win7 == -4)
            {
                MessageBox.Show("L");
            }
        }
        private void pictureBox49_MouseEnter(object sender, EventArgs e)
        {

            if (x % 2 == 0)
            {
                pictureBox49.BackgroundImage = Properties.Resources.Black;
            }
            else if (x % 2 == 1)
            {
                pictureBox49.BackgroundImage = Properties.Resources.Red;
            }
        }
        private void pictureBox49_MouseLeave(object sender, EventArgs e)
        {
            pictureBox49.BackgroundImage = null;
        }

        }
    }


