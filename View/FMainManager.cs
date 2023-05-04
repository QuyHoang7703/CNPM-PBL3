using CNPM_PBL3.BLL;
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
        QLForm f = new QLForm();
        public static TaiKhoan account { get; set; }
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        private void guna2ButBill_Click(object sender, EventArgs e)
        {
            //QLForm k = new QLForm();
            f.OpenChildForm(panelMain, new FBill());
            //OpenChildForm(new FBill());

                
        }

        private void guna2ButSetting_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FSetting());
            FSetting s = new FSetting();
            s.GetChiTietTaiKhoan(FLogin.account.ID);
            f.OpenChildForm(panelMain, s);
           // QLTK_BLL bll = new QLTK_BLL();
           

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FLogin f = new FLogin();
            f.Show();
        }

       
        private void guna2ButStaff_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FStaff());
            f.OpenChildForm(panelMain, new FStaff());
        }

        private void butClock_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FDetailClock());
            f.OpenChildForm(panelMain, new FClock());
        }

        private void butLichSu_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(panelMain, new FPurchaseHistory());
        }
    }
}
