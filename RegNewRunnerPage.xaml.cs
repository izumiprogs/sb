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
using Microsoft.Win32;
using System.Timers;
using System.Windows.Threading;

namespace ProjectMarathon
{
    /// <summary>
    /// Логика взаимодействия для RegNewRunnerPage.xaml
    /// </summary>
    public partial class RegNewRunnerPage : Page
    {
        public RegNewRunnerPage()
        {
            InitializeComponent();
        }

        private void ConfirmNewRunnerButton(object sender, RoutedEventArgs e)
        {
            if (TextBoxEmail.Text.Length >= 5 && password.Password.Length >= 6 && password_copy.Password.Length >= 6
                && TextBoxName.Text.Length >= 2 && TextBoxSurname.Text.Length >= 3)
            {
                bool en = true;
                bool symbol = false;
                bool number = false;

                for (int i = 0; i < password.Password.Length; i++)
                {
                    if ((password.Password[i] >= 'А' && password.Password[i] <= 'Я') || (password.Password[i] >= 'а' && password.Password[i] <= 'я'))
                        en = false;
                    if (char.IsDigit(password.Password[i]))
                        number = true;
                    if (password.Password[i] == '_' || password.Password[i] == '-' || password.Password[i] == '!')
                        symbol = true;
                }
                if (!en)
                {
                    MessageBox.Show("Доступна только английская раскладка");
                }
                else if (!symbol)
                {
                    MessageBox.Show("Добавьте один из следующих символов: _ - !");
                }
                else if (!number)
                {
                    MessageBox.Show("Добавьте хотя бы одну цифру");
                }
                if (en && symbol && number)
                {
                    Confirm.IsEnabled = true;
                    NavigationPage.Navigate(new ConfirmNewRunnerPage());
                }
                else
                {
                    Confirm.IsEnabled = false; // Добавлено для деактивации кнопки, если не все условия выполнены
                }
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные. Пароль должен быть не менее 6 символов, адрес электронной почты - не менее 5 символов, а имя и фамилия должны иметь соответствующую длину.");
                Confirm.IsEnabled = false; // Деактивация кнопки в случае невыполнения условий
            }
            // Создание таймера для включения кнопки через 5 секунд
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += (s, ev) =>
            {
                Confirm.IsEnabled = true;
                timer.Stop(); // Остановка таймера
            };
            timer.Start(); // Запуск таймера
        }

        private void SelectImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.gif)|*.jpg;*.png;*.gif|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string selectedFileName = openFileDialog.FileName;
                imgPreview.Source = new BitmapImage(new Uri(selectedFileName));
                TextBoxFile.Text = System.IO.Path.GetFileName(selectedFileName);
            }
        }

        private void CancelBtn(object sender, RoutedEventArgs e)
        {
            NavigationPage.Navigate(new RunnerPage());
        }
    }
}
