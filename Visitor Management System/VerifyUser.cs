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

namespace Visitor_Management_System
{
    public partial class VerifyUser : KryptonForm
    {
        private const int IdLength = 6;
        private const int ValidPin = 123456;
        public VerifyUser()
        {
            InitializeComponent();
            txt_PinCode.MaxLength = IdLength;
            txt_PinCode.KeyPress += txt_PinCode_KeyPress;
        }

        private void loadForm(object KryptonForm)
        {
            if (this.Verified_User_panel.Controls.Count > 0)
                this.Verified_User_panel.Controls.RemoveAt(0);
            KryptonForm f = KryptonForm as KryptonForm;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Verified_User_panel.Controls.Add(f);
            this.Verified_User_panel.Tag = f;
            f.Show();

        }

        private void confirmPinCode_btn_Click(object sender, EventArgs e)
        {
            int pincode = Convert.ToInt32(txt_PinCode.Text);

            if (pincode != IdLength && pincode != ValidPin)
            {
                MessageBox.Show("Pin code must be matched.");
                txt_PinCode.Clear();
            }
            else if(string.IsNullOrEmpty(Convert.ToString(pincode)))
            {
                MessageBox.Show("Please enter pin code");
            }
            else
            {
                MessageBox.Show("Pin Code Confirmed");

                loadForm(new VerifiedUser());
            }
        }

        private void txt_PinCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
