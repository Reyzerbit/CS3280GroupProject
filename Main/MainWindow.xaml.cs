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

        /// <summary>
        /// Invoice object. Can be null if no invoice is selected
        /// </summary>
        Invoice invoice;

        /// <summary>
        /// Used to determine if invoice is being edited or not
        /// </summary>
        bool isEditing = false;

        /// <summary>
        /// Main window constructor
        /// </summary>
        /// <exception cref="Exception"></exception>
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                searchWindow = new SearchWindow();
                itemsWindow = new ItemsWindow();

                ItemsDropdown.ItemsSource = itemsWindow.Items;
                SetInvoiceEditable(false);
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
                    invoice = MainLogic.GetInvoice(invoiceNumber);
                    UpdateInvoiceUI();
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
                ItemsDropdown.ItemsSource = itemsWindow.Items;
                ItemsDropdown.SelectedItem = null;
                SelectedItemCostLabel.Content = null;
            }
            catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }

        /// <summary>
        /// Called when Items dropdown is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsDropdownSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if(ItemsDropdown.SelectedItem != null) SelectedItemCostLabel.Content = ((Item)ItemsDropdown.SelectedItem).Cost.ToString();
            }
            catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }

        /// <summary>
        /// Helper function for enabling/disabling item UI
        /// </summary>
        /// <param name="editable"></param>
        private void SetInvoiceEditable(bool editable)
        {
            try
            {
                ItemsDropdown.IsEnabled = editable;
                AddItemButton.IsEnabled = editable;
                RemoveItemButton.IsEnabled = editable;
                InvoiceDateBox.IsEnabled = editable;
                InvoiceNumberBox.IsEnabled = editable;
                InvoiceCostBox.IsEnabled = editable;
            }
            catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }

        /// <summary>
        /// Helper function to update UI when invoice is loaded
        /// </summary>
        /// <exception cref="Exception"></exception>
        private void UpdateInvoiceUI()
        {
            try
            {
                if (invoice != null)
                {
                    InvoiceDateBox.Text = invoice.InvDate.ToString();
                    InvoiceNumberBox.Text = invoice.InvNum.ToString();
                    InvoiceCostBox.Text = invoice.InvCharge.ToString();
                    SetInvoiceEditable(isEditing);
                }
                else
                {
                    InvoiceDateBox.Text = "";
                    InvoiceNumberBox.Text = "";
                    InvoiceCostBox.Text = "";
                    SetInvoiceEditable(false);
                }
            }
            catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }

        private void CreateInvoice(object sender, RoutedEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }
    }
}
