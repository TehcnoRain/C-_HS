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
        int[] i = new int[] { 1, 2, 5, 10, 25, 50, 75, 100, 200, 300, 400, 500, 750, 1000, 5000, 10000, 25000, 50000, 75000, 100000, 200000, 300000, 400000, 500000, 750000, 1000000 };
        int[] y = new int[] { 1, 2, 5, 10, 25, 50, 75, 100, 200, 300, 400, 500, 750, 1000, 5000, 10000, 25000, 50000, 75000, 100000, 200000, 300000, 400000, 500000, 750000, 1000000 };
        int c,o,u;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            i = ShuffleArray(i);
        }

        private void Box1_Click(object sender, EventArgs e)
        {
            c++;
            Button g = (Button)sender;
            g.Hide();
            if (c == 1)
            {
                BoxTake.Show();
                BoxTake.Text = g.Text;
            }
            if (c == 6) {u = 0; o = 0; lol();}
            if (c == 11) {u = 0; o = 0; lol();}
            if (c == 15) {u = 0; o = 0; lol();}
            if (c == 18) {u = 0; o = 0; lol();}
            if (c == 20) {u = 0; o = 0; lol();}
            if (c == 21) { u = 0; o = 0; lol();}
            if (c >= 22) { u = 0; o = 0; lol(); }

            if (c != 1)
            {
                for (int q = 0; q <= 25; q++)
                {
                    if (i[Convert.ToInt32(g.Name.Replace("Box", "")) - 1] == y[q])
                    {
                        i[Convert.ToInt32(g.Name.Replace("Box", "")) - 1] = 0;
                        Controls["Open" + (q + 1)].Show();
                    }
                }
            }
        }

        int[] ShuffleArray(int[] i)
        {
            Random r = new Random();
            for (int q = i.Length; q > 0; q--)
            {
                int j = r.Next(q);
                int k = i[j];
                i[j] = i[q - 1];
               i[q - 1] = k;
            }
            return i;
        }
    
        private void lol()
        {
            for (int q = 0; q <= 25; q++)
            {
                if (i[q] != 0)
                {
                    u++;
                    o = o + i[q];
                }
            }
            DialogResult dialogResult = MessageBox.Show("Deal Or No Deal? " + o / u, "Offer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("You Have Won " + o / u);
                    MessageBox.Show("The value of the box you have chosen is " + i[Convert.ToInt32(BoxTake.Text)-1].ToString());
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            
            
        }

        private void BoxTake_Click(object sender, EventArgs e)
        {
          //for (int q = 0; q <= 25; q++)
          //  {
          //      MessageBox.Show(i[q].ToString());
          //  }
        }
        }
    }
