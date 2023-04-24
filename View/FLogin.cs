using CNPM_PBL3.BLL;
using CNPM_PBL3.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_PBL3
{
    public partial class FLogin : Form
    {
        QLTK_BLL bll = new QLTK_BLL();
        public static TaiKhoan account;
        public FLogin()
        {
            InitializeComponent();
        }

        private void guna2Button_Forgot_Click(object sender, EventArgs e)
        {
            panel_login.Visible = false;
        }

        private void guna2Button_login_Click_1(object sender, EventArgs e)
        {
            panel_login.Visible = true;
        }

        private void picture_Visible_Click(object sender, EventArgs e)
        {
            picture_Invisible.BringToFront();
            txtPass.PasswordChar = '\0';
        }

        private void picture_Invisible_Click_1(object sender, EventArgs e)
        {
            picture_Visible.BringToFront();
            txtPass.PasswordChar = '•';
        }
        public int checkRole(TaiKhoan t)
        {
            if (t != null)
            {
                if (t.Role == "Quản lí")
                    return 1;
                else
                    return 0;
            }
            else
            {
                return -1;
            }
        }
        private void butLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUserNameLogin.Text == "")
            {
                MessageBox.Show("Không để trống tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserNameLogin.Focus();
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Không để trống mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPass.Focus();
            }
            else
            {
                account = bll.GetTaiKhoan(txtUserNameLogin.Text, txtPass.Text);
                if (checkRole(account) == 1)
                {
                    FMainManager f = new FMainManager();
                    this.Hide();
                    f.Show();
                }
                if (checkRole(account) == 0)
                {

                }
            }
        }
        Random Randomrandom = new Random();
        int otp;

        private void butForgot_Click(object sender, EventArgs e)
        {
            bll = new QLTK_BLL();
            if (txtUserNameForgot.Text == "")
            {
                MessageBox.Show("Không để trống tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserNameForgot.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Không để trống email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
            }
            else
            {
                if (bll.GetTaiKhoanByEmail(txtUserNameForgot.Text, txtEmail.Text) == 1)
                {
                    try
                    {
                        otp = Randomrandom.Next(100000, 999999);
                        var fromAddress = new MailAddress("tranthangkhuong203@gmail.com");
                        var toAddress = new MailAddress(txtEmail.ToString());
                        const string frompass = "kuiynitbihpxhtqw";
                        const string subject = "Mật khẩu mới của bạn là:";
                        string body = otp.ToString();
                        var smtp = new SmtpClient
                        {
                            Host = "smtp.gmail.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(fromAddress.Address, frompass),
                            Timeout = 200000
                        };
                        using (var message = new MailMessage(fromAddress, toAddress)
                        {
                            Subject = subject,
                            Body = body
                        })
                        {
                            smtp.Send(message);
                        }
                        MessageBox.Show("OTP đã được gửi" + otp);
                        bll.updatePass(bll.getIdByUserName(txtUserNameForgot.Text), otp.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("OTP chưa được gửi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
