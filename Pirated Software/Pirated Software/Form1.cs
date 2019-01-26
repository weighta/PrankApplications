using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Pirated_Software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.microsoft.com/en-us/servicesagreement");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getInfo();
        }

        private void getInfo()
        {
            string subject = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string ip = new WebClient().DownloadString("http://icanhazip.com");
            label3.Text = "Dear " + subject + " " + ip + ",";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
        }
    }
}
