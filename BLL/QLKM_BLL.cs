using CNPM_PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_PBL3.BLL
{
    internal class QLKM_BLL
    {
        QLKM_DAL dal = new QLKM_DAL();
        QLSP_DAL dalsp = new QLSP_DAL();
        public dynamic GetAllKhuyenMai_BLL()
        {
            return dal.GetAllKhuyenMai_DAL();
        }
        public void AddKM_BLL(KhuyenMai k)
        {
            dal.AddKM_DAL(k);
        }
        public List<CBBItems> GetListCBBSP()
        {
            List<CBBItems> data = new List<CBBItems>();
            foreach (DongHo i in dalsp.GetAllSP2_DAL())
            {
                if (i.MaKhuyenMai == null)
                    data.Add(new CBBItems { Text = i.MaSP });
            }
            return data;
        }

        public List<CBBItems> GetListCBBSPByThuongHieu(string thuongHieu)
        {
            List<CBBItems> data = new List<CBBItems>();
            foreach (DongHo i in dalsp.GetSpByThuongHieu(thuongHieu))
            {
                data.Add(new CBBItems { Text = i.MaSP });
            }
            return data;
        }
        public void UpdateKMByMaSP(string masp, int MaKM)
        {
            dal.UpdateKMByMaKM(masp, MaKM);
        }
        public void UpdateKM(int makm)
        {
            dal.UpdateKM(makm);
        }
        public void UpdateAllKM(KhuyenMai k)
        {
            dal.UpdateAllKM(k);
        }
        public void UpdateGiaSP(string masp, decimal giasp)
        {
            dal.UpdateGiaSP(masp, giasp);
        }
        public void DeleteKM(string masp)
        {
            dal.DeleteKM(masp);
        }
        public void DeleteKMByMaKM(int makm)
        {
            dal.DeleteKMByMaKM(makm);
        }
        public int GetMaKM(string nameKM)
        {
            return dal.GetMaKm(nameKM);
        }
    }
}
