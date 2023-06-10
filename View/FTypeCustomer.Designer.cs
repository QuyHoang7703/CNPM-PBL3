namespace CNPM_PBL3.View
{
    partial class FTypeCustomer
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
            this.ctbCancel = new Guna.UI2.WinForms.Guna2ControlBox();
            this.butNewCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.butOldCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctbCancel
            // 
            this.ctbCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctbCancel.BackColor = System.Drawing.Color.IndianRed;
            this.ctbCancel.FillColor = System.Drawing.Color.IndianRed;
            this.ctbCancel.IconColor = System.Drawing.Color.DimGray;
            this.ctbCancel.Location = new System.Drawing.Point(581, 31);
            this.ctbCancel.Name = "ctbCancel";
            this.ctbCancel.Size = new System.Drawing.Size(31, 29);
            this.ctbCancel.TabIndex = 32;
            this.ctbCancel.Click += new System.EventHandler(this.ctbCancel_Click);
            // 
            // butNewCustomer
            // 
            this.butNewCustomer.Animated = true;
            this.butNewCustomer.AutoRoundedCorners = true;
            this.butNewCustomer.BorderRadius = 21;
            this.butNewCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butNewCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butNewCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butNewCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butNewCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.butNewCustomer.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNewCustomer.ForeColor = System.Drawing.Color.Black;
            this.butNewCustomer.Location = new System.Drawing.Point(49, 154);
            this.butNewCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.butNewCustomer.Name = "butNewCustomer";
            this.butNewCustomer.Size = new System.Drawing.Size(266, 45);
            this.butNewCustomer.TabIndex = 33;
            this.butNewCustomer.Text = "Khách hàng mới";
            this.butNewCustomer.Click += new System.EventHandler(this.butNewCustomer_Click);
            // 
            // butOldCustomer
            // 
            this.butOldCustomer.Animated = true;
            this.butOldCustomer.AutoRoundedCorners = true;
            this.butOldCustomer.BorderRadius = 21;
            this.butOldCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butOldCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butOldCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butOldCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butOldCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.butOldCustomer.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOldCustomer.ForeColor = System.Drawing.Color.Black;
            this.butOldCustomer.Location = new System.Drawing.Point(358, 154);
            this.butOldCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.butOldCustomer.Name = "butOldCustomer";
            this.butOldCustomer.Size = new System.Drawing.Size(266, 45);
            this.butOldCustomer.TabIndex = 34;
            this.butOldCustomer.Text = "Khách hàng cũ";
            this.butOldCustomer.Click += new System.EventHandler(this.butOldCustomer_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(222)))), ((int)(((byte)(201)))));
            this.guna2Panel2.Location = new System.Drawing.Point(125, 57);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(405, 57);
            this.guna2Panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hãy chọn loại khách hàng ?";
            // 
            // FTypeCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(182)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(657, 228);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.butOldCustomer);
            this.Controls.Add(this.butNewCustomer);
            this.Controls.Add(this.ctbCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FTypeCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTypeCustomer";
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ControlBox ctbCancel;
        private Guna.UI2.WinForms.Guna2Button butNewCustomer;
        private Guna.UI2.WinForms.Guna2Button butOldCustomer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label2;
    }
}