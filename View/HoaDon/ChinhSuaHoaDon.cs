using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using CuaHangWindowForm.Models;
using C1.Win.C1FlexGrid;

namespace CuaHangWindowForm.View.HoaDon
{
    public partial class ChinhSuaHoaDon : Form
    {
        private readonly string _connectionString;
        private readonly ThongTinHoaDon _invoice;
        private List<ThongTinKhachHang> _customers;
        private List<ThongTinSanPham> _products;

        public ChinhSuaHoaDon(ThongTinHoaDon invoice)
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["CuaHangWindowForm.Properties.Settings.ConnectionString"].ConnectionString;
            _invoice = invoice;
        }

        private void ChinhSuaHoaDon_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadProducts();
            LoadInvoiceDetails();

            
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

                cmbCustomerID.SelectedItem = _customers.FirstOrDefault(c => c.CustomerID == _invoice.CustomerID);
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

        private void LoadInvoiceDetails()
        {
            txtInvoiceID.Text = _invoice.InvoiceID;
            txtInvoiceID.ReadOnly = true; // Ensure the InvoiceID is read-only
            dtpInvoiceDate.Value = _invoice.InvoiceDate;
            txtTotalPrice.Text = _invoice.TotalPrice.ToString("0.00");

            List<ThongTinChiTietHoaDon> invoiceDetails = new List<ThongTinChiTietHoaDon>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT d.InvoiceDetailID, d.ProductID, p.ProductName, d.Quantity, d.TotalPrice, p.Price AS UnitPrice FROM InvoiceDetails d JOIN Product p ON d.ProductID = p.ProductID WHERE d.InvoiceID = @InvoiceID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@InvoiceID", _invoice.InvoiceID);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var detail = new ThongTinChiTietHoaDon
                        {
                            InvoiceDetailID = Convert.ToInt32(reader["InvoiceDetailID"]),
                            ProductID = reader["ProductID"].ToString(),
                            Product = new ThongTinSanPham { ProductName = reader["ProductName"].ToString(), Price = Convert.ToDecimal(reader["UnitPrice"]) },
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            TotalPrice = Convert.ToDecimal(reader["TotalPrice"])
                        };
                        invoiceDetails.Add(detail);
                    }
                }

                InitializeInvoiceDetailsGrid();

                foreach (var detail in invoiceDetails)
                {
                    var row = dataGridViewInvoiceDetails.Rows.Insert(1);
                    row["ProductID"] = detail.ProductID;
                    row["ProductName"] = detail.Product.ProductName;
                    row["Quantity"] = detail.Quantity;
                    row["UnitPrice"] = detail.Product.Price;
                    row["TotalPrice"] = detail.TotalPrice;
                }

                // Remove empty rows after loading invoice details
                RemoveEmptyRows();
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
            dataGridViewInvoiceDetails.CellButtonClick += DataGridViewInvoiceDetails_CellButtonClick;
            dataGridViewInvoiceDetails.AfterEdit += DataGridViewInvoiceDetails_AfterEdit;
            dataGridViewInvoiceDetails.StartEdit += DataGridViewInvoiceDetails_StartEdit;
        }

        private void DataGridViewInvoiceDetails_CellButtonClick(object sender, RowColEventArgs e)
        {
            if (e.Col == dataGridViewInvoiceDetails.Cols["Delete"].Index && e.Row >= 0)
            {
                dataGridViewInvoiceDetails.Rows.Remove(e.Row); // Remove the row from the grid

                UpdateTotalPrice(); // Recalculate total price after deletion
            }
        }

        private void DataGridViewInvoiceDetails_StartEdit(object sender, RowColEventArgs e)
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
                        _previousProductName = dataGridViewInvoiceDetails[e.Row, "ProductName"]?.ToString(); // Store the previous product name
                    }
                }
                else
                {
                    dataGridViewInvoiceDetails.Cols["ProductName"].AllowEditing = false;
                    dataGridViewInvoiceDetails.Cols["Quantity"].AllowEditing = false;
                }
            }
        }

        private string _previousProductName;
        private void DataGridViewInvoiceDetails_AfterEdit(object sender, RowColEventArgs e)
        {
            if (e.Col == dataGridViewInvoiceDetails.Cols["ProductName"].Index && e.Row >= 0)
            {
                var row = dataGridViewInvoiceDetails.Rows[e.Row];
                var selectedProductName = row["ProductName"].ToString();
                var selectedProduct = _products.FirstOrDefault(p => p.ProductName == selectedProductName);

                if (selectedProduct != null)
                {
                    // Check for duplicate product
                    for (int i = dataGridViewInvoiceDetails.Rows.Fixed; i < dataGridViewInvoiceDetails.Rows.Count; i++)
                    {
                        if (i != e.Row && dataGridViewInvoiceDetails[i, "ProductID"]?.ToString() == selectedProduct.ProductID)
                        {
                            MessageBox.Show("Sản phẩm đã tồn tại trong hóa đơn.");
                            row["ProductName"] = _previousProductName; // Restore the previous product name
                            return;
                        }
                    }

                    row["ProductID"] = selectedProduct.ProductID;
                    row["UnitPrice"] = selectedProduct.Price;
                    if (int.TryParse(row["Quantity"]?.ToString(), out int quantity))
                    {
                        var totalPrice = quantity * selectedProduct.Price;
                        row["TotalPrice"] = totalPrice;
                    }
                    UpdateTotalPrice();
                }
            }
            else if (e.Col == dataGridViewInvoiceDetails.Cols["Quantity"].Index && e.Row >= 0)
            {
                var row = dataGridViewInvoiceDetails.Rows[e.Row];
                if (int.TryParse(row["Quantity"]?.ToString(), out int quantity))
                {
                    var unitPrice = Convert.ToDecimal(row["UnitPrice"]);
                    var totalPrice = quantity * unitPrice;
                    row["TotalPrice"] = totalPrice;
                    UpdateTotalPrice();
                }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            RemoveEmptyRows();

            var selectedCustomer = cmbCustomerID.SelectedItem as ThongTinKhachHang;
            if (selectedCustomer == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng.");
                return;
            }

            string customerID = selectedCustomer.CustomerID;
            DateTime invoiceDate = (DateTime)dtpInvoiceDate.Value;
            decimal totalInvoicePrice = Convert.ToDecimal(txtTotalPrice.Text);

            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("Tất cả các mục đều bắt buộc, không được để trống");
                return;
            }

            List<ThongTinChiTietHoaDon> invoiceDetails = new List<ThongTinChiTietHoaDon>();
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
                if (!int.TryParse(row["Quantity"].ToString(), out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Số lượng sản phẩm không hợp lệ.");
                    return;
                }
                if (!decimal.TryParse(row["TotalPrice"].ToString(), out decimal totalPrice) || totalPrice <= 0)
                {
                    MessageBox.Show("Tổng giá sản phẩm không hợp lệ.");
                    return;
                }

                var detail = new ThongTinChiTietHoaDon
                {
                    InvoiceID = _invoice.InvoiceID,
                    ProductID = productID,
                    Quantity = quantity,
                    TotalPrice = totalPrice
                };
                invoiceDetails.Add(detail);
            }

            if (invoiceDetails.Count == 0)
            {
                MessageBox.Show("Bạn phải thêm ít nhất một sản phẩm.");
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
                            // Update invoice
                            string updateInvoiceSql = "UPDATE Invoice SET CustomerID = @CustomerID, InvoiceDate = @InvoiceDate, TotalPrice = @TotalPrice WHERE InvoiceID = @InvoiceID";
                            using (SqlCommand command = new SqlCommand(updateInvoiceSql, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@InvoiceID", _invoice.InvoiceID);
                                command.Parameters.AddWithValue("@CustomerID", customerID);
                                command.Parameters.AddWithValue("@InvoiceDate", invoiceDate);
                                command.Parameters.AddWithValue("@TotalPrice", totalInvoicePrice);
                                command.ExecuteNonQuery();
                            }

                            // Delete existing details
                            string deleteDetailsSql = "DELETE FROM InvoiceDetails WHERE InvoiceID = @InvoiceID";
                            using (SqlCommand command = new SqlCommand(deleteDetailsSql, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@InvoiceID", _invoice.InvoiceID);
                                command.ExecuteNonQuery();
                            }

                            // Insert updated details
                            string insertDetailSql = "INSERT INTO InvoiceDetails (InvoiceID, ProductID, Quantity, TotalPrice) VALUES (@InvoiceID, @ProductID, @Quantity, @TotalPrice)";
                            foreach (var detail in invoiceDetails)
                            {
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
                            MessageBox.Show("Hóa đơn đã được cập nhật thành công");
                            this.Close();
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
                MessageBox.Show("Exception: " + ex.Message);
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

        private void RemoveEmptyRows()
        {
            foreach (var row in dataGridViewInvoiceDetails.Rows.Cast<C1.Win.C1FlexGrid.Row>().Where(r => r.IsNew || string.IsNullOrEmpty(r["ProductID"]?.ToString())).ToList())
            {
                dataGridViewInvoiceDetails.Rows.Remove(row);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
