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
    public partial class FOldCustomer : Form
    {
        public FOldCustomer()
        {
            InitializeComponent();
            ShowDGV(bll.GetAllKH_BLL());
        }
        QLKH_BLL bll = new QLKH_BLL();
        public KhachHang khachHang;
       
        public void ShowDGV(List<dynamic> list)
        {
            dgvOldCustomer.DataSource = list;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            ShowDGV(bll.GetKH_ByTxtSearch(txtsearch.Text));
        }

        private void butChooseKH_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection l = dgvOldCustomer.SelectedRows;
            if (l.Count == 1)
            {
                DialogResult result =MessageBox.Show("Bạn có chọn khách hàng này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    khachHang = new KhachHang()
                    {
                        MaKH = Convert.ToInt32(l[0].Cells["MaKH"].Value.ToString()),
                        HoTenKH = l[0].Cells["HoTenKH"].Value.ToString(),
                        NgaySinh = Convert.ToDateTime(l[0].Cells["NgaySinh"].Value.ToString()),
                        SDT = l[0].Cells["SDT"].Value.ToString(),
                        DiaChi = l[0].Cells["DiaChi"].Value.ToString(),
                        GioiTinh = Convert.ToBoolean(l[0].Cells["GioiTinh"].Value.ToString())
                    };
                    FBill.idKhacHang = khachHang.MaKH;
                    this.Dispose();
                }
                
            }
            else
            {
                MessageBox.Show("Vui lòng chỉ chọn 1 khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }

}
