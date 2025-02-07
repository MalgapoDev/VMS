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

namespace Visitor_Management_System
{
    public partial class VerifiedUser : KryptonForm
    {
        public VerifiedUser()
        {
            InitializeComponent();
            TimePicker_TimeofVisitVerified.Format = DateTimePickerFormat.Custom;
            TimePicker_TimeofVisitVerified.CustomFormat = "hh:mm tt";
            TimePicker_TimeofVisitVerified.Value = DateTime.Now;
        }

        private void ConfirmVisitor_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visitor Confirmed!", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormLoader.LoadForm(Confirmation_panel, new AddVisitor());
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
            comboBox_suffixVerified.Enabled = false;
            comboBox_ValidID_Verified.Enabled = false;

            TimePicker_TimeofVisitVerified.Format = DateTimePickerFormat.Time;
            TimePicker_TimeofVisitVerified.ShowUpDown = true;

            string[] departments = { "Information Technology", "Accounting", "Engineering", "HR" };

            foreach (string dept in departments)
            {
                comboBox_DepartmentVerified.Items.Add(dept);
            }
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
