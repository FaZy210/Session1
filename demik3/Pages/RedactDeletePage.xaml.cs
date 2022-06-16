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
    /// Логика взаимодействия для RedactDeletePage.xaml
    /// </summary>
    public partial class RedactDeletePage : Page
    {
        public RedactDeletePage()
        {
            InitializeComponent();
            listknives.ItemsSource = App.db.knives.ToList();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var deletedknife = listknives.SelectedItem as knife;
                if (deletedknife == null)
                {
                    MessageBox.Show("Сначала выберите нож!", "Упс", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if (MessageBox.Show("Вы действительно хотите удалить нож?!", "Удаление ножа", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        App.db.knives.Remove(deletedknife);
                        App.db.SaveChanges();
                        MessageBox.Show("Нож успешно удален!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                        NavigationService.Navigate(new RedactDeletePage());
                    }
                    else
                    {

                    }
                    
                }

            }
            catch
            {
                MessageBox.Show("Что-то не так!", "Упс", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void RedactButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (listknives.SelectedItem == null)
                {
                    MessageBox.Show("Сначала выберите нож!", "Упс", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    App.choisenknife = listknives.SelectedItem as knife;
                    NavigationService.Navigate(new RedactPage());
                }
            }
            catch
            {
               
            }
        }
    }
    
}
