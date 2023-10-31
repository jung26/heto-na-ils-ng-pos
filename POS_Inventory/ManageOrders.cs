using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Inventory

{
    public partial class ManageOrders : Form
    {
        // SqlConnection object to manage the database connection
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jslts\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                string myQuery = "SELECT * FROM CustomerTb1";

                using (SqlDataAdapter da = new SqlDataAdapter(myQuery, Con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

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

        void populateproducts()
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
        // DataTable to store order details
        DataTable table = new DataTable();

        // Variables for tracking product information
        int num = 0;
        int uprice, totprice, Qty;
        string product;
        int Flag = 0;
        int stock;


        public void UpdateProduct()
        {
            try
            {
                if (ProductGV.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(ProductGV.SelectedRows[0].Cells[0].Value.ToString());
                    int newQty = stock - Convert.ToInt32(QtyTb.Text);

                    if (newQty < 0)
                    {
                        MessageBox.Show("Failed");
                    }
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand("UPDATE ProductTb1 SET ProdQty = @NewQty WHERE ProdId = @ProductId", Con))
                        {
                            cmd.Parameters.AddWithValue("@NewQty", newQty);
                            cmd.Parameters.AddWithValue("@ProductId", id);

                            Con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product quantity: " + ex.Message);
            }
            finally
            {
                Con.Close();
                populateproducts();
            }
        }

        // Constructor for the ManageOrders form
        public ManageOrders()
        {
            // Initialize the DataTable columns
            InitializeComponent();
            table.Columns.Add("No", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("TotalPrice", typeof(int));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            populateproducts();
           
           


        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CustomersGV.Rows.Count)
            {
                CustId.Text = CustomersGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                CustName.Text  = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();

                
            }
            else
            {
                CustId.Text = string.Empty; // Clear the text if no valid row is selected
            }
        }

        private void OrderIdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Searchcombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void Searchcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProductGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ProductGV.Rows.Count)
            {
                product = ProductGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                stock = Convert.ToInt32(ProductGV.Rows[e.RowIndex].Cells[2].Value.ToString());
                uprice = Convert.ToInt32(ProductGV.Rows[e.RowIndex].Cells[3].Value.ToString());
                Flag = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            int sum = 0;

            if (QtyTb.Text == "")
                MessageBox.Show("enter quantity of product");
            else if (Flag == 0)
                MessageBox.Show("Select the product");
            else if (Convert.ToInt32(QtyTb.Text) > stock)
                MessageBox.Show("not enough stock available");
            else
            {
                num = num + 1;
                Qty = Convert.ToInt32(QtyTb.Text);
                totprice = Qty * uprice;
                table.Rows.Add(num, product, Qty, uprice, totprice);
                OrderGv.DataSource = table;
                Flag = 0;
            }
            sum = sum + totprice;
            TotAmount.Text = "" +sum.ToString();
            UpdateProduct();

        }

        private void Searchcombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (OrderIdTb.Text == "" || CustId.Text == "" || CustName.Text == "" || TotAmount.Text == "")
            {
                MessageBox.Show("Fill in the data correctly.");
            }
            else
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();

                        // Use parameters to avoid SQL injection
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO OrdersTb1 (OrderId, CustId, CustName, OrderDate, TotalAmt) VALUES (@OrderId, @CustId, @CustName, @OrderDate, @TotalAmt)", Con))
                        {
                            cmd.Parameters.AddWithValue("@OrderId", OrderIdTb.Text);
                            cmd.Parameters.AddWithValue("@CustId", CustId.Text);
                            cmd.Parameters.AddWithValue("@CustName", CustName.Text);

                            // Convert the string to DateTime
                            if (DateTime.TryParse(orderdate.Text, out DateTime orderDateTime))
                            {
                                cmd.Parameters.AddWithValue("@OrderDate", orderDateTime);
                            }
                            else
                            {
                                MessageBox.Show("Invalid date format.");
                                return;
                            }

                            // Assuming TotalAmt is of INT type, update the datatype if needed
                            if (int.TryParse(TotAmount.Text, out int totalAmt))
                            {
                                cmd.Parameters.AddWithValue("@TotalAmt", totalAmt);
                            }
                            else
                            {
                                MessageBox.Show("Invalid Total Amount.");
                                return;
                            }

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Order Added Successfully ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Connection is already open.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding order: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                    populate();
                }
            }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewOrder view = new ViewOrder();
            view.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CustName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
