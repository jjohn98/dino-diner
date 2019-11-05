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
        /// Stores the navigation service from the main page to link the main UI to the order list.
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
        private void ListBox_SelectionChanged(object sender, EventArgs e)
        {
            if (OrderItems.SelectedItem is Side side)
            {
                NavService?.Navigate(new SidesPage(side));
            }

            if (OrderItems.SelectedItem is PterodactylWings wings)
            {
                NavService?.Navigate(new CustomizePterodactylWings(wings));
            }

            if (OrderItems.SelectedItem is Drink drink)
            {
                NavService?.Navigate(new DrinksPage(drink));
            }

            if (OrderItems.SelectedItem is Brontowurst brat)
            {
                NavService?.Navigate(new CustomizeBrontowurst(brat));
            }

            if (OrderItems.SelectedItem is TRexKingBurger borgar)
            {
                NavService?.Navigate(new CustomizeTRexKingBurger(borgar));
            }

            if (OrderItems.SelectedItem is DinoNuggets nugs)
            {
                NavService?.Navigate(new CustomizeDinoNuggets(nugs));
            }

            if (OrderItems.SelectedItem is SteakosaurusBurger burger)
            {
                NavService?.Navigate(new CustomizeSteakosaurusBurger(burger));
            }

            if (OrderItems.SelectedItem is VelociWrap wrap)
            {
                NavService?.Navigate(new CustomizeVelociwrap(wrap));
            }

            if (OrderItems.SelectedItem is PrehistoricPBJ pbj)
            {
                NavService?.Navigate(new CustomizePrehistoricPBJ(pbj));
            }

            if (OrderItems.SelectedItem is CretaceousCombo combo)
            {
                NavService?.Navigate(new CustomizeCombo(combo.Entree.ToString(),combo));
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
