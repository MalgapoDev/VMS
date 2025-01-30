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
            string[] departments = { "IT", "Accounting", "Engineering", "HR" }; // list of departments

            foreach (string dept in departments)
            {
                comboBox_Department.Items.Add(dept);
            }

            // set date format/value into current date.
            DatePicker_reportDate.Format = DateTimePickerFormat.Custom;
            DatePicker_reportDate.CustomFormat = "MM/dd/yyyy";
            DatePicker_reportDate.Value = DateTime.Now;
        }

        // sample data for report
        private void LoadDataIntoGridView()
        {
            table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Company", typeof(string));
            table.Columns.Add("Person to Visit", typeof(string));
            table.Columns.Add("Purpose", typeof(string));
            table.Columns.Add("ID Presented", typeof(string));
            table.Columns.Add("Time - In", typeof(string));
            table.Columns.Add("Time - Out", typeof(string));
            table.Columns.Add("ID", typeof(int));

            table.Rows.Add("Rj Canlas", "ABC Company", "John Doe", "Contract Signing", "Phil ID", "11:00 AM", "1:00 PM", 1);
            table.Rows.Add("Dolorito", "ABC Company", "Angeles Tablante", "Miss the HR", "Passport", "10:00 AM", "2:00 PM", 2);

            dataGrid_ReportTable.DataSource = table;
        }

        // download reports button for excel format
        private void downloadReport_CSV_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV file (*.csv)|*.csv";
            saveFileDialog.Title = "Export Data to CSV";
            saveFileDialog.FileName = DateTime.Now.ToString("dd/MM/yy") + " Visitor Log - Report";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToCSV(filePath);
            }
        }

        // download reports button for PDF format
        private void downloadReport_PDF_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF file (*.pdf)|*.pdf";
            saveFileDialog.Title = "Export Data to PDF";
            saveFileDialog.FileName = DateTime.Now.ToString("dd/MM/yy") + " Visitor Log - Report";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToPDF(filePath);
            }
        }
        private void ExportToCSV(string filePath)
        {
            StringBuilder csvContent = new StringBuilder();

            for (int i = 0; i < dataGrid_ReportTable.Columns.Count; i++)
            {
                csvContent.Append(dataGrid_ReportTable.Columns[i].HeaderText + ",");
            }
            csvContent.AppendLine();

            foreach (DataGridViewRow row in dataGrid_ReportTable.Rows)
            {
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < dataGrid_ReportTable.Columns.Count; i++)
                    {
                        csvContent.Append(row.Cells[i].Value?.ToString() + ",");
                    }
                    csvContent.AppendLine();
                }
            }

            File.WriteAllText(filePath, csvContent.ToString());
            MessageBox.Show("Data exported successfully to CSV!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportToPDF(string filePath)
        {
            Document pdfDoc = new Document(PageSize.A2);
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));

            pdfDoc.Open();

            Paragraph title = new Paragraph("VISITOR MANAGEMENT SYSTEM HISTORY REPORT", FontFactory.GetFont("Arial", 20));
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 20;
            pdfDoc.Add(title);

            PdfPTable pdfTable = new PdfPTable(dataGrid_ReportTable.Columns.Count);

            foreach (DataGridViewColumn column in dataGrid_ReportTable.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = BaseColor.CYAN;
                pdfTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in dataGrid_ReportTable.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value?.ToString());
                    }
                }
            }

            pdfDoc.Add(pdfTable);
            pdfDoc.Close();
            writer.Close();

            MessageBox.Show("Data exported successfully to PDF!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string selectedDepartment = comboBox_Department.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(selectedDepartment) || selectedDepartment == "All")
            {
                dataGrid_ReportTable.DataSource = table;
            }
            else
            {
                DataView filteredView = new DataView(table);
                filteredView.RowFilter = $"Department = '{selectedDepartment}'";
                dataGrid_ReportTable.DataSource = filteredView;
            }
        }
    }
}
