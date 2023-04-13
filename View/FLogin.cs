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
            //if (guna2TextBox_pasword.PasswordChar == '\0')
            //{
            //    picture_Visible.BringToFront();
            //    guna2TextBox_pasword.PasswordChar = '•';
            //}
        }

        private void picture_Visible_Click_1(object sender, EventArgs e)
        {
            picture_Invisible.BringToFront();
            txtPass.PasswordChar = '\0';
            //if (guna2TextBox_pasword.PasswordChar == '•')
            //{
            //    picture_Invisible.BringToFront();
            //    guna2TextBox_pasword.PasswordChar = '\0';
            //}
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
            QLTKBLL bll = new QLTKBLL();
            TaiKhoan t = bll.GetTaiKhoan(txtUserName.Text, txtPass.Text);
            if (checkRole(t)==1)
            {
                FMainManager f = new FMainManager();
                this.Hide();
                f.Show();
            }
            else if(checkRole(t)==0) 
            {

            }else
            {
                MessageBox.Show("Tài khoản và mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
