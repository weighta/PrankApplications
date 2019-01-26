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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == "weighta" && textBox2.Text.ToLower() == "nitro005")
            {
                Form form = new Form4();
                form.Show();
                this.Hide();
            }
            else if (textBox1.Text.ToLower() == "jombo23" && textBox2.Text.ToLower() == "kyleackerman")
            {
                Form form = new Form4();
                form.Show();
                this.Hide();
            }
        }
    }
}
