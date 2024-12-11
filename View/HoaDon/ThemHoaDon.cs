using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using CuaHangWindowForm.Models;
using System.Drawing;

namespace CuaHangWindowForm.View.HoaDon
{
    public partial class ThemHoaDon : Form
    {
        private readonly string _connectionString;
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

            // Set default date to the current date
            dtpInvoiceDate.Value = DateTime.Now;
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

                cmbCustomerID.Items.Clear();
                foreach (var customer in _customers)
                {
                    cmbCustomerID.Items.Add(customer);
                }
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
            dataGridViewInvoiceDetails.Cols.Count = 7;

            dataGridViewInvoiceDetails.Cols[1].Name = "ProductID";
            dataGridViewInvoiceDetails.Cols[1].Caption = "Mã sản phẩm";
            dataGridViewInvoiceDetails.Cols[1].DataType = typeof(string);
            dataGridViewInvoiceDetails.Cols[1].AllowEditing = false;

            dataGridViewInvoiceDetails.Cols[2].Name = "ProductName";
            dataGridViewInvoiceDetails.Cols[2].Caption = "Sản phẩm";
            dataGridViewInvoiceDetails.Cols[2].DataType = typeof(string);
            dataGridViewInvoiceDetails.Cols[2].ComboList = string.Join("|", _products.Select(p => p.ProductName));
            dataGridViewInvoiceDetails.Cols[2].AllowEditing = true;

            dataGridViewInvoiceDetails.Cols[3].Name = "Quantity";
            dataGridViewInvoiceDetails.Cols[3].Caption = "Số lượng";
            dataGridViewInvoiceDetails.Cols[3].DataType = typeof(int);
            dataGridViewInvoiceDetails.Cols[3].AllowEditing = true;

            dataGridViewInvoiceDetails.Cols[4].Name = "UnitPrice";
            dataGridViewInvoiceDetails.Cols[4].Caption = "Đơn giá";
            dataGridViewInvoiceDetails.Cols[4].DataType = typeof(decimal);
            dataGridViewInvoiceDetails.Cols[4].AllowEditing = false;

            dataGridViewInvoiceDetails.Cols[5].Name = "TotalPrice";
            dataGridViewInvoiceDetails.Cols[5].Caption = "Tổng giá";
            dataGridViewInvoiceDetails.Cols[5].DataType = typeof(decimal);
            dataGridViewInvoiceDetails.Cols[5].AllowEditing = false;

            dataGridViewInvoiceDetails.Cols[6].Name = "Delete";
            dataGridViewInvoiceDetails.Cols[6].Caption = "Xóa";
            dataGridViewInvoiceDetails.Cols[6].ShowButtons = ShowButtonsEnum.Always;


            // Set the row count to the fixed row count to ensure the grid is empty
            dataGridViewInvoiceDetails.Rows.Count = dataGridViewInvoiceDetails.Rows.Fixed;

            // Event handlers
            dataGridViewInvoiceDetails.CellButtonClick += C1flexGrid1_CellButtonClick;
            dataGridViewInvoiceDetails.AfterEdit += DataGridViewInvoiceDetails_AfterEdit;
            dataGridViewInvoiceDetails.CellButtonClick += DataGridViewInvoiceDetails_CellButtonClick;
            dataGridViewInvoiceDetails.StartEdit += DataGridViewInvoiceDetails_StartEdit;
        }

        private void DataGridViewInvoiceDetails_CellButtonClick(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (e.Col == dataGridViewInvoiceDetails.Cols["Delete"].Index && e.Row >= 0)
            {
                dataGridViewInvoiceDetails.Rows.Remove(e.Row); // Remove the row from the grid

                UpdateTotalPrice(); // Recalculate total price after deletion
            }
        }

