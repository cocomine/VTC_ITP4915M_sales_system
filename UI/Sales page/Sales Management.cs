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

namespace UI.Sales_page {
    public partial class Sales_Management : Form {
        private MySqlConnection conn;
        private Account_Details acc;
        private string StoreID;
        private MySqlDataAdapter adapter = new MySqlDataAdapter();
        private DataSet dataSet = new DataSet();
        private BindingSource bindingSource = new BindingSource();

        public Sales_Management(MySqlConnection conn, Account_Details acc) {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e) {
            Program.addPage();

            //check is sales Manager
            if ((!acc.Get_isManager()) && (acc.Get_departmentID() == Department.Sales)) {
                MessageBox.Show("Sorry, you are not a Sales Manager. Unable to enter this page", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            //Get staff Responsible store
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT StoreID FROM sales_staff_store WHERE StaffAccountID = @id", conn);
                cmd.Parameters.AddWithValue("@id", acc.Get_acoountID());
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.HasRows) {
                    while (data.Read()) {
                        StoreID = data.GetString("StoreID");
                        lb_storeID.Text = "Store: " + StoreID;
                    }
                } else {
                    MessageBox.Show("The employee is not assigned to any store", "Not assigned", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                data.Close(); //close up
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //Get inventory
            try {
                //SelectCommand
                adapter.SelectCommand = new MySqlCommand("SELECT ItemID, Name, Price, (SELECT Qty FROM inventory WHERE StoreWarehouseID = " + StoreID + " AND ItemID = item.ItemID) AS Qty FROM item;", conn);

                //fill dataset
                adapter.Fill(dataSet, "Item_List");

                //binding data Source
                bindingSource.DataSource = dataSet;
                bindingSource.DataMember = "Item_List";
                dgv_item_list.DataSource = bindingSource;
                bindingNavigator1.BindingSource = bindingSource;

            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e) {
            Program.removePage();
        }

        //search item
        private void tb_search_TextChanged(object sender, EventArgs e) {
            bindingSource.Filter = String.Format("Name LIKE '%{0}%'", tb_search.Text);
        }

        //show low stock item
        private void num_level_ValueChanged(object sender, EventArgs e) {
            int level = (int) num_level.Value;

            foreach(DataGridViewRow row in dgv_item_list.Rows) {
                if (!Convert.IsDBNull(row.Cells[3].Value)) { //check is not null
                    if (Convert.ToInt32(row.Cells[3].Value) <= level) { //check level
                        row.DefaultCellStyle.BackColor = Color.IndianRed;
                    } else {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        //request item
        private void bt_request_Click(object sender, EventArgs e) {
            int qty = (int) num_level.Value;
            string requestID = null;

            DialogResult result = MessageBox.Show("Are you sure to request select item ?", "Request Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK) {
                //插入紀錄, 取得id
                try {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `request` (toStoreID) VALUES (@storeid); SELECT LAST_INSERT_ID() AS ID;", conn);
                    cmd.Parameters.AddWithValue("@storeid", StoreID);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        requestID = reader.GetString("ID");
                    }
                    reader.Close();
                } catch (MySqlException ex) {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }

                //加入物品
                if (requestID != null) {
                    try {
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO request_item (RequestID, ItemID, fromWarehouseID, Qty) VALUES (@RequestID, @ItemID, NULL, @Qty)", conn);
                        cmd.Parameters.AddWithValue("@RequestID", requestID);
                        cmd.Parameters.AddWithValue("@ItemID", "");
                        cmd.Parameters.AddWithValue("@Qty", qty);
                        foreach (DataGridViewCell Cell in dgv_item_list.SelectedCells) {
                            ;
                        }
                        foreach (DataGridViewRow row in dgv_item_list.SelectedRows) {
                            cmd.Parameters["@ItemID"].Value = dgv_item_list.SelectedRows[i].HeaderCell.Value;
                            cmd.ExecuteNonQuery();
                        }
                    } catch (MySqlException ex) {
                        Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                    }
                }
            }

        }
    }
}
