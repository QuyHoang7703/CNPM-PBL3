namespace CNPM_PBL3.View
{
    partial class FMainManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMainManager));
            this.PanelFrame = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.butKhuyenMai = new Guna.UI2.WinForms.Guna2Button();
            this.lbThongTin = new System.Windows.Forms.Label();
            this.guna2ButStaff = new Guna.UI2.WinForms.Guna2Button();
            this.ButDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButSetting = new Guna.UI2.WinForms.Guna2Button();
            this.butLichSu = new Guna.UI2.WinForms.Guna2Button();
            this.ButThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.butClock = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButBill = new Guna.UI2.WinForms.Guna2Button();
            this.ButTrangChu = new Guna.UI2.WinForms.Guna2Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.PanelFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFrame
            // 
            this.PanelFrame.BorderRadius = 10;
            this.PanelFrame.Controls.Add(this.butKhuyenMai);
            this.PanelFrame.Controls.Add(this.lbThongTin);
            this.PanelFrame.Controls.Add(this.guna2ButStaff);
            this.PanelFrame.Controls.Add(this.ButDangXuat);
            this.PanelFrame.Controls.Add(this.guna2ButSetting);
            this.PanelFrame.Controls.Add(this.butLichSu);
            this.PanelFrame.Controls.Add(this.ButThongKe);
            this.PanelFrame.Controls.Add(this.butClock);
            this.PanelFrame.Controls.Add(this.guna2ButBill);
            this.PanelFrame.Controls.Add(this.ButTrangChu);
            this.PanelFrame.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.PanelFrame.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.PanelFrame.Location = new System.Drawing.Point(0, 1);
            this.PanelFrame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelFrame.Name = "PanelFrame";
            this.PanelFrame.Size = new System.Drawing.Size(269, 900);
            this.PanelFrame.TabIndex = 1;
            this.PanelFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelFrame_Paint_1);
            // 
            // butKhuyenMai
            // 
            this.butKhuyenMai.BackColor = System.Drawing.Color.Transparent;
            this.butKhuyenMai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.butKhuyenMai.BorderRadius = 20;
            this.butKhuyenMai.BorderThickness = 1;
            this.butKhuyenMai.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.butKhuyenMai.CheckedState.BorderColor = System.Drawing.Color.White;
            this.butKhuyenMai.CheckedState.FillColor = System.Drawing.Color.White;
            this.butKhuyenMai.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.butKhuyenMai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butKhuyenMai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butKhuyenMai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butKhuyenMai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butKhuyenMai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.butKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.butKhuyenMai.ForeColor = System.Drawing.Color.Black;
            this.butKhuyenMai.Image = ((System.Drawing.Image)(resources.GetObject("butKhuyenMai.Image")));
            this.butKhuyenMai.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butKhuyenMai.ImageSize = new System.Drawing.Size(40, 40);
            this.butKhuyenMai.Location = new System.Drawing.Point(12, 676);
            this.butKhuyenMai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butKhuyenMai.Name = "butKhuyenMai";
            this.butKhuyenMai.Size = new System.Drawing.Size(251, 60);
            this.butKhuyenMai.TabIndex = 11;
            this.butKhuyenMai.Text = "Khuyến mãi";
            this.butKhuyenMai.Click += new System.EventHandler(this.butKhuyenMai_Click);
            // 
            // lbThongTin
            // 
            this.lbThongTin.AutoSize = true;
            this.lbThongTin.BackColor = System.Drawing.Color.Transparent;
            this.lbThongTin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTin.Location = new System.Drawing.Point(35, 106);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(109, 25);
            this.lbThongTin.TabIndex = 10;
            this.lbThongTin.Text = "Thông tin";
            this.lbThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2ButStaff
            // 
            this.guna2ButStaff.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButStaff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.guna2ButStaff.BorderRadius = 20;
            this.guna2ButStaff.BorderThickness = 1;
            this.guna2ButStaff.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButStaff.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2ButStaff.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2ButStaff.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.guna2ButStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.guna2ButStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButStaff.ForeColor = System.Drawing.Color.Black;
            this.guna2ButStaff.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButStaff.Image")));
            this.guna2ButStaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButStaff.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ButStaff.Location = new System.Drawing.Point(12, 610);
            this.guna2ButStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ButStaff.Name = "guna2ButStaff";
            this.guna2ButStaff.Size = new System.Drawing.Size(251, 60);
            this.guna2ButStaff.TabIndex = 9;
            this.guna2ButStaff.Text = "  Nhân viên";
            this.guna2ButStaff.Click += new System.EventHandler(this.guna2ButStaff_Click);
            // 
            // ButDangXuat
            // 
            this.ButDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.ButDangXuat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.ButDangXuat.BorderRadius = 20;
            this.ButDangXuat.BorderThickness = 1;
            this.ButDangXuat.CheckedState.BorderColor = System.Drawing.Color.White;
            this.ButDangXuat.CheckedState.FillColor = System.Drawing.Color.White;
            this.ButDangXuat.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.ButDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButDangXuat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.ButDangXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButDangXuat.ForeColor = System.Drawing.Color.Black;
            this.ButDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("ButDangXuat.Image")));
            this.ButDangXuat.ImageSize = new System.Drawing.Size(40, 40);
            this.ButDangXuat.Location = new System.Drawing.Point(-31, 828);
            this.ButDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButDangXuat.Name = "ButDangXuat";
            this.ButDangXuat.Size = new System.Drawing.Size(251, 60);
            this.ButDangXuat.TabIndex = 8;
            this.ButDangXuat.Text = "Thoát";
            this.ButDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButDangXuat.UseTransparentBackground = true;
            this.ButDangXuat.Click += new System.EventHandler(this.ButDangXuat_Click);
            // 
            // guna2ButSetting
            // 
            this.guna2ButSetting.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButSetting.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.guna2ButSetting.BorderRadius = 20;
            this.guna2ButSetting.BorderThickness = 1;
            this.guna2ButSetting.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButSetting.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2ButSetting.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2ButSetting.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.guna2ButSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButSetting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.guna2ButSetting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButSetting.ForeColor = System.Drawing.Color.Black;
            this.guna2ButSetting.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButSetting.Image")));
            this.guna2ButSetting.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButSetting.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ButSetting.Location = new System.Drawing.Point(12, 544);
            this.guna2ButSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ButSetting.Name = "guna2ButSetting";
            this.guna2ButSetting.Size = new System.Drawing.Size(251, 60);
            this.guna2ButSetting.TabIndex = 7;
            this.guna2ButSetting.Text = "Cài Đặt";
            this.guna2ButSetting.UseTransparentBackground = true;
            this.guna2ButSetting.Click += new System.EventHandler(this.guna2ButSetting_Click);
            // 
            // butLichSu
            // 
            this.butLichSu.BackColor = System.Drawing.Color.Transparent;
            this.butLichSu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.butLichSu.BorderRadius = 20;
            this.butLichSu.BorderThickness = 1;
            this.butLichSu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.butLichSu.CheckedState.BorderColor = System.Drawing.Color.White;
            this.butLichSu.CheckedState.FillColor = System.Drawing.Color.White;
            this.butLichSu.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.butLichSu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butLichSu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butLichSu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butLichSu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butLichSu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.butLichSu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLichSu.ForeColor = System.Drawing.Color.Black;
            this.butLichSu.Image = ((System.Drawing.Image)(resources.GetObject("butLichSu.Image")));
            this.butLichSu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butLichSu.ImageSize = new System.Drawing.Size(40, 40);
            this.butLichSu.Location = new System.Drawing.Point(12, 479);
            this.butLichSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butLichSu.Name = "butLichSu";
            this.butLichSu.Size = new System.Drawing.Size(251, 60);
            this.butLichSu.TabIndex = 6;
            this.butLichSu.Text = "Lịch sử mua hàng";
            this.butLichSu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.butLichSu.UseTransparentBackground = true;
            this.butLichSu.Click += new System.EventHandler(this.butLichSu_Click);
            // 
            // ButThongKe
            // 
            this.ButThongKe.BackColor = System.Drawing.Color.Transparent;
            this.ButThongKe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.ButThongKe.BorderRadius = 20;
            this.ButThongKe.BorderThickness = 1;
            this.ButThongKe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButThongKe.CheckedState.BorderColor = System.Drawing.Color.White;
            this.ButThongKe.CheckedState.FillColor = System.Drawing.Color.White;
            this.ButThongKe.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.ButThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButThongKe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.ButThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButThongKe.ForeColor = System.Drawing.Color.Black;
            this.ButThongKe.Image = ((System.Drawing.Image)(resources.GetObject("ButThongKe.Image")));
            this.ButThongKe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButThongKe.ImageSize = new System.Drawing.Size(40, 40);
            this.ButThongKe.Location = new System.Drawing.Point(12, 412);
            this.ButThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButThongKe.Name = "ButThongKe";
            this.ButThongKe.Size = new System.Drawing.Size(251, 60);
            this.ButThongKe.TabIndex = 4;
            this.ButThongKe.Text = "Thống Kê";
            this.ButThongKe.UseTransparentBackground = true;
            // 
            // butClock
            // 
            this.butClock.BackColor = System.Drawing.Color.Transparent;
            this.butClock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.butClock.BorderRadius = 20;
            this.butClock.BorderThickness = 1;
            this.butClock.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.butClock.CheckedState.BorderColor = System.Drawing.Color.White;
            this.butClock.CheckedState.FillColor = System.Drawing.Color.White;
            this.butClock.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.butClock.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butClock.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butClock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butClock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butClock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.butClock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClock.ForeColor = System.Drawing.Color.Black;
            this.butClock.Image = ((System.Drawing.Image)(resources.GetObject("butClock.Image")));
            this.butClock.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butClock.ImageSize = new System.Drawing.Size(40, 40);
            this.butClock.Location = new System.Drawing.Point(12, 346);
            this.butClock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butClock.Name = "butClock";
            this.butClock.Size = new System.Drawing.Size(251, 60);
            this.butClock.TabIndex = 3;
            this.butClock.Text = "Đồng Hồ";
            this.butClock.UseTransparentBackground = true;
            this.butClock.Click += new System.EventHandler(this.butClock_Click);
            // 
            // guna2ButBill
            // 
            this.guna2ButBill.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButBill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.guna2ButBill.BorderRadius = 20;
            this.guna2ButBill.BorderThickness = 1;
            this.guna2ButBill.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2ButBill.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2ButBill.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2ButBill.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            this.guna2ButBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2ButBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2ButBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2ButBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.guna2ButBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButBill.ForeColor = System.Drawing.Color.Black;
            this.guna2ButBill.Image = ((System.Drawing.Image)(resources.GetObject("guna2ButBill.Image")));
            this.guna2ButBill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButBill.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ButBill.Location = new System.Drawing.Point(12, 281);
            this.guna2ButBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ButBill.Name = "guna2ButBill";
            this.guna2ButBill.Size = new System.Drawing.Size(251, 60);
            this.guna2ButBill.TabIndex = 2;
            this.guna2ButBill.Text = "Hóa Đơn";
            this.guna2ButBill.UseTransparentBackground = true;
            this.guna2ButBill.Click += new System.EventHandler(this.guna2ButBill_Click);
            // 
            // ButTrangChu
            // 
            this.ButTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.ButTrangChu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.ButTrangChu.BorderRadius = 20;
            this.ButTrangChu.BorderThickness = 1;
            this.ButTrangChu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ButTrangChu.Checked = true;
            this.ButTrangChu.CheckedState.BorderColor = System.Drawing.Color.White;
            this.ButTrangChu.CheckedState.FillColor = System.Drawing.Color.White;
            this.ButTrangChu.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image8")));
            this.ButTrangChu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButTrangChu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButTrangChu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButTrangChu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButTrangChu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.ButTrangChu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButTrangChu.ForeColor = System.Drawing.Color.Black;
            this.ButTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("ButTrangChu.Image")));
            this.ButTrangChu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButTrangChu.ImageSize = new System.Drawing.Size(40, 40);
            this.ButTrangChu.Location = new System.Drawing.Point(12, 215);
            this.ButTrangChu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButTrangChu.Name = "ButTrangChu";
            this.ButTrangChu.Size = new System.Drawing.Size(251, 60);
            this.ButTrangChu.TabIndex = 1;
            this.ButTrangChu.Text = "Trang Chủ";
            this.ButTrangChu.UseTransparentBackground = true;
            this.ButTrangChu.Click += new System.EventHandler(this.ButTrangChu_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(269, 1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1102, 900);
            this.panelMain.TabIndex = 2;
            // 
            // FMainManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 900);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.PanelFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FMainManager";
            this.Text = "Form1";
            this.PanelFrame.ResumeLayout(false);
            this.PanelFrame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel PanelFrame;
        private Guna.UI2.WinForms.Guna2Button butKhuyenMai;
        private System.Windows.Forms.Label lbThongTin;
        private Guna.UI2.WinForms.Guna2Button guna2ButStaff;
        private Guna.UI2.WinForms.Guna2Button ButDangXuat;
        private Guna.UI2.WinForms.Guna2Button guna2ButSetting;
        private Guna.UI2.WinForms.Guna2Button butLichSu;
        private Guna.UI2.WinForms.Guna2Button ButThongKe;
        private Guna.UI2.WinForms.Guna2Button butClock;
        public Guna.UI2.WinForms.Guna2Button guna2ButBill;
        private Guna.UI2.WinForms.Guna2Button ButTrangChu;
        public System.Windows.Forms.Panel panelMain;
    }
}