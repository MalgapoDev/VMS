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
    // window form that shows the visitor image by clicking button view 
    public partial class ViewVisitorImage : KryptonForm
    {
        private Image _visitorImage;
        public ViewVisitorImage(Image image)
        {
            InitializeComponent();
            _visitorImage = image;
        }

        // call and display the image of the visitor.
        private void ViewVisitorImage_Load(object sender, EventArgs e)
        {
            if (_visitorImage != null)
            {
                pictureBox_visitorImage.Image = _visitorImage;
                pictureBox_visitorImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("No image to display.", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
