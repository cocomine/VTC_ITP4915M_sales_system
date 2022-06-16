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
using UI;

namespace ITP4915M.IT {
    public partial class Sales_Staff_arrange : Form {
        private Account_Details acc;
        private MySqlConnection conn;

        public Sales_Staff_arrange(Account_Details acc, MySqlConnection conn) {
            this.acc = acc;
            this.conn = conn;
            InitializeComponent();
        }

        private void Sales_Staff_arrange_Load(object sender, EventArgs e) {
            Program.addPage();

            //get store list
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT ID, Name FROM storewarehouse WHERE isStore = true", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        ListViewItem item = new ListViewItem(new String[]{ reader.GetString("ID"), reader.GetString("Name") });
                        item.Tag = reader.GetString("ID");
                        list_store.Items.Add(item);
                    }
                }
                reader.Close();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //get not arrange staff
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT s.AccountID, s.FullRealName FROM staff s, sales_staff_store f WHERE s.AccountID != f.StaffAccountID AND DepartmentID = 1;", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        ListViewItem item = new ListViewItem(new String[] { reader.GetString("AccountID"), reader.GetString("FullRealName") });
                        item.Tag = reader.GetString("AccountID");
                        list_unInStore.Items.Add(item);
                    }
                }
                reader.Close();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Sales_Staff_arrange_FormClosed(object sender, FormClosedEventArgs e) {
            Program.removePage();
        }

        //get Selected store staff
        private void list_store_SelectedIndexChanged(object sender, EventArgs e) {
            //check is selected
            if(list_store.SelectedItems.Count <= 0) {
                list_inStore.Items.Clear();
                return;
            }

            string storeID = list_store.SelectedItems[0].Tag.ToString();
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT s.AccountID, s.FullRealName FROM staff s, sales_staff_store f WHERE s.AccountID = f.StaffAccountID AND f.StoreID = @id;", conn);
                cmd.Parameters.AddWithValue("@id", storeID);
                MySqlDataReader reader = cmd.ExecuteReader();

                list_inStore.Items.Clear();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        ListViewItem item = new ListViewItem(new String[] { reader.GetString("AccountID"), reader.GetString("FullRealName") });
                        item.Tag = reader.GetString("AccountID");
                        list_inStore.Items.Add(item);
                    }
                }
                reader.Close();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        //add staff in to store
        private void bt_add_Click(object sender, EventArgs e) {
            if(list_unInStore.SelectedItems.Count > 0 && list_store.SelectedItems.Count > 0) {
                try {
                    MySqlCommand cmd = new MySqlCommand("", conn);
                    cmd.Parameters.AddWithValue("@storeId", list_store.SelectedItems[0].Tag.ToString());
                    cmd.Parameters.AddWithValue("@staffId", "");

                    foreach (ListViewItem item in list_unInStore.SelectedItems) {
                        //update database
                        cmd.Parameters["@staffId"].Value = item.Tag.ToString();
                        cmd.ExecuteNonQuery();

                        //update ui
                        list_inStore.Items.Add(item);
                        list_unInStore.Items.Remove(item);
                    }
                } catch (MySqlException ex) {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }
            }
        }

        //remove staff from store
        private void bt_remove_Click(object sender, EventArgs e) {
            if (list_inStore.SelectedItems.Count > 0 && list_store.SelectedItems.Count > 0) {
                try {
                    MySqlCommand cmd = new MySqlCommand("", conn);
                    cmd.Parameters.AddWithValue("@staffId", "");

                    foreach (ListViewItem item in list_inStore.SelectedItems) {
                        //update database
                        cmd.Parameters["@staffId"].Value = item.Tag.ToString();
                        cmd.ExecuteNonQuery();

                        //update ui
                        list_unInStore.Items.Add(item);
                        list_inStore.Items.Remove(item);
                    }
                } catch (MySqlException ex) {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }
            }
        }
    }
}
