namespace CuaHangWindowForm.View.HoaDon
{
    partial class ChinhSuaHoaDon
    {
        private System.ComponentModel.IContainer components = null;
        private C1.Win.C1Input.C1TextBox lblInvoiceID;
        private C1.Win.C1Input.C1TextBox txtInvoiceID;
        private C1.Win.C1Input.C1Label lblCustomerID;
        private C1.Win.C1Input.C1ComboBox cmbCustomerID;
        private C1.Win.C1Input.C1Label lblInvoiceDate;
        private C1.Win.Calendar.C1DateEdit dtpInvoiceDate;
        private C1.Win.C1FlexGrid.C1FlexGrid dataGridViewInvoiceDetails;
        private C1.Win.C1Input.C1Button btnAddDetailRow;
        private C1.Win.C1Input.C1Button btnSave;
        private C1.Win.C1Input.C1Button btnCancel;
        private C1.Win.C1Input.C1Label lblTotalPrice;
        private C1.Win.C1Input.C1TextBox txtTotalPrice;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChinhSuaHoaDon));
            this.lblInvoiceID = new C1.Win.C1Input.C1TextBox();
            this.txtInvoiceID = new C1.Win.C1Input.C1TextBox();
            this.lblCustomerID = new C1.Win.C1Input.C1Label();
            this.cmbCustomerID = new C1.Win.C1Input.C1ComboBox();
            this.lblInvoiceDate = new C1.Win.C1Input.C1Label();
            this.dtpInvoiceDate = new C1.Win.Calendar.C1DateEdit();
            this.dataGridViewInvoiceDetails = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.btnAddDetailRow = new C1.Win.C1Input.C1Button();
            this.btnSave = new C1.Win.C1Input.C1Button();
            this.btnCancel = new C1.Win.C1Input.C1Button();
            this.lblTotalPrice = new C1.Win.C1Input.C1Label();
            this.txtTotalPrice = new C1.Win.C1Input.C1TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lblInvoiceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInvoiceDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpInvoiceDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddDetailRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInvoiceID.Location = new System.Drawing.Point(12, 15);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.ReadOnly = true;
            this.lblInvoiceID.Size = new System.Drawing.Size(78, 15);
            this.lblInvoiceID.TabIndex = 0;
            this.lblInvoiceID.Tag = null;
            this.lblInvoiceID.Text = "Mã hóa đơn";
            this.lblInvoiceID.TextDetached = true;
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInvoiceID.Location = new System.Drawing.Point(120, 12);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(200, 20);
            this.txtInvoiceID.TabIndex = 1;
            this.txtInvoiceID.Tag = null;
            this.txtInvoiceID.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.txtInvoiceID.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCustomerID.Location = new System.Drawing.Point(12, 45);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(77, 16);
            this.lblCustomerID.TabIndex = 2;
            this.lblCustomerID.Tag = null;
            this.lblCustomerID.Text = "Khách hàng";
            this.lblCustomerID.TextDetached = true;
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.AllowSpinLoop = false;
            this.cmbCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbCustomerID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbCustomerID.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cmbCustomerID.GapHeight = 0;
            this.cmbCustomerID.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cmbCustomerID.Location = new System.Drawing.Point(120, 42);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(200, 20);
            this.cmbCustomerID.TabIndex = 3;
            this.cmbCustomerID.Tag = null;
            this.cmbCustomerID.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.cmbCustomerID.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInvoiceDate.Location = new System.Drawing.Point(12, 75);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(92, 16);
            this.lblInvoiceDate.TabIndex = 4;
            this.lblInvoiceDate.Tag = null;
            this.lblInvoiceDate.Text = "Ngày hóa đơn";
            this.lblInvoiceDate.TextDetached = true;
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtpInvoiceDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.dtpInvoiceDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.dtpInvoiceDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.dtpInvoiceDate.ImagePadding = new System.Windows.Forms.Padding(0);
            this.dtpInvoiceDate.Location = new System.Drawing.Point(120, 72);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(200, 20);
            this.dtpInvoiceDate.TabIndex = 5;
            this.dtpInvoiceDate.Tag = null;
            this.dtpInvoiceDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.dtpInvoiceDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            // 
            // dataGridViewInvoiceDetails
            // 
            this.dataGridViewInvoiceDetails.ColumnInfo = "10,1,0,0,0,105,Columns:6{Style:\"ComboList:\"\"|...\"\";\";}\t";
            this.dataGridViewInvoiceDetails.Location = new System.Drawing.Point(12, 110);
            this.dataGridViewInvoiceDetails.Name = "dataGridViewInvoiceDetails";
            this.dataGridViewInvoiceDetails.Rows.DefaultSize = 24;
            this.dataGridViewInvoiceDetails.Size = new System.Drawing.Size(776, 250);
            this.dataGridViewInvoiceDetails.StyleInfo = resources.GetString("dataGridViewInvoiceDetails.StyleInfo");
            this.dataGridViewInvoiceDetails.TabIndex = 6;
            this.dataGridViewInvoiceDetails.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            // 
            // btnAddDetailRow
            // 
            this.btnAddDetailRow.Location = new System.Drawing.Point(12, 379);
            this.btnAddDetailRow.Name = "btnAddDetailRow";
            this.btnAddDetailRow.Size = new System.Drawing.Size(150, 23);
            this.btnAddDetailRow.TabIndex = 7;
            this.btnAddDetailRow.Text = "Thêm sản phẩm";
            this.btnAddDetailRow.UseVisualStyleBackColor = true;
            this.btnAddDetailRow.UseVisualStyleForeColor = true;
            this.btnAddDetailRow.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnAddDetailRow.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
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
            this.btnSave.UseVisualStyleForeColor = true;
            this.btnSave.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnSave.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
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
            this.btnCancel.UseVisualStyleForeColor = true;
            this.btnCancel.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnCancel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTotalPrice.Location = new System.Drawing.Point(521, 383);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(61, 16);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Tag = null;
            this.lblTotalPrice.Text = "Tổng giá";
            this.lblTotalPrice.TextDetached = true;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPrice.Location = new System.Drawing.Point(588, 380);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(200, 20);
            this.txtTotalPrice.TabIndex = 11;
            this.txtTotalPrice.Tag = null;
            this.txtTotalPrice.TextDetached = true;
            this.txtTotalPrice.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.txtTotalPrice.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
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
            ((System.ComponentModel.ISupportInitialize)(this.lblInvoiceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInvoiceDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpInvoiceDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoiceDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddDetailRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
