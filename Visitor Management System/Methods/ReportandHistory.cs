using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;

namespace Visitor_Management_System.Methods
{
    internal class ReportandHistory
    {
        public static DataTable LoadDataIntoGridView()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Company", typeof(string));
            table.Columns.Add("Department", typeof(string));
            table.Columns.Add("Person to Visit", typeof(string));
            table.Columns.Add("Purpose", typeof(string));
            table.Columns.Add("ID Presented", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Time - In", typeof(string));
            table.Columns.Add("Time - Out", typeof(string));
            table.Columns.Add("ID", typeof(int));

            table.Rows.Add("Rj Canlas", "ABC Company", "IT", "John Doe", "Contract Signing", "Phil ID", DateTime.Now.Date, "11:00 AM", "1:00 PM", 1);
            table.Rows.Add("Carl James Dolorito", "ABC Company", "HR", "Angeles Tablante", "Meeting", "Passport", new DateTime(2025, 2, 3), "10:00 AM", "2:00 PM", 2);
            table.Rows.Add("Michael Malgapo", "ABC Company", "IT", "Angeles Tablante", "Discussion", "Passport", new DateTime(2025, 3, 15), "11:00 AM", "1:00 PM", 3);
            table.Rows.Add("Josh Santuico", "ABC Company", "IT", "Angeles Tablante", "Meetng", "Passport", new DateTime(2025, 1, 23), "11:00 AM", "1:00 PM", 4);
            table.Rows.Add("Harry Mariano", "ABC Company", "Accounting", "Trixia Meneses", "Budget Checking", "Passport", new DateTime(2025, 4, 20), "11:00 AM", "1:00 PM", 5);

            return table;
        }

        public static DataTable ApplyFilters(DataTable table, string departmentFilter, string dateFilter)
        {
            string filterExpression = "";

            if (!string.IsNullOrEmpty(departmentFilter) && departmentFilter != "All")
            {
                filterExpression += $"Department = '{departmentFilter}'";
            }

            if (!string.IsNullOrEmpty(dateFilter))
            {
                DateTime currentDate = DateTime.Today;
                DateTime startDate = currentDate;
                switch (dateFilter)
                {
                    case "Daily":
                        startDate = currentDate;
                        break;
                    case "Weekly":
                        startDate = currentDate.AddDays(-7);
                        break;
                    case "Monthly":
                        startDate = currentDate.AddMonths(-1);
                        break;
                    case "Quarterly":
                        startDate = currentDate.AddMonths(-3);
                        break;
                    case "Yearly":
                        startDate = currentDate.AddYears(-1);
                        break;
                    default:
                        startDate = currentDate;
                        break;
                }


                if (!string.IsNullOrEmpty(filterExpression)) filterExpression += " AND ";
                filterExpression += $"Date >= #{startDate:MM/dd/yyyy}#";
            }

            DataRow[] filteredRows = table.Select(filterExpression);
            DataTable filteredTable = table.Clone();

            foreach (DataRow row in filteredRows)
            {
                filteredTable.ImportRow(row);
            }

            return filteredTable;
        }

        public static DataTable FilterByName(DataTable table, string nameFilter)
        {
            if (string.IsNullOrEmpty(nameFilter)) return table;

            DataView dv = new DataView(table)
            {
                RowFilter = $"Name LIKE '%{nameFilter}%'"
            };

            return dv.ToTable();
        }

        public static void ExportToCSV(string filePath, DataTable table)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string[] columnNames = new string[table.Columns.Count];
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    columnNames[i] = table.Columns[i].ColumnName;
                }
                writer.WriteLine(string.Join(",", columnNames));

                foreach (DataRow row in table.Rows)
                {
                    string[] fields = row.ItemArray.Select(field => field.ToString()).ToArray();
                    writer.WriteLine(string.Join(",", fields));
                }
            }

            MessageBox.Show("Data exported to CSV successfully.");
        }

        public static void ExportToPDF(string filePath, DataTable table)
        {
            Document pdfDoc = new Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));

            pdfDoc.Open();

            Paragraph title = new Paragraph("VISITOR MANAGEMENT SYSTEM HISTORY REPORT", FontFactory.GetFont("Arial", 20));
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 12;
            pdfDoc.Add(title);

            PdfPTable pdfTable = new PdfPTable(table.Columns.Count);
            foreach (DataColumn column in table.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                cell.BackgroundColor = BaseColor.CYAN;
                pdfTable.AddCell(cell);
            }

            foreach (DataRow row in table.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    pdfTable.AddCell(item?.ToString());
                }
            }

            pdfDoc.Add(pdfTable);
            pdfDoc.Close();
            writer.Close();


            MessageBox.Show("Data exported to PDF successfully.");
        }
    }
}
