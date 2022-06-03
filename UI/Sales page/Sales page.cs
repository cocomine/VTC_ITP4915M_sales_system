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
        private MySqlConnection conn;
        private Account_Details acc;
        private Dictionary<string, Item> shoppingCart_Item = new Dictionary<string, Item>();
        private Dictionary<string, Combo> shoppingCart_Combo = new Dictionary<string, Combo>();
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
                data.Close();

                tb_add_name.AutoCompleteCustomSource = nameCol; //name
                tb_add_id.AutoCompleteCustomSource = idCol; //id
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
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

        private void bt_add_name_Click(object sender, EventArgs e) {
            Console.WriteLine("work");
            //add by name
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT ItemID, Name, Price, Type, Description FROM item WHERE Name = @name", conn);
                cmd.Parameters.AddWithValue("@name", tb_add_name.Text);
                MySqlDataReader data = cmd.ExecuteReader();

                while (data.Read()) {
                    Item item = new Item(data.GetString("ItemID"), data.GetString("Name"), data.GetDouble("Price"), data.GetInt32("Type"), null, data.IsDBNull(data.GetOrdinal("Description")) ? null : data.GetString("Description"), 1); //create item obj
                    if (shoppingCart_Item.ContainsKey(data.GetString("ItemID"))) {
                        //已經存在, 則增加數量
                        shoppingCart_Item[data.GetString("ItemID")].AddQty();
                    } else {
                        //不存在, 則加入購物車
                        shoppingCart_Item.Add(data.GetString("ItemID"), item); //add in shopping cart
                    }
                    Console.WriteLine(data.GetString("ItemID"));
                }
                data.Close();

                tb_add_name.Text = "";
                checkCombo();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        private void checkCombo() {
            //Debug
            Console.WriteLine("before:");
            foreach (Item item in shoppingCart_Item.Values) {
                Console.WriteLine(item);
            }
            foreach (Combo combo in shoppingCart_Combo.Values) {
                Console.WriteLine(combo);
            }

            //check in shopping cart have item match combo
            try {
                //取得現在item相符的套裝id
                MySqlCommand cmd = new MySqlCommand("SELECT ComboID, COUNT(ItemID) AS 'Count' FROM combo_item WHERE ItemID IN('" + String.Join("','", shoppingCart_Item.Keys) + "') GROUP BY ComboID;", conn);
                MySqlDataReader data = cmd.ExecuteReader();

                Dictionary<string, int> dic = new Dictionary<string, int>();
                if (data.HasRows) {
                    while (data.Read()) {
                        dic.Add(data.GetString("ComboID"), data.GetInt32("Count")); //add the Dictionary
                        //Console.WriteLine(data.GetString("ComboID") + " " + data.GetInt32("Count"));
                    }
                }
                //close up
                data.Close();
                cmd.Dispose();

                if (dic.Count > 0) {
                    foreach (KeyValuePair<string, int> item_count in dic) {
                        //檢查是否符合套裝要求
                        cmd = new MySqlCommand("SELECT * FROM combo WHERE ComboID = @ComboID AND @count = (SELECT COUNT(ItemID) FROM combo_item WHERE ComboID = @ComboID);", conn);
                        cmd.Parameters.AddWithValue("@ComboID", item_count.Key);
                        cmd.Parameters.AddWithValue("@count", item_count.Value);
                        data = cmd.ExecuteReader();

                        if (!data.HasRows) {
                            data.Close();
                            continue;
                        }
                        //符合要求
                        while (data.Read()) {
                            //Create combo obj
                            Combo combo = new Combo(data.GetString("ComboID"), data.GetString("Name"), data.GetDouble("Price"), data.IsDBNull(data.GetOrdinal("Description")) ? null : data.GetString("Description"));

                            //close up
                            data.Close();
                            cmd.Dispose();

                            //取得套裝中包含的物品id
                            cmd = new MySqlCommand("SELECT * FROM combo_item WHERE ComboID = @ComboID", conn);
                            cmd.Parameters.AddWithValue("@ComboID", combo.Id);
                            data = cmd.ExecuteReader();

                            while (data.Read()) {
                                Item item = shoppingCart_Item[data.GetString("ItemID")]; //取得item obj

                                //放入套裝
                                if (shoppingCart_Combo.ContainsKey(combo.Id)) {
                                    shoppingCart_Combo[combo.Id].AddItem(item); //已存在的套裝直接加入item obj
                                } else {
                                    combo.AddItem(item);
                                    shoppingCart_Combo.Add(combo.Id, combo); //不存在的加入combo obj
                                }

                                //如果物品數量歸零則刪除
                                if (item.Qty <= 0) {
                                    shoppingCart_Item.Remove(item.Id);
                                }
                            }
                            data.Close();
                        }
                    }
                }
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //Debug
            Console.WriteLine("after:");
            foreach (Item item in shoppingCart_Item.Values) {
                Console.WriteLine(item);
            }
            foreach (Combo combo in shoppingCart_Combo.Values) {
                Console.WriteLine(combo);
            }

            ShowList();
        }

        private void ShowList() {
            lv_item_list.Items.Clear();
            lv_item_list.Groups.Clear();

            //Show combo list
            foreach (Combo combo in shoppingCart_Combo.Values) {

                //item row
                ListViewGroup listViewGroup = new ListViewGroup() {
                    Tag = combo,
                    Header = combo.Name + " @ $" + combo.GetFinalPrice() + " (-$" + combo.DiscountPrice() + ")",
                    Name = combo.Id,
                };
                lv_item_list.Groups.Add(listViewGroup);

                //Show in combo item list
                foreach (Item item in combo.GetItemsList()) {

                    //item row
                    ListViewItem listViewItem = new ListViewItem(
                        new string[] {
                            "",
                            item.Qty.ToString(), //item qty
                            item.GetTotalPrice().ToString() //item price
                        }) {
                        Tag = item,
                        Text = item.Name,
                        Name = item.Id,
                        Group = listViewGroup
                    };

                    lv_item_list.Items.Add(listViewItem);
                }
            }

            //show Item list
            ListViewGroup defaultGroup = new ListViewGroup() { Header = "Other items" };
            lv_item_list.Groups.Add(defaultGroup);
            foreach (Item item in shoppingCart_Item.Values) {
                ListViewItem listViewItem = new ListViewItem(
                    new string[] {
                        "",
                        item.Qty.ToString(), //item qty
                        item.GetTotalPrice().ToString() //item price
                    }) {
                    Tag = item,
                    Text = item.Name,
                    Name = item.Id,
                    Group = defaultGroup,
                };
                lv_item_list.Items.Add(listViewItem);
            }
        }

        private void bt_add_id_Click(object sender, EventArgs e) {
            //add by id
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT ItemID, Name, Price, Type, Description FROM item WHERE ItemID = @id", conn);
                cmd.Parameters.AddWithValue("@id", tb_add_id.Text);
                MySqlDataReader data = cmd.ExecuteReader();

                while (data.Read()) {
                    Item item = new Item(data.GetString("ItemID"), data.GetString("Name"), data.GetDouble("Price"), data.GetInt32("Type"), null, data.IsDBNull(data.GetOrdinal("Description")) ? null : data.GetString("Description"), 1); ; //create item obj
                    if (shoppingCart_Item.ContainsKey(data.GetString("ItemID"))) {
                        //已經存在, 則增加數量
                        shoppingCart_Item[data.GetString("ItemID")].AddQty();
                    } else {
                        //不存在, 則加入購物車
                        shoppingCart_Item.Add(data.GetString("ItemID"), item); //add in shopping cart
                    }
                }
                data.Close();

                tb_add_id.Text = "";
                checkCombo();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }
    }
}
