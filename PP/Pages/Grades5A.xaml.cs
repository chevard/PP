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
    /// Логика взаимодействия для Grades5A.xaml
    /// </summary>
    public partial class Grades5A : Page
    {
        public Grades5A()
        {
            InitializeComponent();
            UpdateDB();
        }

        private void DG_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItems.Count > 1 && DG.SelectedItems.Count != 5)
            {
                MessageBox.Show($"Вы выделили {DG.SelectedItems.Count.ToString()} записи. Нужно выделить лишь 1.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (DG.SelectedItems.Count >= 5)
            {
                MessageBox.Show($"Вы выделили {DG.SelectedItems.Count.ToString()} записей! Нужно выделить лишь 1.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (DG.SelectedItems.Count == 0)
            {
                MessageBox.Show("Ничего не выделено.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Nav.MainFrame.Navigate(new Grades5AAdd(DG.SelectedItem as Grades_Class5A));
        }

        private void dobavlenie_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Grades5AAdd(null));
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {

            var delStudents = DG.SelectedItems.Cast<Grades_Class5A>().ToList();
            ConDB.context.Grades_Class5A.RemoveRange(delStudents);
            try
            {
                ConDB.context.SaveChanges();
                UpdateDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.GoBack();
        }
     
            void UpdateDB()
            {
            var filtr = ConDB.context.Grades_Class5A.ToList();
            switch (SortCMB.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    filtr = filtr.Where(x => x.Subjects5A.SubjectName == "Русский язык").ToList(); break;
                case 2:
                    filtr = filtr.Where(x => x.Subjects5A.SubjectName == "Математика").ToList(); break;
                case 3:
                    filtr = filtr.Where(x => x.Subjects5A.SubjectName == "Практическая работа по русскому языку").ToList();
                    break;
                case 4:
                    filtr = filtr.Where(x => x.Subjects5A.SubjectName == "Литература").ToList();
                    break;
                case 5:
                    filtr = filtr.Where(x => x.Subjects5A.SubjectName == "История").ToList();
                    break;
                case 6:
                    filtr = filtr.Where(x => x.Subjects5A.SubjectName == "Иностранный язык").ToList();
                    break;
                case 7:
                    filtr = filtr.Where(x => x.Subjects5A.SubjectName == "Физическая культура").ToList();
                    break;
                case 8:
                    filtr = filtr.Where(x => x.Subjects5A.SubjectName == "Биология").ToList();
                    break;
                case 9:
                    filtr = filtr.Where(x => x.Subjects5A.SubjectName == "Изобразительное искусство").ToList();
                    break;
                case 10:
                    filtr = filtr.Where(x => x.Subjects5A.SubjectName == "Технология").ToList();
                    break;
                case 11:
                    filtr = filtr.Where(x => x.Subjects5A.SubjectName == "География").ToList();
                    break;
                case 12:
                    filtr = filtr.Where(x => x.Subjects5A.SubjectName == "Музыка").ToList();
                    break;
                case 13:
                    filtr = filtr.Where(x => x.Subjects5A.SubjectName == "ОДНКНР").ToList();
                    break;
            }
            DG.ItemsSource = filtr;

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDB();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var vivod = ConDB.context.Grades_Class5A.ToList();
            vivod = vivod.Where(x => x.Students5A.FullName.ToLower().Contains(TB.Text.ToLower())).ToList();

            DG.ItemsSource = vivod;
        }
    }
}
