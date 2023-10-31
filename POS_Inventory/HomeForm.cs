using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Inventory
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        // Event handler for the "Manage Products" button
        private void button3_Click(object sender, EventArgs e)
        {
            // Create an instance of the ManageProducts form, show it, and hide the current form
            ManageProducts products = new ManageProducts();
            products.Show();
            this.Hide();
        }

        // Event handler for the "Manage Users" button
        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the ManageUsers form, show it, and hide the current form
            ManageUsers user = new ManageUsers();
            user.Show();
            this.Hide();
        }

        // Event handler for the "Manage Categories" button
        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the ManageCategories form, show it, and hide the current form
            ManageCategories Categories = new ManageCategories();
            Categories.Show();
            this.Hide();
        }

        // Event handler for the "Manage Customers" button
        private void button4_Click(object sender, EventArgs e)
        {
            // Create an instance of the ManageCustomers form, show it, and hide the current form
            ManageCustomers Customers = new ManageCustomers();
            Customers.Show();
            this.Hide();
        }

        // Event handler for the "Manage Orders" button
        private void button5_Click(object sender, EventArgs e)
        {
            // Create an instance of the ManageOrders form, show it, and hide the current form
            ManageOrders Orders = new ManageOrders();
            Orders.Show();
            this.Hide();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
