/// SidesPage.xaml.cs
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
    /// Interaction logic for SidesPage.xaml
    /// </summary>
    public partial class SidesPage : Page
    {
        /// <summary>
        /// Constructor for the sides page.
        /// </summary>
        public SidesPage()
        {
            InitializeComponent();
        }

        public SidesPage(Side s)
        {
            InitializeComponent();
            this.side = s;
        }

        /// <summary>
        /// Private backing variable holding the last created side.
        /// </summary>
        private Side side;

        private void SelectSide(Side s)
        {
            if (DataContext is Order order)
            {
                order.Add(s);
            }
        }

        private void Fryceritops_Click(object sender, RoutedEventArgs e)
        {
            SelectSide(new Fryceritops());
        }

        private void MeteorMacAndCheese_Click(object sender, RoutedEventArgs e)
        {
            SelectSide(new MeteorMacAndCheese());
        }

        private void Triceritots_Click(object sender, RoutedEventArgs e)
        {
            SelectSide(new Triceritots());
        }

        private void MezzorellaSticks_Click(object sender, RoutedEventArgs e)
        {
            SelectSide(new MezzorellaSticks());
        }

        /// <summary>
        /// Sets the currently seelcted item's size to small.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Small_Click(object sender, RoutedEventArgs e)
        {
            side.Size = DinoDiner.Menu.Size.Small;
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Sets the currently selected item's size to medium.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            side.Size = DinoDiner.Menu.Size.Medium;
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Sets the currently seelcted item's size to large.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Large_Click(object sender, RoutedEventArgs e)
        {
            side.Size = DinoDiner.Menu.Size.Large;
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Changes the size depending on which is clicked
        /// Currently unused.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Size_Click(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                side.Size = (DinoDiner.Menu.Size)Enum.Parse(typeof(DinoDiner.Menu.Size), element.Tag.ToString());
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
