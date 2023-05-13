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
using System.Web.WebSockets;
using System.Windows.Forms;

namespace CNPM_PBL3.View
{
    public partial class FDetailStaff : Form
    {
        public FDetailStaff()
        {
            InitializeComponent();
            SetCBBRole();
        }
        public delegate void Mydel(dynamic a);
        public Mydel d { get; set; }
        QLNV_BLL bll = new QLNV_BLL();
        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void SetCBBRole()
        {
            cbbRole.Items.Add("Nhân viên");
            cbbRole.Items.Add("Quản lí");
        }
        public void Add()
        {
            if (cbbRole.SelectedItem != null)
            {
                TaiKhoan t = new TaiKhoan()
                {
                    UserName = txtUserName.Text,
                    Pass = txtPass.Text,
                    Role = cbbRole.SelectedItem.ToString()
                    //Role="Nhân viên"
                };
                QLHA ha = new QLHA();
                bool gender = false;
                if (rdbMale.Checked)
                {
                    gender = true;
                }
                ChiTietTaiKhoan ct = new ChiTietTaiKhoan()
                {
                    Email = txtEmail.Text,
                    HoTen = txtName.Text,
                    SDT = txtPhone.Text,
                    DiaChi = txtAddress.Text,
                    GioiTinh = gender,
                    NgaySinh = Convert.ToDateTime(dtpNS.Value.ToString()),
                    AnhDaiDien = ha.ImageToByteArray(ptbAnhDaiDien.Image)
                };
                bll.AddNV_BLL(t, ct);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
                d(bll.GetAllNV_BLL());
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chức vụ", "THÔNG BÁO");
                return;
            }
                
                     
        }
        public void GetDetailStaff(int id)
        {
            var s =bll.GetDetailStaff_BLL(id);
            QLHA qLHA_DAL = new QLHA();
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
            txtUserName.Text = s.UserName;
            txtPass.Text = s.Pass;
            ptbAnhDaiDien.Image = qLHA_DAL.ConverByteToTmage(s.AnhDaiDien);

        }
        private void butOK_Click(object sender, EventArgs e)
        {
            try
            {
                Add();             
            }
            catch (Exception)
            {
                if(txtUserName.Text=="" && txtPass.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ tài khoản và mật khẩu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else if (txtPass.Text == "")
                {
                    MessageBox.Show("Không được để trống mật khẩu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else if(txtUserName.Text == "")
                {
                    MessageBox.Show("Không được để trống tài khoản ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void butAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "png file|*.PNG";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ptbAnhDaiDien.ImageLocation = open.FileName;
            }
        }
    }
}
