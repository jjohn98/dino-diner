/// DrinksPage.xaml.cs
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
    /// Interaction logic for DrinksPage.xaml
    /// </summary>
    public partial class DrinksPage : Page
    {
        /// <summary>
        /// Initializes a new drinks page with all secondary options disabled.
        /// </summary>
        public DrinksPage()
        {
            InitializeComponent();
            FlavorButton.IsEnabled = false;
            IceButton.IsEnabled = false;
            LemonButton.IsEnabled = false;
            DecafButton.IsEnabled = false;
            SweetButton.IsEnabled = false;
        }

        /// <summary>
        /// Initializes a new drinks page with all secondary options disabled.
        /// </summary>
        public DrinksPage(Drink d)
        {
            InitializeComponent();
            drink = d;
            if (drink is Tyrannotea tea)
            {
                FlavorButton.IsEnabled = false;
                IceButton.IsEnabled = true;
                LemonButton.IsEnabled = true;
                DecafButton.IsEnabled = false;
                SweetButton.IsEnabled = true;
            }
            else if (drink is Sodasaurus soda)
            {
                FlavorButton.IsEnabled = true;
                IceButton.IsEnabled = true;
                LemonButton.IsEnabled = false;
                DecafButton.IsEnabled = false;
                SweetButton.IsEnabled = false;
            }
            else if (drink is Water w)
            {
                FlavorButton.IsEnabled = false;
                IceButton.IsEnabled = true;
                LemonButton.IsEnabled = true;
                DecafButton.IsEnabled = false;
                SweetButton.IsEnabled = false;
            }
            else if (drink is JurassicJava java)
            {
                FlavorButton.IsEnabled = false;
                IceButton.IsEnabled = true;
                LemonButton.IsEnabled = false;
                DecafButton.IsEnabled = true;
                SweetButton.IsEnabled = false;
            }
        }

        /// <summary>
        /// Private backing variable for the currently selected drink.
        /// </summary>
        private Drink drink;

        /// <summary>
        /// Adds the appropriate drink to the order.
        /// </summary>
        /// <param name="s"></param>
        private void SelectDrink(Drink d)
        {
            if (DataContext is Order order)
            {
                order.Add(d);
            }
        }

        /// <summary>
        /// Sets the currently seelcted item's size to small.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Small_Click(object sender, RoutedEventArgs e)
        {
            drink.Size = DinoDiner.Menu.Size.Small;
        }

        /// <summary>
        /// Sets the currently selected item's size to medium.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            drink.Size = DinoDiner.Menu.Size.Medium;
        }

        /// <summary>
        /// Sets the currently seelcted item's size to large.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Large_Click(object sender, RoutedEventArgs e)
        {
            drink.Size = DinoDiner.Menu.Size.Large;
        }

        /// <summary>
        /// Enables secondary options specific to this drink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sodasaurus_Click(object sender, RoutedEventArgs e)
        {
            FlavorButton.IsEnabled = true;
            IceButton.IsEnabled = true;
            LemonButton.IsEnabled = false;
            DecafButton.IsEnabled = false;
            SweetButton.IsEnabled = false;
            SelectDrink(new Sodasaurus());
        }

        /// <summary>
        /// Enables secondary options specific to this drink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tyrannotea_Click(object sender, RoutedEventArgs e)
        {
            FlavorButton.IsEnabled = false;
            IceButton.IsEnabled = true;
            LemonButton.IsEnabled = true;
            DecafButton.IsEnabled = false;
            SweetButton.IsEnabled = true;
            SelectDrink(new Tyrannotea());
        }

        /// <summary>
        /// Enables secondary options specific to this drink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Jurassicjava_Click(object sender, RoutedEventArgs e)
        {
            FlavorButton.IsEnabled = false;
            IceButton.IsEnabled = true;
            LemonButton.IsEnabled = false;
            DecafButton.IsEnabled = true;
            SweetButton.IsEnabled = false;
            SelectDrink(new JurassicJava());
        }

        /// <summary>
        /// Enables secondary options specific to this drink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Water_Click(object sender, RoutedEventArgs e)
        {
            FlavorButton.IsEnabled = false;
            IceButton.IsEnabled = true;
            LemonButton.IsEnabled = true;
            DecafButton.IsEnabled = false;
            SweetButton.IsEnabled = false;
            SelectDrink(new Water());
        }

        /// <summary>
        /// Takes the user to the customize flavor page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Flavor_Click(object sender, RoutedEventArgs e)
        {
            if (drink is Sodasaurus soda)
            {
                NavigationService.Navigate(new CustomizeFlavor(soda));
            }
        }

        /// <summary>
        /// Adds decaf to the currently selected JurassicJava.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Decaf_Click(object sender, RoutedEventArgs e)
        {
            if (drink is JurassicJava java)
            {
                java.Decaf = true;
            }
        }

        /// <summary>
        /// Adds Sweetener to the currently selected Tyrannotea.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sweet_Click(object sender, RoutedEventArgs e)
        {
            if (drink is Tyrannotea tea)
            {
                    tea.AddSugar();

            }
        }

        /// <summary>
        /// Holds ice from the drink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldIce_Click(object sender, RoutedEventArgs e)
        {
            if (drink is Tyrannotea tea)
            {
                tea.HoldIce();
            }
            else if (drink is Water w)
            {
                w.HoldIce();
            }
            else if (drink is Sodasaurus soda)
            {
                soda.HoldIce();
            }
            else if (drink is JurassicJava java)
            {
                java.AddIce();
            }
        }

        /// <summary>
        /// Holds ice from the currently selected drink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IceButton_Click(object sender, RoutedEventArgs e)
        {
            if (drink != null)
            {
                drink.HoldIce();
            }

        }

        /// <summary>
        /// Adds lemon the the currently selected tea or water.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LemonButton_Click(object sender, RoutedEventArgs e)
        {
            if (drink is Water w)
            {
                    w.AddLemon();
                
            }
            else if (drink is Tyrannotea tea)
            {
                    tea.AddLemon();
            }
        }

        /// <summary>
        /// Return the user to the main page after finishing the current drink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
