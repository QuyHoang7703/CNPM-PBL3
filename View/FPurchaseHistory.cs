using CNPM_PBL3.BLL;
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
    public partial class FPurchaseHistory : Form
    {
        public FPurchaseHistory()
        {
            InitializeComponent();
            ShowDGV(bll.GetAllHD_BLL_ForDGV());
        }
        QLHD_BLL bll = new QLHD_BLL();
        public void ShowDGV(List<dynamic> list)
        {
            dgvLSMH.DataSource=list;
        }

        private void butDetailBill_Click(object sender, EventArgs e)
        {
            FDetailBill f = new FDetailBill();
            DataGridViewSelectedRowCollection l = dgvLSMH.SelectedRows;
            if (l.Count == 1)
            {
                dynamic t = bll.GetChiTietHoaDon(Convert.ToInt32(l[0].Cells["MaHoaDon"].Value.ToString()));
                f.GetChiTiet(t);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn để in", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            
                ShowDGV(bll.GetHD_ByTxtSearch(txtsearch.Text));
            
           
        }

        private void butInHoaDon_Click(object sender, EventArgs e)
        {
            FPrintBill fPrintBill= new FPrintBill();
            DataGridViewSelectedRowCollection l = dgvLSMH.SelectedRows;
            if(l.Count == 1)
            {
                fPrintBill.idKH = Convert.ToInt32(l[0].Cells["MaKhachHang"].Value.ToString());
                fPrintBill.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn để in", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
