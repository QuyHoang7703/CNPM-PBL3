using CNPM_PBL3.BLL;
using Guna.UI2.WinForms;
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
    public partial class FSale : Form
    {

        QLKM_BLL bll = new QLKM_BLL();
        QLSP_BLL bllsp = new QLSP_BLL();
        public FSale()
        {
            InitializeComponent();
            ShowDGV();
            AutoUpdateGiaTriKM();
            Enable(false);
        }
        bool check;
        public void Enable(bool enable)
        {
            txtTenKm.Enabled = txtGiaTri.Enabled = guna2HtmlLabel6.Enabled = dateBatDau.Enabled = dateKetThuc.Enabled = enable;
        }
        public void ShowDGV()
        {
            dataGridView1.DataSource = bll.GetAllKhuyenMai_BLL();
        }
        public bool CheckTextBox()
        {
            bool hasEmptyControl = false;
            foreach (Control control in this.Controls)
            {
                if (control is Guna2TextBox)
                {
                    Guna2TextBox textBox = (Guna2TextBox)control;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        hasEmptyControl = true;
                        break;
                    }
                }
            }
            if (hasEmptyControl)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin vào các ô trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckDate()
        {
            if (dateBatDau.Value > dateKetThuc.Value)
            {
                MessageBox.Show("Thời gian khuyến mãi không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        public bool Exception()
        {
            try
            {
                float giatrikm = float.Parse(txtGiaTri.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        

        private void butThem_Click_1(object sender, EventArgs e)
        {
            check = true;
            butCapNhap.Enabled = butChiTiet.Enabled = butXoa.Enabled = false;
            butLuu.Enabled = true;
            guna2HtmlLabel6.Text = txtTenKm.Text = txtGiaTri.Text = "";
            dateBatDau.Value = dateKetThuc.Value = DateTime.Now;
            Enable(true);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    txtTenKm.Text = row.Cells["TenKHuyenMai"].Value.ToString();
                    txtGiaTri.Text = row.Cells["GiaTriKhuyenMai"].Value.ToString();
                    dateBatDau.Value = (DateTime)row.Cells["NgayBatDau"].Value;
                    dateKetThuc.Value = (DateTime)row.Cells["NgayKetThuc"].Value;
                    if (dateBatDau.Value <= DateTime.Now && dateKetThuc.Value >= DateTime.Now)
                    {
                        guna2HtmlLabel6.Text = "Đang diễn ra";
                        butChiTiet.Enabled = true;
                    }
                    else if (dateBatDau.Value > DateTime.Now)
                    {
                        guna2HtmlLabel6.Text = "Chưa diễn ra";
                        butChiTiet.Enabled = false;
                    }
                    else if (dateKetThuc.Value < DateTime.Now)
                    {
                        guna2HtmlLabel6.Text = "Hết đợt khuyến mãi";
                        butChiTiet.Enabled = false;
                    }
                    FDetailSale.IdKhuyenMai = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    FDetailSale.GiaTriKM = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value.ToString());

                }
            }

            Enable(false);
            butThem.Enabled = butCapNhap.Enabled = butXoa.Enabled = true;
            butLuu.Enabled = false;
        }
        private void butCapNhap_Click_1(object sender, EventArgs e)
        {
            check = false;
            Enable(true);
            butThem.Enabled = butChiTiet.Enabled = butXoa.Enabled = false;
            butLuu.Enabled = true;
        }
       
        private void butLuu_Click_1(object sender, EventArgs e)
        {
            if (CheckTextBox() == false && CheckDate() == false && Exception())
            {
                KhuyenMai khuyenMai = new KhuyenMai();
                khuyenMai.MaKhuyenMai = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                khuyenMai.TenKhuyenMai = txtTenKm.Text;
                khuyenMai.GiaTriKhuyenMai = float.Parse(txtGiaTri.Text);
                khuyenMai.NgayBatDau = dateBatDau.Value;
                khuyenMai.NgayKetThuc = dateKetThuc.Value;
                if (check == false)
                {
                    bll.UpdateAllKM(khuyenMai);
                }
                else
                {
                    bll.AddKM_BLL(khuyenMai);
                }
                txtTenKm.Text = txtGiaTri.Text = guna2HtmlLabel6.Text = "";
                dateBatDau.Value = dateKetThuc.Value = DateTime.Now;
                ShowDGV();
            }
          
        }
        private void butChiTiet_Click_1(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection l = dataGridView1.SelectedRows;
            if (l.Count == 1)
            {
                //int maKM = Convert.ToInt32(l[0].Cells["MaKhuyenMai"].Value.ToString());
                FDetailSale f = new FDetailSale();
                
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chỉ chọn một mã khuyến mãi để xem", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void butXoa_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa đợt khuyến mãi này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    List<int> listMaKM = new List<int>();
                    List<decimal> listPrice = new List<decimal>();
                    foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                    {
                        listMaKM.Add(Convert.ToInt32(i.Cells["MaKhuyenMai"].Value.ToString()));
                    }
                    bll.UpdateKM(listMaKM);
                    bll.DeleteKMByMaKM(listMaKM);
                    ShowDGV();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void AutoUpdateGiaTriKM()
        {
            List<int> data = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((DateTime)row.Cells["NgayKetThuc"].Value < DateTime.Now)
                {
                    data.Add(Convert.ToInt32(row.Cells["MaKhuyenMai"].Value.ToString()));
                }
            }
            bll.UpdateKM(data);
        }

       
    }
}
