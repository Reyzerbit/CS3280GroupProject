using Assignment_6;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
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
        /// A Lot of stuff used to remove the X icon from the window. This means that the close window button must be used.
        /// </summary>
        private const int GWL_STYLE = -16;
        private const int WS_SYSMENU = 0x80000;
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        /// <summary>
        /// public invoice number for MainWindow access
        /// </summary>
        public int? invoiceNumber = null;

        //initialize logic object
        SearchLogic logic;

        private int InvNum = -1;
        private string Date = "";
        private int Total = -1;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="home"></param>
        /// <exception cref="Exception"></exception>
        public SearchWindow()
        {
            try
            {
                InitializeComponent();
                logic = new SearchLogic();

                //fill datagrid with default data.
                DataSet ds = new DataSet();
                ds = logic.ReturnAll();
                dgResults.ItemsSource = ds.Tables[0].AsDataView();
            
                //Fill Invoices
                DataSet InvoiceNums = logic.GetInvoiceNumList();
                List<int> InvoiceNumbers = new List<int>();
                for(int i =0; i < InvoiceNums.Tables[0].Rows.Count; i++)
                {
                    string conv = String.Join("",InvoiceNums.Tables[0].Rows[i].ItemArray);
                    int num = Convert.ToInt32(conv);
                    InvoiceNumbers.Add(num);
                }
                cboInvNum.ItemsSource = InvoiceNumbers;

                //Fill Dates
                DataSet Dates = logic.GetDates();
                List<string> lDates = new List<string>();
                for (int i = 0; i < Dates.Tables[0].Rows.Count; i++)
                {
                    lDates.Add(String.Join("", Dates.Tables[0].Rows[i].ItemArray) );
                }
                cboInvDate.ItemsSource = lDates;

                //Fill charges
                DataSet Totals = logic.GetTotals();
                List<int> Tots = new List<int>();
                for (int i = 0; i < Totals.Tables[0].Rows.Count; i++)
                {
                    string conv = String.Join("", Totals.Tables[0].Rows[i].ItemArray);
                    Tots.Add(Convert.ToInt32(conv));
                }
                cboInvCharge.ItemsSource = Tots;


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
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem != null)
            {  DataSet ds = new DataSet();
                try
                {
                    //get input to string
                    string answer = cb.SelectedItem.ToString();

                    //get the input in the correct format
                    int num = Convert.ToInt32(answer);

                    InvNum = num;

                    //Call general method
                    FillDataGrid();
                }
                catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
            }

        }
        /// <summary>
        /// Receives the Users invoice date, sends to SearchLogic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvDatePass(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if(cb.SelectedItem != null)
            {
                Date = cb.SelectedItem.ToString();
            }

            //Call general method
            FillDataGrid();
        }

        /// <summary>
        /// Receives the Users Invoice charges list and sends to search logic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvChargePass(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedItem != null)
            {
                try
                {
                    string answer = cb.SelectedItem.ToString();
                    int num = Convert.ToInt32(answer);

                    Total = num;

                    //call general method
                    FillDataGrid();
                }
                catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
            }
        }



        private void FillDataGrid()
        {
            DataSet ds = new DataSet();
            try
            {
                if (InvNum > -1)
                {
                    if (Date != "")
                    {
                        if (Total > -1)
                        {
                            ds = logic.ReturnQuery(InvNum, Date, Total);
                        
                        }
                        else
                        {
                            ds = logic.ReturnQuery(InvNum, Date);
                        }

                    }
                    else if (Total>-1)
                    {
                        ds = logic.ReturnQuery(InvNum, "0-0-0000", Total);
                    }
                    else
                    {
                        ds = logic.ReturnQuery(InvNum);
                    }
                }
                else if (Date != "" && InvNum==-1)
                {
                    if(Total > -1) 
                    {
                        ds = logic.ReturnQuery(-1, Date, Total);
                    }
                    else
                    {
                        ds = logic.ReturnQuery(-1, Date);
                    }
                }
                else if(InvNum==-1 && Date == "" && Total > -1)
                {
                    ds = logic.ReturnQuery(-1, "0-0-0000", Total);
                }
            }
            catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
            if(ds != null)
            {
                //dgResults.Items.Clear();
                dgResults.ItemsSource = ds.Tables[0].AsDataView();
            }
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
            this.Hide();
        }

        /// <summary>
        /// Cancel will close the window and return to the Main window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearSearch(object sender, RoutedEventArgs e)
        {
            //Used to have this.close() then this.Hide(), but this button doesn't close the form


        }

        /// <summary>
        /// Used to remove the X Button from the pane.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                IntPtr hwnd = new WindowInteropHelper(this).Handle;
                SetWindowLong(hwnd, GWL_STYLE, GetWindowLong(hwnd, GWL_STYLE) & ~WS_SYSMENU);
            }
            catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }

    }
}
