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
using Visitor_Management_System.Methods;

namespace Visitor_Management_System
{
    public partial class History : KryptonForm
    {
        private DataTable table;
        public History()
        {
            InitializeComponent();
            table = ReportandHistoryMethod.LoadDataIntoGridView();
            dataGrid_HistoryTable.DataSource = table;

            txt_historySearch.TextChanged += txt_historySearch_TextChanged;
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

            dataGrid_HistoryTable.AllowUserToAddRows = false;
        }

        private void txt_historySearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txt_historySearch.Text;
            dataGrid_HistoryTable.DataSource = ReportandHistoryMethod.FilterByName(table, filterText);
        }

        private void comboBox_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGrid_HistoryTable.DataSource = ReportandHistoryMethod.ApplyFilters(table, comboBox_Department.SelectedItem?.ToString(), dateFilter_comboBox.SelectedItem?.ToString());
        }

        private void dateFilter_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGrid_HistoryTable.DataSource = ReportandHistoryMethod.ApplyFilters(table, comboBox_Department.SelectedItem?.ToString(), dateFilter_comboBox.SelectedItem?.ToString());
        }
    }
}
