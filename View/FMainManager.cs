using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_PBL3.View
{
    public partial class FMainManager : Form
    {
        public FMainManager()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        private Form currentForm { get; set; }
        private void OpenChildForm(Form childForm)
        {
            if(currentForm!=null)
                currentForm.Close();
            currentForm = childForm;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle= FormBorderStyle.None;
            currentForm.Dock= DockStyle.Fill;
            PanelMain.Controls.Add(currentForm);
            currentForm.Show();


        }
        private void guna2ButBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FBill());


        }

        private void guna2ButSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Caidat());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FLogin f = new FLogin();
            f.Show();
        }
    }
}
