using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_PBL3.DAL
{
    internal class QLNVDAL
    {
        public dynamic GetAllNVDAL()
        {
            
            QLDB db = new QLDB();
            var s= db.ChiTietTaiKhoans.Where(p=>p.TaiKhoan.Role.Contains("Nhân viên")).Select(p => 
            new {p.ID, p.TaiKhoan.UserName, p.HoTen, p.NgaySinh, p.DiaChi, p.SDT, p.GioiTinh}).ToList();
           

            return s;
        } 
        public void AddNV(TaiKhoan t)
        {

        } 
    }
}
