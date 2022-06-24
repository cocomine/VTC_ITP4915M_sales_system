using ITP4915M.API;
using UI.Technical_Support_page;
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

namespace UI.Delivery_Page {
    public partial class Arrange_Delivery_Page : Form
    {
        private MySqlConnection conn;
        private Account_Details acc;
        private string staffID; //Defind variable of staff ID


        public Arrange_Delivery_Page(MySqlConnection conn, Account_Details acc) {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
        }

        private void Arrange_installation_FormClosed(object sender, FormClosedEventArgs e) {
            Program.removePage();
        }

        private void Arrange_installation_Load(object sender, EventArgs e) {
            Program.addPage();

            //Get the data needed by the Arrange Installation Workers Page
            MySqlCommand cmd_order = new MySqlCommand("SELECT * FROM `order` AS o, `customer` AS c, `delivery` AS d " +
                "WHERE c.CustomerID = d.CustomerID AND o.OrderID = d.OrderID AND d.Status = '0';", conn);
            MySqlCommand cmd_staff = new MySqlCommand("SELECT dt.TeamID FROM `delivery_team` AS dt WHERE dt.Status = '0';", conn);
            MySqlCommand cmd_delivery_order = new MySqlCommand("SELECT d.OrderID FROM `delivery` AS d WHERE d.Status = '1';", conn);
            
            MySqlDataReader data_order;
            MySqlDataReader data_staff;
            MySqlDataReader data_delivery_order;
            
            //Show orders that need to be installed in the list box
            try
            {
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

            //According to each selection of the list box,
            //the installation department staff name displayed
            try
            {
                conn.Open();
                data_staff = cmd_staff.ExecuteReader();
                lb_unscheduled_team.Items.Clear();

                while (data_staff.Read())
                {
                    string teams = data_staff.GetString("TeamID");

                    //Display specific content in the owning text box
                    lb_unscheduled_team.Items.Add(teams);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            //Show workers who are processing installation orders
            try
            {
                conn.Open();
                data_delivery_order = cmd_delivery_order.ExecuteReader();
                lb_scheduled_features.Items.Clear();

                while (data_delivery_order.Read())
                {
                    string order = data_delivery_order.GetString("OrderID");

                    lb_scheduled_features.Items.Add(order);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void lb_order_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Select Command
            MySqlCommand cmd_cus = new MySqlCommand("SELECT d.OrderID, d.Session, d.Delivery_date, c.CustomerID, c.Customer_name, c.Phone, c.Address, oi.OrderID, i.ItemID, i.Name " +
                "FROM `delivery` AS d, `customer` AS c, `order_item` AS oi, `item` AS i " +
                "WHERE d.CustomerID = c.CustomerID AND d.OrderID = '" + lb_order.Text + "' AND oi.OrderID = '" + lb_order.Text +
                "' AND oi.ItemID = i.ItemID;", conn);
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
                    DateTime dDate = Convert.ToDateTime(data_cus.GetString("Delivery_date"));

                    //Display specific content in the owning text box
                    tb_customer_name.Text = cName;
                    tb_customer_address.Text = cAddress;
                    tb_customer_phone.Text = cPhone;
                    lb_delivery_item.Items.Add(iName);
                    if (dSession == "0")
                    {
                        tb_session.Text = dDate.Day + "/" + dDate.Month + "/" + dDate.Year + " Session: 09:00 - 12:00";
                    }
                    else if (dSession == "1")
                    {
                        tb_session.Text = dDate.Day + "/" + dDate.Month + "/" + dDate.Year + " Session: 13:00 - 17:00";
                    }
                    else if (dSession == "2")
                    {
                        tb_session.Text = dDate.Day + "/" + dDate.Month + "/" + dDate.Year + " Session: 18:00 - 22:00";
                    }
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

        private void tb_customer_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_customer_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_unscheduled_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            //According to the selection in the list box, get the corresponding record
            MySqlCommand cmd_staff = new MySqlCommand("SELECT * FROM `delivery_team_staff` AS dts, `staff` AS s WHERE s.FullRealName = '" +
                 lb_unscheduled_team.Text + "' AND s.AccountID = dts.StaffAccountID;", conn);
            MySqlDataReader data_staff;

            try
            {
                conn.Open();
                data_staff = cmd_staff.ExecuteReader();

                while (data_staff.Read())
                {
                    staffID = data_staff.GetString("AccountID"); //Store data of staff ID

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void lb_scheduled_features_SelectedIndexChanged(object sender, EventArgs e)
        {
            //According to the selection in the list box, get the corresponding record
            MySqlCommand cmd_schedule = new MySqlCommand("SELECT d.OrderID, d.Session, d.Delivery_date, c.CustomerID, c.Customer_name, c.Phone, c.Address, oi.OrderID, i.ItemID, i.Name" +
                " FROM `delivery` AS d, `customer` AS c, `order_item` AS oi, `item` AS i " +
                "WHERE d.CustomerID = c.CustomerID AND d.OrderID = '" + lb_scheduled_features.Text + "' AND oi.OrderID = '" + lb_scheduled_features.Text +
                "' AND oi.ItemID = i.ItemID;", conn);
            MySqlDataReader data_schedule;

            try
            {
                conn.Open();
                data_schedule = cmd_schedule.ExecuteReader();

                while (data_schedule.Read())
                {
                    string cName = data_schedule.GetString("Customer_name");
                    string cAddress = data_schedule.GetString("Address");
                    string cPhone = data_schedule.GetString("Phone");
                    string iName = data_schedule.GetString("Name");
                    string dSession = data_schedule.GetString("Session");
                    DateTime dDate = Convert.ToDateTime(data_schedule.GetString("Delivery_date"));

                    //Display specific content in the owning text box
                    tb_customer_name.Text = cName;
                    tb_customer_address.Text = cAddress;
                    tb_customer_phone.Text = cPhone;
                    lb_delivery_item.Items.Add(iName);
                    if (dSession == "0")
                    {
                        tb_session.Text = dDate.Day + "/" + dDate.Month + "/" + dDate.Year + " Session: 09:00 - 12:00";
                    }
                    else if (dSession == "1")
                    {
                        tb_session.Text = dDate.Day + "/" + dDate.Month + "/" + dDate.Year + " Session: 13:00 - 17:00";
                    }
                    else if (dSession == "2")
                    {
                        tb_session.Text = dDate.Day + "/" + dDate.Month + "/" + dDate.Year + " Session: 18:00 - 22:00";
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }

        private void btn_unschedule_Click(object sender, EventArgs e)
        {
            //Use "Unschedule" Button to update the new Installation record
            MySqlCommand cmd_to_delivery_staff = new MySqlCommand("UPDATE `delivery_team` AS dt, `delivery` AS d SET dt.Status = '0' WHERE dt.TeamID = d.Delivery_TeamID AND " +
                "d.OrderID = '" + lb_scheduled_features.Text + "';", conn);
            MySqlCommand cmd_to_delivery = new MySqlCommand("UPDATE `delivery` AS d SET d.Delivery_TeamID = NULL, d.Status = '0' WHERE d.OrderID = '" + lb_scheduled_features.Text + "';", conn);
            MySqlCommand cmd_recall_teamID = new MySqlCommand("SELECT dt.TeamID FROM `delivery_team` AS dt WHERE dt.Status = '0';", conn);
            MySqlCommand cmd_to_delivery = new MySqlCommand("UPDATE `delivery` AS d SET d.Delivery_TeamID = NULL WHERE d.OrderID = '" + lb_scheduled_features.Text + "';", conn);
            MySqlDataReader data_get_Id;
            MySqlCommand cmd_to_delivery = new MySqlCommand("UPDATE `delivery` AS d SET d.Delivery_TeamID = NULL WHERE d.OrderID = '" + lb_scheduled_features.Text + "';", conn);
            MySqlDataReader data_get_Id;
            MySqlDataReader data_to_delivery_staff;
            MySqlDataReader data_to_delivery;

            try
            {
                conn.Open();
                data_to_delivery_staff = cmd_to_delivery_staff.ExecuteReader();
                conn.Open();
                while (data_to_delivery_staff.Read())
                {
                    cmd_to_delivery_staff.ExecuteNonQuery(); //Update the data into the database
                    cmd_get_Id.ExecuteNonQuery(); //Update the data into the database
            }
            catch (MySqlException ex)
            {
                    cmd_get_Id.ExecuteNonQuery(); //Update the data into the database
                    string tID = data_get_Id.GetString("Delivery_TeamID");
            conn.Close();

            try
            {
                conn.Open();
                data_to_delivery = cmd_to_delivery.ExecuteReader();
            try
                while (data_to_delivery.Read())
                {
                    cmd_to_delivery.ExecuteNonQuery(); //Update the data into the database
            try
            }
            catch (MySqlException ex)
            {
                    cmd_to_delivery_staff.ExecuteNonQuery(); //Update the data into the database

            conn.Close();
                while (data_to_delivery_staff.Read())
            lb_order.Items.Add(sOrder);
            lb_scheduled_features.Items.Remove(sOrder);
            lb_delivery_item.Items.Clear();
            tb_customer_name.Clear();
            tb_customer_phone.Clear();
            tb_customer_address.Clear();
            lb_unscheduled_team.Items.Clear();

            if (sOrder == "")
            {
                lb_order.Items.Remove(sOrder);
            }

            try
            {
                conn.Open();
                data_recall_teamID = cmd_recall_teamID.ExecuteReader();
            try
                while (data_recall_teamID.Read())
                {
                    string teams = data_recall_teamID.GetString("TeamID");
                    lb_unscheduled_team.Items.Add(teams);

            try

            }
            catch (MySqlException ex)
            {

            }
            conn.Close();
            lb_scheduled_features.Items.Remove(sOrder);
            lb_installation_item.Items.Clear();
        private void btn_schedule_Click(object sender, EventArgs e)
        {
            tb_customer_phone.Clear();
            MySqlCommand cmd_to_delivery = new MySqlCommand("UPDATE `delivery` AS d SET d.Status = '1', d.Delivery_TeamID = '" + lb_unscheduled_team.Text + "' WHERE " +
                "d.OrderID = '" + lb_order.Text + "';", conn);
            lb_installation_item.Items.Clear();
            tb_customer_name.Clear();
            tb_customer_phone.Clear();
            MySqlCommand cmd_to_delivery = new MySqlCommand("UPDATE `delivery` AS d SET d.Delivery_TeamID = '" + lb_unscheduled_team.Text + "' WHERE " +
                "d.OrderID = '" + lb_order.Text + "';", conn);

        private void btn_schedule_Click(object sender, EventArgs e) {
            try
            {
                conn.Open();
            MySqlCommand cmd_to_delivery = new MySqlCommand("UPDATE `delivery` AS d SET d.Delivery_TeamID = '" + lb_unscheduled_team.Text + "' WHERE " +
                "d.OrderID = '" + lb_order.Text + "';", conn);
                while (data_to_delivery.Read())
                {
            MySqlDataReader data_to_delivery;
            MySqlDataReader data_to_delivery_staff;
            }
            catch (MySqlException ex)
            {
                if (sOrder == "")
                {
                    MessageBox.Show("Please select the that needs to be delivery for Team " + tID + " to perform the work.");
                }

                if (tID == "")
                {
                    MessageBox.Show("Please select the delivery team to perform '" + sOrder + "' order.");
                }
            try {
            conn.Close();
            }
            try
            {
                if (sOrder != "")
                {
                    conn.Open();
                    data_to_delivery_staff = cmd_to_delivery_staff.ExecuteReader();
            }
                    while (data_to_delivery_staff.Read())
                    {
                        cmd_to_delivery_staff.ExecuteNonQuery(); //Update the data into the database
                    }
                }
                else
                {
                    MessageBox.Show("Please select the that needs to be delivery for Team " + tID + " to perform the work.");
                }
            }
            catch (MySqlException ex)
            {
                    cmd_to_delivery_staff.ExecuteNonQuery(); //Update the data into the database
                }
            conn.Close();
            }
            catch (MySqlException ex)
            {
                    cmd_to_delivery_staff.ExecuteNonQuery(); //Update the data into the database
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            lb_scheduled_features.Items.Add(sOrder);
            lb_unscheduled_team.Items.Remove(tID);
            lb_order.Items.Remove(sOrder);
            tb_customer_name.Clear();
            tb_customer_phone.Clear();
            tb_customer_address.Clear();
            if (tID == "")
            {
                lb_scheduled_features.Items.Remove(sOrder);
                lb_order.Items.Add(sOrder);
            }
            if (sOrder == "")
            {
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
           Program.Logout();
        }
            if (sfOrder == "" && tID =="")
}
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e) {
            new My_Profile(conn, acc).Show();
        }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e) {
            new My_Profile(conn, acc).Show();
        }
    }
}