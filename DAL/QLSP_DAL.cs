﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public dynamic TinKiem(ComboBox th, ComboBox gt)
        {
            string thuongHieu = null;
            string gioitinh = null;
            var s = db.DongHoes.Select(p => p).ToList();
            if (th.SelectedItem != null)
            {
                thuongHieu = th.SelectedItem.ToString();
                if (string.IsNullOrWhiteSpace(thuongHieu) == false)
                {
                    s = s.Where(p => p.ThuongHieu.TenThuongHieu == thuongHieu)
                        .Select(p => p).ToList();
                }
            }
            if(gt.SelectedItem != null){

                gioitinh = gt.SelectedItem.ToString();

                if (string.IsNullOrWhiteSpace(gioitinh) == false)
                {
                    s = s.Where(p => p.GioiTinhSP == gioitinh)
                        .Select(p => p).ToList();
                }
            }

            return s;
        }
    }
}