using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_PBL3.DAL
{
    internal class QLTK_DAL
    {
        QLDB db = new QLDB();
        public List<TaiKhoan> GetDBTaiKhoan()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            var s = db.TaiKhoans.Select(p => p).ToList();
            list = s;
            return list;
        }
        public dynamic GetDL(string username)
        {
            QLDB db = new QLDB();
            var s = db.ChiTietTaiKhoans.Select(p => new { p.HoTen, p.SDT, p.NgaySinh, p.GioiTinh, p.DiaChi, p.TaiKhoan.UserName, p.TaiKhoan.Pass });
            return s;
        }
        public void UpdatePass_DAL(TaiKhoan t, string pass)
        {
            var s = db.TaiKhoans.Find(t.ID);
            s.Pass = pass;
            db.SaveChanges();
        }
        
        public void UpdateInformation_DAL(ChiTietTaiKhoan ct)
        {
            using(QLDB x = new QLDB())
            {
                var s = db.ChiTietTaiKhoans.Find(ct.ID);
                s.HoTen = ct.HoTen;
                s.SDT = ct.SDT;
                s.NgaySinh = ct.NgaySinh;
                s.GioiTinh = ct.GioiTinh;
                s.DiaChi = ct.DiaChi;
                s.AnhDaiDien = ct.AnhDaiDien;
                x.SaveChanges();
            }
           

        }
    }
}
