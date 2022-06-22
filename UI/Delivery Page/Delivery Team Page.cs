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
        public String dTeamID;

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
            MySqlCommand cmd_order = new MySqlCommand("SELECT * FROM `delivery` AS d, `customer` AS c " +
                "WHERE c.CustomerID = d.CustomerID AND d.Status = '1';", conn);
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
            MySqlCommand cmd_cus = new MySqlCommand("SELECT d.OrderID, d.Session, d.Delivery_date, d.Delivery_TeamID, c.CustomerID, c.Customer_name, c.Phone, c.Address, oi.OrderID, i.ItemID, i.Name " +
                "FROM `delivery` AS d, `customer` AS c, `order_item` AS oi, `item` AS i WHERE d.CustomerID = c.customerID " +
                "AND d.OrderID = '" + lb_order.Text + "' AND oi.OrderID = '" + lb_order.Text + "' AND oi.ItemID = i.ItemID;", conn);
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
                    string cPhone = data_cus.GetString("Phone");
                    string iName = data_cus.GetString("Name");
                    string dSession = data_cus.GetString("Session");
                    string dDate = data_cus.GetString("Delivery_date");
                    dTeamID = data_cus.GetInt32("Delivery_TeamID").ToString();

                    //Display specific content in the owning text box
                    tb_customer_name.Text = cName;
                    tb_customer_address.Text = cAddress;
                    tb_customer_phone.Text = cPhone;
                    lb_delivery_item.Items.Add(iName);
                    if (dSession == "0")
                    {
                        tb_session.Text = "09:00 - 12:00";
                    } else if (dSession == "1")
                    {
                        tb_session.Text = "13:00 - 17:00";
                    } else if (dSession == "2")
                    {
                        tb_session.Text = "18:00 - 22:00";
                    }
                    tb_delivery_date.Text = dDate;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            //Use "Order Complete" Button to update the new Delivery state
            MySqlCommand cmd_comp = new MySqlCommand("UPDATE `delivery` AS d SET d.Status = '2' " +
                "WHERE d.OrderID = '" + lb_order.Text + "';", conn);
            MySqlDataReader comp_data;
            string sOrder = lb_order.Text;

            MySqlCommand update_dTeamStatus = new MySqlCommand("UPDATE `delivery_team` AS ds SET ds.Status = '0' " +
                "WHERE d.TeamID = '" + dTeamID + "';", conn);
            MySqlDataReader data_teamStatus;

            try
            {
                conn.Open();
                comp_data = cmd_comp.ExecuteReader();

                while (comp_data.Read())
                {
                    cmd_comp.ExecuteNonQuery(); //Update the data into the database
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                conn.Open();
                data_teamStatus = update_dTeamStatus.ExecuteReader();

                while (data_teamStatus.Read())
                {
                    update_dTeamStatus.ExecuteNonQuery(); //Update the data into the database
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
            tb_session.Clear();
            tb_delivery_date.Clear();


        }



        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new My_Profile(conn, acc).Show();
        }
    }
}
