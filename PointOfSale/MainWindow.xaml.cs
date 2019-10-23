/// MainWindow.xaml.cs
/// Author: Nathan Bean
/// Modified by: Jack Johnson
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructs a new main window.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            Order order = new Order();

            DataContext = order;
        }

        private void PassDataContextToPage()
        {
            if (OrderUI.Content is Page page)
            {
                page.DataContext = OrderUI.DataContext;
            }
        }

        private void OrderUI_LoadCompleted(object sender, NavigationEventArgs e)
        {
            PassDataContextToPage();
        }

        private void OrderUI_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            PassDataContextToPage();
        }
    }
}
