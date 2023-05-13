namespace CNPM_PBL3.View
{
    partial class FDetailSale
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butThem = new Guna.UI2.WinForms.Guna2Button();
            this.butXoa = new Guna.UI2.WinForms.Guna2Button();
            this.cbbThuongHieu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbSanPham = new Guna.UI2.WinForms.Guna2ComboBox();
            this.butCancel = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 214);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(992, 453);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // butThem
            // 
            this.butThem.Animated = true;
            this.butThem.AutoRoundedCorners = true;
            this.butThem.BorderRadius = 31;
            this.butThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(144)))), ((int)(((byte)(124)))));
            this.butThem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThem.ForeColor = System.Drawing.Color.Black;
            this.butThem.Location = new System.Drawing.Point(56, 701);
            this.butThem.Margin = new System.Windows.Forms.Padding(4);
            this.butThem.Name = "butThem";
            this.butThem.Size = new System.Drawing.Size(261, 65);
            this.butThem.TabIndex = 25;
            this.butThem.Text = "Thêm";
            this.butThem.Click += new System.EventHandler(this.butThem_Click);
            // 
            // butXoa
            // 
            this.butXoa.AutoRoundedCorners = true;
            this.butXoa.BorderRadius = 31;
            this.butXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(144)))), ((int)(((byte)(124)))));
            this.butXoa.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butXoa.ForeColor = System.Drawing.Color.Black;
            this.butXoa.Location = new System.Drawing.Point(425, 701);
            this.butXoa.Margin = new System.Windows.Forms.Padding(4);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(261, 65);
            this.butXoa.TabIndex = 27;
            this.butXoa.Text = "Xóa";
            this.butXoa.Click += new System.EventHandler(this.Xoa_Click);
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
            this.cbbThuongHieu.Location = new System.Drawing.Point(276, 120);
            this.cbbThuongHieu.Margin = new System.Windows.Forms.Padding(4);
            this.cbbThuongHieu.Name = "cbbThuongHieu";
            this.cbbThuongHieu.Size = new System.Drawing.Size(185, 36);
            this.cbbThuongHieu.TabIndex = 28;
            this.cbbThuongHieu.SelectedIndexChanged += new System.EventHandler(this.cbbThuongHieu_SelectedIndexChanged_1);
            // 
            // cbbSanPham
            // 
            this.cbbSanPham.AutoRoundedCorners = true;
            this.cbbSanPham.BackColor = System.Drawing.Color.Transparent;
            this.cbbSanPham.BorderRadius = 17;
            this.cbbSanPham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSanPham.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSanPham.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSanPham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbSanPham.ItemHeight = 30;
            this.cbbSanPham.Location = new System.Drawing.Point(742, 120);
            this.cbbSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSanPham.Name = "cbbSanPham";
            this.cbbSanPham.Size = new System.Drawing.Size(299, 36);
            this.cbbSanPham.TabIndex = 29;
            this.cbbSanPham.SelectedIndexChanged += new System.EventHandler(this.cbbSanPham_SelectedIndexChanged_1);
            // 
            // butCancel
            // 
            this.butCancel.Animated = true;
            this.butCancel.AutoRoundedCorners = true;
            this.butCancel.BorderRadius = 31;
            this.butCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(144)))), ((int)(((byte)(124)))));
            this.butCancel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancel.ForeColor = System.Drawing.Color.Black;
            this.butCancel.Location = new System.Drawing.Point(798, 701);
            this.butCancel.Margin = new System.Windows.Forms.Padding(4);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(261, 65);
            this.butCancel.TabIndex = 30;
            this.butCancel.Text = "Thoát";
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "Thương hiệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 31;
            this.label2.Text = "Sản phẩm";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(144)))), ((int)(((byte)(124)))));
            this.guna2Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(221, 11);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(710, 78);
            this.guna2Panel1.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "CHI TIẾT KHUYẾN MÃI";
            // 
            // FDetailSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1152, 838);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.cbbSanPham);
            this.Controls.Add(this.cbbThuongHieu);
            this.Controls.Add(this.butXoa);
            this.Controls.Add(this.butThem);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FDetailSale";
            this.Text = "FDetailKhuyenMai";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button butThem;
        private Guna.UI2.WinForms.Guna2Button butXoa;
        private Guna.UI2.WinForms.Guna2ComboBox cbbThuongHieu;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSanPham;
        private Guna.UI2.WinForms.Guna2Button butCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
    }
}