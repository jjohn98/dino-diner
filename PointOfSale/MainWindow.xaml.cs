/// MainWindow.xaml.cs
/// Author: Nathan Bean
/// Modified by: Jack Johnson
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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructs a new main window.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            Order order = new Order();

            DataContext = order;

            OrderUI.Navigate(new MenuCategorySelection());

            OrderControl.NavService = OrderUI.NavigationService;

        }

        /// <summary>
        /// Passes the data context to the page as it does not have implicit access to it.
        /// </summary>
        private void PassDataContextToPage()
        {
            if (OrderUI.Content is Page page)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }

        /// <summary>
        /// Passes the data context upon completing a load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderUI_LoadCompleted(object sender, NavigationEventArgs e)
        {
            PassDataContextToPage();
        }

        /// <summary>
        /// Passes the data context upon the data context changing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderUI_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            PassDataContextToPage();
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            OrderUI.NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
