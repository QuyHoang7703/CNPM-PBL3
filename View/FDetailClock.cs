using CNPM_PBL3.BLL;
using CNPM_PBL3.DAL;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_PBL3.View
{
    public partial class FDetailClock : Form
    {
        QLSP_BLL bll= new QLSP_BLL();
        public delegate void Mydel1(dynamic a);
        public Mydel1 d1 { get; set; }
        private string MasP;
        public FDetailClock(string m = null)
        {
            InitializeComponent();
            SetCBBThuongHieu();
            SetCBBKhuyenMai();
            MasP = m;
            SetGUI();
        }
        private void SetGUI()
        {
            if (bll.GetSPBYMaSP(MasP) != null)
            {
                QLHA qLHA_DAL = new QLHA();
                DongHo d = bll.GetSPBYMaSP(MasP);
                txtMasp.Text = MasP.ToString();
                txtMasp.Enabled = false;
                txtXuatxu.Text = d.XuatSu.ToString();
                txtGia.Text = d.GiaSP.ToString();
                comboMaumatso.Text = d.MauMatSo.ToString();
                txtDuongkinh.Text = d.DuongKinhMatSo.ToString();
                txtGiatriBH.Text = d.GiaTriBaoHanh.ToString();
                txtSoluong.Text = d.SoLuong.ToString();
                txtBedaymatso.Text = d.BeDayMatSo.ToString();
                string nameTH = d.ThuongHieu.TenThuongHieu;
                comboThuonghieu.SelectedIndex = bll.GetMaTH_BLL(nameTH) -1;
                comboGioitinh.Text = d.GioiTinhSP;
                comboBomayNL.Text = d.BoMayNangLuong;
                comboChatlieuday.Text = d.ChatLieuDay;
                comboHinhdang.Text = d.HinhDangMatSo;
                comboMucCN.Text = d.MucChongNuoc;
                comboChatlieumatkinh.Text = d.ChatLieuMatKinh;
                picHinhAnh.Image = qLHA_DAL.ConverByteToTmage(d.HinhAnh);
                string nameKM = d.KhuyenMai.TenKhuyenMai;
                comboMaKM.SelectedIndex = bll.GetMaKM_BLL(nameKM) - 2;
            }
        }
        public void SetCBBThuongHieu()
        {
            comboThuonghieu.Items.AddRange(bll.GetListCBBThuongHieu().ToArray());
        }
        public void SetCBBKhuyenMai()
        {
            comboMaKM.Items.AddRange(bll.GetListCBBKhuyenMai().ToArray());
        }

        private void ButThemHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png, .jpg) | *.png; *.jpg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(openFile.FileName);
                picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        public bool  Check()
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
                else if (control is Guna2ComboBox)
                {
                    Guna2ComboBox comboBox = (Guna2ComboBox)control;
                    if (comboBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(comboBox.SelectedItem.ToString()))
                    {
                        hasEmptyControl = true;
                        break;
                    }
                }
                else if(picHinhAnh.Image == null)
                {
                    hasEmptyControl = true;
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
        
        private void ButLuu_Click(object sender, EventArgs e)
        {
            QLHA ha = new QLHA();
            if (Check() == false && bll.CheckID(txtMasp.Text))
            {
                DongHo dongHo = new DongHo
                {
                    MaSP = txtMasp.Text,
                    XuatSu = txtXuatxu.Text,
                    GioiTinhSP = comboGioitinh.Text,
                    ChatLieuMatKinh = comboChatlieumatkinh.Text,
                    BoMayNangLuong = comboBomayNL.Text,
                    MauMatSo = comboMaumatso.Text,
                    ChatLieuDay = comboChatlieuday.Text,
                    BeDayMatSo = Convert.ToDouble(txtBedaymatso.Text),
                    DuongKinhMatSo = Convert.ToDouble(txtDuongkinh.Text),
                    HinhDangMatSo = comboHinhdang.Text,
                    MucChongNuoc = comboMucCN.Text,
                    HinhAnh = ha.ImageToByteArray(picHinhAnh.Image),
                    GiaTriBaoHanh = Convert.ToDouble(txtGiatriBH.Text),
                    GiaSP = Convert.ToDecimal(txtGia.Text),
                    SoLuong = Convert.ToInt32(txtSoluong.Text),
                    MaKhuyenMai = ((CBBItems)comboMaKM.SelectedItem).Value,
                    MaThuongHieu = ((CBBItems)comboThuonghieu.SelectedItem).Value
                };
                bll.ExecuteDB(dongHo);
                d1(bll.GetAllSP_BLL());
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Sản phẩm đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboThuonghieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
