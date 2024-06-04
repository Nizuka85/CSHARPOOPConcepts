using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PersonalTracking
{
    public class ExporToExcel
    {
        internal static void ExcelExport(DataGridView dataGridView1)
        {
            //This Only Works if you have the excell isntalled and reference the correct interop dll in the csproj
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible= true;
            worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Sheets["Sheet1"];
            worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.ActiveSheet;
            for (int i = 1; i < dataGridView1.Columns.Count+1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i-1].HeaderText;
            }
            for (int i =0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i+2, j+1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            //workbook.SaveAs("C:\\ourexcel.xlsx");
            //workbook.Close();
        }
    }
}
