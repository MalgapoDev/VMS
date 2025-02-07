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
using Visitor_Management_System.Methods;

namespace Visitor_Management_System
{
    public partial class MainForm : KryptonForm
    {
        private KryptonForm cachedAddVisitorForm = null;

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

        private void add_Visitor_btn_Click(object sender, EventArgs e)
        {
            if (cachedAddVisitorForm == null || cachedAddVisitorForm.IsDisposed)
            {
                cachedAddVisitorForm = new AddVisitor();
            }
            FormLoader.LoadForm(MainPanel, cachedAddVisitorForm);
            add_Visitor_btn.Cursor = Cursors.Hand;
        }

        private void Queue_btn_Click(object sender, EventArgs e)
        {
            FormLoader.LoadForm(MainPanel, new QueueList());
            Queue_btn.Cursor = Cursors.Hand;
        }

        private void Reports_btn_Click(object sender, EventArgs e)
        {
            FormLoader.LoadForm(MainPanel, new Reports());
            Reports_btn.Cursor = Cursors.Hand;
        }

        private void History_btn_Click(object sender, EventArgs e)
        {
            FormLoader.LoadForm(MainPanel, new History());
            History_btn.Cursor = Cursors.Hand;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormLoader.LoadForm(MainPanel, new QueueList());
            this.MinimizeBox = true;
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Visible = false;
        }

        private void btn_Dept_Click(object sender, EventArgs e)
        {
            addDepartment dept = new addDepartment();
            dept.ShowDialog();
        }
    }
}
