using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CuaHangWindowForm.Models;

namespace CuaHangWindowForm.View.HoaDon
{
    public partial class AddProductForm : Form
    {
        private List<ThongTinSanPham> _products;
        public ThongTinSanPham SelectedProduct { get; private set; }
        public int Quantity { get; private set; }

        public AddProductForm(List<ThongTinSanPham> products)
        {
            InitializeComponent();
            _products = products;
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            cmbProduct.DataSource = _products;
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductID";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedProduct = (ThongTinSanPham)cmbProduct.SelectedItem;
            Quantity = (int)nudQuantity.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
