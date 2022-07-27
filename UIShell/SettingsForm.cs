using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIShell
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }


        public void updateMinBuyBox(int MinBuySetting)
        {
            this.MinBuyTextbox.Text = MinBuySetting.ToString();
        }

        public void updateMaxBuyBox(int MaxBuySetting)
        {
            this.MaxBuyTextbox.Text = MaxBuySetting.ToString();
        }

        public void updateMinSellBox(int MinSellSetting)
        {
            this.MinSellTextbox.Text = MinSellSetting.ToString();
        }

        public void updateMaxSellBox(int MaxSellSetting)
        {
            this.MaxSellTextbox.Text = MaxSellSetting.ToString();
        }

        public void updateMinVolBox(int MinVolSetting)
        {
            this.MinVolTextbox.Text = MinVolSetting.ToString();
        }
        public void updateMinMarginBox(int MinMarginSetting)
        {
            this.MinMarginTextbox.Text = MinMarginSetting.ToString();
        }

        public void updateMinProfitBox(int MinProfitSetting)
        {
            this.MinProfitTextbox.Text = MinProfitSetting.ToString();
        }
    }
}
