using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BasicScraper
{
    public class Scraper
    {
        private ObservableCollection<Block> _entries = new ObservableCollection<Block>();

        public ObservableCollection<Block> Entries
        {
            get { return _entries; }
            set { _entries = value; }
        }

        public void ScrapeData(string page)
        {
            var web = new HtmlWeb();
            var doc = web.Load(page);

            var Blocks = doc.DocumentNode.SelectNodes("//div[@id='mw-content-text']/table/tr");

            foreach(var blocks in Blocks)
            {
                var color = blocks.SelectSingleNode(".//td[1]/a[2]")?.InnerText ?? "";
                var rgb = blocks.SelectSingleNode(".//td[2]")?.InnerText.Substring(0, 13).Replace(",", "") ?? "";

                Console.WriteLine(color + "\n" + rgb);

                _entries.Add(new Block { Color = color, Rgb = rgb });

                if (color == "Glowing White") break;
            }
        }
    }
}
