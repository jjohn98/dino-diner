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
        private PrehistoricPBJ pbj = new PrehistoricPBJ();

        public CustomizePrehistoricPBJ()
        {
            InitializeComponent();
        }

        public CustomizePrehistoricPBJ(PrehistoricPBJ sandwich)
        {
            InitializeComponent();
            this.pbj = sandwich;
        }

        private void HoldPeanutButterButton_Click(object sender, RoutedEventArgs e)
        {
            this.pbj.HoldPeanutButter();
        }

        private void HoldJellyButton_Click(object sender, RoutedEventArgs e)
        {
            this.pbj.HoldJelly();
        }

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
