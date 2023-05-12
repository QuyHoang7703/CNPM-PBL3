using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Windows.Forms;
    

namespace CNPM_PBL3.DAL
{
    internal class QLNV_DAL
    {
       
        public dynamic GetAllNV_DAL()
        {
            using (QLDB db = new QLDB())
            {
                var s = db.TaiKhoans.Where(p => p.Role == "Nhân viên").Select(p => new { p.ID, p.UserName, p.ChiTietTaiKhoan.HoTen, p.ChiTietTaiKhoan.SDT }).ToList();
                return s;
            }
          
       
        }
        //public dynamic GetNVByTxtSearch_DAL(string text)
        //{
        //    using(QLDB db = new QLDB())
        //    {
        //        var s = db.TaiKhoans.Where(p => p.ChiTietTaiKhoan.HoTen.StartsWith(text) || p.UserName==text).Select(p => new { p.ID, p.UserName, p.ChiTietTaiKhoan.HoTen, p.ChiTietTaiKhoan.SDT });
        //        return s;
        //    }
        //}
        public dynamic GetDetailStaff_DAL(int id)
        {
            QLTK_DAL dal = new QLTK_DAL();
            return dal.GetChiTietTaiKhoan_ByID_DAL(id);
        }
        public void AddNV_DAL(TaiKhoan t, ChiTietTaiKhoan ct)
        {
            
                using (QLDB db = new QLDB())
                {
                    db.TaiKhoans.Add(t);
                   // var s = db.TaiKhoans.Find(t.ID);
                    ct.TaiKhoan = t;
                    db.ChiTietTaiKhoans.Add(ct);
                    db.SaveChanges();
                }
              
        } 
        public void DeleteNV_DAL(int id)
        {
            using(QLDB db = new QLDB())
            {
                var s1 = db.ChiTietTaiKhoans.Find(id);
                db.ChiTietTaiKhoans.Remove(s1);
                var s2 = db.TaiKhoans.Find(id);
                db.TaiKhoans.Remove(s2);
                db.SaveChanges();

            }
        }
        //public void SortBy_DAL(string columnName, string direction)
        //{
        //    using (QLDB db = new QLDB())
        //    {

        //    }


        //}
        public dynamic SortBy_DAL(string sortBy, string direction)
        {
            QLDB db = new QLDB();
            var s = db.TaiKhoans.Where(p => p.Role == "Nhân viên").Select(p => new { p.ID, p.UserName, p.ChiTietTaiKhoan.HoTen, p.ChiTietTaiKhoan.SDT }).ToList();
            //var s = GetAllNV_DAL();
            //s= s.ToList();
            if (direction == "Tăng dần")
            {
                return s.OrderBy(p => p.GetType().GetProperty(sortBy).GetValue(p, null)).ToList();
                //return s = s.OrderBy(s => s.ID).ToList();
                //var s = typeof(dynamic).GetProperty(sortBy);
                //return s.OrderBy(p => propertyInfo.GetValue(p, null)).ToList();

            }
            else
            {
                return s = s.OrderByDescending(p => p.GetType().GetProperty(sortBy).GetValue(p, null)).ToList();

            }
        }

    }
}
