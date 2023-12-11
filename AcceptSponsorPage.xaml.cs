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
    /// Логика взаимодействия для AcceptSponsorPage.xaml
    /// </summary>
    public partial class AcceptSponsorPage : Page
    {
        SponsorRunnerPage sponsor = new SponsorRunnerPage();
        public AcceptSponsorPage()
        {
            InitializeComponent();
            MoneyTextBlock.Text += sponsor.MoneyTextBox.Text;
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SponsorRunnerPage());
        }
    }
}
