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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CNPM_PBL3.View
{
    public partial class FDetailKhuyenMai : Form
    {
        QLKM_BLL bll = new QLKM_BLL();
        QLSP_BLL bllsp = new QLSP_BLL();
        public FDetailKhuyenMai()
        {
            InitializeComponent();
            SetCBBThuongHieu();
            GetChiTietKhuyenMai();
            ShowDGV();
        }

        public static int IdKhuyenMai = 0;
        public static decimal GiaTriKM = 0;
        public List<dynamic> list = new List<dynamic>();

        public void SetCBBThuongHieu()
        {
            cbbThuongHieu.Items.Add(new CBBItems { Text = "Tất cả" });
            cbbThuongHieu.Items.AddRange(bllsp.GetListCBBThuongHieu().ToArray());
        }
        public void SetCBBMaSP()
        {
            cbbSanPham.Items.AddRange(bll.GetListCBBSP().ToArray());
        }

        public int GetMaKM(string nameKM)
        {
            return bll.GetMaKM(nameKM);
        }

        string MaSP;
        int makm;

        public void ShowDGV()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaKhuyenMai");
            dt.Columns.Add("MaSanPham");
            dt.Columns.Add("TenThuongHieu");
            dt.Columns.Add("GiaTruocKhuyenMai");
            dt.Columns.Add("GiaSauKhuyenMai");
            foreach (dynamic i in list)
            {
                DataRow dr = dt.NewRow();
                dr["MaKhuyenMai"] = i.MaKhuyenMai;
                dr["MaSanPham"] = i.MaSP;
                dr["TenThuongHieu"] = i.TenThuongHieu;
                decimal myDecimal = i.GiaTruocKhuyenMai;
                string formattedDecimal = myDecimal.ToString("#,##0.000 đ");
                dr["GiaTruocKhuyenMai"] = formattedDecimal;
                decimal myDecimal1 = i.GiaSauKhuyenMai;
                string formattedDecimal1 = myDecimal1.ToString("#,##0.000 đ");
                dr["GiaSauKhuyenMai"] = formattedDecimal1;
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
        }

        private void cbbThuongHieu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbbThuongHieu.SelectedIndex == 0)
            {
                cbbSanPham.Items.Clear();
                SetCBBMaSP();
            }
            else
            {
                cbbSanPham.Items.Clear();
                string thuongHieu = cbbThuongHieu.SelectedItem.ToString();
                cbbSanPham.Items.AddRange(bll.GetListCBBSPByThuongHieu(thuongHieu).ToArray());
            }
        }
        public bool check()
        {
            bool b = true;
            if (cbbSanPham.SelectedIndex >= 0)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            return b;
        }
        string selectedItem;
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

            if (check())
            {
                dynamic ct = new
                {
                    MaKhuyenMai = IdKhuyenMai,
                    MaSP = cbbSanPham.SelectedItem.ToString(),
                    TenThuongHieu = cbbThuongHieu.SelectedItem.ToString(),
                    GiaTruocKhuyenMai = bllsp.GetGiaSPByIdSP(cbbSanPham.SelectedItem.ToString()),
                    GiaSauKhuyenMai = bllsp.GetGiaSPByIdSP(cbbSanPham.SelectedItem.ToString()) * ((100 - GiaTriKM) / 100)
                };

                selectedItem = cbbSanPham.SelectedItem.ToString();

                list.Add(ct);
                bll.UpdateKMByMaSP(ct.MaSP, ct.MaKhuyenMai);
                ShowDGV();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm nào ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            SetCBBMaSP();
        }

        public void cbbSanPham_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // MaSP = cbbSanPham.SelectedItem.ToString();
            // cbbSanPham.Items.Remove(selectedItem);
            //  cbbSanPham.Items.Clear();
            string thuongHieu = cbbThuongHieu.SelectedItem.ToString();
            cbbSanPham.Items.AddRange(bll.GetListCBBSPByThuongHieu(thuongHieu).ToArray());
        }

        public void GetChiTietKhuyenMai()
        {

            foreach (var i in bllsp.GetSPByMaKM(IdKhuyenMai))
            {

                dynamic t = new
                {
                    MaKhuyenMai = i.MaKhuyenMai,
                    MaSP = i.MaSP,
                    TenThuongHieu = i.ThuongHieu.TenThuongHieu,
                    GiaTruocKhuyenMai = i.GiaSP,
                    GiaSauKhuyenMai = i.GiaSP * ((100 - GiaTriKM) / 100)
                };
                list.Add(t);
            }
        }
        int index = -1;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 0)
            {
                if (MessageBox.Show("Bạn có muốn xóa sản phẩm này khỏi đợt khuyến mãi ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    List<string> data = new List<string>();
                    List<decimal> listPrice = new List<decimal>();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        data.Add(row.Cells["MaSanPham"].Value.ToString());
                        //      listPrice.Add(Convert.ToDecimal(row.Cells["GiaTruocKhuyenMai"].Value.ToString()));
                    }
                    bll.DeleteKM(data);
                    //bll.PriceListUpdate(data, listPrice);
                    //   int h = 0;

                    foreach (string item in data)
                    {
                        foreach (var i in list)
                        {
                            if (i.MaSP == item)
                            {
                                list.Remove(i);
                                break;
                            }
                        }
                    }

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
