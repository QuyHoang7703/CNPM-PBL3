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
        public List<dynamic> GetAllKH_BLL()
        {
            QLDB db = new QLDB();
            List<dynamic> list = new List<dynamic>();
            var s = db.KhachHangs.Select(p => new { p.MaKH, p.HoTenKH, p.NgaySinh, p.SDT, p.DiaChi, p.GioiTinh }).ToList();
            list.AddRange(s);
            return list;
        }
        //public List<KhachHang> GetAllKH_BLLl()
        //{
        //    List<KhachHang> list = new List<KhachHang>();
        //    foreach(var i in GetAllKH_BLL())
        //    {
        //        list.Add(i);
        //    }
        //    return list;
        //}
        public List<dynamic> GetKH_ByTxtSearch(string txtSearch)
        {
            List<dynamic> list = new List<dynamic>();
            if (string.IsNullOrEmpty(txtSearch))
            {
                list = GetAllKH_BLL();
            }
            else
            {
                foreach(var i in GetAllKH_BLL())
                {
                    int number;
                    bool check = int.TryParse(txtSearch, out number);
                    if(check && (i.MaKH==number) || i.HoTenKH.Contains(txtSearch) || i.SDT==txtSearch)
                    {
                        list.Add(i);
                    }                  
                }
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
        public int TongKHTrongNgay_BLL(List<int> list)
        {
            QLDB db = new QLDB();
            int t = 0;
            foreach (var i in list)
            {
                var s = db.HoaDons.Where(p => p.MaHD == i).Select(p => p.MaKH).ToList();
                t = t + s.Count;
            }
            return t;
        }
    }
}
