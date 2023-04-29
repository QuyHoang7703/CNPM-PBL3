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
            foreach(DongHo i in dal.GetAllSP1_DAL())
            {
                if (i.MaSP == m)
                {
                    data = i;
                    break;
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
            if(GetSPBYMaSP(s.MaSP) != null) 
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
        public dynamic TimKiem_BLL(ComboBox th, ComboBox gt)
        {
            return dal.TinKiem(th, gt);
        }
    }
}
