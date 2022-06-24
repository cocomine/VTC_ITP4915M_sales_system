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

namespace UI.Installer_Page {
    public partial class Installer_Page : Form {
        private MySqlConnection conn;
        private Account_Details acc;

        public Installer_Page(MySqlConnection conn, Account_Details acc) {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
        }

        private void Installer_Page_FormClosed(object sender, FormClosedEventArgs e) { Program.removePage(); }

        private void Installer_Page_Load(object sender, EventArgs e) {
            Program.addPage();

            //Get the data needed by the Installer Page
            MySqlCommand cmd_order = new MySqlCommand("SELECT * FROM `installation` AS i, `install_staff` AS ins " + " WHERE i.OrderID = ins.OrderID AND i.Status = '0' AND ins.StaffAccountID = '" + acc.Get_acoountID() + "';", conn);
            MySqlDataReader data_order;

            try {
                //Show orders that need to be installed in the list box
                data_order = cmd_order.ExecuteReader();

                while (data_order.Read()) {
                    string order = data_order.GetString("OrderID");
                    lb_order.Items.Add(order);
                }
            } catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e) { Program.Logout(); }

        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void lb_order_SelectedIndexChanged(object sender, EventArgs e) {
            //Select Command
            MySqlCommand cmd_cus = new MySqlCommand("SELECT ins.OrderID, ins.Install_date, c.CustomerID, c.Customer_name, c.Phone, c.Address, oi.OrderID, i.ItemID, i.Name " + "FROM `installation` AS ins, `customer` AS c, `order_item` AS oi, `item` AS i WHERE ins.CustomerID = c.customerID " + "AND ins.OrderID = '" + lb_order.Text + "' AND oi.OrderID = '" + lb_order.Text + "' AND oi.ItemID = i.ItemID;", conn);
            MySqlDataReader data_cus;

            try {
                //According to each selection of the list box, the name,
                //address and telephone number of the customer of an order displayed
                conn.Open();
                data_cus = cmd_cus.ExecuteReader();
                lb_installation_item.Items.Clear();

                while (data_cus.Read()) {
                    string cName = data_cus.GetString("Customer_name");
                    string cAddress = data_cus.GetString("Address");
                    string cPhone = data_cus.GetString("Phone");
                    string iName = data_cus.GetString("Name");
                    string iDate = data_cus.GetString("Install_date");

                    //Display specific content in the owning text box
                    tb_customer_name.Text = cName;
                    tb_customer_address.Text = cAddress;
                    tb_customer_phone.Text = cPhone;
                    lb_installation_item.Items.Add(iName);
                    tb_installation_date.Text = iDate;
                }
            } catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }

        private void tb_customer_name_TextChanged(object sender, EventArgs e) { }

        private void tb_customer_address_TextChanged(object sender, EventArgs e) { }

        private void tb_customer_phone_TextChanged(object sender, EventArgs e) { }

        private void lb_installation_item_SelectedIndexChanged(object sender, EventArgs e) { }

        private void btn_complete_Click(object sender, EventArgs e) {
            //Use "Order Complete" Button to update the new Installation state
            MySqlCommand cmd_comp = new MySqlCommand("UPDATE `installation` AS ins SET ins.Status = '1' " + "WHERE ins.OrderID = '" + lb_order.Text + "';", conn);
            MySqlDataReader data;
            string sOrder = lb_order.Text;

            try {
                conn.Open();
                data = cmd_comp.ExecuteReader();

                while (data.Read()) {
                    cmd_comp.ExecuteNonQuery(); //Update the data into the database
                }
            } catch (MySqlException ex) {
                MessageBox.Show("Please select a completed installation order.");
            }

            conn.Close();

            lb_order.Items.Remove(sOrder);
            tb_customer_name.Clear();
            tb_customer_phone.Clear();
            tb_customer_address.Clear();
            tb_installation_date.Clear();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }

        private void tb_installation_date_TextChanged(object sender, EventArgs e) { }
    }
}