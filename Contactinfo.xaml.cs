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
using System.Windows.Shapes;

namespace ProjectMarathon
{
    /// <summary>
    /// Логика взаимодействия для ContactInfo.xaml
    /// </summary>
    public partial class ContactInfo : Window
    {
        public ContactInfo()
        {
            InitializeComponent();
            WindowStyle = WindowStyle.None;
            AllowsTransparency = true;
        }

        private void rb_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}