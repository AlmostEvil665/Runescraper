using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunescraperObjects
{
    class Settings
    {

        public int minBuy;
        public int maxBuy;
        public int minSell;

        public int maxSell;
        public int minVol;
        public int minMargin;
        public int minProfit;
        public int cashStack;

        

        /// <summary>
        /// Used to store all the filter settings objects
        /// </summary>
        public Settings()
        {
            // Default Values
            minBuy = -System.Int32.MaxValue;
            minSell = -System.Int32.MaxValue;
            minVol = -System.Int32.MaxValue;
            minMargin = -System.Int32.MaxValue;
            minProfit = -System.Int32.MaxValue;

            maxBuy = System.Int32.MaxValue;
            maxSell = System.Int32.MaxValue;
        }

        /// <summary>
        /// Used to save the settings
        /// </summary>
        /// <returns>a string of all filters separated by crlf values</returns>
        public string toString()
        {
            string value = "";

            value = minBuy.ToString() + "\r\n" +
                maxBuy.ToString() + "\r\n" +
                minSell.ToString() + "\r\n" +
                maxSell.ToString() + "\r\n" +
                minVol.ToString() + "\r\n" +
                minMargin.ToString() + "\r\n" +
                minProfit.ToString() + "\r\n" +
                cashStack.ToString();

            return value;
        }


        public void setMinBuy(string value)
        {
            value = convertUnits(value);
            if (value.Equals("\r") || value.Equals(""))
                minBuy = -System.Int32.MaxValue;
            else
                Int32.TryParse(value, out minBuy);
        }


        public void setMaxBuy(string value)
        {
            value = convertUnits(value);
            if (value.Equals("\r") || value.Equals(""))
                maxBuy = System.Int32.MaxValue;
            else
                Int32.TryParse(value, out maxBuy);
        }

        public void setMinSell(string value)
        {
            value = convertUnits(value);
            if (value.Equals("\r") || value.Equals(""))
                minSell = -System.Int32.MaxValue;
            else
                Int32.TryParse(value, out minSell);
        }

        public void setMaxSell(string value)
        {
            value = convertUnits(value);
            if (value.Equals("\r") || value.Equals(""))
                maxSell = System.Int32.MaxValue;
            else
                Int32.TryParse(value, out maxSell);
        }

        public void setMinVol(string value)
        {
            value = convertUnits(value);
            if (value.Equals("\r") || value.Equals(""))
                minVol = -System.Int32.MaxValue;
            else 
                Int32.TryParse(value, out minVol);
        }
        public void setMinMargin(string value)
        {
            value = convertUnits(value);
            if (value.Equals("\r") || value.Equals(""))
                minMargin = -System.Int32.MaxValue;
            else
                Int32.TryParse(value, out minMargin);
        }

        public void setMinProfit(string value)
        {
            value = convertUnits(value);
            if (value.Equals("\r") || value.Equals(""))
                minProfit = -System.Int32.MaxValue;
            else
                Int32.TryParse(value, out minProfit);
        }

        public void setCashStack(string value)
        {
            value = convertUnits(value);
            if (value.Equals("\r") || value.Equals(""))
                cashStack = System.Int32.MaxValue;
            else
                Int32.TryParse(value, out cashStack);
        }

        public string convertUnits(string value)
        {
            return value.ToLower().Replace("k", "000").Replace("m", "000000").Replace("b", "000000000");
        }
    }
}
