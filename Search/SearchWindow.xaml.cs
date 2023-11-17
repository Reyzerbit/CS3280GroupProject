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
using System.Windows.Shapes;

namespace GroupPrject.Search
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        public SearchWindow(MainWindow home)
        {
            InitializeComponent();
        }

        private void InvNumPass(object sender, EventArgs e)
        {
            // receives the Users invoice number, sends to SearchLogic

            //ReturnFromSearchWindow()
        }

        private void InvDatePass(object sender, EventArgs e)
        {
            // receives the Users invoice date, sends to SearchLogic

        }

        private void InvChargePass(object sender, EventArgs e)
        {
            //Receives the Users Invoice charges list and sends to search logic
        }

        private void SelectInvoice(object sender, RoutedEventArgs e)
        {
            //gets the selected invoice. creates an object of type clsInvoice and passes it to the main ]
            //Window using ReturnFromSearchWindow() in the MainLogic

            //for the prototype select button will just close the window
            this.Close();
        }

        private void CancelSearch(object sender, RoutedEventArgs e)
        {
            //btnCancel will close the window and return to the Main window.
            this.Close();
        }
    }
}
