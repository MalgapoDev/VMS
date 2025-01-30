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

namespace Visitor_Management_System
{
    public partial class VerifiedUser : KryptonForm
    {
        public VerifiedUser()
        {
            InitializeComponent();
        }
        private void loadForm(object KryptonForm)
        {
            if (this.Confirmation_panel.Controls.Count > 0)
                this.Confirmation_panel.Controls.RemoveAt(0);
            KryptonForm f = KryptonForm as KryptonForm;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Confirmation_panel.Controls.Add(f);
            this.Confirmation_panel.Tag = f;
            f.Show();

        }

        private void ConfirmVisitor_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visitor Confirmed!", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadForm(new AddVisitor());
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
        }
    }
}
