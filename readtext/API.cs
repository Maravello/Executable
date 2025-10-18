using Newtonsoft.Json;
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
    public partial class API : Form
    {
        public string id { get; set; }
        public string title { get; set; }
        public string thumbnail_url { get; set; }
        public string url { get; set; }
        public API()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        // Remplacer la ligne incorrecte de désérialisation et ajouter des classes pour le mapping JSON

        // Ajouter ces classes à l'intérieur ou à l'extérieur de la classe API, selon votre organisation :
        public class DailymotionResponse
        {
            public List<VideoItem> list { get; set; }
        }

        public class VideoItem
        {
            public string id { get; set; }
            public string title { get; set; }
            public string thumbnail_url { get; set; }
            public string url { get; set; }
        }

        // Remplacer le code dans API_Load par :
           private async Task API_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync("https://api.dailymotion.com/videos?search=sonic&limit=5&fields=id,title,thumbnail_url,url");

            var response = JsonConvert.DeserializeObject<DailymotionResponse>(data);

            if (response != null && response.list != null && response.list.Count > 0)
            {
                // Exemple : lire la première vidéo trouvée
                axWindowsMediaPlayer1.URL = response.list[0].url;
            }
        }
    }
}
