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
using PP.Pages;
using PP.AppData;

namespace PP.Pages
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

        private void vvod_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new vyvodAll());  
        }

        private void vyborka_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Filtr());
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Poisk5A());
        }

        private void vichislenia_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Vychislenia5A());
        }

        private void otchety_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Otchet5A());
        }

        private void vyhod_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
