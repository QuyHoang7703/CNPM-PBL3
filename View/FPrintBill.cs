using CNPM_PBL3.BLL;
using Microsoft.Reporting.WinForms;
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
    public partial class FPrintBill : Form
    {
        public FPrintBill()
        {
            InitializeComponent();
        }
        public int idKH;
        QLHD_BLL bll = new QLHD_BLL();

        private void FPrintBill_Load(object sender, EventArgs e)
        {
            //reportViewer1.Visible = false;
            this.reportViewer1.RefreshReport();
            //QLDB db = new QLDB();


            //var s1 = db.ChiTietHoaDons.Where(p => p.MaHD == 8).Select(p => new
            //{
            //    p.MaSP,
            //    p.SoLuong,
            //    p.DonGia,
            //    p.ThanhTien,
            //    p.HoaDon.TaiKhoan.UserName,
            //    p.HoaDon.NgayBan,
            //    p.HoaDon.KhachHang.MaKH,
            //    p.HoaDon.KhachHang.HoTenKH,
            //    p.HoaDon.MaHD,
            //    p.HoaDon.KhachHang.DiaChi,
            //    p.HoaDon.KhachHang.SDT,
            //    p.HoaDon.TaiKhoan.ID,
            //    p.HoaDon.TaiKhoan.ChiTietTaiKhoan.HoTen
            //}).ToList();
            int maHD = bll.GetMaHoaDon_ByMaKH(idKH);
            var s = bll.GetDetailBillForPrint_BLL(maHD);
            reportViewer1.LocalReport.ReportPath = "./PrintBill.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource("DataSetBill", s);
             
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            
            this.reportViewer1.RefreshReport();
            
        }
    }
}
