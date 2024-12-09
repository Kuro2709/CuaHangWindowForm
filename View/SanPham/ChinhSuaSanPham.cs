using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using CuaHangWindowForm.Models;
using C1.Win.C1Input;

namespace CuaHangWindowForm.View.SanPham
{
    public partial class ChinhSuaSanPham : Form
    {
        private ThongTinSanPham _productInfo;

        public ChinhSuaSanPham(ThongTinSanPham productInfo)
        {
            InitializeComponent();
            _productInfo = productInfo;
        }

        private void ChinhSuaSanPham_Load(object sender, EventArgs e)
        {
            txtProductID.Text = _productInfo.ProductID;
            txtProductName.Text = _productInfo.ProductName;
            numPrice.Value = _productInfo.Price;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text) || Convert.ToDecimal(numPrice.Value) <= 0)
            {
                lblMessage.Text = "Tất cả các mục không được để trống";
                return;
            }

            try
            {
                var connectionStringSettings = System.Configuration.ConfigurationManager.ConnectionStrings["CuaHangWindowForm.Properties.Settings.ConnectionString"];
                if (connectionStringSettings == null)
                {
                    lblMessage.Text = "Connection string 'CuaHangWindowForm.Properties.Settings.ConnectionString' not found.";
                    return;
                }

                string connectionString = connectionStringSettings.ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Product SET ProductName = @ProductName, Price = @Price WHERE ProductID = @ProductID";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", _productInfo.ProductID);
                        command.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                        command.Parameters.AddWithValue("@Price", Convert.ToDecimal(numPrice.Value));
                        command.ExecuteNonQuery();
                    }
                }
                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Sản phẩm đã được cập nhật thành công";

                // Delay for a short period to show the success message
                var timer = new Timer();
                timer.Interval = 1000; // 2 seconds
                timer.Tick += (s, args) =>
                {
                    timer.Stop();
                    this.Close(); // Close the current form to return to the product list view
                };
                timer.Start();
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

        }
    }
}

