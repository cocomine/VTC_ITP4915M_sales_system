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

namespace UI.Installer_Page
{
    public partial class Installer_Page : Form {

        private MySqlConnection conn;
        private Account_Details acc;
        private string customerID;

        public Installer_Page(MySqlConnection conn, Account_Details acc) 
        {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
            
        }

        private void Installer_Page_FormClosed(object sender, FormClosedEventArgs e) {
            Program.removePage();
        }

        private void Installer_Page_Load(object sender, EventArgs e) {
            Program.addPage();

            MySqlCommand cmd_order = new MySqlCommand("SELECT * FROM `order` AS o, `customer` AS c, " +
                "`customer_detail` AS cd, `delivery` AS d WHERE c.CustomerID = d.CustomerID AND " +
                "c.CustomerID = cd.CustomerID AND o.OrderID = d.OrderID;", conn);
            
            MySqlDataReader data_order;

            try
            {
                
                data_order = cmd_order.ExecuteReader();


                while (data_order.Read())
                {
                    string order = data_order.GetString("OrderID");
                    lb_order.Items.Add(order);
                }

            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void myProfiToolStripMenuItem_Click(object sender, EventArgs e) {
            new My_Profile(conn, acc).Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lb_order_SelectedIndexChanged(object sender, EventArgs e) {
            MySqlCommand cmd_cus = new MySqlCommand("SELECT d.OrderID, c.CustomerID, c.Customer_name, c.Phone, cd.Address, oi.OrderID, i.ItemID, i.Name " +
                "FROM `delivery` AS d, `customer` AS c, `customer_detail` AS cd, `order_item` AS oi, `item` AS i WHERE d.CustomerID = cd.customerID " +
                "AND c.CustomerID = cd.customerID AND d.OrderID = '" + lb_order.Text + "' AND oi.OrderID = '" + lb_order.Text + "' AND oi.ItemID = i.ItemID;", conn);
            MySqlDataReader data;

            try
            {
                conn.Open();
                data = cmd_cus.ExecuteReader();
                lb_installation_item.Items.Clear();

                while (data.Read())
                {
                    string cName = data.GetString("Customer_name");
                    string cAddress = data.GetString("Address");
                    string cPhone = data.GetInt32("Phone").ToString();
                    string iName = data.GetString("Name");
                    customerID = data.GetString("CustomerID");

                    tb_customer_name.Text = cName;
                    tb_customer_address.Text = cAddress;
                    tb_customer_phone.Text = cPhone;
                    lb_installation_item.Items.Add(iName);
                }

                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


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

        private void lb_installation_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            // Use Button to insert the new Installation record
            MySqlCommand cmd_comp = new MySqlCommand("INSERT INTO `installation` VALUES ('" + lb_order.Text +
                "', '" + customerID + "', '0')", conn);
            MySqlDataReader data;

            try
            {
                conn.Open();
                data = cmd_comp.ExecuteReader();
               
                while (data.Read())
                {
                    cmd_comp.ExecuteNonQuery();
                }
                conn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}