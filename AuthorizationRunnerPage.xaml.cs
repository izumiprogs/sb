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
    /// Логика взаимодействия для AuthorizationRunnerPage.xaml
    /// </summary>
    public partial class AuthorizationRunnerPage : Page
    {
        
        public AuthorizationRunnerPage()
        {
            InitializeComponent();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Navigation.Navigate(new RunnerPage());
        }

        private void Confirm(object sender, RoutedEventArgs e)
        {
            //Navigation.Navigate(new MenuRunnerPage());
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            Navigation.Navigate(new MainWindow());
        }
    }
}
