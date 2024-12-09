using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;

namespace CuaHangWindowForm.View.HoaDon
{
    partial class HoaDonForm
    {
        private System.ComponentModel.IContainer components = null;
        private C1FlexGrid dataGridViewInvoices;
        private C1Button btnAction;
        private ContextMenuStrip contextMenuStripActions;
        private ToolStripMenuItem toolStripMenuItemAdd;
        private ToolStripMenuItem toolStripMenuItemEdit;
        private ToolStripMenuItem toolStripMenuItemViewDetails;
        private ToolStripMenuItem toolStripMenuItemDelete;
        private C1Button btnBack; // Declare the back button

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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewInvoices = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.btnAction = new C1.Win.C1Input.C1Button();
            this.contextMenuStripActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).BeginInit();
            this.contextMenuStripActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewInvoices
            // 
            this.dataGridViewInvoices.ColumnInfo = "10,1,0,0,0,105,Columns:";
            this.dataGridViewInvoices.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewInvoices.Name = "dataGridViewInvoices";
            this.dataGridViewInvoices.Rows.DefaultSize = 21;
            this.dataGridViewInvoices.Size = new System.Drawing.Size(686, 426);
            this.dataGridViewInvoices.TabIndex = 0;
            this.dataGridViewInvoices.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.dataGridViewInvoices.AutoGenerateColumns = false;
            this.dataGridViewInvoices.AllowEditing = false;

            // Add columns
            this.dataGridViewInvoices.Cols.Count = 4; // Set the number of columns

            this.dataGridViewInvoices.Cols[1].Caption = "Mã hóa đơn";
            this.dataGridViewInvoices.Cols[1].Name = "InvoiceID";
            this.dataGridViewInvoices.Cols[1].DataType = typeof(string);

            this.dataGridViewInvoices.Cols[2].Caption = "Khách hàng";
            this.dataGridViewInvoices.Cols[2].Name = "Customer";
            this.dataGridViewInvoices.Cols[2].DataType = typeof(string);

            this.dataGridViewInvoices.Cols[3].Caption = "Tổng giá";
            this.dataGridViewInvoices.Cols[3].Name = "TotalPrice";
            this.dataGridViewInvoices.Cols[3].DataType = typeof(decimal);

            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(704, 12);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(93, 24);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "Thực hiện";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // contextMenuStripActions
            // 
            this.contextMenuStripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdd,
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemViewDetails,
            this.toolStripMenuItemDelete});
            this.contextMenuStripActions.Name = "contextMenuStripActions";
            this.contextMenuStripActions.Size = new System.Drawing.Size(181, 114);
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemAdd.Text = "Thêm";
            this.toolStripMenuItemAdd.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemEdit.Text = "Sửa";
            this.toolStripMenuItemEdit.Click += new System.EventHandler(this.btnEditInvoice_Click);
            // 
            // toolStripMenuItemViewDetails
            // 
            this.toolStripMenuItemViewDetails.Name = "toolStripMenuItemViewDetails";
            this.toolStripMenuItemViewDetails.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.toolStripMenuItemViewDetails.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemViewDetails.Text = "Chi tiết";
            this.toolStripMenuItemViewDetails.Click += new System.EventHandler(this.btnViewInvoiceDetails_Click);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemDelete.Text = "Xóa";
            this.toolStripMenuItemDelete.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(704, 42);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(93, 24);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // HoaDonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.dataGridViewInvoices);
            this.Name = "HoaDonForm";
            this.Text = "Danh sách hóa đơn";
            this.Load += new System.EventHandler(this.HoaDonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).EndInit();
            this.contextMenuStripActions.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}



