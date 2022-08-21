using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;

namespace Runescraper_v5._13
{
    
    class Scraper
    {
        string URL;
        string EP_one_d;
        string EP_latest;
        string EP_mapping;
        String EP_volume;
        WebClient client;
        int nature_rn_price;

        public Scraper()
        {
            URL = "https://prices.runescape.wiki/api/v1/osrs/";
            EP_one_d = "24h";
            EP_latest = "latest";
            EP_mapping = "mapping";
            EP_volume = "volumes";

            client = new WebClient();
            using (client)
            {
                client.Headers["User-Agent"] =
                "Flipping Tool Scraper - Danny#0897";
            }
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
            try
            {
                this.client.DownloadFile(src, dst);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }



        public bool checkPricePercentile(Item item)
        {
            string item_api_call = "https://services.runescape.com/m=itemdb_oldschool/api/graph/" + item.ID + ".json";
            string filename = "items/" + item.ID + ".txt";

            item.historical_data.Clear();

            DownloadFile(item_api_call, filename);

            string item_rdata = File.ReadAllText(filename);

            //Cut the daily data we only want the average data
            item_rdata = item_rdata.Substring(item_rdata.IndexOf("average")).Replace("average\":{", "").Replace("\"", "").Replace("}", ""); ;
            var average_daily_data_arr = item_rdata.Split(',');
            var week_daily_data_arr = average_daily_data_arr.Skip(Math.Max(0, average_daily_data_arr.Count() - 7));
            foreach (var average_daily_data in week_daily_data_arr)
            {
                var data = average_daily_data.Split(':');

                Int32.TryParse(data[1], out int price);
                item.historical_data.Add(price);
            }

            item.historical_data.Sort();


            return item.historical_data[item.price_percentile] > item.low;
        }

        public int checkHighAlch(Item item)
        {
            return item.halch - item.high - nature_rn_price;
        }

        public int checkLowAlch(Item item)
        {
            return item.lalch - item.low - nature_rn_price;
        }

        public List<Item> refresh_items()
        {
            DownloadFile(this.URL + this.EP_latest, "item_db.txt");
            DownloadFile(this.URL + this.EP_mapping, "item_mapping.txt");
            DownloadFile(this.URL + this.EP_volume, "item_volume.txt");
            DownloadFile("https://chisel.weirdgloop.org/gazproj/gazbot/os_dump.json", "ge.tmp");

            Dictionary<string, Item> items = new Dictionary<string, Item>();

            // Read the mapping and cleanse the input. Then prepare it for parsing
            string items_mapping = System.IO.File.ReadAllText("item_mapping.txt");
            items_mapping = items_mapping.Replace("[{", "").Replace("},", "\n").Replace("{", "").Replace(":", "").Replace("\"\"", "\"").Replace(",", "");
            string[] mapping_arr = items_mapping.Split('\n');

            // Parse each mapping into its respective mapping
            foreach (string curr in mapping_arr)
            {
                var vals = curr.Split('"');
                Item item = new Item();
                for (int i = 0; i < vals.Length - 1; i++)
                {
                    switch (vals[i])
                    {
                        case "id":
                            Int32.TryParse(vals[i + 1], out item.ID);
                            break;
                        case "limit":
                            Int32.TryParse(vals[i + 1], out item.limit);
                            break;
                        case "value":
                            break;
                        case "icon":
                            item.icon = vals[i + 1];
                            break;
                        case "name":
                            item.name = vals[i + 1];
                            break;
                        default:
                            break;
                    }
                }

                items[item.ID.ToString()] = item;
            }

            // Read items_text and cleanse the input. Then prepare it for parsing
            string items_text = File.ReadAllText("item_db.txt");
            items_text = items_text.Replace("{\"data\":{", "").Replace("\"", "").Replace("{", "").Replace("},", "\n").Replace(",", ":");
            string[] items_arr = items_text.Split('\n');

            // Parse each entry into an Item object and add them to the list.
            foreach (string curr in items_arr)
            {
                var vals = curr.Split(':');
                Item item = new Item();
                try
                {
                    item = items[vals[0]];
                }
                catch
                {
                    continue;
                }
                Int32.TryParse(vals[0], out item.ID);
                Int32.TryParse(vals[2], out item.high);
                Int32.TryParse(vals[6], out item.low);

                if (item.ID == 561)
                    nature_rn_price = item.high;

                items[item.ID.ToString()] = item;
            }


            string items_volume_txt = File.ReadAllText("item_volume.txt");
            items_volume_txt = items_volume_txt.Substring(items_volume_txt.IndexOf("\"data\":") + 7).Replace("{", "").Replace("\"", "");
            string[] items_volume_arr = items_volume_txt.Split(',');

            foreach (string item in items_volume_arr)
            {
                string[] ipair = item.Split(':');
                Int32.TryParse(ipair[1], out items[ipair[0]].volume);
            }

            string ge_text = File.ReadAllText("ge.tmp");
            string[] ge_array = ge_text.Replace(": ", ":").Replace(" ", "").Replace(": {", "").Replace("{", "").Replace("}: ", "").Replace("\"", "").Replace(",", ":").Replace("}:", "\n").Split('\n');
            foreach (string line in ge_array)
            {
                Console.WriteLine(line);

                Item item = new Item();
                string[] vals = line.Split(':');
                try
                {
                    item = items[vals[0]];
                    Int32.TryParse(vals[14], out item.halch);
                    Int32.TryParse(vals[8], out item.lalch);
                }
                catch
                {
                    continue;
                }
                //Int32.TryParse(vals[12], out item.value);

                items[item.ID.ToString()] = item;
            }



            return new List<Item>(items.Values);
        }

        internal List<Item> grabGeLogs()
        {
            List<Item> items = refresh_items();

            String logDir = "C:/Users/" + Environment.UserName + "/.runelite/exchange-logger/exchange.log";
            String log_str = File.ReadAllText(logDir);
            Item[] flips = new Item[8];

            foreach(String line in log_str.Split('\n'))
            {
                if (line.Equals(""))
                    break;
                var data = line.Replace("{", "").Replace("}", "").Replace("\"", "").Replace(":",",").Split(',');

                String state = data[7];
                Int32.TryParse(data[9], out int slot);
                Int32.TryParse(data[11], out int id);
                String[] date = data[1].Split('-');
                string hour = data[3];
                string minute = data[4];
                string second = data[5];

                if (state.Equals("EMPTY") || state.Equals("CANCELLED_BUY") || state.Equals("CANCELLED_SELL") 
                    || state.Equals("SOLD") || state.Equals("BOUGHT") )
                {
                    flips[slot] = null;
                    continue;
                }
                if (state.Equals("BUYING") || state.Equals("SELLING"))
                {
                    Item item = new Item();
                    item.ID = id;
                    item.state = state;
                    Int32.TryParse(data[19], out item.user_price);
                    item.orderTime = stringToTime(date[0], date[1], date[2], hour, minute, second);
                    flips[slot] = item;
                }
            }

            List<Item> flipList = new List<Item>();
            foreach(Item item in flips)
            {
                if (!(item is null))
                {
                    foreach(Item curr in items)
                    {
                        if (curr.ID == item.ID)
                        {
                            curr.state = item.state;
                            curr.user_price = item.user_price;
                            curr.orderTime = item.orderTime;
                            checkPricePercentile(curr);
                            flipList.Add(curr);
                        }
                    }
                }
            }
            return flipList;
        }

        public DateTime stringToTime(string year, string month, string day, string hour, string minute, string second)
        {
            Int32.TryParse(year, out int yr);
            Int32.TryParse(month, out int mo);
            Int32.TryParse(day, out int dy);
            Int32.TryParse(hour, out int hr);
            Int32.TryParse(minute, out int min);
            Int32.TryParse(second, out int sec);

            return new DateTime(yr, mo, dy, hr, min, sec);
        }

        internal bool isSafe(Item item)
        {
            DownloadFile("https://api.weirdgloop.org/exchange/history/osrs/latest?id=" + item.ID, "item.tmp");

            string[] temp = File.ReadAllText("item.tmp").Split('\n');

            foreach (string line in temp)
            {
                if (line.Contains("price"))
                {
                    int value = Int32.Parse(line.Replace(",", ":").Split(':')[8]);

                    return item.low < value;
                }
            }
            return false;
        }
    }
}
