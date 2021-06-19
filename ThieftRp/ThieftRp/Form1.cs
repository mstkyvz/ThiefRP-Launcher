using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThieftRp
{
    public partial class Form1 : Form
    {
        public string Ip { get; set; }
        public int Port { get; set; }
        public Form1()
        {
            InitializeComponent();
            Ip = "5.1.1.1";
            Port = 30120;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/TPFhBuz");   ///teamspeak 3
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"fivem://connect/{Ip}:{Port}");//server bağlan
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/TPFhBuz"); ///DİSCORD
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();   ///programı durdur .d
        }
    }
}
