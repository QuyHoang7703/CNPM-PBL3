﻿using CNPM_PBL3.BLL;
using CNPM_PBL3.DAL;
using CNPM_PBL3.DTO;
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
    public partial class FStatistical : Form
    {
        public FStatistical()
        {
            InitializeComponent();
            hienThi(DateTime.Now);
        }
        QLSP_BLL sp_bll = new QLSP_BLL();
        QLHD_BLL hd_bll = new QLHD_BLL();
        QLKH_BLL kh_bll = new QLKH_BLL();
        public void hienThi(DateTime dateTime)
        {
            // trong ngày

            List<int> list = hd_bll.GetMAHDTrongNgay_BLL(dateTime);
            int tonghd = list.Count;
            int tongsp = sp_bll.GetTongSP_BLL(list);
            int tongkh = kh_bll.TongKHTrongNgay_BLL(list);
            decimal tongtien = hd_bll.TongTienTrongNgay_BLL(list);
            lableTongSanPham.Text = tongsp.ToString() + " Sản Phẩm";
            lableTongKhachHang.Text = tongkh.ToString() + " Khách Hàng";
            lableDoanhThu.Text = tongtien.ToString() + "đ";
            lableTongHoaDon.Text = tonghd.ToString() + " Hóa Đơn";

            // trong tháng
            List<int> li = hd_bll.GetMAHDTrongThang_BLL(dateTime);
            int tonghdtrongthang = li.Count;
            int tongkhtrongthang = kh_bll.TongKHTrongNgay_BLL(li);
            int tongsptrongthang = sp_bll.GetTongSP_BLL(li);
            decimal tongtientrongthang = hd_bll.TongTienTrongNgay_BLL(li);
            lableTongHoaDonT.Text = tonghdtrongthang.ToString() + " Hóa Đơn";
            lableTongSanPhamT.Text = tongsptrongthang.ToString() + " Sản Phẩm";
            lableTongKhachHangT.Text = tongkhtrongthang.ToString() + " Khách Hàng";
            lableDoanhThuT.Text = tongtientrongthang.ToString() + "đ";

            // Top 4

            List<string> l = new List<string>();
            l = sp_bll.GetMaSPCoTrongThang_BLL(li);
            List<SanPham> lll = sp_bll.TongSPTrongThang_BLL(l, li);
            for (int i = 0; i < l.Count - 1; i++)
            {
                for (int j = i + 1; j < l.Count; j++)
                {
                    if (lll[j].soluong <= lll[i].soluong)
                    {
                        SanPham t = lll[j];
                        lll[j] = lll[i];
                        lll[i] = t;
                    }
                }
            }

            if (lll.Count < 4)
            {
                label5.Visible = false;
                guna2Panel1.Visible = false;

            }
            else
            {
                label5.Visible = true;
                guna2Panel1.Visible = true;
                int sl1 = lll[lll.Count - 1].soluong;
                string masp1 = lll[lll.Count - 1].masp;
                labelSP1.Text = masp1 +" - "+ sl1.ToString() +" Sản Phẩm";

                int sl2 = lll[lll.Count - 2].soluong;
                string masp2 = lll[lll.Count - 2].masp;
                labelSP2.Text = masp2 + " - " + sl2.ToString() + " Sản Phẩm";

                int sl3 = lll[lll.Count - 3].soluong;
                string masp3 = lll[lll.Count - 3].masp;
                labelSP3.Text = masp3 + " - " + sl3.ToString() + " Sản Phẩm";

                int sl4 = lll[lll.Count - 4].soluong;
                string masp4 = lll[lll.Count - 4].masp;
                labelSP4.Text = masp4 + " - " + sl4.ToString() + " Sản Phẩm";
              
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            hienThi(monthCalendar1.SelectionStart);
        }
    }
}
