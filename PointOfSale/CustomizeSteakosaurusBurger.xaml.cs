/// CustomizeSteakosaurusBurger.cs
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
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        /// <summary>
        /// Private backing variable.
        /// </summary>
        private SteakosaurusBurger borgar;

        /// <summary>
        /// Private backing combo.
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor which initializes the private backing variable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public CustomizeSteakosaurusBurger(SteakosaurusBurger b)
        {
            InitializeComponent();
            this.borgar = b;
        }

        /// <summary>
        /// Constructor which initializes the private backing variable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public CustomizeSteakosaurusBurger(CretaceousCombo c)
        {
            InitializeComponent();
            this.combo = c;
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldPickleButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.borgar.HoldPickle();
            }
            else
            {
                if (combo.Entree is SteakosaurusBurger s)
                {
                    s.HoldPickle();
                }
            }
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldBunButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.borgar.HoldBun();
            }
            else
            {
                if (combo.Entree is SteakosaurusBurger s)
                {
                    s.HoldBun();
                }
            }
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldKetchupButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.borgar.HoldKetchup();
            }
            else
            {
                if (combo.Entree is SteakosaurusBurger s)
                {
                    s.HoldKetchup();
                }
            }
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldMustardButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.borgar.HoldMustard();
            }
            else
            {
                if (combo.Entree is SteakosaurusBurger s)
                {
                    s.HoldMustard();
                }
            }
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
