using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_PBL3.DAL
{
    internal class QLHD_DAL
    {
        public dynamic GetALLDH_DAL()
        {
            
            using(QLDB db = new QLDB())
            {
               
                var s = db.DongHoes.Select(p => p).ToList();
              
                return s;
            }
        }
        public dynamic GetAllHD_DAL()
        {
            QLDB db = new QLDB();
            var s = db.HoaDons.Select(p => p).ToList();
            return s;
            
        }
        public void AddHD_DAL(HoaDon hd, List<ChiTietHoaDon> list)
        {
            using(QLDB db = new QLDB())
            {
                db.HoaDons.Add(hd);
                foreach(ChiTietHoaDon i in list)
                {
                    i.HoaDon= hd;
                    db.ChiTietHoaDons.Add(i);
                   
                }
            //    ct.HoaDon= hd;
            //    db.ChiTietHoaDons.Add(ct);
               db.SaveChanges();
            }
        }
        public void UpDateSoLuong(string maSP, int soLuong)
        {
            using(QLDB db = new QLDB())
            {
                
                    var s = db.DongHoes.Find(maSP);
                    s.SoLuong = soLuong;
                    db.SaveChanges();
                
                
            }
        }
            

       
    }
}
