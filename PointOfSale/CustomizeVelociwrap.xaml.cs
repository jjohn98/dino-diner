/// CustomizeVelociwrap.cs
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
    /// Interaction logic for CustomizeVelociwrap.xaml
    /// </summary>
    public partial class CustomizeVelociwrap : Page
    {
        /// <summary>
        /// Private backing variable.
        /// </summary>
        private VelociWrap wrap;

        /// <summary>
        /// Constructor which initializes the private backing variable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public CustomizeVelociwrap(VelociWrap w)
        {
            InitializeComponent();
            this.wrap = w;
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldTortillaButton_Click(object sender, RoutedEventArgs e)
        {
            this.wrap.HoldTortilla();
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldLettuceButton_Click(object sender, RoutedEventArgs e)
        {
            this.wrap.HoldLettuce();
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldCheeseButton_Click(object sender, RoutedEventArgs e)
        {
            this.wrap.HoldCheese();
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldDressingButton_Click(object sender, RoutedEventArgs e)
        {
            this.wrap.HoldDressing();
        }

        /// <summary>
        /// Navigates to the previous page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
