using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data;
using System.Windows.Forms;
using Visitor_Management_System.Methods;

namespace Visitor_Management_System
{
    public partial class Reports : KryptonForm
    {
        private DataTable table;
        private string currentDateFilter = "";
        public Reports()
        {
            InitializeComponent();
            table = ReportandHistoryMethod.LoadDataIntoGridView();
            dataGrid_ReportTable.DataSource = table;

            txt_reportSearch.TextChanged += txt_reportSearch_TextChanged;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            string[] departments = { "All", "IT", "Accounting", "Engineering", "HR" };
            comboBox_Department.Items.AddRange(departments);

            dataGrid_ReportTable.AllowUserToAddRows = false;
        }

        private void downloadReport_CSV_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV file (*.csv)|*.csv",
                Title = "Export Data to CSV",
                FileName = DateTime.Now.ToString("MM-dd-yyyy") + " Visitor Log Report"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataTable filteredData = ReportandHistoryMethod.ApplyFilters(
                    table,
                    comboBox_Department.SelectedItem?.ToString(),
                    currentDateFilter 
                );
                ReportandHistoryMethod.ExportToCSV(saveFileDialog.FileName, filteredData);
            }
        }

        private void downloadReport_PDF_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF file (*.pdf)|*.pdf",
                Title = "Export Data to PDF",
                FileName = DateTime.Now.ToString("MM-dd-yyyy") + " Visitor Log Report"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataTable filteredData = ReportandHistoryMethod.ApplyFilters(
                    table,
                    comboBox_Department.SelectedItem?.ToString(),
                    currentDateFilter 
                );
                ReportandHistoryMethod.ExportToPDF(saveFileDialog.FileName, filteredData);
            }
        }

        private void txt_reportSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txt_reportSearch.Text;
            dataGrid_ReportTable.DataSource = ReportandHistoryMethod.FilterByName(table, filterText);
        }

        private void comboBox_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGrid_ReportTable.DataSource = ReportandHistoryMethod.ApplyFilters(
                table,
                comboBox_Department.SelectedItem?.ToString(),
                currentDateFilter
            );
        }

        private void btn_Daily_Click(object sender, EventArgs e)
        {
            currentDateFilter = "Daily";
            ApplyCurrentFilters();
        }

        private void btn_Weekly_Click(object sender, EventArgs e)
        {
            currentDateFilter = "Weekly";
            ApplyCurrentFilters();
        }

        private void btn_Monthly_Click(object sender, EventArgs e)
        {
            currentDateFilter = "Monthly";
            ApplyCurrentFilters();
        }

        private void btn_Quarterly_Click(object sender, EventArgs e)
        {
            currentDateFilter = "Quarterly";
            ApplyCurrentFilters();
        }

        private void btn_Yearly_Click(object sender, EventArgs e)
        {
            currentDateFilter = "Yearly";
            ApplyCurrentFilters();
        }

        private void ApplyCurrentFilters()
        {
            dataGrid_ReportTable.DataSource = ReportandHistoryMethod.ApplyFilters(
                table,
                comboBox_Department.SelectedItem?.ToString(),
                currentDateFilter
            );
        }
    }
}
