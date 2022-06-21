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
            //item tag = false = not in any store
            //item tag = true = in store
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT s.AccountID, s.FullRealName FROM staff s LEFT JOIN sales_staff_store f ON s.AccountID = f.StaffAccountID WHERE f.StaffAccountID IS NULL AND s.DepartmentID = 1;", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        ListViewItem item = new ListViewItem(new String[] { reader.GetString("AccountID"), reader.GetString("FullRealName") });
                        item.Tag = false;
                        item.Name = reader.GetString("AccountID");
                        list_unInStore.Items.Add(item);
                    }
                }
                reader.Close();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Program.Logout();
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
                        item.Tag = true;
                        item.Name = reader.GetString("AccountID");
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
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `sales_staff_store` (`StaffAccountID`, `StoreID`) VALUES (@staffId, @storeId)", conn);
                    cmd.Parameters.AddWithValue("@storeId", list_store.SelectedItems[0].Tag.ToString());
                    cmd.Parameters.AddWithValue("@staffId", "");

                    foreach (ListViewItem item in list_unInStore.SelectedItems) {
                        //update database
                        cmd.Parameters["@staffId"].Value = item.Name;
                        cmd.ExecuteNonQuery();

                        //update ui
                        list_unInStore.Items.Remove(item);
                        item.Tag = true;
                        list_inStore.Items.Add(item);
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
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM `sales_staff_store` WHERE `sales_staff_store`.`StaffAccountID` = @staffId;", conn);
                    cmd.Parameters.AddWithValue("@staffId", "");

                    foreach (ListViewItem item in list_inStore.SelectedItems) {
                        //update database
                        cmd.Parameters["@staffId"].Value = item.Name;
                        cmd.ExecuteNonQuery();

                        //update ui
                        list_inStore.Items.Remove(item);
                        item.Tag = false;
                        list_unInStore.Items.Add(item);
                    }
                } catch (MySqlException ex) {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }
            }
        }

        //drag drop
        //Drag item
        private void list_unInStore_ItemDrag(object sender, ItemDragEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
        }
        //Drop from InStore staff //remove staff
        private void list_unInStore_DragDrop(object sender, DragEventArgs e) {
            ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            if (item != null && (bool) item.Tag == true) {
                bt_remove.PerformClick();
            }
        }
        //check allowed drop
        private void list_unInStore_DragEnter(object sender, DragEventArgs e) {
            if(list_store.SelectedItems.Count > 0) { //check is select store
                e.Effect = e.AllowedEffect;
            }
        }
        //Drop from unInStore staff //add staff
        private void list_inStore_DragDrop(object sender, DragEventArgs e) {
            ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            if (item != null && (bool)item.Tag == false && list_store.SelectedItems.Count > 0) {
                bt_add.PerformClick();
            }
        }
        //on drag, select store
        private void list_store_DragOver(object sender, DragEventArgs e) {
            Point point = list_store.PointToClient(new Point(e.X, e.Y)); // gete mouse position. 
            ListViewItem item = list_store.GetItemAt(point.X, point.Y); // Select node at mouse position.
            if (item != null) {
                item.Selected = true;
                list_store.Select();
            }
        }
        //Drop from unInStore staff, add staff
        private void list_store_DragDrop(object sender, DragEventArgs e) {
            ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            if (item != null && list_store.SelectedItems.Count > 0 && (bool)item.Tag == false) {
                bt_add.PerformClick(); //add staff
            }
        }
        //store list check allowed drop
        private void list_store_DragEnter(object sender, DragEventArgs e) {
            ListViewItem item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
            if (item != null && (bool)item.Tag == false) { //check is unInStore staff
                e.Effect = e.AllowedEffect;
            }
        }
    }
}
