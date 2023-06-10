using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_PBL3.BLL
{
    internal class QLTH_BLL
    {
        QLDB db = new QLDB();
        public List<ThuongHieu> GetAllThuongHieu()
        {
            List<ThuongHieu> list = new List<ThuongHieu>();
            var s = db.ThuongHieux.Select(p => p).ToList();
            list = s;
            return list;
        }
        public void AddThuongHieu(string name)
        {
            ThuongHieu t = new ThuongHieu();
            t.TenThuongHieu = name;
            db.ThuongHieux.Add(t);
            db.SaveChanges();
        }
        public int GetMaTHByTenTH(string name)
        {
            int id = 0;
            foreach (ThuongHieu i in GetAllThuongHieu())
            {
                if (i.TenThuongHieu == name)
                {
                    id = i.MaThuongHieu;
                    break;
                }
            }
            return id;
        }

    }
}
