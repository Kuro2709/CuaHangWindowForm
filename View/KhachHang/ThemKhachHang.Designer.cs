namespace CuaHangWindowForm.View.KhachHang
{
    partial class ThemKhachHang
    {
        private System.ComponentModel.IContainer components = null;
        private C1.Win.C1Input.C1Label lblCustomerID;
        private C1.Win.C1Input.C1Label lblCustomerName;
        private C1.Win.C1Input.C1Label lblPhone;
        private C1.Win.C1Input.C1TextBox txtCustomerID;
        private C1.Win.C1Input.C1TextBox txtCustomerName;
        private C1.Win.C1Input.C1TextBox txtPhone;
        private C1.Win.C1Input.C1Button btnSubmit;
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
            this.btnSubmit = new C1.Win.C1Input.C1Button();
            this.btnCancel = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCustomerID.Location = new System.Drawing.Point(12, 12);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(98, 16);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Tag = null;
            this.lblCustomerID.Text = "Mã khách hàng";
            this.lblCustomerID.TextDetached = true;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 42);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(100, 20);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Tag = null;
            this.lblCustomerName.Text = "Tên khách hàng";
            this.lblCustomerName.TextDetached = true;
            // 
            // lblPhone
            // 
            this.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPhone.Location = new System.Drawing.Point(12, 72);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 20);
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
            this.txtCustomerID.Size = new System.Drawing.Size(247, 20);
            this.txtCustomerID.TabIndex = 3;
            this.txtCustomerID.Tag = null;
            this.txtCustomerID.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.txtCustomerID.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Location = new System.Drawing.Point(121, 42);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(247, 20);
            this.txtCustomerName.TabIndex = 4;
            this.txtCustomerName.Tag = null;
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
            this.txtPhone.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.txtPhone.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
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
            this.btnSubmit.UseVisualStyleForeColor = true;
            this.btnSubmit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnSubmit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
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
            this.btnCancel.UseVisualStyleForeColor = true;
            this.btnCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ThemKhachHang
            // 
            this.ClientSize = new System.Drawing.Size(380, 140);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Name = "ThemKhachHang";
            this.Text = "Thêm khách hàng";
            this.Load += new System.EventHandler(this.ThemKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
