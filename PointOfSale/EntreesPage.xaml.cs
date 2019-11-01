/// EntreesPage.xaml.cs
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
    /// Interaction logic for EntreesPage.xaml
    /// </summary>
    public partial class EntreesPage : Page
    {
        /// <summary>
        /// Constructs a new page
        /// </summary>
        public EntreesPage()
        {
            InitializeComponent();
        }

        public EntreesPage(Entree e)
        {
            InitializeComponent();
            entree = e;
        }

        /// <summary>
        /// Private Backing Variable for the entree selected.
        /// </summary>
        private Entree entree;

        /// <summary>
        /// Adds the specified entree to the order.
        /// </summary>
        /// <param name="s"></param>
        private void SelectEntree(Entree e)
        {
            if (DataContext is Order order)
            {
                order.Add(e);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        /// <summary>
        /// Adds the specified entree to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Brontowurst_Click(object sender, RoutedEventArgs e)
        {
            Brontowurst brat = new Brontowurst();
            SelectEntree(brat);
            NavigationService.Navigate(new CustomizeBrontowurst(brat));
        }

        /// <summary>
        /// Adds the specified entree to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DinoNuggets_Click(object sender, RoutedEventArgs e)
        {
            DinoNuggets nugs = new DinoNuggets();
            SelectEntree(nugs);
            NavigationService.Navigate(new CustomizeDinoNuggets(nugs));
        }

        /// <summary>
        /// Adds the specified entree to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Steakosaurus_Click(object sender, RoutedEventArgs e)
        {
            SteakosaurusBurger borgar = new SteakosaurusBurger();
            SelectEntree(borgar);
            NavigationService.Navigate(new CustomizeSteakosaurusBurger(borgar));
        }

        /// <summary>
        /// Adds the specified entree to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrehistoricPBJ_Click(object sender, RoutedEventArgs e)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            SelectEntree(pbj);
            NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
        }

        /// <summary>
        /// Adds the specified entree to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PterodactylWings_Click(object sender, RoutedEventArgs e)
        {
            PterodactylWings wings = new PterodactylWings();
            SelectEntree(wings);
            NavigationService.Navigate(new CustomizePterodactylWings(wings));
        }

        /// <summary>
        /// Adds the specified entree to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VelociWrap_Click(object sender, RoutedEventArgs e)
        {
            VelociWrap wrap = new VelociWrap();
            SelectEntree(wrap);
            NavigationService.Navigate(new CustomizeVelociwrap(wrap));
        }

        /// <summary>
        /// Adds the specified entree to the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TRexKingBurger_Click(object sender, RoutedEventArgs e)
        {
            TRexKingBurger borgar = new TRexKingBurger();
            SelectEntree(borgar);
            NavigationService.Navigate(new CustomizeTRexKingBurger(borgar));
        }
    }
}
