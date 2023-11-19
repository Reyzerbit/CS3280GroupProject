using GroupPrject.Common;
using GroupPrject.Items;
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
        /// This method is called by the Items Window from the passed in MainWindow reference when a change has been made.
        /// </summary>
        public void NotifyOfItemsWindowChange()
        {
            try
            {
                itemsWindow.Hide();

                // itemsWindow.getItem();

                // This is also where the combo boxes will be updated

                // itemsWindow.getTheStuff()
                // Do stuff with the stuff
            }
            catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }

        /// <summary>
        /// This method is called by the Search Window from the passed in MainWindow reference when all logic is done.
        /// </summary>
        public void ReturnFromSearchWindow(/*int invoice = null*/)
        {
            try
            {
                searchWindow.Hide();
                /*
                 * Invoice is passed back from search window, and stuff is done.
                 * 
                 * We are aware that instructions said to save invoice ID to local variable and tghen retrieve it,
                 * but this way results in one less step of having to clear the local variable when we're done with it.
                 * 
                 * if(invoice == null)
                 * else
                 */
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
