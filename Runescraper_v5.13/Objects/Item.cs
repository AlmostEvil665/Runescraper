using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runescraper_v5._13
{

    class Item : IComparable<Item>
    {
        public int price_percentile = (int)(.4 * 180) - 1;
        public int ID;
        public int high;
        public int highTime;
        public int low;
        public int lowTime;
        public int day_avg_buy;
        public int day_avg_sell;
        public string examine;
        public string members;
        public int lowalch;
        public int limit;
        public int value;
        public int highalch;
        public string icon;
        public string name;
        public int volume;
        public int ge_price;
        public int init_low;
        public int init_high;
        public int init_margin;
        public long init_profit;
        public List<int> historical_data;


        public Item()
        {
            this.historical_data = new List<int>();
        }

        

        public int getExpectedProfit()
        {
            return getExpectedMargin() * limit;
        }
        public int getExpectedMargin()
        {
            try
            {
                return historical_data[historical_data.Count - price_percentile] - (int)(historical_data[price_percentile] * 0.01) - historical_data[price_percentile];
            } catch (Exception e)
            {
                return 0;
            }
        }

        public int CompareTo(Item other)
        {
            return other.getProfit().CompareTo(getProfit());
        }

        public long getCost()
        {
            return (long)low * (long)limit;
        }

        public int getMargin()
        {
            return high - (int)(high * 0.01) - low;
        }

        public long getProfit()
        {
            return ((long)getMargin() * (long)limit);
        }

        public float getROI()
        {
            try
            {
                return (float)getProfit() / (float)getCost();
            }
            catch
            {
                return 0;
            }
        }
    }
}
