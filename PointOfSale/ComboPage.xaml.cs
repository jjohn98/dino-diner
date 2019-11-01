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
            NavigationService.Navigate(new CustomizeCombo("Brontowurst"));
            Brontowurst brat = new Brontowurst();
            CretaceousCombo combo = new CretaceousCombo(brat);
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
            NavigationService.Navigate(new CustomizeCombo("Dino-Nuggets"));
            DinoNuggets nugs = new DinoNuggets();
            CretaceousCombo combo = new CretaceousCombo(nugs);
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
            NavigationService.Navigate(new CustomizeCombo("Steakosaurus"));
            SteakosaurusBurger borgar = new SteakosaurusBurger();
            CretaceousCombo combo = new CretaceousCombo(borgar);
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
            NavigationService.Navigate(new CustomizeCombo("Prehistoric PB&J"));
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            CretaceousCombo combo = new CretaceousCombo(pbj);
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
            NavigationService.Navigate(new CustomizeCombo("Pterodactyl Wings"));
            PterodactylWings wings = new PterodactylWings();
            CretaceousCombo combo = new CretaceousCombo(wings);
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
            NavigationService.Navigate(new CustomizeCombo("Veloci-Wrap"));
            VelociWrap wrap = new VelociWrap();
            CretaceousCombo combo = new CretaceousCombo(wrap);
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
            NavigationService.Navigate(new CustomizeCombo("T-Rex King Burger"));
            TRexKingBurger borgar = new TRexKingBurger();
            CretaceousCombo combo = new CretaceousCombo(borgar);
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
                order.Add(c.Entree);
                order.Add(c.Side);
                order.Add(c.Drink);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
    }
}
