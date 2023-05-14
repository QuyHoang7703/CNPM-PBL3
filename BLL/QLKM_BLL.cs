using CNPM_PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public List<string> GetListCBBSP()
        {
            List<string> data = new List<string>();
            foreach (DongHo i in dalsp.GetAllSP2_DAL())
            {
                if (i.MaKhuyenMai == null)
                    data.Add(i.MaSP);
            }
            return data;
        }

        public List<string> GetListCBBSPByThuongHieu(string thuongHieu)
        {
            List<string> data = new List<string>();
            //QLDB db = new QLDB();
            //var s= db.DongHoes.Select(p=>p).ToList();
            foreach (var i in dalsp.GetAllSP2_DAL())
            {
                if (i.ThuongHieu.TenThuongHieu == thuongHieu && i.MaKhuyenMai == null)

                    data.Add(i.MaSP);
            }
            // MessageBox.Show("blo");
            return data;
        }
        public void UpdateKMByMaSP_BLL(string masp, int MaKM)
        {
            dal.UpdateKMByMaSP_DAL(masp, MaKM);
        }
        public void UpdateKM(List<int> maKM)
        {
            foreach (int i in maKM)
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
        //public void PriceListUpdate(List<string> lisMasp, List<decimal> listPrice)
        //{
        //    dal.PriceListUpdate(lisMasp, listPrice);
        //}
        public void DeleteKM(List<string> masp)
        {
            foreach (string i in masp)
            {
                dal.DeleteKM(i);
            }
        }
        public void DeleteKMByMaKM(List<int> listMaKM)
        {
            foreach (int i in listMaKM)
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
        //public void PriceListUpdate(List<string> masp)
        //{
        //    dal.PriceListUpdate(masp);
        //}
        public string GetTenThuongHieuByMaSP(string masp)
        {
            return dal.GetNameTHBYMaSP(masp);
        }
    }
}

