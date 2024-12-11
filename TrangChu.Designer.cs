namespace WindowsFormsApp
{
    partial class TrangChu
    {
        private System.ComponentModel.IContainer components = null;
        private C1.Win.C1Input.C1Button btnManageProducts;
        private C1.Win.C1Input.C1Button btnManageCustomers;
        private C1.Win.C1Input.C1Button btnManageInvoices;
        private C1.Win.C1Input.C1Label lblWelcome;
        private C1.Win.C1Input.C1Label lblProducts;
        private C1.Win.C1Input.C1Label lblCustomers;
        private C1.Win.C1Input.C1Label lblInvoices;

        private void InitializeComponent()
        {
            this.btnManageProducts = new C1.Win.C1Input.C1Button();
            this.btnManageCustomers = new C1.Win.C1Input.C1Button();
            this.btnManageInvoices = new C1.Win.C1Input.C1Button();
            this.lblWelcome = new C1.Win.C1Input.C1Label();
            this.lblProducts = new C1.Win.C1Input.C1Label();
            this.lblCustomers = new C1.Win.C1Input.C1Label();
            this.lblInvoices = new C1.Win.C1Input.C1Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnManageProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnManageCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnManageInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblWelcome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInvoices)).BeginInit();
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
            this.btnManageProducts.UseVisualStyleForeColor = true;
            this.btnManageProducts.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnManageProducts.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
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
            this.btnManageCustomers.UseVisualStyleForeColor = true;
            this.btnManageCustomers.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnManageCustomers.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
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
            this.btnManageInvoices.UseVisualStyleForeColor = true;
            this.btnManageInvoices.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnManageInvoices.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue;
            this.btnManageInvoices.Click += new System.EventHandler(this.btnManageInvoices_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(50, 50);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(447, 31);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Tag = null;
            this.lblWelcome.Text = "Chào mừng bạn đến với cửa hàng";
            this.lblWelcome.TextDetached = true;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblProducts.Location = new System.Drawing.Point(50, 120);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(68, 16);
            this.lblProducts.TabIndex = 4;
            this.lblProducts.Tag = null;
            this.lblProducts.Text = "Sản phẩm";
            this.lblProducts.TextDetached = true;
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCustomers.Location = new System.Drawing.Point(300, 120);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(77, 16);
            this.lblCustomers.TabIndex = 5;
            this.lblCustomers.Tag = null;
            this.lblCustomers.Text = "Khách hàng";
            this.lblCustomers.TextDetached = true;
            // 
            // lblInvoices
            // 
            this.lblInvoices.AutoSize = true;
            this.lblInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInvoices.Location = new System.Drawing.Point(550, 120);
            this.lblInvoices.Name = "lblInvoices";
            this.lblInvoices.Size = new System.Drawing.Size(59, 16);
            this.lblInvoices.TabIndex = 6;
            this.lblInvoices.Tag = null;
            this.lblInvoices.Text = "Hóa đơn";
            this.lblInvoices.TextDetached = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.btnManageProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnManageCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnManageInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblWelcome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

