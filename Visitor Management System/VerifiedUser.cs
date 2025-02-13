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
using System.Windows.Forms;
using Visitor_Management_System.Methods;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Visitor_Management_System
{
    public partial class VerifiedUser : KryptonForm
    {
        private string mySqlCon = "server=127.0.0.1; user=root; database=vms_database; password=";
        public VerifiedUser(string firstname, string lastname, string MI, string suffix, string email, string contactnum, string dateofbirth,
                    string address, string contactperson, string idpresented, string room, string department, string date, string purpose, Image visitorImage)
        {
            InitializeComponent();

            txt_firstnameVerified.Text = firstname;
            txt_lastnameVerified.Text = lastname;
            txt_middleInitalVerified.Text = MI;
            txt_suffixVerified.Text = suffix;
            txt_EmailVerified.Text = email;
            txt_ContactVerified.Text = contactnum;
            datePicker_DateofBirthVerified.Text = dateofbirth;
            txt_AddressVerified.Text = address;
            txt_ContactPersonVerified.Text = contactperson;
            txt_validIDVerified.Text = idpresented;
            txt_RoomVerified.Text = room;
            txt_DepartmentVerified.Text = department;
            DatePicker_DateofVisitVerified.Text = date;
            txt_PurposeofVisitVerified.Text = purpose;

            if (visitorImage != null)
            {
                pictureBox_verifiedUserPfp.Image = visitorImage;
                pictureBox_verifiedUserPfp.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            TimePicker_TimeofVisitVerified.Format = DateTimePickerFormat.Custom;
            TimePicker_TimeofVisitVerified.CustomFormat = "hh:mm tt";
            TimePicker_TimeofVisitVerified.Value = DateTime.Now;
        }

        private void ConfirmVisitor_btn_Click(object sender, EventArgs e)
        {
            try 
            {
                MySqlConnection mysql = new MySqlConnection(mySqlCon);
                mysql.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE addvisitor SET TimeIn = @TimeIn, CardNumber = @CardNumber WHERE Email = @Email", mysql);
                cmd.Parameters.AddWithValue("@TimeIn", TimePicker_TimeofVisitVerified.Text);
                cmd.Parameters.AddWithValue("@CardNumber", txt_CardNumberVerified.Text);
                cmd.Parameters.AddWithValue("@Email", txt_EmailVerified.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Visitor's TimeIn and CardNumber updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No matching visitor found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                FormLoader.LoadForm(Confirmation_panel, new AddVisitor());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void VerifiedUser_Load(object sender, EventArgs e)
        {
            txt_firstnameVerified.Enabled = false;
            txt_lastnameVerified.Enabled = false;
            txt_middleInitalVerified.Enabled = false;
            txt_EmailVerified.Enabled = false;
            txt_ContactVerified.Enabled = false;
            txt_AddressVerified.Enabled = false;
            datePicker_DateofBirthVerified.Enabled = false;
            txt_suffixVerified.Enabled = false;
            txt_validIDVerified.Enabled = false;
            DatePicker_DateofVisitVerified.Enabled = false;
            txt_ContactPersonVerified.Enabled = false;
            txt_DepartmentVerified.Enabled = false;
            txt_RoomVerified.Enabled = false;
            txt_PurposeofVisitVerified.Enabled = false;

            datePicker_DateofBirthVerified.Format = DateTimePickerFormat.Custom;
            datePicker_DateofBirthVerified.CustomFormat = "MM/dd/yyyy";

            DatePicker_DateofVisitVerified.Format = DateTimePickerFormat.Custom;
            DatePicker_DateofVisitVerified.CustomFormat = "MM/dd/yyyy";
            DatePicker_DateofVisitVerified.Value = DateTime.Now;

            TimePicker_TimeofVisitVerified.Format = DateTimePickerFormat.Custom;
            TimePicker_TimeofVisitVerified.CustomFormat = "hh:mm tt";
            TimePicker_TimeofVisitVerified.Text = DateTime.Now.ToString("hh:mm tt");
            TimePicker_TimeofVisitVerified.ShowUpDown = true;
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            if (ShowConfirmationDialog("Are you sure you want to cancel?", "Confirmation"))
            {
                FormLoader.LoadForm(Confirmation_panel, new AddVisitor());
            }
            else
            {
                MessageBox.Show("Operation not canceled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool ShowConfirmationDialog(string message, string title)
        {
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

    }
}
