/// DrinksPage.xaml.cs
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinksPage.xaml
    /// </summary>
    public partial class DrinksPage : Page
    {
        /// <summary>
        /// Initializes a new drinks page with all secondary options disabled.
        /// </summary>
        public DrinksPage()
        {
            InitializeComponent();
            FlavorButton.IsEnabled = false;
            IceButton.IsEnabled = false;
            LemonButton.IsEnabled = false;
            DecafButton.IsEnabled = false;
            SweetButton.IsEnabled = false;
        }

        /// <summary>
        /// Enables secondary options specific to this drink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sodasaurus_Click(object sender, RoutedEventArgs e)
        {
            FlavorButton.IsEnabled = true;
            IceButton.IsEnabled = true;
            LemonButton.IsEnabled = false;
            DecafButton.IsEnabled = false;
            SweetButton.IsEnabled = false;
        }

        /// <summary>
        /// Enables secondary options specific to this drink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tyrannotea_Click(object sender, RoutedEventArgs e)
        {
            FlavorButton.IsEnabled = false;
            IceButton.IsEnabled = true;
            LemonButton.IsEnabled = true;
            DecafButton.IsEnabled = false;
            SweetButton.IsEnabled = true;
        }

        /// <summary>
        /// Enables secondary options specific to this drink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Jurassicjava_Click(object sender, RoutedEventArgs e)
        {
            FlavorButton.IsEnabled = false;
            IceButton.IsEnabled = false;
            LemonButton.IsEnabled = false;
            DecafButton.IsEnabled = true;
            SweetButton.IsEnabled = false;
        }

        /// <summary>
        /// Enables secondary options specific to this drink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Water_Click(object sender, RoutedEventArgs e)
        {
            FlavorButton.IsEnabled = false;
            IceButton.IsEnabled = true;
            LemonButton.IsEnabled = true;
            DecafButton.IsEnabled = false;
            SweetButton.IsEnabled = false;
        }

        /// <summary>
        /// Takes the user to the customize flavor page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Flavor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeFlavor());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Decaf_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sweet_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
