﻿using CNPM_PBL3.BLL;
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
            showHinhAnh(qLSP.GetAllSP2_DAL());
        }
        QLSP_DAL qLSP = new QLSP_DAL();
        QLSP_BLL bll = new QLSP_BLL();
        QLHD_BLL qLHD = new QLHD_BLL();
        public void showHinhAnh(dynamic list)
        {
            foreach (var item in list)
            {
                FUserControlClock fUserControlClock = new FUserControlClock();
                fUserControlClock.chiTiet = qLSP.tenThuongHieu_DAL(item.MaThuongHieu) + " - " + item.MaSP + " - " + item.GioiTinhSP + "\n" +
                    item.ChatLieuMatKinh + " - " + item.BoMayNangLuong + " - " + item.DuongKinhMatSo + "mm";
                fUserControlClock.GiaSP = Convert.ToString(item.GiaSP) + "đ";
                fUserControlClock.hinhAnh = item.HinhAnh;
                fUserControlClock.MSP = item.MaSP;
                if (item.MaKhuyenMai != null)
                {
                    float giaTriKM = qLHD.GetGiaTriKhuyenMai(item.MaSP);
                    fUserControlClock.khuyenmai = "Khuyến mãi " + giaTriKM.ToString()+ "%\n"
                        + (qLHD.GetDonGia(item.MaSP) - qLHD.GetDonGia(item.MaSP) * (decimal)giaTriKM / 100).ToString() + "đ"; ;
                }
                else
                {
                    fUserControlClock.khuyenmai = null;
                }
                flowLayoutPanel1.Controls.Add(fUserControlClock);
            }
        }
        public void GetCBBThuongHieu()
        {
            cbbThuongHieu.Items.Add("");
            cbbThuongHieu.Items.AddRange(bll.GetListCBBThuongHieu().ToArray());
        }
        public void GetCBBGioiTinhSP()
        {
            cbbGioiTinh.Items.Add("");
            cbbGioiTinh.Items.AddRange(bll.GetGioiTinhSP_BLL().Distinct().ToArray());
        }
        public void GetCBBBoMayNangLuong()
        {
            cbbBoMayNangLuong.Items.Add("");
            cbbBoMayNangLuong.Items.AddRange(bll.GetBoMayNangLuong_BLL().Distinct().ToArray());
        }
        public void GetMauMatSo()
        {
            cbbMauMatSo.Items.Add("");
            cbbMauMatSo.Items.AddRange(bll.GetMauMatSo_BLL().Distinct().ToArray());
        }
        public void GetHinhDangMatSo()
        {
            cbbHinhDangMatSo.Items.Add("");
            cbbHinhDangMatSo.Items.AddRange(bll.GetHinhDangMatSo_BLL().Distinct().ToArray());
        }
        public void GetChatLieuMatKinh()
        {
            cbbChatLieuMatKinh.Items.Add("");
            cbbChatLieuMatKinh.Items.AddRange(bll.GetChatLieuMatKinh_BLL().Distinct().ToArray());
        }
        public void GetChatLieuDay()
        {
            cbbChatLieuDay.Items.Add("");
            cbbChatLieuDay.Items.AddRange(bll.GetChatLieuDay_BLL().Distinct().ToArray());
        }
        public void GetXuatXu()
        {
            cbbXuatXu.Items.Add("");
            cbbXuatXu.Items.AddRange(bll.GetXuatXu_BLL().Distinct().ToArray());
        }
        public void GetGiaSP()
        {
            cbbGiaSP.Items.Add("");
            cbbGiaSP.Items.Add("10.0000-300.0000");
            cbbGiaSP.Items.Add("300.0000-500.0000");
            cbbGiaSP.Items.Add("Trên 300.0000 ");
        }
        public void showTimKiem(ComboBox cbbTH, ComboBox cbbGT, ComboBox cbbBMNL, ComboBox cbbMMS, ComboBox cbbHDMS, ComboBox cbbCLMK, ComboBox cbbCLD, ComboBox cbbXX, ComboBox cbbgsp)
        {
            showHinhAnh(bll.TimKiemTrangChu_BLL(cbbTH, cbbGT, cbbBMNL, cbbMMS, cbbHDMS, cbbCLMK, cbbCLD, cbbXX, cbbgsp));

        }

        private void butTimKiem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            showTimKiem(cbbThuongHieu, cbbGioiTinh, cbbBoMayNangLuong, cbbMauMatSo, cbbHinhDangMatSo, cbbChatLieuMatKinh, cbbChatLieuDay, cbbXuatXu, cbbGiaSP);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            showHinhAnh(bll.TimKiemTrenTXTTrangChu_BLL(txtsearch.Text, bll.TimKiemTrangChu_BLL(cbbThuongHieu, cbbGioiTinh, cbbBoMayNangLuong, cbbMauMatSo, cbbHinhDangMatSo, cbbChatLieuMatKinh, cbbChatLieuDay, cbbXuatXu, cbbGiaSP)));
        }
    }
}
