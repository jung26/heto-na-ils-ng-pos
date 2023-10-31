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
    public partial class ViewOrder : Form
    {
         SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jslts\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        public ViewOrder()
        {
            InitializeComponent();
        }

        void populateOrders()
        {
            try
            {
                Con.Open();
                string myQuery = "SELECT * FROM OrdersTb1"; // Corrected table name

                using (SqlDataAdapter da = new SqlDataAdapter(myQuery, Con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    OrdersGv.DataSource = dt;
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

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            populateOrders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OrdersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            { 
            printDocument1.Print();
        }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Order Summary", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Order Id: " + OrdersGv.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 100));
            e.Graphics.DrawString("Customer Id: " + OrdersGv.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 133));
            e.Graphics.DrawString("Customer Name: " + OrdersGv.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 166));
            e.Graphics.DrawString("Order Date: " + OrdersGv.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 199));
            e.Graphics.DrawString("Total Amount: " + OrdersGv.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 232));

            e.Graphics.DrawString("---MYBRANDNAME---", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230,350));

        }
    }
}
