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
    /// Логика взаимодействия для ConfirmNewRunnerPage.xaml
    /// </summary>
    public partial class ConfirmNewRunnerPage : Page
    {
        public ConfirmNewRunnerPage()
        {
            InitializeComponent();
        }

        private void MenuRunnerButton(object sender, RoutedEventArgs e)
        {
            //NavigationPage.Navigate(new MenuRunnerPage());
        }

        private void Logout(object sender, RoutedEventArgs e)
        {
            NavigationPage.Navigate(new MainWindow());
        }
    }
}
