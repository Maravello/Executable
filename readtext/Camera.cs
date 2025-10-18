using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Newtonsoft.Json; // pour parser le JSON


namespace Executable
{
   
    public partial class Camera : Form
    {
        UdpClient udpserver;
        int port = 5000;
        public Camera()
        {
            InitializeComponent();
            StartListening();
        }

        private void Camera_Load(object sender, EventArgs e)
        {

        }

        private async void StartListening()
        {
            udpserver = new UdpClient(port);
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                var result = await udpserver.ReceiveAsync();
                string message = Encoding.UTF8.GetString(result.Buffer);

                dynamic data = JsonConvert.DeserializeObject(message);

                double x = data.x;
                double y = data.y;
                double z = data.z;


                string direction = "";

                if (x > 1)
                {
                    direction += "Droite ";
                }else if (x < -1)
                {
                    direction += "Gauche ";
                }
                
                if(y > 1)
                {
                    direction += "Haut ";
                }else if(y < -1)
                {
                    direction += "Bas ";
                }

                if (z > 1)
                {
                    direction += "Avancer ";
                }
                else if (z < -1)
                {
                    direction += "Reculer ";
                }


                this.Invoke((MethodInvoker)(() =>
                    {
                        textBox1.AppendText(direction + Environment.NewLine);
                    }));
            }
        }
    }
}
