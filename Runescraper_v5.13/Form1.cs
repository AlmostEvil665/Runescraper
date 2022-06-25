using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Runescraper_v5._13
{

    public partial class Form1 : Form
    {
        Scraper _scraper;
        VirtualController vc = new VirtualController();
        List<Item> _items;
        List<Item> _flips;
        BackgroundWorker scraperBGW = new BackgroundWorker();
        public Form1()
        {
            InitializeComponent();

            InitializeBGWs();
            //signals here
            
        }

        private void InitializeBGWs()
        {
            scraperBGW.DoWork += new DoWorkEventHandler(vc.scrapeDB);
            scraperBGW.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.finishScrape);
        }

      


        private void scrape_btn_Click_1(object sender, EventArgs e)
        {
            scrape_btn.Enabled = false;
            scrape_btn.Text = "Scraping...";
            scraperBGW.RunWorkerAsync();
        }

        private void finishScrape(object sender, EventArgs e)
        {
            scrape_btn.Text = "Scrape";
            scrape_btn.Enabled = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.itemGridView.Rows.Clear();
        }

       


        private void delete_items_btn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in itemGridView.Rows)
            {
                if (row.Selected)
                {
                    foreach(Item item in this._items)
                    {
                        if (item.name.Equals(row.Cells[0].Value))
                        {
                            this._items.Remove(item);
                            break;
                        }
                    }
                    itemGridView.Rows.Remove(row);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] filter =
            {
                min_buy_tbox.Text,
                max_buy_tbox.Text,
                min_sell_tbox.Text,
                max_sell_tbox.Text,
                min_volume_tbox.Text,
                min_margin_tbox.Text,
                min_profit_tbox.Text,
                cash_stk_tbox.Text
            };

            List<string> settings = new List<string>();

            foreach (string s in filter)
                settings.Add(s);

            foreach (DataGridViewRow row in itemGridView.Rows)
            {
                if (row.Cells[0].Value is null)
                    break;

                string s = ""; 
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    s = s + row.Cells[i].Value.ToString() + ",";
                }
                settings.Add(s);
            }
            settings.Add("flips");
            foreach (DataGridViewRow row in flipsGridView.Rows)
            {
                if (row.Cells[0].Value is null)
                    break;

                string s = "";
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    s = s + row.Cells[i].Value.ToString() + ",";
                }
                settings.Add(s);
            }

            File.WriteAllLines("settings.stg", settings.ToArray());
        }

        private bool alreadyFlipping(Item item)
        {
            foreach(Item currItem in this._flips)
            {
                if (currItem.name.Equals(item.name))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Suggest items button click method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suggest_items_btn_Click(object sender, EventArgs e)
        {
            suggest_item_btn.Text = "Suggesting...";
            cleanse_items();
            var fitems = new List<Item>(this._items);
            Int32.TryParse(cash_stk_tbox.Text, out int cash_stk);
            List<Item> chosen_items = new List<Item>();

            fitems.Sort();

            while (cash_stk >= 0 && fitems.Count > 0 && chosen_items.Count + this._flips.Count < 8)
            {
                Item item = fitems[0];
                fitems.Remove(item);

                if (cash_stk - item.getCost() > 0 && !alreadyFlipping(item) && this._scraper.checkPricePercentile(item))
                {
                    cash_stk = (int)(cash_stk - item.getCost());
                    chosen_items.Add(item);
                }

            }
            itemGridView.Rows.Clear();
            foreach (Item item in chosen_items)
            {
                itemGridView.Rows.Add(item.name, item.low, item.high, item.limit, item.volume, item.getMargin(), item.getProfit());
            }
            suggest_item_btn.Text = "Suggest Items";
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            update_btn.Text = "Updating...";
            List<Item> new_prices = _scraper.refresh_items();

            //Update current flips
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            String itemids = File.ReadAllText(userProfile + "/.runelite/FlipAssistant_FlipIDs.txt");

            flipsGridView.Rows.Clear();
            foreach (string line in itemids.Split('\n'))
            {
                foreach (Item item in new_prices)
                {
                    if (item.ID.ToString().Equals(line))
                    {
                        flipsGridView.Rows.Add(item.name, item.low, item.high, item.historical_data[item.price_percentile], item.historical_data[item.historical_data.Count - item.price_percentile],
                            item.getMargin(), item.getExpectedMargin(), item.getProfit(), item.getExpectedProfit());
                        break;
                    }
                }
            }

            List<Item> display_list = new List<Item>();
            List<Item> flip_display_list = new List<Item>();

            foreach(DataGridViewRow row in itemGridView.Rows)
            {
                var name = row.Cells[0].Value;

                foreach(Item item in this._items)
                {
                    if (item.name.Equals(name)) {
                        foreach(Item new_item in new_prices)
                        {
                            if(new_item.name.Equals(item.name))
                            {
                                item.low = new_item.low;
                                item.high = new_item.high;
                                item.volume = new_item.volume;
                                item.day_avg_buy = new_item.day_avg_buy;
                                item.day_avg_sell = new_item.day_avg_sell;
                                break;
                            }
                        }
                        display_list.Add(item);
                        break;
                    }
                }
            }
            foreach(DataGridViewRow row in flipsGridView.Rows)
            {
                var name = row.Cells[0].Value;

                foreach(Item item in this._flips)
                {
                    if(item.name.Equals(name))
                    {
                        foreach(Item new_item in new_prices)
                        {
                            if(new_item.name.Equals(item.name))
                            {
                                item.low = new_item.low;
                                item.high = new_item.high;
                                item.volume = new_item.volume;
                                item.limit = new_item.limit;
                                item.day_avg_buy = new_item.day_avg_buy;
                                item.day_avg_sell = new_item.day_avg_sell;
                                break;
                            }
                        }
                        flip_display_list.Add(item);
                    }
                }
            }

            itemGridView.Rows.Clear();
            foreach (Item item in display_list)
            {
                itemGridView.Rows.Add(item.name, item.low, item.high, item.limit, item.volume, item.getMargin(), item.getProfit());
            }

            update_btn.Text = "Update Prices";
        }

        private void cleanse_items()
        {
            List<Item> removable = new List<Item>();
            int i = 0;
            foreach(Item item in this._items)
            {
                i = i + 1;
                if(!this._scraper.isSafe(item))
                {
                    removable.Add(item);
                }
            }

            foreach(Item item in removable)
            {
                this._items.Remove(item);
            }

            itemGridView.Rows.Clear();
            foreach (Item item in this._items)
            {
                itemGridView.Rows.Add(item.name, item.low, item.high, item.limit, item.volume, item.getMargin(), item.getProfit());
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            add_btn.Text = "Adding...";
            string iname = add_tbox.Text;
            foreach(Item item in this._items)
            {
                if (item.name.ToLower().Equals(iname.ToLower()))
                {
                    itemGridView.Rows.Add(item.name, item.low, item.high, item.limit, item.volume, item.getMargin(), item.getProfit());
                    break;
                }
            }
            add_btn.Text = "Add Item";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_flip_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in itemGridView.Rows)
            {
                if (row.Selected)
                {
                    foreach (Item item in this._items)
                    {
                        if (item.name.Equals(row.Cells[0].Value))
                        {
                            this._scraper.checkPricePercentile(item);
                            this._flips.Add(item);
                            item.init_low = item.low;
                            item.init_high = item.high;
                            item.init_margin = item.getMargin();
                            item.init_profit = item.getProfit();
                            flipsGridView.Rows.Add(item.name, item.low, item.high, item.historical_data[item.price_percentile], item.historical_data[item.historical_data.Count - item.price_percentile],
                                item.getMargin(), item.getExpectedMargin(), item.getProfit(), item.getExpectedProfit()); 
                            break;
                        }
                    }
                }
            }
        }

        private void remove_flip_btn_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rows_to_remove = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in flipsGridView.Rows)
            {
                if (row.Selected)
                {
                    foreach (Item item in this._flips)
                    {
                        if (item.name.Equals(row.Cells[0].Value))
                        {
                            this._flips.Remove(item);
                            rows_to_remove.Add(row);
                            break;
                        }
                    }
                }
            }
            foreach(DataGridViewRow row in rows_to_remove)
            {
                flipsGridView.Rows.Remove(row);
            }
        }

        private void cash_stk_tbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                suggest_items_btn_Click(this, new EventArgs());
            }
        }
    }
}
