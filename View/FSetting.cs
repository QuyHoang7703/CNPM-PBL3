using CNPM_PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_PBL3.View
{
    public partial class FSetting : Form
    {
        public FSetting()
        {
            InitializeComponent();
        }
        QLTK_BLL bll = new QLTK_BLL();
      
       
       
        private void picture_Invisible_Click(object sender, EventArgs e)
        {
            picture_Visible.BringToFront();
            txtPass.PasswordChar = '•';
        }

        private void picture_Visible_Click(object sender, EventArgs e)
        {
            picture_Invisible.BringToFront();
            txtPass.PasswordChar = '\0';
        }

        public void GetChiTietTaiKhoan(int id)
        {
            var s = bll.GetChiTietTaiKhoan_ByID_BLL(id);
            txtName.Text = s.HoTen;
            txtPhone.Text = s.SDT;
            dtpNS.Value = s.NgaySinh;
            txtAddress.Text = s.DiaChi;
            if (s.GioiTinh == true)
            {
                rdbMale.Checked = true;
            }
            else
            {
                rdbFemale.Checked = true;
            }
            txtUserName.Text=s.UserName;
            txtPass.Text = s.Pass;
           // ptbImage.Image = ConverByteToTmage(account.ChiTietTaiKhoan.AnhDaiDien);

        }

        public void UpdatePass()
        {
           
            bll.UpdatePass_BLL(txtNewPass.Text);
            // FLogin.account.Pass=txtNewPass.Text;
            //TaiKhoan t = FLogin.account;
           // return t;
        }
        public bool SetGioiTinh()
        {
            if (rdbMale.Checked)
                return true;
            else return false;
        }
        public void UpadteInformation()
        {
            ChiTietTaiKhoan ct = new ChiTietTaiKhoan()
            {
                ID = FLogin.account.ID,
                HoTen = txtName.Text,
                SDT = txtPhone.Text,
                NgaySinh = Convert.ToDateTime(dtpNS.Value.ToString()),
                GioiTinh = SetGioiTinh(),
                DiaChi = txtAddress.Text,
                //  AnhDaiDien = data;
               // AnhDaiDien = ConverImagetoByte(ptbImage.ImageLocation)
                
                
            };
            
            bll.UpdateInformation_BLL(ct);
            

        }
        private void butUpdate_Click(object sender, EventArgs e)
        {

             UpadteInformation();
            MessageBox.Show("Cập nhập thành công", "Thông báo", MessageBoxButtons.OK);
            


        }
        private void butChangePass_Click(object sender, EventArgs e)
        {
            //FLogin.account=UpdatePass();
            UpdatePass();
            MessageBox.Show("Thay đổi mật khẩu thành công");
           
        }
        //public byte[] ConvertToByte(string i)
        //{
        //    FileStream fs = new FileStream(i, FileMode.Open, FileAccess.Read);
        //    byte[] data = new byte[fs.Length];
        //    fs.Read(data, 0, Convert.ToInt32(data.Length));
        //    fs.Close();
        //    return data;   
        //}
        //public Image ConvertToImage(byte[] data)
        //{

        //    using (MemoryStream ms = new MemoryStream(data))
        //    {
        //        Image image = Image.FromStream(ms);

        //        // Gán đối tượng Image vào thuộc tính Image của PictureBox
        //        // ptbImage.Image = image;
        //        // pictureBox1.Image = image;
        //        return image;
        //    }

        //}
        public byte[] ConverImagetoByte(string s)
        {
            byte[] data;
            FileInfo fif = new FileInfo(s);
            long number = fif.Length;
            FileStream fs = new FileStream(s, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            data = br.ReadBytes((int)number);
            return data;
        }
        public Image ConverByteToTmage(byte[] i)
        {
            Image newimage;
            using (MemoryStream ms = new MemoryStream(i, 0, i.Length))
            {
                ms.Write(i, 0, i.Length);
                newimage = Image.FromStream(ms, true);
            }
            return newimage;
        }
        private void butAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                
                ptbImage.ImageLocation = open.FileName;

            }

            //data = ConvertToByte(open.FileName);
            //ptbImage.Image=ConvertToImage(data);
            //QLDB db = new QLDB();
            //account.ChiTietTaiKhoan.AnhDaiDien = data;
            //db.SaveChanges();

        }
    }
}
