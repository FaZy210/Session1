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
    /// Логика взаимодействия для RedactPage.xaml
    /// </summary>
    public partial class RedactPage : Page
    {
        public RedactPage()
        {
            InitializeComponent();
            colorcmb.ItemsSource = App.db.colors.ToList();
            nametxt.Text = App.choisenknife.Name;
            imagetxt.Text = App.choisenknife.Image;
            colorcmb.SelectedItem = App.choisenknife.color;
        }

        private void savebtn_Click(object sender, RoutedEventArgs e)
        {
            var newname = nametxt.Text as string;
            var newimage = imagetxt.Text as string;
            var newcolor = colorcmb.SelectedItem as color;
            App.choisenknife.Name = nametxt.Text;
            App.choisenknife.Image = imagetxt.Text;
            App.choisenknife.IdColor = newcolor.Id;
            App.db.SaveChanges();
            MessageBox.Show("Нож успешно отредактирован!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new RedactDeletePage());
        }
    }
}
