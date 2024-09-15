using PP.AppData;
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

namespace PP.Pages
{
    /// <summary>
    /// Логика взаимодействия для forTeachers.xaml
    /// </summary>
    public partial class forTeachers : Page
    {
        public forTeachers()
        {
            InitializeComponent();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Grades5A());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Poisk6A());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Poisk7A());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Poisk5A());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Poisk8A());
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Grades6A());
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Grades7A());
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Grades8A());
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Otchet5A());
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }

        private void SobBTN(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new SobytiyaPage());
        }
    }
}
