using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Runescraper_v5._13.Objects;

namespace Runescraper_v5._13
{
    class VirtualController
    {
        Scraper scraper;
        List<Item> itemsTable;
        List<Item> flipsTable;
        Settings stg = new Settings();

        BackgroundWorker RuneliteWorker = new BackgroundWorker();

        public delegate void MinBuyUpdater(int MinBuySetting);
        public event MinBuyUpdater UpdateMinBuy;

        public delegate void MaxBuyUpdater(int MaxBuySetting);
        public event MaxBuyUpdater UpdateMaxBuy;

        public delegate void MinSellUpdater(int MinSellSetting);
        public event MinSellUpdater UpdateMinSell;

        public delegate void MaxSellUpdater(int MaxSellSetting);
        public event MaxSellUpdater UpdateMaxSell;

        public delegate void MinVolUpdater(int MinVolSetting);
        public event MinVolUpdater UpdateMinVol;
        public delegate void MinMarginUpdater(int MinMarginSetting);
        public event MinMarginUpdater UpdateMinMargin;

        public delegate void MinProfitUpdater(int MinProfitSetting);
        public event MinProfitUpdater UpdateMinProfit;

        public delegate void CashStackUpdater(int CashStackSetting);
        public event CashStackUpdater UpdateCashStack;

        public delegate void ItemSender(Item item);
        public event ItemSender sendItem;

        public delegate void FlipSender(List<Item> items);
        public event FlipSender sendFlip;

        public delegate void ScrapeFinishHandler();
        public event ScrapeFinishHandler scrapeFinished;

        public delegate void UpdateFinishHandler();
        public event UpdateFinishHandler updateFinished;

        //init
        /// <summary>
        /// 
        /// </summary>
        public VirtualController()
        {
            itemsTable = new List<Item>();
            flipsTable = new List<Item>();
            scraper = new Scraper();

            RuneliteWorker.DoWork += scrapeRunelogs;
            RuneliteWorker.RunWorkerCompleted += finishUpdateItems;
            
            

            string[] settings = new string[0];
            try
            {
                string stg_data = File.ReadAllText("settings.stg");
                settings = stg_data.Split('\n');


                stg.setMinBuy(settings[0]);
                stg.setMaxBuy(settings[1]);
                stg.setMinSell(settings[2]);
                stg.setMaxSell(settings[3]);
                stg.setMinVol(settings[4]);
                stg.setMinMargin(settings[5]);
                stg.setMinProfit(settings[6]);


                Int32.TryParse(settings[7], out int cashStack);


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
                if (line == "flips\r")
                    continue;
                string[] vals = line.Split(',');

                //call flips grid signal
                //flipsGridView.Rows.Add(vals[0], vals[1], vals[2], vals[3], vals[4], vals[5], vals[6], vals[7], vals[8]);

                Item item = new Item();
                item.name = vals[0];
                Int32.TryParse(vals[1], out item.low);
                Int32.TryParse(vals[2], out item.high);
                Int32.TryParse(vals[3], out item.init_low);
                Int32.TryParse(vals[4], out item.init_high);
                Int32.TryParse(vals[5], out item.init_margin);
                item.init_profit = long.Parse(vals[6]);
                flipsTable.Add(item); 
            }

        }



        public Settings getStg()
        {
            return stg;
        }

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
            if (Math.Abs(this.stg.minBuy) != Math.Abs(System.Int32.MaxValue))
                UpdateMinBuy(this.stg.minBuy);
            if (Math.Abs(this.stg.maxBuy) != Math.Abs(System.Int32.MaxValue))
                UpdateMaxBuy(this.stg.maxBuy);
            if (Math.Abs(this.stg.minSell) != Math.Abs(System.Int32.MaxValue))
                UpdateMinSell(this.stg.minSell);
            if (Math.Abs(this.stg.maxSell) != Math.Abs(System.Int32.MaxValue))
                UpdateMaxSell(this.stg.maxSell);
            if (Math.Abs(this.stg.minVol) != Math.Abs(System.Int32.MaxValue))
                UpdateMinVol(this.stg.minVol);
            if (Math.Abs(this.stg.minMargin) != Math.Abs(System.Int32.MaxValue))
                UpdateMinMargin(this.stg.minMargin);
            if (Math.Abs(this.stg.minProfit) != Math.Abs(System.Int32.MaxValue))
                UpdateMinProfit(this.stg.minProfit);
            if (Math.Abs(this.stg.cashStack) != Math.Abs(System.Int32.MaxValue))
                UpdateCashStack(this.stg.cashStack);

        }

        private List<Item> filter_items()
        {


            
            List<Item> filtered_items = new List<Item>();
            List<Item> removable_items = new List<Item>();
            foreach (Item item in this.itemsTable)
            {
                if (item.ID == 383)
                    Console.WriteLine("test");
                if (item.low >= stg.minBuy && item.low <= stg.maxBuy && item.high >= stg.minSell && item.high <= stg.maxSell
                    && item.volume >= stg.minVol && item.getMargin() >= stg.minMargin && item.getProfit() >= stg.minProfit)
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

        /// <summary>
        /// Instructs the Runeworker to begin working
        /// </summary>
        public void updateItems()
        {
            RuneliteWorker.RunWorkerAsync();
        }
        private void scrapeRunelogs(object sender, DoWorkEventArgs e)
        {
            List<Item> logFlips = this.scraper.grabGeLogs();
            e.Result = logFlips;
        }

        private void finishUpdateItems(object sender, RunWorkerCompletedEventArgs e)
        {
            List<Item> flips = ((List<Item>) e.Result);
            sendFlip(flips);

            foreach(Item flip in flips)
            {
                flipsTable.Add(flip);
            }

            updateFinished();
        }



    }
}
