using ComponentFactory.Krypton.Toolkit;
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
    public partial class MainForm : KryptonForm
    {
        public MainForm()
        {
            InitializeComponent();
            MakeRoundPictureBox(logoImage);
        }

        //Make to logo circled.
        private void MakeRoundPictureBox(PictureBox pictureBox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);

            pictureBox.Region = new Region(path);
        }

        private void loadForm(object KryptonForm)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            KryptonForm f = KryptonForm as KryptonForm;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();

        }

        private void add_Visitor_btn_Click(object sender, EventArgs e)
        {
            loadForm(new AddVisitor());

            add_Visitor_btn.Cursor = Cursors.Hand;
        }

        private void Queue_btn_Click(object sender, EventArgs e)
        {
            loadForm(new QueueList());
            Queue_btn.Cursor = Cursors.Hand;
        }

        private void Reports_btn_Click(object sender, EventArgs e)
        {
            loadForm(new Reports());
            Reports_btn.Cursor = Cursors.Hand;
        }

        private void History_btn_Click(object sender, EventArgs e)
        {
            loadForm(new History());
            History_btn.Cursor = Cursors.Hand;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadForm(new QueueList());
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Visible = false;
        }
    }
}
