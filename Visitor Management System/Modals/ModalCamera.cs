using AForge.Video;
using AForge.Video.DirectShow;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visitor_Management_System
{
    public partial class ModalCamera : KryptonForm
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        public Image CapturedImage { get; private set; }
        public ModalCamera()
        {
            InitializeComponent();

            // start modal camera to center top
            this.StartPosition = FormStartPosition.Manual;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int formWidth = this.Width;
            int x = (screenWidth - formWidth) / 2;
            int y = 0;
            this.Location = new Point(x, y);
        }
        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox_userProfile.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Capture_btn_Click(object sender, EventArgs e)
        {
            if (pictureBox_userProfile.Image == null)
            {
                MessageBox.Show("No image captured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource.NewFrame -= VideoCaptureDevice_NewFrame;
            }
            // Ask receptionist for the confirmation of the visitor capture image
            DialogResult result = MessageBox.Show("Are you sure about this image?", "Confirm Capture",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) // Retake 
            {
                StartCameraFeed();
                return;
            }

            if (result == DialogResult.Yes)
            {
                if (videoSource != null && videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                    videoSource.NewFrame -= VideoCaptureDevice_NewFrame; 
                }
            }

            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            string fileName = $"CapturedImage_{DateTime.Now:yyyyMMdd_HHmmss}.jpg";
            string savePath = Path.Combine(folderPath, fileName);

            try
            {
                using (Bitmap bmp = new Bitmap(pictureBox_userProfile.Image))
                {
                    bmp.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                }

                CapturedImage = Image.FromFile(savePath);

                MessageBox.Show($"Image saved to {savePath}", "Image Captured", MessageBoxButtons.OK);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Capture Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModalCamera_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No camera detected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (FilterInfo device in videoDevices)
            {
                comboBox_selectCamera.Items.Add(device.Name);
            }

            comboBox_selectCamera.SelectedIndex = 0; // Select first camera
            StartCamera(comboBox_selectCamera.SelectedIndex);
        }

        private void comboBox_selectCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartCamera(comboBox_selectCamera.SelectedIndex);
        }

        private void StartCamera(int cameraIndex) //start the camera by selecting camera type
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource.NewFrame -= VideoCaptureDevice_NewFrame;
            }

            videoSource = new VideoCaptureDevice(videoDevices[cameraIndex].MonikerString);
            videoSource.NewFrame += VideoCaptureDevice_NewFrame;
            videoSource.Start();
        }

        private void StartCameraFeed() // method for retake capture 
        {
            if (videoSource != null)
            {
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                }
                videoSource.NewFrame -= VideoCaptureDevice_NewFrame;
            }

            videoSource = new VideoCaptureDevice(videoDevices[comboBox_selectCamera.SelectedIndex].MonikerString);
            videoSource.NewFrame += VideoCaptureDevice_NewFrame;
            videoSource.Start();
        }

        private void ModalCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource.NewFrame -= VideoCaptureDevice_NewFrame;
            }
        }
    }
}
