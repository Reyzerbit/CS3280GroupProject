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

namespace GroupPrject.Items
{
    /// <summary>
    /// Interaction logic for ItemsWindow.xaml
    /// </summary>
    public partial class ItemsWindow : Window
    {
        ItemsLogic ItemsLogic = new ItemsLogic();
        public ItemsWindow(MainWindow home)
        {
            InitializeComponent();
            dgItems.ItemsSource = ItemsLogic.GetAllItems();
        }

        //bool bHasItemsBeenChanged;    //Set to true when an item has been added/edited/deleted.   Used by main window to know if needs to refresh items list
        //bool HasItemsBeenChanged;     //Property

    }
}
