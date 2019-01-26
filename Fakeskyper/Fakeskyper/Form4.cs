using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakeskyper
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<byte> iList = new List<byte>();
            string stringbyte;
            for (int i = 0; i < textBox1.Text.Length; i += 2)
            {
                stringbyte = (textBox1.Text[i].ToString() + textBox1.Text[i + 1].ToString());
                iList.Add((byte)Convert.ToInt32(stringbyte, 16));
            }
            var decryption = "";
            for (int i = 0; i < iList.Count; i++)
            {
                decryption += Convert.ToChar(iList[i] ^ Convert.ToInt32(textBox2.Text));
            }
            richTextBox1.Text = decryption;
        }
    }
}
