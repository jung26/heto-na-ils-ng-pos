using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace POS_Inventory
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jslts\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void populate()
        {
            try
            {
                Con.Open();
                string myQuery = "SELECT * FROM UserTb1";

                using (SqlDataAdapter da = new SqlDataAdapter(myQuery, Con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    UsersGV.DataSource = dt;
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


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();

                // Fix the SQL syntax error: 'insert' instead of 'inser'
                SqlCommand cmd = new SqlCommand("INSERT INTO UserTb1 VALUES('" + unameTb.Text + "','" + FnameTb.Text + "','" + PasswordTb.Text + "','" + PhoneTb.Text + "')", Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
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

        private void unameTb_TextChanged(object sender, EventArgs e)
        {

        }
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UsersGV.SelectedRows.Count > 0)
            {
                unameTb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
                FnameTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
                PasswordTb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
                PhoneTb.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();

                string query = "UPDATE UserTb1 SET Uname=@Uname, Ufullname=@Ufullname, Upassword=@Upassword WHERE Uphone=@Uphone";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@Uname", unameTb.Text);
                cmd.Parameters.AddWithValue("@Ufullname", FnameTb.Text);
                cmd.Parameters.AddWithValue("@Upassword", PasswordTb.Text);
                cmd.Parameters.AddWithValue("@Uphone", PhoneTb.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User Successfully Updated");
                }
                else
                {
                    MessageBox.Show("Edit not successful. Enter Number No matching record found.");
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
        private void button3_Click(object sender, EventArgs e)
        {
            if (PhoneTb.Text == "")
            {
                MessageBox.Show("Enter the PHONE Number");
            }
            else
            {
                try
                {
                    Con.Open();
                    string myquery = "DELETE FROM UserTb1 WHERE Uphone = @Phone";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.Parameters.AddWithValue("@Phone", PhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully deleted");
                    populate();
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
        }


        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void PhoneTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}