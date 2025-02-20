using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Visitor_Management_System.Methods
{
    internal class QueueListMethod
    {
        // Connection string for MySQL database
        private string mySqlCon = "server=127.0.0.1; user=root; database=vms_database; password=";
        private DataTable table;

        public DataTable LoadVisitorData() // datatable method to call the table and display from data grid view.
        {
            
            try
            {
                MySqlConnection mysql = new MySqlConnection(mySqlCon);
                mysql.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT v.visitorID, CONCAT(v.FirstName ,' ' , v.LastName) AS visitorName, v.Email, v.ContactNumber, i.ContactPerson," +
                    " i.IDPresented, i.Room, i.Department, i.DateOfVisit, i.TimeIn, i.TimeOut, i.PurposeOfVisit," +
                    " i.CardNumber FROM visitors v JOIN visit_information i ON v.visitorID = i.visitorID WHERE i.TimeOut IS NULL", mysql);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                table = new DataTable();
                adapter.Fill(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading visitors: {ex.Message}");
            }

            return table;
        }
    }
}
