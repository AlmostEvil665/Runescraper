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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();
            FrameworkElement.StyleProperty.OverrideMetadata(typeof(Window), new FrameworkPropertyMetadata
            {
                DefaultValue = FindResource(typeof(Window))
            });
            FlipButton.Content = "Flip";
        }



        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void CollapseAll()
        {
            FlipSuggesterWindow.Visibility = Visibility.Collapsed;
            ItemLookupWindow.Visibility = Visibility.Collapsed;

        }

        private void FlipButton_Click(object sender, RoutedEventArgs e)
        {

            if (FlipSuggesterWindow.Visibility == Visibility.Collapsed)
            {
                CollapseAll();
                FlipSuggesterWindow.Visibility = Visibility.Visible;
            }

        }



        private void ScrapeButton_Click(object sender, RoutedEventArgs e)
        {

            if (ItemLookupWindow.Visibility == Visibility.Collapsed)
            {
                CollapseAll();
                ItemLookupWindow.Visibility = Visibility.Visible;
            }
        }







        private void MenuRibbonGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void ResizeButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

    }
}
