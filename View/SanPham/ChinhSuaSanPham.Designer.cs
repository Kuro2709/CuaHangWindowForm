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
            ((System.ComponentModel.ISupportInitialize)(this.lblProductID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblProductID.Location = new System.Drawing.Point(50, 20);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(88, 16);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Tag = null;
            this.lblProductID.Text = "Mã sản phẩm";
            this.lblProductID.TextDetached = true;
            // 
            // txtProductID
            // 
            this.txtProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductID.Location = new System.Drawing.Point(200, 20);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(200, 20);
            this.txtProductID.TabIndex = 1;
            this.txtProductID.Tag = null;
            this.txtProductID.TextDetached = true;
            this.txtProductID.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.txtProductID.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblProductName.Location = new System.Drawing.Point(50, 60);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(93, 16);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Tag = null;
            this.lblProductName.Text = "Tên sản phẩm";
            this.lblProductName.TextDetached = true;
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Location = new System.Drawing.Point(200, 60);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(200, 20);
            this.txtProductName.TabIndex = 3;
            this.txtProductName.Tag = null;
            this.txtProductName.TextDetached = true;
            this.txtProductName.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.txtProductName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPrice.Location = new System.Drawing.Point(50, 100);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(63, 16);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Tag = null;
            this.lblPrice.Text = "Giá thành";
            this.lblPrice.TextDetached = true;
            // 
            // numPrice
            // 
            this.numPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.numPrice.Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.numPrice.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.numPrice.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.numPrice.ImagePadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.numPrice.Location = new System.Drawing.Point(200, 100);
            this.numPrice.Name = "numPrice";
            this.numPrice.PostValidation.Intervals.AddRange(new C1.Win.C1Input.ValueInterval[] {
                    new C1.Win.C1Input.ValueInterval(new decimal(new int[] {
                                    1,
                                    0,
                                    0,
                                    0}), new decimal(new int[] {
                                    100000000,
                                    0,
                                    0,
                                    0}), true, true)});
            this.numPrice.Size = new System.Drawing.Size(200, 20);
            this.numPrice.TabIndex = 5;
            this.numPrice.Tag = null;
            this.numPrice.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.numPrice.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
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
            this.btnSave.UseVisualStyleForeColor = true;
            this.btnSave.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnSave.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
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
            this.btnCancel.UseVisualStyleForeColor = true;
            this.btnCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ChinhSuaSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 250);
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
            ((System.ComponentModel.ISupportInitialize)(this.lblProductID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

