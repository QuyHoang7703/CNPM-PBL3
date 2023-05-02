using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNPM_PBL3.DAL;

namespace CNPM_PBL3.BLL
{
    internal class QLKH_BLL
    {
        QLKH_DAL qLKH_DAL = new QLKH_DAL();
        public dynamic GetAllKH_BLL()
        {
            var s = qLKH_DAL.GetAllKH_DAL();
            return s;
        }
        public void AddKhachHang_BLL(KhachHang khachHang)
        {
            qLKH_DAL.AddKhachHang_DAL(khachHang);
        }
    }
}
