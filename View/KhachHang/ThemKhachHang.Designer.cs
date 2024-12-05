namespace CuaHangWindowForm.View.KhachHang
{
    partial class ThemKhachHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(12, 12);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(98, 16);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Mã khách hàng";
            this.lblCustomerID.Click += new System.EventHandler(this.lblCustomerID_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 42);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(103, 16);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Tên khách hàng";
            this.lblCustomerName.Click += new System.EventHandler(this.lblCustomerName_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 75);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(85, 16);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(121, 12);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(247, 22);
            this.txtCustomerID.TabIndex = 3;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(121, 42);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(247, 22);
            this.txtCustomerName.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(121, 72);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(247, 22);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(121, 100);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(93, 24);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Nhập tiếp";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(275, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 24);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 140);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerID);
            this.Name = "ThemKhachHang";
            this.Text = "Thêm khách hàng";
            this.Load += new System.EventHandler(this.ThemKhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
