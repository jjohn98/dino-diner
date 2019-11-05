/// CustomizeBrontowurst.cs
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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        /// <summary>
        /// Private backing variable.
        /// </summary>
        private Brontowurst sausage;

        /// <summary>
        /// Private backing combo.
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor which initializes the private backing variable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public CustomizeBrontowurst(Brontowurst b)
        {
            InitializeComponent();
            this.sausage = b;
        }

        /// <summary>
        /// Constructor which initializes the private backing combo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public CustomizeBrontowurst(CretaceousCombo c)
        {
            InitializeComponent();
            this.combo = c;
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldOnionButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.sausage.HoldOnion();
            }
            else
            {
                if (combo.Entree is Brontowurst brat)
                {
                    brat.HoldOnion();
                }
            }
            
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldPeppersButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.sausage.HoldPeppers();
            }
            else
            {
                if (combo.Entree is Brontowurst brat)
                {
                    brat.HoldPeppers();
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
                this.sausage.HoldBun();
            }
            else
            {
                if (combo.Entree is Brontowurst brat)
                {
                    brat.HoldBun();
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
