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
        QLKH_DAL dal = new QLKH_DAL();
        public List<KhachHang> GetAllKH_BLL()
        {
            List<KhachHang> list = new List<KhachHang>();
            foreach(var i in dal.GetAllKH_DAL())
            {
                list.Add(i);
            }
            return list;
        }
        public void AddKhachHang_BLL(KhachHang khachHang)
        {
            dal.AddKhachHang_DAL(khachHang);
        }
        public int GetIdKhachHang_BLL(KhachHang khachHang)
        {
            //int idKachHang = 0;
            //foreach (KhachHang i in GetAllKH_BLL())
            //{
            //    if (i == khachHang)
            //    {
            //        idKachHang=
            //    }

            //}
            return khachHang.MaKH;
        }
    }
}
