using CNPM_PBL3.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_PBL3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            // Application.Run(new FSetting());
            // Application.Run(new FLogin());
            // Application.Run(new FClock());
            //Application.Run(new FDetailClock());
            // Application.Run(new FDetailStaff());
            // Application.Run(new FMainManager());
            //Application.Run(new FStaff());
            // Application.Run(new FLogin());
          //   Application.Run(new FHomePage());
            // Application.Run(new FCustomer());
            //Application.Run(new FBill());
            //Application.Run(new FAddCustomer());
            //Application.Run(new FPurchaseHistory());
             Application.Run(new FKhuyenMai());
           //Application.Run(new FPrintBill());

        }
    }
}
