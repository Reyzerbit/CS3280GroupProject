using Assignment_6;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace GroupPrject.Search
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        /// <summary>
        /// MainWindow instance passed in constructor
        /// </summary>
        private MainWindow home;
        public int? invoiceNumber = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="home"></param>
        /// <exception cref="Exception"></exception>
        public SearchWindow(MainWindow home)
        {
            try
            {
                InitializeComponent();
                this.home = home;
                SearchLogic logic = new SearchLogic();

                //fill datagrid with default data.
                DataSet ds = new DataSet();
                ds = logic.ReturnAll();
            }
            catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }

        /// <summary>
        /// Receives the Users invoice number, sends to SearchLogic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvNumPass(object sender, SelectionChangedEventArgs e)
        {

        }
        /// <summary>
        /// Receives the Users invoice date, sends to SearchLogic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvDatePass(object sender, SelectionChangedEventArgs e)
        {

        }

        /// <summary>
        /// Receives the Users Invoice charges list and sends to search logic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvChargePass(object sender, SelectionChangedEventArgs e)
        {

        }

        /// <summary>
        /// Gets the selected invoice.
        /// Calls "GetInvoice" from SearchLogic and return it to the MainWindow via ReturnFromSearchWindow().
        /// When a item is selected from the datagrid, the lblSelectStatus will change and appear to
        /// display the selected item to the user before they click the select button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectInvoice(object sender, RoutedEventArgs e)
        {
            // invoiceNumber = SearchLogic.GetInvoiceNumber();
            this.Close();
        }

        /// <summary>
        /// Cancel will close the window and return to the Main window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearSearch(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
