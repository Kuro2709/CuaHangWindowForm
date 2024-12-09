namespace CuaHangWindowForm.View.KhachHang
{
    partial class ChinhSuaKhachHang
    {
        private System.ComponentModel.IContainer components = null;
        private C1.Win.C1Input.C1Label lblCustomerID;
        private C1.Win.C1Input.C1Label lblCustomerName;
        private C1.Win.C1Input.C1Label lblPhone;
        private C1.Win.C1Input.C1TextBox txtCustomerID;
        private C1.Win.C1Input.C1TextBox txtCustomerName;
        private C1.Win.C1Input.C1TextBox txtPhone;
        private C1.Win.C1Input.C1Button btnSave;
        private C1.Win.C1Input.C1Button btnCancel;

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
            this.lblCustomerID = new C1.Win.C1Input.C1Label();
            this.lblCustomerName = new C1.Win.C1Input.C1Label();
            this.lblPhone = new C1.Win.C1Input.C1Label();
            this.txtCustomerID = new C1.Win.C1Input.C1TextBox();
            this.txtCustomerName = new C1.Win.C1Input.C1TextBox();
            this.txtPhone = new C1.Win.C1Input.C1TextBox();
            this.btnSave = new C1.Win.C1Input.C1Button();
            this.btnCancel = new C1.Win.C1Input.C1Button();
            this.SuspendLayout();
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(12, 15);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(98, 16);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.TextDetached = true; // Ensure the Text property is detached
            this.lblCustomerID.Text = "Mã khách hàng";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 45);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(103, 16);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.TextDetached = true; // Ensure the Text property is detached
            this.lblCustomerName.Text = "Tên khách hàng";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 75);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(85, 16);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.TextDetached = true; // Ensure the Text property is detached
            this.lblPhone.Text = "Số điện thoại";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(121, 12);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(247, 22);
            this.txtCustomerID.TabIndex = 3;
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.TextDetached = true; // Ensure the Text property is detached
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(121, 42);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(247, 22);
            this.txtCustomerName.TabIndex = 4;
            this.txtCustomerName.TextDetached = true; // Ensure the Text property is detached
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(121, 72);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(247, 22);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.TextDetached = true; // Ensure the Text property is detached
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(121, 100);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 24);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // ChinhSuaKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 140);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerID);
            this.Name = "ChinhSuaKhachHang";
            this.Text = "Chỉnh sửa khách hàng";
            this.Load += new System.EventHandler(this.ChinhSuaKhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
