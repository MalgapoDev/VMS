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
using System.IO;
using MySqlX.XDevAPI;

namespace Visitor_Management_System
{
    public partial class QueueList : KryptonForm
    {
        // Connection string for MySQL database
        private string mySqlCon = "server=127.0.0.1; user=root; database=vms_database; password=";

        private QueueListMethod myQueueListMethod;

        private DataTable table;
        private DataGridViewImageColumn imageColumn;
        public QueueList()
        {
            InitializeComponent();

            myQueueListMethod = new QueueListMethod();

            txt_Search.TextChanged += txt_Search_TextChanged;

            // set time interval for the display of the current time.
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        // Method to load visitor data into the DataGridView
        private void LoadVisitor()
        {
            table = myQueueListMethod.LoadVisitorData();
            dataGrid_QueueTable.DataSource = table;

            // Add "ViewImage" button column if it doesn't exist
            if (!dataGrid_QueueTable.Columns.Contains("ViewImage"))
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
                {
                    Name = "ViewImage",
                    HeaderText = "VisitorImage",
                    Text = "View",
                    UseColumnTextForButtonValue = true
                };
                dataGrid_QueueTable.Columns.Add(buttonColumn);
            }

            // Add "Action" image column if it doesn't exist
            if (!dataGrid_QueueTable.Columns.Contains("Action"))
            {
                imageColumn = new DataGridViewImageColumn
                {
                    Name = "Action",
                    HeaderText = " ",
                    Image = System.Drawing.Image.FromFile(@"C:/Users/Nancy/Desktop/SENTINEL/timeout.png"),
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                dataGrid_QueueTable.Columns.Add(imageColumn);
            }

            dataGrid_QueueTable.RowTemplate.Height = 30;
            dataGrid_QueueTable.AllowUserToAddRows = false;

        }

        // Event handler for search text box - filters the visitor data based on user input
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
                filteredView.RowFilter = $"FirstName LIKE '%{filterText}%' OR LastName LIKE '%{filterText}%' " +
                    $"' OR Email LIKE '%{filterText}%' ' OR ContactPerson LIKE '%{filterText}%'";
                dataGrid_QueueTable.DataSource = filteredView;
            }
        }

        // Event handler for form load - initializes visitor data and loads user details
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

        // Event handler for timer tick - updates the time label dynamically
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("hh:mm tt");
        }

        // Event handler for DataGridView cell click - handles "ViewImage" and "Action" clicks
        private void dataGrid_QueueTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGrid_QueueTable.Columns["ViewImage"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGrid_QueueTable.Rows[e.RowIndex];
                string Id = row.Cells["Id"].Value.ToString();

                try
                {
                    MySqlConnection mysql = new MySqlConnection(mySqlCon);
                    mysql.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT VisitorImage FROM addvisitor WHERE Id = @Id", mysql);
                    cmd.Parameters.AddWithValue("@Id", Id);

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

            if (e.ColumnIndex == dataGrid_QueueTable.Columns["Action"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGrid_QueueTable.Rows[e.RowIndex];
                string visitorId = row.Cells["Id"].Value.ToString();
                string timeIn = row.Cells["TimeIn"].Value.ToString();
                object timeOutValue = row.Cells["TimeOut"].Value;

                if (timeOutValue != DBNull.Value && !string.IsNullOrWhiteSpace(timeOutValue.ToString()))
                {
                    MessageBox.Show("Visitor has already timed out.", "Time out Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
                    imageColumn.Visible = false;
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