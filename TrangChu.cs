using System;
using System.Windows.Forms;
using CuaHangWindowForm.View.HoaDon;

namespace WindowsFormsApp
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            // Navigate to the Products management form
            var productsForm = new SanPhamForm();
            productsForm.Show();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            // Navigate to the Customers management form
            var customersForm = new KhachHangForm();
            customersForm.Show();
        }

        private void btnManageInvoices_Click(object sender, EventArgs e)
        {
            // Navigate to the Invoices management form
            var invoicesForm = new HoaDonForm();
            invoicesForm.Show();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            // Add any initialization code here
        }
    }
}

