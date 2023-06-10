using CNPM_PBL3.BLL;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace CNPM_PBL3.View
{
    public partial class FStatistical : Form
    {
        public FStatistical()
        {
            InitializeComponent();
            dtpngay.Value = DateTime.Now;
            dtpthang.Value = DateTime.Now;
            dtpnam.Value = DateTime.Now;
            doangThuTheoNgay(DateTime.Now);
            doanhThuTHeoThang(DateTime.Now);
            BieuDo(DateTime.Now);
           
        }
        QLSP_BLL sp_bll = new QLSP_BLL();
        QLHD_BLL hd_bll = new QLHD_BLL();
        QLKH_BLL kh_bll = new QLKH_BLL();

        public String SoSanh(int a, int b)
        {
            int t;
            t = b - a;
            if (t == 0)
            {
                return null;
            }
            else
            {
                if (t < 0)
                {
                    return "Giảm " + Convert.ToString(Math.Round(Math.Abs(((double)(b - a) / a)) * 100, 2));
                }
                else
                {
                    if (a == 0)
                        return "Tăng " + Convert.ToString(100);
                    else
                        return "Tăng " + Convert.ToString(Math.Round(((double)(b - a) / a) * 100, 2));
                }
            }
        }

        public String SoSanhtien(decimal a, decimal b)
        {
            decimal t;
            t = b - a;
            if (t == 0)
            {
                return null;
            }
            else
            {
                if (t < 0)
                {
                    return "Giảm " + Convert.ToString(Math.Round(Math.Abs(((decimal)(b - a) / a)) * 100, 2));
                }
                else
                {
                    if (a == 0)
                        return "Tăng " + Convert.ToString(100);
                    else
                        return "Tăng " + Convert.ToString(Math.Round(((decimal)(b - a) / a) * 100, 2));
                }
            }
        }
        public void doangThuTheoNgay(DateTime dateTime)
        {
            // trong ngày

            List<int> list = hd_bll.GetMAHDTrongNgay_BLL(dateTime);
            int tonghd = list.Count;
            int tongsp = sp_bll.GetTongSP_BLL(list);
            int tongkh = kh_bll.TongKHTrongNgay_BLL(list);
            decimal tongtien = hd_bll.TongTienTrongNgay_BLL(list);
            lableTongSanPham.Text = tongsp.ToString() + " Sản Phẩm";
            lableTongKhachHang.Text = tongkh.ToString() + " Khách Hàng";
            lableDoanhThu.Text = tongtien.ToString("N0") + "đ";
            lableTongHoaDon.Text = tonghd.ToString() + " Hóa Đơn";

            // so sánh tăng giảm trong ngày
            List<int> list1 = hd_bll.GetMAHDTrongNgay_BLL(dateTime.AddDays(-1));
            int tonghd1 = list1.Count;
            int tongsp1 = sp_bll.GetTongSP_BLL(list1);
            int tongkh1 = kh_bll.TongKHTrongNgay_BLL(list1);
            decimal tongtien1 = hd_bll.TongTienTrongNgay_BLL(list1);
            if (SoSanh(tonghd1, tonghd) == null)
                TGHD.Text = "Không tăng giảm" + "\n So với ngày trước";
            else
                TGHD.Text = SoSanh(tonghd1, tonghd) + "%" + "\n so với ngày trước";
            if (SoSanh(tongsp1, tongsp) == null)
                TGSP.Text = "Không tăng giảm" + "\n So với ngày trước";
            else
                TGSP.Text = SoSanh(tongsp1, tongsp) + "%" + "\n so với ngày trước";
            if (SoSanh(tongkh1, tongkh) == null)
                TGKH.Text = "Không tăng giảm" + "\n So với ngày trước";
            else
                TGKH.Text = SoSanh(tongkh1, tongkh) + "%" + "\n so với ngày trước";
            if (SoSanhtien(tongtien1, tongtien) == null)
                TGDT.Text = "Không tăng giảm" + "\n So với ngày trước";
            else
                TGDT.Text = SoSanhtien(tongtien1, tongtien) + "%" + "\n so với ngày trước";
           
        }
        public void doanhThuTHeoThang(DateTime dateTime)
        {
            // trong tháng
            List<int> li = hd_bll.GetMAHDTrongThang_BLL(dateTime);
            int tonghdtrongthang = li.Count;
            int tongkhtrongthang = kh_bll.TongKHTrongNgay_BLL(li);
            int tongsptrongthang = sp_bll.GetTongSP_BLL(li);
            decimal tongtientrongthang = hd_bll.TongTienTrongNgay_BLL(li);
            lableTongHoaDonT.Text = tonghdtrongthang.ToString() + " Hóa Đơn";
            lableTongSanPhamT.Text = tongsptrongthang.ToString() + " Sản Phẩm";
            lableTongKhachHangT.Text = tongkhtrongthang.ToString() + " Khách Hàng";
            lableDoanhThuT.Text = tongtientrongthang.ToString("N0") + "đ";
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
                labelSP1.Text = masp1 + " - " + sl1.ToString() + " Sản Phẩm";

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
           
          // hienThi(monthCalendar1.SelectionStart);
           // BieuDo();
            
        }

      
        public void BieuDo(DateTime datetime)
        {
            labelNam.Text = datetime.Year.ToString();
            // làm mới và tạo series mới
            ChartBDCC.Series.Clear();
            ChartBDCC.ChartAreas[0].AxisX.Interval = 1;
            Series ChartBDC = new Series();
            ChartBDC.LegendText = "Sản Phẩm";


            // thêm dữ liệu
            for (int i = 0; i <= 11; i++)
            {
               int thang = i + 1;
                DateTime dt = new DateTime(datetime.Year, thang, 1);
                List<int> lii = hd_bll.GetMAHDTrongThang_BLL(dt);
                int tongsptrongthang1 = sp_bll.GetTongSP_BLL(lii);
                ChartBDC.Points.AddXY(thang, tongsptrongthang1);
                ChartBDC.Points[i].Label = tongsptrongthang1.ToString();
            }
            
            ChartBDCC.Series.Add(ChartBDC);
            ChartBDCC.ChartAreas[0].AxisX.Minimum = 1;
            ChartBDCC.ChartAreas[0].AxisX.Maximum = 12;

            ChartBDCC.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            ChartBDCC.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            ChartBDCC.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            ChartBDCC.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

        }

        private void dtpngay_ValueChanged(object sender, EventArgs e)
        {
            doangThuTheoNgay(dtpngay.Value);
        }

        private void dtpthang_ValueChanged(object sender, EventArgs e)
        {
            doanhThuTHeoThang(dtpthang.Value);
        }

        private void dtpnam_ValueChanged(object sender, EventArgs e)
        {
            BieuDo(dtpnam.Value);
        }
    }
}
