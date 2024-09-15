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
    /// Логика взаимодействия для Vychislenia6A.xaml
    /// </summary>
    public partial class Vychislenia6A : Page
    {
        public Vychislenia6A()
        {
            InitializeComponent();
            var markk = ConDB.context.Grades_Class6A.GroupBy(x => x.StudentID).Select(y =>
            new
            {
                StudentID = y.Key,
                FullName = ConDB.context.Students6A.FirstOrDefault(q => q.StudentID == y.Key).FullName,
                Average = Math.Round(y.Average(o => o.Grade), 2)
            }).ToList();
            DG.ItemsSource = markk;
        }


        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }

        private void DG_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Vychislenia7A());
        }
    }
}
