using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using CuaHangWindowForm.Models;

namespace CuaHangWindowForm.View.HoaDon
{
    public partial class ThemHoaDon : Form
    {
        private string _connectionString;
        private List<ThongTinKhachHang> _customers;
        private List<ThongTinSanPham> _products;

        public ThemHoaDon()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["CuaHangWindowForm.Properties.Settings.ConnectionString"].ConnectionString;
        }

        private void ThemHoaDon_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadProducts();
            InitializeInvoiceDetailsGrid();
        }

        private void LoadCustomers()
        {
            _customers = new List<ThongTinKhachHang>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT CustomerID, CustomerName FROM Customer";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var customer = new ThongTinKhachHang
                        {
                            CustomerID = reader["CustomerID"].ToString(),
                            CustomerName = reader["CustomerName"].ToString()
                        };
                        _customers.Add(customer);
                    }
                }

                cmbCustomerID.DataSource = _customers;
                cmbCustomerID.DisplayMember = "CustomerName";
                cmbCustomerID.ValueMember = "CustomerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void LoadProducts()
        {
            _products = new List<ThongTinSanPham>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT ProductID, ProductName, Price FROM Product";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var product = new ThongTinSanPham
                        {
                            ProductID = reader["ProductID"].ToString(),
                            ProductName = reader["ProductName"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"])
                        };
                        _products.Add(product);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void InitializeInvoiceDetailsGrid()
        {
            dataGridViewInvoiceDetails.Columns.Add("ProductID", "Mã sản phẩm");

            var productNameColumn = new DataGridViewComboBoxColumn
            {
                Name = "ProductName",
                HeaderText = "Tên sản phẩm",
                DataSource = _products,
                DisplayMember = "ProductName",
                ValueMember = "ProductName",
                DataPropertyName = "ProductName"
            };
            dataGridViewInvoiceDetails.Columns.Add(productNameColumn);

            var quantityColumn = new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                HeaderText = "Số lượng",
                ReadOnly = false
            };
            dataGridViewInvoiceDetails.Columns.Add(quantityColumn);
            dataGridViewInvoiceDetails.Columns.Add("UnitPrice", "Đơn giá");
            dataGridViewInvoiceDetails.Columns.Add("TotalPrice", "Tổng giá");

            var deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Xóa",
                Text = "Xóa",
                UseColumnTextForButtonValue = true
            };
            dataGridViewInvoiceDetails.Columns.Add(deleteButtonColumn);

            dataGridViewInvoiceDetails.CellEndEdit += DataGridViewInvoiceDetails_CellEndEdit;
            dataGridViewInvoiceDetails.CellValueChanged += DataGridViewInvoiceDetails_CellValueChanged;
            dataGridViewInvoiceDetails.EditingControlShowing += DataGridViewInvoiceDetails_EditingControlShowing;
            dataGridViewInvoiceDetails.CellContentClick += DataGridViewInvoiceDetails_CellContentClick;
        }

        private void DataGridViewInvoiceDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewInvoiceDetails.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                dataGridViewInvoiceDetails.Rows.RemoveAt(e.RowIndex);
                UpdateTotalPrice();
            }
        }



        private void DataGridViewInvoiceDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridViewInvoiceDetails.CurrentCell.ColumnIndex == dataGridViewInvoiceDetails.Columns["ProductName"].Index)
            {
                ComboBox comboBox = e.Control as ComboBox;
                if (comboBox != null)
                {
                    comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                    comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
                }
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            if (comboBox != null && comboBox.SelectedItem != null)
            {
                var selectedProductName = comboBox.GetItemText(comboBox.SelectedItem);
                var row = dataGridViewInvoiceDetails.CurrentRow;
                var selectedProduct = _products.FirstOrDefault(p => p.ProductName == selectedProductName);

                if (selectedProduct != null)
                {
                    row.Cells["ProductID"].Value = selectedProduct.ProductID;
                    row.Cells["UnitPrice"].Value = selectedProduct.Price;
                    if (int.TryParse(row.Cells["Quantity"].Value?.ToString(), out int quantity))
                    {
                        var totalPrice = quantity * selectedProduct.Price;
                        row.Cells["TotalPrice"].Value = totalPrice;
                        UpdateTotalPrice();
                    }
                }
            }
        }

        private void DataGridViewInvoiceDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewInvoiceDetails.Columns["ProductName"].Index && e.RowIndex >= 0)
            {
                var row = dataGridViewInvoiceDetails.Rows[e.RowIndex];
                var selectedProductName = row.Cells["ProductName"].Value?.ToString();
                var selectedProduct = _products.FirstOrDefault(p => p.ProductName == selectedProductName);

                if (selectedProduct != null)
                {
                    row.Cells["ProductID"].Value = selectedProduct.ProductID;
                    row.Cells["UnitPrice"].Value = selectedProduct.Price;
                    if (int.TryParse(row.Cells["Quantity"].Value?.ToString(), out int quantity))
                    {
                        var totalPrice = quantity * selectedProduct.Price;
                        row.Cells["TotalPrice"].Value = totalPrice;
                        UpdateTotalPrice();
                    }
                }
            }
        }

        private void DataGridViewInvoiceDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewInvoiceDetails.Columns["Quantity"].Index && e.RowIndex >= 0)
            {
                var row = dataGridViewInvoiceDetails.Rows[e.RowIndex];
                var quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                var unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                var totalPrice = quantity * unitPrice;
                row.Cells["TotalPrice"].Value = totalPrice;
                UpdateTotalPrice();
            }
        }

        private void btnAddDetailRow_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm(_products);
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                var product = addProductForm.SelectedProduct;
                var quantity = addProductForm.Quantity;
                var unitPrice = product.Price;
                var totalPrice = quantity * unitPrice;

                dataGridViewInvoiceDetails.Rows.Add(product.ProductID, product.ProductName, quantity, unitPrice, totalPrice);
                UpdateTotalPrice();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string invoiceID = txtInvoiceID.Text.Trim().ToUpper().Replace(" ", "");
            string customerID = cmbCustomerID.SelectedValue.ToString();
            DateTime invoiceDate = dtpInvoiceDate.Value;

            if (string.IsNullOrEmpty(invoiceID) || string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("Tất cả các mục đều bắt buộc, không được để trống");
                return;
            }

            if (InvoiceExists(invoiceID))
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại, xin vui lòng nhập mã mới");
                return;
            }

            List<ThongTinChiTietHoaDon> invoiceDetails = new List<ThongTinChiTietHoaDon>();
            foreach (DataGridViewRow row in dataGridViewInvoiceDetails.Rows)
            {
                if (row.IsNewRow) continue;

                var detail = new ThongTinChiTietHoaDon
                {
                    InvoiceID = invoiceID,
                    ProductID = row.Cells["ProductID"].Value.ToString(),
                    Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                    TotalPrice = Convert.ToDecimal(row.Cells["TotalPrice"].Value)
                };
                invoiceDetails.Add(detail);
            }

            if (invoiceDetails.Count == 0)
            {
                MessageBox.Show("Bạn phải thêm ít nhất một sản phẩm.");
                return;
            }

            decimal totalPrice;
            if (!decimal.TryParse(txtTotalPrice.Text, out totalPrice) || totalPrice == 0)
            {
                MessageBox.Show("Tổng giá phải lớn hơn 0.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Insert invoice
                            string insertInvoiceSql = "INSERT INTO Invoice (InvoiceID, CustomerID, InvoiceDate, TotalPrice) VALUES (@InvoiceID, @CustomerID, @InvoiceDate, @TotalPrice)";
                            using (SqlCommand command = new SqlCommand(insertInvoiceSql, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@InvoiceID", invoiceID);
                                command.Parameters.AddWithValue("@CustomerID", customerID);
                                command.Parameters.AddWithValue("@InvoiceDate", invoiceDate);
                                command.Parameters.AddWithValue("@TotalPrice", totalPrice);
                                command.ExecuteNonQuery();
                            }

                            // Insert invoice details
                            foreach (var detail in invoiceDetails)
                            {
                                string insertDetailSql = "INSERT INTO InvoiceDetails (InvoiceID, ProductID, Quantity, TotalPrice) VALUES (@InvoiceID, @ProductID, @Quantity, @TotalPrice)";
                                using (SqlCommand command = new SqlCommand(insertDetailSql, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@InvoiceID", detail.InvoiceID);
                                    command.Parameters.AddWithValue("@ProductID", detail.ProductID);
                                    command.Parameters.AddWithValue("@Quantity", detail.Quantity);
                                    command.Parameters.AddWithValue("@TotalPrice", detail.TotalPrice);
                                    command.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                            MessageBox.Show("Hóa đơn đã được thêm thành công");
                            ClearForm();
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }


        private bool InvoiceExists(string invoiceID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT COUNT(*) FROM Invoice WHERE InvoiceID = @InvoiceID";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@InvoiceID", invoiceID);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void UpdateTotalPrice()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridViewInvoiceDetails.Rows)
            {
                if (row.IsNewRow) continue;
                total += Convert.ToDecimal(row.Cells["TotalPrice"].Value);
            }
            txtTotalPrice.Text = total.ToString("0.00");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            txtInvoiceID.Clear();
            cmbCustomerID.SelectedIndex = -1;
            dtpInvoiceDate.Value = DateTime.Now;
            dataGridViewInvoiceDetails.Rows.Clear();
            txtTotalPrice.Text = "0.00";
        }
    }
}
