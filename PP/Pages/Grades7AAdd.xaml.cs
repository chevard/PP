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
    /// Логика взаимодействия для Grades7AAdd.xaml
    /// </summary>
    public partial class Grades7AAdd : Page
    {
    

            Grades_Class7A Grade;
            bool checkNew;
            public Grades7AAdd(Grades_Class7A s)
            {
                InitializeComponent();
                if (s == null)
                {
                    s = new Grades_Class7A();
                    checkNew = true;
                }
                else
                    checkNew = false;
                DataContext = Grade = s;
            }

            private void nazad_Click(object sender, RoutedEventArgs e)
            {
                Nav.MainFrame.GoBack();
            }

            private void dobavit_Click(object sender, RoutedEventArgs e)
            {
                if (checkNew)
                {
                    ConDB.context.Grades_Class7A.Add(Grade);
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
