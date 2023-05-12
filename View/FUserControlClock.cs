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

        private void PTBHinhAnh_Click(object sender, EventArgs e)
        {
            if (ButGioHang.Visible == false)
            {
                ButGioHang.Visible = true;
                panel1.Visible = true;
            }
            else
            {
                ButGioHang.Visible = false;
                panel1.Visible = false;
            }
        }

        private void labelChiTiet_Click(object sender, EventArgs e)
        {
            if (ButGioHang.Visible == false)
            {
                ButGioHang.Visible = true;
                panel1.Visible = true;
            }
            else
            {
                ButGioHang.Visible = false;
                panel1.Visible = false;
            }
        }

        private void labelKM_Click(object sender, EventArgs e)
        {
            if (ButGioHang.Visible == false)
            {
                ButGioHang.Visible = true;
                panel1.Visible = true;
            }
            else
            {
                ButGioHang.Visible = false;
                panel1.Visible = false;
            }
        }

        private void labelGiaTri_Click(object sender, EventArgs e)
        {
            if (ButGioHang.Visible == false)
            {
                ButGioHang.Visible = true;
                panel1.Visible = true;
            }
            else
            {
                ButGioHang.Visible = false;
                panel1.Visible = false;
            }
        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            if (ButGioHang.Visible == false)
            {
                ButGioHang.Visible = true;
                panel1.Visible = true;
            }
            else
            {
                ButGioHang.Visible = false;
                panel1.Visible = false;
            }
        }
    }
}
