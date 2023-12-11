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
    /// Логика взаимодействия для MySponsorPage.xaml
    /// </summary>
    public partial class MySponsorPage : Page
    {
        public MySponsorPage()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MyFrame.Navigate(new NewMainWindow());
        }   
       
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            //MyFrame.Navigate(new MenuRunnerPage());
        }

        
    }
}
