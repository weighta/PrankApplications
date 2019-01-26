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

namespace Bitdefender
{
    public partial class Form2 : Form
    {
        Random ran = new Random();
        public Form2()
        {
            this.ControlBox = false;
            InitializeComponent();
            Thread install = new Thread(new ThreadStart(progress));
            install.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progress()
        {
            Thread.Sleep(1500);
            float g = 0.00f;
            while (true)
            {
                char i = Convert.ToChar(ran.Next(0x30, 0x32));
                Invoke(new Action(() => richTextBox1.AppendText(i.ToString())));
                Invoke(new Action(() => progressBar1.Value = (int)g));
                Thread.Sleep(ran.Next(100));

                g += 0.01f;
            }
        }
    }
}
