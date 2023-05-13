using CNPM_PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_PBL3.BLL
{
    internal class QLSP_BLL
    {
        QLSP_DAL dal = new QLSP_DAL();
        public dynamic GetAllSP_BLL()
        {
            var s = dal.GetAllSP_DAL();
            return s;
        }
        public dynamic GetSPByTxtSearch(string text)
        {
            var s = dal.GetSPByTxtSearch_DAL(text);
            return s;
        }

        public List<CBBItems> GetListCBBThuongHieu()
        {
            List<CBBItems> data = new List<CBBItems>();
            foreach (ThuongHieu i in dal.GetAllTH_DAL())
            {
                data.Add(new CBBItems { Text = i.TenThuongHieu, Value = i.MaThuongHieu });
            }
            return data;
        }
        public List<CBBItems> GetListCBBKhuyenMai()
        {
            List<CBBItems> data = new List<CBBItems>();
            foreach (KhuyenMai i in dal.GetAllKM_DAL())
            {
                data.Add(new CBBItems { Text = i.TenKhuyenMai, Value = i.MaKhuyenMai });
            }
            return data;
        }
        public DongHo GetSPBYMaSP(string m)
        {
            DongHo data = null;
            foreach (DongHo i in dal.GetAllSP2_DAL())
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
            foreach (var i in dal.GetAllSP2_DAL())
            {
                if (i.MaSP == masp)
                {
                    gia = i.GiaSP;
                }
            }
            return gia;
        }
        public List<dynamic> GetSPByMaKM(int MaKM)
        {
            List<dynamic> data = new List<dynamic>();
            foreach (var i in dal.GetAllSP2_DAL())
            {
                if (i.MaKhuyenMai == MaKM)
                {
                    data.Add(i);
                }
            }
            return data;
        }
        public void ExecuteDB(DongHo s)
        {
            if (GetSPBYMaSP(s.MaSP) == null)
            {
                dal.AddSP_DAL(s);
            }
            if (GetSPBYMaSP(s.MaSP) != null)
            {
                dal.EditSP_DAL(s);
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
                        dal.DeleteSP_DAL(i);
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
            return dal.GetMaTH_DAL(name);
        }
        public int GetMaKM_BLL(string name)
        {
            return dal.GetMaKM_DAL(name);
        }

        public List<string> GetGioiTinhSP_BLL()
        {
            List<string> list = new List<string>();
            var s = dal.GetAllSP1_DAL();
            foreach (var i in s)
            {
                list.Add(i.GioiTinhSP);
            }
            return list;
        }
        public List<string> GetBoMayNangLuong_BLL()
        {
            List<string> list = new List<string>();
            var s = dal.GetAllSP1_DAL();
            foreach (var i in s)
            {
                list.Add(i.BoMayNangLuong);
            }
            return list;
        }
        public List<string> GetMauMatSo_BLL()
        {
            List<string> list = new List<string>();
            var s = dal.GetAllSP1_DAL();
            foreach (var i in s)
            {
                list.Add(i.MauMatSo);
            }
            return list;
        }
        public List<string> GetHinhDangMatSo_BLL()
        {
            List<string> list = new List<string>();
            var s = dal.GetAllSP1_DAL();
            foreach (var i in s)
            {
                list.Add(i.HinhDangMatSo);
            }
            return list;
        }
        public List<string> GetChatLieuMatKinh_BLL()
        {
            List<string> list = new List<string>();
            var s = dal.GetAllSP1_DAL();
            foreach (var i in s)
            {
                list.Add(i.ChatLieuMatKinh);
            }
            return list;
        }
        public List<string> GetChatLieuDay_BLL()
        {
            List<string> list = new List<string>();
            var s = dal.GetAllSP1_DAL();
            foreach (var i in s)
            {
                list.Add(i.ChatLieuDay);
            }
            return list;
        }
        public List<string> GetXuatXu_BLL()
        {
            List<string> list = new List<string>();
            var s = dal.GetAllSP1_DAL();
            foreach (var i in s)
            {
                list.Add(i.XuatSu);
            }
            return list;
        }
        //public dynamic TimKiemTrangChu_BLL(ComboBox cbbTH, ComboBox cbbGT, ComboBox cbbBMNL, ComboBox cbbMMS, ComboBox cbbHDMS, ComboBox cbbCLMK, ComboBox cbbCLD, ComboBox cbbXX, ComboBox cbbGSP)
        //{
        //    //return dal.TimKiemTrangChu_DAL(cbbTH, cbbGT, cbbBMNL, cbbMMS, cbbHDMS, cbbCLMK, cbbCLD, cbbXX, cbbGSP);
        //    List<dynamic> list = new List<dynamic>();
        //    //foreach(var i in dal.TimKiemTrangChu_DAL(cbbTH, cbbGT, cbbBMNL, cbbMMS, cbbHDMS, cbbCLMK, cbbCLD, cbbXX, cbbGSP))
        //    //{
        //    //    var t = new
        //    //    {
        //    //        TenThuongHieu=i.ThuongHieu.TenThuongHieu,
        //    //        MaSP =i.MaSP,
        //    //        GioiTinhSP=i.GioiTinhSP,
        //    //        ChatLieuMatKinh=i.ChatLieuMatKinh,
        //    //        BoMayNangLuong=i.BoMayNangLuong,
        //    //        GiaSP=i.GiaSP,
        //    //        GiaTriKhuyenMai=i.KhuyenMai.GiaTriKhuyenMai,
        //    //        //GiaSP= 
        //    //    };
        //    //    list.Add(t);
        //    //}
        //    //return list;
        //}



        public dynamic TimKiemTrenTXTTrangChu_BLL(string txt, List<DongHo> list)
        {
            var s = list.Where(p => p.MaSP.Contains(txt)).Select(p => p).ToList();

            if (s.Count == 0)
            {
                MessageBox.Show("Không tồn tại sản phẩm");
            }
            return s;
        }
    }
}