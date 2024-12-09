using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using C1.Win.C1Input;

namespace CuaHangWindowForm.View.SanPham
{
    public partial class ThemSanPham : Form
    {
        private string _connectionString;

        public ThemSanPham()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["CuaHangWindowForm.Properties.Settings.ConnectionString"].ConnectionString;
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            txtProductID.Text = txtProductID.Text.ToUpper().Replace(" ", "");
            txtProductID.SelectionStart = txtProductID.Text.Length; // Move cursor to the end
        }

        private void ThemSanPham_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string productID = txtProductID.Text.Trim().ToUpper();
            string productName = txtProductName.Text.Trim();
            string priceText = txtPrice.Text.Trim();

            if (string.IsNullOrEmpty(productID) || string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(priceText))
            {
                MessageBox.Show("Tất cả các mục đều bắt buộc, không được để trống");
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Giá phải là một số hợp lệ");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Product (ProductID, ProductName, Price) VALUES (@ProductID, @ProductName, @Price)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productID);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@Price", price);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Sản phẩm đã được thêm thành công");
                ClearForm();
            }
            catch (SqlException ex) when (ex.Number == 2627) // SQL error code for primary key violation
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

        private void ClearForm()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
        }
    }
}
