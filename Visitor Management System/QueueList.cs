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
using Visitor_Management_System.Methods;

namespace Visitor_Management_System
{
    public partial class QueueList : KryptonForm
    {
        private string mySqlCon = "server=127.0.0.1; user=root; database=vms_database; password=";

        private QueueListMethod myQueueListMethod;

        private DataTable table;
        public QueueList()
        {
            InitializeComponent();

            myQueueListMethod = new QueueListMethod();

            txt_Search.TextChanged += txt_Search_TextChanged;

            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }
        private void LoadVisitor()
        {
            table = myQueueListMethod.LoadVisitorData();
            dataGrid_QueueTable.DataSource = table;

            if (!dataGrid_QueueTable.Columns.Contains("Action"))
            {
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
                {
                    Name = "Action",
                    HeaderText = " ",
                    Image = System.Drawing.Image.FromFile(@"C:/Users/Nancy/Desktop/SENTINEL/timeout.png"),
                    ImageLayout = DataGridViewImageCellLayout.NotSet
                };
                dataGrid_QueueTable.Columns.Add(imageColumn);
            }
            dataGrid_QueueTable.RowTemplate.Height = 100;
            dataGrid_QueueTable.Columns["VisitorImage"].Width = 100;
            dataGrid_QueueTable.AllowUserToAddRows = false;

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

            LoadVisitor();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void dataGrid_QueueTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGrid_QueueTable.Columns["Action"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGrid_QueueTable.Rows[e.RowIndex];
                string visitorId = row.Cells["Id"].Value.ToString();
                string timeIn = row.Cells["TimeIn"].Value.ToString();
                string timeOut = DateTime.Now.ToString("hh:mm tt");

                try
                {
                    MySqlConnection mysql = new MySqlConnection(mySqlCon);
                    mysql.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE addvisitor SET TimeOut = @TimeOut WHERE Id = @Id", mysql);
                    cmd.Parameters.AddWithValue("@TimeOut", timeOut);
                    cmd.Parameters.AddWithValue("@Id", visitorId);
                    cmd.ExecuteNonQuery();
                    mysql.Close();

                    MessageBox.Show("Visitor timed out successfully.");

                    LoadVisitor();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating time out: {ex.Message}");
                }
            }
        }
    }
}
