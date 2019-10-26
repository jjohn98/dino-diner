/// OrderList.xaml.cs
/// Author: Jack Johnson
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
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public NavigationService NavService { get; set; }

        public OrderList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Removes an item from the list when the remove button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if (element.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }

        /// <summary>
        /// Navigates to the appropriate page when the item is clicked on in the OrderItems.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrderItems.SelectedItem is Side side)
            {
                NavService?.Navigate(new SidesPage(side));
            }

            if (OrderItems.SelectedItem is Entree entree)
            {
                NavService?.Navigate(new EntreesPage(entree));
            }

            if (OrderItems.SelectedItem is Drink drink)
            {
                NavService?.Navigate(new DrinksPage(drink));
            }
        }

        /// <summary>
        /// Creates a new order and scraps the old one.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if (element.DataContext is List<IOrderItem> items)
                    {
                        foreach (IOrderItem item in items)
                        {
                            items.Remove(item);
                        }
                    }
                }
            }
        }
    }

    
}
