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
            this.SuspendLayout();
            // 
            // lblCustomerID
            //
            this.lblCustomerID.TextDetached = true;
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Text = "Mã khách hàng";
            this.lblCustomerID.Location = new System.Drawing.Point(12, 12);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(100, 20);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.TextDetached = true;
            this.lblCustomerName.Text = "Tên khách hàng";
            this.lblCustomerName.Location = new System.Drawing.Point(12, 42);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(100, 20);
            // 
            // lblPhone
            // 
            this.lblPhone.TextDetached = true;
            this.lblPhone.Text = "Số điện thoại";
            this.lblPhone.Location = new System.Drawing.Point(12, 72);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 20);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(121, 12);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(247, 22);
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(121, 42);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(247, 22);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(121, 72);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(247, 22);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Text = "Nhập tiếp";
            this.btnSubmit.Location = new System.Drawing.Point(121, 100);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(93, 24);
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Location = new System.Drawing.Point(275, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 24);
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
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
