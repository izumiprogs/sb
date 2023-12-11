using System;
using System.Collections.Generic;
using System.Data;
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
using MarathonSkills;

namespace MarathonSkills.Runner
{
    /// <summary>
    /// Логика взаимодействия для AuthRunner.xaml
    /// </summary>
    public partial class AuthRunner : Page
    {
        
        public AuthRunner()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ChoicePage.xaml", UriKind.Relative));
        }

        private void btn_Reg_Click(object sender, RoutedEventArgs e)
        {
            
            this.NavigationService.Navigate(new Uri("Runner/RunnerMenu.xaml", UriKind.Relative));

        }

        private void txb_email_GotFocus(object sender, RoutedEventArgs e)
        {
            txb_email.Text = "";
        }
    }
}
