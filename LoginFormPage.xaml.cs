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
    /// Логика взаимодействия для LoginFormPage.xaml
    /// </summary>
    public partial class LoginFormPage : Page
    {
        public LoginFormPage()
        {
            InitializeComponent();            
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new MainWindow());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MyFrame.Navigate(new MenuRunnerPage());
        }

        private void MoneyTextBox_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            MoneyTextBlock.Text = "";
            MoneyTextBlock.Text += '$' + MoneyTextBox.Text;
        }
    }
}
