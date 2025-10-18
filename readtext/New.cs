using HtmlAgilityPack;
using OpenCvSharp;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Executable
{
    public partial class New : Form
    {
        public New()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            GetData();

            //var driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://www.amazon.fr/s?k=nintendo+switch+2");

            //var prices = driver.FindElements(By.CssSelector("span.a-price-whole"));
            //var element = driver.FindElement(By.CssSelector("[aria-label]"));
            //foreach (var price in prices)
            //{
            //    textBox1.AppendText(element.Text+""+  price.Text + " €" + Environment.NewLine);
            //}

            //driver.Quit();
        }

        public async void GetData()
        {
            var url = "https://www.lerepairedudragon.fr/?mot_q=raidraptor&mot_s=51156";
            HttpClient client = new HttpClient();
            var html = await client.GetStringAsync(url);
            var Mydocument = new HtmlAgilityPack.HtmlDocument();

            Mydocument.LoadHtml(html);

            var divs = Mydocument.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("id", "")
                .Contains("page")).ToList();

            textBox1.Clear();

            foreach (var div in divs)
            {
                string prix = div.InnerText.Trim();
                  

            
                textBox1.Text += prix;
            }
        }
    }
}
