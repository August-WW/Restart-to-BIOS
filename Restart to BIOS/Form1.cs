using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Restart_to_BIOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-r -fw -t 0");
        }
    }
}
