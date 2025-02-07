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
        private void loadForm(object KryptonForm)
        {
            if (this.userPrompt_panel.Controls.Count > 0)
                this.userPrompt_panel.Controls.RemoveAt(0);
            KryptonForm f = KryptonForm as KryptonForm;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.userPrompt_panel.Controls.Add(f);
            this.userPrompt_panel.Tag = f;
            f.Show();

        }

        private void Okay_btn_Click(object sender, EventArgs e)
        {
            loadForm(new AddVisitor());
        }

        private void AddUserPrompt_Load(object sender, EventArgs e)
        {
            
        }
    }
}
