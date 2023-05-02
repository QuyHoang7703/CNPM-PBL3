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
    public partial class FAddCustomer : Form
    {
        public FAddCustomer()
        {
            InitializeComponent();
            GetCBBGioiTinh();
        }
        QLKH_BLL bll = new QLKH_BLL();
        public void GetCBBGioiTinh()
        {
            CBBGioiTinh.Items.Clear();
            CBBGioiTinh.Items.Add("Nam");
            CBBGioiTinh.Items.Add("Nữ");
        }
        public void AddKachHang()
        {
            bool check = false;
            if(CBBGioiTinh.SelectedItem.ToString() == "Nam")
            {
                check = true;
            }
            else
            {
                check = false;
            }
            KhachHang khachHang = new KhachHang()
            {
                HoTen = txtHoTen.Text,
                SDT = txtSDT.Text,
                DiaChi = txtDiaChi.Text,
                GioiTinh = check,
                NgaySinh = Convert.ToDateTime(DTPKhachHang.Value)
            };
            bll.AddKhachHang_BLL(khachHang);
        }
        private void ButThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButLuu_Click(object sender, EventArgs e)
        {
            try
            {
                AddKachHang();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            catch (Exception)
            {
                if (string.IsNullOrEmpty(txtHoTen.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if(string.IsNullOrEmpty(txtSDT.Text))
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if(string.IsNullOrEmpty(txtDiaChi.Text))
                        {
                            MessageBox.Show("Vui lòng điền đầy đủ thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if(CBBGioiTinh.SelectedItem == null)
                            {
                                MessageBox.Show("Vui lòng điền đầy đủ thông tin ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }
    }
}
