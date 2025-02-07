using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Guna.UI2.WinForms.Suite;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Drawing.Imaging;
using Visitor_Management_System.Methods;



namespace Visitor_Management_System
{

    public partial class AddVisitor : KryptonForm
    {
        private string mySqlCon = "server=127.0.0.1; user=root; database=vms_database; password=";
        Dictionary<string, string> departmentRoomMap = new Dictionary<string, string>();
        public AddVisitor()
        {
            InitializeComponent();

            TimePicker_TimeofVisit.Format = DateTimePickerFormat.Custom;
            TimePicker_TimeofVisit.CustomFormat = "hh:mm tt";
            TimePicker_TimeofVisit.Value = DateTime.Now;
        }

        private void AddVisitor_Load(object sender, EventArgs e)
        {
            TimePicker_TimeofVisit.Format = DateTimePickerFormat.Time;
            TimePicker_TimeofVisit.ShowUpDown = true;

            string[] suffix = { "N/A", "Jr", "Sr", "II", "III", "IV" };

            foreach (string sfx in suffix)
            {
                comboBox_suffix.Items.Add(sfx);
            }

            try
            {
                MySqlConnection mysql = new MySqlConnection(mySqlCon);
                mysql.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT DepartmentName, Room FROM department", mysql);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string departmentName = reader["DepartmentName"].ToString();
                    string room = reader["Room"].ToString();

                    comboBox_Department.Items.Add(departmentName);

                    // Store the department and room in a dictionary
                    if (!departmentRoomMap.ContainsKey(departmentName))
                    {
                        departmentRoomMap.Add(departmentName, room);
                    }
                }

                mysql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string[] ValidID = { "Postal ID", "PRC ID", "OFW ID", "National ID", "Philhealth ID", "SSS ID",
                "Passport", "Driver's License", "TIN ID"};

            foreach (string id in ValidID)
            {
                comboBox_ValidID.Items.Add(id);
            }

            datePicker_DateofBirth.Format = DateTimePickerFormat.Custom;
            datePicker_DateofBirth.CustomFormat = "MM/dd/yyyy";

            DatePicker_DateofVisit.Format = DateTimePickerFormat.Custom;
            DatePicker_DateofVisit.CustomFormat = "MM/dd/yyyy";
            DatePicker_DateofVisit.Value = DateTime.Now;

            TimePicker_TimeofVisit.Format = DateTimePickerFormat.Custom;
            TimePicker_TimeofVisit.CustomFormat = "hh:mm tt";
            TimePicker_TimeofVisit.Text = DateTime.Now.ToString("hh:mm tt");
            TimePicker_TimeofVisit.ShowUpDown = true;

        }

        private void EnterVisitCode_btn_Click(object sender, EventArgs e)
        {
            FormLoader.LoadForm(modal_panel, new VerifyUser());
            modal_panel.Visible = true;
        }

        private void AddVisitor_btn_Click(object sender, EventArgs e)
        {

            string firstName = txt_firstname.Text.Trim();
            string lastName = txt_lastname.Text.Trim();
            string middleInitial = txt_middleInital.Text.Trim();
            string Email = txt_Email.Text.Trim();
            string ContactNum = txt_Contact.Text.Trim();
            string Address = txt_Address.Text.Trim();
            string ContactPerson = txt_ContactPerson.Text.Trim();
            string Room = txt_Room.Text.Trim();
            string Purpose = txt_PurposeofVisit.Text.Trim();
            string CardNumber = txt_CardNumber.Text.Trim();
            string IdPresented = comboBox_ValidID.Text.Trim();
            string department = comboBox_Department.Text.Trim();

            DateTime timeVisit = TimePicker_TimeofVisit.Value;
            DateTime dateofBirth = datePicker_DateofBirth.Value;
            DateTime dateVisit = DatePicker_DateofVisit.Value;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(middleInitial) || string.IsNullOrEmpty(Email)
                || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(ContactPerson) || string.IsNullOrEmpty(Room) || string.IsNullOrEmpty(Purpose) || string.IsNullOrEmpty(CardNumber))
            {
                MessageBox.Show("Please fill the visitor credentials", "Add Visitor Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (firstName.Any(char.IsDigit) && lastName.Any(char.IsDigit) && ContactPerson.Any(char.IsDigit) && middleInitial.Any(char.IsDigit))
            {
                MessageBox.Show("Check the credentials.", "Add Visitor Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (!Email.Contains("@gmail.com"))
            {
                MessageBox.Show("Enter the gmail account of the visitor.", "Add Visitor Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (ContactNum.Any(char.IsLetter))
            {
                MessageBox.Show("Contact Number must be numeric.", "Add Visitor Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    MySqlConnection mysql = new MySqlConnection(mySqlCon);

                    mysql.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO addvisitor (FirstName, LastName, MiddleInitial, Suffix, Email, ContactNumber, DateofBirth, Address, VisitorImage, ContactPerson, IDPresented, Room, Department, Date, TimeIn, Purpose, CardNumber) " +
                    "VALUES (@FirstName, @LastName, @MiddleInitial, @Suffix, @Email, @ContactNumber, @DateofBirth, @Address, @VisitorImage, @ContactPerson, @IDPresented, @Room, @Department, @Date, @TimeIn, @Purpose, @CardNumber)", mysql);

                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@MiddleInitial", middleInitial);
                    cmd.Parameters.AddWithValue("@Suffix", comboBox_suffix.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@ContactNumber", ContactNum);
                    cmd.Parameters.AddWithValue("@DateofBirth", dateofBirth);
                    cmd.Parameters.AddWithValue("@Address", Address);

                    if (pictureBox_userProfile.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            Image resizedImage = new Bitmap(pictureBox_userProfile.Image, new Size(150, 150));
                            resizedImage.Save(ms, ImageFormat.Jpeg);

                            if (ms.Length < 65536) // Check if the image is within acceptable size
                            {
                                cmd.Parameters.AddWithValue("@VisitorImage", ms.ToArray());
                            }
                            else
                            {
                                MessageBox.Show("Image is too large. Please use a smaller image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@VisitorImage", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@ContactPerson", ContactPerson);
                    cmd.Parameters.AddWithValue("@IDPresented", IdPresented);
                    cmd.Parameters.AddWithValue("@Room", Room);
                    cmd.Parameters.AddWithValue("@Department", department);
                    cmd.Parameters.AddWithValue("@Date", dateVisit);
                    cmd.Parameters.AddWithValue("@TimeIn", timeVisit);
                    cmd.Parameters.AddWithValue("@Purpose", Purpose);
                    cmd.Parameters.AddWithValue("@CardNumber", CardNumber);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Visitor added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    mysql.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Add Visitor Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                FormLoader.LoadForm(modal_panel, new AddUserPrompt());
                modal_panel.Visible = true;

            }
        }

        private void btn_startCamera_Click(object sender, EventArgs e)
        {
            using (ModalCamera captureForm = new ModalCamera())
            {
                if (captureForm.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_userProfile.Image = captureForm.CapturedImage;
                }
            }
        }

        private void comboBox_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDepartment = comboBox_Department.SelectedItem.ToString();

            if (departmentRoomMap.ContainsKey(selectedDepartment))
            {
                txt_Room.Text = departmentRoomMap[selectedDepartment];
            }
        }
    }
}
