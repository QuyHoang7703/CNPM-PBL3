namespace CNPM_PBL3.View
{
    partial class FUserControlClock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUserControlClock));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelGiaTri = new System.Windows.Forms.Label();
            this.labelChiTiet = new System.Windows.Forms.Label();
            this.PTBHinhAnh = new System.Windows.Forms.PictureBox();
            this.labelKM = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButGioHang = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTBHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.ButGioHang);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Controls.Add(this.labelKM);
            this.guna2Panel1.Controls.Add(this.labelGiaTri);
            this.guna2Panel1.Controls.Add(this.labelChiTiet);
            this.guna2Panel1.Controls.Add(this.PTBHinhAnh);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(34, 31);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(363, 436);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Click += new System.EventHandler(this.guna2Panel1_Click);
            // 
            // labelGiaTri
            // 
            this.labelGiaTri.AutoSize = true;
            this.labelGiaTri.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiaTri.Location = new System.Drawing.Point(141, 403);
            this.labelGiaTri.Name = "labelGiaTri";
            this.labelGiaTri.Size = new System.Drawing.Size(60, 22);
            this.labelGiaTri.TabIndex = 2;
            this.labelGiaTri.Text = "label1";
            this.labelGiaTri.Click += new System.EventHandler(this.labelGiaTri_Click);
            // 
            // labelChiTiet
            // 
            this.labelChiTiet.AutoSize = true;
            this.labelChiTiet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChiTiet.Location = new System.Drawing.Point(13, 292);
            this.labelChiTiet.Name = "labelChiTiet";
            this.labelChiTiet.Size = new System.Drawing.Size(51, 19);
            this.labelChiTiet.TabIndex = 1;
            this.labelChiTiet.Text = "label1";
            this.labelChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChiTiet.Click += new System.EventHandler(this.labelChiTiet_Click);
            // 
            // PTBHinhAnh
            // 
            this.PTBHinhAnh.Location = new System.Drawing.Point(3, 13);
            this.PTBHinhAnh.Name = "PTBHinhAnh";
            this.PTBHinhAnh.Size = new System.Drawing.Size(357, 246);
            this.PTBHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PTBHinhAnh.TabIndex = 0;
            this.PTBHinhAnh.TabStop = false;
            this.PTBHinhAnh.Click += new System.EventHandler(this.PTBHinhAnh_Click);
            // 
            // labelKM
            // 
            this.labelKM.AutoSize = true;
            this.labelKM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKM.Location = new System.Drawing.Point(102, 342);
            this.labelKM.Name = "labelKM";
            this.labelKM.Size = new System.Drawing.Size(60, 23);
            this.labelKM.TabIndex = 3;
            this.labelKM.Text = "label1";
            this.labelKM.Click += new System.EventHandler(this.labelKM_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(17, 431);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 5);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // ButGioHang
            // 
            this.ButGioHang.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButGioHang.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButGioHang.Image = ((System.Drawing.Image)(resources.GetObject("ButGioHang.Image")));
            this.ButGioHang.ImageOffset = new System.Drawing.Point(0, 0);
            this.ButGioHang.ImageRotate = 0F;
            this.ButGioHang.ImageSize = new System.Drawing.Size(50, 50);
            this.ButGioHang.Location = new System.Drawing.Point(283, 370);
            this.ButGioHang.Name = "ButGioHang";
            this.ButGioHang.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ButGioHang.Size = new System.Drawing.Size(80, 66);
            this.ButGioHang.TabIndex = 5;
            this.ButGioHang.Visible = false;
            this.ButGioHang.Click += new System.EventHandler(this.ButGioHang_Click);
            // 
            // FUserControlClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FUserControlClock";
            this.Size = new System.Drawing.Size(437, 500);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTBHinhAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label labelGiaTri;
        private System.Windows.Forms.Label labelChiTiet;
        private System.Windows.Forms.PictureBox PTBHinhAnh;
        private Guna.UI2.WinForms.Guna2ImageButton ButGioHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelKM;
    }
}
