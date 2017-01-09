using System;
using System.Collections.Generic;
using System.Windows;
using System.Drawing.Printing;
using System.Drawing;
using System.Threading.Tasks;

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
            order.Insert(0, "------------------");
            order.Insert(1, DateTime.Now.ToShortTimeString());
            order.Insert(2, "Order Number: " + orderNumber.ToString());
            order.Insert(3, "------------------");

            order.Add(".");
            order.Add(".");
            order.Add(".");
            order.Add(".");

            var message = string.Join(Environment.NewLine, order);
            order.Clear();

            if (orderNumber == 999)
            {
                orderNumber = 0;
            }
            orderNumber++;

            PrintDocument p = new PrintDocument();
            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(message, new Font("Arial", 16), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
            };
            try
            {
                p.PrinterSettings.PrinterName = "Kitchen";
                p.Print();

                p.PrinterSettings.PrinterName = "Counter";
                p.Print();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }
        }

        // Burgers Start
        private async void btnRibBurger_Click(object sender, RoutedEventArgs e)
        {
            btnRibBurger.IsEnabled = false;
            order.Add("Rib Burger");
            order.Add("------------------");
            await Task.Delay(1000);
            btnRibBurger.IsEnabled = true;
        }

        private async void btnSweetChilliChickenBurger_Click(object sender, RoutedEventArgs e)
        {
            btnSweetChilliChickenBurger.IsEnabled = false;
            order.Add("Sweet Chilli Chicken Burger");
            order.Add("------------------");
            await Task.Delay(1000);
            btnSweetChilliChickenBurger.IsEnabled = true;
        }

        private async void btnChickenBurger_Click(object sender, RoutedEventArgs e)
        {
            btnChickenBurger.IsEnabled = false;
            order.Add("Chicken Burger");
            order.Add("------------------");
            await Task.Delay(1000);
            btnChickenBurger.IsEnabled = true;
        }

        private async void btnBaconCheeseBurger_Click(object sender, RoutedEventArgs e)
        {
            btnBaconCheeseBurger.IsEnabled = false;
            order.Add("Bacon and Cheese Burger");
            order.Add("------------------");
            await Task.Delay(1000);
            btnBaconCheeseBurger.IsEnabled = true;
        }

        private async void btnBaconAvoBurger_Click(object sender, RoutedEventArgs e)
        {
            btnBaconAvoBurger.IsEnabled = false;
            order.Add("Bacon and Avo Burger");
            order.Add("------------------");
            await Task.Delay(1000);
            btnBaconAvoBurger.IsEnabled = true;
        }

        private async void btnPukBurger_Click(object sender, RoutedEventArgs e)
        {
            btnPukBurger.IsEnabled = false;
            order.Add("PUK Burger");
            order.Add("------------------");
            await Task.Delay(1000);
            btnPukBurger.IsEnabled = true;
        }

        private async void btnHamburger_Click(object sender, RoutedEventArgs e)
        {
            btnHamburger.IsEnabled = false;
            order.Add("Hamburger");
            order.Add("------------------");
            await Task.Delay(1000);
            btnHamburger.IsEnabled = true;
        }

        private async void btnCheeseBurger_Click(object sender, RoutedEventArgs e)
        {
            btnCheeseBurger.IsEnabled = false;
            order.Add("Cheese Burger");
            order.Add("------------------");
            await Task.Delay(1000);
            btnCheeseBurger.IsEnabled = true;
        }

        private async void btnBudgetBurger_Click(object sender, RoutedEventArgs e)
        {
            btnBudgetBurger.IsEnabled = false;
            order.Add("Budget Burger");
            order.Add("------------------");
            await Task.Delay(1000);
            btnBudgetBurger.IsEnabled = true;
        }

        private async void btnBudgetCheeseBurger_Click(object sender, RoutedEventArgs e)
        {
            btnBudgetCheeseBurger.IsEnabled = false;
            order.Add("Budget Cheese Burger");
            order.Add("------------------");
            await Task.Delay(1000);
            btnBudgetCheeseBurger.IsEnabled = true;
        }
    }
}
