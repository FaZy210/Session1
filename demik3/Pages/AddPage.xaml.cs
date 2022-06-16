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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
            colorcmb.ItemsSource = App.db.colors.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            var newcolor = colorcmb.SelectedItem as color;
            knife knife1 = new knife
            {
                Name = nametxt.Text,
                Image = imagetxt.Text,
                IdColor = newcolor.Id
               
            };
            App.db.knives.Add(knife1);
            App.db.SaveChanges();
            MessageBox.Show("Нож добавлен!");
            NavigationService.Navigate(new AddPage());
        }
    }
}
