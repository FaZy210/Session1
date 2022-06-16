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

namespace demik3
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();

        }

        private void JoinButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var loga = (from loge in App.db.clients where logtxt.Text == loge.Login && pastxt.Text == loge.Password select loge).Count();
                if (loga == 0)
                {
                    MessageBox.Show("Такого пользователя не существует!", "Упс", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (loga ==1 && kaptchatxt.Text == "F7RU4")
                {
                    MessageBox.Show("Успешный вход!", "Ура", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.Navigate(new MainPage());
                }
                else if (kaptchatxt.Text != "F7RU4")
                {
                    MessageBox.Show("Неправильно введена капча!", "Упс", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                MessageBox.Show("Что-то не так", "Упс", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RegistrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
