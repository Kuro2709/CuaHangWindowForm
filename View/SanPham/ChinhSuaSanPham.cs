using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using C1.Win.C1Input;

namespace CuaHangWindowForm.View.SanPham
{
    public partial class ChinhSuaSanPham : Form
    {
        private string _connectionString;
        private ThongTinSanPham _productInfo;
        private bool _isUpdate;

        public ChinhSuaSanPham(ThongTinSanPham productInfo = null)
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["CuaHangWindowForm.Properties.Settings.ConnectionString"].ConnectionString;
            _productInfo = productInfo;
            _isUpdate = productInfo != null;
        }

        private void ChinhSuaSanPham_Load(object sender, EventArgs e)
        {
            if (_isUpdate)
            {
                txtProductID.Text = _productInfo.ProductID;
                txtProductName.Text = _productInfo.ProductName;
                numPrice.Value = _productInfo.Price;
                txtProductID.ReadOnly = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string productID = txtProductID.Text.Trim().ToUpper();
            string productName = txtProductName.Text.Trim();
            decimal price = (decimal)numPrice.Value;

            if (string.IsNullOrEmpty(productID) || string.IsNullOrEmpty(productName) || price <= 0)
            {
                MessageBox.Show("Tất cả các mục đều bắt buộc, không được để trống");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    if (_isUpdate)
                    {
                        string sql = "UPDATE Product SET ProductName = @ProductName, Price = @Price WHERE ProductID = @ProductID";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@ProductID", productID);
                            command.Parameters.AddWithValue("@ProductName", productName);
                            command.Parameters.AddWithValue("@Price", price);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Sản phẩm đã được cập nhật thành công");
                    }
                    else
                    {
                        string sql = "INSERT INTO Product (ProductID, ProductName, Price) VALUES (@ProductID, @ProductName, @Price)";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@ProductID", productID);
                            command.Parameters.AddWithValue("@ProductName", productName);
                            command.Parameters.AddWithValue("@Price", price);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Sản phẩm đã được thêm thành công");
                    }
                }
                this.Close();
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại, xin vui lòng nhập mã mới");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            txtProductID.Text = txtProductID.Text.ToUpper().Replace(" ", "");
            txtProductID.SelectionStart = txtProductID.Text.Length;
        }

        private void numPrice_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

