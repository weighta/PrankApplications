using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Fakeskyper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Random ran = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Who's Calling?
            int switcher = ran.Next(0, 5);
            string name = "";
            switch (switcher)
            {
                case 0:
                    {
                        name = "Jombo23";
                        pictureBox6.Visible = true;
                        break;
                    }
                case 1:
                    {
                        name = " ";
                        pictureBox7.Visible = true;
                        break;
                    }
                case 2:
                    {
                        name = " ";
                        pictureBox8.Visible = true;
                        break;
                    }
                case 3:
                    {
                        pictureBox9.Visible = true;
                        name = "WOLF";
                        break;
                    }
                case 4:
                    {
                        pictureBox10.Visible = true;
                        name = "☭☬𝒇𝓸𝓸𝔁☬☭";
                        break;
                    }
            }
            label1.Text = name + " calling...";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox4.Visible = true;
            Form form = new Form2();
            form.Show();
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox5.Visible = true;
            Thread dumb = new Thread(new ThreadStart(waist));
            dumb.Start();
        }
        
        private void waist()
        {
            Thread.Sleep(100);
            Invoke(new Action(() => this.Close()));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form form1 = new Form3();
            form1.Show();
        }
    }
}
