using Executable;
using System;
using System.IO;
using System.Windows.Forms;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

namespace readtext {



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Icon = new Icon("D:\\téléchargement\\téléchargement.ico");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Textfiles | *.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var lines = GetStrings(ofd.FileName);
                foreach (var variable in lines)
                {
                    string pdfExtract = GetStrings(ofd.FileName);
                    textBox1.Text = pdfExtract;
                }
                label1.Text = Path.GetFileName(ofd.FileName);
            }
        }
        private string GetStrings(string filepath)
        {
            String text = "";
            using (PdfDocument document = PdfDocument.Open(filepath))
            {
                foreach (Page page in document.GetPages())
                {
                    text += page.Text + Environment.NewLine + Environment.NewLine;
                }
                return text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vidéoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();

            f4.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void apiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void newsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New Mynews = new New();
            Mynews.Show();
            this.Hide();
        }
    }
}


