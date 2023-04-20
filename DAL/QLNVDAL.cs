using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_PBL3.DAL
{
    internal class QLNVDAL
    {
        public dynamic GetAllNV()
        {
            //List<ChiTietTaiKhoan> l = new List<ChiTietTaiKhoan>();
            QLDB db = new QLDB();
            var s= db.ChiTietTaiKhoans.Select(p => new {p.ID, p.HoTen, p.NgaySinh, p.DiaChi}).ToList();
           

            return s;
        } 
    }
}
