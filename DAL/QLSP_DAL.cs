using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_PBL3.DAL
{
    internal class QLSP_DAL
    {
        QLDB db = new QLDB();
        public dynamic GetAllSP_DAL()
        {
                var s = db.DongHoes.Select(p => new {p.MaSP, p.XuatSu, p.ThuongHieu.TenThuongHieu, p.GiaSP, p.GioiTinhSP, p.GiaTriBaoHanh, p.SoLuong}).ToList();
                return s;
        }
        public dynamic GetSPByXuatXu_DAL(string xuatxu)
        {     
                var s = db.DongHoes.Where( p=> p.XuatSu == xuatxu)
                    .Select(p => new { p.MaSP, p.XuatSu, p.ThuongHieu.TenThuongHieu, p.GiaSP, p.GioiTinhSP, p.GiaTriBaoHanh, p.SoLuong }).ToList();
                return s;
        }
        public dynamic GetSPByGender_DAL(string gender)
        {        
              var s = db.DongHoes.Where(p => p.GioiTinhSP == gender)
                    .Select(p => new { p.MaSP, p.XuatSu, p.ThuongHieu.TenThuongHieu, p.GiaSP, p.GioiTinhSP, p.GiaTriBaoHanh, p.SoLuong }).ToList();
                return s;    
        }
        public dynamic GetSPByShape_DAL(string shape)
        {
            var s = db.DongHoes.Where(p => p.HinhDangMatSo == shape)
                  .Select(p => new { p.MaSP, p.XuatSu, p.ThuongHieu.TenThuongHieu, p.GiaSP, p.GioiTinhSP, p.GiaTriBaoHanh, p.SoLuong }).ToList();
            return s;
        }
        public dynamic GetSPByColor_DAL(string color)
        {
            var s = db.DongHoes.Where(p => p.MauMatSo == color)
                  .Select(p => new { p.MaSP, p.XuatSu, p.ThuongHieu.TenThuongHieu, p.GiaSP, p.GioiTinhSP, p.GiaTriBaoHanh, p.SoLuong }).ToList();
            return s;
        }
        public dynamic GetSPByBrand_DAL(string brand)
        {
            var s = db.DongHoes.Where(p => p.ThuongHieu.TenThuongHieu == brand)
                  .Select(p => new { p.MaSP, p.XuatSu, p.ThuongHieu.TenThuongHieu, p.GiaSP, p.GioiTinhSP, p.GiaTriBaoHanh, p.SoLuong }).ToList();
            return s;
        }
        public dynamic GetSPByTxtSearch_DAL(string text)
        {
            var s = db.DongHoes.Where(p => (p.MaSP).Contains(text))
                  .Select(p => new { p.MaSP, p.XuatSu, p.ThuongHieu.TenThuongHieu, p.GiaSP, p.GioiTinhSP, p.GiaTriBaoHanh, p.SoLuong }).ToList();
            return s;
        }
        public dynamic GetAllSP1_DAL()
        {
            var s = db.DongHoes.Select(p => p).ToList();
                return s;         
        }
        public string checkID(string id)
        {
            var s = db.DongHoes.Where(p => p.MaSP == id).Select(p => new { p.MaSP }).FirstOrDefault();
            return s.MaSP;
        }
        public List<ThuongHieu> GetAllTH_DAL()
        { 
                List<ThuongHieu> data = new List<ThuongHieu>();
                var s = db.ThuongHieux.Select(p =>p).ToList();
                data = s;
                return data;        
        }
        public List<KhuyenMai> GetAllKM_DAL()
        {     
                List<KhuyenMai> data = new List<KhuyenMai>();
                var s = db.KhuyenMais.Select(p => p).ToList();
                data = s;
                return data;        
        }
        public void AddSP_DAL(DongHo dh)
        {       
                db.DongHoes.Add(dh);
                db.SaveChanges();       
        }
        public void EditSP_DAL(DongHo dh)
        {     
                DongHo o = db.DongHoes.Find(dh.MaSP);
                o = dh;
                db.DongHoes.AddOrUpdate(o);
                db.SaveChanges();   
        }
        public void DeleteSP_DAL(string IdSP)
        {
                DongHo o = db.DongHoes.Find(IdSP);
                db.DongHoes.Remove(o);
                db.SaveChanges();
        }
        public int GetMaTH_DAL(string name)
        {
            var s = db.DongHoes.Where(p => p.ThuongHieu.TenThuongHieu == name).
                Select(p => new { p.MaThuongHieu }).FirstOrDefault();
            return s.MaThuongHieu;
        }
        public int GetMaKM_DAL(string name)
        {
            var s = db.DongHoes.Where(p => p.KhuyenMai.TenKhuyenMai == name).
                Select(p => new { p.MaKhuyenMai }).FirstOrDefault();
            return (int)s.MaKhuyenMai;
        }
    }
}
