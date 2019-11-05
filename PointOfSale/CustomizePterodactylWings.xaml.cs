/// CustomizePterodactylWings.cs
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
    /// Interaction logic for CustomizePterodactylWings.xaml
    /// </summary>
    public partial class CustomizePterodactylWings : Page
    {
        /// <summary>
        /// Private backing variable.
        /// </summary>
        private PterodactylWings wings;

        /// <summary>
        /// Private backing combo.
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor which initializes the private backing variable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public CustomizePterodactylWings(PterodactylWings w)
        {
            InitializeComponent();
            this.wings = w;
        }

        /// <summary>
        /// Constructor which initializes the private backing combo.
        /// </summary>
        /// <param name="c"></param>
        public CustomizePterodactylWings(CretaceousCombo c)
        {
            InitializeComponent();
            this.combo = c;
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldWingSauceButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.wings.HoldSauce();
            }
            else
            {
                if (combo.Entree is PterodactylWings w)
                {
                    w.HoldSauce();
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
