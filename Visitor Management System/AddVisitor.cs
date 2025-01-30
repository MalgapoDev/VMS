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



namespace Visitor_Management_System
{
    public partial class AddVisitor : KryptonForm
    {

        public AddVisitor()
        {
            InitializeComponent();

            TimePicker_TimeofVisit.Format = DateTimePickerFormat.Custom;
            TimePicker_TimeofVisit.CustomFormat = "hh:mm tt"; 
            TimePicker_TimeofVisit.Value = DateTime.Now;
        }
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;

        private void loadForm(object KryptonForm)
        {
            if (this.modal_panel.Controls.Count > 0)
                this.modal_panel.Controls.RemoveAt(0);
            KryptonForm f = KryptonForm as KryptonForm;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.modal_panel.Controls.Add(f);
            this.modal_panel.Tag = f;
            f.Show();

        }

        private void AddVisitor_Load(object sender, EventArgs e)
        {
            TimePicker_TimeofVisit.Format = DateTimePickerFormat.Time;
            TimePicker_TimeofVisit.ShowUpDown = true;

            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in videoDevices)
            {
                comboBox_selectCamera.Items.Add(filterInfo.Name);
                comboBox_selectCamera.SelectedIndex = 0;
                videoSource = new VideoCaptureDevice();
            }

            string[] suffix = { "Jr", "Sr", "II", "III" };

            foreach (string sfx in suffix)
            {
                comboBox_suffix.Items.Add(sfx);
            }

            string[] departments = { "Information Technology", "Accounting", "Engineering", "HR" };

            foreach (string dept in departments)
            {
                comboBox_Department.Items.Add(dept);
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
            TimePicker_TimeofVisit.Value = DateTime.Now;
            TimePicker_TimeofVisit.ShowUpDown = true;

        }

        private void EnterVisitCode_btn_Click(object sender, EventArgs e)
        {
            loadForm(new VerifyUser());
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
            string Floor = txt_Floor.Text.Trim();
            string Purpose = txt_PurposeofVisit.Text.Trim();
            string CardNumber = txt_CardNumber.Text.Trim();

            DateTime timeVisit = TimePicker_TimeofVisit.Value;
            DateTime dateofBirth = datePicker_DateofBirth.Value;
            DateTime dateVisit = DatePicker_DateofVisit.Value;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(middleInitial) || string.IsNullOrEmpty(Email)
                || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(ContactPerson) || string.IsNullOrEmpty(Room) || string.IsNullOrEmpty(Floor)
                || string.IsNullOrEmpty(Purpose) || string.IsNullOrEmpty(CardNumber))
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

            else if (dateVisit < DateTime.Now)
            {
                MessageBox.Show("Please select a future date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (timeVisit < DateTime.Now)
            {
                MessageBox.Show("Please select a future time", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                AddUserPrompt userprompt = new AddUserPrompt();
                userprompt.ShowDialog();
            }
        }

        private void btn_startCamera_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(videoDevices[comboBox_selectCamera.SelectedIndex].MonikerString);
            videoSource.NewFrame += VideoCaptureDevice_NewFrame;
            videoSource.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox_CapturedImage.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Capture_btn_Click(object sender, EventArgs e)
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            string fileName = $"CapturedImage_{DateTime.Now:yyyyMMdd}.jpg";
            string savePath = Path.Combine(folderPath, fileName);

            try
            {
                pictureBox_CapturedImage.Image.Save(savePath);
                pictureBox_userProfile.Image = new Bitmap(savePath);
                MessageBox.Show($"Image saved to {savePath}", "Image Captured", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void btn_stopCamera_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.Stop();
                videoSource.NewFrame -= VideoCaptureDevice_NewFrame;
            }
        }
    }
}
