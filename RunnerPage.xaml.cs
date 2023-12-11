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
    /// Логика взаимодействия для RunnerPage.xaml
    /// </summary>
    public partial class RunnerPage : Page
    {
        public RunnerPage()
        {
            InitializeComponent();
        }

        private void RegNewRunnerButton(object sender, RoutedEventArgs e)
        {
            Navigation.Navigate(new RegNewRunnerPage());
        }

        private void AuthBtn(object sender, RoutedEventArgs e)
        {
            Navigation.Navigate(new AuthorizationRunnerPage());
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            Navigation.Navigate(new MainWindow());
        }

        private void AuthFormBtn(object sender, RoutedEventArgs e)
        {
            Navigation.Navigate(new AuthorizationRunnerPage());
        }
    }
}
