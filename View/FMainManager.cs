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
            f.OpenChildForm(panelMain, new FHomePage());
        }
        QLForm f = new QLForm();
        public static FBill fBill = new FBill();
        public delegate void Mydel(DateTime dt);
        public Mydel d { get;set;}
       // QLNV_DAL dal = new QLNV_DAL();
     
        private void PanelFrame_Paint_1(object sender, PaintEventArgs e)
        {
            lbThongTin.Text = FLogin.account.ChiTietTaiKhoan.HoTen + "\n" + FLogin.account.Role + "\n" + "ID: " + FLogin.account.ID + "";
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
        private void ButDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin f = new FLogin();
            f.Show();
        }

        private void ButTrangChu_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(panelMain, new FHomePage());

        }
        
        private void guna2ButBill_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(panelMain, fBill);
            guna2ButBill.Checked = true;
        }

        private void butClock_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(panelMain, new FClock());
        }

        private void butLichSu_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(panelMain, new FPurchaseHistory());
        }

        private void guna2ButSetting_Click(object sender, EventArgs e)
        {
            FSetting s = new FSetting();
            s.GetChiTietTaiKhoan(FLogin.account.ID);
            f.OpenChildForm(panelMain, s);
        }

        private void guna2ButStaff_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(panelMain, new FStaff());
        }

        private void butKhuyenMai_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(panelMain, new FSale());
        }

        private void ButThongKe_Click(object sender, EventArgs e)
        {
           
            f.OpenChildForm(panelMain, new FStatistical());
        }
    }
}
