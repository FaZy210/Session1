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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void JoinButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var rega = (from regi in App.db.clients where regi.Login == logtxt.Text select regi).Count();
                if (logtxt.Text == "")
                {
                    MessageBox.Show("Логин не может быть пустым", "Упс", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (logtxt.Text.Length < 8)
                {
                    MessageBox.Show("Логин не может содержать менее 8 символов", "Упс", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (logtxt.Text.Length > 20)
                {
                    MessageBox.Show("Логин не может содержать более 20 символов", "Упс", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (pastxt.Text == "")
                {
                    MessageBox.Show("Пароль не может быть пустым", "Упс", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (pastxt.Text.Length < 8)
                {
                    MessageBox.Show("Пароль не может содержать менее 8 символов", "Упс", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (pastxt.Text.Length > 20)
                {
                    MessageBox.Show("Пароль не может содержать более 20 символов", "Упс", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else if (rega == 0)
                {
                    client client1 = new client
                    {
                        Login = logtxt.Text,
                        Password = pastxt.Text,
                        roleId = 1

                    };
                    App.db.clients.Add(client1);
                    App.db.SaveChanges();
                    MessageBox.Show("Пользователь успешно добавлен!", "Успех!", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.Navigate(new MainPage());
                }
                else
                {
                    MessageBox.Show("Такой пользователь уже есть!", "Упс", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                MessageBox.Show("Что-то не так", "Упс", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RegistrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LoginPage());
        }
    }
}
