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
using DinoDiner.Menu;

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
            Brontowurst brat = new Brontowurst();
            CretaceousCombo combo = new CretaceousCombo(brat);
            NavigationService.Navigate(new CustomizeCombo("Brontowurst", combo));        
            SelectCombo(combo);

        }

        /// <summary>
        /// Takes the user to the customize combo page and sends the name
        /// of the entree for the combo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DinoNuggetsCombo_Click(object sender, RoutedEventArgs e)
        {
            DinoNuggets nugs = new DinoNuggets();
            CretaceousCombo combo = new CretaceousCombo(nugs);
            NavigationService.Navigate(new CustomizeCombo("Dino-Nuggets", combo));
            SelectCombo(combo);
        }

        /// <summary>
        /// Takes the user to the customize combo page and sends the name
        /// of the entree for the combo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SteakosaurusCombo_Click(object sender, RoutedEventArgs e)
        {
            SteakosaurusBurger borgar = new SteakosaurusBurger();
            CretaceousCombo combo = new CretaceousCombo(borgar);
            NavigationService.Navigate(new CustomizeCombo("Steakosaurus", combo));
            SelectCombo(combo);
        }

        /// <summary>
        /// Takes the user to the customize combo page and sends the name
        /// of the entree for the combo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrehistoricPBJCombo_Click(object sender, RoutedEventArgs e)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            CretaceousCombo combo = new CretaceousCombo(pbj);
            NavigationService.Navigate(new CustomizeCombo("Prehistoric PB&J", combo));
            SelectCombo(combo);
        }

        /// <summary>
        /// Takes the user to the customize combo page and sends the name
        /// of the entree for the combo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PterodactylWingsCombo_Click(object sender, RoutedEventArgs e)
        {
            PterodactylWings wings = new PterodactylWings();
            CretaceousCombo combo = new CretaceousCombo(wings);
            NavigationService.Navigate(new CustomizeCombo("Pterodactyl Wings", combo));
            SelectCombo(combo);
        }

        /// <summary>
        /// Takes the user to the customize combo page and sends the name
        /// of the entree for the combo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VelociWrapCombo_Click(object sender, RoutedEventArgs e)
        {
            VelociWrap wrap = new VelociWrap();
            CretaceousCombo combo = new CretaceousCombo(wrap);
            NavigationService.Navigate(new CustomizeCombo("Veloci-Wrap", combo));
            SelectCombo(combo);
        }

        /// <summary>
        /// Takes the user to the customize combo page and sends the name
        /// of the entree for the combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TRexKingBurgerCombo_Click(object sender, RoutedEventArgs e)
        {
            TRexKingBurger borgar = new TRexKingBurger();
            CretaceousCombo combo = new CretaceousCombo(borgar);
            NavigationService.Navigate(new CustomizeCombo("T-Rex King Burger", combo));
            SelectCombo(combo);
        }

        /// <summary>
        /// Adds the specified Combo to the order.
        /// </summary>
        /// <param name="s"></param>
        private void SelectCombo(CretaceousCombo c)
        {
            if (DataContext is Order order)
            {
                order.Add(c);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
    }
}
