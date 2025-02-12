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
using MySql.Data.MySqlClient;

namespace Visitor_Management_System.Methods
{
    internal class ReportandHistoryMethod
    {
        public static DataTable LoadDataIntoGridView()
        {
            /*DataTable table = new DataTable();
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
            table.Rows.Add("Carl James Dolorito", "ABC Company", "HR", "Angeles Tablante", "Meeting", "Passport", new DateTime(2025, 2, 14), "10:00 AM", "2:00 PM", 2);
            table.Rows.Add("Michael Malgapo", "ABC Company", "IT", "Angeles Tablante", "Discussion", "Passport", new DateTime(2025, 2, 15), "11:00 AM", "1:00 PM", 3);
            table.Rows.Add("Josh Santuico", "ABC Company", "IT", "Angeles Tablante", "Meetng", "Passport", new DateTime(2025, 1, 23), "11:00 AM", "1:00 PM", 4);
            table.Rows.Add("Harry Mariano", "ABC Company", "Accounting", "Trixia Meneses", "Budget Checking", "Passport", new DateTime(2025, 4, 20), "11:00 AM", "1:00 PM", 5);

            return table;*/

            DataTable table = new DataTable();
            string mySqlCon = "server=127.0.0.1; user=root; database=vms_database; password=";
            try
            {

                MySqlConnection mysql = new MySqlConnection(mySqlCon);
                mysql.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT Id, FirstName, LastName, MiddleInitial, Suffix, Email, ContactNumber, DateofBirth," +
                    " Address, ContactPerson, IDPresented, Room, Department, Date, TimeIn, TimeOut, Purpose, CardNumber FROM addvisitor WHERE TimeOut != 0", mysql);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                table = new DataTable();
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reports: {ex.Message}");
            }

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
                DateTime currentDate = DateTime.Now.Date;
                DateTime startDate = DateTime.Today;
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
            Document pdfDoc = new Document(PageSize.LEGAL.Rotate(), 30f,30f,30f,30f); // 36f = 0.5 inch margins
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
            pdfDoc.Open();

            Font titleFont = FontFactory.GetFont("Arial", 20, Font.BOLD);
            Paragraph title = new Paragraph("VISITOR MANAGEMENT SYSTEM REPORT", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 20f;
            pdfDoc.Add(title);

            Font timestampFont = FontFactory.GetFont("Arial", 10, Font.ITALIC);
            Paragraph timestamp = new Paragraph($"Generated on: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", timestampFont);
            timestamp.Alignment = Element.ALIGN_RIGHT;
            timestamp.SpacingAfter = 20f;
            pdfDoc.Add(timestamp);

            PdfPTable pdfTable = new PdfPTable(table.Columns.Count);
            pdfTable.WidthPercentage = 100; 
            pdfTable.SpacingBefore = 10f;
            pdfTable.SpacingAfter = 10f;

            float[] columnWidths = new float[table.Columns.Count];
            for (int i = 0; i < table.Columns.Count; i++)
            {
                string columnName = table.Columns[i].ColumnName;
                if (columnName.Contains("Date") || columnName.Contains("Time"))
                    columnWidths[i] = 2f;
                else if (columnName.Length <= 3) 
                    columnWidths[i] = 1f;
                else
                    columnWidths[i] = 3f;
            }
            pdfTable.SetWidths(columnWidths);

            Font headerFont = FontFactory.GetFont("Arial", 6, Font.BOLD);
            foreach (DataColumn column in table.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName, headerFont));
                cell.BackgroundColor = new BaseColor(210, 240, 247); 
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                cell.Padding = 5f;
                cell.MinimumHeight = 25f;
                pdfTable.AddCell(cell);
            }

            Font contentFont = FontFactory.GetFont("Arial", 7);
            foreach (DataRow row in table.Rows)
            {
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    string columnName = table.Columns[i].ColumnName;
                    PdfPCell cell = new PdfPCell();
                    cell.Padding = 5f;
                    cell.MinimumHeight = 20f;

                    // Format different types of data
                    if (columnName.Contains("Date"))
                    {
                        if (DateTime.TryParse(row[i].ToString(), out DateTime dateValue))
                            cell.Phrase = new Phrase(dateValue.ToString("dd/MM/yyyy"), contentFont);
                        else
                            cell.Phrase = new Phrase(row[i]?.ToString() ?? "", contentFont);
                    }
                    else if (columnName.Contains("Time"))
                    {
                        if (DateTime.TryParse(row[i].ToString(), out DateTime timeValue))
                            cell.Phrase = new Phrase(timeValue.ToString("HH:mm"), contentFont);
                        else
                            cell.Phrase = new Phrase(row[i]?.ToString() ?? "", contentFont);
                    }
                    else
                    {
                        cell.Phrase = new Phrase(row[i]?.ToString() ?? "", contentFont);
                    }

                    // Alternate row colors for better readability
                    if (pdfTable.Rows.Count % 2 == 1)
                        cell.BackgroundColor = new BaseColor(245, 245, 245);

                    // Align numbers to right, text to left
                    if (row[i] is int || row[i] is decimal || row[i] is double)
                        cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    else
                        cell.HorizontalAlignment = Element.ALIGN_LEFT;

                    pdfTable.AddCell(cell);
                }
            }

            pdfDoc.Add(pdfTable);

            //PAGE NUMBER
            int pageCount = writer.PageNumber;
            Font footerFont = FontFactory.GetFont("Arial", 8);
            Paragraph footer = new Paragraph($"Page {pageCount}", footerFont);
            footer.Alignment = Element.ALIGN_CENTER;
            pdfDoc.Add(footer);

            pdfDoc.Close();
            writer.Close();

            MessageBox.Show("Data exported to PDF successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}