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
    public partial class FAddCustomer : Form
    {
        public FAddCustomer()
        {
            InitializeComponent();
            GetCBBGioiTinh();
        }
        QLKH_BLL bll = new QLKH_BLL();
        public KhachHang khachHang;
        public void GetCBBGioiTinh()
        {
            CBBGioiTinh.Items.Clear();
            CBBGioiTinh.Items.Add("Nam");
            CBBGioiTinh.Items.Add("Nữ");
        }
        public void AddKachHang()
        {
            bool check = false;
            if(CBBGioiTinh.SelectedItem.ToString()=="Nam")
            {
                check = true;
            }
          
            khachHang = new KhachHang()
            {
                HoTen = txtHoTen.Text,
                SDT = txtSDT.Text,
                DiaChi = txtDiaChi.Text,
                GioiTinh = check,
                NgaySinh = (dtpNS.Value)
            };
            bll.AddKhachHang_BLL(khachHang);
         
        }
        public int GetIdKhachHang()
        {
            return bll.GetIdKhachHang_BLL(khachHang);
        }
        private void ButThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool Check()
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
                //else if (control is RadioButton)
                //{
                //   RadioButton radioButton = (RadioButton)control;
                //    if(radioButton.Checked==null) { }
                //    hasEmptyControl = true;
                //}
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
        private void ButAdd_Click(object sender, EventArgs e)
        {
            
            if (!Check())
            {
                AddKachHang();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            FBill.idKhacHang = GetIdKhachHang();
            //MessageBox.Show(FBill.idKhacHang.ToString());

        }
    }
}
