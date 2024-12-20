using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using CuaHangWindowForm.Models;

namespace CuaHangWindowForm.View.KhachHang
{
    public partial class ThemVaChinhSuaKhachHang : Form
    {
        private string _connectionString;
        private ThongTinKhachHang _customer;
        private bool _isUpdate;

        public ThemVaChinhSuaKhachHang(ThongTinKhachHang customer = null)
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["CuaHangWindowForm.Properties.Settings.ConnectionString"].ConnectionString;
            _customer = customer;
            _isUpdate = customer != null;
        }

        private void ChinhSuaKhachHang_Load(object sender, EventArgs e)
        {
            if (_isUpdate)
            {
                txtCustomerID.Text = _customer.CustomerID;
                txtCustomerName.Text = _customer.CustomerName;
                txtPhone.Text = _customer.Phone;
                txtCustomerID.ReadOnly = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string customerID = txtCustomerID.Text.Trim();
            string customerName = txtCustomerName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("All the fields are required");
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
                        sql = "UPDATE Customer SET CustomerName = @CustomerName, Phone = @Phone WHERE CustomerID = @CustomerID";
                    }
                    else
                    {
                        sql = "INSERT INTO Customer (CustomerID, CustomerName, Phone) VALUES (@CustomerID, @CustomerName, @Phone)";
                    }

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(_isUpdate ? "Chỉnh sửa khách hàng thành công" : "Khách hàng đã được thêm thành công");
                this.Close();
            }
            catch (SqlException ex) when (ex.Number == 2627) // SQL error code for primary key violation
            {
                MessageBox.Show("Mã khách hàng đã tồn tại, xin vui lòng nhập mã mới");
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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '(' && e.KeyChar != ')')
            {
                e.Handled = true;
            }

            // Limit the length to 15 digits
            if (char.IsDigit(e.KeyChar) && txtPhone.Text.Length >= 15)
            {
                e.Handled = true;
            }
        }
    }
}

