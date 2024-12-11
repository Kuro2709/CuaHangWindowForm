using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using C1.Win.C1Command;

namespace WindowsFormsApp
{
    partial class KhachHangForm
    {
        private System.ComponentModel.IContainer components = null;
        private C1FlexGrid dataGridViewCustomers;
        private C1Button btnAction;
        private C1ContextMenu contextMenuStripActions;
        private C1CommandLink commandLinkAdd;
        private C1CommandLink commandLinkEdit;
        private C1CommandLink commandLinkDelete;
        private C1CommandMenu commandMenuActions;
        private C1Command commandAdd;
        private C1Command commandEdit;
        private C1Command commandDelete;
        private C1Button btnBack;
        private C1CommandHolder c1CommandHolder1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHangForm));
            this.dataGridViewCustomers = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.btnAction = new C1.Win.C1Input.C1Button();
            this.contextMenuStripActions = new C1.Win.C1Command.C1ContextMenu();
            this.commandLinkAdd = new C1.Win.C1Command.C1CommandLink();
            this.commandAdd = new C1.Win.C1Command.C1Command();
            this.commandLinkEdit = new C1.Win.C1Command.C1CommandLink();
            this.commandEdit = new C1.Win.C1Command.C1Command();
            this.commandLinkDelete = new C1.Win.C1Command.C1CommandLink();
            this.commandDelete = new C1.Win.C1Command.C1Command();
            this.commandMenuActions = new C1.Win.C1Command.C1CommandMenu();
            this.btnBack = new C1.Win.C1Input.C1Button();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowEditing = false;
            this.dataGridViewCustomers.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.dataGridViewCustomers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.Rows.DefaultSize = 19;
            this.dataGridViewCustomers.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(686, 426);
            this.dataGridViewCustomers.StyleInfo = resources.GetString("dataGridViewCustomers.StyleInfo");
            this.dataGridViewCustomers.TabIndex = 0;
            this.dataGridViewCustomers.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2010Blue;
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
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // contextMenuStripActions
            // 
            this.contextMenuStripActions.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
                this.commandLinkAdd,
                this.commandLinkEdit,
                this.commandLinkDelete});
            this.contextMenuStripActions.Name = "contextMenuStripActions";
            this.contextMenuStripActions.ShortcutText = "";
            this.contextMenuStripActions.Virgin = false;
            // 
            // commandLinkAdd
            // 
            this.commandLinkAdd.Command = this.commandAdd;
            // 
            // commandAdd
            // 
            this.commandAdd.Name = "commandAdd";
            this.commandAdd.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.commandAdd.ShortcutText = "Ctrl+N";
            this.commandAdd.Text = "Thêm";
            this.commandAdd.Virgin = false;
            this.commandAdd.Click += new C1.Win.C1Command.ClickEventHandler(this.btnAddCustomer_Click);
            // 
            // commandLinkEdit
            // 
            this.commandLinkEdit.Command = this.commandEdit;
            // 
            // commandEdit
            // 
            this.commandEdit.Name = "commandEdit";
            this.commandEdit.Shortcut = System.Windows.Forms.Shortcut.CtrlE;
            this.commandEdit.ShortcutText = "Ctrl+E";
            this.commandEdit.Text = "Sửa";
            this.commandEdit.Virgin = false;
            this.commandEdit.Click += new C1.Win.C1Command.ClickEventHandler(this.btnEditCustomer_Click);
            // 
            // commandLinkDelete
            // 
            this.commandLinkDelete.Command = this.commandDelete;
            // 
            // commandDelete
            // 
            this.commandDelete.Name = "commandDelete";
            this.commandDelete.Shortcut = System.Windows.Forms.Shortcut.CtrlD;
            this.commandDelete.ShortcutText = "Ctrl+D";
            this.commandDelete.Text = "Xóa";
            this.commandDelete.Virgin = false;
            this.commandDelete.Click += new C1.Win.C1Command.ClickEventHandler(this.btnDeleteCustomer_Click);
            // 
            // commandMenuActions
            // 
            this.commandMenuActions.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
                this.commandLinkAdd,
                this.commandLinkEdit,
                this.commandLinkDelete});
            this.commandMenuActions.Name = "commandMenuActions";
            this.commandMenuActions.ShortcutText = "";
            this.commandMenuActions.Text = "Actions";
            this.commandMenuActions.Virgin = false;
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
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.contextMenuStripActions);
            this.c1CommandHolder1.Commands.Add(this.commandAdd);
            this.c1CommandHolder1.Commands.Add(this.commandEdit);
            this.c1CommandHolder1.Commands.Add(this.commandDelete);
            this.c1CommandHolder1.Commands.Add(this.commandMenuActions);
            this.c1CommandHolder1.Owner = this;
            // 
            // KhachHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Name = "KhachHangForm";
            this.Text = "KhachHangForm";
            this.Load += new System.EventHandler(this.KhachHangForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}

