using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Threading.Tasks;
using readtext;

namespace Executable
{
    public partial class reelcamera : Form
    {
        private VideoCapture Myvideo;
        private Mat Mymath;
        private Bitmap image;
        private bool IsRunning;
        string url;

        public reelcamera()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

        }

        private void StopButton_Click(object sender, EventArgs e)
        {

        }

        private void Stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {


            Myvideo = new VideoCapture(url);
            Mymath = new Mat();

            IsRunning = true;
            await Task.Run(() =>
            {
                while (IsRunning)
                {
                    Myvideo.Read(Mymath);

                    if (!Mymath.Empty())
                    {
                        image = BitmapConverter.ToBitmap(Mymath);
                        pictureBox2.Invoke(() =>
                        {
                            pictureBox2.Image?.Dispose();
                            pictureBox2.Image = (Bitmap)image.Clone();
                        });
                    }
                }
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsRunning = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                url = textBox3.Text;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            url = textBox3.Text;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void reelcamera_Load(object sender, EventArgs e)
        {

        }
    }
}
