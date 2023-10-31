using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS_Inventory
{
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }
        // SqlConnection object to manage the database connection
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jslts\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        // Method to populate the DataGridView with data from the CategoryTb1 table
        void populate()
        {
            try
            {
                Con.Open();
                string myQuery = "SELECT * FROM CategoryTb1";

                // Use SqlDataAdapter to fill a DataTable with data from the database
                using (SqlDataAdapter da = new SqlDataAdapter(myQuery, Con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Set the DataSource of the DataGridView to the populated DataTable
                    CategoriesGV.DataSource = dt;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Event handler for the "Add Category" button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                // Use parameterized query for insert operation
                SqlCommand cmd = new SqlCommand("INSERT INTO CategoryTb1 VALUES( @CatId, @CatName)", Con);
                cmd.Parameters.AddWithValue("@CatId", CatIdTb.Text);
                cmd.Parameters.AddWithValue("@CatName", CatNameTb.Text);

                // Execute the query and show a success message
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
                populate(); // Refresh the data after insertion
            }
        }

        // Event handler for the "Delete Category" button
        private void button3_Click(object sender, EventArgs e)
        {
            // Check if the Category Id is provided
            if (CatIdTb.Text == "")
            {
                MessageBox.Show("Enter the Category Id");
            }

            else
            {
                try
                {
                    Con.Open();
                    // Use parameterized query for the delete operation
                    string myquery = "DELETE FROM CategoryTb1 WHERE CatId = @CatId";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.Parameters.AddWithValue("@CatId", CatIdTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully deleted");
                    Console.WriteLine("Connection opened");
                    populate(); // Execute the query and show a success message
                }
                catch (Exception ex)
                {
                    // Execute the query and show a success message
                    MessageBox.Show("Failed to delete customer. Please try again.");
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                    Console.WriteLine("Connection closed");
                }
            }
            }

        // Event handler for the "Update Category" button
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();

                // Check if CatId is blank
                if (string.IsNullOrEmpty(CatIdTb.Text))
                {
                    MessageBox.Show("Enter the Category Id");
                    return; // Exit the method if Category Id is not provided
                }
                // Use parameterized query for the update operation
                string query = "UPDATE CategoryTb1 SET CatName=@CatName WHERE CatId=@CatId";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@CatId", CatIdTb.Text);
                cmd.Parameters.AddWithValue("@CatName", CatNameTb.Text);
                // Execute the query and show a success message
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Category Successfully Updated");
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

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            populate(); // Populate the DataGridView when the form loads
        }

        // Event handler for the DataGridView cell content click event
        private void CategoriesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Populate the TextBoxes with the selected row data when a cell is clicked
            if (CategoriesGV.SelectedRows.Count > 0)
            {
                CatIdTb.Text = CategoriesGV.SelectedRows[0].Cells[0].Value.ToString();
                CatNameTb.Text = CategoriesGV.SelectedRows[0].Cells[1].Value.ToString();
              

            }
        }
        // Event handler for the "Back" button
        private void button4_Click(object sender, EventArgs e)
        {
            // Create an instance of the HomeForm, show it, and hide the current form
            HomeForm home =new HomeForm();
            home.Show();
            this.Hide();
        }

        // Event handler for the "Exit" label
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }



