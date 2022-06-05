using ITP4915M.API;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace UI.Sales_page {
    public partial class Sales_Page : Form {
        private String StoreID;
        private MySqlConnection conn;
        private Account_Details acc;
        private List<Item> shoppingCart_Item = new List<Item>();
        private List<Combo> shoppingCart_Combo = new List<Combo>();
        private Dictionary<Item, int> Unavailable_Item_Qty = new Dictionary<Item, int>();
        private double received = 0;
        private double total = 0;
        public Sales_Page(MySqlConnection conn, Account_Details acc) {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
        }

        private void Sales_Page_Load(object sender, EventArgs e) {
            Program.addPage();

            //setup AutoComplete
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT Name, ItemID FROM item", conn);
                MySqlDataReader data = cmd.ExecuteReader();

                AutoCompleteStringCollection nameCol = new AutoCompleteStringCollection(); //name list
                AutoCompleteStringCollection idCol = new AutoCompleteStringCollection(); //id list
                while (data.Read()) {
                    nameCol.Add(data.GetString("Name"));
                    idCol.Add(data.GetString("ItemID"));
                }
                data.Close(); //close up
                cmd.Dispose(); //close up

                tb_add_name.AutoCompleteCustomSource = nameCol; //set add by name
                tb_add_id.AutoCompleteCustomSource = idCol; //set add by code

                //Get staff Responsible store
                cmd = new MySqlCommand("SELECT StoreID FROM sales_staff_store WHERE StaffAccountID = @id", conn);
                cmd.Parameters.AddWithValue("@id", acc.Get_acoountID());
                data = cmd.ExecuteReader();
                if (data.HasRows) {
                    while (data.Read()) {
                        StoreID = data.GetString("StoreID");
                    }
                } else {
                    MessageBox.Show("The employee is not assigned to any store", "Not assigned", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                data.Close(); //close up

            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            Console.WriteLine(StoreID);
        }

        private void Sales_Page_FormClosed(object sender, FormClosedEventArgs e) {
            Program.removePage();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e) {
            new My_Profile(conn, acc).Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //add by name
        private void bt_add_name_Click(object sender, EventArgs e) {
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT i.ItemID, i.Name, i.Price, i.Type, i.Description, t.Qty FROM item i, inventory t WHERE i.ItemID = t.ItemID AND i.Name = @name AND t.StoreWarehouseID = @StoreID;", conn);
                cmd.Parameters.AddWithValue("@name", tb_add_name.Text);
                cmd.Parameters.AddWithValue("@StoreID", StoreID);
                MySqlDataReader data = cmd.ExecuteReader();

                addItem(data);
                data.Close();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //Next work flow
            tb_add_name.Text = "";
            checkCombo();
            ShowList();
            CountPrice();
        }

        //add by id
        private void bt_add_id_Click(object sender, EventArgs e) {
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT i.ItemID, i.Name, i.Price, i.Type, i.Description, t.Qty FROM item i, inventory t WHERE i.ItemID = t.ItemID AND i.ItemID = @id AND t.StoreWarehouseID = @StoreID;", conn);
                cmd.Parameters.AddWithValue("@id", tb_add_id.Text);
                cmd.Parameters.AddWithValue("@StoreID", StoreID);
                MySqlDataReader data = cmd.ExecuteReader();

                addItem(data);
                data.Close();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //Next work flow
            tb_add_id.Text = "";
            checkCombo();
            ShowList();
            CountPrice();

        }

        //加入物品到購物車
        private void addItem(MySqlDataReader data) {
            if (!data.HasRows) { //檢查是否存在
                //不存在
                MessageBox.Show("The item does not exist", "Not exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            while (data.Read()) {
                //檢查購物車本身有沒有該物品
                Item item = shoppingCart_Item.Find(x => x.Id == data.GetString("ItemID"));
                if (item != null) {
                    //add qty
                    item.AddQty();
                } else {
                    //create item
                    item = new Item(data.GetString("ItemID"), data.GetString("Name"), data.GetDouble("Price"), data.GetInt32("Type"), null, data.IsDBNull(data.GetOrdinal("Description")) ? null : data.GetString("Description"), 1); //create item obj
                    shoppingCart_Item.Add(item);
                }

                //檢查庫存是否足夠
                int Unavailable_qty = data.GetInt32("Qty") - item.Qty;
                if (Unavailable_qty < 0) {
                    if (Unavailable_Item_Qty.ContainsKey(item)) Unavailable_Item_Qty[item]++;
                    else Unavailable_Item_Qty.Add(item, Unavailable_qty);
                }

                //展示物品詳細
                tb_item_name.Text = item.Name;
                tb_item_price.Text = String.Format("{0:C}", item.Price);
                tb_item_description.Text = item.Description;
                chb_item_install.Checked = (item.Type == ItemType.Install || item.Type == ItemType.Large_and_install);
                chb_item_large.Checked = (item.Type == ItemType.Large || item.Type == ItemType.Large_and_install);
            }
        }

        //檢查套裝
        private void checkCombo() {
            //check in shopping cart have item match combo
            List<string> items_id_list = new List<string>();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (Item item in shoppingCart_Item) {
                items_id_list.Add(item.Id);
            }
            try {
                //取得現在item相符的套裝id
                MySqlCommand cmd = new MySqlCommand("SELECT ComboID, COUNT(ItemID) AS 'Count' FROM combo_item WHERE ItemID IN('" + String.Join("','", items_id_list) + "') GROUP BY ComboID;", conn);
                MySqlDataReader data = cmd.ExecuteReader();

                if (data.HasRows) {
                    while (data.Read()) {
                        dic.Add(data.GetString("ComboID"), data.GetInt32("Count")); //add the Dictionary
                    }
                }
                //close up
                data.Close();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }


            if (dic.Count <= 0) return; //沒有相符的套裝id

            //檢查是否符合套裝要求
            List<string> combos_id_list = new List<string>();
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(ItemID) AS 'count' FROM combo_item WHERE ComboID = @ComboID;", conn);
                cmd.Parameters.AddWithValue("@ComboID", "");
                cmd.Parameters.AddWithValue("@count", 0);

                foreach (KeyValuePair<string, int> item_count in dic) {
                    cmd.Parameters["@ComboID"].Value = item_count.Key;
                    MySqlDataReader data = cmd.ExecuteReader();

                    data.Read();
                    if (data.GetInt32("count") == item_count.Value) {
                        //符合要求
                        combos_id_list.Add(item_count.Key);
                    }
                    data.Close();
                }
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            if (combos_id_list.Count <= 0) return; //沒有符合任何套裝要求

            //取得套裝包括的物品
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT ci.ItemID, c.Name, c.Price, c.Description FROM combo_item ci, combo c WHERE ci.ComboID = c.ComboID AND ci.ComboID = @ComboID", conn);
                cmd.Parameters.AddWithValue("@ComboID", "");

                foreach (string combo_id in combos_id_list) {
                    cmd.Parameters["@ComboID"].Value = combo_id;
                    MySqlDataReader reader = cmd.ExecuteReader();

                    //放入套裝
                    while (reader.Read()) {
                        Item item = shoppingCart_Item.Find(x => x.Id == reader.GetString("ItemID")); //取得item obj
                        Combo combo = shoppingCart_Combo.Find(x => x.Id == combo_id);

                        //檢查是否已存在相同的combo
                        if (combo == null) {
                            //不存在創建新的
                            combo = new Combo(combo_id, reader.GetString("Name"), reader.GetDouble("Price"), reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString("Description"));
                            combo.AddItem(item);
                            shoppingCart_Combo.Add(combo);
                        } else {
                            //已存在
                            //檢查item是否已存在於combo
                            Item ls = combo.GetItemsList().Find(x => x.Equals(item));
                            if (ls == null) {
                                combo.AddItem(item); //不存在
                            }
                        }
                    }
                    reader.Close();
                }

            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        //展示訂單列表
        private void ShowList() {
            //debug
            foreach (Item item in shoppingCart_Item) {
                Console.WriteLine(item);
            }
            foreach (Combo combo in shoppingCart_Combo) {
                Console.WriteLine(combo);
            }
            foreach (Item item in Unavailable_Item_Qty.Keys) {
                Console.WriteLine(item);
            }

            //clear up item list
            lv_item_list.Items.Clear();
            lv_item_list.Groups.Clear();

            //show Item list
            foreach (Item item in shoppingCart_Item) {
                ListViewItem listViewItem = new ListViewItem(
                    new string[] {
                        "",
                        item.Qty.ToString(), //item qty
                        String.Format("{0:0.00}", item.GetTotalPrice()) //item price
                    }) {
                    Tag = item,
                    Text = item.Name,
                    Name = item.Id
                };
                lv_item_list.Items.Add(listViewItem);
            }

            //Show combo list
            foreach (Combo combo in shoppingCart_Combo) {
                ListViewItem listViewItem = new ListViewItem(
                    new string[] {
                            "",
                            combo.GetQty().ToString(), //combo qty
                            String.Format("-{0:0.00}", combo.DiscountPrice()) //combo price
                    }) {
                    Tag = combo,
                    Text = combo.Name + String.Format(" @ {0:C}", combo.GetFinalPrice()),
                    Name = combo.Id,
                };

                lv_item_list.Items.Add(listViewItem);
            }
        }

        //計算價格
        private void CountPrice() {
            double subtotal = 0; //未折扣總額
            double discount = 0; //未折額
            double deposit = 0; //對於超過$5000的不可用商品, 20%訂金
            double Unavailable = 0; //不可用貨品所佔金額

            //計算單件貨品價格
            foreach (Item item in shoppingCart_Item) {
                subtotal += item.GetTotalPrice();
            }

            //計算折扣價
            foreach (Combo combo in shoppingCart_Combo) {
                discount += combo.DiscountPrice();
            }

            //計算不可用物品所佔金額
            foreach (KeyValuePair<Item, int> Unavailable_item in Unavailable_Item_Qty) {
                double this_Unavailable = Unavailable_item.Key.Price * Math.Abs(Unavailable_item.Value);
                if (Unavailable_item.Key.Price > 5000) {
                    deposit += this_Unavailable * 0.2; //大於5000, 20%訂金
                    Unavailable += this_Unavailable;
                }
            }

            total = subtotal - discount - received; //實付總額
            deposit = total - Unavailable + deposit; //20%訂金總額
            deposit = deposit < 0 ? total : deposit;

            tb_subtotal.Text = String.Format("{0:C}", subtotal);
            tb_discount.Text = String.Format("-{0:C}", discount);
            tb_total.Text = String.Format("{0:C}", total);
            tb_deposit.Text = String.Format("{0:C}", deposit);
        }

        private void tb_add_id_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) bt_add_id.PerformClick(); //Enter key
        }

        private void tb_add_name_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) bt_add_name.PerformClick(); //Enter key
        }

        private void tb_reshow_order_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) bt_reshow_order.PerformClick(); //Enter key
        }

        private void lv_item_list_SelectedIndexChanged(object sender, EventArgs e) {
            //選擇該物件, 顯示該物件詳情
            if (lv_item_list.SelectedItems.Count > 0) {
                Item item = lv_item_list.SelectedItems[0].Tag as Item;
                if (item != null) {
                    tb_item_name.Text = item.Name;
                    tb_item_price.Text = String.Format("{0:C}", item.Price);
                    tb_item_description.Text = item.Description;
                    chb_item_install.Checked = (item.Type == ItemType.Install || item.Type == ItemType.Large_and_install);
                    chb_item_large.Checked = (item.Type == ItemType.Large || item.Type == ItemType.Large_and_install);
                }
            }
        }
    }
}
