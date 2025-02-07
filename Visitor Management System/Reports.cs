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

        public Reports()
        {
            InitializeComponent();
            table = ReportandHistory.LoadDataIntoGridView();
            dataGrid_ReportTable.DataSource = table;

            txt_reportSearch.TextChanged += txt_reportSearch_TextChanged;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            string[] departments = { "All", "IT", "Accounting", "Engineering", "HR" };
            comboBox_Department.Items.AddRange(departments);

            string[] filters = { "Daily", "Weekly", "Monthly", "Quarterly", "Yearly" };
            dateFilter_comboBox.Items.AddRange(filters);
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
                DataTable filteredData = ReportandHistory.ApplyFilters(table, comboBox_Department.SelectedItem?.ToString(), dateFilter_comboBox.SelectedItem?.ToString());
                ReportandHistory.ExportToCSV(saveFileDialog.FileName, filteredData);
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
                DataTable filteredData = ReportandHistory.ApplyFilters(table, comboBox_Department.SelectedItem?.ToString(), dateFilter_comboBox.SelectedItem?.ToString());
                ReportandHistory.ExportToPDF(saveFileDialog.FileName, filteredData);
            }
        }

        private void txt_reportSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txt_reportSearch.Text;
            dataGrid_ReportTable.DataSource = ReportandHistory.FilterByName(table, filterText);
        }

        private void comboBox_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGrid_ReportTable.DataSource = ReportandHistory.ApplyFilters(table, comboBox_Department.SelectedItem?.ToString(), dateFilter_comboBox.SelectedItem?.ToString());
        }

        private void dateFilter_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGrid_ReportTable.DataSource = ReportandHistory.ApplyFilters(table, comboBox_Department.SelectedItem?.ToString(), dateFilter_comboBox.SelectedItem?.ToString());
        }
    }
}
