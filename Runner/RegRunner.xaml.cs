using Microsoft.Win32;
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
using MarathonSkills;

namespace MarathonSkills.Runner
{
    /// <summary>
    /// Логика взаимодействия для RegRunner.xaml
    /// </summary>
    public partial class RegRunner : Page
    {
        
        public RegRunner()
        {
            InitializeComponent();
            cmb_gender.ItemsSource = new Gender[]
            {
                 new Gender {Name = "Male"},
                 new Gender {Name = "Female"}
            };

            cmbCountry.ItemsSource = new Country[]
            {
                new Country {Name = "Andora" }, new Country {Name = "Argentina" }, new Country {Name = "Australia" },new Country {Name = "Austria" },new Country {Name = "China" },new Country {Name = "Brazil" },new Country {Name = "USA" },new Country {Name = "Russia" },new Country {Name = "Canada" },new Country {Name = "Chile" },new Country {Name = "Germany" },new Country { Name = "China" },new Country { Name = "Chinese Taipei" },new Country { Name = "Colombia" },new Country { Name = "Croatia" },new Country { Name = "Czech Republic" },new Country { Name = "Denmark" },new Country { Name = "Dominican Republic" },new Country { Name = "Ecuador" },new Country { Name = "Egypt" },new Country { Name = "El Salvador" },new Country { Name = "Equatorial Guinea" },new Country { Name = "Esonia" },new Country { Name = "Finland" },new Country { Name = "France" },new Country { Name = "Germany" },new Country { Name = "Greece" },new Country { Name = "Guatemala" },new Country { Name = "Guinea" },new Country { Name = "Guinea-Bissau" },new Country { Name = "Honduras" },new Country { Name = "Hong Kong" },new Country { Name = "Hungary" },new Country { Name = "India" },new Country { Name = "Indonesia" },new Country { Name = "Ireland" },new Country { Name = "Israel" },new Country { Name = "Ivory Coast" },new Country { Name = "Jamaica" },new Country { Name = "Japan" },new Country { Name = "Jordan" },new Country { Name = "Kenya" },new Country { Name = "Latvia" }, new Country { Name = "Liechtenstein" },new Country { Name = "Lithuania" },new Country { Name = "Luxemburg" }, new Country { Name = "Macau" }, new Country { Name = "Macedonia" }, new Country { Name = "Madagascar" }, new Country { Name = "Malaysia" }, new Country { Name = "Mali" }, new Country { Name = "Malta" }, new Country { Name = "Mauritius" }, new Country { Name = "Mexico" }, new Country { Name = "Moldova" }, new Country { Name = "Monaco" }, new Country { Name = "Montenegro" }, new Country { Name = "Netherlands" }, new Country { Name = "New Zealand" }, new Country { Name = "Nicaragua" }, new Country { Name = "Niger" }, new Country { Name = "Norway" }, new Country { Name = "Panama" }, new Country { Name = "Paraguay" }, new Country { Name = "Peru" }, new Country { Name = "Philippines" }, new Country { Name = "Poland" }, new Country { Name = "Portugal" }, new Country { Name = "Puerto Rico" }, new Country { Name = "Qatar" }, new Country { Name = "Romania" }, new Country { Name = "Saudi Arabia" }, new Country { Name = "Senegal" }, new Country { Name = "Singapore" },new Country { Name = "Slovakia" }, new Country { Name = "South Africa" }, new Country { Name = "South Korea" }, new Country { Name = "Spain" }, new Country { Name = "Sweden" }, new Country { Name = "Switzerland" }, new Country { Name = "Thailand" }, new Country { Name = "Turkey" }, new Country { Name = "Unitied Arab Emirates" }, new Country { Name = "Inited Kingdom" }, new Country { Name = "Uruguay" }, new Country { Name = "Vatican" }, new Country { Name = "Venezuela" }, new Country { Name = "Vietnam" }
            };          
        }
        public class Gender 
        {
            public string Name { get; set; } = "";
            
            public override string ToString() => $"{Name}";
        }

        public class Country
        {
            public string Name { get; set; } = "";

            public override string ToString() => $"{Name}";
        }

        

        private void btn_Reg_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Runner/AuthRunner.xaml", UriKind.Relative));
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Runner/AuthRegRunner.xaml", UriKind.Relative));
        }

        private void txb_email_GotFocus(object sender, RoutedEventArgs e)
        {
            txb_email.Text = "";
        }

        private void txb_pass_GotFocus(object sender, RoutedEventArgs e)
        {
            txb_pass.Text = "";
        }

        private void txb_repeatpass_GotFocus(object sender, RoutedEventArgs e)
        {
            txb_repeatpass.Text = "";
        }

        private void txb_name_GotFocus(object sender, RoutedEventArgs e)
        {
            txb_name.Text = "";
        }

        private void txb_surname_GotFocus(object sender, RoutedEventArgs e)
        {
            txb_surname.Text = "";
        }

        
    }
}
