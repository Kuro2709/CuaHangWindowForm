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
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCustomerID.Location = new System.Drawing.Point(12, 15);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(98, 16);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Tag = null;
            this.lblCustomerID.Text = "Mã khách hàng";
            this.lblCustomerID.TextDetached = true;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 45);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(103, 16);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Tag = null;
            this.lblCustomerName.Text = "Tên khách hàng";
            this.lblCustomerName.TextDetached = true;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPhone.Location = new System.Drawing.Point(12, 75);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(85, 16);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Tag = null;
            this.lblPhone.Text = "Số điện thoại";
            this.lblPhone.TextDetached = true;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerID.Location = new System.Drawing.Point(121, 12);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(247, 20);
            this.txtCustomerID.TabIndex = 3;
            this.txtCustomerID.Tag = null;
            this.txtCustomerID.TextDetached = true;
            this.txtCustomerID.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.txtCustomerID.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Location = new System.Drawing.Point(121, 42);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(247, 20);
            this.txtCustomerName.TabIndex = 4;
            this.txtCustomerName.Tag = null;
            this.txtCustomerName.TextDetached = true;
            this.txtCustomerName.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.txtCustomerName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(121, 72);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(247, 20);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.Tag = null;
            this.txtPhone.TextDetached = true;
            this.txtPhone.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.txtPhone.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(121, 100);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 24);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.UseVisualStyleForeColor = true;
            this.btnSave.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnSave.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
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
            this.btnCancel.UseVisualStyleForeColor = true;
            this.btnCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
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
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
