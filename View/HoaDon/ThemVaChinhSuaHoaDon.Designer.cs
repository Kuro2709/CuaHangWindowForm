namespace CuaHangWindowForm.View.HoaDon
{
    partial class ThemVaChinhSuaHoaDon
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.DataGridView dataGridViewInvoiceDetails;
        private System.Windows.Forms.Button btnAddDetailRow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;

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
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewInvoiceDetails = new System.Windows.Forms.DataGridView();
            this.btnAddDetailRow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Location = new System.Drawing.Point(12, 15);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(78, 16);
            this.lblInvoiceID.TabIndex = 0;
            this.lblInvoiceID.Text = "Mã hóa đơn";
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Location = new System.Drawing.Point(120, 12);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(200, 22);
            this.txtInvoiceID.TabIndex = 1;
            this.txtInvoiceID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceID_KeyPress);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(12, 45);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(77, 16);
            this.lblCustomerID.TabIndex = 2;
            this.lblCustomerID.Text = "Khách hàng";
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(120, 42);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(200, 24);
            this.cmbCustomerID.TabIndex = 3;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(12, 75);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(92, 16);
            this.lblInvoiceDate.TabIndex = 4;
            this.lblInvoiceDate.Text = "Ngày hóa đơn";
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(120, 72);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(200, 22);
            this.dtpInvoiceDate.TabIndex = 5;
            // 
            // dataGridViewInvoiceDetails
            // 
            this.dataGridViewInvoiceDetails.AllowUserToAddRows = false;
            this.dataGridViewInvoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoiceDetails.Location = new System.Drawing.Point(12, 110);
            this.dataGridViewInvoiceDetails.Name = "dataGridViewInvoiceDetails";
            this.dataGridViewInvoiceDetails.RowHeadersWidth = 51;
            this.dataGridViewInvoiceDetails.RowTemplate.Height = 24;
            this.dataGridViewInvoiceDetails.Size = new System.Drawing.Size(776, 250);
            this.dataGridViewInvoiceDetails.TabIndex = 6;
            this.dataGridViewInvoiceDetails.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewInvoiceDetails_CellValidating);
            // 
            // btnAddDetailRow
            // 
            this.btnAddDetailRow.Location = new System.Drawing.Point(12, 379);
            this.btnAddDetailRow.Name = "btnAddDetailRow";
            this.btnAddDetailRow.Size = new System.Drawing.Size(150, 23);
            this.btnAddDetailRow.TabIndex = 7;
            this.btnAddDetailRow.Text = "Thêm sản phẩm";
            this.btnAddDetailRow.UseVisualStyleBackColor = true;
            this.btnAddDetailRow.Click += new System.EventHandler(this.btnAddDetailRow_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(713, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(521, 383);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(61, 16);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "Tổng giá";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(588, 380);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(200, 22);
            this.txtTotalPrice.TabIndex = 11;
            // 
            // ChinhSuaHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddDetailRow);
            this.Controls.Add(this.dataGridViewInvoiceDetails);
            this.Controls.Add(this.dtpInvoiceDate);
            this.Controls.Add(this.lblInvoiceDate);
            this.Controls.Add(this.cmbCustomerID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.txtInvoiceID);
            this.Controls.Add(this.lblInvoiceID);
            this.Name = "ChinhSuaHoaDon";
            this.Text = "Chỉnh sửa hóa đơn";
            this.Load += new System.EventHandler(this.ChinhSuaHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
