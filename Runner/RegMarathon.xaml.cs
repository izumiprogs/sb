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
    /// Логика взаимодействия для RegMarathon.xaml
    /// </summary>
    public partial class RegMarathon : Page
    {
        int price;
        int fundMoney;
        int id = 0;
        
        public RegMarathon()
        {
            InitializeComponent();
            

            cmb_fund.ItemsSource = new Fund[]
            {
                new Fund {Name = "Фонд Кошечек" }, new Fund {Name = "Фонд Собачек" }, 
            };
            
        }

        public class Fund
        {
            public string Name { get; set; } = "";

            public override string ToString() => $"{Name}";
        } 

        private void btn_reg_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Runner/RegConfirm.xaml", UriKind.Relative));
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void check_min_Checked(object sender, RoutedEventArgs e)
        {
            price += 20;
            txt_price.Text = Convert.ToString(price);
        }

        private void check_half_Checked(object sender, RoutedEventArgs e)
        {
            price += 75;
            txt_price.Text = Convert.ToString(price);

        }

        private void check_full_Checked(object sender, RoutedEventArgs e)
        {
            price += 145;
            txt_price.Text = Convert.ToString(price);
        }

        private void radio_a_Checked(object sender, RoutedEventArgs e)
        {
            price += 0;
            txt_price.Text = Convert.ToString(price);
        }

        private void radio_b_Checked(object sender, RoutedEventArgs e)
        {
            price += 20;
            txt_price.Text = Convert.ToString(price);
        }

        private void radio_c_Checked(object sender, RoutedEventArgs e)
        {
            price += 45;
            txt_price.Text = Convert.ToString(price);
        }

        private void check_full_Unchecked(object sender, RoutedEventArgs e)
        {
            price -= 145;
            txt_price.Text = Convert.ToString(price);
        }

        private void check_half_Unchecked(object sender, RoutedEventArgs e)
        {
            price -= 75;
            txt_price.Text = Convert.ToString(price);
        }

        private void check_min_Unchecked(object sender, RoutedEventArgs e)
        {
            price -= 20;
            txt_price.Text = Convert.ToString(price);
        }

        private void radio_a_Unchecked(object sender, RoutedEventArgs e)
        {
            price -= 0;
            txt_price.Text = Convert.ToString(price);
        }

        private void radio_b_Unchecked(object sender, RoutedEventArgs e)
        {
            price -= 20;
            txt_price.Text = Convert.ToString(price);
        }

        private void radio_c_Unchecked(object sender, RoutedEventArgs e)
        {
            price -= 45;
            txt_price.Text = Convert.ToString(price);
        }

    }
}
