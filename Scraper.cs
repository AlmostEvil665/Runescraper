using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Runescraper_v5._13
{
    class Scraper
    {
        string URL;
        string EP_hour;
        string EP_fivem;
        string EP_latest;
        WebClient client;

        public Scraper()
        {
            URL = "https://prices.runescape.wiki/api/v1/osrs/";
            EP_hour = "1h";
            EP_fivem = "5m";
            EP_latest = "latest";

            client = new WebClient();
        }

        /// <summary>
        /// Takes a src URL and dst filename as parameter. Downloads the webpage found
        /// at src and stores the file in dst
        /// 
        /// return void
        /// </summary>
        /// <param name="src">URL to download</param>
        /// <param name="dst">file location</param>
        public void DownloadFile(string src, string dst)
        {
            this.client.DownloadFile(src, dst);
        }

        public List<Item> refresh_items()
        {
            DownloadFile(this.URL + this.EP_hour, "item_db.txt");

            return null;
        }
    }
}
