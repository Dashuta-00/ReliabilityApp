using Microsoft.Office.Interop.Excel;
using System;
using System.Data.Common;
using Excel = Microsoft.Office.Interop.Excel;

namespace НадёжностьЭлементов
{
    public class ExcelReader
    {
        private Excel.Application excelApplication = new Excel.Application();
        private Excel.Workbook workbook;
        private Excel.Worksheet worksheet;

        private const string filePath = @"D:\Надежность\Книга1.xlsx";

        public void Open()
        {
            workbook = excelApplication.Workbooks.Open(filePath);
            worksheet = (Excel.Worksheet)workbook.ActiveSheet;
            excelApplication.Visible = true;
        }

        public void SearchRow(string type, ref int row)
        {
            for (int i = 1; i <= 24; i++)
            {

                //Excel.Range value = ((Excel.Worksheet)excelApplication.ActiveSheet).Cells[i, 1] as Excel.Range;
                //table[i - 1, j - 1] = (int)value.Value

                if (type == Convert.ToString(worksheet.Cells[i, 1].Value2))
                {
                    row = i; break;
                }
            }
            // return (string)worksheet.Cells[row, column].Value2;

        }
    }
}
