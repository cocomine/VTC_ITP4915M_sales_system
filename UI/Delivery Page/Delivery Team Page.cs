using ITP4915M.API;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Delivery_Page
{
    public partial class Delivery_Team_Page : Form
    {
        private MySqlConnection conn;
        private Account_Details acc;

        public Delivery_Team_Page(MySqlConnection conn, Account_Details acc)
        {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
        }

        private void Delivery_Page_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.removePage();
        }

        private void Delivery_Page_Load(object sender, EventArgs e)
        {
            Program.addPage();

            //Get the data needed by the Delivery Page
            MySqlCommand cmd_order = new MySqlCommand("SELECT * FROM `delivery` AS d, `customer` AS c, " +
                "`customer_detail` AS cd WHERE c.CustomerID = d.CustomerID AND " +
                "c.CustomerID = cd.CustomerID AND d.Status = '1';", conn);
            MySqlDataReader data_order;

            try
            {
                //Show orders that require delivery in a list box
                data_order = cmd_order.ExecuteReader();

                while (data_order.Read())
                {
                    string order = data_order.GetString("OrderID");
                    lb_order.Items.Add(order);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void lb_order_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Select Command
            MySqlCommand cmd_cus = new MySqlCommand("SELECT d.OrderID, c.CustomerID, c.Customer_name, c.Phone, cd.Address, oi.OrderID, i.ItemID, i.Name " +
                "FROM `delivery` AS d, `customer` AS c, `customer_detail` AS cd, `order_item` AS oi, `item` AS i WHERE d.CustomerID = cd.customerID " +
                "AND c.CustomerID = cd.customerID AND d.OrderID = '" + lb_order.Text + "' AND oi.OrderID = '" + lb_order.Text + "' AND oi.ItemID = i.ItemID;", conn);
            MySqlDataReader data_cus;

            try
            {
                //According to each selection of the list box, the name,
                //address and telephone number of the customer of an order displayed
                conn.Open();
                data_cus = cmd_cus.ExecuteReader();
                lb_delivery_item.Items.Clear();

                while (data_cus.Read())
                {
                    string cName = data_cus.GetString("Customer_name");
                    string cAddress = data_cus.GetString("Address");
                    string cPhone = data_cus.GetInt32("Phone").ToString();
                    string iName = data_cus.GetString("Name");

                    //Display specific content in the owning text box
                    tb_customer_name.Text = cName;
                    tb_customer_address.Text = cAddress;
                    tb_customer_phone.Text = cPhone;
                    lb_delivery_item.Items.Add(iName);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void tb_customer_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_customer_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_customer_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_delivery_item_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            //Use "Order Complete" Button to update the new Delivery state
            MySqlCommand cmd_comp = new MySqlCommand("UPDATE `delivery` AS d SET d.Status = '2' " +
                "WHERE d.OrderID = '" + lb_order.Text + "';", conn);
            MySqlDataReader data;
            string sOrder = lb_order.Text;

            try
            {
                conn.Open();
                data = cmd_comp.ExecuteReader();

                while (data.Read())
                {
                    cmd_comp.ExecuteNonQuery(); //Update the data into the database
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            lb_order.Items.Remove(sOrder);
            tb_customer_name.Clear();
            tb_customer_phone.Clear();
            tb_customer_address.Clear();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new My_Profile(conn, acc).Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
