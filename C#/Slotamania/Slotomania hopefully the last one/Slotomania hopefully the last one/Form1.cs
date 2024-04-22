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
        int ran;
        Image[] FEImages;
        int[] FE;
        int score = 1000;
        Random rand = new Random();
        int line = 1;


        public Form1()
        {
            InitializeComponent();
            label17.Text = score.ToString();
            label18.Text = line.ToString();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label17.Text = score.ToString();
            label18.Text = line.ToString();
            FEImages = new Image[6];
            FEImages[0] = Properties.Resources.Anna;
            FEImages[1] = Properties.Resources.Chrome;
            FEImages[2] = Properties.Resources.Emelina;
            FEImages[3] = Properties.Resources.Henry;
            FEImages[4] = Properties.Resources.Marth;
            FEImages[5] = Properties.Resources.Ronku;

            FE = new int[5] { 0, 0, 0, 0, 0 };
            Win();
            

        }
        private void RandomFE()
        {
            label17.Text = score.ToString();
            for (int i = 1; i <= 15; i++)
            {
                label17.Text = score.ToString();
                ran = rand.Next(0, 6);
                Controls["label" + i].BackgroundImage = FEImages[ran];
            }
            Win();
        }

        private void Bonus()
        {

        }

        private void Line()
        {
            if (line == 1)
            {
            }
        }

        private void Win()
        {
           
            for (int i = 0; i <= 5; i++)
            {
                label17.Text = score.ToString();
                
                if (line >= 1)
                {

                    
                        if (label1.BackgroundImage == FEImages[i] && label2.BackgroundImage == FEImages[i] && label3.BackgroundImage == FEImages[i] && label4.BackgroundImage == FEImages[i] && label5.BackgroundImage == FEImages[i])
                        {
                            score = score + 1000;
                            MessageBox.Show("1000 Points Earned");

                        }
                        else if (label1.BackgroundImage == FEImages[i] && label2.BackgroundImage == FEImages[i] && label3.BackgroundImage == FEImages[i] && label4.BackgroundImage == FEImages[i])
                        {
                            score = score + 300;
                            MessageBox.Show("300 Points Earned");
                        }
                        else if (label1.BackgroundImage == FEImages[i] && label2.BackgroundImage == FEImages[i] && label3.BackgroundImage == FEImages[i])
                        {
                            score = score + 100;
                            MessageBox.Show("100 Points Earned");
                        }
                    
                }
                if (line >= 2)
                {
                    {
                        if (label6.BackgroundImage == FEImages[i] && label7.BackgroundImage == FEImages[i] && label8.BackgroundImage == FEImages[i] && label9.BackgroundImage == FEImages[i] && label10.BackgroundImage == FEImages[i])
                        {
                            score = score + 1000;
                            MessageBox.Show("1000 Points Earned");
                        }
                        else if (label6.BackgroundImage == FEImages[i] && label7.BackgroundImage == FEImages[i] && label8.BackgroundImage == FEImages[i] && label9.BackgroundImage == FEImages[i])
                        {
                            score = score + 300;
                            MessageBox.Show("300 Points Earned");
                        }
                        else if (label6.BackgroundImage == FEImages[i] && label7.BackgroundImage == FEImages[i] && label8.BackgroundImage == FEImages[i])
                        {
                            score = score + 100;
                            MessageBox.Show("100 Points Earned");
                        }
                    }
                }
                {
                    if (line >= 3)
                    {
                        if (label11.BackgroundImage == FEImages[i] && label12.BackgroundImage == FEImages[i] && label13.BackgroundImage == FEImages[i] && label14.BackgroundImage == FEImages[i] && label15.BackgroundImage == FEImages[i])
                        {
                            score = score + 1000;
                            MessageBox.Show("1000 Points Earned");
                        }
                        else if (label11.BackgroundImage == FEImages[i] && label12.BackgroundImage == FEImages[i] && label13.BackgroundImage == FEImages[i] && label14.BackgroundImage == FEImages[i])
                        {
                            score = score + 300;
                            MessageBox.Show("300 Points Earned");
                        }
                        else if (label11.BackgroundImage == FEImages[i] && label12.BackgroundImage == FEImages[i] && label13.BackgroundImage == FEImages[i])
                        {
                            score = score + 100;
                            MessageBox.Show("100 Points Earned");
                        }
                    }

                    if (line >= 4)
                    {
                        {
                            if (label6.BackgroundImage == FEImages[i] && label2.BackgroundImage == FEImages[i] && label3.BackgroundImage == FEImages[i] && label4.BackgroundImage == FEImages[i] && label10.BackgroundImage == FEImages[i])
                            {
                                score = score + 1000;
                                MessageBox.Show("1000 Points Earned");
                            }
                            else if (label6.BackgroundImage == FEImages[i] && label2.BackgroundImage == FEImages[i] && label3.BackgroundImage == FEImages[i] && label4.BackgroundImage == FEImages[i])
                            {
                                score = score + 300;
                                MessageBox.Show("300 Points Earned");
                            }
                            else if (label6.BackgroundImage == FEImages[i] && label2.BackgroundImage == FEImages[i] && label3.BackgroundImage == FEImages[i])
                            {
                                score = score + 100;
                                MessageBox.Show("100 Points Earned");
                            }
                        }
                    }
                    {
                        if (line >= 5)
                        {
                            if (label6.BackgroundImage == FEImages[i] && label12.BackgroundImage == FEImages[i] && label13.BackgroundImage == FEImages[i] && label14.BackgroundImage == FEImages[i] && label10.BackgroundImage == FEImages[i])
                            {
                                score = score + 1000;
                                MessageBox.Show("1000 Points Earned");
                            }
                            else if (label6.BackgroundImage == FEImages[i] && label12.BackgroundImage == FEImages[i] && label13.BackgroundImage == FEImages[i] && label14.BackgroundImage == FEImages[i])
                            {
                                score = score + 300;
                                MessageBox.Show("300 Points Earned");
                            }
                            else if (label6.BackgroundImage == FEImages[i] && label12.BackgroundImage == FEImages[i] && label13.BackgroundImage == FEImages[i])
                            {
                                score = score + 100;
                                MessageBox.Show("100 Points Earned");

                            }
                        }


                    }
                }
            }
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label16.BackgroundImage = FEImages[1];
            //if (label16.BackgroundImage == FEImages[1])
            //{
            //    MessageBox.Show("hi");
            //}
            label17.Text = score.ToString();
            score = score - 25;
            RandomFE();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            line = line + 1;
            if (line == 6)
            {
                line = 5;
            }
            label18.Text = line.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            line = line - 1;
            if(line == 0)
            {
                line = 1;
            }
            label18.Text = line.ToString();
        }

      
    
    }
}


//label1.Image = FEImages[FE[0]];
//label2.Image = FEImages[FE[1]];
//label3.Image = FEImages[FE[2]];
//label4.Image = FEImages[FE[3]];
//label5.Image = FEImages[FE[4]];
//label6.Image = FEImages[FE[5]];
//label7.Image = FEImages[FE[6]];
//label8.Image = FEImages[FE[7]];
//label9.Image = FEImages[FE[8]];
//label10.Image = FEImages[FE[9]];
//label11.Image = FEImages[FE[10]];
//label12.Image = FEImages[FE[11]];
//label13.Image = FEImages[FE[12]];
//label14.Image = FEImages[FE[13]];
//label15.Image = FEImages[FE[14]];