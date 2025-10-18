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
using Newtonsoft.Json;
using System.IO;
using Microsoft.VisualBasic.Devices;

namespace Executable
{
    public partial class RécupererUneListeJson : Form
    {
        public RécupererUneListeJson()
        {
            InitializeComponent();
        }

        private void RécupererUneListeJson_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = textBox2.Text;
                string result = await client.GetStringAsync(url);
                Cursor.Current = Cursors.WaitCursor;
                var json = JsonConvert.DeserializeObject(result);
                textBox1.Text = JsonConvert.SerializeObject(json, Formatting.Indented);
                Cursor.Current = Cursors.Default;
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void enregistréDansUnFichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (fbd.ShowDialog() == DialogResult.OK) {
                string path = fbd.SelectedPath;
                string cheminFichier = Path.Combine(path, "data.json");
                File.WriteAllText(cheminFichier, textBox1.Text);
                MessageBox.Show("Fichier enregistré avec succès !");
            }

        }
    }
}
