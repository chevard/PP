﻿using PP.AppData;
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
    /// Логика взаимодействия для A6.xaml
    /// </summary>
    public partial class A6 : Page
    {
        public A6()
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
            Nav.MainFrame.Navigate(new A6Add(DG.SelectedItem as Students6A));
        }

        private void dobavlenie_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new A6Add(null));
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {

            var delStudents = DG.SelectedItems.Cast<Students6A>().ToList();
            ConDB.context.Students6A.RemoveRange(delStudents);
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
            var vivod = DG.ItemsSource = ConDB.context.Students6A.ToList(); //вывод в листвью из созданной бд

        }
    }
}
