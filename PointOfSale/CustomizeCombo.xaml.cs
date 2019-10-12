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
        public CustomizeCombo(string entree)
        {
            InitializeComponent();
            ComboEntreeTextBox.Text = "Customize " + entree + " Combo";
        }

        /// <summary>
        /// Takes the user to the sides page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboSide_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SidesPage());
        }

        /// <summary>
        /// Takes the user to the drinks page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboDrink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinksPage());
        }
    }
}
