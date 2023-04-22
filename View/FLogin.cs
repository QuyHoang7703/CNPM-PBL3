using CNPM_PBL3.BLL;
using CNPM_PBL3.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_PBL3
{
    public partial class FLogin : Form
    {
        QLTK_BLL bll = new QLTK_BLL();
        TaiKhoan t;
        public FLogin()
        {
            InitializeComponent();
        }

        private void guna2Button_ForgotPassword_Click(object sender, EventArgs e)
        {
            panel_login.Visible = false;
           
        }

        private void guna2Button_Login_Click(object sender, EventArgs e)
        {
            panel_login.Visible = true;
        }

        private void picture_Invisible_Click(object sender, EventArgs e)
        {
            picture_Visible.BringToFront();
            txtPass.PasswordChar = '•';
        }

        private void picture_Visible_Click_1(object sender, EventArgs e)
        {
            picture_Invisible.BringToFront();
            txtPass.PasswordChar = '\0';
        }
        public int checkRole(TaiKhoan t)
        {
            if (t != null)
            {
                if (t.Role == "Quản lí")
                    return 1;
                else
                    return 0;
            }else
            {
                return -1;
            }
        }
        private void butLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text =="" && txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (txtUserName.Text != "" && txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng điền mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                t = bll.GetTaiKhoan(txtUserName.Text, txtPass.Text);
                if (checkRole(t) == 1)
                {
                    FMainManager f = new FMainManager();
                    this.Hide();
                    f.account = t;
                    f.Show();
                }
                else if (checkRole(t) == 0)
                {

                }
                else
                {
                    txtUserName.Text = "";
                    txtPass.Text = "";
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           

            
        }
        //public void ReLoadChiTietTaiKhoan(ChiTietTaiKhoan ct)
        //{
        //    t.ChiTietTaiKhoan.HoTen = ct.HoTen;
        //}
    }
}
