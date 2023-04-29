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
    public partial class FClock : Form
    {
        QLSP_BLL bll = new QLSP_BLL();
        public FClock()
        {
            InitializeComponent();
            ShowDGV(bll.GetAllSP_BLL());
            SetCBBThuongHieu();
        }

        public void ShowDGV(dynamic s)
        {
            dataGridView1.DataSource= s;
        }

        private void ButThem_Click(object sender, EventArgs e)
        {
            FDetailClock f = new FDetailClock();
            f.d1 += new FDetailClock.Mydel1(ShowDGV);
            f.ShowDialog();
        }

        private void ButCapNhat_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                string MaSP = dataGridView1.SelectedRows[0].Cells["MaSP"].Value.ToString();
                FDetailClock f = new FDetailClock(MaSP);
                f.d1 += new FDetailClock.Mydel1(ShowDGV);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chỉ chọn 1 sản phẩm !");
            }
        }

        private void ButXoa_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count >= 0)
            {
                List<string> ListMaSP = new List<string>();
                foreach(DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    ListMaSP.Add(i.Cells["MaSP"].Value.ToString());
                }
                bll.DeleteSP_BLL(ListMaSP);
                ShowDGV(bll.GetAllSP_BLL());
            }          
        }

        private void ButSapXep_Click(object sender, EventArgs e)
        {
            // Sắp xếp danh sách sinh viên theo điểm từ cao đến thấp
           //   sinhVienList.Sort((sv1, sv2) => sv2.Diem.CompareTo(sv1.Diem));

            // Gán danh sách đã sắp xếp cho DataSource của DataGridView
           // dataGridView1.DataSource = sinhVienList;
            //List<DongHo> list = bll.GetAllSP_BLL();
            //list.Sort((l1, l2) => l2.GiaSP.CompareTo(l1.GiaSP));
            //dataGridView1.DataSource = list;
        }

        private void việtNamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            string clickedItemName = clickedItem.Text;          
            dataGridView1.DataSource = bll.GetSPByXuatXu_BLL(clickedItemName);
        }

        private void namToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            string clickedItemName = clickedItem.Text;
            dataGridView1.DataSource = bll.GetSPByGender_BLL(clickedItemName);
        }

        private void hìnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            string clickedItemName = clickedItem.Text;
            dataGridView1.DataSource = bll.GetSPByShape_BLL(clickedItemName);
        }

        private void xanhDươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            string clickedItemName = clickedItem.Text;
            dataGridView1.DataSource = bll.GetSPByColor_BLL(clickedItemName);
        }
        public void SetCBBThuongHieu()
        {
            toolStripComboBox1.Items.AddRange(bll.GetListCBBThuongHieu().ToArray());
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.GetSPByBrand_BLL(toolStripComboBox1.SelectedItem.ToString());
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.GetSPByTxtSearch(txtsearch.Text);

        }
    }
}
