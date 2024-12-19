using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using CuaHangWindowForm.Models;

namespace CuaHangWindowForm.View.HoaDon
{
    public partial class ChiTietHoaDon : Form
    {
        private string _connectionString;
        private ThongTinHoaDon _invoice;

        public ChiTietHoaDon(ThongTinHoaDon invoice)
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["CuaHangWindowForm.Properties.Settings.ConnectionString"].ConnectionString;
            _invoice = invoice;
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            txtInvoiceID.Text = _invoice.InvoiceID;
            txtCustomerID.Text = _invoice.CustomerID;
            txtInvoiceDate.Text = _invoice.InvoiceDate.ToString("yyyy-MM-dd");
            txtTotalPrice.Text = _invoice.TotalPrice.ToString("C");

            LoadInvoiceDetails();
        }

        private void LoadInvoiceDetails()
        {
            List<ThongTinChiTietHoaDon> invoiceDetails = new List<ThongTinChiTietHoaDon>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT d.InvoiceDetailID, d.ProductID, p.ProductName, d.Quantity, d.TotalPrice FROM InvoiceDetails d JOIN Product p ON d.ProductID = p.ProductID WHERE d.InvoiceID = @InvoiceID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@InvoiceID", _invoice.InvoiceID);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var detail = new ThongTinChiTietHoaDon
                        {
                            InvoiceDetailID = Convert.ToInt32(reader["InvoiceDetailID"]),
                            ProductID = reader["ProductID"].ToString(),
                            Product = new ThongTinSanPham { ProductName = reader["ProductName"].ToString() },
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            TotalPrice = Convert.ToDecimal(reader["TotalPrice"])
                        };
                        invoiceDetails.Add(detail);
                    }
                }

                dataGridViewInvoiceDetails.DataSource = null;
                dataGridViewInvoiceDetails.DataSource = invoiceDetails;
                dataGridViewInvoiceDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Remove unwanted columns
                dataGridViewInvoiceDetails.Columns["InvoiceDetailID"].Visible = false;
                dataGridViewInvoiceDetails.Columns["InvoiceID"].Visible = false;

                // Rename columns to Vietnamese
                dataGridViewInvoiceDetails.Columns["ProductID"].HeaderText = "Mã sản phẩm";
                dataGridViewInvoiceDetails.Columns["Product"].HeaderText = "Sản phẩm";
                dataGridViewInvoiceDetails.Columns["Quantity"].HeaderText = "Số lượng";
                dataGridViewInvoiceDetails.Columns["TotalPrice"].HeaderText = "Tổng tiền";

                // Swap ProductID and Product column positions
                dataGridViewInvoiceDetails.Columns["ProductID"].DisplayIndex = 0;
                dataGridViewInvoiceDetails.Columns["Product"].DisplayIndex = 1;

                // Make all columns read-only
                foreach (DataGridViewColumn column in dataGridViewInvoiceDetails.Columns)
                {
                    column.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewInvoiceDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewInvoiceDetails.Columns[e.ColumnIndex].Name == "Product" && e.RowIndex >= 0)
            {
                var detail = dataGridViewInvoiceDetails.Rows[e.RowIndex].DataBoundItem as ThongTinChiTietHoaDon;
                if (detail != null)
                {
                    e.Value = detail.Product.ProductName;
                }
            }
        }
    }
}

