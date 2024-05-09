using System.Data;
using System.Data.SqlClient;

namespace FurnitureProductionManagementSystem
{
    public partial class Warehouse : Form
    {
        Functions Con;
        int Key = 0;

        public Warehouse()
        {
            InitializeComponent();
            Con = new Functions();
            ShowWarehouses();
        }

        private void ShowWarehouses()
        {
            string Query = "select * from Warehouses";
            wDGV.DataSource = Con.GetData(Query);
        }

        private void SaveWarehouse()
        {
            if (ltbl.Text == "" || ctbl.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string location = ltbl.Text;
                    string capacity = ctbl.Text;
                    string Query = "insert into Warehouses (Location, Capacity) values('{0}', '{1}')";
                    Query = string.Format(Query, location, capacity);
                    Con.SetData(Query);
                    MessageBox.Show("Warehouse Added");
                    Reset();
                    ShowWarehouses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateWarehouse()
        {
            if (ltbl.Text == "" || ctbl.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string location = ltbl.Text;
                    string capacity = ctbl.Text;
                    string Query = "update Warehouses set Location = '{0}', Capacity='{1}' where WarehouseID={2}";
                    Query = string.Format(Query, location, capacity, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Warehouse Updated");
                    Reset();
                    ShowWarehouses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteWarehouse()
        {
            if (Key == 0)
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Query = "delete from Warehouses where WarehouseID = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Warehouse Deleted");
                    Reset();
                    ShowWarehouses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private DataTable AllSearch()
        {
            string query = "SELECT * FROM Warehouses ";
            query += "WHERE WarehouseID LIKE '%' + @param + '%' ";
            query += "OR Location LIKE '%' + @param + '%' ";
            query += "OR Capacity LIKE '%' + @param + '%' ";
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
                        wDGV.DataSource = dt;
                        return dt;
                    }
                }
            }
        }

        private void Reset()
        {
            ltbl.Text = "";
            ctbl.Text = "";
        }

        private void RestoreFilter()
        {
            stbl.Text = "";
            ShowWarehouses();
        }

        private void wDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ltbl.Text = wDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            ctbl.Text = wDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (ltbl.Text == "" || ctbl.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(wDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            SaveWarehouse();
        }

        private void ubtn_Click(object sender, EventArgs e)
        {
            UpdateWarehouse();
        }

        private void dbtn_Click(object sender, EventArgs e)
        {
            DeleteWarehouse();
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