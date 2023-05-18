﻿using CNPM_PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_PBL3.BLL
{
    internal class QLHD_BLL
    {
        QLHD_DAL dal = new QLHD_DAL();
        QLSP_BLL bllsp= new QLSP_BLL(); 
        public List<string> GetDBCBB()
        {
            List<string> list = new List<string>();
            foreach (DongHo i in bllsp.GetAllSP_BLL())
            {
                list.Add(i.MaSP);
            }
            return list;
        }
        public List<HoaDon> GetAllHD()
        {
            QLDB db = new QLDB();
            var s = db.HoaDons.Select(p => p).ToList();
            return s;

        }
        public List<dynamic> GetAllHD_BLL_ForDGV()
        {
            List<dynamic> list = new List<dynamic>();
            foreach (HoaDon i in GetAllHD())
            {
                var pt = new
                {

                    MaHoaDon = i.MaHD,
                    MaKhachHang = i.KhachHang.MaKH,
                    HoTen = i.KhachHang.HoTenKH,
                    NgayBan = i.NgayBan,
                    MaNhanVien = i.ID,

                };
                list.Add(pt);
            }
            return list;

        }
        public dynamic GetChiTietHoaDon(int maHD)
        {
            foreach (HoaDon i in GetAllHD())
            {
                if (i.MaHD == maHD)
                    return i;
            }
            return null;
        }

        public dynamic GetDetailBillForPrint_BLL(int maHD)
        {
            QLDB db = new QLDB();
            var s = db.ChiTietHoaDons.Where(p => p.MaHD == maHD).Select(p => new
            {
                p.MaSP,
                p.SoLuong,
                p.DonGia,
                p.ThanhTien,
                p.HoaDon.TaiKhoan.UserName,
                p.HoaDon.NgayBan,
                p.HoaDon.KhachHang.MaKH,
                p.HoaDon.KhachHang.HoTenKH,
                p.HoaDon.MaHD,
                p.HoaDon.KhachHang.DiaChi,
                p.HoaDon.KhachHang.SDT,
                p.HoaDon.TaiKhoan.ID,
                p.HoaDon.TaiKhoan.ChiTietTaiKhoan.HoTen
            }).ToList();
            return s;

        }
        //

        //bỏ bên QLSP
        public decimal GetDonGia(string maSP)
        {
            decimal giaSP = 0;
            foreach (var i in bllsp.GetAllSP_BLL())
            {
                if (i.MaSP == maSP)
                {
                    giaSP = i.GiaSP;
                }

            }
            return giaSP;
        }
        
        public int GetSoLuong(string maSP)
        {
            int soLuong = 0;
            foreach (var i in bllsp.GetAllSP_BLL())
            {
                if (i.MaSP == maSP)
                {
                    soLuong = (int)i.SoLuong;
                }
            }
            return soLuong;
        }
        public float GetGiaTriKhuyenMai(string maSP)
        {
            float giaTriKM = 0.0f;
            foreach(var i in bllsp.GetAllSP_BLL())
            {
                if (i.MaSP == maSP)
                {
                    if(i.MaKhuyenMai!=null)
                    giaTriKM= (float)i.KhuyenMai.GiaTriKhuyenMai;
                }
            }
            return giaTriKM;
        }
        //
        public void AddHD(HoaDon hd, List<ChiTietHoaDon> list)
        {
            using (QLDB db = new QLDB())
            {
                db.HoaDons.Add(hd);
                foreach (ChiTietHoaDon i in list)
                {
                    i.HoaDon = hd;
                    db.ChiTietHoaDons.Add(i);

                }
                //    ct.HoaDon= hd;
                //    db.ChiTietHoaDons.Add(ct);
                db.SaveChanges();
            }
        }



        public void UpdateSoLuong(string maSP, int soLuong)
        {
            using (QLDB db = new QLDB())
            {

                var s = db.DongHoes.Find(maSP);
                s.SoLuong = soLuong;
                db.SaveChanges();
            }
        }

        public dynamic GetHD_ByTxtSearch(string text)
        {

            List<dynamic> list = new List<dynamic>();

            if (string.IsNullOrEmpty(text))
            {
                list = GetAllHD_BLL_ForDGV();
            }
            else
            {              
                int number;
                bool check = int.TryParse(text, out number);
                DateTime dateTime;
                bool checkDateTime = DateTime.TryParse(text, out dateTime);
                foreach (var i in GetAllHD_BLL_ForDGV())
                {
                    if ((check && i.MaHoaDon == number) || (checkDateTime && i.NgayBan.Date == dateTime) || i.HoTen.Contains(text))
                    {
                        list.Add(i);
                    }
                }               
            }
            return list;
        }
        public int GetMaHoaDon_ByMaKH(int maKH)
        {
            int maHD = 0;
            foreach (HoaDon i in GetAllHD())
            {
                if (i.MaKH == maKH)
                {
                    maHD = i.MaHD;
                    break;
                }
            }
            return maHD;
        }



    }
}

