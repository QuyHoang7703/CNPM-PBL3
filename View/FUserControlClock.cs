using CNPM_PBL3.BLL;
using CNPM_PBL3.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_PBL3.View
{
    public partial class FUserControlClock : UserControl
    {
        public FUserControlClock()
        {
            InitializeComponent();
            //hienthi();
        }
        public delegate void MyDel(string s);
        public MyDel d { get; set; }
        public delegate void MyDel1();
        public MyDel1 d1 { get; set; }


        private byte[] hinhAnh { get; set; }
        private string maSanPham { get; set; }


        QLHA qLHA = new QLHA();
        public string ChiTiet
        {
            get
            {
                return labelChiTiet.Text;
              
            }
            set
            {               
                labelChiTiet.Text = value;
            }
        }
        public string GiaSanPham
        {
            get
            {
                return labelGiaTri.Text;

            }
            set
            {
                labelGiaTri.Text = value;
            }
        }
        public byte[] HinhAnh
        {
            get
            {
                return hinhAnh;
            }
            set
            {
                hinhAnh = value;
                PTBHinhAnh.Image = qLHA.ConverByteToTmage(value);
            }
        }
        public string MaSanPham
        {
            get
            {
                return maSanPham;
            }
            set
            {
                maSanPham = value;
            }
        }
        public string KhuyenMai
        {
            get
            {
                return labelKM.Text;
            }
            set
            {
                labelKM.Text = value;
            }
        }
        public void hienthi()
        {
            if (labelKM.Text == "")
            {
                labelGiaTri.Font = new Font(labelGiaTri.Font, labelGiaTri.Font.Style & ~FontStyle.Strikeout);
            }
            else
            {
                labelGiaTri.Font = new Font(labelGiaTri.Font, labelGiaTri.Font.Style & FontStyle.Strikeout);
            }

        }
        private void ButGioHang_Click(object sender, EventArgs e)
        {

            try
            {
                // FMainManager fMainManager = new FMainManager();
                this.d += new FUserControlClock.MyDel(FMainManager.fBill.SetMaSanPham);
                this.d1 += new FUserControlClock.MyDel1(FMainManager.fBill.ThemSPVaoList);

                d(MaSanPham);
                d1();
               


                MessageBox.Show("Thêm vào hóa đơn thành công");
            }
            catch
            {
                MessageBox.Show("Thêm vào hóa đơn thất bại");
            }

        }

        private void guna2Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ButGioHang.Visible = true;
            panel1.Visible = true;
        }

        private void FUserControlClock_MouseLeave(object sender, EventArgs e)
        {
            ButGioHang.Visible = false;
            panel1.Visible = false;
        }

        private void FUserControlClock_Load(object sender, EventArgs e)
        {
            hienthi();
        }
    }
}
