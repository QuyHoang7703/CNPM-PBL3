using CNPM_PBL3.BLL;
using CNPM_PBL3.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace CNPM_PBL3.View
{
    public partial class FSetting : Form
    {
        public FSetting()
        {
            InitializeComponent();
        }
        QLTK_BLL bll = new QLTK_BLL();
        private void picture_Invisible_Click(object sender, EventArgs e)
        {
            picture_Visible.BringToFront();
            txtPass.PasswordChar = '•';
        }

        private void picture_Visible_Click(object sender, EventArgs e)
        {
            picture_Invisible.BringToFront();
            txtPass.PasswordChar = '\0';
        }

        public void GetChiTietTaiKhoan(int id)
        {
            QLHA_DAL qLHA_DAL = new QLHA_DAL(); 
            var s = bll.GetChiTietTaiKhoan_ByID_BLL(id);
            txtName.Text = s.HoTen;
            txtPhone.Text = s.SDT;
            txtEmail.Text = s.Email;
            dtpNS.Value = s.NgaySinh;
            txtAddress.Text = s.DiaChi;
            if (s.GioiTinh == true)
            {
                rdbMale.Checked = true;
            }
            else
            {
                rdbFemale.Checked = true;
            }
            txtUserName.Text=s.UserName;
            txtPass.Text = s.Pass;
           ptbImage.Image = qLHA_DAL.ConverByteToTmage(s.AnhDaiDien);

        }

        public void UpdatePass()
        {
            bll.UpdatePass_BLL(txtNewPass.Text);
        }
        public bool SetGioiTinh()
        {
            if (rdbMale.Checked)
                return true;
            else return false;
        }
        public void UpadteInformation()
        {
            PictureBox pi = new PictureBox();
            QLHA_DAL qLHA_DAL = new QLHA_DAL();
            ChiTietTaiKhoan ct = new ChiTietTaiKhoan();
            pi.Image = qLHA_DAL.ConverByteToTmage(ct.AnhDaiDien);
            ct.ID = FLogin.account.ID;
            ct.HoTen = txtName.Text;
            ct.SDT = txtPhone.Text;
            ct.NgaySinh = Convert.ToDateTime(dtpNS.Value.ToString());
            ct.GioiTinh = SetGioiTinh();
            ct.DiaChi = txtAddress.Text;
            ct.Email = txtEmail.Text;
            ct.AnhDaiDien = qLHA_DAL.ImageToByteArray(ptbImage.Image);
            bll.UpdateInformation_BLL(ct);
        }
        private void butUpdate_Click(object sender, EventArgs e)
        {

             UpadteInformation();
            MessageBox.Show("Cập nhập thành công", "Thông báo", MessageBoxButtons.OK);
            


        }
        private void butChangePass_Click(object sender, EventArgs e)
        {
            UpdatePass();
            MessageBox.Show("Thay đổi mật khẩu thành công");
           
        }
        private void butAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "png file|*.PNG";
            if (open.ShowDialog() == DialogResult.OK)
            {  
                ptbImage.ImageLocation = open.FileName;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
