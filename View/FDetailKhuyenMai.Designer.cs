namespace CNPM_PBL3.View
{
    partial class FDetailKhuyenMai
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.cbbThuongHieu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbSanPham = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(764, 447);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(124)))), ((int)(((byte)(106)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(55, 41);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 25;
            this.guna2Button1.Text = "Thêm vào đợt khuyến mãi";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 21;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(124)))), ((int)(((byte)(106)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(337, 600);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 27;
            this.guna2Button2.Text = "Xóa";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
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
            this.cbbThuongHieu.Location = new System.Drawing.Point(337, 41);
            this.cbbThuongHieu.Name = "cbbThuongHieu";
            this.cbbThuongHieu.Size = new System.Drawing.Size(140, 36);
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
            this.cbbSanPham.Location = new System.Drawing.Point(535, 41);
            this.cbbSanPham.Name = "cbbSanPham";
            this.cbbSanPham.Size = new System.Drawing.Size(225, 36);
            this.cbbSanPham.TabIndex = 29;
            this.cbbSanPham.SelectedIndexChanged += new System.EventHandler(this.cbbSanPham_SelectedIndexChanged_1);
            // 
            // FDetailKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(864, 681);
            this.Controls.Add(this.cbbSanPham);
            this.Controls.Add(this.cbbThuongHieu);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FDetailKhuyenMai";
            this.Text = "FDetailKhuyenMai";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2ComboBox cbbThuongHieu;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSanPham;
    }
}