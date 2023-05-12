using CNPM_PBL3.BLL;
using CNPM_PBL3.DAL;
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
        QLNV_DAL dal = new QLNV_DAL();
       // public static TaiKhoan account { get; set; }
        private void PanelFrame_Paint(object sender, PaintEventArgs e)
        {
            lbThongTin.Text = FLogin.account.ChiTietTaiKhoan.HoTen + "\n" + FLogin.account.Role + "\n"  + "ID: " +FLogin.account.ID + "";
        }
        public void show()
        {
            f.OpenChildForm(panelMain, new FHomePage());
            this.lbThongTin.Location = new System.Drawing.Point(35, 170);
            butClock.Visible = false;
            ButThongKe.Visible = false;
            this.ButTrangChu.Location = new System.Drawing.Point(11, 254);
            this.guna2ButBill.Location = new System.Drawing.Point(11, 314);
            this.butLichSu.Location = new System.Drawing.Point(11, 374);
            this.guna2ButSetting.Location = new System.Drawing.Point(11, 434);
            guna2ButStaff.Visible = false;
            butKhuyenMai.Visible = false;

        }

        public static FBill fBill = new FBill(); 
        private void guna2ButBill_Click(object sender, EventArgs e)
        {
            //QLForm k = new QLForm();
            f.OpenChildForm(panelMain, fBill);
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

        private void ButTrangChu_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(panelMain, new FHomePage());

        }

        private void butKhuyenMai_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(panelMain, new FKhuyenMai());
        }
    }
}
