/// CustomizeTRexKingBurger.cs
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
    /// Interaction logic for CustomizeTRexKingBurger.xaml
    /// </summary>
    public partial class CustomizeTRexKingBurger : Page
    {
        /// <summary>
        /// Private backing variable.
        /// </summary>
        private TRexKingBurger borgar;

        /// <summary>
        /// Constructor which initializes the private backing variable.
        /// </summary>
        /// <param name="b"></param>
        public CustomizeTRexKingBurger(TRexKingBurger b)
        {
            InitializeComponent();
            this.borgar = b;
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldKetchupButton_Click(object sender, RoutedEventArgs e)
        {
            this.borgar.HoldKetchup();
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldMustardButton_Click(object sender, RoutedEventArgs e)
        {
            this.borgar.HoldMustard();
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

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldBunButton_Click(object sender, RoutedEventArgs e)
        {
            this.borgar.HoldBun();
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldPickleButton_Click(object sender, RoutedEventArgs e)
        {
            this.borgar.HoldPickle();
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldLettuceButton_Click(object sender, RoutedEventArgs e)
        {
            this.borgar.HoldLettuce();
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldOnionButton_Click(object sender, RoutedEventArgs e)
        {
            this.borgar.HoldOnion();
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldMayoButton_Click(object sender, RoutedEventArgs e)
        {
            this.borgar.HoldMayo();
        }
    }
}
