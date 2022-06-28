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

        public Form1()
        {
            InitializeComponent();
            vc.sendItem += AddItem;
            vc.sendFlip += addFlips;
            vc.scrapeFinished += finishScrape;
            vc.updateFinished += finishUpdate;
            vc.UpdateMinBuy += updateMinBuyBox;
            vc.UpdateMaxBuy += updateMaxBuyBox;
            vc.UpdateMinSell += updateMinSellBox;
            vc.UpdateMaxSell += updateMaxSellBox;
            vc.UpdateMinVol += updateMinVolBox;
            vc.UpdateMinMargin += updateMinMarginBox;
            vc.UpdateMinProfit += updateMinProfitBox;
            vc.UpdateCashStack += updateCashStackBox;

            vc.suggestFinished += updateWithSuggestions;

            if (!Directory.Exists("items"))
            {
                Directory.CreateDirectory("items");
            }

            UpdateBoxes();
        }

        private void updateWithSuggestions(List<Item> suggestions)
        {
            itemGridView.Rows.Clear();
            foreach(Item item in suggestions)
            {
                itemGridView.Rows.Add(item.name, item.low, item.high, item.limit, item.volume, item.getMargin(), item.getProfit());
            }
            suggest_item_btn.Text = "Suggest Items";
            suggest_item_btn.Enabled = true;
        }

        private void UpdateList(Item item)
        { 
            vc.updateFinished += finishUpdate;
            UpdateBoxes();
        }

        private void addFlips(List<Item> items)
        {
            foreach (Item item in items)
            {
                item.init_margin = item.getMargin();
                item.init_profit = item.getProfit();
                flipsGridView.Rows.Add(item.name, item.low, item.high, item.historical_data[item.price_percentile], item.historical_data[item.historical_data.Count - item.price_percentile],
                    item.getMargin(), item.getExpectedMargin(), item.getProfit(), item.getExpectedProfit());
            }
            
        }

        private void AddItem(Item item)
        {
            itemGridView.Rows.Add(item.name, item.low, item.high, item.limit, item.volume, item.getMargin(), item.getProfit());
        }

        public void UpdateBoxes()
        {
            vc.SendSettings();
        }

        private void scrape_btn_Click_1(object sender, EventArgs e)
        {
            scrape_btn.Text = "Scraping...";
            scrape_btn.Enabled = false;
            itemGridView.Rows.Clear();
            vc.scrapeDB();
        }

        private void finishScrape(List<Item> itemsTable)
        {
            foreach (Item item in itemsTable)
            {
                AddItem(item);
            }

            scrape_btn.Text = "Scrape";
            scrape_btn.Enabled = true;

        }
        
        public void updateMinBuyBox(int MinBuySetting)
        {
            this.min_buy_tbox.Text = MinBuySetting.ToString();
        }

        public void updateMaxBuyBox(int MaxBuySetting)
        {
            this.max_buy_tbox.Text = MaxBuySetting.ToString();
        }

        public void updateMinSellBox(int MinSellSetting)
        {
            this.min_sell_tbox.Text = MinSellSetting.ToString();
        }

        public void updateMaxSellBox(int MaxSellSetting)
        {
            this.max_sell_tbox.Text = MaxSellSetting.ToString();
        }

        public void updateMinVolBox(int MinVolSetting)
        {
            this.min_volume_tbox.Text = MinVolSetting.ToString();
        }
        public void updateMinMarginBox(int MinMarginSetting)
        {
            this.min_margin_tbox.Text = MinMarginSetting.ToString();
        }

        public void updateMinProfitBox(int MinProfitSetting)
        {
            this.min_profit_tbox.Text = MinProfitSetting.ToString();
        }
        public void updateCashStackBox(int CashStackSetting)
        {
            this.cash_stk_tbox.Text = CashStackSetting.ToString();
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

       

        /// <summary>
        /// Suggest items button click method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suggest_items_btn_Click(object sender, EventArgs e)
        {

            suggest_item_btn.Text = "Suggesting...";
            suggest_item_btn.Enabled = false;
            vc.StartSuggesting();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            update_btn.Text = "Updating...";
            update_btn.Enabled = false;
            this.flipsGridView.Rows.Clear();
            vc.updateItems();
        }

        private void finishUpdate()
        {
            update_btn.Enabled = true;
            update_btn.Text = "Update Flips";
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

        private void min_buy_tbox_TextChanged(object sender, EventArgs e)
        {
            vc.getStg().setMinBuy(min_buy_tbox.Text);
        }

        private void max_buy_tbox_TextChanged(object sender, EventArgs e)
        {
            vc.getStg().setMaxBuy(max_buy_tbox.Text);

        }

        private void min_sell_tbox_TextChanged(object sender, EventArgs e)
        {
            vc.getStg().setMinSell(min_sell_tbox.Text);

        }

        private void max_sell_tbox_TextChanged(object sender, EventArgs e)
        {
            vc.getStg().setMaxBuy(max_buy_tbox.Text);
        }

        private void min_volume_tbox_TextChanged(object sender, EventArgs e)
        {
            vc.getStg().setMinVol(min_volume_tbox.Text);
        }

        private void min_margin_tbox_TextChanged(object sender, EventArgs e)
        {
            vc.getStg().setMinMargin(min_margin_tbox.Text);
        }

        private void min_profit_tbox_TextChanged(object sender, EventArgs e)
        {
            vc.getStg().setMinProfit(min_profit_tbox.Text);
        }

        private void cash_stk_tbox_TextChanged(object sender, EventArgs e)
        {
            vc.getStg().setCashStack(cash_stk_tbox.Text);
        }
    }
}
