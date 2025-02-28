using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Visitor_Management_System.Methods;
using MySql.Data.MySqlClient;

namespace Visitor_Management_System
{
    public partial class Reports : KryptonForm
    {
        // Connection string for MySQL database
        private string mySqlCon = "server=127.0.0.1; user=root; database=vms_database; password=";
        private DataTable table;
        private string currentDateFilter = "";
        public Reports()
        {
            InitializeComponent();
            table = ReportandHistoryMethod.LoadDataIntoGridView();
            dataGrid_ReportTable.DataSource = table;

            txt_reportSearch.TextChanged += txt_reportSearch_TextChanged;
        }

        // Event triggered when the form loads
        private void Reports_Load(object sender, EventArgs e)
        {
            string[] departments = { "All", "IT", "Accounting", "Engineering", "HR" };
            comboBox_Department.Items.AddRange(departments);

            dataGrid_ReportTable.AllowUserToAddRows = false;

            loadReport();
        }

        // Event triggered when the "Download CSV" button is clicked
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

        // Event triggered when the "Download PDF" button is clicked
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

        // Event triggered when the user types in the search box
        private void txt_reportSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txt_reportSearch.Text;
            dataGrid_ReportTable.DataSource = ReportandHistoryMethod.FilterByName(table, filterText);
        }

        // Event triggered when the department dropdown selection changes
        private void comboBox_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGrid_ReportTable.DataSource = ReportandHistoryMethod.ApplyFilters(
                table,
                comboBox_Department.SelectedItem?.ToString(),
                currentDateFilter
            );
        }

        // Event handlers for date filter buttons
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

        // Applies the current filters (department + date) to the DataGridView
        private void ApplyCurrentFilters()
        {
            dataGrid_ReportTable.DataSource = ReportandHistoryMethod.ApplyFilters(
                table,
                comboBox_Department.SelectedItem?.ToString(),
                currentDateFilter
            );
        }

        // Configures the report DataGridView, adding a button column if necessary
        private void loadReport()
        {
            if (!dataGrid_ReportTable.Columns.Contains("ViewImage"))
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
                {
                    Name = "ViewImage",
                    HeaderText = "VisitorImage",
                    Text = "View",
                    UseColumnTextForButtonValue = true
                };
                dataGrid_ReportTable.Columns.Add(buttonColumn);

                dataGrid_ReportTable.RowTemplate.Height = 30;
                dataGrid_ReportTable.AllowUserToAddRows = false;
            }
        }

        // Event triggered when a button inside the DataGridView is clicked
        private void dataGrid_ReportTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGrid_ReportTable.Columns["ViewImage"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGrid_ReportTable.Rows[e.RowIndex];
                string visitorID = row.Cells["visitorID"].Value.ToString();

                try
                {
                    MySqlConnection mysql = new MySqlConnection(mySqlCon);
                    mysql.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT VisitorImage FROM visitors WHERE visitorID = @visitorID", mysql);
                    cmd.Parameters.AddWithValue("@visitorID", visitorID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                byte[] imageBytes = (byte[])reader["VisitorImage"];

                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    System.Drawing.Image visitorImage = System.Drawing.Image.FromStream(ms);

                                    ViewVisitorImage view = new ViewVisitorImage(visitorImage);
                                    view.ShowDialog();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No image available for this visitor.", "Image Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Visitor not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving image: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
