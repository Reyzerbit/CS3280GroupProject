using GroupPrject.Common;
using GroupPrject.Items;
using GroupPrject.Main;
using GroupPrject.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace GroupPrject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Search window instance
        /// </summary>
        SearchWindow searchWindow;

        /// <summary>
        /// Items window instance
        /// </summary>
        ItemsWindow itemsWindow;

        Invoice invoice;

        /// <summary>
        /// Main window constructor
        /// </summary>
        /// <exception cref="Exception"></exception>
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                searchWindow = new SearchWindow(this);
                itemsWindow = new ItemsWindow(this);
            }
            catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }

        /// <summary>
        /// Called on "Search" menu item click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
        private void OpenSearch(object sender, RoutedEventArgs e)
        {
            try
            {
                searchWindow.ShowDialog();
                if (searchWindow.invoiceNumber != null)
                {
                    int invoiceNumber = searchWindow.invoiceNumber.Value;
                    searchWindow.invoiceNumber = null;
                    // Process invoice get
                    invoice = MainSQL.GetInvoiceData(invoiceNumber);
                }
            }
            catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }

        /// <summary>
        /// Called on "Items" menu item click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
        private void OpenItems(object sender, RoutedEventArgs e)
        {
            try
            {
                itemsWindow.ShowDialog();
            }
            catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }
    }
}
