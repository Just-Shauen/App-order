using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;


namespace AppOrder
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=customers.db;Version=3;";


        public Form1()
        {
            InitializeComponent();
            LoadCustomers();
        }



        private void LoadCustomers()
        {
            listBoxCustomers.Items.Clear();
            string query = "SELECT Id, City FROM Customers";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                conn.Open();
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string customer = reader["City"].ToString();
                    listBoxCustomers.Items.Add(new ListItem
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        City = customer
                    });
                }

                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedItem != null)
            {
                ListItem selectedCustomer = (ListItem)listBoxCustomers.SelectedItem;
                LoadOrders(selectedCustomer.Id);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите город.");
            }

        }
        


        private void LoadOrders(int customerId)
        {
            dataGridViewOrders.Rows.Clear();
            dataGridViewOrders.Columns.Clear();
            dataGridViewOrders.Columns.Add("OrderDetails", "Детали заказа");

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT OrderDetails FROM Orders WHERE CustomerId = @CustomerId";
                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dataGridViewOrders.Rows.Add(reader["OrderDetails"].ToString());
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listBoxCustomers.SelectedItem == null)
            {
                MessageBox.Show("Выберите город");
                return;
            }

            var selected = (ListItem)listBoxCustomers.SelectedItem;
            int customerId = selected.Id;

            dataGridViewOrders.Rows.Clear();
            string query = "SELECT OrderDetails FROM Orders WHERE CustomerId = @CustomerId";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);

                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridViewOrders.Rows.Add(reader["OrderDetails"].ToString());
                }

                conn.Close();
            }
        }
        public class ListItem
        {
            public int Id { get; set; }
            public string City { get; set; }

            public override string ToString()
            {
                return City;
            }
        }

        private void FilterCustomers(string namePart)
        {
            listBoxCustomers.Items.Clear();
            string query = "SELECT Id, City FROM Customers WHERE City LIKE @NamePart";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@NamePart", "%" + namePart + "%");
                conn.Open();

                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listBoxCustomers.Items.Add(new ListItem
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        City = reader["City"].ToString()
                    });
                }

                conn.Close();
            }
        }


        private void txtName_TextChanged(object sender, EventArgs e)
        {
            FilterCustomers(txtName.Text);

        }

















        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        
        

    }
}
