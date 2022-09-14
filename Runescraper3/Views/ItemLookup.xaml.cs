using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Runescraper3
{
    /// <summary>
    /// Interaction logic for ItemLookup.xaml
    /// </summary>
    public partial class ItemLookup : UserControl
    {
        public ItemLookup()
        {
            InitializeComponent();
        }

        private void FlipDataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.Column.Header.ToString() == "Name")
            {
                e.Column.Width = new DataGridLength(3, DataGridLengthUnitType.Star);
            }
            else
            {
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            }
        }
    }
}
