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
        QLTH_BLL bllth = new QLTH_BLL();
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
                comboThuonghieu.Text = nameTH;
                comboGioitinh.Text = d.GioiTinhSP;
                comboBomayNL.Text = d.BoMayNangLuong;
                comboChatlieuday.Text = d.ChatLieuDay;
                comboHinhdang.Text = d.HinhDangMatSo;
                comboMucCN.Text = d.MucChongNuoc;
                comboChatlieumatkinh.Text = d.ChatLieuMatKinh;
                picHinhAnh.Image = qLHA_DAL.ConverByteToTmage(d.HinhAnh);
                if(d.MaKhuyenMai != null)
                {
                    string nameKM = d.KhuyenMai.TenKhuyenMai;
                   comboMaKM.Text = nameKM;
                }
                else
                {
                    comboMaKM.SelectedIndex = 0;
                }
               
            }
        }
        public void SetCBBThuongHieu()
        {
            comboThuonghieu.Items.AddRange(bll.GetListCBBThuongHieu().ToArray());
        }
        public void SetCBBKhuyenMai()
        {
            comboMaKM.Items.Add("");
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
                    if (comboBox.Name != "comboThuonghieu1" && comboBox.Name != "comboMaKM" && (comboBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(comboBox.SelectedItem.ToString())))
                    {
                        hasEmptyControl = true;
                        break;
                    }
                    else if (comboBox.Name == "comboMaKM")
                    {
                        hasEmptyControl = false;
                    }
                    else if (comboBox.Name == "comboThuonghieu1")
                    {
                        hasEmptyControl = false;
                    }
                }
                else if (picHinhAnh.Image == null)
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
        public bool Exception()
        {
            try
            {
                float bedaymatso = float.Parse(txtBedaymatso.Text);
                decimal giaTien = decimal.Parse(txtGia.Text);
                float giatriBH = float.Parse(txtGiatriBH.Text);
                float duongkinh = float.Parse(txtDuongkinh.Text);
                int soluong = int.Parse(txtSoluong.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        private void ButLuu_Click(object sender, EventArgs e)
        {
            QLHA ha = new QLHA();
            if (Check() == false && Exception())
            {
                DongHo dongHo = new DongHo();
                dongHo.MaSP = txtMasp.Text;
                dongHo.XuatSu = txtXuatxu.Text;
                dongHo.GioiTinhSP = comboGioitinh.Text;
                dongHo.ChatLieuMatKinh = comboChatlieumatkinh.Text;
                dongHo.BoMayNangLuong = comboBomayNL.Text;
                dongHo.MauMatSo = comboMaumatso.Text;
                dongHo.ChatLieuDay = comboChatlieuday.Text;
                dongHo.BeDayMatSo = Convert.ToDouble(txtBedaymatso.Text);
                dongHo.DuongKinhMatSo = Convert.ToDouble(txtDuongkinh.Text);
                dongHo.HinhDangMatSo = comboHinhdang.Text;
                dongHo.MucChongNuoc = comboMucCN.Text;
                dongHo.HinhAnh = ha.ImageToByteArray(picHinhAnh.Image);
                dongHo.GiaTriBaoHanh = Convert.ToDouble(txtGiatriBH.Text);
                dongHo.GiaSP = Convert.ToDecimal(txtGia.Text);
                dongHo.SoLuong = Convert.ToInt32(txtSoluong.Text);
                if (comboMaKM.SelectedIndex >= 1)
                {
                    dongHo.MaKhuyenMai = ((CBBItems)comboMaKM.SelectedItem).Value;
                }
                else
                {
                    dongHo.MaKhuyenMai = null;
                }
                if (comboThuonghieu.SelectedIndex >= 0 && string.IsNullOrWhiteSpace(textAddThuonghieu.Text))
                {
                    dongHo.MaThuongHieu = ((CBBItems)comboThuonghieu.SelectedItem).Value;
                }
                else if (textAddThuonghieu.Text != null)
                {
                    AddThuongHieu(textAddThuonghieu.Text);
                    dongHo.MaThuongHieu = bllth.GetMaTHByTenTH(textAddThuonghieu.Text);
                }
                bll.ExecuteDB(dongHo);
                d1(bll.GetAllSP_BLL_ForDGV());
                this.Dispose();
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

        public void AddThuongHieu(string name)
        {
            List<ThuongHieu> listTH = bllth.GetAllThuongHieu();
            int count = 0;
            foreach (ThuongHieu i in listTH)
            {
                if (i.TenThuongHieu == name)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                MessageBox.Show("Thuong hiệu đã tồn tại");
            }
            else
            {
                bllth.AddThuongHieu(name);
            }

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            textAddThuonghieu.BringToFront();
        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            comboThuonghieu.BringToFront();
            textAddThuonghieu.Text = null;
        }
    }
}
