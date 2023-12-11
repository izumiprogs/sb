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

namespace MarathonSkills.Runner
{
    /// <summary>
    /// Логика взаимодействия для RunnerMenu.xaml
    /// </summary>
    public partial class RunnerMenu : Page
    {
        
       
        public RunnerMenu()
        {
            InitializeComponent();
            
        }

        private void btn_regmarathon_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Runner/RegMarathon.xaml", UriKind.Relative));
        }

        private void btn_myresult_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btn_editprofile_Click(object sender, RoutedEventArgs e)
        {
            
        }

        

        private void btn_contact_Click(object sender, RoutedEventArgs e)
        {
            ContactCoordinator cc = new ContactCoordinator();
            cc.Show();
        }

        private void btn_my_sponsor_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
