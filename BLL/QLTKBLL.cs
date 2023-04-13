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
    internal class QLTKBLL
    {
        public TaiKhoan GetTaiKhoan(string username, string password)
        {
            QLTKDAL dal = new QLTKDAL();
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
     


    }
}
