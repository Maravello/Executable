using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;


namespace readtext
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.KeyPreview = true;
#pragma warning disable CS8622 // La nullabilité des types référence dans le type du paramètre ne correspond pas au délégué cible (probablement en raison des attributs de nullabilité).
            this.KeyDown += Form2_KeyDown;
#pragma warning restore CS8622 // La nullabilité des types référence dans le type du paramètre ne correspond pas au délégué cible (probablement en raison des attributs de nullabilité).
            this.Icon = new Icon("D:\\téléchargement\\téléchargement.ico");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Video Files|*.mp4";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = ofd.FileName;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            label1.Text = Path.GetFileName(ofd.FileName);
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.P)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            else if (e.KeyCode == Keys.R)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
