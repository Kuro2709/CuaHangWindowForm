using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace WindowsFormsApp
{
    partial class SanPhamForm
    {
        private System.ComponentModel.IContainer components = null;
        private C1FlexGrid c1FlexGridProducts;
        private C1.Win.C1Input.C1Button btnAction;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripActions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPhamForm));
            this.c1FlexGridProducts = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.btnAction = new C1.Win.C1Input.C1Button();
            this.contextMenuStripActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAction)).BeginInit();
            this.contextMenuStripActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGridProducts
            // 
            this.c1FlexGridProducts.AllowEditing = false;
            this.c1FlexGridProducts.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.c1FlexGridProducts.Location = new System.Drawing.Point(12, 12);
            this.c1FlexGridProducts.Name = "c1FlexGridProducts";
            this.c1FlexGridProducts.Rows.DefaultSize = 19;
            this.c1FlexGridProducts.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.c1FlexGridProducts.Size = new System.Drawing.Size(686, 426);
            this.c1FlexGridProducts.StyleInfo = resources.GetString("c1FlexGridProducts.StyleInfo");
            this.c1FlexGridProducts.TabIndex = 0;
            this.c1FlexGridProducts.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(704, 12);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(93, 24);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "Thực hiện";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.UseVisualStyleForeColor = true;
            this.btnAction.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnAction.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // contextMenuStripActions
            // 
            this.contextMenuStripActions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdd,
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemDelete});
            this.contextMenuStripActions.Name = "contextMenuStripActions";
            this.contextMenuStripActions.Size = new System.Drawing.Size(169, 76);
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(168, 24);
            this.toolStripMenuItemAdd.Text = "Thêm";
            this.toolStripMenuItemAdd.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(168, 24);
            this.toolStripMenuItemEdit.Text = "Sửa";
            this.toolStripMenuItemEdit.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(168, 24);
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
            this.btnBack.UseVisualStyleForeColor = true;
            this.btnBack.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnBack.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SanPhamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.c1FlexGridProducts);
            this.Name = "SanPhamForm";
            this.Text = "Danh sách sản phẩm";
            this.Load += new System.EventHandler(this.SanPhamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAction)).EndInit();
            this.contextMenuStripActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
