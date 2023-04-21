using CNPM_PBL3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM_PBL3.BLL
{
    internal class QLNVBLL
    {
        public dynamic GetAllNVBLL()
        {
            QLNVDAL dal = new QLNVDAL();
            var s = dal.GetAllNVDAL();
            return s;
        }

    }
}
