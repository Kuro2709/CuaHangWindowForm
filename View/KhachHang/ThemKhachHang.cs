﻿using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CuaHangWindowForm.View.KhachHang
{
    public partial class ThemKhachHang : Form
    {
        private string _connectionString;

        public ThemKhachHang()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["CuaHangWindowForm.Properties.Settings.ConnectionString"].ConnectionString;
        }

        private void ThemKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            txtCustomerID.Text = txtCustomerID.Text.ToUpper().Replace(" ", "");
            txtCustomerID.SelectionStart = txtCustomerID.Text.Length; // Move cursor to the end
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

        private void btnSubmit_Click(object sender, EventArgs e)
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

            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^[\d\+\-\(\) ]{10,15}$"))
            {
                MessageBox.Show("Số điện thoại phải chứa đúng 15 chữ số");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Customer (CustomerID, CustomerName, Phone) VALUES (@CustomerID, @CustomerName, @Phone)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Khách hàng đã được thêm thành công");
                ClearForm();
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

        private void ClearForm()
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtPhone.Clear();
        }

        private void lblCustomerName_Click(object sender, EventArgs e)
        {

        }

        private void lblCustomerID_Click(object sender, EventArgs e)
        {

        }
    }
}

