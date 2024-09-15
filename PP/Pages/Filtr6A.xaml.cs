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
    /// Логика взаимодействия для Filtr6A.xaml
    /// </summary>
    public partial class Filtr6A : Page
    {
        public Filtr6A()
        {
            InitializeComponent();
            Update();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Update();
        }
        private void DG_Loaded(object sender, RoutedEventArgs e)
        {
            Update();
        }

        void Update()
        {
            var filtr = ConDB.context.Grades_Class6A.ToList();
            switch (SortCMB.SelectedIndex)
            {

                case 1:
                    filtr = filtr.Where(x => x.Grade == 5).ToList(); break;
                case 2:
                    filtr = filtr.Where(x => x.Grade == 4).ToList(); break;
                case 3:
                    filtr = filtr.Where(x => x.Grade == 3).ToList();
                    break;
            }
            DG.ItemsSource = filtr;
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Filtr7A());
        }
    }
}
