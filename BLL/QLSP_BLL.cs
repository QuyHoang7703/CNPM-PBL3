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
    internal class QLSP_BLL
    {
      // QLSP_DAL dal= new QLSP_DAL();
      
        public dynamic GetAllSP_BLL_ForDGV()
        {
            QLDB db = new QLDB();
            var s = db.DongHoes.Select(p => new { p.MaSP, p.XuatSu, p.ThuongHieu.TenThuongHieu, p.GiaSP, p.GioiTinhSP, p.GiaTriBaoHanh, p.SoLuong }).ToList();
            return s;
        }
        public List<DongHo> GetAllSP_BLL()
        {
            QLDB db = new QLDB();
            var s = db.DongHoes.Select(p => p).ToList();
            return s;
        }
        public dynamic GetSPByTxtSearch(string text)
        {
            QLDB db = new QLDB();
            var s = db.DongHoes.Where(p => (p.MaSP).Contains(text))
                  .Select(p => new { p.MaSP, p.XuatSu, p.ThuongHieu.TenThuongHieu, p.GiaSP, p.GioiTinhSP, p.GiaTriBaoHanh, p.SoLuong }).ToList();
            return s;
        }

        public List<ThuongHieu> GetAllTH_DAL()
        {
            QLDB db = new QLDB();
            List<ThuongHieu> data = new List<ThuongHieu>();
            var s = db.ThuongHieux.Select(p => p).ToList();
            data = s;
            return data;
        }
        public List<KhuyenMai> GetAllKM_DAL()
        {
            QLDB db = new QLDB();
            List<KhuyenMai> data = new List<KhuyenMai>();
            var s = db.KhuyenMais.Select(p => p).ToList();
            data = s;
            return data;
        }

        public List<CBBItems> GetListCBBThuongHieu()
        {
            List<CBBItems> data = new List<CBBItems>();
            foreach (ThuongHieu i in GetAllTH_DAL())
            {
                data.Add(new CBBItems { Text = i.TenThuongHieu, Value = i.MaThuongHieu });
            }
            return data;
        }
        public List<CBBItems> GetListCBBKhuyenMai()
        {
            List<CBBItems> data = new List<CBBItems>();
            foreach (KhuyenMai i in GetAllKM_DAL())
            {
                data.Add(new CBBItems { Text = i.TenKhuyenMai, Value = i.MaKhuyenMai });
            }
            return data;
        }
        public DongHo GetSPBYMaSP(string m)
        {
            DongHo data = null;
            foreach (DongHo i in GetAllSP_BLL())
            {
                if (i.MaSP == m)
                {
                    data = i;
                    break;
                }
            }
            return data;
        }
        public decimal GetGiaSPByIdSP(string masp)
        {
            decimal gia = 0;
            foreach (DongHo i in GetAllSP_BLL())
            {
                if (i.MaSP == masp)
                {
                    gia = i.GiaSP;
                }
            }
            return gia;
        }
        public List<DongHo> GetSPByMaKM(int MaKM)
        {
            List<DongHo> data = new List<DongHo>();
            foreach (DongHo i in GetAllSP_BLL())
            {
                if (i.MaKhuyenMai == MaKM)
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public void AddSP_BLL(DongHo dh)
        {   QLDB db = new QLDB();
            db.DongHoes.Add(dh);
            db.SaveChanges();
        }
        public void EditSP_BLL(DongHo dh)
        {
            QLDB db = new QLDB();
            DongHo o = db.DongHoes.Find(dh.MaSP);
            o = dh;
            db.DongHoes.AddOrUpdate(o);
            db.SaveChanges();
        }
        public void DeleteSP(string IdSP)
        {
            QLDB db = new QLDB();
            DongHo o = db.DongHoes.Find(IdSP);
            db.DongHoes.Remove(o);
            db.SaveChanges();
        }
        public void ExecuteDB(DongHo s)
        {
            if (GetSPBYMaSP(s.MaSP) == null)
            {
                AddSP_BLL(s);
            }
            if (GetSPBYMaSP(s.MaSP) != null)
            {
                EditSP_BLL(s);
                
            }
        }
        public void DeleteSP_BLL(List<string> listDel)
        {
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                try
                {
                    foreach (string i in listDel)
                    {
                        DeleteSP(i);
                    }
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
        public int GetMaTH_BLL(string name)
        {
            QLDB db = new QLDB();
            var s = db.DongHoes.Where(p => p.ThuongHieu.TenThuongHieu == name).
                Select(p => new { p.MaThuongHieu }).FirstOrDefault();
            return s.MaThuongHieu;
        }
        public int GetMaKM_BLL(string name)
        {
            QLDB db = new QLDB();
            var s = db.DongHoes.Where(p => p.KhuyenMai.TenKhuyenMai == name).
               Select(p => new { p.MaKhuyenMai }).FirstOrDefault();
            return (int)s.MaKhuyenMai;
        }

        public List<string> GetGioiTinhSP_BLL()
        {
            List<string> list = new List<string>();
            //var s = dal.GetAllSP1_DAL();
            foreach (DongHo i in GetAllSP_BLL())
            {
                list.Add(i.GioiTinhSP);
            }
            return list;
        }
        public List<string> GetBoMayNangLuong_BLL()
        {
            List<string> list = new List<string>();
            //var s = dal.GetAllSP1_DAL();
            foreach (DongHo i in GetAllSP_BLL())
            {
                list.Add(i.BoMayNangLuong);
            }
            return list;
        }
        public List<string> GetMauMatSo_BLL()
        {
            List<string> list = new List<string>();
            //var s = dal.GetAllSP1_DAL();
            foreach (DongHo i in GetAllSP_BLL())
            {
                list.Add(i.MauMatSo);
            }
            return list;
        }
        public List<string> GetHinhDangMatSo_BLL()
        {
            List<string> list = new List<string>();
            //var s = dal.GetAllSP1_DAL();
            foreach (DongHo i in GetAllSP_BLL())
            {
                list.Add(i.HinhDangMatSo);
            }
            return list;
        }
        public List<string> GetChatLieuMatKinh_BLL()
        {
            List<string> list = new List<string>();
            //var s = dal.GetAllSP1_DAL();
            foreach (DongHo i in GetAllSP_BLL())
            {
                list.Add(i.ChatLieuMatKinh);
            }
            return list;
        }
        public List<string> GetChatLieuDay_BLL()
        {
            List<string> list = new List<string>();
            //var s = dal.GetAllSP1_DAL();
            foreach (DongHo i in GetAllSP_BLL())
            {
                list.Add(i.ChatLieuDay);
            }
            return list;
        }
        public List<string> GetXuatXu_BLL()
        {
            List<string> list = new List<string>();
            //var s = dal.GetAllSP1_DAL();
            foreach (DongHo i in GetAllSP_BLL())
            {
                list.Add(i.XuatSu);
            }
            return list;
        }

        //public dynamic TimKiemTrangChu_BLL(ComboBox cbbTH, ComboBox cbbGT, ComboBox cbbBMNL, ComboBox cbbMMS, ComboBox cbbHDMS, ComboBox cbbCLMK, ComboBox cbbCLD, ComboBox cbbXX, ComboBox cbbGSP)
        //{
        //    return dal.TimKiemDongHo_DAL(cbbTH, cbbGT, cbbBMNL, cbbMMS, cbbHDMS, cbbCLMK, cbbCLD, cbbXX, cbbGSP);
        //}
        public dynamic TimKiemTrangChu_BLL(ComboBox cbbTH, ComboBox cbbGT, ComboBox cbbBMNL, ComboBox cbbMMS, ComboBox cbbHDMS, ComboBox cbbCLMK, ComboBox cbbCLD, ComboBox cbbXX, ComboBox cbbGSP)
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
        public dynamic TimKiemFClock_BLL(ComboBox cbbTH, ComboBox cbbGT, ComboBox cbbBMNL, ComboBox cbbMMS, ComboBox cbbHDMS, ComboBox cbbCLMK, ComboBox cbbCLD, ComboBox cbbXX, ComboBox cbbGSP)
        {
            List<DongHo> list = TimKiemTrangChu_BLL(cbbTH, cbbGT, cbbBMNL, cbbMMS, cbbHDMS, cbbCLMK, cbbCLD, cbbXX, cbbGSP);
            if(list.Count == 0)
            {
                MessageBox.Show("Không Tìm Thấy Sản Phẩm");
            }
            var s = list.Select(p => new { p.MaSP, p.ThuongHieu.TenThuongHieu, p.GioiTinhSP, p.BoMayNangLuong, p.MauMatSo, p.HinhDangMatSo, p.ChatLieuMatKinh, p.ChatLieuDay, p.XuatSu, p.GiaSP }).ToList();
            return s;      
        }
        public dynamic TimKiemTrenTXT_DAL(string txt, List<DongHo> list)
        {
            var s = list.Where(p => p.MaSP.Contains(txt)).Select(p => p).ToList();
            return s;
        }
        public dynamic TimKiemTrenTXTTrangChu_BLL(string txt, List<DongHo> list)
        {
            if (TimKiemTrenTXT_DAL(txt, list).Count == 0)
            {
                MessageBox.Show("Không tồn tại sản phẩm");
            }
            return TimKiemTrenTXT_DAL(txt, list);
        }
    }
}