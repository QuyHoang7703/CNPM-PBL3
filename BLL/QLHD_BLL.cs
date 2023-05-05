using CNPM_PBL3.DAL;
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
        public List<string> GetDBCBB()
        {
            List<string> list = new List<string>();
            foreach (DongHo i in dal.GetALLDH_DAL())
            {
                list.Add(i.MaSP);
            }
            return list;
        }
        public List<dynamic> GetAllHD_BLL()
        {
            List<dynamic> list = new List<dynamic>();
            //var s= dal.GetALLDH_DAL();
            foreach (var i in dal.GetAllHD_DAL())
            {
                var pt = new
                {

                    MaHoaDon = i.MaHD,
                    MaKhachHang = i.KhachHang.MaKH,
                    HoTen = i.KhachHang.HoTen,
                    NgayBan = i.NgayBan,
                    MaNhanVien = i.ID,

                };
                list.Add(pt);
            }
            return list;

        }
        public dynamic GetChiTietHoaDon(int maHD)
        {
            foreach (var i in dal.GetAllHD_DAL())
            {
                if (i.MaHD == maHD)
                    return i;
            }
            return null;
        }
        //public List<dynamic> Get
        public decimal GetDonGia(string maSP)
        {
            decimal giaSP = 0;
            foreach (var i in dal.GetALLDH_DAL())
            {
                if (i.MaSP == maSP)
                {
                    giaSP = i.GiaSP;
                }

            }
            return giaSP;
        }
        //bỏ bên QLSP
        public int GetSoLuong(string maSP)
        {
            int soLuong = 0;
            foreach (var i in dal.GetALLDH_DAL())
            {
                if (i.MaSP == maSP)
                {
                    soLuong = i.SoLuong;
                }
            }
            return soLuong;
        }
        public void AddHD(HoaDon hd, List<ChiTietHoaDon> list)
        {
            dal.AddHD_DAL(hd, list);
        }



        public void UpdateSoLuong(string maSP, int soLuong)
        {
            dal.UpDateSoLuong(maSP, soLuong);
        }

        public dynamic GetHD_ByTxtSearch(string text)
        {

            List<dynamic> list = new List<dynamic>();

            if (string.IsNullOrEmpty(text))
            {
                list = GetAllHD_BLL();
            }
            else
            {              
                int number;
                bool check = int.TryParse(text, out number);
                DateTime dateTime;
                bool checkDateTime = DateTime.TryParse(text, out dateTime);
                foreach (var i in GetAllHD_BLL())
                {
                    if ((check && i.MaHoaDon == number) || (checkDateTime && i.NgayBan.Date == dateTime) || i.HoTen.Contains(text))
                    {
                        list.Add(i);
                    }
                }               
            }
            return list;
        }



    }
}

