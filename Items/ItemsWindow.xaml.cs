﻿using GroupPrject.Common;
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
using System.Windows.Shapes;

namespace GroupPrject.Items
{
    /// <summary>
    /// Interaction logic for ItemsWindow.xaml
    /// </summary>
    public partial class ItemsWindow : Window
    {
        private MainWindow home;
        /// <summary>
        /// itemslogic class to hold the business logic
        /// </summary>
        ItemsLogic itemsLogic = new ItemsLogic();
        /// <summary>
        /// Used by the save button to determine if it needs to create a new item
        /// or update an existing one
        /// </summary>
        public bool isEditing;
        public ItemsWindow(MainWindow home)
        {
            try
            {
                InitializeComponent();

                this.home = home;
                dgItems.ItemsSource = itemsLogic.GetAllItems();
                txtCode.IsEnabled = false;
                txtCost.IsEnabled = false;
                txtDesc.IsEnabled = false;
            }
            catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }

        /// <summary>
        /// Called when the save button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveItem(object sender, RoutedEventArgs e)
        {
            try
            {
                // if the text boxes are not null
                if (txtDesc.Text != "" && txtCost.Text != "")
                {
                    // add the information to a new item
                    Item item = new Item(txtCode.Text, txtDesc.Text, txtCost.Text);

                    // if the code box isn't null and the user is not editing
                    if (txtCode.Text != "" && isEditing == false)
                    {
                        // add the new item
                        itemsLogic.AddItem(item);
                    }
                    else if (isEditing == true)
                    {
                        // keep the item code the same, so the user can't change it
                        Item selectedItem = (Item)dgItems.SelectedItem;
                        item.ItemCode = selectedItem.ItemCode;
                        // update the existing item
                        itemsLogic.UpdateItem(item);
                    }

                    // disable and reset text boxes
                    txtCode.IsEnabled = false;
                    txtCost.IsEnabled = false;
                    txtDesc.IsEnabled = false;
                    txtCode.Text = "";
                    txtCost.Text = "";
                    txtDesc.Text = "";
                    // update data grid
                    dgItems.ItemsSource = itemsLogic.GetAllItems();

                    home.NotifyOfItemsWindowChange();
                }

            }
            catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }

        /// <summary>
        /// Event handler for add item button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // enable text boxes
                txtCode.IsEnabled = true;
                txtCost.IsEnabled = true;
                txtDesc.IsEnabled = true;
            }
            catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }

        /// <summary>
        /// Event handler for delete button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
        private void buttonDeleteItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // if there is a selected item
                if(dgItems.SelectedItem != null)
                {
                    // create new item set to values of the selected item info
                    Item item = (Item)dgItems.SelectedItem;

                    // check if the item is connected to an invoice
                    string invoice = itemsLogic.GetInvoiceNum(item);
                    if (invoice == "")
                    {
                        // delete the item from the database
                        itemsLogic.DeleteItem(item);
                        // update datagrid
                        dgItems.ItemsSource = itemsLogic.GetAllItems();

                        home.NotifyOfItemsWindowChange();
                    }
                }
            }
            catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }

        private void btnEditItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // enable text boxes
                txtCost.IsEnabled = true;
                txtDesc.IsEnabled = true;

                isEditing = true;
            }
            catch (Exception ex) { throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message); }
        }
    }
}
