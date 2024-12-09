﻿namespace CuaHangWindowForm.View.SanPham
{
    partial class ThemSanPham
    {
        private System.ComponentModel.IContainer components = null;
        private C1.Win.C1Input.C1Label lblProductID;
        private C1.Win.C1Input.C1Label lblProductName;
        private C1.Win.C1Input.C1Label lblPrice;
        private C1.Win.C1Input.C1TextBox txtProductID;
        private C1.Win.C1Input.C1TextBox txtProductName;
        private C1.Win.C1Input.C1TextBox txtPrice;
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
            this.lblProductID = new C1.Win.C1Input.C1Label();
            this.lblProductName = new C1.Win.C1Input.C1Label();
            this.lblPrice = new C1.Win.C1Input.C1Label();
            this.txtProductID = new C1.Win.C1Input.C1TextBox();
            this.txtProductName = new C1.Win.C1Input.C1TextBox();
            this.txtPrice = new C1.Win.C1Input.C1TextBox();
            this.btnSubmit = new C1.Win.C1Input.C1Button();
            this.btnCancel = new C1.Win.C1Input.C1Button();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(12, 15);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(88, 16);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.TextDetached = true; // Ensure the Text property is detached
            this.lblProductID.Text = "Mã sản phẩm";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 45);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(93, 16);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.TextDetached = true; // Ensure the Text property is detached
            this.lblProductName.Text = "Tên sản phẩm";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 75);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(28, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.TextDetached = true; // Ensure the Text property is detached
            this.lblPrice.Text = "Giá";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(113, 12);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(255, 22);
            this.txtProductID.TabIndex = 3;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(113, 42);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(255, 22);
            this.txtProductName.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(113, 72);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(255, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(113, 100);
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
            // ThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 140);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductID);
            this.Name = "ThemSanPham";
            this.Text = "Thêm sản phẩm";
            this.Load += new System.EventHandler(this.ThemSanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }


    }
}
