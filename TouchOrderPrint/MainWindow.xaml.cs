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

        private async void btnHamburger_Click(object sender, RoutedEventArgs e)
        {
            btnHamburger.IsEnabled = false;
            order.Add("Hamburger");
            order.Add("------------------");
            await Task.Delay(1000);
            btnHamburger.IsEnabled = true;
        }

        private async void btnRibBurger_Click(object sender, RoutedEventArgs e)
        {
            btnRibBurger.IsEnabled = false;
            order.Add("Rib Burger");
            order.Add("------------------");
            await Task.Delay(1000);
            btnRibBurger.IsEnabled = true;
        }

        private async void btnCheeseBurger_Click(object sender, RoutedEventArgs e)
        {
            btnCheeseBurger.IsEnabled = false;
            order.Add("Cheese Burger");
            order.Add("------------------");
            await Task.Delay(1000);
            btnCheeseBurger.IsEnabled = true;
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

        private async void btnSweetChilliChickenBurger_Click(object sender, RoutedEventArgs e)
        {
            btnSweetChilliChickenBurger.IsEnabled = false;
            order.Add("Sweet Chilli and Cheese Chicken Burger");
            order.Add("------------------");
            await Task.Delay(1000);
            btnSweetChilliChickenBurger.IsEnabled = true;
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
        // Burgers End

        // Pitas Start
        private async void btnBreakfastPita_Click(object sender, RoutedEventArgs e)
        {
            btnBreakfastPita.IsEnabled = false;
            order.Add("Breakfast Pita");
            order.Add("------------------");
            await Task.Delay(1000);
            btnBreakfastPita.IsEnabled = true;
        }

        private async void btnRibCheesePita_Click(object sender, RoutedEventArgs e)
        {
            btnRibCheesePita.IsEnabled = false;
            order.Add("Rib and Cheese Pita");
            order.Add("------------------");
            await Task.Delay(1000);
            btnRibCheesePita.IsEnabled = true;
        }

        private async void btnChickenPita_Click(object sender, RoutedEventArgs e)
        {
            btnChickenPita.IsEnabled = false;
            order.Add("Chicken Pita");
            order.Add("------------------");
            await Task.Delay(1000);
            btnChickenPita.IsEnabled = true;
        }

        private async void btnMeatyHawaiianPita_Click(object sender, RoutedEventArgs e)
        {
            btnMeatyHawaiianPita.IsEnabled = false;
            order.Add("Meaty Hawaiian Pita");
            order.Add("------------------");
            await Task.Delay(1000);
            btnMeatyHawaiianPita.IsEnabled = true;
        }
        // Pitas End

        // Wraps Start
        private async void btnChickenWrap_Click(object sender, RoutedEventArgs e)
        {
            btnChickenWrap.IsEnabled = false;
            order.Add("Chicken Wrap");
            order.Add("------------------");
            await Task.Delay(1000);
            btnChickenWrap.IsEnabled = true;
        }

        private async void btnHawaiianWrap_Click(object sender, RoutedEventArgs e)
        {
            btnHawaiianWrap.IsEnabled = false;
            order.Add("Hawaiian Wrap");
            order.Add("------------------");
            await Task.Delay(1000);
            btnHawaiianWrap.IsEnabled = true;
        }
        // Wraps End

        // Paninis Start
        private async void btnBaconFetaAvoPanini_Click(object sender, RoutedEventArgs e)
        {
            btnBaconFetaAvoPanini.IsEnabled = false;
            order.Add("Bacon, Feta and Avo Panini");
            order.Add("------------------");
            await Task.Delay(1000);
            btnBaconFetaAvoPanini.IsEnabled = true;
        }

        private async void btnCheeseHamPineapplePanini_Click(object sender, RoutedEventArgs e)
        {
            btnCheeseHamPineapplePanini.IsEnabled = false;
            order.Add("Cheese, Ham and Pineapple Panini");
            order.Add("------------------");
            await Task.Delay(1000);
            btnCheeseHamPineapplePanini.IsEnabled = true;
        }

        private async void btnGrilledCheesePanini_Click(object sender, RoutedEventArgs e)
        {
            btnGrilledCheesePanini.IsEnabled = false;
            order.Add("Grilled Cheese Panini");
            order.Add("------------------");
            await Task.Delay(1000);
            btnGrilledCheesePanini.IsEnabled = true;
        }

        private async void btnGrilledAvoFetaPanini_Click(object sender, RoutedEventArgs e)
        {
            btnGrilledAvoFetaPanini.IsEnabled = false;
            order.Add("Grilled Avo and Feta Panini");
            order.Add("------------------");
            await Task.Delay(1000);
            btnGrilledAvoFetaPanini.IsEnabled = true;
        }
        // Paninis End

        // Extras Start
        private async void btnExtraTomato_Click(object sender, RoutedEventArgs e)
        {
            btnExtraTomato.IsEnabled = false;
            order.Add("Extra Tomato");
            order.Add("------------------");
            await Task.Delay(1000);
            btnExtraTomato.IsEnabled = true;
        }

        private async void btnExtraFriedOnions_Click(object sender, RoutedEventArgs e)
        {
            btnExtraFriedOnions.IsEnabled = false;
            order.Add("Extra Fried Onions");
            order.Add("------------------");
            await Task.Delay(1000);
            btnExtraFriedOnions.IsEnabled = true;
        }

        private async void btnExtraEgg_Click(object sender, RoutedEventArgs e)
        {
            btnExtraEgg.IsEnabled = false;
            order.Add("Extra Egg");
            order.Add("------------------");
            await Task.Delay(1000);
            btnExtraEgg.IsEnabled = true;
        }

        private async void btnExtraCheese_Click(object sender, RoutedEventArgs e)
        {
            btnExtraCheese.IsEnabled = false;
            order.Add("Extra Cheese");
            order.Add("------------------");
            await Task.Delay(1000);
            btnExtraCheese.IsEnabled = true;
        }

        private async void btnExtraAvo_Click(object sender, RoutedEventArgs e)
        {
            btnExtraAvo.IsEnabled = false;
            order.Add("Extra Avo");
            order.Add("------------------");
            await Task.Delay(1000);
            btnExtraAvo.IsEnabled = true;
        }

        private async void btnExtraFeta_Click(object sender, RoutedEventArgs e)
        {
            btnExtraFeta.IsEnabled = false;
            order.Add("Extra Feta");
            order.Add("------------------");
            await Task.Delay(1000);
            btnExtraFeta.IsEnabled = true;
        }

        private async void btnExtraBacon_Click(object sender, RoutedEventArgs e)
        {
            btnExtraBacon.IsEnabled = false;
            order.Add("Extra Bacon");
            order.Add("------------------");
            await Task.Delay(1000);
            btnExtraBacon.IsEnabled = true;
        }
        // Extras End
    }
}
