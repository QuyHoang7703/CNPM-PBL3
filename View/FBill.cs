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
using System.Dynamic;

namespace CNPM_PBL3.View
{
    public partial class FBill : Form
    {
        public FBill()
        {
            InitializeComponent();
            GetCBB_MaSP();
        }
        public static int idKhacHang = 0;
        QLHD_BLL bll = new QLHD_BLL();
        public List<dynamic> list= new List<dynamic>();
        public dynamic sp;
        public void GetCBB_MaSP()
        {
            cbbMaSP.Items.Clear();
            cbbMaSP.Items.AddRange(bll.GetDBCBB().ToArray());
        }

        public void get(string s)
        {
            cbbMaSP.SelectedItem = s;
            
        }
        private void ButAddCustomers_Click(object sender, EventArgs e)
        {
            //FAddCustomer f = new FAddCustomer();
            //f.TopLevel = false;
            //f.FormBorderStyle = FormBorderStyle.None;
            //f.Dock = DockStyle.Fill;
            //this.Controls.Add(f);
            //f.BringToFront();
            //f.Show();
            FAddCustomer fAddCustomer = new FAddCustomer();
            QLForm f = new QLForm();
            f.OpenChildForm(FMainManager.panelMain, fAddCustomer);
            fAddCustomer.BringToFront();
            
        }

        private void cbbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSP = cbbMaSP.SelectedItem.ToString();
            
            float giaTriKM = bll.GetGiaTriKhuyenMai(maSP);
            MessageBox.Show("" + giaTriKM);
            if (giaTriKM != 0)
            {
               
                txtDonGia.Text = (bll.GetDonGia(maSP) - bll.GetDonGia(maSP)*(decimal)giaTriKM/100).ToString();
                lbGiaThat.Visible = true;
                lbGiaThat.Text = (bll.GetDonGia(maSP)).ToString();
              
            }
            else
            {
                txtDonGia.Text = (bll.GetDonGia(maSP)).ToString();
                lbGiaThat.Visible = false;

            }
           
            txtSLCoSan.Text = (bll.GetSoLuong(maSP)).ToString();
            txtSoLuong.Text = "";


        }
        public void ShowDGVHD()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sản phẩm", typeof(string));
            dt.Columns.Add("Số lượng", typeof(int));
            dt.Columns.Add("Đơn giá", typeof(decimal));
            dt.Columns.Add("Thành tiền", typeof(decimal));
            foreach (dynamic i in list)
            {
                DataRow dr = dt.NewRow();
                dr["Mã sản phẩm"] = i.maSanPham;
                dr["Số lượng"] = i.soLuong;
                dr["Đơn giá"] = i.donGia;
                dr["Thành tiền"] = i.thanhTien;

                dt.Rows.Add(dr);
            }
           
            dgvHD.DataSource = dt;
        }
        public int CheckAvailable(string maSanPham)
        {
            
            int index = -1;
            foreach(dynamic i in list)
            {
                if (i.maSanPham == maSanPham)
                {
                    index = list.IndexOf(i);
                   // MessageBox.Show(index.ToString());
                    break;

                }
               
            }
            return index;
        }
   
        private void butAdd_Click(object sender, EventArgs e)
        {
            
            if (cbbMaSP.SelectedIndex >= 0)
            {    
                if (!string.IsNullOrEmpty(txtSoLuong.Text) && txtSoLuong.Text!="0")
                {
                    int soLuong;
                    if (Int32.TryParse(txtSoLuong.Text, out soLuong))
                    {
                        sp = new ExpandoObject();
                        sp.maSanPham = cbbMaSP.SelectedItem.ToString();
                        sp.soLuong = soLuong;
                        sp.donGia = Convert.ToDecimal(txtDonGia.Text);
                        sp.thanhTien = sp.soLuong * sp.donGia;
                        int sLHienCo = (Convert.ToInt32(txtSLCoSan.Text) - soLuong);
                        if (sLHienCo < 0)
                        {
                            MessageBox.Show("Số lượng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        } 
                        txtSLCoSan.Text = sLHienCo.ToString();
                        int index = CheckAvailable(sp.maSanPham);
                        if (index >= 0)
                        {
                            dynamic temp = list[index];
                            temp.soLuong += sp.soLuong;
                            temp.thanhTien = temp.soLuong * temp.donGia;
                            list[index] = temp;
                        }
                        else
                        {
                            list.Add(sp);
                        }
                        ShowDGVHD();
                    }
                    else
                    {
                        MessageBox.Show("Hãy nhập đúng định dạng của số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }  
            }
            else
            {
                MessageBox.Show("Vui lòng điền chọn đầy đủ thông tin mã sản phẩm và mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection l = dgvHD.SelectedRows;
            if (l.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    foreach (DataGridViewRow i in l)
                    {
                        int index = CheckAvailable(i.Cells["Mã sản phẩm"].Value.ToString());
                        if (index >= 0)
                        {
                            list.RemoveAt(index);
                        }
                        
                                                                  
                    }
                    
                }
                ShowDGVHD();
            }
            else
            {
                MessageBox.Show("Hãy chọn sản phẩm muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        public void Add()
        {
            if (idKhacHang > 0)
            {
                HoaDon hd = new HoaDon()
                {
                    ID= FLogin.account.ID,
                    MaKH=idKhacHang,
                    NgayBan= dtpNgayBan.Value
                };
                List<ChiTietHoaDon> m = new List<ChiTietHoaDon>();
                foreach(dynamic i in list)
                {
                    ChiTietHoaDon ct = new ChiTietHoaDon()
                    {
                        MaSP=i.maSanPham,
                        SoLuong=i.soLuong,
                        DonGia=i.donGia,
                        ThanhTien= i.soLuong * i.donGia
                    };
                    m.Add(ct);
                }
                bll.AddHD(hd, m);
            }
            else
            {
                MessageBox.Show("Hãy thêm thông tin khách hàng trước khi tạo hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
        public decimal TinhTien()
        {
            decimal t = 0;
            foreach(var i in list)
            {
                t += i.thanhTien;
            }
            return t;
        }
        private void butThanhToan_Click(object sender, EventArgs e)
        {
            if(idKhacHang > 0 && dgvHD.DataSource!=null)
            {
                Add();
                foreach (var i in list)
                {
                    bll.UpdateSoLuong(i.maSanPham, bll.GetSoLuong(i.maSanPham) - i.soLuong);
                }

                decimal tongTien = TinhTien();
                txtThanhTien.Text = tongTien.ToString();
              
                
                
                MessageBox.Show("Tạo hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = MessageBox.Show("Bạn có muốn in hóa đơn không!", "THÔNG BÁO", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    FPrintBill f = new FPrintBill();
                    f.idKH = idKhacHang;
                    f.Show();
                   
                }
                idKhacHang = 0;
                dgvHD.DataSource = null;
                cbbMaSP.Items.Clear();
                txtSLCoSan.Text = "";
                txtSoLuong.Text = "";
                lbGiaThat.Visible= false;
                txtDonGia.Text = "";

            }
            else if(idKhacHang > 0 && dgvHD.DataSource == null)
            {
                MessageBox.Show("Hãy chọn sản phẩm muốn tạo hóa đơn", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nhập thông tin khách hàng trước khi tạo hóa đơn", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

       
    }
}
