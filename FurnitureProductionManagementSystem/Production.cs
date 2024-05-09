using System.Data;
using System.Data.SqlClient;

namespace FurnitureProductionManagementSystem
{
    public partial class Production : Form
    {
        Functions Con;
        int Key = 0;

        public Production()
        {
            InitializeComponent();
            Con = new Functions();
            ShowProduction();
            GetProducts();
        }

        private void ShowProduction()
        {
            string Query = "select * from Production";
            pDGV.DataSource = Con.GetData(Query);
        }

        private void SaveProduction()
        {
            if (pcb.SelectedIndex == -1 || qptbl.Text == "" || qptbl.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    int productId = Convert.ToInt32(pcb.SelectedValue);
                    int quantityProduced = Convert.ToInt32(qptbl.Text);
                    DateTime productionDate = dtp.Value.Date;
                    string Query = "insert into Production (ProductID, QuantityProduced, ProductionDate) values({0}, {1}, '{2}')";
                    Query = string.Format(Query, productId, quantityProduced, productionDate.ToString("yyyy-MM-dd")); // Formatting date as yyyy-MM-dd

                    Con.SetData(Query);

                    MessageBox.Show("Production Added");
                    Reset();
                    ShowProduction();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateProduction()
        {
            if (pcb.SelectedIndex == -1 || qptbl.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string productName = pcb.SelectedValue.ToString();
                    string quantityProduct = qptbl.Text;
                    DateTime dateTime = dtp.Value.Date;
                    string Query = "update Production set ProductId = '{0}', QuantityProduced='{1}', ProductionDate='{2}' where ProductionID={3}";
                    Query = string.Format(Query, productName, quantityProduct, dateTime, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Production Updated");
                    Reset();
                    ShowProduction();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteProduction()
        {
            if (Key == 0)
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Query = "delete from Production where ProductionID = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Production Deleted");
                    Reset();
                    ShowProduction();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private DataTable AllSearch()
        {
            string query = "SELECT * FROM Production ";
            query += "WHERE ProductionID LIKE '%' + @param + '%' ";
            query += "OR ProductID LIKE '%' + @param + '%' ";
            query += "OR QuantityProduced LIKE '%' + @param + '%' ";
            query += "OR ProductionDate LIKE '%' + @param + '%' ";
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
            pcb.Text = "";
            qptbl.Text = "";
        }

        private void RestoreFilter()
        {
            stbl.Text = "";
            ShowProduction();
        }

        private void GetProducts()
        {
            if (pcb.SelectedItem == "")
            {
                pcb.Text = "Products is empty!";
            }
            else
            {
                SqlConnection cn = new SqlConnection("Data Source=ACER;Initial Catalog=FurnitureProductionDB;Integrated Security=True;Encrypt=False");
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from Products", cn);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("ProductId", typeof(int));
                dt.Load(rdr);
                pcb.DisplayMember = "ProductName";
                pcb.ValueMember = "ProductId";
                pcb.DataSource = dt;
                cn.Close();
            }
        }

        private void pDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pcb.SelectedValue = pDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            qptbl.Text = pDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (pcb.SelectedIndex == -1 || qptbl.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(pDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            SaveProduction();
        }

        private void ubtn_Click(object sender, EventArgs e)
        {
            UpdateProduction();
        }

        private void dbtn_Click(object sender, EventArgs e)
        {
            DeleteProduction();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void restorebtn_Click(object sender, EventArgs e)
        {
            RestoreFilter();
        }

        private void stbl_TextChanged(object sender, EventArgs e)
        {
            AllSearch();
        }
    }
}