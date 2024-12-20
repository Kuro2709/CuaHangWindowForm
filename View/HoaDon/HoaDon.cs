using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using CuaHangWindowForm.Models;
using C1.Win.C1FlexGrid;

namespace CuaHangWindowForm.View.HoaDon
{
    public partial class HoaDonForm : Form
    {
        private List<ThongTinHoaDon> _invoices;
        private readonly string _connectionString;

        public HoaDonForm()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["CuaHangWindowForm.Properties.Settings.ConnectionString"].ConnectionString;
            LoadInvoices();
        }

        private void LoadInvoices()
        {
            _invoices = new List<ThongTinHoaDon>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT i.InvoiceID, i.CustomerID, c.CustomerName, i.TotalPrice FROM Invoice i JOIN Customer c ON i.CustomerID = c.CustomerID";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var invoice = new ThongTinHoaDon
                        {
                            InvoiceID = reader["InvoiceID"].ToString(),
                            CustomerID = reader["CustomerID"].ToString(),
                            Customer = new ThongTinKhachHang
                            {
                                CustomerID = reader["CustomerID"].ToString(),
                                CustomerName = reader["CustomerName"].ToString()
                            },
                            TotalPrice = Convert.ToDecimal(reader["TotalPrice"])
                        };
                        _invoices.Add(invoice);
                    }
                }

                dataGridViewInvoices.DataSource = _invoices;
                dataGridViewInvoices.Cols.Count = 4; // Set the number of columns to 4

                dataGridViewInvoices.Cols[1].Caption = "Mã hóa đơn";
                dataGridViewInvoices.Cols[1].Name = "InvoiceID";
                dataGridViewInvoices.Cols[1].DataType = typeof(string);

                dataGridViewInvoices.Cols[2].Caption = "Khách hàng";
                dataGridViewInvoices.Cols[2].Name = "CustomerName";
                dataGridViewInvoices.Cols[2].DataType = typeof(string);

                dataGridViewInvoices.Cols[3].Caption = "Tổng giá";
                dataGridViewInvoices.Cols[3].Name = "TotalPrice";
                dataGridViewInvoices.Cols[3].DataType = typeof(decimal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            // Navigate to the Add/Edit Invoice form
            var addInvoiceForm = new ChinhSuaHoaDon();
            addInvoiceForm.ShowDialog();
            LoadInvoices(); // Reload invoices after adding
        }

        private void btnEditInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoices.RowSel > 0)
            {
                var selectedInvoice = (ThongTinHoaDon)dataGridViewInvoices.Rows[dataGridViewInvoices.RowSel].DataSource;
                var editInvoiceForm = new ChinhSuaHoaDon(selectedInvoice);
                editInvoiceForm.ShowDialog();
                LoadInvoices(); // Reload invoices after editing
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để chỉnh sửa.");
            }
        }

        private void btnViewInvoiceDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoices.RowSel > 0)
            {
                var selectedInvoice = (ThongTinHoaDon)dataGridViewInvoices.Rows[dataGridViewInvoices.RowSel].DataSource;
                var viewInvoiceDetailsForm = new ChiTietHoaDon(selectedInvoice);
                viewInvoiceDetailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xem chi tiết.");
            }
        }

        private void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoices.RowSel > 0)
            {
                var selectedInvoice = (ThongTinHoaDon)dataGridViewInvoices.Rows[dataGridViewInvoices.RowSel].DataSource;

                var result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(_connectionString))
                        {
                            connection.Open();
                            using (SqlTransaction transaction = connection.BeginTransaction())
                            {
                                try
                                {
                                    // Delete related InvoiceDetails first
                                    string deleteDetailsQuery = "DELETE FROM InvoiceDetails WHERE InvoiceID = @InvoiceID";
                                    using (SqlCommand deleteDetailsCommand = new SqlCommand(deleteDetailsQuery, connection, transaction))
                                    {
                                        deleteDetailsCommand.Parameters.AddWithValue("@InvoiceID", selectedInvoice.InvoiceID);
                                        deleteDetailsCommand.ExecuteNonQuery();
                                    }

                                    // Delete the Invoice
                                    string deleteInvoiceQuery = "DELETE FROM Invoice WHERE InvoiceID = @InvoiceID";
                                    using (SqlCommand deleteInvoiceCommand = new SqlCommand(deleteInvoiceQuery, connection, transaction))
                                    {
                                        deleteInvoiceCommand.Parameters.AddWithValue("@InvoiceID", selectedInvoice.InvoiceID);
                                        deleteInvoiceCommand.ExecuteNonQuery();
                                    }

                                    transaction.Commit();
                                }
                                catch (Exception)
                                {
                                    transaction.Rollback();
                                    throw;
                                }
                            }
                        }

                        LoadInvoices(); // Reload invoices after deleting
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xóa.");
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

        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(HoaDonForm_KeyDown);
        }

        private void HoaDonForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                btnAddInvoice_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                btnEditInvoice_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                btnViewInvoiceDetails_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                btnDeleteInvoice_Click(sender, e);
            }
        }
    }
}


