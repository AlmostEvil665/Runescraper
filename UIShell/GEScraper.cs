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
    public partial class GEScraper : UserControl
    {
        public GEScraper()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdatePricesButton_Click(object sender, EventArgs e)
        {
            UpdatePricesButton.Enabled = false;
            UpdatePricesButton.Text = "Getting current prices...";
        }

        internal void addItems(List<Item> items)
        {
            itemGridView.Rows.Clear();
            foreach (Item item in items)
            {
                itemGridView.Rows.Add(item.name, item.low, item.high, item.limit, item.volume, item.getMargin(), item.getProfit());
            }
            UpdatePricesButton.Text = "UPDATE PRICES";
            UpdatePricesButton.Enabled = true;

        }
    }
}
