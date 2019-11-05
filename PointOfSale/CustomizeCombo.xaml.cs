/// CustomizeCombo.xaml.cs
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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page { 
    
        /// <summary>
        /// Constructs a new combo customization screen with the corresponding
        /// entree name.
        /// </summary>
        /// <param name="entree"></param>
        public CustomizeCombo(string entree, CretaceousCombo c)
        {
            InitializeComponent();
            ComboEntreeTextBox.Text = "Customize " + entree + " Combo";
            EntreeName.Text = entree;
            this.combo = c;
        }

        /// <summary>
        /// Private backing variable for storing the currently selected combo.
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Takes the user to the sides page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboSide_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SidesPage(combo));
        }

        /// <summary>
        /// Takes the user to the drinks page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboDrink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinksPage(combo));
        }

        /// <summary>
        /// Sets the size of the combo to large.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargeButton_Click(object sender, RoutedEventArgs e)
        {
            this.combo.Size = DinoDiner.Menu.Size.Large;
        }

        /// <summary>
        /// Sets the size of the combo to medium.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumButton_Click(object sender, RoutedEventArgs e)
        {
            this.combo.Size = DinoDiner.Menu.Size.Medium;
        }

        /// <summary>
        /// Sets the size of the combo to small.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallButton_Click(object sender, RoutedEventArgs e)
        {
            this.combo.Size = DinoDiner.Menu.Size.Small;
        }

        /// <summary>
        /// Navigates to the entree selection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboEntree_Click(object sender, RoutedEventArgs e)
        {
            if (combo.Entree is Brontowurst brat)
            {
                NavigationService.Navigate(new CustomizeBrontowurst(brat));
            }

            if (combo.Entree is TRexKingBurger borgar)
            {
                NavigationService.Navigate(new CustomizeTRexKingBurger(borgar));
            }

            if (combo.Entree is DinoNuggets nugs)
            {
                NavigationService.Navigate(new CustomizeDinoNuggets(nugs));
            }

            if (combo.Entree is SteakosaurusBurger burger)
            {
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(burger));
            }

            if (combo.Entree is VelociWrap wrap)
            {
                NavigationService.Navigate(new CustomizeVelociwrap(wrap));
            }

            if (combo.Entree is PrehistoricPBJ pbj)
            {
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
            }

            if (combo.Entree is PterodactylWings wings)
            {
                NavigationService.Navigate(new CustomizePterodactylWings(wings));
            }
        }
    }
}
