using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_PBL3.BLL
{
    internal class QLForm
    {
        //private static QLForm _instance;
       // public static QLForm Instance { get; set; }
        private Form currentForm { get; set; }
        public void OpenChildForm(Panel parentForm, Form childForm)
        {
            if(currentForm !=null)
            {
                currentForm.Hide();
            }
            currentForm = childForm;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;
            parentForm.Controls.Add(currentForm);
            currentForm.Show();

        }
    }
}
