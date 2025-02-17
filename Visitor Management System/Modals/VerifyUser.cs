using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Visitor_Management_System.Methods;

namespace Visitor_Management_System
{
    public partial class VerifyUser : KryptonForm
    {
        // Connection string for MySQL database
        private string mySqlCon = "server=127.0.0.1; user=root; database=vms_database; password=";

        // initial limit for Visit code.
        private const int IdLength = 9;

        public VerifyUser()
        {
            InitializeComponent();
            txt_PinCode.MaxLength = IdLength;
        }

        // Event handler for confirming the PIN code input
        private void confirmPinCode_btn_Click(object sender, EventArgs e)
        {
            string pinCode = txt_PinCode.Text.Trim();

            if (string.IsNullOrWhiteSpace(pinCode))
            {
                MessageBox.Show("Please enter a pin code.");
                return;
            }

            // Fetch visitor details from the database based on the entered PIN code
            DataTable visitorData = GetVisitorData(pinCode);

            if (visitorData.Rows.Count > 0)
            {
                DataRow row = visitorData.Rows[0];

                // Extract details from database row
                string firstname = row["FirstName"].ToString();
                string lastname = row["LastName"].ToString();
                string MI = row["MiddleInitial"].ToString();
                string suffix = row["Suffix"].ToString();
                string email = row["Email"].ToString();
                string contactnum = row["ContactNumber"].ToString();
                string dateofbirth = row["DateofBirth"].ToString();
                string address = row["Address"].ToString();
                string contactperson = row["ContactPerson"].ToString();
                string idpresented = row["IDPresented"].ToString();
                string room = row["Room"].ToString();
                string department = row["Department"].ToString();
                string date = row["Date"].ToString();
                string purpose = row["Purpose"].ToString();
                byte[] visitorImage = (byte[])row["VisitorImage"];

                Image image = null;
                if (visitorImage != null && visitorImage.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(visitorImage))
                    {
                        image = Image.FromStream(ms);
                    }
                }


                FormLoader.LoadForm(Verified_User_panel, new VerifiedUser(firstname, lastname, MI, suffix, email, contactnum, dateofbirth,
                    address, contactperson, idpresented, room, department, date, purpose, image));
            }
            else
            {
                MessageBox.Show("Pin code does not match any records.");
                txt_PinCode.Clear();
            }
        }

        // Method to fetch visitor details from the database using the provided PIN code
        private DataTable GetVisitorData(string pincode)
        {

            DataTable visitorData = new DataTable();

            // Prepare the SQL query to retrieve visitor details
            try
            {
                MySqlConnection mysql = new MySqlConnection(mySqlCon);
                mysql.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM addvisitor WHERE VisitCode = @VisitCode", mysql);
                cmd.Parameters.AddWithValue("@VisitCode", pincode);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(visitorData);
                mysql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }

            return visitorData;

        }

        // Event handler for the "Back" button click
        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLoader.LoadForm(Verified_User_panel, new AddVisitor());
        }
    }
}
