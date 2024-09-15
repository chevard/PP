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
using Excel = Microsoft.Office.Interop.Excel;


namespace PP.Pages
{
    /// <summary>
    /// Логика взаимодействия для Otchet7A.xaml
    /// </summary>
    public partial class Otchet7A : Page
    {
        public Otchet7A()
        {
            InitializeComponent();
            var markk = ConDB.context.Grades_Class5A.GroupBy(x => x.StudentID).Select(y =>
            new
            {
                StudentID = y.Key,
                FullName = ConDB.context.Students5A.FirstOrDefault(q => q.StudentID == y.Key).FullName,
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
            Nav.MainFrame.Navigate(new Otchet8A());
        }

        private void createOtch_Click_1(object sender, RoutedEventArgs e)
        {
            Excel.Application app = new Excel.Application();
            app.Visible = true;
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Excel.Worksheet sheet = (Excel.Worksheet)workbook.Sheets[1];
            // Устанавливаем заголовки столбцов
            for (int j = 0; j < DG.Columns.Count; j++)
            {
                Excel.Range range = (Excel.Range)sheet.Cells[3, j + 1];
                sheet.Cells[3, j + 1].Font.Bold = true;
                if (j == 1)
                {
                    sheet.Columns[j + 1].ColumnWidth = 50;
                }
                else
                {
                    sheet.Columns[j + 1].ColumnWidth = 15;
                }
                range.Value2 = DG.Columns[j].Header;
            }

            for (int i = 0; i < DG.Items.Count; i++)
            {
                for (int j = 0; j < DG.Columns.Count; j++)
                {
                    TextBlock b = DG.Columns[j].GetCellContent(DG.Items[i]) as TextBlock;
                    if (b != null)
                    {
                        Excel.Range range = (Excel.Range)sheet.Cells[i + 4, j + 1];
                        range.Value2 = b.Text;
                    }
                }
            }

            // Объединение и форматирование ячеек
            Excel.Range _excelCells2 = (Excel.Range)sheet.get_Range("A1", "C1").Cells;
            Excel.Range _excelCells3 = (Excel.Range)sheet.get_Range("A2", "C2").Cells;
            _excelCells2.Merge(Type.Missing);
            _excelCells3.Merge(Type.Missing);
            sheet.Cells[1, 1] = "Средний балл учеников 7А:";
            _excelCells2.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            _excelCells3.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
        }
    }
}