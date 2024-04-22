using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Pacman
{
    public partial class Form1 : Form
    {
        //variables for left or right and up or down
        int y;
        int x;

        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // starts the loop
            for (x = -1; x < 450; x++)
            {
                if (x % 2 == 0)
                {
                    pacClosed.Hide();
                    pacOpen.Show();
                }
                else
                {
                    pacClosed.Show();
                    pacOpen.Hide();
                }
                if (x == 449)
                {
                    pacOpen.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pacClosed.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                //Moves pacman across screen
                pacClosed.Location = new Point(x, 1);
                pacOpen.Location = new Point(x, 1);
                this.Refresh();
                //3 MilliSecond Pauses
                Thread.Sleep(1);
            }
            for (y = 1; y < 433; y++)
            {
                if (y % 2 == 0)
                {
                    pacClosed.Hide();
                    pacOpen.Show();
                }
                else
                {
                    pacClosed.Show();
                    pacOpen.Hide();
                }
                if (y == 432)
                {
                    pacOpen.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pacClosed.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                //Moves pacman across screen
                pacClosed.Location = new Point(x, y);
                pacOpen.Location = new Point(x, y);
                this.Refresh();
                //3 MilliSecond Pauses
                Thread.Sleep(1);
            }
            for (x = 448; x > -1; x--)
            {
                if (x % 2 == 0)
                {
                    pacClosed.Hide();
                    pacOpen.Show();
                }
                else
                {
                    pacClosed.Show();
                    pacOpen.Hide();
                }
                if (x == 0)
                {
                    pacOpen.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pacClosed.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                //Moves pacman across screen
                pacClosed.Location = new Point(x, y);
                pacOpen.Location = new Point(x, y);
                this.Refresh();
                //3 MilliSecond Pauses
                Thread.Sleep(3);
            }
            for (y = 432; y > 1; y--)
            {
                if (y % 2 == 0)
                {
                    pacClosed.Hide();
                    pacOpen.Show();
                }
                else
                {
                    pacClosed.Show();
                    pacOpen.Hide();
                }
                if (y == 2)
                {
                    pacOpen.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    pacClosed.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                //Moves pacman across screen
                pacClosed.Location = new Point(x, y);
                pacOpen.Location = new Point(x, y);
                this.Refresh();
                //3 MilliSecond Pauses
                Thread.Sleep(3);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //draws pacman at location (-1,1) on screen
            pacOpen.Location = new Point(-1, 1);
            pacClosed.Location = new Point(-1, 1);
        }
    }
}