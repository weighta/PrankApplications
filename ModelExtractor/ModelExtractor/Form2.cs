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
using System.Speech.Synthesis;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Synth = new SpeechSynthesizer();
            if (button1.Text == "Start" == true)
            {
                Synth.Speak("Stop clicking start twice be patient faggot");
                MessageBox.Show("You can't click Start twice.");
            }
            else
            {
                button1.Text = "Start";
                timer1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            int timewait = ran.Next(200, 1000);
            timer1.Interval = timewait;
            int offset = Convert.ToInt32(label1.Text);
            int next = offset + 1;
            if (next > 330)
            {
                timer1.Enabled = false;
                richTextBox1.Text = "";
                timer2.Enabled = true;
                richTextBox1.Text = "FileModel_Checksums: ";
            }
            else
            {
                label1.Text = ("" + next);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer Synth = new SpeechSynthesizer();
            if (label1.Text == "0")
            {
                MessageBox.Show("You Must Start Drawing Models First.");
            }
            else if (richTextBox1.TextLength < 50 || richTextBox2.TextLength < 3000 || label1.Text == "330" == false)
            {
                Synth.Speak("Models are still drawing be patient faggot.");
                MessageBox.Show("Models Are Still Drawing.");
            }
            else
            {
                MessageBox.Show("Models Parsed!");
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            int timerinterval = ran.Next(50, 500);
            timer2.Interval = (timerinterval);
            int numberofsymbols = ran.Next(2);
            richTextBox1.AppendText("" + ran.Next(0, 10));
            switch (numberofsymbols)
            {
                case 0:
                    {
                        richTextBox1.AppendText("" + ran.Next(9)+"|");
                        break;
                    }
                case 1:
                    {
                        richTextBox1.AppendText("" + ran.Next(9) + ran.Next(9)+"|");
                        break;
                    }
                case 2:
                    {
                        richTextBox1.AppendText("" + ran.Next(9) + ran.Next(9) + ran.Next(9)+"|");
                        break;
                    }
            }
            if (richTextBox1.TextLength == 200 || richTextBox1.TextLength == 201 || richTextBox1.TextLength == 202 || richTextBox1.TextLength == 203)
            {
                timer2.Enabled = false;
                richTextBox2.Text = "";
                timer3.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Closing the application will stop the current process." + Environment.NewLine + "Would you like to load the current .dds textures?", "Model Textures", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            int ranlen = ran.Next(3000, 7000);
            if (richTextBox2.TextLength >= ranlen)
            {
                timer3.Enabled = false;
                button2.Enabled = true;
                MessageBox.Show("Done. Be sure to make vehicle backups before editing!");
            }
            else
            {
                int timerinterval = ran.Next(100, 1500);
                timer3.Interval = timerinterval;
                int modelnum = ran.Next(0, 331) - 1;
                int ranx = ran.Next(10) - 1 + ran.Next(10) - 1 + ran.Next(10) - 1;
                int rany = ran.Next(10) - 1 + ran.Next(10) - 1 + ran.Next(10) - 1;
                int ranz = ran.Next(10) - 1 + ran.Next(10) - 1 + ran.Next(10) - 1;
                int afterxdot = ran.Next(10) - 1 + ran.Next(10);
                int afterydot = ran.Next(10) - 1 + ran.Next(10);
                int afterzdot = ran.Next(10) - 1 + ran.Next(10);
                int num = ran.Next(2) + 1;
                switch (num)
                {
                    case 1:
                        {
                            richTextBox2.AppendText(Environment.NewLine + "Model #" + modelnum + " X: " + ranx + " Y: " + rany + " Z: " + ranz);
                            break;
                        }
                    case 2:
                        {
                            richTextBox2.AppendText(Environment.NewLine + "Model #" + modelnum + " X: " + ranx + "." + afterxdot + " Y: " + rany + "." + afterydot + " Z: " + ranz + "." + afterzdot);
                            break;
                        }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }
    }
}
