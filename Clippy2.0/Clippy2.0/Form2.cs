using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clippy2._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random ran = new Random();
        private void Form2_Load(object sender, EventArgs e)
        {
            string[] dict = { "Please", "Computer", "Help", "Steam.exe", "tokyobella123", "BUT_face4321", "Zurix", "godsgift210", "hogeater", "xxgrill1232", "poopybutt3", "blue or red", "IM GAYYYY", "IM GAYYYY AYYYY", "tf2trade27", "bigthicfella", "Simonhero1", "spottale", "Kirby ༼ つ ◕_◕ ༽つ", "Spottale", "Tuftin66", "◕◕◕Blender", "Doggo", "RobotBreez", "Faze Carmal", "Smasherslayer" };
            label1.Text = dict[ran.Next(0, dict.Length)];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            
            int phase = ran.Next(100, 2000);
            for (int i = -720; i <= 3250; i++)
            {
                double x = (Math.PI / 180.0) * i;
                this.Location = new Point((int)((50 * Math.Sin(x)) + phase), (int)Math.Abs(i / 2) - 500);
            }
            this.Close();
        }
    }
}
