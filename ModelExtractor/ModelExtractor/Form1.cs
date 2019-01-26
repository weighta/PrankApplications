using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program coded in C# by: Antonio"+Environment.NewLine+"1) Open a script (If Desired)"+Environment.NewLine+"2) Open 'connect_gmod.exe'"+Environment.NewLine + "If you have done this part correctly you should be able to move ragdolls remotely from this program." + Environment.NewLine + "Any Questions? Send me an email at antoniodman@gmail.com"+Environment.NewLine + "Additionally, .dds error has been fixed as well and will be rendered if not DXT2, then DXT5.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            if (textBox1.Text.Contains(".txt") == true && textBox1.Text.Contains(":") == true)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Open A Script File Or Create One";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        timer2.Enabled = true;
                        checkBox2.Enabled = true;
                        BinaryReader br = new BinaryReader(File.OpenRead(ofd.FileName));
                        string filename = ofd.FileName;
                        string vehiclecode = null;
                        // Get Address Of Whatever
                        for (int i = 0x0; i <= 0xff; i++)
                        {
                            br.BaseStream.Position = i;
                            vehiclecode += br.ReadByte().ToString("X2");
                        }
                        richTextBox1.Text = vehiclecode;
                        DialogResult dialogResult = MessageBox.Show("Would You Like To Render Ragdol Joints From: " + message + "?", "Script Import", MessageBoxButtons.YesNo);

                        radioButton1.Text = ("" + filename);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Form2 frm2 = new Form2();
                            frm2.Show();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            button5.Enabled = true;
                        }
                    }
                    catch(Exception EX)
                    {
                        MessageBox.Show("Error: " + EX);
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Directory: "+message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MessageBox.Show(".obj Saved!");
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }
        public void EnablePicture()
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Specular On")
            {
                label1.Text = ("Specular Off");
            }
            else if (label1.Text == "Specular Off")
            {
                label1.Text = ("Specular On");
            }
            else
            {
                MessageBox.Show("What?");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Visible = false;
            timer1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                radioButton1.Enabled = true;
            }
            else if (checkBox1.Checked == false)
            {
                radioButton1.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (richTextBox1.Text == "")
                {
                    MessageBox.Show("You have not opened a script file.");
                }
                else
                {
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (richTextBox1.Text == "")
                {
                    MessageBox.Show("You have not opened a vehicle file.");
                }
                else
                {
                    string dir = textBox1.Text;
                    DialogResult dialogResult = MessageBox.Show("This filetype requires one or more specular indicies from " + dir + Environment.NewLine + "Would you like to load the missing model fileparts?", "Allocating Mesh Files", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Form2 frm2 = new Form2();
                        frm2.Show();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        button5.Enabled = true;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            int fps = ran.Next(50,70);
            label4.Text = "FPS: " + fps;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label4.Visible=true;
            }
            else
            {
                label4.Visible=false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                Random ran = new Random();
                int ranvar = ran.Next(1, 3);
                int ranvar1 = ran.Next(1, 3000);
                Thread.Sleep(ranvar1);
                switch (ranvar)
                {
                    case 1:
                        {
                            MessageBox.Show("connect_gmod.exe is not currently active");
                            break;
                        }
                    case 2:
                        {
                            MessageBox.Show("hl2.exe Connected!");
                            break;
                        }
                }
            }
            else
            {
                Random ran = new Random();
                int ranvar1 = ran.Next(1, 3000);
                Thread.Sleep(ranvar1);
                MessageBox.Show("1) You must check 'connect_gmod.exe Is currently running'" + Environment.NewLine + "2) connect_gmod.exe is not currently active", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                Random ran = new Random();
                int ranvar = ran.Next(1, 5);
                int ranvar1 = ran.Next(1, 3000);
                Thread.Sleep(ranvar1);
                switch (ranvar)
                {
                    case 1:
                        {
                            MessageBox.Show("connect_gmod.exe is not currently active");
                            break;
                        }
                    case 2:
                        {
                            MessageBox.Show("connect_gmod.exe is not currently active");
                            break;
                        }
                    case 3:
                        {
                            timer3.Enabled = true;
                            label20.Visible = true;
                            break;
                        }
                    case 4:
                        {
                            MessageBox.Show("connect_gmod.exe is not currently active");
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("You have not checked 'connect_gmod.exe Is currently running'");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label20.Visible = false;
            timer3.Enabled = false;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            else
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MessageBox.Show(".txt Script Saved!");
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
