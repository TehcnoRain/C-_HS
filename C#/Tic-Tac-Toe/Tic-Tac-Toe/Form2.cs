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
    public partial class Form2 : Form
    {
        int turn=1;
        int click1 = 0;
        int click2 = 0;
        int click3 = 0;
        int click4 = 0;
        int click5 = 0;
        int click6 = 0;
        int click7 = 0;
        int click8 = 0;
        int click9 = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (click1 == 0)
            {
                if (turn % 2 != 0)
                {
                    button1.Text = "X";
                }
                else
                {
                    button1.Text = "O";
                }
                turn++;
                click1++;
            }
            else
            {
                button1.Text = button1.Text;
            }
            display();
            checkit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (click2 == 0)
            {
                if (turn % 2 != 0)
                {
                    button2.Text = "X";
                }
                else
                {
                    button2.Text = "O";
                }
                turn++;
                click2++;
            }
            else
            {
                button2.Text = button2.Text;
            }
            display();
            checkit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (click3 == 0)
            {
                if (turn % 2 != 0)
                {
                    button3.Text = "X";
                }
                else
                {
                    button3.Text = "O";
                }
                turn++;
                click3++;
            }
            else
            {
                button3.Text = button3.Text;
            }
            display();
            checkit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (click4 == 0)
            {
                if (turn % 2 != 0)
                {
                    button4.Text = "X";
                }
                else
                {
                    button4.Text = "O";
                }
                turn++;
                click4++;
            }
            else
            {
                button4.Text = button4.Text;
            }
            display();
            checkit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (click5 == 0)
            {
                if (turn % 2 != 0)
                {
                    button5.Text = "X";
                }
                else
                {
                    button5.Text = "O";
                }
                turn++;
                click5++;
            }
            else
            {
                button5.Text = button5.Text;
            }
            display();
            checkit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (click6 == 0)
            {
                if (turn % 2 != 0)
                {
                    button6.Text = "X";
                }
                else
                {
                    button6.Text = "O";
                }
                turn++;
                click6++;
            }
            else
            {
                button6.Text = button6.Text;
            }
            display();
            checkit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (click7 == 0)
            {
                if (turn % 2 != 0)
                {
                    button7.Text = "X";
                }
                else
                {
                    button7.Text = "O";
                }
                turn++;
                click7++;
            }
            else
            {
                button7.Text = button7.Text;
            }
            display();
            checkit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (click8 == 0)
            {
                if (turn % 2 != 0)
                {
                    button8.Text = "X";
                }
                else
                {
                    button8.Text = "O";
                }
                turn++;
                click8++;
            }
            else
            {
                button8.Text = button8.Text;
            }
            display();
            checkit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (click9 == 0)
            {
                if (turn % 2 != 0)
                {
                    button9.Text = "X";
                }
                else
                {
                    button9.Text = "O";
                }
                turn++;
                click9++;
            }
            else
            {
                button9.Text = button9.Text;
            }
            display();
            checkit();
        }
       
        public void display()
        {
            if (turn % 2 != 0)
            {
                
            }
            else
            {
                
            }
        }
        
        public void checkit()
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                if (button1.Text == button2.Text && button1.Text == button3.Text)
                {
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    button2.BackColor = Color.Green;
                    button2.ForeColor = Color.White;
                    button3.BackColor = Color.Green;
                    button3.ForeColor = Color.White;
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        
                    }
                    Application.Restart();
                }
            }
            if (button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                if (button4.Text == button5.Text && button4.Text == button6.Text)
                {
                    button4.BackColor = Color.Green;
                    button4.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button6.BackColor = Color.Green;
                    button6.ForeColor = Color.White;
                    if (button4.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");

                    }
                    Application.Restart();
                }
            }
            if (button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if (button7.Text == button8.Text && button7.Text == button9.Text)
                {
                    button7.BackColor = Color.Green;
                    button7.ForeColor = Color.White;
                    button8.BackColor = Color.Green;
                    button8.ForeColor = Color.White;
                    button9.BackColor = Color.Green;
                    button9.ForeColor = Color.White;
                    if (button7.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");

                    }
                    Application.Restart();
                }
            }
            if (button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                if (button1.Text == button4.Text && button1.Text == button7.Text)
                {
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    button4.BackColor = Color.Green;
                    button4.ForeColor = Color.White;
                    button7.BackColor = Color.Green;
                    button7.ForeColor = Color.White;
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");

                    }
                    Application.Restart();
                }
            }
            if (button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                if (button2.Text == button5.Text && button2.Text == button8.Text)
                {
                    button2.BackColor = Color.Green;
                    button2.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button8.BackColor = Color.Green;
                    button8.ForeColor = Color.White;
                    if (button2.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");

                    }
                    Application.Restart();
                }
            }
            if (button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                if (button3.Text == button6.Text && button3.Text == button9.Text)
                {
                    button3.BackColor = Color.Green;
                    button3.ForeColor = Color.White;
                    button6.BackColor = Color.Green;
                    button6.ForeColor = Color.White;
                    button9.BackColor = Color.Green;
                    button9.ForeColor = Color.White;
                    if (button3.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");

                    }
                    Application.Restart();
                }
            }
            if (button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                if (button1.Text == button5.Text && button1.Text == button9.Text)
                {
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button9.BackColor = Color.Green;
                    button9.ForeColor = Color.White;
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");

                    }
                    Application.Restart();
                }
            }
            if (button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                if (button3.Text == button5.Text && button1.Text == button7.Text)
                {
                    button3.BackColor = Color.Green;
                    button3.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button9.BackColor = Color.Green;
                    button9.ForeColor = Color.White;
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");

                    }

                    Application.Restart();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

  
    }
}
