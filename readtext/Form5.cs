using readtext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Executable
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RécupererUneListeJson rulj = new RécupererUneListeJson();
            rulj.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Camera camera = new Camera();
            camera.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reelcamera reelcamera = new reelcamera();
            reelcamera.Show();
            this.Close();
        }
    }
}
