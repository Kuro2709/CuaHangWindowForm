using C1.Win.C1Input;

namespace CuaHangWindowForm.View.HoaDon
{
    partial class AddProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private C1.Win.C1Input.C1ComboBox cmbProduct;
        private C1.Win.C1Input.C1Label lblProduct;
        private C1.Win.C1Input.C1Label lblQuantity;
        private C1.Win.C1Input.C1NumericEdit nudQuantity;
        private C1.Win.C1Input.C1Button btnOK;
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
            this.cmbProduct = new C1.Win.C1Input.C1ComboBox();
            this.lblProduct = new C1.Win.C1Input.C1Label();
            this.lblQuantity = new C1.Win.C1Input.C1Label();
            this.nudQuantity = new C1.Win.C1Input.C1NumericEdit();
            this.btnOK = new C1.Win.C1Input.C1Button();
            this.btnCancel = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProduct
            // 
            this.cmbProduct.AllowSpinLoop = false;
            this.cmbProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbProduct.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbProduct.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cmbProduct.GapHeight = 0;
            this.cmbProduct.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cmbProduct.Location = new System.Drawing.Point(120, 12);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(200, 20);
            this.cmbProduct.TabIndex = 0;
            this.cmbProduct.Tag = null;
            this.cmbProduct.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.cmbProduct.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblProduct.Location = new System.Drawing.Point(12, 15);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(67, 16);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Sản phẩm:";
            this.lblProduct.TextDetached = true;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblQuantity.Location = new System.Drawing.Point(12, 45);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(69, 16);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Số lượng:";
            this.lblProduct.TextDetached = true;
            // 
            // nudQuantity
            // 
            this.nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.nudQuantity.Calculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.nudQuantity.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.nudQuantity.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.nudQuantity.ImagePadding = new System.Windows.Forms.Padding(0);
            this.nudQuantity.Location = new System.Drawing.Point(120, 42);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.PostValidation.Intervals.AddRange(new C1.Win.C1Input.ValueInterval[] {
            new C1.Win.C1Input.ValueInterval(new decimal(new int[] {
                            1,
                            0,
                            0,
                            0}), new decimal(new int[] {
                            100000,
                            0,
                            0,
                            0}), true, true)});
            this.nudQuantity.Size = new System.Drawing.Size(200, 20);
            this.nudQuantity.TabIndex = 3;
            this.nudQuantity.Tag = null;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.nudQuantity.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(120, 80);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.UseVisualStyleForeColor = true;
            this.btnOK.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnOK.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.UseVisualStyleForeColor = true;
            this.btnCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 115);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cmbProduct);
            this.Name = "AddProductForm";
            this.Text = "Thêm sản phẩm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
