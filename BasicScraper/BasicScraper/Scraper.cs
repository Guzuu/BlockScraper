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
            bool lol = false;

            var Blocks = doc.DocumentNode.SelectNodes("//div[@id='mw-content-text']/table/tr");

            foreach(var blocks in Blocks)
            {
                var color = blocks.SelectSingleNode(".//td[1]/a[2]")?.InnerText ?? "";
                var A = "125";
                var R = blocks.SelectSingleNode(".//td[2]")?.InnerText.Substring(0, 3) ?? "";
                var G = blocks.SelectSingleNode(".//td[2]")?.InnerText.Substring(5, 3) ?? "";
                var B = blocks.SelectSingleNode(".//td[2]")?.InnerText.Substring(10, 3) ?? "";

                if (color == "Brown Glass") lol = true;

                if (lol)
                {
                    Console.WriteLine(color + "\n" + A + " " + R + " " + G + " " + B);
                    _entries.Add(new Block { Color = color, A = A, R = R, G = G, B = B });
                }
                if (color == "Black Ice") break;
            }
        }
    }
}
