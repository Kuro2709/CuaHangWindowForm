using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using CuaHangWindowForm.Models;

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

                dataGridViewInvoices.DataSource = null;
                dataGridViewInvoices.DataSource = _invoices;
                dataGridViewInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            // Open the ChinhSuaHoaDon form in add mode
            var addInvoiceForm = new ThemVaChinhSuaHoaDon();
            addInvoiceForm.ShowDialog();
            LoadInvoices(); // Reload invoices after adding
        }

        private void btnEditInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoices.SelectedRows.Count > 0)
            {
                var selectedInvoice = (ThongTinHoaDon)dataGridViewInvoices.SelectedRows[0].DataBoundItem;
                var editInvoiceForm = new ThemVaChinhSuaHoaDon(selectedInvoice);
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
            if (dataGridViewInvoices.SelectedRows.Count > 0)
            {
                var selectedInvoice = (ThongTinHoaDon)dataGridViewInvoices.SelectedRows[0].DataBoundItem;
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
            if (dataGridViewInvoices.SelectedRows.Count > 0)
            {
                var selectedInvoice = (ThongTinHoaDon)dataGridViewInvoices.SelectedRows[0].DataBoundItem;

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
            dataGridViewInvoices.CellFormatting += DataGridViewInvoices_CellFormatting;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(HoaDonForm_KeyDown);
        }

        private void DataGridViewInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewInvoices.Columns[e.ColumnIndex].Name == "Customer" && e.RowIndex >= 0)
            {
                var invoice = dataGridViewInvoices.Rows[e.RowIndex].DataBoundItem as ThongTinHoaDon;
                if (invoice != null)
                {
                    e.Value = invoice.Customer.CustomerName;
                }
            }
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
