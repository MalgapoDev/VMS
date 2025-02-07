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
                MessageBox.Show("Input to add Department or Room.");
            }
            else 
            {
                MySqlConnection mysql = new MySqlConnection(mySqlCon);
                try
                {
                    mysql.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO department (DepartmentName, Room) VALUES (@DepartmentName, @Room)", mysql);
                    cmd.Parameters.AddWithValue("@DepartmentName", DepartmentName);
                    cmd.Parameters.AddWithValue("@Room", Room);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Department added.");
                    txt_Department.Clear();
                    txt_Room.Clear();
                    
                    mysql.Close();

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Add Department Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
