using CNPM_PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_PBL3.BLL
{
    internal class QLKM_BLL
    {
        //QLKM_DAL dal = new QLKM_DAL();
        //QLSP_DAL dalsp = new QLSP_DAL();
        //QLSP_BLL bll = new QLSP_BLL();
        QLDB db = new QLDB();
       // QLSP_DAL dal = new QLSP_DAL();
        QLSP_BLL bll = new QLSP_BLL();
        public dynamic GetAllKhuyenMai_BLL()
        {
            // return dal.GetAllKhuyenMai_DAL();
            var s = db.KhuyenMais.Select(p => new { p.MaKhuyenMai, p.TenKhuyenMai, p.GiaTriKhuyenMai, p.NgayBatDau, p.NgayKetThuc }).ToList();
            return s;
        }
        public void AddKM_BLL(KhuyenMai k)
        {
            QLDB db = new QLDB();
            db.KhuyenMais.Add(k);
            db.SaveChanges();
        }
        public List<string> GetListCBBSP()
        {
            List<string> data = new List<string>();
            foreach (DongHo i in bll.GetAllSP_BLL())
            {
                if (i.MaKhuyenMai == null)
                    data.Add(i.MaSP);
            }
            return data;
        }

        public List<string> GetListCBBSPByThuongHieu(string thuongHieu)
        {
            List<string> data = new List<string>();
            QLDB db = new QLDB();
            var s = db.DongHoes.Select(p => p).ToList();
            foreach (var i in bll.GetAllSP_BLL())
            {
                if (i.ThuongHieu.TenThuongHieu == thuongHieu && i.MaKhuyenMai == null)

                    data.Add(i.MaSP);
            }
            return data;
        }
        public void UpdateKMByMaSP_BLL(string masp, int MaKM)
        {
            //  dal.UpdateKMByMaSP_DAL(masp, MaKM);
            var s = db.DongHoes.Find(masp);
            s.MaKhuyenMai = MaKM;
            db.SaveChanges();
        }

        public void UpdateKM_1(int makm)
        {
            var s = db.DongHoes.Where(p => p.MaKhuyenMai == makm).ToList();
            foreach (var i in s)
            {
                i.MaKhuyenMai = null;
                db.DongHoes.AddOrUpdate(i);
                db.SaveChanges();
            }
        }

        public void UpdateKM(List<int> maKM)
        {
            foreach (int i in maKM)
            {
                //dal.UpdateKM(i);
                UpdateKM_1(i);
            }
        }
        public void UpdateAllKM(KhuyenMai k)
        {
            // dal.UpdateAllKM(k);
            KhuyenMai s = db.KhuyenMais.Find(k.MaKhuyenMai);
            s = k;
            db.KhuyenMais.AddOrUpdate(s);
            db.SaveChanges();
        }
        public void UpdateGiaSP(string masp, decimal giasp)
        {
            // dal.UpdateGiaSP(masp, giasp);
            var s = db.DongHoes.Find(masp);
            s.GiaSP = giasp;
            db.SaveChanges();
        }
        public void DeleteKM_1(string Masp)
        {
            var s = db.DongHoes.Find(Masp);
            s.MaKhuyenMai = null;
            db.SaveChanges();

        }
        public void DeleteKM(List<string> masp)
        {
            foreach (string i in masp)
            {
                //dal.DeleteKM(i);
                DeleteKM_1(i);
            }
        }
        public void DeleteKMByMaKM_1(int makm)
        {
            KhuyenMai s = db.KhuyenMais.Find(makm);
            db.KhuyenMais.Remove(s);
            db.SaveChanges();
        }

        public void DeleteKMByMaKM(List<int> listMaKM)
        {
            foreach (int i in listMaKM)
            {
                // dal.DeleteKMByMaKM(i);
                DeleteKMByMaKM_1(i);
            }
        }
        public int GetMaKm_1(string nameKm)
        {
            var s = db.KhuyenMais.Where(p => p.TenKhuyenMai == nameKm).
                Select(p => new { p.MaKhuyenMai }).FirstOrDefault();
            return s.MaKhuyenMai;
        }
        public int GetMaKM(string nameKM)
        {
            return GetMaKm_1(nameKM);
        }
        public List<string> GetMaSPByMaKM(List<int> makm)
        {
            List<string> list = new List<string>();
            foreach (DongHo i in bll.GetAllSP_BLL())
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

        public string GetNameTHBYMaSP_1(string masp)
        {
            DongHo i = db.DongHoes.Find(masp);
            return i.ThuongHieu.TenThuongHieu;
        }
        public string GetTenThuongHieuByMaSP(string masp)
        {
            return GetNameTHBYMaSP_1(masp);
        }
    }
}

