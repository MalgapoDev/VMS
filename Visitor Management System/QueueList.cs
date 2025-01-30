using ComponentFactory.Krypton.Toolkit;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Visitor_Management_System
{
    public partial class QueueList : KryptonForm
    {
        private DataTable table;
        public QueueList()
        {
            InitializeComponent();
            InitializeDataTable();

            txt_Search.TextChanged += txt_Search_TextChanged;
        }
        private void InitializeDataTable()
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

            dataGrid_QueueTable.DataSource = table;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Action";
            buttonColumn.Text = "Time - Out";
            buttonColumn.UseColumnTextForButtonValue = true;

            dataGrid_QueueTable.Columns.Add(buttonColumn);
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            string filterText = txt_Search.Text;

            if (string.IsNullOrWhiteSpace(filterText))
            {
                dataGrid_QueueTable.DataSource = table;
            }
            else
            {
                DataView filteredView = new DataView(table);
                filteredView.RowFilter = $"Name LIKE '%{filterText}%'";
                dataGrid_QueueTable.DataSource = filteredView;
            }
        }
    }
}
