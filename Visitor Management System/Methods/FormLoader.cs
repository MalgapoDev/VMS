using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visitor_Management_System.Methods
{
    internal class FormLoader
    {
        public static void LoadForm(Control parentControl, KryptonForm form)
        {
            if (parentControl.Controls.Count > 0)
                parentControl.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            parentControl.Controls.Add(form);
            parentControl.Tag = form;
            form.Show();
        }
    }
}
