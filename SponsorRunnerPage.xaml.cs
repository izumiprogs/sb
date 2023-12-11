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

namespace ProjectMarathon
{
    /// <summary>
    /// Логика взаимодействия для SponsorRunnerPage.xaml
    /// </summary>
    public partial class SponsorRunnerPage : Page
    {
        public int money = 0;        
        public SponsorRunnerPage()
        {
            InitializeComponent();
            MoneyTextBox.Text += $"${money}";
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            //Navigation.Navigate(new MainWindow());
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            if(money > 0 && money - 10 >= 0)
            {
                MoneyTextBox.Clear();
                money -= 10;
                MoneyTextBox.Text += $"${money}";
            }
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            MoneyTextBox.Clear();
            money += 10;
            MoneyTextBox.Text += $"${money}";
        }

        private void GiveMoneyButton_Click(object sender, RoutedEventArgs e)
        {
            Navigation.Navigate(new AcceptSponsorPage());
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            //Navigation.Navigate(new MainWindow());
        }
    }
}
