using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runescraper_v5._13
{

    class Item : IComparable<Item>
    {
        public int ID;
        public int high;
        public int highTime;
        public int low;
        public int lowTime;
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


        public Item()
        {

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
