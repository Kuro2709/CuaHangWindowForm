using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using CuaHangWindowForm.Models;
using System.Configuration;

namespace CuaHangWindowForm.View.SanPham
{
    public partial class ThemVaChinhSuaSanPham : Form
    {
        private ThongTinSanPham _productInfo;
        private bool _isUpdate;
        private string _connectionString;

        public ThemVaChinhSuaSanPham(ThongTinSanPham productInfo = null)
        {
            InitializeComponent();
            _productInfo = productInfo;
            _isUpdate = productInfo != null;
            _connectionString = ConfigurationManager.ConnectionStrings["CuaHangWindowForm.Properties.Settings.ConnectionString"].ConnectionString;
        }

        private void ChinhSuaSanPham_Load(object sender, EventArgs e)
        {
            if (_isUpdate)
            {
                LoadProductInfo();
                txtProductID.ReadOnly = true; // Make ProductID read-only in edit mode
            }
        }

        private void LoadProductInfo()
        {
            txtProductID.Text = _productInfo.ProductID;
            txtProductName.Text = _productInfo.ProductName;
            numPrice.Value = _productInfo.Price;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string productID = txtProductID.Text.Trim().ToUpper();
            string productName = txtProductName.Text.Trim();
            decimal price = numPrice.Value;

            if (string.IsNullOrEmpty(productID) || string.IsNullOrEmpty(productName) || price <= 0)
            {
                lblMessage.Text = "Tất cả các mục không được để trống";
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql;
                    if (_isUpdate)
                    {
                        sql = "UPDATE Product SET ProductName = @ProductName, Price = @Price WHERE ProductID = @ProductID";
                    }
                    else
                    {
                        sql = "INSERT INTO Product (ProductID, ProductName, Price) VALUES (@ProductID, @ProductName, @Price)";
                    }

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productID);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@Price", price);
                        command.ExecuteNonQuery();
                    }
                }

                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = _isUpdate ? "Sản phẩm đã được cập nhật thành công" : "Sản phẩm đã được thêm thành công";

                // Delay for a short period to show the success message
                var timer = new Timer();
                timer.Interval = 1000; // 1 second
                timer.Tick += (s, args) =>
                {
                    timer.Stop();
                    this.Close(); // Close the current form to return to the product list view
                };
                timer.Start();
            }
            catch (SqlException ex) when (ex.Number == 2627) // SQL error code for primary key violation
            {
                lblMessage.Text = "Mã sản phẩm đã tồn tại, xin vui lòng nhập mã mới";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Exception: " + ex.Message;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numPrice_ValueChanged(object sender, EventArgs e)
        {
            // Handle price value change if needed
        }
    }
}
