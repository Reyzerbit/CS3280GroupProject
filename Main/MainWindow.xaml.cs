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

namespace GroupPrject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        

        /// <summary>
        /// This method is called by the Items Window from the passed in MainWindow reference when all logic is done.
        /// </summary>
        public void ReturnFromItemsWindow(/*Needed Variables*/)
        {
            /*
             * Whatever needed data that is required from the Items Window
             * will be processsed hear and passed in via Needed Variables
             */
        }

        /// <summary>
        /// This method is called by the Search Window from the passed in MainWindow reference when all logic is done.
        /// </summary>
        public void ReturnFromSearchWindow(/*Needed Variables*/)
        {
            /*
             * Whatever needed data that is required from the Search Window
             * will be processsed hear and passed in via Needed Variables
             */
        }
    }
}
