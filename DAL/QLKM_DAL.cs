using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_PBL3.DAL
{
    internal class QLKM_DAL
    {
        QLDB db = new QLDB();
        QLSP_DAL dal = new QLSP_DAL();
        public dynamic GetAllKhuyenMai_DAL()
        {
            var s = db.KhuyenMais.Select(p => new { p.MaKhuyenMai, p.TenKhuyenMai, p.GiaTriKhuyenMai, p.NgayBatDau, p.NgayKetThuc }).ToList();
            return s;
        }
        public void AddKM_DAL(KhuyenMai k)
        {
            db.KhuyenMais.Add(k);
            db.SaveChanges();
        }
        public void UpdateKMByMaSP_DAL(string Masp, int MaKM)
        {
            var s = db.DongHoes.Find(Masp);
            s.MaKhuyenMai = MaKM;
            db.SaveChanges();
        }
        public void UpdateKM(int makm)
        {
            var s = db.DongHoes.Where(p => p.MaKhuyenMai == makm).ToList();
            foreach (var i in s)
            {
                i.MaKhuyenMai = null;
                db.DongHoes.AddOrUpdate(i);
                db.SaveChanges();
            }
        }
        public void UpdateGiaSP(string masp, decimal giasp)
        {
            var s = db.DongHoes.Find(masp);
            s.GiaSP = giasp;
            db.SaveChanges();
        }
        public void PriceListUpdate(List<string> masp, List<decimal> listPrice)
        {
            for (int i = 0; i < masp.Count; i++)
            {
                var s = db.DongHoes.Find(masp[i]);
                s.GiaSP = listPrice[i];
                db.SaveChanges();
            }
        }
        public void UpdateAllKM(KhuyenMai k)
        {
            KhuyenMai s = db.KhuyenMais.Find(k.MaKhuyenMai);
            s = k;
            db.KhuyenMais.AddOrUpdate(s);
            db.SaveChanges();
        }
        public void DeleteKM(string Masp)
        {
            var s = db.DongHoes.Find(Masp);
            s.MaKhuyenMai = null;
            db.SaveChanges();

        }
        public void DeleteKMByMaKM(int makm)
        {
            KhuyenMai s = db.KhuyenMais.Find(makm);
            db.KhuyenMais.Remove(s);
            db.SaveChanges();
        }
        public int GetMaKm(string nameKm)
        {
            var s = db.KhuyenMais.Where(p => p.TenKhuyenMai == nameKm).
                Select(p => new { p.MaKhuyenMai }).FirstOrDefault();
            return s.MaKhuyenMai;
        }
        public dynamic GetMaSPByThuongHieu(string ThuongHieu)
        {

            var s = db.DongHoes.Where(p => p.ThuongHieu.TenThuongHieu == ThuongHieu).
                Select(p => p).ToList();
            return s;
        }
        public void PriceListUpdate(List<string> masp)
        {
            foreach (string i in masp)
            {
                var s = db.DongHoes.Find(i);
                decimal giatrikm = Convert.ToDecimal(s.KhuyenMai.GiaTriKhuyenMai);
                decimal giasp = (s.GiaSP / (100 - giatrikm)) * 100;
                s.GiaSP = giasp;
                db.SaveChanges();
            }
        }
    }
}

