using System;
using System.Collections.Generic;
using System.Data;
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
using RunescraperObjects;

namespace Runescraper3
{
    /// <summary>
    /// Interaction logic for FlipSuggester.xaml
    /// </summary>
    public partial class FlipSuggester : UserControl
    {
        

       

        public FlipSuggester()
        {
            InitializeComponent();

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
          
          //  adapter = new DummyDBDataSetTableAdapters.DummyTableTableAdapter();
          //  adapter.Fill(dt);
          //  FlipDataGrid.ItemsSource(items);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //make button go to viewmodel
            //
        }

        private void FlipDataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.Column.Header.ToString() == "Name"){
                e.Column.Width = new DataGridLength(3, DataGridLengthUnitType.Star);
            }
            else
            {
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            }
        }
    }
}
