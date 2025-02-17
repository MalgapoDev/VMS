using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace Visitor_Management_System
{
    public partial class Login : KryptonForm
    {
        // Connection string for MySQL database
        private string mySqlCon = "server=127.0.0.1; user=root; database=vms_database; password=";

        public Login()
        {
            InitializeComponent();
        }

        // login function for receptionist. The value for receptionist is only sample data.
        private void gunaLogin_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection mysql = new MySqlConnection(mySqlCon);

            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Empty Credentials");
            }
            else 
            {
                mysql.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM accounts", mysql);
                MySqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    if(username.Equals(reader.GetString("Username")) && password.Equals(reader.GetString("Password")))
                    {
                        MainForm main = new MainForm();
                        main.Show();
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login");
                    }
                }
                mysql.Close();
            }

        }

        // exit the application by clicking the close button in the window form.
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
