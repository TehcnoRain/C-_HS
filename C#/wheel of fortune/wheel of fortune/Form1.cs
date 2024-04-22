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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Form2 lol = new Form2();
            lol.Show();
            this.Hide();
        }

        private void pig_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Form2 lol = new Form2();
            lol.Show();
            this.Hide();
        }

        private void dog_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Form2 lol = new Form2();
            lol.Show();
            this.Hide();
        }

        private void bunny_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            Form2 lol = new Form2();
            lol.Show();
            this.Hide();
        }
    }
}
