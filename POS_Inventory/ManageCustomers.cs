using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS_Inventory
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }
        // SqlConnection object to manage the database connection
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jslts\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()  // Method to populate the DataGridView with data from the CustomerTb1 table
        {
            try
            {
                Con.Open();
                string myQuery = "SELECT * FROM CustomerTb1";

                // Use SqlDataAdapter to fill a DataTable with data from the database
                using (SqlDataAdapter da = new SqlDataAdapter(myQuery, Con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Set the DataSource of the DataGridView to the populated DataTable
                    CustomersGV.DataSource = dt;
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

        // Event handler for the "Exit" label
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        // Event handler for the "Add Customer" button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                // Use parameterized query for insert operation
                SqlCommand cmd = new SqlCommand("INSERT INTO CustomerTb1 VALUES(@CustId, @CustomerName, @CustomerPhone)", Con);
                cmd.Parameters.AddWithValue("@CustId", Customerid.Text);
                cmd.Parameters.AddWithValue("@CustomerName", CustomernameTb.Text);
                cmd.Parameters.AddWithValue("@CustomerPhone", CustomerPhoneTb.Text);

                // Execute the query and show a success message
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added");
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


        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (CustomersGV.SelectedCells.Count > 0)
            {
                int selectedRowIndex = CustomersGV.SelectedCells[0].RowIndex;

                // Get the values from the selected row
                Customerid.Text = CustomersGV.Rows[selectedRowIndex].Cells[0].Value.ToString();
                CustomernameTb.Text = CustomersGV.Rows[selectedRowIndex].Cells[1].Value.ToString();
                CustomerPhoneTb.Text = CustomersGV.Rows[selectedRowIndex].Cells[2].Value.ToString();



                // Check if Customerid.Text is not empty or null
                if (!string.IsNullOrEmpty(Customerid.Text))
                {
                    try
                    {
                        Con.Open();

                        // Use SqlDataAdapter to retrieve additional information about the selected customer
                        SqlDataAdapter sda = new SqlDataAdapter("SELECT Count(*) FROM OrdersTb1 WHERE CustId =" + Customerid.Text, Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        OrderLabel.Text = dt.Rows[0][0].ToString();

                        SqlDataAdapter sda1 = new SqlDataAdapter("SELECT Sum(TotalAmt) FROM OrdersTb1 WHERE CustId =" + Customerid.Text, Con);
                        DataTable dt1 = new DataTable();
                        sda1.Fill(dt1);
                        AmountLabel.Text = dt1.Rows[0][0].ToString();

                        SqlDataAdapter sda2 = new SqlDataAdapter("SELECT Max(OrderDate) FROM OrdersTb1 WHERE CustId =" + Customerid.Text, Con);
                        DataTable dt2 = new DataTable();
                        sda2.Fill(dt2);
                        DateLabel.Text = dt2.Rows[0][0].ToString();


                       
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
                else
                {
                    MessageBox.Show("Customer ID is empty or null.");
                }
            }
        }

        // Event handler for the form load event
        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populate(); // Populate the DataGridView when the form loads
        }

        // Event handler for the "Delete Customer" button
        private void button3_Click(object sender, EventArgs e)
        {
            // Check if the Category Id is provided
            if (string.IsNullOrEmpty(Customerid.Text))
            {
                MessageBox.Show("Enter the Customer Id");
                return; // Exit the method if Customer Id is not provided
            }

            try
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM CustomerTb1 WHERE CustId = @Custid", Con))
                {
                    if (Con.State != ConnectionState.Open)
                    {
                        Con.Open();
                        Console.WriteLine("Connection opened");
                    }

                    cmd.Parameters.AddWithValue("@Custid", Customerid.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Customer Successfully deleted");
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete customer. Please try again.");
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

        // Event handler for the "Update Customer" button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                // Check if Custid is blank
                if (string.IsNullOrEmpty(Customerid.Text))
                {
                    MessageBox.Show("Enter the Customer Id");
                    return; // Exit the method if Customer Id is not provided
                }

                // Use parameterized query for the update operation
                string query = "UPDATE CustomerTb1 SET CustPhone=@CustPhone, CustName=@CustName WHERE Custid=@Custid";
                SqlCommand cmd = new SqlCommand(query, Con);

                cmd.Parameters.AddWithValue("@CustPhone", CustomerPhoneTb.Text);
                cmd.Parameters.AddWithValue("@CustName", CustomernameTb.Text);
                cmd.Parameters.AddWithValue("@Custid", Customerid.Text);

                // Execute the query and show a success message
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer Successfully Updated");
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

        private void Customerid_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        // Event handler for the "Back" button
        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}