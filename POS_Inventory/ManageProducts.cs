using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS_Inventory
{
    public partial class ManageProducts : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jslts\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                string myQuery = "SELECT * FROM ProductTb1";

                using (SqlDataAdapter da = new SqlDataAdapter(myQuery, Con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    ProductGV.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        void filterbycategory()
        {
            try
            {
                Con.Open();

                // Assuming Searchcombo is a ComboBox control, you should use SelectedValue
                string selectedCategory = Searchcombo.SelectedValue?.ToString();

                if (!string.IsNullOrEmpty(selectedCategory))
                {
                    string myQuery = "SELECT * FROM ProductTb1 WHERE ProdCat = @ProdCat";

                    using (SqlDataAdapter da = new SqlDataAdapter(myQuery, Con))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@ProdCat", selectedCategory);

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Clear the previous data bindings
                        ProductGV.DataSource = null;

                        // Set the data source and refresh the grid
                        ProductGV.DataSource = dt;
                        ProductGV.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a category to filter.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        public ManageProducts()
        {
            InitializeComponent();
            // Call the fillcategory method in the constructor or form load
            fillcategory();
        }

        void fillcategory()
        {
            try
            {
                Con.Open();
                // Use parameters in your query to prevent SQL injection
                string query = "SELECT * FROM CategoryTb1";
                SqlCommand cmd = new SqlCommand(query, Con);

                // Use SqlDataAdapter to fill DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind data to the combo box
                CatCombo.ValueMember = "CatName"; // Assuming there is a CatName column in CategoryTb1
                CatCombo.DisplayMember = "CatName"; // Assuming there is a CatName column in CategoryTb1
                CatCombo.DataSource = dt;

                // Set the DropDownStyle to DropDownList
                CatCombo.DropDownStyle = ComboBoxStyle.DropDownList;

                // Apply the same settings to Searchcombo
                Searchcombo.ValueMember = "CatName";
                Searchcombo.DisplayMember = "CatName";
                Searchcombo.DataSource = dt;
                Searchcombo.DropDownStyle = ComboBoxStyle.DropDownList;

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                // Use parameterized query for insert operation
                string query = "INSERT INTO ProductTb1 (ProdId, ProdName, ProdQty, ProdPrice, ProdDesc, ProdCat) VALUES (@ProdId, @ProdName, @ProdQty, @ProdPrice, @ProdDesc, @ProdCat)";
                SqlCommand cmd = new SqlCommand(query, Con);

                // Assuming ProdId is an integer; adjust the SqlDbType accordingly
                cmd.Parameters.AddWithValue("@ProdId", SqlDbType.Int).Value = int.Parse(ProdIdTb.Text);

                cmd.Parameters.AddWithValue("@ProdName", ProdNameTb.Text);

                // Assuming ProdQty is an integer; adjust the SqlDbType accordingly
                cmd.Parameters.AddWithValue("@ProdQty", SqlDbType.Int).Value = int.Parse(QtyTb.Text);

                // Assuming ProdPrice is a decimal; adjust the SqlDbType accordingly
                cmd.Parameters.AddWithValue("@ProdPrice", SqlDbType.Decimal).Value = decimal.Parse(PriceTb.Text);

                cmd.Parameters.AddWithValue("@ProdDesc", DescriptionTb.Text);

                cmd.Parameters.AddWithValue("@ProdCat", CatCombo.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
                populate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProdIdTb.Text))
            {
                MessageBox.Show("Enter the Product Id");
                return; // Exit the method if Customer Id is not provided
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM ProductTb1 WHERE ProdId = @ProdId", Con))
                {
                    if (Con.State != ConnectionState.Open)
                    {
                        Con.Open();
                        Console.WriteLine("Connection opened");
                    }

                    cmd.Parameters.AddWithValue("@ProdId", ProdIdTb.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Customer Successfully deleted");
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete Id. Please try again.");
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Close();
                    Console.WriteLine("Connection closed");
                }
            }
        }

        private void ProductGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductGV.SelectedRows.Count > 0)
            {
                ProdIdTb.Text = ProductGV.SelectedRows[0].Cells[0].Value.ToString();
                ProdNameTb.Text = ProductGV.SelectedRows[0].Cells[1].Value.ToString();
                QtyTb.Text = ProductGV.SelectedRows[0].Cells[2].Value.ToString();
                PriceTb.Text = ProductGV.SelectedRows[0].Cells[3].Value.ToString();
                DescriptionTb.Text = ProductGV.SelectedRows[0].Cells[4].Value.ToString();
                CatCombo.SelectedValue = ProductGV.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                // Check if ProdId is blank
                if (string.IsNullOrEmpty(ProdIdTb.Text))
                {
                    MessageBox.Show("Enter the Product Id");
                    return; // Exit the method if Product Id is not provided
                }

                string query = "UPDATE ProductTb1 SET ProdName=@ProdName, ProdQty=@ProdQty,ProdPrice=@ProdPrice, ProdDesc=@ProdDesc, ProdCat=@ProdCat  WHERE ProdId=@ProdId";
                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.Parameters.AddWithValue("@ProdName", ProdNameTb.Text);
                cmd.Parameters.AddWithValue("@ProdQty", QtyTb.Text);
                cmd.Parameters.AddWithValue("@ProdPrice", PriceTb.Text);
                cmd.Parameters.AddWithValue("@ProdDesc", DescriptionTb.Text);
                cmd.Parameters.AddWithValue("@ProdCat", CatCombo.Text);
                cmd.Parameters.AddWithValue("@ProdId", ProdIdTb.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product Successfully Updated");
                }
                else
                {
                    MessageBox.Show("Edit not successful. No matching record found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
                populate(); // Refresh the data after update
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Searchcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
