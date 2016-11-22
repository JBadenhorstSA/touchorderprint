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

namespace TouchOrderPrint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> order = new List<string>();
        int orderNumber = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            order.Insert(0, DateTime.Now.ToShortTimeString());
            order.Insert(1, "Order Number: " + orderNumber.ToString());
            order.Insert(2, "------------------");
            var message = string.Join(Environment.NewLine, order);
            MessageBox.Show(message);
            order.Clear();
            if (orderNumber == 3)
            {
                orderNumber = 0;
            }
            orderNumber++;
        }

        // Paninis Start
        private void btnBaconFetaPanini_Click(object sender, RoutedEventArgs e)
        {
            order.Add("Bacon Feta Panini");
            order.Add("------------------");
        }

        private void btnHamPineapplePanini_Click(object sender, RoutedEventArgs e)
        {
            order.Add("Ham Pineapple Panini");
            order.Add("------------------");
        }

        private void btnGrilledCheesePanani_Click(object sender, RoutedEventArgs e)
        {
            order.Add("Grilled Cheese Panini");
            order.Add("------------------");
        }

        private void btnAvoFetaPanini_Click(object sender, RoutedEventArgs e)
        {
            order.Add("Avo Feta Panini");
            order.Add("------------------");
        }

        private void btnHamCheesePineapplePanini_Click(object sender, RoutedEventArgs e)
        {
            order.Add("Ham, Cheese, Pineapple Panini");
            order.Add("------------------");
        }

        private void btnHamCheeseTomatoPanini_Click(object sender, RoutedEventArgs e)
        {
            order.Add("Ham, Cheese, Tomato Panini");
            order.Add("------------------");
        }

        // Paninis End
        // Burgers Start
        private void btnRibBurger_Click(object sender, RoutedEventArgs e)
        {
            order.Add("Rib Burger");
            order.Add("------------------");
        }

        private void btnSweetChilliChickenBurger_Click(object sender, RoutedEventArgs e)
        {
            order.Add("Sweet Chilli Chicken Burger");
            order.Add("------------------");
        }

        private void btnChickenBurger_Click(object sender, RoutedEventArgs e)
        {
            order.Add("Chicken Burger");
            order.Add("------------------");
        }

        private void btnBaconCheeseBurger_Click(object sender, RoutedEventArgs e)
        {
            order.Add("Bacon and Cheese Burger");
            order.Add("------------------");
        }

        private void btnBaconAvoBurger_Click(object sender, RoutedEventArgs e)
        {
            order.Add("Bacon and Avo Burger");
            order.Add("------------------");
        }

        private void btnPukBurger_Click(object sender, RoutedEventArgs e)
        {
            order.Add("PUK Burger");
            order.Add("------------------");
        }

        private void btnHamburger_Click(object sender, RoutedEventArgs e)
        {
            order.Add("Hamburger");
            order.Add("------------------");
        }

        private void btnCheeseBurger_Click(object sender, RoutedEventArgs e)
        {
            order.Add("Cheese Burger");
            order.Add("------------------");
        }

        private void btnBudgetBurger_Click(object sender, RoutedEventArgs e)
        {
            order.Add("Budget Burger");
            order.Add("------------------");
        }

        private void btnBudgetCheeseBurger_Click(object sender, RoutedEventArgs e)
        {
            order.Add("Budget Cheese Burger");
            order.Add("------------------");
        }
    }
}
