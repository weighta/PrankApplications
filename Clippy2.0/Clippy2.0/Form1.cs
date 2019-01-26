using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Clippy2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double theta = 1;
        private int a = 0;
        Random ran = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show((int)Math.Abs((30.0 * Math.Sin(theta))) + "");
            timer1.Enabled = false;
            this.Hide();
            
        }
        private void Mouse(int p)
        {
            int xinit = Cursor.Position.X;
            int yinit = Cursor.Position.Y;
            int x_ = 0;
            int y_ = 0;
            for (int i = 0; i <= 360; i += 5)
            {
                formOpacity(i); //USE WITH STATE OF i < 0 < 360
                double x = (Math.PI / 180) * i;

                switch (p)
                {
                    case 0: //CIRCLE
                    {
                        x_ = Cursor.Position.X + (int)((5 * a) * Math.Cos(x));
                        y_ = Cursor.Position.Y + (int)((5 * a) * Math.Sin(x));
                        break;
                    }
                    case 1: //Hourglass Tripple
                    {
                        x_ = Cursor.Position.X + (int)(25 * Math.Sin(x));
                        y_ = Cursor.Position.Y + (int)(25 * Math.Cos(3 * x));
                        break;
                    }
                    case 2:
                    {
                        break;
                    }
                }
                Cursor.Position = new System.Drawing.Point(x_, y_);
                Thread.Sleep(25);
            }
            a++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            Mouse(ran.Next(0, 2));
        }
        private void formOpacity(double x) //USE DOUBLE 0 <= x <= 1;
        {
            x = Math.Sin((Math.PI * x) / 360.0) / 5;
            this.Opacity = x;
        }
    }
}
