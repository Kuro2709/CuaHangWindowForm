namespace CuaHangWindowForm.View.HoaDon
{
    partial class ChiTietHoaDon
    {
        private System.ComponentModel.IContainer components = null;
        private C1.Win.C1Input.C1Label lblInvoiceID;
        private C1.Win.C1Input.C1Label lblCustomerID;
        private C1.Win.C1Input.C1Label lblInvoiceDate;
        private C1.Win.C1Input.C1TextBox txtInvoiceID;
        private C1.Win.C1Input.C1TextBox txtCustomerID;
        private C1.Win.C1Input.C1TextBox txtInvoiceDate;
        private C1.Win.C1Input.C1TextBox txtTotalPrice;
        private C1.Win.C1FlexGrid.C1FlexGrid flexGridInvoiceDetails;
        private C1.Win.C1Input.C1Button btnBack;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietHoaDon));
            this.lblInvoiceID = new C1.Win.C1Input.C1Label();
            this.lblCustomerID = new C1.Win.C1Input.C1Label();
            this.lblInvoiceDate = new C1.Win.C1Input.C1Label();
            this.txtInvoiceID = new C1.Win.C1Input.C1TextBox();
            this.txtCustomerID = new C1.Win.C1Input.C1TextBox();
            this.txtInvoiceDate = new C1.Win.C1Input.C1TextBox();
            this.txtTotalPrice = new C1.Win.C1Input.C1TextBox();
            this.flexGridInvoiceDetails = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.btnBack = new C1.Win.C1Input.C1Button();
            this.lblTotalPrice = new C1.Win.C1Input.C1Label();
            ((System.ComponentModel.ISupportInitialize)(this.lblInvoiceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInvoiceDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flexGridInvoiceDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInvoiceID.Location = new System.Drawing.Point(12, 15);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(78, 16);
            this.lblInvoiceID.TabIndex = 0;
            this.lblInvoiceID.Tag = null;
            this.lblInvoiceID.Text = "Mã hóa đơn";
            this.lblInvoiceID.TextDetached = true;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCustomerID.Location = new System.Drawing.Point(12, 45);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(98, 16);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Tag = null;
            this.lblCustomerID.Text = "Mã khách hàng";
            this.lblCustomerID.TextDetached = true;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInvoiceDate.Location = new System.Drawing.Point(12, 75);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(114, 16);
            this.lblInvoiceDate.TabIndex = 2;
            this.lblInvoiceDate.Tag = null;
            this.lblInvoiceDate.Text = "Ngày tạo hóa đơn";
            this.lblInvoiceDate.TextDetached = true;
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceID.Location = new System.Drawing.Point(132, 12);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.ReadOnly = true;
            this.txtInvoiceID.Size = new System.Drawing.Size(200, 20);
            this.txtInvoiceID.TabIndex = 4;
            this.txtInvoiceID.Tag = null;
            this.txtInvoiceID.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.txtInvoiceID.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerID.Location = new System.Drawing.Point(132, 40);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerID.TabIndex = 5;
            this.txtCustomerID.Tag = null;
            this.txtCustomerID.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.txtCustomerID.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceDate.Location = new System.Drawing.Point(132, 72);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.ReadOnly = true;
            this.txtInvoiceDate.Size = new System.Drawing.Size(200, 20);
            this.txtInvoiceDate.TabIndex = 6;
            this.txtInvoiceDate.Tag = null;
            this.txtInvoiceDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.txtInvoiceDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.txtInvoiceDate.TextChanged += new System.EventHandler(this.txtInvoiceDate_TextChanged);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPrice.Location = new System.Drawing.Point(132, 102);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(200, 20);
            this.txtTotalPrice.TabIndex = 7;
            this.txtTotalPrice.Tag = null;
            this.txtTotalPrice.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.txtTotalPrice.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.txtTotalPrice.TextChanged += new System.EventHandler(this.txtTotalPrice_TextChanged);
            // 
            // flexGridInvoiceDetails
            // 
            this.flexGridInvoiceDetails.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.flexGridInvoiceDetails.Location = new System.Drawing.Point(12, 140);
            this.flexGridInvoiceDetails.Name = "flexGridInvoiceDetails";
            this.flexGridInvoiceDetails.Rows.DefaultSize = 19;
            this.flexGridInvoiceDetails.Size = new System.Drawing.Size(776, 250);
            this.flexGridInvoiceDetails.StyleInfo = resources.GetString("flexGridInvoiceDetails.StyleInfo");
            this.flexGridInvoiceDetails.TabIndex = 8;
            this.flexGridInvoiceDetails.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            this.flexGridInvoiceDetails.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.flexGridInvoiceDetails_OwnerDrawCell);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 406);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.UseVisualStyleForeColor = true;
            this.btnBack.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnBack.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTotalPrice.Location = new System.Drawing.Point(12, 105);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(91, 16);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Tag = null;
            this.lblTotalPrice.Text = "Tổng hóa đơn";
            this.lblTotalPrice.TextDetached = true;
            // 
            // ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.flexGridInvoiceDetails);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtInvoiceDate);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtInvoiceID);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblInvoiceID);
            this.Name = "ChiTietHoaDon";
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.ChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblInvoiceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInvoiceDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flexGridInvoiceDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private C1.Win.C1Input.C1Label lblTotalPrice;
    }
}

