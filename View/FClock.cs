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
        }
        public void GetCBBThuongHieu()
        {
            cbbThuongHieu.Items.Add("");
            cbbThuongHieu.Items.AddRange(bll.GetListCBBThuongHieu().ToArray());
        }
        public void GetCBBGioiTinhSP()
        {
            cbbGioiTinh.Items.Add("");
            cbbGioiTinh.Items.AddRange(bll.GetGioiTinhSP_BLL().Distinct().ToArray());
        }
        public void GetCBBBoMayNangLuong()
        {
            cbbBoMayNangLuong.Items.Add("");
            cbbBoMayNangLuong.Items.AddRange(bll.GetBoMayNangLuong_BLL().Distinct().ToArray());
        }
        public void GetMauMatSo()
        {
            cbbMauMatSo.Items.Add("");
            cbbMauMatSo.Items.AddRange(bll.GetMauMatSo_BLL().Distinct().ToArray());
        }
        public void GetHinhDangMatSo()
        {
            cbbHinhDangMatSo.Items.Add("");
            cbbHinhDangMatSo.Items.AddRange(bll.GetHinhDangMatSo_BLL().Distinct().ToArray());
        }
        public void GetChatLieuMatKinh()
        {
            cbbChatLieuMatKinh.Items.Add("");
            cbbChatLieuMatKinh.Items.AddRange(bll.GetChatLieuMatKinh_BLL().Distinct().ToArray());
        }
        public void GetChatLieuDay()
        {
            cbbChatLieuDay.Items.Add("");
            cbbChatLieuDay.Items.AddRange(bll.GetChatLieuDay_BLL().Distinct().ToArray());
        }
        public void GetXuatXu()
        {
            cbbXuatXu.Items.Add("");
            cbbXuatXu.Items.AddRange(bll.GetXuatXu_BLL().Distinct().ToArray());
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
           
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.GetSPByTxtSearch(txtsearch.Text);
        }

        private void cbbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void SetCBBThuongHieu1()
        {
            cbbThuongHieu.Items.AddRange(bll.GetListCBBThuongHieu().ToArray());
        }
        public void showTimKiem(ComboBox cbbTH, ComboBox cbbGT, ComboBox cbbBMNL, ComboBox cbbMMS, ComboBox cbbHDMS, ComboBox cbbCLMK, ComboBox cbbCLD, ComboBox cbbXX)
        {
            //ShowDGV(bll.TimKiem_BLL(cbbTH, cbbGT, cbbBMNL, cbbMMS, cbbHDMS, cbbCLMK, cbbCLD, cbbXX));
          
        }


        private void cbbThuongHieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void butTimKiem_Click(object sender, EventArgs e)
        {
            showTimKiem(cbbThuongHieu, cbbGioiTinh, cbbBoMayNangLuong, cbbMauMatSo, cbbHinhDangMatSo, cbbChatLieuMatKinh, cbbChatLieuDay, cbbXuatXu);
        }
    }
}
