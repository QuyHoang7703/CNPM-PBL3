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
           
            GetCBBThuongHieu();
            GetCBBGioiTinhSP();
            GetCBBBoMayNangLuong();
            GetMauMatSo();
            GetHinhDangMatSo();
            GetChatLieuMatKinh();
            GetChatLieuDay();
            GetXuatXu();
            GetGiaSP();
            //showTimKiem(cbbThuongHieu, cbbGioiTinh, cbbBoMayNangLuong, cbbMauMatSo, cbbHinhDangMatSo, cbbChatLieuMatKinh, cbbChatLieuDay, cbbXuatXu, cbbGiaSP);
            ShowDGV();
        }
        public void GetCBBThuongHieu()
        {
            cbbThuongHieu.Items.Add("Tất cả");
            cbbThuongHieu.Items.AddRange(bll.GetListCBBThuongHieu().ToArray());
        }
        public void GetCBBGioiTinhSP()
        {
            cbbGioiTinh.Items.Add("Tất cả");
            cbbGioiTinh.Items.AddRange(bll.GetGioiTinhSP_BLL().Distinct().ToArray());
        }
        public void GetCBBBoMayNangLuong()
        {
            cbbBoMayNangLuong.Items.Add("Tất cả");
            cbbBoMayNangLuong.Items.AddRange(bll.GetBoMayNangLuong_BLL().Distinct().ToArray());
        }
        public void GetMauMatSo()
        {
            cbbMauMatSo.Items.Add("Tất cả");
            cbbMauMatSo.Items.AddRange(bll.GetMauMatSo_BLL().Distinct().ToArray());
        }
        public void GetHinhDangMatSo()
        {
            cbbHinhDangMatSo.Items.Add("Tất cả");
            cbbHinhDangMatSo.Items.AddRange(bll.GetHinhDangMatSo_BLL().Distinct().ToArray());
        }
        public void GetChatLieuMatKinh()
        {
            cbbChatLieuMatKinh.Items.Add("Tất cả");
            cbbChatLieuMatKinh.Items.AddRange(bll.GetChatLieuMatKinh_BLL().Distinct().ToArray());
        }
        public void GetChatLieuDay()
        {
            cbbChatLieuDay.Items.Add("Tất cả");
            cbbChatLieuDay.Items.AddRange(bll.GetChatLieuDay_BLL().Distinct().ToArray());
        }
        public void GetXuatXu()
        {
            cbbXuatXu.Items.Add("Tất cả");
            cbbXuatXu.Items.AddRange(bll.GetXuatXu_BLL().Distinct().ToArray());
        }
        public void GetGiaSP()
        {
            cbbGiaSP.Items.Add("Tất cả");
            cbbGiaSP.Items.Add("10.0000-50.0000");
            cbbGiaSP.Items.Add("50.0000-150.0000");
            cbbGiaSP.Items.Add("150.0000-250.0000");
            cbbGiaSP.Items.Add("Trên 250.0000 ");
        }

        public void ShowDGV(dynamic s)
        {
            dataGridView1.DataSource= s;
        }
        public void ShowDGV()
        {
            dataGridView1.DataSource = bll.GetAllSP_BLL_ForDGV();
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
                ShowDGV(bll.GetAllSP_BLL_ForDGV());
            }          
        }

        private void ButSapXep_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = bll.GetSPByTxtSearch(txtsearch.Text);
        }

        private void cbbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void SetCBBThuongHieu1()
        {
            cbbThuongHieu.Items.AddRange(bll.GetListCBBThuongHieu().ToArray());
        }
        public void showTimKiem(ComboBox cbbTH, ComboBox cbbGT, ComboBox cbbBMNL, ComboBox cbbMMS, ComboBox cbbHDMS, ComboBox cbbCLMK, ComboBox cbbCLD, ComboBox cbbXX, ComboBox cbbGSP)
        {
            ShowDGV(bll.TimKiemFClock_BLL(cbbTH, cbbGT, cbbBMNL, cbbMMS, cbbHDMS, cbbCLMK, cbbCLD, cbbXX, cbbGSP));
          
        }


        private void cbbThuongHieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void butTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsearch.Text))
            {
                showTimKiem(cbbThuongHieu, cbbGioiTinh, cbbBoMayNangLuong, cbbMauMatSo, cbbHinhDangMatSo, cbbChatLieuMatKinh, cbbChatLieuDay, cbbXuatXu, cbbGiaSP);
            }
            else
            {
                ShowDGV(bll.TimKiemFClock_All_BLL(txtsearch.Text, cbbThuongHieu, cbbGioiTinh, cbbBoMayNangLuong, cbbMauMatSo, cbbHinhDangMatSo, cbbChatLieuMatKinh, cbbChatLieuDay, cbbXuatXu, cbbGiaSP));
            }
        }

        private void FClock_Load(object sender, EventArgs e)
        {
            cbbThuongHieu.SelectedIndex = 0;
            cbbGioiTinh.SelectedIndex = 0;
            cbbBoMayNangLuong.SelectedIndex = 0;
            cbbMauMatSo.SelectedIndex = 0;
            cbbHinhDangMatSo.SelectedIndex = 0;
            cbbChatLieuMatKinh.SelectedIndex = 0;
            cbbChatLieuDay.SelectedIndex = 0;
            cbbXuatXu.SelectedIndex = 0;
            cbbGiaSP.SelectedIndex = 0;
            showTimKiem(cbbThuongHieu, cbbGioiTinh, cbbBoMayNangLuong, cbbMauMatSo, cbbHinhDangMatSo, cbbChatLieuMatKinh, cbbChatLieuDay, cbbXuatXu, cbbGiaSP);
        }

        private void butAll_Click(object sender, EventArgs e)
        {
            cbbThuongHieu.SelectedIndex = 0;
            cbbGioiTinh.SelectedIndex = 0;
            cbbBoMayNangLuong.SelectedIndex = 0;
            cbbMauMatSo.SelectedIndex = 0;
            cbbHinhDangMatSo.SelectedIndex = 0;
            cbbChatLieuMatKinh.SelectedIndex = 0;
            cbbChatLieuDay.SelectedIndex = 0;
            cbbXuatXu.SelectedIndex = 0;
            cbbGiaSP.SelectedIndex = 0;
            showTimKiem(cbbThuongHieu, cbbGioiTinh, cbbBoMayNangLuong, cbbMauMatSo, cbbHinhDangMatSo, cbbChatLieuMatKinh, cbbChatLieuDay, cbbXuatXu, cbbGiaSP);
        }
    }
}
