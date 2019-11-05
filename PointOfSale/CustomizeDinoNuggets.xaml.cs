/// CustomizeDinoNuggets.cs
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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        /// <summary>
        /// Private backing variable.
        /// </summary>
        private DinoNuggets nugs;

        /// <summary>
        /// Private backing combo.
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor which initializes the private backing variable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public CustomizeDinoNuggets(DinoNuggets d)
        {
            InitializeComponent();
            this.nugs = d;
        }

        /// <summary>
        /// Constructor which initializes the private backing combo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public CustomizeDinoNuggets(CretaceousCombo c)
        {
            InitializeComponent();
            this.combo = c;
        }

        /// <summary>
        /// Adds a nugget to the selected dino nuggets entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNuggetButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.nugs.AddNugget();
            }
            else
            {
                if (combo.Entree is DinoNuggets nugs)
                {
                    nugs.AddNugget();
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
