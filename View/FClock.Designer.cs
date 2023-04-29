namespace CNPM_PBL3.View
{
    partial class FClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FClock));
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButThem = new Guna.UI2.WinForms.Guna2Button();
            this.ButCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.ButXoa = new Guna.UI2.WinForms.Guna2Button();
            this.ButSapXep = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbbGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbThuongHieu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Animated = true;
            this.txtsearch.AutoRoundedCorners = true;
            this.txtsearch.BorderRadius = 15;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.DefaultText = "";
            this.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtsearch.IconLeft")));
            this.txtsearch.Location = new System.Drawing.Point(37, 61);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderText = "Tìm Kiếm";
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(233, 33);
            this.txtsearch.TabIndex = 9;
            this.txtsearch.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // ButThem
            // 
            this.ButThem.Animated = true;
            this.ButThem.AutoRoundedCorners = true;
            this.ButThem.BorderRadius = 15;
            this.ButThem.DefaultAutoSize = true;
            this.ButThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(144)))), ((int)(((byte)(124)))));
            this.ButThem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButThem.ForeColor = System.Drawing.Color.Black;
            this.ButThem.Location = new System.Drawing.Point(44, 627);
            this.ButThem.Margin = new System.Windows.Forms.Padding(2);
            this.ButThem.Name = "ButThem";
            this.ButThem.Size = new System.Drawing.Size(76, 33);
            this.ButThem.TabIndex = 11;
            this.ButThem.Text = "THÊM";
            this.ButThem.Click += new System.EventHandler(this.ButThem_Click);
            // 
            // ButCapNhat
            // 
            this.ButCapNhat.Animated = true;
            this.ButCapNhat.AutoRoundedCorners = true;
            this.ButCapNhat.BorderRadius = 15;
            this.ButCapNhat.DefaultAutoSize = true;
            this.ButCapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButCapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButCapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButCapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButCapNhat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(144)))), ((int)(((byte)(124)))));
            this.ButCapNhat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButCapNhat.ForeColor = System.Drawing.Color.Black;
            this.ButCapNhat.Location = new System.Drawing.Point(169, 627);
            this.ButCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.ButCapNhat.Name = "ButCapNhat";
            this.ButCapNhat.Size = new System.Drawing.Size(111, 33);
            this.ButCapNhat.TabIndex = 12;
            this.ButCapNhat.Text = "CẬP NHẬT";
            this.ButCapNhat.Click += new System.EventHandler(this.ButCapNhat_Click);
            // 
            // ButXoa
            // 
            this.ButXoa.Animated = true;
            this.ButXoa.AutoRoundedCorners = true;
            this.ButXoa.BorderRadius = 15;
            this.ButXoa.DefaultAutoSize = true;
            this.ButXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(144)))), ((int)(((byte)(124)))));
            this.ButXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButXoa.ForeColor = System.Drawing.Color.Black;
            this.ButXoa.Location = new System.Drawing.Point(356, 627);
            this.ButXoa.Margin = new System.Windows.Forms.Padding(2);
            this.ButXoa.Name = "ButXoa";
            this.ButXoa.Size = new System.Drawing.Size(65, 33);
            this.ButXoa.TabIndex = 13;
            this.ButXoa.Text = "XÓA";
            this.ButXoa.Click += new System.EventHandler(this.ButXoa_Click);
            // 
            // ButSapXep
            // 
            this.ButSapXep.Animated = true;
            this.ButSapXep.AutoRoundedCorners = true;
            this.ButSapXep.BorderRadius = 15;
            this.ButSapXep.DefaultAutoSize = true;
            this.ButSapXep.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButSapXep.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButSapXep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButSapXep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButSapXep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(144)))), ((int)(((byte)(124)))));
            this.ButSapXep.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButSapXep.ForeColor = System.Drawing.Color.Black;
            this.ButSapXep.Location = new System.Drawing.Point(480, 627);
            this.ButSapXep.Margin = new System.Windows.Forms.Padding(2);
            this.ButSapXep.Name = "ButSapXep";
            this.ButSapXep.Size = new System.Drawing.Size(93, 33);
            this.ButSapXep.TabIndex = 14;
            this.ButSapXep.Text = "SẮP XẾP";
            this.ButSapXep.Click += new System.EventHandler(this.ButSapXep_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.AutoRoundedCorners = true;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 17;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "ID",
            "Giá",
            "Số Lượng"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(632, 627);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(179, 36);
            this.guna2ComboBox1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(795, 485);
            this.dataGridView1.TabIndex = 16;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.AutoRoundedCorners = true;
            this.cbbGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cbbGioiTinh.BorderRadius = 17;
            this.cbbGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbGioiTinh.ItemHeight = 30;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Unisex"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(337, 55);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(140, 36);
            this.cbbGioiTinh.TabIndex = 19;
            this.cbbGioiTinh.SelectedIndexChanged += new System.EventHandler(this.cbbGioiTinh_SelectedIndexChanged);
            // 
            // cbbThuongHieu
            // 
            this.cbbThuongHieu.AutoRoundedCorners = true;
            this.cbbThuongHieu.BackColor = System.Drawing.Color.Transparent;
            this.cbbThuongHieu.BorderRadius = 17;
            this.cbbThuongHieu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbThuongHieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThuongHieu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbThuongHieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbThuongHieu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbThuongHieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbThuongHieu.ItemHeight = 30;
            this.cbbThuongHieu.Location = new System.Drawing.Point(502, 55);
            this.cbbThuongHieu.Name = "cbbThuongHieu";
            this.cbbThuongHieu.Size = new System.Drawing.Size(140, 36);
            this.cbbThuongHieu.TabIndex = 20;
            this.cbbThuongHieu.SelectedIndexChanged += new System.EventHandler(this.cbbThuongHieu_SelectedIndexChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.DefaultAutoSize = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(658, 55);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(79, 27);
            this.guna2Button1.TabIndex = 21;
            this.guna2Button1.Text = "Tim kiem";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // FClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(880, 720);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.cbbThuongHieu);
            this.Controls.Add(this.cbbGioiTinh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.ButSapXep);
            this.Controls.Add(this.ButXoa);
            this.Controls.Add(this.ButCapNhat);
            this.Controls.Add(this.ButThem);
            this.Controls.Add(this.txtsearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FClock";
            this.Text = "FClock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private Guna.UI2.WinForms.Guna2Button ButThem;
        private Guna.UI2.WinForms.Guna2Button ButCapNhat;
        private Guna.UI2.WinForms.Guna2Button ButXoa;
        private Guna.UI2.WinForms.Guna2Button ButSapXep;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbGioiTinh;
        private Guna.UI2.WinForms.Guna2ComboBox cbbThuongHieu;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}