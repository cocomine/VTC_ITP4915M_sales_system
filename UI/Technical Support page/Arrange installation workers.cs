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

namespace UI.Technical_Support_page {
    public partial class Arrange_installation : Form {
        private MySqlConnection conn;
        private Account_Details acc;
        private Lang lang;

        private string staffID; //Defind variable of staff ID
        // private string old_order_date;

        public Arrange_installation(MySqlConnection conn, Account_Details acc) {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
            lang = new Lang(typeof(Arrange_installation));
        }

        private void Arrange_installation_FormClosed(object sender, FormClosedEventArgs e) { Program.removePage(); }

        private void Arrange_installation_Load(object sender, EventArgs e) {
            Program.addPage();

            //Get the data needed by the Arrange Installation Workers Page
            MySqlCommand cmd_order = new MySqlCommand("SELECT * FROM `order` AS o, `customer` AS c, `installation` AS ins " + "WHERE c.CustomerID = ins.CustomerID AND o.OrderID = ins.OrderID AND ins.Status = '0';", conn);
            MySqlCommand cmd_staff = new MySqlCommand("SELECT s.DepartmentID, s.FullRealName FROM `staff` AS s WHERE s.DepartmentID = '8';", conn);
            MySqlCommand cmd_install_staff = new MySqlCommand("SELECT ins.OrderID FROM `install_staff` AS ins, `staff` AS s WHERE ins.StaffAccountID = s.AccountID;", conn);

            MySqlDataReader data_order;
            MySqlDataReader data_staff;
            MySqlDataReader data_install_staff;

            //Show orders that need to be installed in the list box
            try {
                data_order = cmd_order.ExecuteReader();

                while (data_order.Read()) {
                    string order = data_order.GetString("OrderID");
                    lb_order.Items.Add(order);
                }
            } catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
            }

            conn.Close();

            //According to each selection of the list box,
            //the installation department staff name displayed
            try {
                conn.Open();
                data_staff = cmd_staff.ExecuteReader();
                lb_unscheduled_worker.Items.Clear();

                while (data_staff.Read()) {
                    string installationworker = data_staff.GetString("FullRealName");

                    //Display specific content in the owning text box
                    lb_unscheduled_worker.Items.Add(installationworker);
                }
            } catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
            }

            conn.Close();

