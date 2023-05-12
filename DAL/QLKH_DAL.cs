using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_PBL3.DAL
{
    internal class QLKH_DAL
    {
        QLDB db = new QLDB();
        public dynamic GetAllKH_DAL()
        {
           
            var s = db.KhachHangs.Select(p => new {p.MaKH, p.HoTenKH, p.NgaySinh, p.SDT, p.DiaChi, p.GioiTinh}).ToList();
          
            return s;
        }
        public void AddKhachHang_DAL(KhachHang khachhang)
        {
            db.KhachHangs.Add(khachhang);
            db.SaveChanges();
        }
    }
}
