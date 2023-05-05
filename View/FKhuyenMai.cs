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
    public partial class FKhuyenMai : Form
    {
        public delegate void Mydel_3(int MaKM);
        public Mydel_3 d1 { get; set; }

        QLKM_BLL bll = new QLKM_BLL();
        QLSP_BLL bllsp = new QLSP_BLL();
        public FKhuyenMai()
        {
            InitializeComponent();
            ShowDGV();
        }



        public void ShowDGV()
        {
            dataGridView1.DataSource = bll.GetAllKhuyenMai_BLL();
        }
        public void Reset()
        {
            txtTenKm.Text = txtGiaTri.Text = txtTinhTrang.Text = "";
            dateBatDau.Value = dateKetThuc.Value = DateTime.Now;
        }

       
        private void butthem_Click_1(object sender, EventArgs e)
        {
            KhuyenMai khuyenMai = new KhuyenMai();
            khuyenMai.TenKhuyenMai = txtTenKm.Text;
            khuyenMai.GiaTriKhuyenMai = float.Parse(txtGiaTri.Text);
            khuyenMai.NgayBatDau = dateBatDau.Value;
            khuyenMai.NgayKetThuc = dateKetThuc.Value;
            bll.AddKM_BLL(khuyenMai);
            //   UpdateKMByMASP(GetListMaSP(), GetMaKM(khuyenMai.TenKhuyenMai));
            Reset();
            ShowDGV();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    txtTenKm.Text = row.Cells["TenKHuyenMai"].Value.ToString();
                    txtGiaTri.Text = row.Cells["GiaTriKhuyenMai"].Value.ToString();
                    if (dateBatDau.Value <= DateTime.Now && dateKetThuc.Value >= DateTime.Now)
                    {
                        txtTinhTrang.Text = "Đang diễn ra";
                    }
                    else
                    {
                        txtTinhTrang.Text = "Hết đợt khuyến mãi";
                    }
                    dateBatDau.Value = (DateTime)row.Cells["NgayBatDau"].Value;
                    dateKetThuc.Value = (DateTime)row.Cells["NgayKetThuc"].Value;
                }
            }
            FDetailKhuyenMai.IdKhuyenMai = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            FDetailKhuyenMai.GiaTriKM = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value.ToString());
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            KhuyenMai khuyenMai = new KhuyenMai();
            khuyenMai.MaKhuyenMai = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            khuyenMai.TenKhuyenMai = txtTenKm.Text;
            khuyenMai.GiaTriKhuyenMai = float.Parse(txtGiaTri.Text);
            khuyenMai.NgayBatDau = dateBatDau.Value;
            khuyenMai.NgayKetThuc = dateKetThuc.Value;
            bll.UpdateAllKM(khuyenMai);
            Reset();
            ShowDGV();
        }
        private void butChiTiet_Click_1(object sender, EventArgs e)
        {
            int maKM = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            FDetailKhuyenMai f = new FDetailKhuyenMai();
            
            f.ShowDialog();
        }
        public void UpdateKm(int makm)
        {
            bll.UpdateKM(makm);
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int makm = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                if (MessageBox.Show("Bạn có muốn xóa đợt khuyến mãi này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    UpdateKm(makm);
                    bll.DeleteKMByMaKM(makm);
                    ShowDGV();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
