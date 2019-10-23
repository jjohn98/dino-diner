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

        /// <summary>
        /// Private backing variable holding the last created side.
        /// </summary>
        private Side side;

        private void Fryceritops_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                side = new Fryceritops();
                order.Items.Add(side);
            }

        }

        private void Small_Click(object sender, RoutedEventArgs e)
        {
            side.Size = DinoDiner.Menu.Size.Small;
            
        }

        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            side.Size = DinoDiner.Menu.Size.Medium;
        }

        private void Large_Click(object sender, RoutedEventArgs e)
        {
            side.Size = DinoDiner.Menu.Size.Large;
        }

        private void Size_Click(object sender, RoutedEventArgs e)
        {
            if (sender is FrameworkElement element)
            {
                side.Size = (DinoDiner.Menu.Size)Enum.Parse(typeof(DinoDiner.Menu.Size), element.Tag.ToString());

            }
        }
    }
}
