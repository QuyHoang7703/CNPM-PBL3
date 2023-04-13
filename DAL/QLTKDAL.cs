using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_PBL3.DAL
{
    internal class QLTKDAL
    {
        
        public List<TaiKhoan> GetDBTaiKhoan()
        {
            QLDB db = new QLDB();
            List<TaiKhoan> list = new List<TaiKhoan>();
            var s = db.TaiKhoans.Select(p => p).ToList();
            list = s;
            return list;
        }

    }
}
