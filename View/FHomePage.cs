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
    public partial class FHomePage : Form
    {
        public FHomePage()
        {
            InitializeComponent();
            GetCBBThuongHieu();
            GetCBBGioiTinhSP();
            GetCBBBoMayNangLuong();
            GetMauMatSo();
            GetHinhDangMatSo();
            GetChatLieuMatKinh();
            GetChatLieuDay();
            GetXuatXu();
            GetGiaSP();
            ctbCancel.Visible = true;
          
        }
        QLSP_BLL bll = new QLSP_BLL();
        QLHD_BLL qLHD = new QLHD_BLL();
        public void showHinhAnh(dynamic list)
        {
            foreach (var item in list)
            {
                //qLSP.tenThuongHieu_DAL(item.MaThuongHieu)
                FUserControlClock fUserControlClock = new FUserControlClock();
                fUserControlClock.ChiTiet = item.ThuongHieu.TenThuongHieu + " - " + item.MaSP + " - " + item.GioiTinhSP + "\n" +
                                            item.ChatLieuMatKinh + " - " + item.BoMayNangLuong;
                fUserControlClock.GiaSanPham = Convert.ToString(item.GiaSP) + "đ";
                fUserControlClock.HinhAnh = item.HinhAnh;
                fUserControlClock.MaSanPham = item.MaSP;
                if (item.MaKhuyenMai != null)
                {
                    float giaTriKM = qLHD.GetGiaTriKhuyenMai(item.MaSP);
                    fUserControlClock.KhuyenMai = "Khuyến mãi " + giaTriKM.ToString() + "%\n"
                        + (qLHD.GetDonGia(item.MaSP) - qLHD.GetDonGia(item.MaSP) * (decimal)giaTriKM / 100).ToString() + "đ"; ;
                }
                else
                {
                    fUserControlClock.KhuyenMai = null;
                }
                flowLayoutPanel1.Controls.Add(fUserControlClock);
            }
        }
        public void GetCBBThuongHieu()
        {
            cbbThuongHieu.Items.Add("Tất cả");
            cbbThuongHieu.Items.AddRange(bll.GetListCBBThuongHieu().ToArray());
        }
        public void GetCBBGioiTinhSP()
        {
            cbbGioiTinh.Items.Add("Tất cả");
            cbbGioiTinh.Items.AddRange(bll.GetGioiTinhSP_BLL().Distinct().ToArray());
        }
        public void GetCBBBoMayNangLuong()
        {
            cbbBoMayNangLuong.Items.Add("Tất cả");
            cbbBoMayNangLuong.Items.AddRange(bll.GetBoMayNangLuong_BLL().Distinct().ToArray());
        }
        public void GetMauMatSo()
        {
            cbbMauMatSo.Items.Add("Tất cả");
            cbbMauMatSo.Items.AddRange(bll.GetMauMatSo_BLL().Distinct().ToArray());
        }
        public void GetHinhDangMatSo()
        {
            cbbHinhDangMatSo.Items.Add("Tất cả");
            cbbHinhDangMatSo.Items.AddRange(bll.GetHinhDangMatSo_BLL().Distinct().ToArray());
        }
        public void GetChatLieuMatKinh()
        {
            cbbChatLieuMatKinh.Items.Add("Tất cả");
            cbbChatLieuMatKinh.Items.AddRange(bll.GetChatLieuMatKinh_BLL().Distinct().ToArray());
        }
        public void GetChatLieuDay()
        {
            cbbChatLieuDay.Items.Add("Tất cả");
            cbbChatLieuDay.Items.AddRange(bll.GetChatLieuDay_BLL().Distinct().ToArray());
        }
        public void GetXuatXu()
        {
            cbbXuatXu.Items.Add("Tất cả");
            cbbXuatXu.Items.AddRange(bll.GetXuatXu_BLL().Distinct().ToArray());
        }
        public void GetGiaSP()
        {
            cbbGiaSP.Items.Add("Tất cả");
            cbbGiaSP.Items.Add("10.0000-50.0000");
            cbbGiaSP.Items.Add("50.0000-150.0000");
            cbbGiaSP.Items.Add("150.0000-250.0000");
            cbbGiaSP.Items.Add("Trên 250.0000 ");
        }
        public void showTimKiem(ComboBox cbbTH, ComboBox cbbGT, ComboBox cbbBMNL, ComboBox cbbMMS, ComboBox cbbHDMS, ComboBox cbbCLMK, ComboBox cbbCLD, ComboBox cbbXX, ComboBox cbbgsp)
        {
            showHinhAnh(bll.TimKiemTrangChu_BLL(cbbTH, cbbGT, cbbBMNL, cbbMMS, cbbHDMS, cbbCLMK, cbbCLD, cbbXX, cbbgsp));

        }

        private void butTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsearch.Text))
            {
                flowLayoutPanel1.Controls.Clear();
                showTimKiem(cbbThuongHieu, cbbGioiTinh, cbbBoMayNangLuong, cbbMauMatSo, cbbHinhDangMatSo, cbbChatLieuMatKinh, cbbChatLieuDay, cbbXuatXu, cbbGiaSP);
            }
            else
            {
                flowLayoutPanel1.Controls.Clear();
                showHinhAnh(bll.TimKiemTrenTXTTrangChu_BLL(txtsearch.Text, bll.TimKiemTrangChu_BLL(cbbThuongHieu, cbbGioiTinh, cbbBoMayNangLuong, cbbMauMatSo, cbbHinhDangMatSo, cbbChatLieuMatKinh, cbbChatLieuDay, cbbXuatXu, cbbGiaSP)));
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FHomePage_Load(object sender, EventArgs e)
        {
            showTimKiem(cbbThuongHieu, cbbGioiTinh, cbbBoMayNangLuong, cbbMauMatSo, cbbHinhDangMatSo, cbbChatLieuMatKinh, cbbChatLieuDay, cbbXuatXu, cbbGiaSP);
        }

        private void butAll_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            cbbThuongHieu.SelectedIndex = 0;
            cbbGioiTinh.SelectedIndex = 0;
            cbbBoMayNangLuong.SelectedIndex = 0;
            cbbMauMatSo.SelectedIndex = 0;
            cbbHinhDangMatSo.SelectedIndex = 0;
            cbbChatLieuMatKinh.SelectedIndex = 0;
            cbbChatLieuDay.SelectedIndex = 0;
            cbbXuatXu.SelectedIndex = 0;
            cbbGiaSP.SelectedIndex = 0;
            showTimKiem(cbbThuongHieu, cbbGioiTinh, cbbBoMayNangLuong, cbbMauMatSo, cbbHinhDangMatSo, cbbChatLieuMatKinh, cbbChatLieuDay, cbbXuatXu, cbbGiaSP);
        }

        private void cbbThuongHieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ctbCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
