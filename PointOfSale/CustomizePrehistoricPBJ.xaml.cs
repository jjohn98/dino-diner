/// CustomizePrehistoricPBJ.cs
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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        /// <summary>
        /// Private backing variable.
        /// </summary>
        private PrehistoricPBJ pbj = new PrehistoricPBJ();

        /// <summary>
        /// Private backing combo;
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// Constructor which initializes the private backing variable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public CustomizePrehistoricPBJ(PrehistoricPBJ sandwich)
        {
            InitializeComponent();
            this.pbj = sandwich;
        }

        /// <summary>
        /// Constructor which initializes the private backing combo.
        /// </summary>
        /// <param name="c"></param>
        public CustomizePrehistoricPBJ(CretaceousCombo c)
        {
            InitializeComponent();
            this.combo = c;
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldPeanutButterButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.pbj.HoldPeanutButter();
            }
            else
            {
                if (combo.Entree is PrehistoricPBJ sandwich)
                {
                    sandwich.HoldPeanutButter();
                }
            }
        }

        /// <summary>
        /// Holds the specified addition from the entree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldJellyButton_Click(object sender, RoutedEventArgs e)
        {
            if (combo == null)
            {
                this.pbj.HoldJelly();
            }
            else
            {
                if (combo.Entree is PrehistoricPBJ sandwich)
                {
                    sandwich.HoldJelly();
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
            try
            {
                NavigationService.GoBack();
            }
            catch (Exception exception)
            {
                cantGoBack.IsOpen = true;
            }
        }
    }
}
