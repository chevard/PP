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
    /// Логика взаимодействия для Poisk8A.xaml
    /// </summary>
    public partial class Poisk8A : Page
    {
        public Poisk8A()
        {
            InitializeComponent();
            UpdateDG();
        }
        void UpdateDG()
        {
            var vivod = ConDB.context.Grades_Class8A.ToList();
            vivod = vivod.Where(x => x.Students8A.FullName.ToLower().Contains(TBpoisk.Text.ToLower())).ToList();

            DG.ItemsSource = vivod;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateDG();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }

        private void DG_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateDG();
        }

    }
}
