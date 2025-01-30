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
    public partial class AddUserPrompt : KryptonForm
    {
        public AddUserPrompt()
        {
            InitializeComponent();
        }

        private void Okay_btn_Click(object sender, EventArgs e)
        {
            QueueList queueList = new QueueList();
            queueList.Show();
            Visible = false;
        }

        private void AddUserPrompt_Load(object sender, EventArgs e)
        {
            displayText.Text = "Visitor Added to the Queue";
        }
    }
}
