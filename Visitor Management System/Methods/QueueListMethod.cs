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
        private string mySqlCon = "server=127.0.0.1; user=root; database=vms_database; password=";
        private DataTable table;
        public DataTable LoadVisitorData()
        {
            try
            {
                MySqlConnection mysql = new MySqlConnection(mySqlCon);
                mysql.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM addvisitor", mysql);
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
