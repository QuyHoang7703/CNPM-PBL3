using System;
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
            var s = db.DongHoes.Select(p => new { p.MaSP, p.XuatSu, p.ThuongHieu.TenThuongHieu, p.GiaSP, p.GioiTinhSP, p.GiaTriBaoHanh, p.SoLuong }).ToList();
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
            var s = db.DongHoes.Select(p => new { p.MaSP, p.ThuongHieu.TenThuongHieu, p.GioiTinhSP, p.BoMayNangLuong, p.MauMatSo, p.HinhDangMatSo, p.ChatLieuMatKinh, p.ChatLieuDay, p.XuatSu }).ToList();
            return s;
        }
        public dynamic GetAllSP2_DAL()
        {
            var s = db.DongHoes.AsNoTracking().Select(p => p).ToList();
            //var s = db.DongHoes.Select(p => p).ToList();
            return s;
        }

        public void GetData()
        {

        }

        public dynamic GetSpByThuongHieu(string thuongHieu)
        {
            var s = db.DongHoes.Where(p => p.ThuongHieu.TenThuongHieu == thuongHieu)
                .Select(p => p).ToList();
            return s;
        }
        public List<ThuongHieu> GetAllTH_DAL()
        {
            List<ThuongHieu> data = new List<ThuongHieu>();
            var s = db.ThuongHieux.Select(p => p).ToList();
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
        public string tenThuongHieu_DAL(int math)
        {
            using (QLDB db = new QLDB())
            {
                var s = db.ThuongHieux.Where(p => p.MaThuongHieu == math).Select(p => p).Single();
                return s.TenThuongHieu;
            }
        }
        public string giaTriKuyenMai_DAL(int maKM)
        {
            using (QLDB db = new QLDB())
            {
                var s = db.KhuyenMais.Where(p => p.MaKhuyenMai == maKM).Select(p => p).Single();
                return s.GiaTriKhuyenMai.ToString();
            }
        }
       
        public dynamic TimKiemDongHo_DAL(ComboBox cbbTH, ComboBox cbbGT, ComboBox cbbBMNL, ComboBox cbbMMS, ComboBox cbbHDMS, ComboBox cbbCLMK, ComboBox cbbCLD, ComboBox cbbXX, ComboBox cbbGSP)
        {
            string thuongHieu = "";
            if (cbbTH.SelectedItem != null)
            {
                thuongHieu = cbbTH.SelectedItem.ToString();
            }
            string gioiTinhSP = "";
            if (cbbGT.SelectedItem != null)
            {
                gioiTinhSP = cbbGT.SelectedItem.ToString();
            }
            string boMayNangNuong = "";
            if (cbbBMNL.SelectedItem != null)
            {
                boMayNangNuong = cbbBMNL.SelectedItem.ToString();
            }
            string mauMatSo = "";
            if (cbbMMS.SelectedItem != null)
            {
                mauMatSo = cbbMMS.SelectedItem.ToString();
            }
            string hinhDangMatSo = "";
            if (cbbHDMS.SelectedItem != null)
            {
                hinhDangMatSo = cbbHDMS.SelectedItem.ToString();
            }
            string chatLieuMatKinh = "";
            if (cbbCLMK.SelectedItem != null)
            {
                chatLieuMatKinh = cbbCLMK.SelectedItem.ToString();
            }
            string chatLieuDay = "";
            if (cbbCLD.SelectedItem != null)
            {
                chatLieuDay = cbbCLD.SelectedItem.ToString();
            }
            string xuatXu = "";
            if (cbbXX.SelectedItem != null)
            {
                xuatXu = cbbXX.SelectedItem.ToString();
            }
            string giaSP = "";
            if (cbbGSP.SelectedItem != null)
            {
                giaSP = cbbGSP.SelectedItem.ToString();
            }
            QLDB db = new QLDB();
                var s = db.DongHoes.Select(p => p).ToList();

                if (!string.IsNullOrWhiteSpace(thuongHieu))
                {
                    s = s.Where(p => p.ThuongHieu.TenThuongHieu == thuongHieu)
                            .Select(p => p).ToList();
                }
                if (!string.IsNullOrWhiteSpace(gioiTinhSP))
                {
                    s = s.Where(p => p.GioiTinhSP == gioiTinhSP)
                            .Select(p => p).ToList();
                }
                if (!string.IsNullOrWhiteSpace(boMayNangNuong))
                {
                    s = s.Where(p => p.BoMayNangLuong == boMayNangNuong)
                            .Select(p => p).ToList();
                }
                if (!string.IsNullOrEmpty(mauMatSo))
                {
                    s = s.Where(p => p.MauMatSo == mauMatSo)
                            .Select(p => p).ToList();
                }
                if (!string.IsNullOrWhiteSpace(hinhDangMatSo))
                {

                    s = s.Where(p => p.HinhDangMatSo == hinhDangMatSo)
                            .Select(p => p).ToList();
                }
                if (!string.IsNullOrWhiteSpace(chatLieuMatKinh))
                {


                    s = s.Where(p => p.ChatLieuMatKinh == chatLieuMatKinh)
                            .Select(p => p).ToList();
                }
                if (!string.IsNullOrWhiteSpace(chatLieuDay))
                {


                    s = s.Where(p => p.ChatLieuDay == chatLieuDay)
                            .Select(p => p).ToList();
                }
                if (!string.IsNullOrWhiteSpace(xuatXu))
                {


                    s = s.Where(p => p.XuatSu == xuatXu)
                            .Select(p => p).ToList();
                }
                if (!string.IsNullOrWhiteSpace(giaSP))
                {
                    List<decimal> li = new List<decimal>();
                    li = GetGiatri_CBBGiaSP(giaSP);
                    if (li.Count == 1)
                    {
                        decimal gia1 = li[0];

                        s = s.Where(p => p.GiaSP >= gia1)
                           .Select(p => p).ToList();
                    }
                    else
                    {
                        decimal gia1 = li[0];
                        decimal gia2 = li[1];
                        s = s.Where(p => p.GiaSP >= gia1 && p.GiaSP <= gia2)
                           .Select(p => p).ToList();
                    }
                }
                return s;
        }
        public List<decimal> GetGiatri_CBBGiaSP(string txt)
        {
            List<decimal> li = new List<decimal>();
            string inputString = txt;
            string inputString1 = txt;
            int startIndex = inputString.IndexOfAny("0123456789".ToCharArray());
            int endIndex = inputString.IndexOf('-', startIndex);
            if (endIndex == -1)
            {
                endIndex = inputString.Length;
            }
            if (inputString.Contains("Trên"))
            {
                string numberString = inputString.Substring(startIndex, endIndex - startIndex);
                decimal number = Convert.ToDecimal(numberString);
                li.Add(number);

            }
            else
            {
                string numberString = inputString.Substring(startIndex, endIndex - startIndex);
                string numberString1 = inputString1.Substring(endIndex - startIndex + 1, inputString1.Length - endIndex - 1);
                decimal number = Convert.ToDecimal(numberString);
                li.Add(number);
                decimal number2 = Convert.ToDecimal(numberString1);
                li.Add(number2);
            }
            return li;
        }
        public dynamic TimKiemTrenTXT_DAL(string txt, List<DongHo> list)
        {
            var s = list.Where(p => p.MaSP.Contains(txt)).Select(p => p).ToList();
            return s;
        }
    }
}