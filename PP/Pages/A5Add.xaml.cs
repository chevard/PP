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
    /// Логика взаимодействия для A5Add.xaml
    /// </summary>
    public partial class A5Add : Page

    {
        Students5A Student;
        bool checkNew;
        public A5Add(Students5A s)
        {
            InitializeComponent();
            if (s == null)
            {
                s = new Students5A();
                checkNew = true;

            }
            else
                checkNew = false;
            DataContext = Student = s;
        }

        private void nazad_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }

        private void dobavit_Click(object sender, RoutedEventArgs e)
        {
            if (checkNew)
            {
                ConDB.context.Students5A.Add(Student);
            }
            try
            {
                ConDB.context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            Nav.MainFrame.GoBack();
        }
    }
}
