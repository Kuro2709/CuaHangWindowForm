using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
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
            // Temporarily make the text boxes editable
            txtInvoiceID.ReadOnly = false;
            txtCustomerID.ReadOnly = false;
            txtInvoiceDate.ReadOnly = false;
            txtTotalPrice.ReadOnly = false;

            // Set the Text property
            txtInvoiceID.Text = _invoice.InvoiceID;
            txtCustomerID.Text = _invoice.CustomerID;
            txtInvoiceDate.Text = _invoice.InvoiceDate.ToString("yyyy-MM-dd");
            txtTotalPrice.Text = _invoice.TotalPrice.ToString("C");

            // Make the text boxes read-only again
            txtInvoiceID.ReadOnly = true;
            txtCustomerID.ReadOnly = true;
            txtInvoiceDate.ReadOnly = true;
            txtTotalPrice.ReadOnly = true;

            LoadInvoiceDetails();
        }

        private void LoadInvoiceDetails()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT d.InvoiceDetailID, d.ProductID, p.ProductName, d.Quantity, d.TotalPrice " +
                                   "FROM InvoiceDetails d " +
                                   "JOIN Product p ON d.ProductID = p.ProductID " +
                                   "WHERE d.InvoiceID = @InvoiceID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@InvoiceID", _invoice.InvoiceID);
                    SqlDataReader reader = command.ExecuteReader();

                    var invoiceDetails = new List<dynamic>();

                    while (reader.Read())
                    {
                        invoiceDetails.Add(new
                        {
                            InvoiceDetailID = Convert.ToInt32(reader["InvoiceDetailID"]),
                            ProductID = reader["ProductID"].ToString(),
                            ProductName = reader["ProductName"].ToString(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            TotalPrice = Convert.ToDecimal(reader["TotalPrice"])
                        });
                    }

                    flexGridInvoiceDetails.DataSource = invoiceDetails;

                    // Adjust column visibility and captions
                    flexGridInvoiceDetails.Cols["InvoiceDetailID"].Visible = false;
                    flexGridInvoiceDetails.Cols["ProductID"].Caption = "Mã sản phẩm";
                    flexGridInvoiceDetails.Cols["ProductName"].Caption = "Tên sản phẩm";
                    flexGridInvoiceDetails.Cols["Quantity"].Caption = "Số lượng";
                    flexGridInvoiceDetails.Cols["TotalPrice"].Caption = "Tổng tiền";

                    // Ensure the ProductID column is visible
                    flexGridInvoiceDetails.Cols["ProductID"].Visible = true;

                    // Rearrange columns
                    flexGridInvoiceDetails.Cols["ProductID"].Move(1);
                    flexGridInvoiceDetails.Cols["ProductName"].Move(2);

                    // Make all columns read-only
                    foreach (Column column in flexGridInvoiceDetails.Cols)
                    {
                        column.AllowEditing = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flexGridInvoiceDetails_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
        {
            if (flexGridInvoiceDetails.Cols[e.Col].Name == "Product" && e.Row >= 0)
            {
                var detail = flexGridInvoiceDetails.Rows[e.Row].DataSource as ThongTinChiTietHoaDon;
                if (detail != null)
                {
                    e.Text = detail.Product.ProductName;
                }
            }
        }

        private void txtInvoiceDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

