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
using MySql.Data.MySqlClient;
using System.Collections;

namespace Visitor_Management_System
{
    public partial class QueueList : KryptonForm
    {
        private string mySqlCon = "server=127.0.0.1; user=root; database=vms_database; password=";

        private DataTable table;
        public QueueList()
        {
            InitializeComponent();
            InitializeDataTable();

            txt_Search.TextChanged += txt_Search_TextChanged;

            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }
        private void InitializeDataTable()
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

        private void QueueList_Load(object sender, EventArgs e)
        {
            lbl_Date.Text = DateTime.Now.ToString("MMMM dd, yyyy");

            MySqlConnection mysql = new MySqlConnection(mySqlCon);

            mysql.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT FullName, BuildingName FROM accounts WHERE Username = @Username", mysql);
            cmd.Parameters.AddWithValue("@Username", "admin01");
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbl_fullName.Text = reader["FullName"].ToString();
                lbl_buildingNo.Text = reader["BuildingName"].ToString();
            }
            else
            {
                MessageBox.Show("No data found for the given username.");
            }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("hh:mm tt");
        }
    }
}
