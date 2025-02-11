using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Visitor_Management_System
{
    public partial class addDepartment : KryptonForm
    {
        private string mySqlCon = "server=127.0.0.1; user=root; database=vms_database; password=";
        public addDepartment()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int formWidth = this.Width;
            int x = screenWidth - formWidth;
            int y = 0;
            this.Location = new Point(x, y);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string DepartmentName = txt_Department.Text.Trim();
            string Room = txt_Room.Text.Trim();

            if (string.IsNullOrEmpty(DepartmentName) || string.IsNullOrEmpty(Room))
            {
                MessageBox.Show("Please input both Department and Room.");
            }
            else
            {
                using (MySqlConnection mysql = new MySqlConnection(mySqlCon))
                {
                    try
                    {
                        mysql.Open();

                        // Check if the department already exists
                        MySqlCommand checkDeptCmd = new MySqlCommand("SELECT departmentId FROM department WHERE DepartmentName = @DepartmentName", mysql);
                        checkDeptCmd.Parameters.AddWithValue("@DepartmentName", DepartmentName);

                        object result = checkDeptCmd.ExecuteScalar();
                        long departmentId;

                        if (result != null)
                        {
                            // Department exists, get its ID
                            departmentId = Convert.ToInt64(result);
                        }
                        else
                        {
                            MySqlCommand insertDeptCmd = new MySqlCommand("INSERT INTO department (DepartmentName) VALUES (@DepartmentName)", mysql);
                            insertDeptCmd.Parameters.AddWithValue("@DepartmentName", DepartmentName);
                            insertDeptCmd.ExecuteNonQuery();
                            departmentId = insertDeptCmd.LastInsertedId;
                        }

                        // Add the room associated with the department
                        MySqlCommand insertRoomCmd = new MySqlCommand("INSERT INTO room (RoomNo, departmentId) VALUES (@RoomNo, @departmentId)", mysql);
                        insertRoomCmd.Parameters.AddWithValue("@RoomNo", Room);
                        insertRoomCmd.Parameters.AddWithValue("@departmentId", departmentId);
                        insertRoomCmd.ExecuteNonQuery();

                        MessageBox.Show("Department and Room added successfully.");
                        txt_Room.Clear(); 

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Add Department Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
