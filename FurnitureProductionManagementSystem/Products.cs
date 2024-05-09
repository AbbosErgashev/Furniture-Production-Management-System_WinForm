using System.Data;
using System.Data.SqlClient;

namespace FurnitureProductionManagementSystem
{
    public partial class Product : Form
    {
        Functions Con;
        int Key = 0;

        public Product()
        {
            InitializeComponent();
            Con = new Functions();
            ShowProducts();
        }

        private void ShowProducts()
        {
            string Query = "select * from Products";
            pDGV.DataSource = Con.GetData(Query);
        }

        private void SaveProduct()
        {
            if (pntbl.Text == "" || ptbl.Text == "" || qtbl.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string productName = pntbl.Text;
                    string price = ptbl.Text;
                    string quantity = qtbl.Text;
                    string Query = "insert into Products (ProductName, Price, Quantity) values('{0}', '{1}', '{2}')";
                    Query = string.Format(Query, productName, price, quantity);
                    Con.SetData(Query);
                    MessageBox.Show("Product Added");
                    Reset();
                    ShowProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateProduct()
        {
            if (pntbl.Text == "" || ptbl.Text == "" || qtbl.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string productName = pntbl.Text;
                    string price = ptbl.Text;
                    string quantity = qtbl.Text;
                    string Query = "update Products set ProductName = '{0}', Price='{1}', Quantity='{2}' where ProductId={3}";
                    Query = string.Format(Query, productName, price, quantity, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Product Updated");
                    Reset();
                    ShowProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteProduct()
        {
            if (Key == 0)
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string Query = "delete from Products where ProductId = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Product Deleted");
                    Reset();
                    ShowProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private DataTable AllSearch()
        {
            string query = "SELECT * FROM Products ";
            query += "WHERE ProductID LIKE '%' + @param + '%' ";
            query += "OR ProductName LIKE '%' + @param + '%' ";
            query += "OR Price LIKE '%' + @param + '%' ";
            query += "OR Quantity LIKE '%' + @param + '%' ";
            string con = "Data Source=ACER;Initial Catalog=FurnitureProductionDB;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(con))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@param", stbl.Text);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        pDGV.DataSource = dt;
                        return dt;
                    }
                }
            }
        }

        private void Reset()
        {
            pntbl.Text = "";
            ptbl.Text = "";
            qtbl.Text = "";
        }

        private void pDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pntbl.Text = pDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            ptbl.Text = pDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            qtbl.Text = pDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (pntbl.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(pDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void RestoreFilter()
        {
            stbl.Text = "";
            ShowProducts();
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            SaveProduct();
        }

        private void ubtn_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void dbtn_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void restorebtn_Click(object sender, EventArgs e)
        {
            RestoreFilter();
            ShowProducts();
        }

        private void stbl_TextChanged(object sender, EventArgs e)
        {
            AllSearch();
        }
    }
}