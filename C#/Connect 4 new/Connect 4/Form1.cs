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

        string win1;
        string win2;
        string win3;
        string win4;
        string win5;
        string win6;
        string win7;
        string win8;
        string win9;
        string win10;
        string win11;
        string win12;
        string win13;

        public Form1()
        {
            InitializeComponent();
            WinH();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WinH();
        }
            
        private void pictureBox43_Click(object sender, EventArgs e)
        {
            WinH();
            if (x % 2 == 0)
            {
                WinH();
                Controls["pictureBox" + (42 + r1)].BackgroundImage = Properties.Resources.Black;
                r1 = r1 - 7;
                win1 = win1 + "1";
                x++;
            }
            else if (x % 2 == 1)
            {
                WinH();
                Controls["pictureBox" + (42 + r1)].BackgroundImage = Properties.Resources.Red;
                r1 = r1 - 7;
                win1 = win1 + "0";
                x--;
            }

            if (win1.Contains("1111")) 
            {
                MessageBox.Show("W");
            }
            else if (win1.Contains("0000")) 
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
            WinH();
            if (x % 2 == 0)
            {
                WinH();
                Controls["pictureBox" + (41 + r2)].BackgroundImage = Properties.Resources.Black;
                r2 = r2 - 7;
                win2 = win2 + "1";
                x++;
            }
            else if (x % 2 == 1)
            {
                WinH();
                Controls["pictureBox" + (41 + r2)].BackgroundImage = Properties.Resources.Red;
               r2 = r2 - 7;
               win2 = win2 + "0";
                x--;
            }

           if (win2.Contains("1111")) 
            {
                MessageBox.Show("W");
            }
            else if (win2.Contains("0000")) 
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
            WinH();
            if (x % 2 == 0)
            {
                WinH();
                Controls["pictureBox" + (40 + r3)].BackgroundImage = Properties.Resources.Black;
                r3 = r3 - 7;
                win3 = win3 + "1";
                x++;
            }
            else if (x % 2 == 1)
            {
                WinH();
                Controls["pictureBox" + (40 + r3)].BackgroundImage = Properties.Resources.Red;
                r3 = r3 - 7;
                win3 = win3 + "0";
                x--;
            }

            if (win3.Contains("1111"))
            {
                MessageBox.Show("W");
            }
            else if (win3.Contains("0000"))
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
            WinH();
            if (x % 2 == 0)
            {
                WinH();
                Controls["pictureBox" + (39 + r4)].BackgroundImage = Properties.Resources.Black;
                r4 = r4 - 7;
                win4 = win4 + "1";
                x++;
            }
            else if (x % 2 == 1)
            {
                WinH();
                Controls["pictureBox" + (39 + r4)].BackgroundImage = Properties.Resources.Red;
                r4 = r4 - 7;
                win4 = win4 + "0";
                x--;
            }

            if (win4.Contains("1111"))
            {
                MessageBox.Show("W");
            }
            else if (win4.Contains("0000"))
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
            WinH();
            if (x % 2 == 0)
            {
                WinH();
                Controls["pictureBox" + (38 + r5)].BackgroundImage = Properties.Resources.Black;
                r5 = r5 - 7;
                win5 = win5 + "1";
                x++;
            }
            else if (x % 2 == 1)
            {
                WinH();
                Controls["pictureBox" + (38 + r5)].BackgroundImage = Properties.Resources.Red;
                r5 = r5 - 7;
                win5 = win5 + "0";
                x--;
            }

            if (win5.Contains("1111"))
            {
                MessageBox.Show("W");
            }
            else if (win5.Contains("0000"))
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
            WinH();
            if (x % 2 == 0)
            {
                WinH();
                Controls["pictureBox" + (37 + r6)].BackgroundImage = Properties.Resources.Black;
                r6 = r6 - 7;
                win6 = win6 + "1";
                x++;
            }
            else if (x % 2 == 1)
            {
                WinH();
                Controls["pictureBox" + (37 + r6)].BackgroundImage = Properties.Resources.Red;
                r6 = r6 - 7;
                win6 = win6 + "0";
                x--;
            }

            if (win6.Contains("1111"))
            {
                MessageBox.Show("W");
            }
            else if (win6.Contains("0000"))
            {
                MessageBox.Show("L");
            }
            WinH();
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
            WinH();
            if (x % 2 == 0)
            {
                WinH();
                Controls["pictureBox" + (36 + r7)].BackgroundImage = Properties.Resources.Black;
                r7 = r7 - 7;
                win7 = win7 + "1";
                x++;
            }
            else if (x % 2 == 1)
            {
                WinH();
                Controls["pictureBox" + (36 + r7)].BackgroundImage = Properties.Resources.Red;
                r7 = r7 - 7;
                win7 = win7 + "0";
                x--;
            }

            if (win7.Contains("1111"))
            {
                MessageBox.Show("W");
            }
            else if (win7.Contains("0000"))
            {
                MessageBox.Show("L");
            }
            WinH();
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

        public void WinH()
        {
            if (pictureBox7.BackgroundImage == Properties.Resources.Black && pictureBox6.BackgroundImage == Properties.Resources.Black && pictureBox5.BackgroundImage == Properties.Resources.Black && pictureBox4.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox7.BackgroundImage == Properties.Resources.Red && pictureBox6.BackgroundImage == Properties.Resources.Red && pictureBox5.BackgroundImage == Properties.Resources.Red && pictureBox4.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }
            if (pictureBox6.BackgroundImage == Properties.Resources.Black && pictureBox5.BackgroundImage == Properties.Resources.Black && pictureBox4.BackgroundImage == Properties.Resources.Black && pictureBox3.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox6.BackgroundImage == Properties.Resources.Red && pictureBox5.BackgroundImage == Properties.Resources.Red && pictureBox4.BackgroundImage == Properties.Resources.Red && pictureBox3.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }
            if (pictureBox5.BackgroundImage == Properties.Resources.Black && pictureBox4.BackgroundImage == Properties.Resources.Black && pictureBox3.BackgroundImage == Properties.Resources.Black && pictureBox2.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox5.BackgroundImage == Properties.Resources.Red && pictureBox4.BackgroundImage == Properties.Resources.Red && pictureBox3.BackgroundImage == Properties.Resources.Red && pictureBox2.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }
            if (pictureBox4.BackgroundImage == Properties.Resources.Black && pictureBox3.BackgroundImage == Properties.Resources.Black && pictureBox2.BackgroundImage == Properties.Resources.Black && pictureBox1.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox4.BackgroundImage == Properties.Resources.Red && pictureBox3.BackgroundImage == Properties.Resources.Red && pictureBox2.BackgroundImage == Properties.Resources.Red && pictureBox1.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }



            if (pictureBox14.BackgroundImage == Properties.Resources.Black && pictureBox13.BackgroundImage == Properties.Resources.Black && pictureBox12.BackgroundImage == Properties.Resources.Black && pictureBox11.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox14.BackgroundImage == Properties.Resources.Red && pictureBox13.BackgroundImage == Properties.Resources.Red && pictureBox12.BackgroundImage == Properties.Resources.Red && pictureBox11.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }
            if (pictureBox13.BackgroundImage == Properties.Resources.Black && pictureBox12.BackgroundImage == Properties.Resources.Black && pictureBox11.BackgroundImage == Properties.Resources.Black && pictureBox10.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox13.BackgroundImage == Properties.Resources.Red && pictureBox12.BackgroundImage == Properties.Resources.Red && pictureBox11.BackgroundImage == Properties.Resources.Red && pictureBox10.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }
            if (pictureBox12.BackgroundImage == Properties.Resources.Black && pictureBox11.BackgroundImage == Properties.Resources.Black && pictureBox10.BackgroundImage == Properties.Resources.Black && pictureBox9.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox12.BackgroundImage == Properties.Resources.Red && pictureBox11.BackgroundImage == Properties.Resources.Red && pictureBox10.BackgroundImage == Properties.Resources.Red && pictureBox9.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }
            if (pictureBox11.BackgroundImage == Properties.Resources.Black && pictureBox10.BackgroundImage == Properties.Resources.Black && pictureBox9.BackgroundImage == Properties.Resources.Black && pictureBox8.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox11.BackgroundImage == Properties.Resources.Red && pictureBox10.BackgroundImage == Properties.Resources.Red && pictureBox9.BackgroundImage == Properties.Resources.Red && pictureBox8.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }



            if (pictureBox21.BackgroundImage == Properties.Resources.Black && pictureBox20.BackgroundImage == Properties.Resources.Black && pictureBox19.BackgroundImage == Properties.Resources.Black && pictureBox18.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox21.BackgroundImage == Properties.Resources.Red && pictureBox20.BackgroundImage == Properties.Resources.Red && pictureBox19.BackgroundImage == Properties.Resources.Red && pictureBox18.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }
            if (pictureBox20.BackgroundImage == Properties.Resources.Black && pictureBox19.BackgroundImage == Properties.Resources.Black && pictureBox18.BackgroundImage == Properties.Resources.Black && pictureBox17.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox20.BackgroundImage == Properties.Resources.Red && pictureBox19.BackgroundImage == Properties.Resources.Red && pictureBox18.BackgroundImage == Properties.Resources.Red && pictureBox17.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }
            if (pictureBox19.BackgroundImage == Properties.Resources.Black && pictureBox18.BackgroundImage == Properties.Resources.Black && pictureBox17.BackgroundImage == Properties.Resources.Black && pictureBox16.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox19.BackgroundImage == Properties.Resources.Red && pictureBox18.BackgroundImage == Properties.Resources.Red && pictureBox17.BackgroundImage == Properties.Resources.Red && pictureBox16.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }
            if (pictureBox18.BackgroundImage == Properties.Resources.Black && pictureBox17.BackgroundImage == Properties.Resources.Black && pictureBox16.BackgroundImage == Properties.Resources.Black && pictureBox15.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox18.BackgroundImage == Properties.Resources.Red && pictureBox17.BackgroundImage == Properties.Resources.Red && pictureBox16.BackgroundImage == Properties.Resources.Red && pictureBox15.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }



            if (pictureBox28.BackgroundImage == Properties.Resources.Black && pictureBox27.BackgroundImage == Properties.Resources.Black && pictureBox26.BackgroundImage == Properties.Resources.Black && pictureBox25.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox28.BackgroundImage == Properties.Resources.Red && pictureBox27.BackgroundImage == Properties.Resources.Red && pictureBox26.BackgroundImage == Properties.Resources.Red && pictureBox25.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }
            if (pictureBox27.BackgroundImage == Properties.Resources.Black && pictureBox26.BackgroundImage == Properties.Resources.Black && pictureBox25.BackgroundImage == Properties.Resources.Black && pictureBox24.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox27.BackgroundImage == Properties.Resources.Red && pictureBox26.BackgroundImage == Properties.Resources.Red && pictureBox25.BackgroundImage == Properties.Resources.Red && pictureBox24.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }
            if (pictureBox26.BackgroundImage == Properties.Resources.Black && pictureBox25.BackgroundImage == Properties.Resources.Black && pictureBox24.BackgroundImage == Properties.Resources.Black && pictureBox23.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox26.BackgroundImage == Properties.Resources.Red && pictureBox25.BackgroundImage == Properties.Resources.Red && pictureBox24.BackgroundImage == Properties.Resources.Red && pictureBox23.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }
            if (pictureBox25.BackgroundImage == Properties.Resources.Black && pictureBox24.BackgroundImage == Properties.Resources.Black && pictureBox23.BackgroundImage == Properties.Resources.Black && pictureBox22.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox25.BackgroundImage == Properties.Resources.Red && pictureBox24.BackgroundImage == Properties.Resources.Red && pictureBox23.BackgroundImage == Properties.Resources.Red && pictureBox22.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }



            if (pictureBox35.BackgroundImage == Properties.Resources.Black && pictureBox34.BackgroundImage == Properties.Resources.Black && pictureBox33.BackgroundImage == Properties.Resources.Black && pictureBox32.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox35.BackgroundImage == Properties.Resources.Red && pictureBox34.BackgroundImage == Properties.Resources.Red && pictureBox33.BackgroundImage == Properties.Resources.Red && pictureBox32.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }
            if (pictureBox34.BackgroundImage == Properties.Resources.Black && pictureBox33.BackgroundImage == Properties.Resources.Black && pictureBox32.BackgroundImage == Properties.Resources.Black && pictureBox31.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox34.BackgroundImage == Properties.Resources.Red && pictureBox33.BackgroundImage == Properties.Resources.Red && pictureBox32.BackgroundImage == Properties.Resources.Red && pictureBox31.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }
            if (pictureBox33.BackgroundImage == Properties.Resources.Black && pictureBox32.BackgroundImage == Properties.Resources.Black && pictureBox31.BackgroundImage == Properties.Resources.Black && pictureBox30.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox33.BackgroundImage == Properties.Resources.Red && pictureBox32.BackgroundImage == Properties.Resources.Red && pictureBox31.BackgroundImage == Properties.Resources.Red && pictureBox30.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }
            if (pictureBox32.BackgroundImage == Properties.Resources.Black && pictureBox31.BackgroundImage == Properties.Resources.Black && pictureBox30.BackgroundImage == Properties.Resources.Black && pictureBox29.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox32.BackgroundImage == Properties.Resources.Red && pictureBox31.BackgroundImage == Properties.Resources.Red && pictureBox30.BackgroundImage == Properties.Resources.Red && pictureBox29.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }



            if (pictureBox42.BackgroundImage == Properties.Resources.Black && pictureBox41.BackgroundImage == Properties.Resources.Black && pictureBox40.BackgroundImage == Properties.Resources.Black && pictureBox39.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox42.BackgroundImage == Properties.Resources.Red && pictureBox41.BackgroundImage == Properties.Resources.Red && pictureBox40.BackgroundImage == Properties.Resources.Red && pictureBox39.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }
            if (pictureBox41.BackgroundImage == Properties.Resources.Black && pictureBox40.BackgroundImage == Properties.Resources.Black && pictureBox39.BackgroundImage == Properties.Resources.Black && pictureBox38.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox41.BackgroundImage == Properties.Resources.Red && pictureBox40.BackgroundImage == Properties.Resources.Red && pictureBox39.BackgroundImage == Properties.Resources.Red && pictureBox38.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }
            if (pictureBox40.BackgroundImage == Properties.Resources.Black && pictureBox39.BackgroundImage == Properties.Resources.Black && pictureBox38.BackgroundImage == Properties.Resources.Black && pictureBox37.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox40.BackgroundImage == Properties.Resources.Red && pictureBox39.BackgroundImage == Properties.Resources.Red && pictureBox38.BackgroundImage == Properties.Resources.Red && pictureBox37.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }
            if (pictureBox39.BackgroundImage == Properties.Resources.Black && pictureBox38.BackgroundImage == Properties.Resources.Black && pictureBox37.BackgroundImage == Properties.Resources.Black && pictureBox36.BackgroundImage == Properties.Resources.Black)
            {
                MessageBox.Show("Player One Wins");
            }
            if (pictureBox39.BackgroundImage == Properties.Resources.Red && pictureBox38.BackgroundImage == Properties.Resources.Red && pictureBox37.BackgroundImage == Properties.Resources.Red && pictureBox36.BackgroundImage == Properties.Resources.Red)
            {
                MessageBox.Show("Player Two Wins");
            }

        }
        }
    }


