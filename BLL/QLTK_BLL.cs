using CNPM_PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CNPM_PBL3.BLL
{
    internal class QLTK_BLL
    {
        QLTK_DAL dal = new QLTK_DAL();
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            QLDB db = new QLDB();
            var s = db.TaiKhoans.Select(p => p).ToList();
            list = s;
            return list;
        }
        public TaiKhoan GetTaiKhoan(string username, string password)
        {         
            TaiKhoan t = null;
            foreach (TaiKhoan i in GetAllTaiKhoan())
            {
                if (i.UserName == username)
                {
                    if (i.Pass == password)
                    {
                        t = i;
                        break;
                    }

                }
            }
            return t;

        }
        public void UpdatePass_BLL(string pass)
        {
            QLDB db = new QLDB();
            var s = db.TaiKhoans.Find(FLogin.account.ID);
            s.Pass = pass;
            db.SaveChanges();
        }
        public void UpdateInformation_BLL(ChiTietTaiKhoan ct)
        {
            QLDB db = new QLDB();
            var s = db.ChiTietTaiKhoans.Find(ct.ID);
            s.HoTen = ct.HoTen;
            s.SDT = ct.SDT;
            s.NgaySinh = ct.NgaySinh;
            s.GioiTinh = ct.GioiTinh;
            s.DiaChi = ct.DiaChi;
            s.AnhDaiDien = ct.AnhDaiDien;
            s.Email = ct.Email;
            db.SaveChanges();

        }
        //public dynamic GetChiTietTaiKhoan_ByID_BLL(int id)
        //{
        //    return dal.GetChiTietTaiKhoan_ByID_DAL(id);
        //}
        public ChiTietTaiKhoan GetChiTietTaiKhoan_ByID_BLL(int id)
        {
            QLDB db = new QLDB();
            ChiTietTaiKhoan ct = db.ChiTietTaiKhoans.Find(id);
            return ct;
        }
        // moi lam
        public bool GetTaiKhoanByEmail_BLL(string username, string email)
        {
            bool check = false;
            foreach (TaiKhoan i in GetAllTaiKhoan())
            {
                if (i.UserName == username && i.ChiTietTaiKhoan.Email==email )
                {
                    check= true;
                    break;
                }
            }
            return check;
        }
        public int getIdByUserName_BLL(string username)
        {
            int result = 0;
            //dal = new QLTK_DAL();
            foreach (TaiKhoan i in GetAllTaiKhoan())
            {
                if (i.UserName == username)
                {
                    result = i.ID;
                }
            }
            return result;
        }
        public void UpdatePassForFogotLogin_BLL(int ID, string password)
        {
            try
            {
                QLDB db = new QLDB();
                TaiKhoan taiKhoan = db.TaiKhoans.Find(ID);
                taiKhoan.Pass = password;
                db.SaveChanges();

            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
