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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            Thread install = new Thread(new ThreadStart(progress));
            install.Start();
        }
        Random ran = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void progress()
        {
            for(int i = 0; i < 1000; i++)
            {
                Invoke(new Action(() => progressBar1.Value = (i/10)));
                Thread.Sleep(100);
            }
            Invoke(new Action(() => this.Hide()));
            MessageBox.Show("Complete" + Environment.NewLine + "Thank you for installing Bit defender.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit the installation?", "Exit Installer?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("why");
                Form uninstall = new Form2();
                uninstall.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
