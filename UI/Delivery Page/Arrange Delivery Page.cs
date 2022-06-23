﻿using ITP4915M.API;
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
        private string customerID; //Defind variable of customer ID
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
            MySqlCommand cmd_delivery_staff = new MySqlCommand("SELECT d.OrderID FROM `delivery` AS d WHERE d.Status = '1';", conn);
            
            MySqlDataReader data_order;
            MySqlDataReader data_staff;
            MySqlDataReader data_delivery_staff;
            
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
                    string installationworker = data_staff.GetString("TeamID");

                    //Display specific content in the owning text box
                    lb_unscheduled_team.Items.Add(installationworker);
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
                data_delivery_staff = cmd_delivery_staff.ExecuteReader();
                lb_scheduled_features.Items.Clear();

                while (data_delivery_staff.Read())
                {
                    string order = data_delivery_staff.GetString("OrderID");

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
            MySqlCommand cmd_cus = new MySqlCommand("SELECT d.OrderID, d.Session, c.CustomerID, c.Customer_name, c.Phone, c.Address, oi.OrderID, i.ItemID, i.Name " +
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
                lb_installation_item.Items.Clear();

                while (data_cus.Read())
                {
                    string cName = data_cus.GetString("Customer_name");
                    string cAddress = data_cus.GetString("Address");
                    string cPhone = data_cus.GetString("Phone");
                    string iName = data_cus.GetString("Name");
                    string dSession = data_cus.GetString("Session");
                    customerID = data_cus.GetString("CustomerID"); //Store data of customer ID

                    //Display specific content in the owning text box
                    tb_customer_name.Text = cName;
                    tb_customer_address.Text = cAddress;
                    tb_customer_phone.Text = cPhone;
                    lb_installation_item.Items.Add(iName);
                    if (dSession == "0")
                    {
                        tb_session.Text = "09:00 - 12:00";
                    }
                    else if (dSession == "1")
                    {
                        tb_session.Text = "13:00 - 17:00";
                    }
                    else if (dSession == "2")
                    {
                        tb_session.Text = "18:00 - 22:00";
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
            MySqlCommand cmd_schedule = new MySqlCommand("SELECT d.OrderID, d.Session, c.CustomerID, c.Customer_name, c.Phone, c.Address, oi.OrderID, i.ItemID, i.Name" +
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

                    //Display specific content in the owning text box
                    tb_customer_name.Text = cName;
                    tb_customer_address.Text = cAddress;
                    tb_customer_phone.Text = cPhone;
                    lb_installation_item.Items.Add(iName);
                    if (dSession == "0")
                    {
                        tb_session.Text = "09:00 - 12:00";
                    }
                    else if (dSession == "1")
                    {
                        tb_session.Text = "13:00 - 17:00";
                    }
                    else if (dSession == "2")
                    {
                        tb_session.Text = "18:00 - 22:00";
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
            MySqlCommand cmd_get_Id = new MySqlCommand("SELECT dts.Delivery_TeamID FROM `delivery_team_staff` AS dts, `delivery` AS d WHERE d.OrderID = '" 
                + lb_scheduled_features.Text + "' AND dts.Delivery_TeamID = d.Delivery_TeamID", conn);
            MySqlCommand cmd_to_delivery_staff = new MySqlCommand("UPDATE `delivery_team` AS dt, `delivery` AS d SET dt.Status = '0' WHERE dt.TeamID = d.Delivery_TeamID AND " +
                "d.OrderID = '" + lb_scheduled_features.Text + "';", conn);
            MySqlCommand cmd_to_delivery = new MySqlCommand("UPDATE `delivery` AS d SET d.Delivery_TeamID = NULL WHERE d.OrderID = '" + lb_scheduled_features.Text + "';", conn);
            MySqlDataReader data_get_Id;
            MySqlDataReader data_to_delivery_staff;
            MySqlDataReader data_to_delivery;

            string sOrder = lb_scheduled_features.Text;

            try
            {
                conn.Open();
                data_get_Id = cmd_get_Id.ExecuteReader();

                while (data_get_Id.Read())
                {
                    cmd_get_Id.ExecuteNonQuery(); //Update the data into the database
                    string tID = data_get_Id.GetString("Delivery_TeamID");
                    lb_unscheduled_team.Items.Add(tID);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();


            try
            {
                conn.Open();
                data_to_delivery_staff = cmd_to_delivery_staff.ExecuteReader();

                while (data_to_delivery_staff.Read())
                {
                    cmd_to_delivery_staff.ExecuteNonQuery(); //Update the data into the database
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            try
            {
                conn.Open();
                data_to_delivery = cmd_to_delivery.ExecuteReader();

                while (data_to_delivery.Read())
                {
                    cmd_to_delivery.ExecuteNonQuery(); //Update the data into the database
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            lb_order.Items.Add(sOrder);
            //lb_unscheduled_team.Items.Add(tID);
            lb_scheduled_features.Items.Remove(sOrder);
            lb_installation_item.Items.Clear();
            tb_customer_name.Clear();
            tb_customer_phone.Clear();
            tb_customer_address.Clear();
        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            //Use "Schedule" Button to update the new Installation record
            MySqlCommand cmd_to_delivery = new MySqlCommand("UPDATE `delivery` AS d SET d.Delivery_TeamID = '" + lb_unscheduled_team.Text + "' WHERE " +
                "d.OrderID = '" + lb_order.Text + "';", conn);
            MySqlCommand cmd_to_delivery_staff = new MySqlCommand("UPDATE `delivery_team` AS dt SET dt.Status = '2' WHERE dt.TeamID = '" + lb_unscheduled_team.Text + "';", conn);
            MySqlDataReader data_to_delivery;
            MySqlDataReader data_to_delivery_staff;
            string sOrder = lb_order.Text;
            string tID = lb_unscheduled_team.Text;

            try
            {
                conn.Open();
                data_to_delivery = cmd_to_delivery.ExecuteReader();

                while (data_to_delivery.Read())
                {
                    cmd_to_delivery.ExecuteNonQuery(); //Update the data into the database
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            try
            {
                conn.Open();
                data_to_delivery_staff = cmd_to_delivery_staff.ExecuteReader();

                while (data_to_delivery_staff.Read())
                {
                    cmd_to_delivery_staff.ExecuteNonQuery(); //Update the data into the database
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            lb_scheduled_features.Items.Add(sOrder);
            lb_unscheduled_team.Items.Remove(tID);
            lb_order.Items.Remove(sOrder);
            tb_customer_name.Clear();
            tb_customer_phone.Clear();
            tb_customer_address.Clear();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e) {
            new My_Profile(conn, acc).Show();
        }
    }
}