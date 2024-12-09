namespace CuaHangWindowForm.View.SanPham
{
    partial class ChinhSuaSanPham
    {
        private System.ComponentModel.IContainer components = null;
        private C1.Win.C1Input.C1Label lblProductID;
        private C1.Win.C1Input.C1TextBox txtProductID;
        private C1.Win.C1Input.C1Label lblProductName;
        private C1.Win.C1Input.C1TextBox txtProductName;
        private C1.Win.C1Input.C1Label lblPrice;
        private C1.Win.C1Input.C1NumericEdit numPrice;
        private C1.Win.C1Input.C1Button btnSave;
        private C1.Win.C1Input.C1Button btnCancel;
        private C1.Win.C1Input.C1Label lblMessage;

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
            this.txtProductID = new C1.Win.C1Input.C1TextBox();
            this.lblProductName = new C1.Win.C1Input.C1Label();
            this.txtProductName = new C1.Win.C1Input.C1TextBox();
            this.lblPrice = new C1.Win.C1Input.C1Label();
            this.numPrice = new C1.Win.C1Input.C1NumericEdit();
            this.btnSave = new C1.Win.C1Input.C1Button();
            this.btnCancel = new C1.Win.C1Input.C1Button();
            this.lblMessage = new C1.Win.C1Input.C1Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(50, 20);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(93, 16);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.TextDetached = true; // Ensure the Text property is detached
            this.lblProductID.Text = "Mã sản phẩm";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(200, 20);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(200, 22);
            this.txtProductID.TabIndex = 1;
            this.txtProductID.ReadOnly = true;
            this.txtProductID.TextDetached = true; // Ensure the Text property is detached
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(50, 60);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(93, 16);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.TextDetached = true; // Ensure the Text property is detached
            this.lblProductName.Text = "Tên sản phẩm";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(200, 60);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 22);
            this.txtProductName.TabIndex = 3;
            this.txtProductName.TextDetached = true; // Ensure the Text property is detached
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(50, 100);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 16);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.TextDetached = true; // Ensure the Text property is detached
            this.lblPrice.Text = "Giá thành";
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(200, 100);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(200, 22);
            this.numPrice.TabIndex = 5;
            this.numPrice.PostValidation.Validation = C1.Win.C1Input.PostValidationTypeEnum.ValuesAndIntervals;
            this.numPrice.PostValidation.Intervals.AddRange(new C1.Win.C1Input.ValueInterval[] {
                new C1.Win.C1Input.ValueInterval(
                    new decimal(new int[] {1, 0, 0, 0}), // Minimum value
                    new decimal(new int[] {1000000, 0, 0, 0}), // Maximum value
                    true, // Include minimum
                    true) // Include maximum
            });
            this.numPrice.ValueChanged += new System.EventHandler(this.numPrice_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(200, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(325, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(50, 200);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 8;
            // 
            // ChinhSuaSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductID);
            this.Name = "ChinhSuaSanPham";
            this.Text = "Chỉnh sửa sản phẩm";
            this.Load += new System.EventHandler(this.ChinhSuaSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

