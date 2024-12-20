using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using CuaHangWindowForm.Models;
using C1.Win.C1Input;

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
            string customerID = txtCustomerID.Text.Trim().ToUpper();
            string customerName = txtCustomerName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(customerID) || string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Tất cả các mục đều bắt buộc, không được để trống");
                return;
            }

            if (customerID.Contains(" "))
            {
                MessageBox.Show("Mã khách hàng không được chứa khoảng trắng");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải chứa đúng 10 chữ số");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    if (_isUpdate)
                    {
                        string sql = "UPDATE Customer SET CustomerName = @CustomerName, Phone = @Phone WHERE CustomerID = @CustomerID";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@CustomerID", customerID);
                            command.Parameters.AddWithValue("@CustomerName", customerName);
                            command.Parameters.AddWithValue("@Phone", phone);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Chỉnh sửa khách hàng thành công");
                    }
                    else
                    {
                        string sql = "INSERT INTO Customer (CustomerID, CustomerName, Phone) VALUES (@CustomerID, @CustomerName, @Phone)";
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@CustomerID", customerID);
                            command.Parameters.AddWithValue("@CustomerName", customerName);
                            command.Parameters.AddWithValue("@Phone", phone);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Khách hàng đã được thêm thành công");
                    }
                }
                this.Close();
            }
            catch (SqlException ex) when (ex.Number == 2627)
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

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            txtCustomerID.Text = txtCustomerID.Text.ToUpper().Replace(" ", "");
            txtCustomerID.SelectionStart = txtCustomerID.Text.Length;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as C1TextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar) && textBox.Text.Length >= 10)
            {
                e.Handled = true;
            }
        }
    }
}
