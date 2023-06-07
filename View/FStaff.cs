using CNPM_PBL3.BLL;
using CNPM_PBL3.DAL;
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
    public partial class FStaff : Form
    {
        QLNV_BLL bll = new QLNV_BLL();
        public delegate void MydelFStaff(int id);
        public MydelFStaff d { get; set; }
        public FStaff()
        {
            InitializeComponent();
            showDGV(bll.GetAllNV_BLL());
            setCBBSort();
            setCBBItems();
        }
        public void setCBBSort()
        {
            cbbSort.Items.Add("Tăng dần");
            cbbSort.Items.Add("Giảm dần");
        }
        public void setCBBItems()
        {
            foreach(DataGridViewColumn i in dgvNV.Columns)
            {
                string columnName = i.HeaderText;
                cbbItems.Items.Add(columnName);
                
            }
        }
        public void showDGV(List<dynamic> list)
        {
            dgvNV.DataSource = list;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            FDetailStaff f = new FDetailStaff();
            f.d += new FDetailStaff.Mydel(showDGV);
            f.ShowDialog();
        }

        
        private void txttSearch_TextChanged(object sender, EventArgs e)
        {
            showDGV(bll.GetNV_ByTxtSearch(txttSearch.Text));
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection l = dgvNV.SelectedRows;
            if(l.Count==0)
            {
                MessageBox.Show("Vui lòng hãy chọn nhân viên muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result=MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    foreach (DataGridViewRow i in l)
                    {
                        int id = Convert.ToInt32(i.Cells["ID"].Value.ToString());
                        bll.DeleteNV_BLL(id);
                    }
                    showDGV(bll.GetAllNV_BLL());
                }
               
            }
        }

        private void butDetailStaff_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection l = dgvNV.SelectedRows;
            if(l.Count==1)
            {
                FDetailStaff f = new FDetailStaff();
                this.d += new FStaff.MydelFStaff(f.GetDetailStaff);
                d(Convert.ToInt32(l[0].Cells["ID"].Value.ToString()));
                
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 nhân viên để xem");
            }
            
        }

        private void butSort_Click(object sender, EventArgs e)
        {
            if(cbbItems.SelectedItem!=null && cbbSort.SelectedItem != null)
            {
                string columnname = cbbItems.SelectedItem.ToString();
                string direction = cbbSort.SelectedItem.ToString();
                showDGV(bll.SortBy_BLL(columnname, direction));
            }
            else
            {
                MessageBox.Show("Hãy chọn mục sắp xếp và chiều sắp xếp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
          
        }

       
    }
}
