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
        QLNV_DAL dal = new QLNV_DAL();
        public dynamic GetAllNV_BLL()
        {
            var s = dal.GetAllNV_DAL();
            return s;
        }
        public dynamic GetNV_ByTxtSearch(string text)
        {
            List<dynamic> list = new List<dynamic>();
            foreach (var s in GetAllNV_BLL())
            {
                int number;
                bool check = int.TryParse(text, out number);
                if ((check && s.ID==number) || s.HoTen==text || s.UserName==text) 
                    list.Add(s);
            }
            return list;
        }      
        public void AddNV_BLL(TaiKhoan t, ChiTietTaiKhoan ct)
        {
            dal.AddNV_DAL(t, ct);
        }
        public void DeleteNV_BLL(int id)
        {
            dal.DeleteNV_DAL(id);
        }
        public dynamic GetDetailStaff_BLL(int id)
        {
            return dal.GetDetailStaff_DAL(id);
        }
        //public void SortBy_BLL(string columnName, string direction)
        //{
        //    dal.SortBy_DAL(columnName, direction);
        //}
        //public dynamic Sort_BLL(dynamic s, string direction)
        //{
        //    dynamic l = GetAllNV_BLL();
        //    if(direction=="Tăng dần")
        //    {
        //        l.Sort();
        //    }
        //    else
        //    {
        //        l.Reverse();
        //    }
        //    return l;
        //}
    }
}
