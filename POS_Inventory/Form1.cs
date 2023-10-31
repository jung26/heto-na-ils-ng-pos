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
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jslts\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Event handler for the "Show Password" checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility based on checkbox state
            if (checkBox1.Checked == true)
            {
                PasswordTb.PasswordChar = '\0';// Show password
            }
            else
            {
                PasswordTb.PasswordChar = '*';// Hide password with asterisks / *
            }

        }

        // Event handler for the "Clear" label
        private void label3_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
        }

        // Event handler for the "Close" label
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event handler for the "Login" button
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if username and password fields are not empty
            if (string.IsNullOrEmpty(UnameTb.Text) || string.IsNullOrEmpty(PasswordTb.Text))
            {
                MessageBox.Show("Please enter username and password.");
                return; // Exit the method if fields are empty
            }

            try
            {
                Con.Open(); // Open the database connection

                // Use SqlDataAdapter to execute a SQL query to check the user's credentials
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM UserTb1 WHERE Uname = '" + UnameTb.Text + "' AND Upassword ='" + PasswordTb.Text + "'", Con);
                DataTable dt = new DataTable();   // Create a new DataTable to store the results of the SQL query.
                sda.Fill(dt);   // Use the SqlDataAdapter (sda) to fill the DataTable (dt) with the results of the SQL query.

                // Check if a matching user is found
                if (dt.Rows[0][0].ToString() == "1")
                {
                    ManageCustomers cust = new ManageCustomers();
                    cust.Show();
                    this.Hide(); // Hide the current login form if login is successful
                }       
                else
                {
                    MessageBox.Show("Wrong UserName or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                Con.Close(); // Close the database connection, whether an exception occurred or not
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
