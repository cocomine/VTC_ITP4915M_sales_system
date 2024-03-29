﻿using iText.Html2pdf;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using ITP4915M.API;
using ITP4915M.Properties;
using ITP4915M.Sales_page;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace UI.Sales_page {
    public partial class Sales_Page : Form {
        private string StoreID; //商店id
        private MySqlConnection conn;
        private Account_Details acc;
        private List<Item> shoppingCart_Item = new List<Item>(); //購物車內的物品
        private List<Combo> shoppingCart_Combo = new List<Combo>(); //符合的套裝折扣
        private Dictionary<Item, int> Unavailable_Item_Qty = new Dictionary<Item, int>(); //庫存不足物品, 會儲存尚欠多少件
        private double received = 0; //已收取金額
        private double total = 0; //需付金額
        private string orderID = null; //訂單id
        private bool need_delivery = false; //是否需要送貨
        private bool need_install = false; //是否需要安裝
        private bool isCancel = false;
        private Lang lang;

        public Sales_Page(MySqlConnection conn, Account_Details acc) {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
            lang = new Lang(typeof(Sales_Page));
        }

        private void Sales_Page_Load(object sender, EventArgs e) {
            Program.addPage();

            //AutoComplete setup
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT Name, ItemID FROM item;", conn);
                MySqlDataReader data = cmd.ExecuteReader(); //start up async

                AutoCompleteStringCollection nameCol = new AutoCompleteStringCollection(); //name AutoComplete list
                AutoCompleteStringCollection idCol = new AutoCompleteStringCollection(); //id AutoComplete list
                while (data.Read()) {
                    nameCol.Add(data.GetString("Name"));
                    idCol.Add(data.GetString("ItemID"));
                }

                data.Close(); //close up
                cmd.Dispose(); //close up

                tb_add_name.AutoCompleteCustomSource = nameCol; //set add by name
                tb_add_id.AutoCompleteCustomSource = idCol; //set add by code
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //Get staff Responsible store
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT StoreID FROM sales_staff_store WHERE StaffAccountID = @id", conn);
                cmd.Parameters.AddWithValue("@id", acc.Get_acoountID());
                MySqlDataReader data = cmd.ExecuteReader();
                if (data.HasRows) {
                    while (data.Read()) {
                        StoreID = data.GetString("StoreID");
                        Text += lang.GetString("__Store__") + StoreID + ")";
                    }
                } else {
                    MessageBox.Show(lang.GetString("The_employee_is_not_assigned_to_any_store"), lang.GetString("Not_assigned"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }

                data.Close(); //close up
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            Console.WriteLine(StoreID);
        }

        private void Sales_Page_FormClosed(object sender, FormClosedEventArgs e) { Program.removePage(); }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) { Program.Logout(); }

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
            if (!data.HasRows) {
                //檢查是否存在
                //不存在
                MessageBox.Show(lang.GetString("The_item_does_not_exist"), lang.GetString("Not_exist"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                int Unavailable_qty = data.GetInt32("Qty") < 0 ? -item.Qty : data.GetInt32("Qty") - item.Qty; //如果庫存係0直接入負數, 否則的話計算尚欠多少件
                if (Unavailable_qty < 0) {
                    Unavailable_qty = Math.Abs(Unavailable_qty);
                    if (Unavailable_Item_Qty.ContainsKey(item)) Unavailable_Item_Qty[item] = Unavailable_qty;
                    else Unavailable_Item_Qty.Add(item, Unavailable_qty);

                    MessageBox.Show(lang.GetString("Please_note_that_the_item_is_out_of_stock_"), lang.GetString("Out_of_stock"), MessageBoxButtons.OK, MessageBoxIcon.Warning); //物品庫存不足
                }

                //展示物品詳細
                tb_item_name.Text = item.Name;
                tb_item_price.Text = $@"{item.Price:C}";
                tb_item_description.Text = item.Description;
                chb_item_install.Checked = item.Type == ItemType.Install || item.Type == ItemType.Large_and_install;
                chb_item_large.Checked = item.Type == ItemType.Large || item.Type == ItemType.Large_and_install;
            }
        }

        //檢查套裝
        private void checkCombo() {
            shoppingCart_Combo.Clear();

            //check in shopping cart have item match combo
            List<string> items_id_list = new List<string>();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (Item item in shoppingCart_Item) {
                items_id_list.Add(item.Id);
            }

            try {
                //取得現在item相符的套裝id
                MySqlCommand cmd = new MySqlCommand("SELECT ComboID, COUNT(ItemID) AS 'Count' FROM combo_item WHERE ItemID IN('" + string.Join("','", items_id_list) + "') GROUP BY ComboID;", conn);
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
                    if (data.GetInt32("count") == item_count.Value) //符合要求
                    {
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
                            if (ls == null) combo.AddItem(item); //不存在
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
                ListViewItem listViewItem = new ListViewItem(new string[] {
                    "", item.Qty.ToString(), //item qty
                    $"{item.GetTotalPrice():0.00}" //item price
                }) { Tag = item, Text = item.Name, Name = item.Id };
                lv_item_list.Items.Add(listViewItem);
            }

            //Show combo list
            foreach (Combo combo in shoppingCart_Combo) {
                ListViewItem listViewItem = new ListViewItem(new string[] {
                    "", combo.GetQty().ToString(), //combo qty
                    $"-{combo.DiscountPrice():0.00}" //combo price
                }) { Tag = combo, Text = combo.Name + $@" @ {combo.GetFinalPrice():C}", Name = combo.Id };

                lv_item_list.Items.Add(listViewItem);
            }
        }

        //計算價格
        private Dictionary<string, double> CountPrice() {
            double subtotal = 0; //未折扣總額
            double discount = 0; //未折額
            double deposit = 0; //對於超過$5000的不可用商品, 20%訂金
            double Unavailable = 0; //不可用貨品所佔金額

            //計算單件貨品價格
            foreach (Item item in shoppingCart_Item) {
                subtotal += item.GetTotalPrice();

                //取得貨件是否需要安裝或運送
                if (item.Type == ItemType.Install || item.Type == ItemType.Large_and_install) need_install = true;
                if (item.Type == ItemType.Large || item.Type == ItemType.Large_and_install) need_delivery = true;
            }

            //計算折扣價
            foreach (Combo combo in shoppingCart_Combo) {
                discount += combo.DiscountPrice();
            }

            //計算不可用物品所佔金額
            foreach (KeyValuePair<Item, int> Unavailable_item in Unavailable_Item_Qty) {
                double this_Unavailable = Unavailable_item.Key.Price * Unavailable_item.Value;
                if (Unavailable_item.Key.Price > 5000) {
                    deposit += this_Unavailable * 0.2; //大於5000, 20%訂金
                    Unavailable += this_Unavailable;
                }

                Console.WriteLine(Unavailable_item.Value);
            }

            total = subtotal - discount - received; //實付總額
            //Console.WriteLine(deposit);
            deposit = subtotal - Unavailable + deposit; //20%訂金總額
            //Console.WriteLine(deposit);
            //Console.WriteLine(subtotal);
            //Console.WriteLine(Unavailable);
            deposit = deposit >= total ? total : deposit;

            tb_subtotal.Text = $@"{subtotal:C}";
            tb_discount.Text = $@"-{discount:C}";
            tb_total.Text = $@"{total:C}";
            tb_deposit.Text = $@"{deposit:C}";
            tb_reveived.Text = $@"-{received:C}";

            return new Dictionary<string, double>() { { "subtotal", subtotal }, { "discount", discount }, { "deposit", deposit } }; //return same data
        }

        //Enter key
        private void tb_add_id_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) bt_add_id.PerformClick(); //Enter key
        }

        private void tb_add_name_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) bt_add_name.PerformClick(); //Enter key
        }

        private void tb_reshow_order_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) bt_reshow_order.PerformClick(); //Enter key
        }

        private void lv_item_list_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Delete) bt_remove_item.PerformClick(); //Del key
        }

        //選擇該物件, 顯示該物件詳情
        private void lv_item_list_SelectedIndexChanged(object sender, EventArgs e) {
            if (lv_item_list.SelectedItems.Count > 0) {
                Item item = lv_item_list.SelectedItems[0].Tag as Item;
                if (item != null) {
                    tb_item_name.Text = item.Name;
                    tb_item_price.Text = $@"{item.Price:C}";
                    tb_item_description.Text = item.Description;
                    chb_item_install.Checked = item.Type == ItemType.Install || item.Type == ItemType.Large_and_install;
                    chb_item_large.Checked = item.Type == ItemType.Large || item.Type == ItemType.Large_and_install;
                }
            }
        }

        //save order btn click
        private void bt_save_Click(object sender, EventArgs e) {
            string orderID = saveOrder(this.orderID);
            if (orderID != null) {
                this.orderID = orderID;
                lb_orderID.Text = lang.GetString("Order_ID__") + orderID;
                lb_orderID.Visible = true;
            }
        }

        //save order
        private string saveOrder(string orderID = null) {
            //檢查有沒有物品
            if (shoppingCart_Item.Count <= 0) {
                MessageBox.Show(lang.GetString("There_are_no_items_in_the_shopping_cart_"), lang.GetString("No_item"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            //訂單資訊
            try {
                if (orderID == null) {
                    //有沒有訂單id
                    //建立新的訂單紀錄, 並且取得訂單id
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `order` (Payment_Method, Charge, Status, DateTime) VALUES (2, 0, 1, @datetime); SELECT LAST_INSERT_ID() AS OrderID;", conn);
                    cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read()) {
                        orderID = reader.GetString("OrderID");
                    }

                    reader.Close();
                } else {
                    //更新訂單紀錄
                    MySqlCommand cmd = new MySqlCommand("UPDATE `order` SET Status = 1, DateTime = @datetime WHERE OrderID = @OrderID", conn);
                    cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@OrderID", orderID);

                    //沒有符合訂單
                    if (cmd.ExecuteNonQuery() <= 0) return saveOrder(); //沒有訂單id形式運行
                }
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //將物品寫入數據庫
            try {
                //寫入前先清除數據
                MySqlCommand cmd = new MySqlCommand("DELETE FROM order_item WHERE OrderID = @OrderID;", conn);
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand("INSERT INTO order_item (OrderID, ItemID, Qty, Purchase_price) VALUES (@OrderID, @ItemID, @Qty, @Purchase_price)", conn);
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                cmd.Parameters.AddWithValue("@ItemID", "");
                cmd.Parameters.AddWithValue("@Qty", 0);
                cmd.Parameters.AddWithValue("@Purchase_price", 0.0);

                //逐件貨品寫入
                foreach (Item item in shoppingCart_Item) {
                    cmd.Parameters["@ItemID"].Value = item.Id;
                    cmd.Parameters["@Qty"].Value = item.Qty;
                    cmd.Parameters["@Purchase_price"].Value = item.Price;
                    cmd.ExecuteNonQuery();
                }
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //將套裝折扣寫入數據庫
            try {
                //寫入前先清除數據
                MySqlCommand cmd = new MySqlCommand("DELETE FROM order_combo WHERE OrderID = @OrderID", conn);
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                cmd.ExecuteNonQuery();

                cmd = new MySqlCommand("INSERT INTO order_combo (OrderID, ComboID, Purchase_price) VALUES (@OrderID, @ComboID, @Purchase_price)", conn);
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                cmd.Parameters.AddWithValue("@ComboID", "");
                cmd.Parameters.AddWithValue("@Purchase_price", 0.0);

                //逐件套裝寫入
                foreach (Combo combo in shoppingCart_Combo) {
                    cmd.Parameters["@ComboID"].Value = combo.Id;
                    cmd.Parameters["@Purchase_price"].Value = combo.Price;
                    cmd.ExecuteNonQuery();
                }
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //return order id
            MessageBox.Show(lang.GetString("Order_saved_") + orderID, lang.GetString("Order_saved"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            lb_save.Visible = true;
            return orderID;
        }

        //e-payment pay
        private void bt_epay_Click(object sender, EventArgs e) {
            //檢查是否numbers
            double charge = 0;
            try {
                charge = double.Parse(tb_charge.Text);
            } catch (Exception) {
                MessageBox.Show(lang.GetString("Only_numbers_are_accepted_"), lang.GetString("Wrong_format"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (charge > total) charge = total; //如果大於總數, 則直接改為總數
            checkout(charge, 1); //checkout e-payment pay
        }

        //reshow order
        private void bt_reshow_order_Click(object sender, EventArgs e) {
            int Status = 0;
            int Payment_Method = 0;
            string orderID = tb_reshow_order.Text;
            reset_All(); //reaet all


            //get order info
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT OrderID, Charge, Status, Payment_Method FROM `order` WHERE OrderID = @id", conn);
                cmd.Parameters.AddWithValue("@id", orderID);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        received = reader.GetDouble("Charge");
                        Status = reader.GetInt32("Status");
                        Payment_Method = reader.GetInt32("Payment_Method");
                        orderID = reader.GetString("OrderID");
                    }
                } else {
                    //沒有符合訂單
                    MessageBox.Show(lang.GetString("There_are_no_matching_order_"), lang.GetString("No_match_order"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reader.Close();
                    return;
                }

                reader.Close();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //get order item
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT o.ItemID, o.Qty, o.Purchase_price, i.Name, i.Price, i.Type, i.Description, t.Qty AS `Stocks` FROM order_item o, item i, inventory t "
                                                    + "WHERE o.ItemID = i.ItemID AND i.ItemID = t.ItemID AND o.OrderID = @id AND t.StoreWarehouseID = @StoreID;", conn);
                cmd.Parameters.AddWithValue("@id", orderID);
                cmd.Parameters.AddWithValue("@StoreID", StoreID);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        //create item obj
                        Item item = new Item(reader.GetString("ItemID"), reader.GetString("Name"), Payment_Method == 2 ? reader.GetDouble("Price") : reader.GetDouble("Purchase_price"), //如果訂單尚未付款則使用物品價格, 否則使用下單時的價格
                            reader.GetInt32("Type"), null, reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString("Description"), //如果description為null則輸入null
                            reader.GetInt32("Qty"));

                        shoppingCart_Item.Add(item); //add to shopping cart

                        //check stocks
                        int Unavailable_qty = reader.GetInt32("Stocks") < 0 ? -item.Qty : reader.GetInt32("Stocks") - item.Qty; //如果庫存係0直接入負數, 否則的話計算尚欠多少件
                        if (Unavailable_qty < 0) {
                            Unavailable_qty = Math.Abs(Unavailable_qty);
                            if (Unavailable_Item_Qty.ContainsKey(item)) Unavailable_Item_Qty[item] = Unavailable_qty;
                            else Unavailable_Item_Qty.Add(item, Unavailable_qty);
                        }
                    }
                }

                reader.Close();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //get order combo
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT o.ComboID, o.Purchase_price, c.Name, c.Price, c.Description FROM order_combo o, combo c WHERE o.ComboID = c.ComboID AND o.OrderID = @id", conn);
                cmd.Parameters.AddWithValue("@id", orderID);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        //create item obj
                        Combo combo = new Combo(reader.GetString("ComboID"), reader.GetString("Name"), Payment_Method == 2 ? reader.GetDouble("Price") : reader.GetDouble("Purchase_price"), //如果訂單尚未付款則使用物品價格, 否則使用下單時的價格
                            reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString("Description")); //如果description為null則輸入null

                        shoppingCart_Combo.Add(combo); //add to combo shopping cart
                    }
                }

                reader.Close();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //get combo item
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT ItemID FROM combo_item WHERE ComboID = @id", conn);
                cmd.Parameters.AddWithValue("@id", "");
                foreach (Combo combo in shoppingCart_Combo) {
                    cmd.Parameters["@id"].Value = combo.Id;
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows) {
                        while (reader.Read()) {
                            combo.AddItem(shoppingCart_Item.Find(x => x.Id == reader.GetString("ItemID"))); //Add item to combo
                        }
                    }

                    reader.Close();
                }
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //UI update
            ShowList();
            Dictionary<string, double> totalPriceData = CountPrice();
            lb_orderID.Text = lang.GetString("Order_ID__") + orderID;
            lb_orderID.Visible = true;
            this.orderID = orderID;

            //set controls
            if (received >= totalPriceData["subtotal"] - totalPriceData["discount"]) {
                //is paid
                bt_cash.Enabled = false;
                bt_epay.Enabled = false;
                bt_add_id.Enabled = false;
                bt_add_name.Enabled = false;
                lb_paid.Visible = true;
                tb_change.Enabled = false;
                tb_add_id.Enabled = false;
                tb_add_name.Enabled = false;
                bt_save.Enabled = false;
                bt_remove_item.Enabled = false;
            }else
            if (Unavailable_Item_Qty.Count > 0 && !(Status == 5 || Status == 6)) {
                //have item out of stock
                MessageBox.Show(lang.GetString("Please_note_that_have_items_is_out_of_stock_"), lang.GetString("Out_of_stock"), MessageBoxButtons.OK, MessageBoxIcon.Warning); //物品庫存不足
            }

            //if is cancel
            Console.WriteLine(Status);
            if (Status == 5 || Status == 6) {
                bt_cash.Enabled = false;
                bt_epay.Enabled = false;
                bt_add_id.Enabled = false;
                bt_add_name.Enabled = false;
                lb_cancel.Visible = true;
                tb_change.Enabled = false;
                tb_add_id.Enabled = false;
                tb_add_name.Enabled = false;
                isCancel = true;
                bt_save.Enabled = false;
                bt_remove_item.Enabled = false;
            }
        }

        //cash pay
        private void bt_cash_Click(object sender, EventArgs e) {
            //檢查是否numbers
            double charge = 0;
            try {
                charge = double.Parse(tb_charge.Text);
            } catch (Exception) {
                MessageBox.Show(lang.GetString("Only_numbers_are_accepted_"), lang.GetString("Wrong_format"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            checkout(charge, 0); //checkout cash
        }

        //結帳
        private void checkout(double charge, int payment_Method) {
            //金額必須大於零
            if (charge <= 0) {
                MessageBox.Show(lang.GetString("Please_enter_the_amount"), lang.GetString("CheckOut"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //save order first
            string orderID = saveOrder(this.orderID);
            if (orderID == null) return; //儲存失敗
            this.orderID = orderID;
            //show orderid
            lb_orderID.Text = lang.GetString("Order_ID__") + orderID;
            lb_orderID.Visible = true;

            //檢查是否輸入個客戶資訊
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT (SELECT IF(COUNT(*) > 0, true, false) FROM delivery d WHERE d.OrderID = @OrderID) AS delivery," + "(SELECT IF(COUNT(*) > 0, true, false) FROM installation i WHERE i.OrderID = @OrderID) AS installation;", conn);
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    if (reader.GetBoolean("delivery")) need_delivery = false;
                    if (reader.GetBoolean("installation")) need_install = false;
                }

                reader.Close();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //需要送貨及安裝, 要求輸入客戶資訊
            Customer_info Customer_info_form = new Customer_info(conn);
            if (need_delivery || need_install) {
                DialogResult result = Customer_info_form.ShowDialog();
                if (result != DialogResult.OK) return; //取消輸入 => 取消付款流程
            }

            string CustomerID = Customer_info_form.CustomerID; //get CustomerID

            DateTime delivery_DateTime = DateTime.Now; //先定義時間
            //需要送貨, 添加記錄
            if (need_delivery) {
                //open input form
                Delivery_time_select form = new Delivery_time_select();
                DialogResult result = form.ShowDialog();
                if (result != DialogResult.OK) return; //取消輸入 => 取消付款流程

                DateTime date = form.Date; //get 日期
                delivery_DateTime = date; //set 給安裝時間選擇頁面用
                int Time = form.Time; //get 時段

                //新增記錄
                try {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `delivery` (`OrderID`, `Delivery_TeamID`, `CustomerID`, `Session`, `Status`, `Delivery_date`) " + "VALUES (@OrderID, NULL, @CustomerID, @Session, 0, @Delivery_date)", conn);
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    cmd.Parameters.AddWithValue("@Session", Time);
                    cmd.Parameters.AddWithValue("@Delivery_date", date.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                } catch (MySqlException ex) {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }
            }

            //需要安裝, 添加記錄
            if (need_install) {
                //open input form
                Install_time_select form = new Install_time_select(delivery_DateTime); //如果需要送貨, 則在送貨日期後3日才可以選擇
                DialogResult result = form.ShowDialog();
                if (result != DialogResult.OK) return; //取消輸入 => 取消付款流程

                DateTime dateTime = form.DateTime; //get 日期

                //新增記錄
                try {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `installation` (`OrderID`, `CustomerID`, `Status`, `install_date`) " + "VALUES (@OrderID, @CustomerID, 0, @install_date)", conn);
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    cmd.Parameters.AddWithValue("@install_date", dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                } catch (MySqlException ex) {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }
            }

            Dictionary<string, double> totalPriceData = CountPrice();
            double change = charge - total; //找錢
            if (change >= 0) {
                //全額付款
                tb_change.Text = $@"{change:C}";
                bt_cash.Enabled = false;
                bt_epay.Enabled = false;
                bt_add_id.Enabled = false;
                bt_add_name.Enabled = false;
                lb_paid.Visible = true;
                tb_change.Enabled = false;
                tb_add_id.Enabled = false;
                tb_add_name.Enabled = false;
                bt_remove_item.Enabled = false;
            } else {
                //非全額付款
                tb_change.Text = $@"{0:C}";
            }

            //更新訂單紀錄
            try {
                MySqlCommand cmd = new MySqlCommand("UPDATE `order` SET Status = @Status, Charge = @Charge, finalTotal = @finalTotal, Payment_Method = @Payment_Method, DateTime = @datetime WHERE OrderID = @OrderID", conn);
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@Status", change >= 0 ? 2 : 7); //2:completed 7:款項未完全交付
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                cmd.Parameters.AddWithValue("@Charge", charge + received);
                cmd.Parameters.AddWithValue("@finalTotal", totalPriceData["subtotal"] - totalPriceData["discount"]);
                cmd.Parameters.AddWithValue("@Payment_Method", payment_Method);
                cmd.ExecuteNonQuery();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //更新庫存
            if (received <= 0) //沒有收錢才更新庫存
            {
                try {
                    MySqlCommand cmd = new MySqlCommand("UPDATE inventory SET Qty = (Qty - @Qty) WHERE ItemID = @ItemID AND StoreWarehouseID = @StoreID", conn);
                    cmd.Parameters.AddWithValue("@StoreID", StoreID);
                    cmd.Parameters.AddWithValue("@ItemID", "");
                    cmd.Parameters.AddWithValue("@Qty", 0);
                    shoppingCart_Item.ForEach(item => {
                        cmd.Parameters["@ItemID"].Value = item.Id;
                        cmd.Parameters["@Qty"].Value = item.Qty;
                        cmd.ExecuteNonQuery();
                    });
                } catch (MySqlException ex) {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }
            }
        }

        //remove item
        private void bt_remove_item_Click(object sender, EventArgs e) {
            foreach (ListViewItem x in lv_item_list.SelectedItems) {
                Item item = x.Tag as Item;
                if (item != null) {
                    shoppingCart_Item.Remove(item);
                    if (Unavailable_Item_Qty.ContainsKey(item)) Unavailable_Item_Qty.Remove(item);
                }
            }

            checkCombo();
            ShowList();
            CountPrice();
        }

        //重置
        private void bt_reset_Click(object sender, EventArgs e) { reset_All(); }

        //重置表單
        private void reset_All() {
            //clear up shopping list
            shoppingCart_Combo.Clear();
            shoppingCart_Item.Clear();
            Unavailable_Item_Qty.Clear();

            //reset control
            lv_item_list.Items.Clear();
            tb_item_description.Clear();
            chb_item_install.Checked = false;
            chb_item_large.Checked = false;
            lb_orderID.Visible = false;
            lb_paid.Visible = false;
            lb_save.Visible = false;
            lb_cancel.Visible = false;
            bt_cash.Enabled = true;
            bt_epay.Enabled = true;
            bt_add_id.Enabled = true;
            bt_add_name.Enabled = true;
            tb_change.Enabled = true;
            tb_add_id.Enabled = true;
            tb_add_name.Enabled = true;
            bt_remove_item.Enabled = true;

            //clear all textbox
            List<TextBox> AllTextBox = new List<TextBox>();
            AllTextBox = findAllTextBox(AllTextBox, this);
            AllTextBox.ForEach(x => x.Text = "");

            //reset variable
            orderID = null;
            total = 0;
            received = 0;
            need_delivery = false;
            need_install = false;
        }

        //在control中尋找所有text box
        private List<TextBox> findAllTextBox(List<TextBox> list, Control parent) {
            foreach (Control control in parent.Controls) {
                if (control is TextBox box) list.Add(box);
                if (control is Panel) findAllTextBox(list, control);
                if (control is GroupBox) findAllTextBox(list, control);
            }

            return list;
        }

        //打印收據pdf
        private void bt_receipt_Click(object sender, EventArgs e) {
            //save order first
            //string orderID = saveOrder(this.orderID);
            if (orderID == null) return; //儲存失敗

            Dictionary<string, double> totalPriceData = CountPrice();
            string html = Resources.Receipt;

            //取得資料 order info
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT Payment_Method, Charge, DateTime FROM `order` WHERE OrderID = @id", conn);
                cmd.Parameters.AddWithValue("@id", orderID);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    //order status
                    html = html.Replace("%paid_status%", reader.GetDouble("Charge") >= totalPriceData["subtotal"] - totalPriceData["discount"] ? "<div id=\"paid\" class=\"tag\">PAID</div>" : "<div id=\"unpaid\" class=\"tag\">UNPAID</div> ");

                    //order detail
                    html = html.Replace("%order_id%", orderID);
                    html = html.Replace("%receipt_date%", DateTime.Now.ToString("yyyy-MM-dd"));
                    html = html.Replace("%payment_date%", reader.GetDateTime("DateTime").ToString("yyyy-MM-dd HH:mm:ss"));
                    html = html.Replace("%payment_method%", reader.GetInt32("Payment_Method") == 0 ? "Cash" : reader.GetInt32("Payment_Method") == 1 ? "E-payment" : "N/A");

                    //取得資料 paid info
                    double change = reader.GetDouble("Charge") - (totalPriceData["subtotal"] - totalPriceData["discount"]);
                    html = html.Replace("%change%", change <= 0 ? $@"{0:C}" : $"{change:C}");
                    html = html.Replace("%arrears%", change <= 0 ? $"{Math.Abs(change):C}" : $@"{0:C}");
                    html = html.Replace("%paid%", $"{reader.GetDouble("Charge"):C}");
                }

                reader.Close();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //取得資料 customer info
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT c.Phone, c.Customer_name, c.Address FROM customer c, installation i, delivery d WHERE i.CustomerID = c.CustomerID AND d.CustomerID = c.CustomerID AND (d.OrderID = @id OR i.OrderID = @id)", conn);
                cmd.Parameters.AddWithValue("@id", orderID);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        html = html.Replace("%customer_name%", reader.GetString("Customer_name"));
                        html = html.Replace("%customer_address%", reader.GetString("Address"));
                        html = html.Replace("%customer_phone%", reader.GetString("Phone"));
                    }
                } else {
                    html = html.Replace("%customer_name%", "- No Data -");
                    html = html.Replace("%customer_address%", "");
                    html = html.Replace("%customer_phone%", "");
                }

                reader.Close();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //取得資料 item & combo info
            string items = "";
            shoppingCart_Item.ForEach(item => {
                items += $"<tr><td> {item.Name} </td ><td > {item.Qty} </td><td> {item.Price:C} </td ></tr>";
            });
            shoppingCart_Combo.ForEach(combo => {
                items += $"<tr><td> {combo.Name} </td ><td > {combo.GetQty()} </td><td> -{combo.DiscountPrice():C} </td ></tr>";
            });
            html = html.Replace("%items%", items);

            //取得資料 total price
            html = html.Replace("%subtotal%", $"{totalPriceData["subtotal"]:C}");
            html = html.Replace("%discount%", $"-{totalPriceData["discount"]:C}");
            html = html.Replace("%total%", $"{totalPriceData["subtotal"] - totalPriceData["discount"]:C}");

            //cancel status
            if (isCancel) {
                html = html.Replace("%cancel%", "<div id=\"cancel\">CANCEL</div>");
            }

            //save as pdf
            SavePdf.Save(html, DateTime.Now.ToString("yyyy-MM-dd")+"_"+orderID);
        }
    }
}