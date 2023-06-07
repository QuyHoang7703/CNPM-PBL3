using CNPM_PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_PBL3.BLL
{
    internal class QLNV_BLL
    {
      
        public List<dynamic> GetAllNV_BLL()
        {
            using (QLDB db = new QLDB())
            {
                var s = db.TaiKhoans.Where(p => p.Role == "Nhân viên").Select(p => new { p.ID, p.UserName, p.ChiTietTaiKhoan.HoTen, p.ChiTietTaiKhoan.SDT }).ToList();
                List<dynamic> list = new List<dynamic>();
                list.AddRange(s);
                return list;
            }

        }
        public List<dynamic> GetNV_ByTxtSearch(string text)
        {
            List<dynamic> list = new List<dynamic>();
            if (string.IsNullOrEmpty(text))
            {
                list=GetAllNV_BLL();
            }
            else
            {
                foreach (var s in GetAllNV_BLL())
                {
                    int number;
                    bool check = int.TryParse(text, out number);
                    if (check && (s.ID == number ) || s.HoTen.Contains(text) || s.UserName.Contains(text) || s.SDT.Contains(number.ToString())) 
                        list.Add(s);
                }
            }
            
            return list;
        }      
        public void AddNV_BLL(TaiKhoan t, ChiTietTaiKhoan ct)
        {
            using (QLDB db = new QLDB())
            {
                db.TaiKhoans.Add(t);
                ct.TaiKhoan = t;
                db.ChiTietTaiKhoans.Add(ct);
                db.SaveChanges();
            }
        }
        public void DeleteNV_BLL(int id)
        {
            using (QLDB db = new QLDB())
            {
                var s1 = db.ChiTietTaiKhoans.Find(id);
                db.ChiTietTaiKhoans.Remove(s1);
                var s2 = db.TaiKhoans.Find(id);
                db.TaiKhoans.Remove(s2);
                db.SaveChanges();

            }
        }
        public ChiTietTaiKhoan GetDetailStaff_BLL(int id)
        {
            QLTK_BLL bll = new QLTK_BLL();
            return bll.GetChiTietTaiKhoan_ByID_BLL(id);
        }
       
        public dynamic SortBy_BLL(string sortBy, string direction)
        {
            QLDB db = new QLDB();
            var s = db.TaiKhoans.Where(p => p.Role == "Nhân viên").Select(p => new { p.ID, p.UserName, p.ChiTietTaiKhoan.HoTen, p.ChiTietTaiKhoan.SDT }).ToList();
            if (direction == "Tăng dần")
            {
                return s.OrderBy(p => p.GetType().GetProperty(sortBy).GetValue(p, null)).ToList();
            }
            else
            {
                return s = s.OrderByDescending(p => p.GetType().GetProperty(sortBy).GetValue(p, null)).ToList();
            }
        }
    }
}
