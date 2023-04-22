using CNPM_PBL3.DAL;
using System;
using System.Collections.Generic;
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
        public TaiKhoan GetTaiKhoan(string username, string password)
        {
            
            TaiKhoan t = null;
            foreach (TaiKhoan i in dal.GetDBTaiKhoan())
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
            dal.UpdatePass_DAL(pass);
        }
        public void UpdateInformation_BLL(ChiTietTaiKhoan ct)
        {
            dal.UpdateInformation_DAL(ct);
           
        }
        public dynamic GetChiTietTaiKhoan_ByID_BLL(int id)
        {
            return dal.GetChiTietTaiKhoan_ByID_DAL(id);
        }


    }

}
