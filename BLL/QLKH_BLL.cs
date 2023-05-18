using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CNPM_PBL3.DAL;

namespace CNPM_PBL3.BLL
{
    internal class QLKH_BLL
    {
        //QLKH_DAL dal = new QLKH_DAL();
        public dynamic GetAllKH_BLL()
        {
            QLDB db = new QLDB();
            var s = db.KhachHangs.Select(p => new { p.MaKH, p.HoTenKH, p.NgaySinh, p.SDT, p.DiaChi, p.GioiTinh }).ToList();

            return s;
        }
        public List<KhachHang> GetAllKH_BLLl()
        {
            List<KhachHang> list = new List<KhachHang>();
            foreach(var i in GetAllKH_BLL())
            {
                list.Add(i);
            }
            return list;
        }
        
        public void AddKhachHang_BLL(KhachHang khachHang)
        {  
            QLDB db = new QLDB();
            db.KhachHangs.Add(khachHang);
            db.SaveChanges();
        }
        public int GetIdKhachHang_BLL(KhachHang khachHang)
        {
            
            return khachHang.MaKH;
        }
    }
}
