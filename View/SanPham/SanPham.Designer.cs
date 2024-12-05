using System.Windows.Forms;

namespace WindowsFormsApp
{
    partial class SanPhamForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripActions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.Button btnBack; // Declare the back button

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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.btnAction = new System.Windows.Forms.Button();
            this.contextMenuStripActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.contextMenuStripActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(686, 426);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.AutoGenerateColumns = false;
            this.dataGridViewProducts.ReadOnly = true;

            // Add columns
            var productIDColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductID",
                HeaderText = "Mã sản phẩm",
                Name = "ProductID"
            };
            dataGridViewProducts.Columns.Add(productIDColumn);

            var productNameColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ProductName",
                HeaderText = "Tên sản phẩm",
                Name = "ProductName"
            };
            dataGridViewProducts.Columns.Add(productNameColumn);

            var priceColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Giá",
                Name = "Price"
            };
            dataGridViewProducts.Columns.Add(priceColumn);

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
            this.toolStripMenuItemDelete});
            this.contextMenuStripActions.Name = "contextMenuStripActions";
            this.contextMenuStripActions.Size = new System.Drawing.Size(181, 92);
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemAdd.Text = "Thêm";
            this.toolStripMenuItemAdd.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemEdit.Text = "Sửa";
            this.toolStripMenuItemEdit.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemDelete.Text = "Xóa";
            this.toolStripMenuItemDelete.Click += new System.EventHandler(this.btnDeleteProduct_Click);
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
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "ProductForm";
            this.Text = "Danh sách sản phẩm";
            this.Load += new System.EventHandler(this.SanPhamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.contextMenuStripActions.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
