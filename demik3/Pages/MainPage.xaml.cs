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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ListButton_Click(object sender, RoutedEventArgs e)
        {
            SecondaryFrame.Content = new ListPage();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void RedactDeletePageButton_Click(object sender, RoutedEventArgs e)
        {
            SecondaryFrame.Content = new RedactDeletePage();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            SecondaryFrame.Content = new AddPage();
        }

        private void cartButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
