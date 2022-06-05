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
        List<Item> _items;
        List<Item> _flips;
        public Form1()
        {
            InitializeComponent();
            _items = new List<Item>();
            _flips = new List<Item>();
            _scraper = new Scraper();
            string[] settings = new string[0];
            try
            {
                string stg_data = File.ReadAllText("settings.stg");
                settings = stg_data.Split('\n');

                min_buy_tbox.Text = settings[0];
                max_buy_tbox.Text = settings[1];
                min_sell_tbox.Text = settings[2];
                max_sell_tbox.Text = settings[3];
                min_volume_tbox.Text = settings[4];
                min_margin_tbox.Text = settings[5];
                min_profit_tbox.Text = settings[6];
                cash_stk_tbox.Text = settings[7];
            }
            catch
            {

            }
            int i = 8;
#pragma warning disable CS1717 // Assignment made to same variable
            for (i = i; i < settings.Length; i++) //Assignment made to same variable

            {
                string line = settings[i];
                if (line == "" || line == "flips\r")
                    break;
                string[] vals = line.Split(',');
                itemGridView.Rows.Add(vals[0], vals[1], vals[2], vals[3], vals[4], vals[5], vals[6], vals[7], vals[8]);

                Item item = new Item();
                item.name = vals[0];
                Int32.TryParse(vals[1], out item.low);
                Int32.TryParse(vals[2], out item.high);
                Int32.TryParse(vals[3], out item.volume);
                Int32.TryParse(vals[4], out item.limit);
                _items.Add(item);
            }
            for (i = i + 1; i < settings.Length; i++)
            {
                string line = settings[i];
                if (line == "")
                    break;
                string[] vals = line.Split(',');
                flipsGridView.Rows.Add(vals[0], vals[1], vals[2], vals[3], vals[4], vals[5], vals[6], vals[7], vals[8]);

                Item item = new Item();
                item.name = vals[0];
                Int32.TryParse(vals[1], out item.low);
                Int32.TryParse(vals[2], out item.high);
                Int32.TryParse(vals[3], out item.init_low);
                Int32.TryParse(vals[4], out item.init_high);
                Int32.TryParse(vals[6], out item.init_margin);
                item.init_profit = long.Parse(vals[8]);
                _flips.Add(item);
            }
            #pragma warning restore CS1717 // Assignment made to same variable
        }



        private void scrape_btn_Click_1(object sender, EventArgs e)
        {
            scrape_btn.Text = "Scraping...";
            this._items = this._scraper.refresh_items();
            scrape_btn.Text = "Scrape";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private List<Item> filter_items()
        {
            Int32.TryParse(min_buy_tbox.Text, out int min_buy);
            Int32.TryParse(max_buy_tbox.Text, out int max_buy);
            Int32.TryParse(min_sell_tbox.Text, out int min_sell);
            Int32.TryParse(max_sell_tbox.Text, out int max_sell);
            Int32.TryParse(min_volume_tbox.Text, out int min_volume);
            Int32.TryParse(min_margin_tbox.Text, out int min_margin);
            Int32.TryParse(min_profit_tbox.Text, out int min_profit);

            if (max_buy == 0)
                max_buy = int.MaxValue;
            if (max_sell == 0)
                max_sell = int.MaxValue;

            List<Item> filtered_items = new List<Item>();
            List<Item> removable_items = new List<Item>();
            foreach (Item item in this._items)
            {
                if (item.low >= min_buy && item.low <= max_buy && item.high >= min_sell && item.high <= max_sell && item.volume >= min_volume && item.getMargin() >= min_margin && item.getProfit() >= min_profit)
                {
                    filtered_items.Add(item);
                } else
                {
                    removable_items.Add(item);
                }
            }

            foreach (Item item in removable_items)
            {
                this._items.Remove(item);
            }

            return filtered_items;
        }

        private void apply_Click(object sender, EventArgs e)
        {
            apply_btn.Text = "Applying...";
            itemGridView.Rows.Clear();

            var fitems = filter_items();
            foreach(Item item in fitems)
            {
                itemGridView.Rows.Add(item.name, item.low, item.high, item.volume, item.limit, item.getCost(), item.getMargin(), item.getROI(), item.getProfit());
            }

            apply_btn.Text = "Apply";
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

        private void suggest_items_btn_Click(object sender, EventArgs e)
        {
            suggest_item_btn.Text = "Suggesting...";
            var fitems = new List<Item>(this._items);
            Int32.TryParse(cash_stk_tbox.Text, out int cash_stk);
            List<Item> chosen_items = new List<Item>();

            fitems.Sort();

            while (cash_stk >= 0 && fitems.Count > 0)
            {
                Item item = fitems[0];
                fitems.Remove(item);

                if (cash_stk - item.getCost() > 0)
                {
                    cash_stk = (int)(cash_stk - item.getCost());
                    chosen_items.Add(item);
                }

            }
            itemGridView.Rows.Clear();
            foreach (Item item in chosen_items)
            {
                itemGridView.Rows.Add(item.name, item.low, item.high, item.volume, item.limit, item.getCost(), item.getMargin(), item.getROI(), item.getProfit());
            }
            suggest_item_btn.Text = "Suggest Items";
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            update_btn.Text = "Updating...";
            List<Item> new_prices = _scraper.refresh_items();
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
                itemGridView.Rows.Add(item.name, item.low, item.high, item.volume, item.limit, item.getCost(), item.getMargin(), item.getROI(), item.getProfit());
            }
            flipsGridView.Rows.Clear();
            foreach (Item item in flip_display_list)
            {
                flipsGridView.Rows.Add(item.name, item.low, item.high, item.init_low, item.init_high, item.getMargin(), item.init_margin, item.getProfit(), item.init_profit);
            }

            update_btn.Text = "Update Prices";
        }

        private void cleanse_btn_Click(object sender, EventArgs e)
        {
            cleanse_btn.Text = "Cleansing...";
            List<Item> removable = new List<Item>();
            foreach(Item item in this._items)
            {
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
                itemGridView.Rows.Add(item.name, item.low, item.high, item.volume, item.limit, item.getCost(), item.getMargin(), item.getROI(), item.getProfit());
            }
            cleanse_btn.Text = "Cleanse Unsafe Items";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            add_btn.Text = "Adding...";
            string iname = add_tbox.Text;
            foreach(Item item in this._items)
            {
                if (item.name.ToLower().Equals(iname.ToLower()))
                {
                    itemGridView.Rows.Add(item.name, item.low, item.high, item.volume, item.limit, item.getCost(), item.getMargin(), item.getROI(), item.getProfit());
                    break;
                }
            }
            add_btn.Text = "Add Item";
        }

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
                            this._flips.Add(item);
                            item.init_low = item.low;
                            item.init_high = item.high;
                            item.init_margin = item.getMargin();
                            item.init_profit = item.getProfit();
                            flipsGridView.Rows.Add(item.name, item.low, item.high, item.init_low, item.init_high, item.getMargin(), item.init_margin, item.getProfit(), item.init_profit);
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
    }
}
