using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq; // Add this using directive

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
            cmbProduct.Items.Clear();
            foreach (var product in _products)
            {
                cmbProduct.Items.Add(product);
            }
            cmbProduct.SelectedItem = _products.FirstOrDefault();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedProduct = (ThongTinSanPham)cmbProduct.SelectedItem;
            Quantity = Convert.ToInt32(nudQuantity.Value);
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
