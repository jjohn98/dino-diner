/// CustomizeFlavor.xaml.cs
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
    /// Interaction logic for CustomizeFlavor.xaml
    /// </summary>
    public partial class CustomizeFlavor : Page
    {
        /// <summary>
        /// Constructor for the customize flavor page.
        /// </summary>
        public CustomizeFlavor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor which takes a sodasaurus.
        /// </summary>
        /// <param name="s"></param>
        public CustomizeFlavor(Sodasaurus s)
        {
            InitializeComponent();
            soda = s;
        }

        /// <summary>
        /// Private backing soda which changes the flavor.
        /// </summary>
        private Sodasaurus soda;

        /// <summary>
        /// Changes the sodasaurus flavor to the selected flavor.
        /// </summary>
        /// <param name="s"></param>
        private void SelectFlavor(SodasaurusFlavor s)
        {
            soda.Flavor = s;
        }

        /// <summary>
        /// Changes the selected sodas flavor to cherry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cherry_Click(object sender, RoutedEventArgs e)
        {
            SelectFlavor(SodasaurusFlavor.Cherry);
        }

        /// <summary>
        /// Changes the selected sodas flavor to Lime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lime_Click(object sender, RoutedEventArgs e)
        {
            SelectFlavor(SodasaurusFlavor.Lime);
        }

        /// <summary>
        /// Changes the selected sodas flavor to Vanilla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Vanilla_Click(object sender, RoutedEventArgs e)
        {
            SelectFlavor(SodasaurusFlavor.Vanilla);
        }

        /// <summary>
        /// Changes the selected sodas flavor to Chocolate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Chocolate_Click(object sender, RoutedEventArgs e)
        {
            SelectFlavor(SodasaurusFlavor.Chocolate);
        }

        /// <summary>
        /// Changes the selected sodas flavor to Orange.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Orange_Click(object sender, RoutedEventArgs e)
        {
            SelectFlavor(SodasaurusFlavor.Orange);
        }

        /// <summary>
        /// Changes the selected sodas flavor to Cola.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cola_Click(object sender, RoutedEventArgs e)
        {
            SelectFlavor(SodasaurusFlavor.Cola);
        }

        /// <summary>
        /// Changes the selected sodas flavor to Root Beer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RootBeer_Click(object sender, RoutedEventArgs e)
        {
            SelectFlavor(SodasaurusFlavor.RootBeer);
        }
    }
}
