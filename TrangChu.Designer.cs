namespace WindowsFormsApp
{
    partial class TrangChu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnManageProducts;
        private System.Windows.Forms.Button btnManageCustomers;
        private System.Windows.Forms.Button btnManageInvoices;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblInvoices;

        private void InitializeComponent()
        {
            this.btnManageProducts = new System.Windows.Forms.Button();
            this.btnManageCustomers = new System.Windows.Forms.Button();
            this.btnManageInvoices = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblInvoices = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnManageProducts
            // 
            this.btnManageProducts.Location = new System.Drawing.Point(50, 150);
            this.btnManageProducts.Name = "btnManageProducts";
            this.btnManageProducts.Size = new System.Drawing.Size(200, 30);
            this.btnManageProducts.TabIndex = 0;
            this.btnManageProducts.Text = "Quản lý sản phẩm";
            this.btnManageProducts.UseVisualStyleBackColor = true;
            this.btnManageProducts.Click += new System.EventHandler(this.btnManageProducts_Click);
            // 
            
            // btnManageCustomers
            // 
            this.btnManageCustomers.Location = new System.Drawing.Point(300, 150);
            this.btnManageCustomers.Name = "btnManageCustomers";
            this.btnManageCustomers.Size = new System.Drawing.Size(200, 30);
            this.btnManageCustomers.TabIndex = 1;
            this.btnManageCustomers.Text = "Quản lý khách hàng";
            this.btnManageCustomers.UseVisualStyleBackColor = true;
            this.btnManageCustomers.Click += new System.EventHandler(this.btnManageCustomers_Click);
            // 
            
            // btnManageInvoices
            // 
            this.btnManageInvoices.Location = new System.Drawing.Point(550, 150);
            this.btnManageInvoices.Name = "btnManageInvoices";
            this.btnManageInvoices.Size = new System.Drawing.Size(200, 30);
            this.btnManageInvoices.TabIndex = 2;
            this.btnManageInvoices.Text = "Quản lý hóa đơn";
            this.btnManageInvoices.UseVisualStyleBackColor = true;
            this.btnManageInvoices.Click += new System.EventHandler(this.btnManageInvoices_Click);
            // 
            
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(50, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(447, 31);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Chào mừng bạn đến với cửa hàng";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(50, 120);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(68, 16);
            this.lblProducts.TabIndex = 4;
            this.lblProducts.Text = "Sản phẩm";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(300, 120);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(77, 16);
            this.lblCustomers.TabIndex = 5;
            this.lblCustomers.Text = "Khách hàng";
            // 
            // lblInvoices
            // 
            this.lblInvoices.AutoSize = true;
            this.lblInvoices.Location = new System.Drawing.Point(550, 120);
            this.lblInvoices.Name = "lblInvoices";
            this.lblInvoices.Size = new System.Drawing.Size(59, 16);
            this.lblInvoices.TabIndex = 6;
            this.lblInvoices.Text = "Hóa đơn";
            // 
            // TrangChu
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInvoices);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnManageInvoices);
            this.Controls.Add(this.btnManageCustomers);
            this.Controls.Add(this.btnManageProducts);
            this.Name = "TrangChu";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.TrangChu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
