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

namespace Visitor_Management_System
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
            MakeRoundPictureBox(guna2CirclePictureBox1);

        }
        private void MakeRoundPictureBox(PictureBox pictureBox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);

            pictureBox.Region = new Region(path);
        }

        private void gunaLogin_btn_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_password.Text.Trim();

            // sample user
            string ValidUser = "admin";
            string Validpass = "123456";

            if (username == ValidUser && password == Validpass)
            {
                MessageBox.Show("Logged in Successfully!");
                MainForm main = new MainForm();
                main.Show();
                Visible = false;

            }
            else 
            {
                MessageBox.Show("Username or password incorrect!");
            }

        }
    }
}