            //Show workers who are processing installation orders
            try {
                conn.Open();
                data_install_staff = cmd_install_staff.ExecuteReader();
                lb_scheduled_features.Items.Clear();

                while (data_install_staff.Read()) {
                    string order = data_install_staff.GetString("OrderID");
                    lb_scheduled_features.Items.Add(order);

                    //Compare the repeatability between the need-install Order and the pre-install Order.
                    //If it repeats, remove the items in the pre-install order.
                    for (int i = 0; i < lb_order.Items.Count; i++) {
                        string rmOrder = lb_order.Items[i].ToString();
                        if (order == rmOrder) {
                            lb_order.Items.Remove(rmOrder);
                        }
                    }
                }
            } catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }

        private void lb_order_SelectedIndexChanged(object sender, EventArgs e) {
            //Select Command
            MySqlCommand cmd_cus = new MySqlCommand("SELECT ins.OrderID, ins.Install_date, c.CustomerID, c.Customer_name, c.Phone, c.Address, oi.OrderID, i.ItemID, i.Name " + "FROM `installation` AS ins, `customer` AS c, `order_item` AS oi, `item` AS i " + "WHERE ins.CustomerID = c.customerID AND ins.OrderID = '" + lb_order.Text + "' AND oi.OrderID = '" + lb_order.Text + "' AND oi.ItemID = i.ItemID;", conn);
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

                conn.Close();
            } catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void lb_unscheduled_worker_SelectedIndexChanged(object sender, EventArgs e) {
            //According to the selection in the list box, get the corresponding record
            MySqlCommand cmd_staff = new MySqlCommand("SELECT * FROM `staff` AS s WHERE s.FullRealName = '" + lb_unscheduled_worker.Text + "' AND s.DepartmentID = '8';", conn);
            MySqlDataReader data_staff;

            try {
                conn.Open();
                data_staff = cmd_staff.ExecuteReader();

                while (data_staff.Read()) {
                    staffID = data_staff.GetString("AccountID"); //Store data of staff ID
                }
            } catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
            }

            conn.Close();
        }

        private void lb_scheduled_features_SelectedIndexChanged(object sender, EventArgs e) {
            //According to the selection in the list box, get the corresponding record
            MySqlCommand cmd_schedule = new MySqlCommand("SELECT ins.OrderID, ins.Install_date, c.CustomerID, c.Customer_name, c.Phone, c.Address, oi.OrderID, i.ItemID, i.Name" + " FROM `installation` AS ins, `customer` AS c, `order_item` AS oi, `item` AS i " + "WHERE ins.CustomerID = c.customerID AND ins.OrderID = '" + lb_scheduled_features.Text + "' AND oi.OrderID = '" + lb_scheduled_features.Text + "' AND oi.ItemID = i.ItemID;", conn);
            MySqlDataReader data_schedule;

            try {
                lb_installation_item.Items.Clear();
                conn.Open();
                data_schedule = cmd_schedule.ExecuteReader();

                while (data_schedule.Read()) {
                    string cName = data_schedule.GetString("Customer_name");
                    string cAddress = data_schedule.GetString("Address");
                    string cPhone = data_schedule.GetString("Phone");
                    string iName = data_schedule.GetString("Name");
                    string iDate = data_schedule.GetString("Install_date");

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

        private void btn_unschedule_Click(object sender, EventArgs e) {
            //Use "Unschedule" Button to update the new Installation record
            string sOrder = lb_scheduled_features.Text;
            MySqlCommand cmd_to_install_staff = new MySqlCommand("DELETE FROM `install_staff` WHERE OrderID = '" + sOrder + "';", conn);
            MySqlDataReader data_to_install_staff;

            try {
                conn.Open();
                data_to_install_staff = cmd_to_install_staff.ExecuteReader();

                while (data_to_install_staff.Read()) {
                    cmd_to_install_staff.ExecuteNonQuery(); //Update the data into the database
                }
            } catch (MySqlException ex) {
                MessageBox.Show(lang.GetString("Please_select_the_order_to_cancel_the_schedule_of_installation_"));
            }

            conn.Close();

            lb_order.Items.Add(sOrder);
            lb_scheduled_features.Items.Remove(sOrder);
            lb_installation_item.Items.Clear();
            tb_customer_name.Clear();
            tb_customer_phone.Clear();
            tb_customer_address.Clear();
            tb_installation_date.Clear();

            //Avoid creating an empty order
            if (sOrder == "") {
                lb_order.Items.Remove(sOrder);
            }
        }

        private void btn_schedule_Click(object sender, EventArgs e) {
            //Use "Schedule" Button to update the new Installation record
            MySqlCommand cmd_to_install_staff = new MySqlCommand("INSERT INTO `install_staff` (OrderID, StaffAccountID) VALUES" + " ('" + lb_order.Text + "', '" + staffID + "');", conn);
            MySqlDataReader data_to_install_staff;
            MySqlCommand cmd_count_30 = new MySqlCommand("SELECT * FROM `installation` AS i, `install_staff` AS ins, `staff` AS s WHERE " + "s.FullRealName = '" + lb_unscheduled_worker.Text + "' AND ins.OrderID = i.OrderID AND s.AccountID = ins.StaffAccountID;", conn);
            MySqlDataReader data_count_30;
            string sOrder = lb_order.Text;
            string sStaff = lb_unscheduled_worker.Text;
            bool rs = true;

            try {
                conn.Open();
                data_count_30 = cmd_count_30.ExecuteReader();

                while (data_count_30.Read()) {
                    //Defind variable of only one order can be taken every 30 minutes
                    DateTime new_date = Convert.ToDateTime(tb_installation_date.Text);
                    DateTime old_date = Convert.ToDateTime(data_count_30.GetString("install_date"));

                    if (DateTime.Compare(new_date, old_date) == 0) //if new older and old order are same time
                    {
                        DialogResult result = MessageBox.Show(lang.GetString("Installation_orders_for_each_employee_can_only_be_separated_by_thirty_minutes_"), "Warning", MessageBoxButtons.OK);
                        if (result == DialogResult.OK) {
                            rs = false;
                        }
                    } else if (DateTime.Compare(new_date, old_date) > 0) //if new order installation date is later than old older
                    {
                        //if old order installation date is later than new older
                        if (old_date.AddMinutes(30) >= new_date) {
                            DialogResult result = MessageBox.Show(lang.GetString("Installation_orders_for_each_employee_can_only_be_separated_by_thirty_minutes_"), "Warning", MessageBoxButtons.OK);
                            if (result == DialogResult.OK) {
                                rs = false;
                            }
                        }
                    } else //if old order installation date is later than new older
                    {
                        if (new_date.AddMinutes(30) >= old_date) {
                            DialogResult result = MessageBox.Show(lang.GetString("Installation_orders_for_each_employee_can_only_be_separated_by_thirty_minutes_"), "Warning", MessageBoxButtons.OK);
                            if (result == DialogResult.OK) {
                                rs = false;
                            }
                        }
                    }
                }
            } catch (MySqlException ex) 
            {
                MessageBox.Show(lang.GetString("Please_select_the_order_to_cancel_the_schedule_of_installation_"));

            } catch (FormatException ex)
            {
                MessageBox.Show(string.Format(lang.GetString("Please_select_the_order_that_needs_to_be_installed_for__0__to_perform_the_work_"), sStaff));
                rs = false;
            }

            conn.Close();

            if (rs) {
                try {
                    conn.Open();
                    data_to_install_staff = cmd_to_install_staff.ExecuteReader();

                    while (data_to_install_staff.Read()) {
                        cmd_to_install_staff.ExecuteNonQuery(); //Update the data into the database
                    }
                } catch (MySqlException ex) {
                    if (sOrder == "") {
                        MessageBox.Show(string.Format(lang.GetString("Please_select_the_order_that_needs_to_be_installed_for__0__to_perform_the_work_"), sStaff));
                    }

                    if (sStaff == "") {
                        MessageBox.Show(string.Format(lang.GetString("Please_select_the_installer_worker_to_perform___0___order_"), sOrder));
                    }
                }

                conn.Close();
            }

            lb_scheduled_features.Items.Add(sOrder);
            lb_order.Items.Remove(sOrder);
            tb_customer_name.Clear();
            tb_customer_phone.Clear();
            tb_customer_address.Clear();
            tb_installation_date.Clear();
            if (sStaff == "") {
                lb_scheduled_features.Items.Remove(sOrder);
                lb_order.Items.Add(sOrder);
            }

            if (!rs) {
                lb_scheduled_features.Items.Remove(sOrder);
                lb_order.Items.Add(sOrder);
            }

            if(sOrder == "")
            {
                lb_order.Items.Remove(sOrder);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) { Program.Logout(); }
    }
}