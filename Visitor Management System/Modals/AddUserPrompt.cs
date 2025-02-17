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
using Visitor_Management_System.Methods;

namespace Visitor_Management_System
{
    public partial class AddUserPrompt : KryptonForm
    {
        public AddUserPrompt()
        {
            InitializeComponent();
        }

        // display the form addvisitor to the Main form by clicking okay button.
        private void Okay_btn_Click(object sender, EventArgs e)
        {
            FormLoader.LoadForm(userPrompt_panel, new AddVisitor());
        }
    }
}
