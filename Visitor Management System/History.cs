using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;
using System.IO;
using Org.BouncyCastle.Asn1.Cms;
using System.Web.UI.WebControls;

namespace Visitor_Management_System
{
    public partial class History : KryptonForm
    {
        private DataTable table;
        public History()
        {
            InitializeComponent();
            LoadDataIntoGridView();

            txt_historySearch.TextChanged += txt_historySearch_TextChanged;
        }
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

            dataGrid_HistoryTable.DataSource = table;
        }

        private void History_Load(object sender, EventArgs e)
        {
            string[] departments = { "All", "IT", "Accounting", "Engineering", "HR" }; // types of department
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

        private void txt_historySearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txt_historySearch.Text;
            if (string.IsNullOrWhiteSpace(filterText))
            {
                dataGrid_HistoryTable.DataSource = table;
            }
            else
            {
                DataView filteredView = new DataView(table);
                filteredView.RowFilter = $"Name LIKE '%{filterText}%'";
                dataGrid_HistoryTable.DataSource = filteredView;
            }
        }

        private void comboBox_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGrid_HistoryTable.DataSource = ApplyFilters();
        }

        private void dateFilter_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGrid_HistoryTable.DataSource = ApplyFilters();
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
    }
}
