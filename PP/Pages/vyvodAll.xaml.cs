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
    /// Логика взаимодействия для vyvodAll.xaml
    /// </summary>
    public partial class vyvodAll : Page
    {
        public vyvodAll()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new A5());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new A6());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new A7());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new A8());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new ClassTeachersPage());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new _5ASubjects());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new _6ASubjects());
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new _7ASubjects());
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new _8ASubjects());
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Grades5A());
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

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }
    }
}
