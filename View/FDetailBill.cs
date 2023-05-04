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
    public partial class FDetailBill : Form
    {
        public FDetailBill()
        {
            InitializeComponent();
            SetCBBGioiTinh();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void SetCBBGioiTinh()
        {
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
        }
        public void GetChiTiet(dynamic t)
        {
            if (t != null)
            {
                txtHoTen.Text = t.KhachHang.HoTen;
                txtSDT.Text = t.KhachHang.SDT;
                txtDiaChi.Text = t.KhachHang.DiaChi;
                dtpNS.Value = t.KhachHang.NgaySinh;
                dtpNM.Value = t.NgayBan;
                if (t.KhachHang.GioiTinh == true)
                {
                    cbbGioiTinh.SelectedIndex = 0;
                }
                else
                {
                    cbbGioiTinh.SelectedIndex = 1;
                }
            }
            List<dynamic> list = new List<dynamic>();
            foreach(var i in t.ChiTietHoaDons)
            {
                var chitiet = new
                {
                    MaSanPham=i.MaSP,
                    SoLuong=i.SoLuong,
                    DonGia=i.DonGia,
                };
                list.Add(chitiet);
            }

            dgvCTHD.DataSource = list;

        }
    }
}
