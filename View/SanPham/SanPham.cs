using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using CuaHangWindowForm.View.SanPham;
using C1.Win.C1FlexGrid;

namespace WindowsFormsApp
{
    public partial class SanPhamForm : Form
    {
        private List<ThongTinSanPham> _products;
        private string _connectionString;

        public SanPhamForm()
        {
            InitializeComponent();
            _connectionString = ConfigurationManager.ConnectionStrings["CuaHangWindowForm.Properties.Settings.ConnectionString"].ConnectionString;
            LoadProducts();
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

                c1FlexGridProducts.DataSource = null;
                c1FlexGridProducts.DataSource = _products;

                // Rename columns
                c1FlexGridProducts.Cols["ProductID"].Caption = "Mã sản phẩm";
                c1FlexGridProducts.Cols["ProductName"].Caption = "Sản phẩm";
                c1FlexGridProducts.Cols["Price"].Caption = "Đơn giá";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Navigate to the Add/Edit Product form
            var addProductForm = new ChinhSuaSanPham();
            addProductForm.ShowDialog();
            LoadProducts(); // Reload products after adding
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (c1FlexGridProducts.RowSel > 0)
            {
                var selectedProduct = (ThongTinSanPham)c1FlexGridProducts.Rows[c1FlexGridProducts.RowSel].DataSource;
                var editProductForm = new ChinhSuaSanPham(selectedProduct);
                editProductForm.ShowDialog();
                LoadProducts(); // Reload products after editing
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để chỉnh sửa.");
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (c1FlexGridProducts.RowSel > 0)
            {
                var selectedProduct = (ThongTinSanPham)c1FlexGridProducts.Rows[c1FlexGridProducts.RowSel].DataSource;

                var result = MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(_connectionString))
                        {
                            connection.Open();
                            string checkQuery = "SELECT COUNT(*) FROM InvoiceDetails WHERE ProductID = @ProductID";
                            SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                            checkCommand.Parameters.AddWithValue("@ProductID", selectedProduct.ProductID);
                            int count = (int)checkCommand.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show("Không thể xóa sản phẩm này vì sản phẩm được liên kết với một hoặc nhiều hóa đơn.");
                                return;
                            }

                            string query = "DELETE FROM Product WHERE ProductID = @ProductID";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@ProductID", selectedProduct.ProductID);
                            command.ExecuteNonQuery();
                        }

                        LoadProducts(); // Reload products after deleting
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
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

        private void SanPhamForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(SanPhamForm_KeyDown);
        }

        private void SanPhamForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                btnAddProduct_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                btnEditProduct_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                btnDeleteProduct_Click(sender, e);
            }
        }

        private void c1FlexGridProducts_CellEndEdit(object sender, RowColEventArgs e)
        {
            if (e.Col == c1FlexGridProducts.Cols["ProductName"].Index)
            {
                var cell = c1FlexGridProducts[e.Row, e.Col];
                c1FlexGridProducts[e.Row, e.Col] = cell.ToString().ToUpper().Replace(" ", "");
            }
        }
    }
}
