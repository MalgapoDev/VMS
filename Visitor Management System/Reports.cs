using ComponentFactory.Krypton.Toolkit;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visitor_Management_System
{
    public partial class Reports : KryptonForm
    {
        private DataTable table;
        public Reports()
        {
            InitializeComponent();
            LoadDataIntoGridView();

            txt_reportSearch.TextChanged += txt_reportSearch_TextChanged;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            string[] departments = { "All", "IT", "Accounting", "Engineering", "HR" }; // list of departments

            foreach (string dept in departments)
            {
                comboBox_Department.Items.Add(dept);
            }

            string[] filters = { "Daily", "Weekly", "Monthly", "Quarterly", "Yearly" };
            foreach (string filter in filters)
            {
                dateFilter_comboBox.Items.Add(filter);
            }
        }

        // sample data for report
        private void LoadDataIntoGridView()
        {
            table = new DataTable();
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

            dataGrid_ReportTable.DataSource = table;
        }

        // download reports button for excel format
        private void downloadReport_CSV_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
            saveFileDialog.Title = "Export Data to CSV";
            saveFileDialog.FileName = DateTime.Now.ToString("MM-dd-yyyy") + " Visitor Log Report";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                DataTable filteredData = ApplyFilters();
                ExportToCSV(filePath, filteredData);
            }
        }

        // download reports button for PDF format
        private void downloadReport_PDF_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF file (*.pdf)|*.pdf";
            saveFileDialog.Title = "Export Data to PDF";
            saveFileDialog.FileName = DateTime.Now.ToString("MM-dd-yyyy") + " Visitor Log Report";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                DataTable filteredData = ApplyFilters();
                ExportToPDF(filePath, filteredData);
            }
        }

        private DataTable ApplyFilters()
        {
            string selectedDepartment = comboBox_Department.SelectedItem?.ToString();
            string selectedDateFilter = dateFilter_comboBox.SelectedItem?.ToString();
            DateTime today = DateTime.Today;

            DataTable filteredData = table.Clone();

            foreach (DataRow row in table.Rows)
            {
                // If "All" is selected, match all departments
                bool matchesDepartment = selectedDepartment == "All" || string.IsNullOrWhiteSpace(selectedDepartment) || row["Department"].ToString() == selectedDepartment;

                DateTime date = Convert.ToDateTime(row["Date"]);
                bool matchesDateFilter = false;

                switch (selectedDateFilter)
                {
                    case "Daily":
                        matchesDateFilter = date.Date == today;
                        break;
                    case "Weekly":
                        matchesDateFilter = date >= today.AddDays(-7) && date <= today;
                        break;
                    case "Monthly":
                        matchesDateFilter = date >= today.AddMonths(-1) && date <= today;
                        break;
                    case "Quarterly":
                        int currentQuarter = (today.Month - 1) / 3 + 1;
                        int rowQuarter = (date.Month - 1) / 3 + 1;
                        matchesDateFilter = date.Year == today.Year && rowQuarter == currentQuarter;
                        break;
                    case "Yearly":
                        matchesDateFilter = date.Year == today.Year;
                        break;
                    default:
                        matchesDateFilter = true; // No date filter selected
                        break;
                }

                if (matchesDepartment && matchesDateFilter)
                {
                    filteredData.ImportRow(row);
                }
            }

            return filteredData;
        }

        private void ExportToCSV(string filePath, DataTable filteredData)
        {
            StringBuilder csvContent = new StringBuilder();

            foreach (DataColumn column in filteredData.Columns)
            {
                csvContent.Append(column.ColumnName + ",");
            }
            csvContent.AppendLine();

            foreach (DataRow row in filteredData.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    csvContent.Append(item?.ToString() + ",");
                }
                csvContent.AppendLine();
            }

            File.WriteAllText(filePath, csvContent.ToString());
            MessageBox.Show("Data exported successfully to CSV!", "Export Complete", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void ExportToPDF(string filePath, DataTable filteredData)
        {
            Document pdfDoc = new Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));

            pdfDoc.Open();

            Paragraph title = new Paragraph("VISITOR MANAGEMENT SYSTEM HISTORY REPORT", FontFactory.GetFont("Arial", 20));
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 12;
            pdfDoc.Add(title);

            PdfPTable pdfTable = new PdfPTable(filteredData.Columns.Count);

            foreach (DataColumn column in filteredData.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                cell.BackgroundColor = BaseColor.CYAN;
                pdfTable.AddCell(cell);
            }

            foreach (DataRow row in filteredData.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    pdfTable.AddCell(item?.ToString());
                }
            }

            pdfDoc.Add(pdfTable);
            pdfDoc.Close();
            writer.Close();

            MessageBox.Show("Data exported successfully to PDF!", "Export Complete", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // textbox with search function by name 
        private void txt_reportSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txt_reportSearch.Text;

            if (string.IsNullOrWhiteSpace(filterText))
            {
                dataGrid_ReportTable.DataSource = table;
            }
            else
            {
                DataView filteredView = new DataView(table);
                filteredView.RowFilter = $"Name LIKE '%{filterText}%'";
                dataGrid_ReportTable.DataSource = filteredView;
            }
        }

        private void comboBox_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGrid_ReportTable.DataSource = ApplyFilters();
        }

        private void dateFilter_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGrid_ReportTable.DataSource = ApplyFilters();
        }
    }
}
