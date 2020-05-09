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

namespace BasicScraper
{
    public partial class Form1 : Form
    {
        Scraper scraper;

        public Form1()
        {
            InitializeComponent();
            scraper = new Scraper();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonScrape_Click(object sender, EventArgs e)
        {
            scraper.ScrapeData(textBoxBrowserBar.Text);
            foreach (var entry in scraper.Entries)
                dataGridView1.DataSource = scraper.Entries;
        }

        private void buttonToJson_Click(object sender, EventArgs e)
        {
            string output = JsonConvert.SerializeObject(scraper.Entries);
            saveFileDialog1.ShowDialog();

            File.WriteAllText(saveFileDialog1.FileName, output);
        }
    }
}
