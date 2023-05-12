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
    public partial class FUserControlClock : UserControl
    {
        public FUserControlClock()
        {
            InitializeComponent();
            //hienthi();
        }
        public delegate void mydel(string s);
        public mydel d { get; set; }


        public byte[] data { get; set; }
        public string maSP { get; set; }


        QLHA qLHA = new QLHA();
        public string chiTiet
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
        public string GiaSP
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
        public byte[] hinhAnh
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
                PTBHinhAnh.Image = qLHA.ConverByteToTmage(value);
            }
        }
        public string MSP
        {
            get
            {
                return maSP;
            }
            set
            {
                maSP = value;
            }
        }
        public string khuyenmai
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
                QLForm qLForm = new QLForm();
                qLForm.OpenChildForm(FMainManager.panelMain, FMainManager.fBill);
                this.d += new FUserControlClock.mydel(FMainManager.fBill.get);
                d(MSP);
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
