using RunescraperObjects;
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
    public partial class FlipGetter : UserControl
    {
        public FlipGetter()
        {
            InitializeComponent();
        }

        private void SuggestFlipsButton_Click(object sender, EventArgs e)
        {
            SuggestFlipsButton.Enabled = false;
            SuggestFlipsButton.Text = "Getting Suggestions...";
            //
        }

        public void updateWithSuggestions(List<Item> suggestions)
        {
            
            foreach (Item item in suggestions)
            {
                suggestionTable.Rows.Add(item.name, item.low, item.high, item.limit, item.volume, item.getMargin(), item.getProfit());
            }
            SuggestFlipsButton.Text = "Suggest Items";
            SuggestFlipsButton.Enabled = true;
        }

        private void UpdatePricesButton_Click(object sender, EventArgs e)
        {
            UpdatePricesButton.Enabled = false;
            UpdatePricesButton.Text = "Getting current prices...";
        }

        internal void updateCashStackBox(int CashStackSetting)
        {
            CashStackTextbox.Text = CashStackSetting.ToString();
        }

        public void finishUpdatingPrices()
        {
            UpdatePricesButton.Enabled = true;
            UpdatePricesButton.Text = "UPDATE PRICES";
        }
    }
}
