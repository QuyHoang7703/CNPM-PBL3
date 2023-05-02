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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelGiaTri = new System.Windows.Forms.Label();
            this.labelChiTiet = new System.Windows.Forms.Label();
            this.PTBHinhAnh = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PTBHinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.labelGiaTri);
            this.guna2Panel1.Controls.Add(this.labelChiTiet);
            this.guna2Panel1.Controls.Add(this.PTBHinhAnh);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(34, 31);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(363, 436);
            this.guna2Panel1.TabIndex = 0;
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
            // 
            // PTBHinhAnh
            // 
            this.PTBHinhAnh.Location = new System.Drawing.Point(3, 13);
            this.PTBHinhAnh.Name = "PTBHinhAnh";
            this.PTBHinhAnh.Size = new System.Drawing.Size(357, 246);
            this.PTBHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PTBHinhAnh.TabIndex = 0;
            this.PTBHinhAnh.TabStop = false;
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
    }
}
