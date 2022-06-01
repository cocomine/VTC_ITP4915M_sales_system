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
            //MySqlCommand cmd_item = new MySqlCommand("SELECT * FROM `order` AS o, `order_item` AS oi, " +
               // "`item` AS i WHERE o.OrderID = oi.OrderID AND oi.ItemID = i.ItemID", conn);
            
            MySqlDataReader data_order;
            //MySqlDataReader data_item;

            try
            {
                
                data_order = cmd_order.ExecuteReader();
                //data_item = cmd_item.ExecuteReader();


                while (data_order.Read())
                {
                    string order = data_order.GetString("OrderID");
                    lb_order.Items.Add(order);
                }

                //while (data_item.Read())
               // {
                 //   string item = data_item.GetString("ItemID");
                //    lb_installation_item.Items.Add(item);
               // }

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
            MySqlCommand cmd = new MySqlCommand("SELECT d.OrderID, c.Customer_name, c.Phone, cd.Address FROM `delivery` AS d, `customer` AS c, " +
                "`customer_detail` AS cd WHERE d.CustomerID = cd.customerID AND c.CustomerID = cd.customerID AND d.OrderID = '" + lb_order.Text + "';", conn);
            MySqlDataReader data;

            try
            {
                conn.Open();
                data = cmd.ExecuteReader();

                while (data.Read())
                {
                    string cName = data.GetString("Customer_name");
                    string cAddress = data.GetString("Address");
                    string cPhone = data.GetInt32("Phone").ToString();
                    tb_customer_name.Text = cName;
                    tb_customer_address.Text = cAddress;
                    tb_customer_phone.Text = cPhone;
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
            MySqlCommand cmd_1 = new MySqlCommand("SELECT * FROM `customer` AS c WHERE c.Phone = '" +
                tb_customer_phone.Text + "' AND c.Customer_name = '" + tb_customer_name.Text + "';", conn);
            
            MySqlDataReader data;

            try
            {
                conn.Open();
                data = cmd_1.ExecuteReader();
                while (data.Read())
                {
                    string cID = data.GetString("CustomerID");
                    MySqlCommand cmd_2 = new MySqlCommand("INSERT INTO `installation` VALUES ('" + lb_order.Text + "', '" + cID +"',0)", conn);
                    cmd_2.ExecuteNonQuery();
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