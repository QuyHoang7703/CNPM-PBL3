using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_PBL3.View
{
    public partial class FTypeCustomer : Form
    {
        public FTypeCustomer()
        {
            InitializeComponent();
        }

        private void butNewCustomer_Click(object sender, EventArgs e)
        {
            FAddCustomer fAddCustomer = new FAddCustomer();
            fAddCustomer.TopLevel = false;
            fAddCustomer.FormBorderStyle = FormBorderStyle.None;
            fAddCustomer.Dock = DockStyle.Fill;
            FMainManager.fBill.Controls.Add(fAddCustomer);
            fAddCustomer.BringToFront();
            fAddCustomer.Show();
            this.Dispose();
        }

        private void butOldCustomer_Click(object sender, EventArgs e)
        {
            FOldCustomer fOldCustomer = new FOldCustomer();
            fOldCustomer.TopLevel = false;
            fOldCustomer.FormBorderStyle = FormBorderStyle.None;
            fOldCustomer.Dock = DockStyle.Fill;
            FMainManager.fBill.Controls.Add(fOldCustomer);
            fOldCustomer.BringToFront();
            fOldCustomer.Show();
            this.Dispose();
        }

        private void ctbCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }
}
