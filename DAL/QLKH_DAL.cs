using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_PBL3.DAL
{
    internal class QLKH_DAL
    {
        QLDB qLDB = new QLDB();
        public dynamic GetAllKH_DAL()
        {
            var s = qLDB.KhachHangs.Select(p => new {p.MaKH, p.HoTen, p.NgaySinh, p.SDT, p.DiaChi, p.GioiTinh}).ToList();
            return s;
        }
        public void AddKhachHang_DAL(KhachHang khachhang)
        {
            qLDB.KhachHangs.Add(khachhang);
            qLDB.SaveChanges();
        }
    }
}
