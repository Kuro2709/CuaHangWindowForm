using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using CuaHangWindowForm.Models;
using CuaHangWindowForm.View.KhachHang;

namespace WindowsFormsApp
{
    public partial class KhachHangForm : Form
    {
        private List<ThongTinKhachHang> _customers;
        private string _connectionString;

        public KhachHangForm()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["CuaHangWindowForm.Properties.Settings.ConnectionString"].ConnectionString;
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            _customers = new List<ThongTinKhachHang>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT CustomerID, CustomerName, Phone FROM Customer";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var customer = new ThongTinKhachHang
                        {
                            CustomerID = reader["CustomerID"].ToString(),
                            CustomerName = reader["CustomerName"].ToString(),
                            Phone = reader["Phone"].ToString()
                        };
                        _customers.Add(customer);
                    }
                }

                dataGridViewCustomers.DataSource = null;
                dataGridViewCustomers.DataSource = _customers;
                dataGridViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // Navigate to the Add Customer form
            var addCustomerForm = new ThemKhachHang();
            addCustomerForm.ShowDialog();
            LoadCustomers(); // Reload customers after adding
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                var selectedCustomer = (ThongTinKhachHang)dataGridViewCustomers.SelectedRows[0].DataBoundItem;
                var editCustomerForm = new ChinhSuaKhachHang(selectedCustomer);
                editCustomerForm.ShowDialog();
                LoadCustomers(); // Reload customers after editing
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để chỉnh sửa.");
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridViewCustomers.SelectedRows.Count > 0)
            {
                var selectedCustomer = (ThongTinKhachHang)dataGridViewCustomers.SelectedRows[0].DataBoundItem;

                var result = MessageBox.Show("Bạn có muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(_connectionString))
                        {
                            connection.Open();
                            string checkQuery = "SELECT COUNT(*) FROM Invoice WHERE CustomerID = @CustomerID";
                            SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                            checkCommand.Parameters.AddWithValue("@CustomerID", selectedCustomer.CustomerID);
                            int count = (int)checkCommand.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show("Không thể xóa khách hàng này vì khách hàng được liên kết với một hoặc nhiều hóa đơn.");
                                return;
                            }

                            string query = "DELETE FROM Customer WHERE CustomerID = @CustomerID";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@CustomerID", selectedCustomer.CustomerID);
                            command.ExecuteNonQuery();
                        }

                        LoadCustomers(); // Reload customers after deleting
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.");
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            contextMenuStripActions.Show(btnAction, new System.Drawing.Point(0, btnAction.Height));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form to go back to the home page
        }

        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(KhachHangForm_KeyDown);
        }

        private void KhachHangForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                btnAddCustomer_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                btnEditCustomer_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                btnDeleteCustomer_Click(sender, e);
            }
        }
    }
}
