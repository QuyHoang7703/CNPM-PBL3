namespace CNPM_PBL3.View
{
    partial class FPurchaseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPurchaseHistory));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLSMH = new System.Windows.Forms.DataGridView();
            this.butDetailBill = new Guna.UI2.WinForms.Guna2Button();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.butInHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSMH)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(144)))), ((int)(((byte)(124)))));
            this.guna2Panel1.Location = new System.Drawing.Point(187, 57);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(700, 70);
            this.guna2Panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "LỊCH SỬ MUA HÀNG";
            // 
            // dgvLSMH
            // 
            this.dgvLSMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLSMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLSMH.Location = new System.Drawing.Point(50, 297);
            this.dgvLSMH.Name = "dgvLSMH";
            this.dgvLSMH.RowHeadersWidth = 51;
            this.dgvLSMH.RowTemplate.Height = 24;
            this.dgvLSMH.Size = new System.Drawing.Size(1011, 390);
            this.dgvLSMH.TabIndex = 26;
            // 
            // butDetailBill
            // 
            this.butDetailBill.BorderRadius = 15;
            this.butDetailBill.BorderThickness = 1;
            this.butDetailBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butDetailBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butDetailBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butDetailBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butDetailBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(144)))), ((int)(((byte)(124)))));
            this.butDetailBill.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDetailBill.ForeColor = System.Drawing.Color.Black;
            this.butDetailBill.Location = new System.Drawing.Point(124, 737);
            this.butDetailBill.Name = "butDetailBill";
            this.butDetailBill.Size = new System.Drawing.Size(246, 55);
            this.butDetailBill.TabIndex = 27;
            this.butDetailBill.Text = "Xem Chi Tiết";
            this.butDetailBill.Click += new System.EventHandler(this.butDetailBill_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Animated = true;
            this.txtsearch.AutoRoundedCorners = true;
            this.txtsearch.BorderRadius = 19;
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
            this.txtsearch.Location = new System.Drawing.Point(760, 223);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderText = "Tìm Kiếm";
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(291, 41);
            this.txtsearch.TabIndex = 90;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // butInHoaDon
            // 
            this.butInHoaDon.BorderRadius = 15;
            this.butInHoaDon.BorderThickness = 1;
            this.butInHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butInHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butInHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butInHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butInHoaDon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(144)))), ((int)(((byte)(124)))));
            this.butInHoaDon.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInHoaDon.ForeColor = System.Drawing.Color.Black;
            this.butInHoaDon.Location = new System.Drawing.Point(641, 737);
            this.butInHoaDon.Name = "butInHoaDon";
            this.butInHoaDon.Size = new System.Drawing.Size(246, 55);
            this.butInHoaDon.TabIndex = 91;
            this.butInHoaDon.Text = "In Hóa Đơn";
            this.butInHoaDon.Click += new System.EventHandler(this.butInHoaDon_Click);
            // 
            // FPurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1082, 853);
            this.Controls.Add(this.butInHoaDon);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.butDetailBill);
            this.Controls.Add(this.dgvLSMH);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FPurchaseHistory";
            this.Text = "FPurchaseHistory";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSMH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLSMH;
        private Guna.UI2.WinForms.Guna2Button butDetailBill;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private Guna.UI2.WinForms.Guna2Button butInHoaDon;
    }
}