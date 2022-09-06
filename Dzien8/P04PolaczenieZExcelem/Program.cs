using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P04PolaczenieZExcelem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application excel = new Application();
            Workbook wb = excel.Workbooks.Open("");
            Worksheet ws = wb.ActiveSheet;

            string s = ws.Cells[1, 2].Value.ToString();
        }
    }
}
