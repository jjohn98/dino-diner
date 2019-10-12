/// ComboPage.xaml.cs
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
    /// Interaction logic for ComboPage.xaml
    /// </summary>
    public partial class ComboPage : Page
    {
        /// <summary>
        /// Creates a new combo page.
        /// </summary>
        public ComboPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Takes the user to the customize combo page and sends the name
        /// of the entree for the combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrontowurstCombo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("Brontowurst"));
        }

        /// <summary>
        /// Takes the user to the customize combo page and sends the name
        /// of the entree for the combo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DinoNuggetsCombo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("Dino-Nuggets"));
        }

        /// <summary>
        /// Takes the user to the customize combo page and sends the name
        /// of the entree for the combo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SteakosaurusCombo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("Steakosaurus"));
        }

        /// <summary>
        /// Takes the user to the customize combo page and sends the name
        /// of the entree for the combo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrehistoricPBJCombo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("Prehistoric PB&J"));
        }

        /// <summary>
        /// Takes the user to the customize combo page and sends the name
        /// of the entree for the combo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PterodactylWingsCombo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("Pterodactyl Wings"));
        }

        /// <summary>
        /// Takes the user to the customize combo page and sends the name
        /// of the entree for the combo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VelociWrapCombo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("Veloci-Wrap"));
        }

        /// <summary>
        /// Takes the user to the customize combo page and sends the name
        /// of the entree for the combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TRexKingBurgerCombo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo("T-Rex King Burger"));
        }
    }
}
