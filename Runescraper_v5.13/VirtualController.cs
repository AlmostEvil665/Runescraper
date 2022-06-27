using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Runescraper_v5._13
{
    class VirtualController
    {
        Scraper scraper;
        List<Item> itemsTable;
        List<Item> flipsTable;

        string minBuySetting, maxBuySetting, 
            minSellSetting, maxSellSetting, 
            minVolSetting, minMarginSetting,
            minProfitSetting, cashStack;

       

        public delegate void MinBuyUpdater(string MinBuySetting);
        public event MinBuyUpdater UpdateMinBuy;

        public delegate void MaxBuyUpdater(string MaxBuySetting);
        public event MaxBuyUpdater UpdateMaxBuy;

        public delegate void MinSellUpdater(string MinSellSetting);
        public event MinBuyUpdater UpdateMinSell;

        public delegate void MaxSellUpdater(string MaxSellSetting);
        public event MaxBuyUpdater UpdateMaxSell;

        public delegate void MinVolUpdater(string MinVolSetting);
        public event MinVolUpdater UpdateMinVol;
        public delegate void MinMarginUpdater(string MinMarginSetting);
        public event MinMarginUpdater UpdateMinMargin;

        public delegate void MinProfitUpdater(string MinProfitSetting);
        public event MinBuyUpdater UpdateMinProfit;

        public delegate void CashStackUpdater(string CashStackSetting);
        public event CashStackUpdater UpdateCashStack;

        public delegate void ItemSender(Item item);
        public event ItemSender sendItem;

        public delegate void ScrapeFinishHandler();
        public event ScrapeFinishHandler scrapeFinished;

        //init
        /// <summary>
        /// 
        /// </summary>
        public VirtualController()
        {
            itemsTable = new List<Item>();
            flipsTable = new List<Item>();
            scraper = new Scraper();
            

            
            

            string[] settings = new string[0];
            try
            {
                string stg_data = File.ReadAllText("settings.stg");
                settings = stg_data.Split('\n');

                minBuySetting = settings[0];
                maxBuySetting = settings[1];
                minSellSetting = settings[2];
                maxSellSetting = settings[3];
                minVolSetting = settings[4];
                minMarginSetting = settings[5];
                minProfitSetting = settings[6];
                cashStack = settings[7];

                

            }
            catch
            {

            }

            int j = 8;
            for (int i = j; i < settings.Length; i++)
            {
                string line = settings[i];
                if (line == "" || line == "flips\r")
                    break;
                string[] vals = line.Split(',');
                //call grid signal
                //itemGridView.Rows.Add(vals[0], vals[1], vals[2], vals[3], vals[4], vals[5], vals[6]);

                Item item = new Item();
                item.name = vals[0];
                Int32.TryParse(vals[1], out item.low);
                Int32.TryParse(vals[2], out item.high);
                Int32.TryParse(vals[3], out item.volume);
                Int32.TryParse(vals[4], out item.limit);
                itemsTable.Add(item);
            }
            for (int i  = j + 1; i < settings.Length; i++)
            {
                string line = settings[i];
                if (line == "")
                    break;
                string[] vals = line.Split(',');

                //call flips grid signal
                //flipsGridView.Rows.Add(vals[0], vals[1], vals[2], vals[3], vals[4], vals[5], vals[6], vals[7], vals[8]);

          /*      Item item = new Item();
                item.name = vals[0];
                Int32.TryParse(vals[1], out item.low);
                Int32.TryParse(vals[2], out item.high);
                Int32.TryParse(vals[3], out item.init_low);
                Int32.TryParse(vals[4], out item.init_high);
                Int32.TryParse(vals[5], out item.init_margin);
                item.init_profit = long.Parse(vals[6]);
                flipsTable.Add(item); */
            }

        }
        //

        public void scrapeDB()
        {
            this.itemsTable = this.scraper.refresh_items();
            this.itemsTable = filter_items();
            
            foreach (Item item in this.itemsTable)
            {
                sendItem(item);
            }

            scrapeFinished();
        }

        public void SendSettings()
        {
            UpdateMinBuy(minBuySetting);
            UpdateMaxBuy(maxBuySetting);

        }

        private List<Item> filter_items()
        {
            Int32.TryParse(minBuySetting, out int min_buy);
            Int32.TryParse(maxBuySetting, out int max_buy);
            Int32.TryParse(minSellSetting, out int min_sell);
            Int32.TryParse(maxSellSetting, out int max_sell);
            Int32.TryParse(minVolSetting, out int min_volume);
            Int32.TryParse(minMarginSetting, out int min_margin);
            Int32.TryParse(minProfitSetting, out int min_profit);

            //deal with null values
            if (max_buy == 0)
                max_buy = int.MaxValue;
            if (max_sell == 0)
                max_sell = int.MaxValue;
            //if (min_margin_tbox.Text.Replace("\r", "").Equals(""))
                min_margin = -System.Int32.MaxValue;
           // if (min_profit_tbox.Text.Replace("\r", "").Equals(""))
                min_profit = -System.Int32.MaxValue;
            
            List<Item> filtered_items = new List<Item>();
            List<Item> removable_items = new List<Item>();
            foreach (Item item in this.itemsTable)
            {
                if (item.ID == 383)
                    Console.WriteLine("test");
                if (item.low >= min_buy && item.low <= max_buy && item.high >= min_sell && item.high <= max_sell && item.volume >= min_volume && item.getMargin() >= min_margin && item.getProfit() >= min_profit)
                {
                    filtered_items.Add(item);
                }
                else
                {
                    removable_items.Add(item);
                }
            }

            foreach (Item item in removable_items)
            {
                this.itemsTable.Remove(item);
            }

            return filtered_items;
        }
    }
}