        private void DataGridViewInvoiceDetails_StartEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (e.Row >= dataGridViewInvoiceDetails.Rows.Fixed)
            {
                var productID = dataGridViewInvoiceDetails[e.Row, "ProductID"]?.ToString();
                if (!string.IsNullOrEmpty(productID))
                {
                    if (e.Col == dataGridViewInvoiceDetails.Cols["ProductName"].Index || e.Col == dataGridViewInvoiceDetails.Cols["Quantity"].Index)
                    {
                        dataGridViewInvoiceDetails.Cols["ProductName"].AllowEditing = true;
                        dataGridViewInvoiceDetails.Cols["Quantity"].AllowEditing = true;
                    }
                }
                else
                {
                    dataGridViewInvoiceDetails.Cols["ProductName"].AllowEditing = false;
                    dataGridViewInvoiceDetails.Cols["Quantity"].AllowEditing = false;
                }
            }
        }

        private void txtInvoiceID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevent space character
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtInvoiceID_TextChanged(object sender, EventArgs e)
        {
            // Convert text to uppercase
            txtInvoiceID.Text = txtInvoiceID.Text.ToUpper();
            txtInvoiceID.SelectionStart = txtInvoiceID.Text.Length; // Move cursor to the end
        }


        private void DataGridViewInvoiceDetails_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (e.Col == dataGridViewInvoiceDetails.Cols["ProductName"].Index && e.Row >= 0)
            {
                var row = dataGridViewInvoiceDetails.Rows[e.Row];
                var selectedProductName = row["ProductName"].ToString();
                var selectedProduct = _products.FirstOrDefault(p => p.ProductName == selectedProductName);

                if (selectedProduct != null)
                {
                    row["ProductID"] = selectedProduct.ProductID;
                    row["UnitPrice"] = selectedProduct.Price;
                    if (int.TryParse(row["Quantity"]?.ToString(), out int quantity))
                    {
                        var totalPrice = quantity * selectedProduct.Price;
                        row["TotalPrice"] = totalPrice;
                        UpdateTotalPrice();
                    }
                }
            }
            else if (e.Col == dataGridViewInvoiceDetails.Cols["Quantity"].Index && e.Row >= 0)
            {
                var row = dataGridViewInvoiceDetails.Rows[e.Row];
                var quantity = Convert.ToInt32(row["Quantity"]);
                var unitPrice = Convert.ToDecimal(row["UnitPrice"]);
                var totalPrice = quantity * unitPrice;
                row["TotalPrice"] = totalPrice;
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

                if (product == null)
                {
                    MessageBox.Show("Sản phẩm không hợp lệ.");
                    return;
                }

                // Check for duplicate product
                for (int i = dataGridViewInvoiceDetails.Rows.Fixed; i < dataGridViewInvoiceDetails.Rows.Count; i++)
                {
                    var row = dataGridViewInvoiceDetails.Rows[i];
                    if (row["ProductID"] != null && row["ProductID"].ToString() == product.ProductID)
                    {
                        MessageBox.Show("Sản phẩm đã tồn tại trong hóa đơn.");
                        return;
                    }
                }
                // Add a new row at the bottom
                var newRow = dataGridViewInvoiceDetails.Rows.Insert(1);

                // Set the values for each cell in the new row
                dataGridViewInvoiceDetails.SetData(newRow.Index, "ProductID", product.ProductID);
                dataGridViewInvoiceDetails.SetData(newRow.Index, "ProductName", product.ProductName);
                dataGridViewInvoiceDetails.SetData(newRow.Index, "Quantity", quantity);
                dataGridViewInvoiceDetails.SetData(newRow.Index, "UnitPrice", product.Price);
                dataGridViewInvoiceDetails.SetData(newRow.Index, "TotalPrice", quantity * product.Price);

                UpdateTotalPrice();
            }
        }

        private void C1flexGrid1_CellButtonClick(object sender, RowColEventArgs e)
        {
            // Perform any operation like the following code marks the current row by changing its color
            if (dataGridViewInvoiceDetails.Rows[e.Row].StyleDisplay.BackColor == Color.FromName("Window"))
            {
                dataGridViewInvoiceDetails.Rows[e.Row].StyleNew.BackColor = Color.Green;
                dataGridViewInvoiceDetails.Rows[e.Row].StyleNew.ForeColor = Color.White;
            }
            else
            {
                dataGridViewInvoiceDetails.Rows[e.Row].StyleNew.BackColor = Color.FromName("Window");
                dataGridViewInvoiceDetails.Rows[e.Row].StyleNew.ForeColor = Color.FromName("WindowText");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string invoiceID = txtInvoiceID.Text.Trim();
            if (!(cmbCustomerID.SelectedItem is ThongTinKhachHang selectedCustomer))
            {
                MessageBox.Show("Vui lòng chọn khách hàng hợp lệ.");
                return;
            }

            string customerID = selectedCustomer.CustomerID;
            DateTime invoiceDate = (DateTime)dtpInvoiceDate.Value;

            if (string.IsNullOrEmpty(invoiceID))
            {
                MessageBox.Show("Mã hóa đơn không được để trống.");
                return;
            }

            // Check for existing invoice
            if (InvoiceExists(invoiceID))
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại.");
                return;
            }

            var invoiceDetails = new List<ThongTinChiTietHoaDon>();
            for (int i = dataGridViewInvoiceDetails.Rows.Fixed; i < dataGridViewInvoiceDetails.Rows.Count; i++)
            {
                var row = dataGridViewInvoiceDetails.Rows[i];

                // Skip empty rows
                if (row["ProductID"] == null || row["Quantity"] == null || row["TotalPrice"] == null)
                {
                    continue;
                }

                // Validate row data
                var productID = row["ProductID"].ToString();
                if (!int.TryParse(row["Quantity"].ToString(), out int quantity))
                {
                    MessageBox.Show("Số lượng sản phẩm không hợp lệ.");
                    return;
                }
                if (!decimal.TryParse(row["TotalPrice"].ToString(), out decimal totalPrice))
                {
                    MessageBox.Show("Tổng giá sản phẩm không hợp lệ.");
                    return;
                }

                var detail = new ThongTinChiTietHoaDon
                {
                    InvoiceID = invoiceID,
                    ProductID = productID,
                    Quantity = quantity,
                    TotalPrice = totalPrice
                };
                invoiceDetails.Add(detail);
            }

            if (invoiceDetails.Count == 0)
            {
                MessageBox.Show("Hóa đơn phải có ít nhất một sản phẩm.");
                return;
            }

            decimal totalInvoicePrice = invoiceDetails.Sum(d => d.TotalPrice);

            // Save invoice and details to the database
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
                            string insertInvoiceSql = @"INSERT INTO Invoice (InvoiceID, CustomerID, InvoiceDate, TotalPrice) 
                                                        VALUES (@InvoiceID, @CustomerID, @InvoiceDate, @TotalPrice)";
                            using (var command = new SqlCommand(insertInvoiceSql, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@InvoiceID", invoiceID);
                                command.Parameters.AddWithValue("@CustomerID", customerID);
                                command.Parameters.AddWithValue("@InvoiceDate", invoiceDate);
                                command.Parameters.AddWithValue("@TotalPrice", totalInvoicePrice);
                                command.ExecuteNonQuery();
                            }

                            // Insert details
                            string insertDetailSql = @"INSERT INTO InvoiceDetails (InvoiceID, ProductID, Quantity, TotalPrice) 
                                                       VALUES (@InvoiceID, @ProductID, @Quantity, @TotalPrice)";
                            foreach (var detail in invoiceDetails)
                            {
                                using (var command = new SqlCommand(insertDetailSql, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@InvoiceID", detail.InvoiceID);
                                    command.Parameters.AddWithValue("@ProductID", detail.ProductID);
                                    command.Parameters.AddWithValue("@Quantity", detail.Quantity);
                                    command.Parameters.AddWithValue("@TotalPrice", detail.TotalPrice);
                                    command.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                            MessageBox.Show("Hóa đơn đã được lưu thành công.");
                            ClearForm();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
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
            for (int i = dataGridViewInvoiceDetails.Rows.Fixed; i < dataGridViewInvoiceDetails.Rows.Count; i++)
            {
                var row = dataGridViewInvoiceDetails.Rows[i];
                total += Convert.ToDecimal(row["TotalPrice"]);
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
            dataGridViewInvoiceDetails.Rows.Count = dataGridViewInvoiceDetails.Rows.Fixed;
            txtTotalPrice.Text = "0.00";
        }

        private void dataGridViewInvoiceDetails_Click(object sender, EventArgs e)
        {

        }
    }
}