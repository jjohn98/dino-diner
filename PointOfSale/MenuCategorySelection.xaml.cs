/// MenuCategorySelection.xaml.cs
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
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        /// <summary>
        /// Constructor for the menu category selection page.
        /// </summary>
        public MenuCategorySelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Takes the user to the combo selection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Combo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComboPage());
        }

        /// <summary>
        /// Takes the user to the Entree selection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Entrees_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EntreesPage());
        }

        /// <summary>
        /// Takes the user to the side selection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sides_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SidesPage());
        }

        /// <summary>
        /// Takes the user to the drink selection page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Drinks_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinksPage());
        }
    }
}
