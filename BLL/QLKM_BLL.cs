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
                if (i.MaKhuyenMai == null)
                    data.Add(new CBBItems { Text = i.MaSP });
            }
            return data;
        }
        public void UpdateKMByMaSP(string masp, int MaKM)
        {
            dal.UpdateKMByMaKM(masp, MaKM);
        }
        public void UpdateKM(List<int> makm)
        {
            foreach (int i in makm)
            {
                dal.UpdateKM(i);
            }
        }
        public void UpdateAllKM(KhuyenMai k)
        {
            dal.UpdateAllKM(k);
        }
        public void UpdateGiaSP(string masp, decimal giasp)
        {
            dal.UpdateGiaSP(masp, giasp);
        }
        public void PriceListUpdate(List<string> lisMasp, List<decimal> listPrice)
        {
            dal.PriceListUpdate(lisMasp, listPrice);
        }
        public void DeleteKM(List<string> masp)
        {
            foreach (string i in masp)
            {
                dal.DeleteKM(i);
            }
        }
        public void DeleteKMByMaKM(List<int> listmakm)
        {
            foreach (int i in listmakm)
            {
                dal.DeleteKMByMaKM(i);
            }
        }
        public int GetMaKM(string nameKM)
        {
            return dal.GetMaKm(nameKM);
        }
        public List<string> GetMaSPByMaKM(List<int> makm)
        {
            List<string> list = new List<string>();
            foreach (DongHo i in dalsp.GetAllSP2_DAL())
            {
                foreach (int item in makm)
                {
                    if (i.MaKhuyenMai == item)
                    {
                        list.Add(i.MaSP);
                    }
                }
            }
            return list;
        }
        public void PriceListUpdate(List<string> masp)
        {
            dal.PriceListUpdate(masp);
        }
    }
}
