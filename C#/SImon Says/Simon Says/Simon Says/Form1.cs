using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int score;
        int SimBox = 4;
        int SimHit;
        int[] SimBoxGo = {0,0,0,0,0,0,0,0,0,0,0,0,0,0 } ;
        int[] UserEnter= {0,0,0,0,0,0,0,0,0,0,0,0,0,0 } ;
        SoundPlayer beep1 = new SoundPlayer(@"F:\New folder (2)\SImon Says\Simon Says\Simon Says\Resources\beep3.wav");
        SoundPlayer beep2 = new SoundPlayer(@"F:\New folder (2)\SImon Says\Simon Says\Simon Says\Resources\beep4.wav");
        SoundPlayer beep3 = new SoundPlayer(@"F:\New folder (2)\SImon Says\Simon Says\Simon Says\Resources\beep5.wav");
        SoundPlayer beep4 = new SoundPlayer(@"F:\New folder (2)\SImon Says\Simon Says\Simon Says\Resources\beep6.wav");
        SoundPlayer beep5 = new SoundPlayer(@"F:\New folder (2)\SImon Says\Simon Says\Simon Says\Resources\beep10.wav");
        SoundPlayer beep6 = new SoundPlayer(@"F:\New folder (2)\SImon Says\Simon Says\Simon Says\Resources\beep23.wav");
        SoundPlayer beep7 = new SoundPlayer(@"F:\New folder (2)\SImon Says\Simon Says\Simon Says\Resources\Horns.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //Start.Enabled = false;
            beep6.Play();
            label1.Text = "Score  " + score.ToString();
            RandDis();
        }

        private void RandDis()
        {
            Random BoxRand = new Random();
            
            for (int i = 0; i < SimBox; i++)
            {
                SimBoxGo[i] = BoxRand.Next(1, 5);
                if (SimBoxGo[i] == 1)
                {
                    beep1.Play();
                    Red.BackColor = Color.FromArgb(255, 192, 192);
                    this.Refresh();
                    Thread.Sleep(500);
                    Red.BackColor = Color.FromArgb(192, 0, 0);
                }

                if (SimBoxGo[i] == 2)
                {
                    beep2.Play();
                    Blue.BackColor = Color.FromArgb(192, 192, 255);
                    this.Refresh();
                    Thread.Sleep(500);
                    Blue.BackColor = Color.FromArgb(0, 0, 192);
                }

                if (SimBoxGo[i] == 3)
                {
                    beep3.Play();
                    Green.BackColor = Color.FromArgb(192, 255, 192);
                    this.Refresh();
                    Thread.Sleep(500);
                    Green.BackColor = Color.FromArgb(0, 192, 0);
                }

                if (SimBoxGo[i] == 4)
                {
                    beep4.Play();
                    Yellow.BackColor = Color.FromArgb(255, 255, 192); 
                    this.Refresh();
                    Thread.Sleep(500);
                    Yellow.BackColor = Color.FromArgb(192, 192, 0);
                }
            }
        }

        private void Red_Click(object sender, EventArgs e)
        {
            int nxtlvl = 0;
            beep1.Play();
            Red.BackColor = Color.FromArgb(255, 192, 192);
            this.Refresh();
            Thread.Sleep(500);
            Red.BackColor = Color.FromArgb(192, 0, 0);
            UserEnter[SimHit] = 1;
            if (SimHit < SimBox)
            {
                SimHit++;
            }
            if (SimHit == SimBox)
            {
                for (int i = 0; i < SimHit; i++)
                {
                    if (SimBoxGo[i] == UserEnter[i])
                    {
                        nxtlvl = 5;
                    }
                }

                if (nxtlvl > SimBox)
                {
                    beep6.Play();
                    score = score + 10;
                    MessageBox.Show("Congratz, now onto the next one!");
                    label1.Text = "Score  " + score.ToString();
                    NxtlvlCheck();
                }

                else
                {
                    beep5.Play();
                    MessageBox.Show("Suckz, better luck next time!");
                    Application.Exit();
                }
        }
    }

        private void Blue_Click(object sender, EventArgs e)
        {
            int nxtlvl = 0;
            beep2.Play();
            Blue.BackColor = Color.FromArgb(192, 192, 255);
            this.Refresh();
            Thread.Sleep(500);
            Blue.BackColor = Color.FromArgb(0, 0, 192);
            UserEnter[SimHit] = 1;
            if (SimHit < SimBox)
            {
                SimHit++;
            }
            if (SimHit == SimBox)
            {
                for (int i = 0; i < SimHit; i++)
                {
                    if (SimBoxGo[i] == UserEnter[i])
                    {
                        nxtlvl = 5;
                    }
                }

                if (nxtlvl > SimBox)
                {
                    beep6.Play();
                    score = score + 10;
                    MessageBox.Show("Congratz, now onto the next one!");
                     label1.Text = "Score  " + score.ToString();
                    NxtlvlCheck();
                }

                else
                {
                    beep5.Play();
                    MessageBox.Show("Suckz, better luck next time!");
                    Application.Exit();
                }
        
        }

        
}

        private void Green_Click(object sender, EventArgs e)
        {
            int nxtlvl = 0;
            beep3.Play();
            Green.BackColor = Color.FromArgb(192, 255, 192);
            this.Refresh();
            Thread.Sleep(500);
            Green.BackColor = Color.FromArgb(0, 192, 0);
            UserEnter[SimHit] = 1;
            if (SimHit < SimBox)
            {
                SimHit++;
            }
            if (SimHit == SimBox)
            {
                for (int i = 0; i < SimHit; i++)
                {
                    if (SimBoxGo[i] == UserEnter[i])
                    {
                        nxtlvl = 5;
                    }
                }

                if (nxtlvl > SimBox)
                {
                    beep6.Play();
                    score = score + 10;
                    MessageBox.Show("Congratz, now onto the next one!");
                     label1.Text = "Score  " + score.ToString();
                    NxtlvlCheck();
                }

                else
                {
                    beep5.Play();
                    MessageBox.Show("Suckz, better luck next time!");
                    Application.Exit();
                }

            }
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            int nxtlvl = 0;
            beep4.Play();
            Yellow.BackColor = Color.FromArgb(255, 255, 192);
            this.Refresh();
            Thread.Sleep(500);
            Yellow.BackColor = Color.FromArgb(192, 192, 0);
            UserEnter[SimHit] = 1;
            if (SimHit < SimBox)
            {
                SimHit++;
            }
            if (SimHit == SimBox)
            {
                for (int i = 0; i < SimHit; i++)
                {
                    if (SimBoxGo[i] == UserEnter[i])
                    {
                        nxtlvl = 5;
                    }
                }

                if (nxtlvl > SimBox)
                {
                    beep6.Play();
                    score = score + 10;
                    MessageBox.Show("Congratz, now onto the next one!");
                     label1.Text = "Score  " + score.ToString();
                    NxtlvlCheck();
                }

                else
                {
                    beep5.Play();
                    MessageBox.Show("Suckz, better luck next time!");
                    Application.Exit();
                }
        }
    }

        private void NxtlvlCheck()
        {
            SimHit = 0;
            label1.Text = "Score  " + score.ToString();
            if (score == 100)
            {
                beep7.Play();
                MessageBox.Show("You Win");
                Application.Exit();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
}
}
