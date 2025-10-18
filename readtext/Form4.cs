using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Novacode;
using readtext;

namespace Executable
{
    public partial class Form4 : Form

    {
        private string path { get; set; }
        public Form4()
        {
            InitializeComponent();
            Icon icon = new Icon("D:\\téléchargement\\téléchargement.ico");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files|*.txt;*.docx;*.json";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileContent = GetContent(ofd.FileName);
                textBox1.Text = fileContent;
            }
        }
        public string GetContent(string filepath)
        {
            path = filepath;
            if (filepath.EndsWith(".docx"))
            {
                using (DocX document = DocX.Load(filepath))
                {
                    return document.Text;
                }
            }
            String text = System.IO.File.ReadAllText(filepath);
            return text;
        }


        private void button2_Click(object sender, EventArgs e)
        {


        }
        private void ModifierDocument(string filepath)
        {
            using (StreamWriter SW = new StreamWriter(filepath))
            {
                SW.WriteLine(textBox1.Text);
                if (SW != null)
                {
                    SW.Close();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (path == null)
            {
                MessageBox.Show("Veuillez choisir un fichier");
            }
            else
            {
                ModifierDocument(path);
                MessageBox.Show("Modification avec succets");
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        //A prévoir pour plus tard le fait que l'ont puisse récupérer du json
    }
}
