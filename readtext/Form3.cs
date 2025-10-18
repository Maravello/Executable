using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace readtext
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Icon = new Icon("D:\\téléchargement\\téléchargement.ico");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\yahay\\AppData\\Local\\Roblox\\Versions\\version-40d8b489aa2c403b\\RobloxPlayerBeta.exe");
            Process.Start("D:\\téléchargement\\Xeno-v1.2.55\\Xeno.exe");
            Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");


        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
