namespace CuaHangWindowForm.View.HoaDon
{
    partial class ChiTietHoaDon
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtInvoiceDate;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.DataGridView dataGridViewInvoiceDetails;
        private System.Windows.Forms.Button btnBack;

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
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.dataGridViewInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Location = new System.Drawing.Point(12, 15);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(88, 16);
            this.lblInvoiceID.TabIndex = 0;
            this.lblInvoiceID.Text = "Mã số hóa đơn";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(12, 45);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(93, 16);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "Mã khách hàng";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(12, 75);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(82, 16);
            this.lblInvoiceDate.TabIndex = 2;
            this.lblInvoiceDate.Text = "Ngày hóa đơn";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(12, 105);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(58, 16);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Tổng giá";
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Location = new System.Drawing.Point(120, 12);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.ReadOnly = true;
            this.txtInvoiceID.Size = new System.Drawing.Size(200, 22);
            this.txtInvoiceID.TabIndex = 4;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(120, 42);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(200, 22);
            this.txtCustomerID.TabIndex = 5;
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(120, 72);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.ReadOnly = true;
            this.txtInvoiceDate.Size = new System.Drawing.Size(200, 22);
            this.txtInvoiceDate.TabIndex = 6;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(120, 102);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(200, 22);
            this.txtTotalPrice.TabIndex = 7;
            // 
            // dataGridViewInvoiceDetails
            // 
            this.dataGridViewInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoiceDetails.Location = new System.Drawing.Point(12, 140);
            this.dataGridViewInvoiceDetails.Name = "dataGridViewInvoiceDetails";
            this.dataGridViewInvoiceDetails.RowHeadersWidth = 51;
            this.dataGridViewInvoiceDetails.RowTemplate.Height = 24;
            this.dataGridViewInvoiceDetails.Size = new System.Drawing.Size(776, 250);
            this.dataGridViewInvoiceDetails.TabIndex = 8;
            this.dataGridViewInvoiceDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewInvoiceDetails_CellFormatting);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 406);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewInvoiceDetails);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
