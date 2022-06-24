using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITP4915M.API;
using MySql.Data.MySqlClient;
using UI;

namespace ITP4915M.Sales_page {
    public partial class Cancel_Order : Form {
        private MySqlConnection conn;
        private Account_Details acc;
        private string orderID;
        private double total;
        private double received;
        private Lang lang;

        public Cancel_Order(MySqlConnection conn, Account_Details acc) {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
            lang = new Lang(typeof(Cancel_Order));
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) { Program.Logout(); }

        private void Cancel_Order_Load(object sender, EventArgs e) { Program.addPage(); }

        private void Cancel_Order_FormClosed(object sender, FormClosedEventArgs e) { Program.removePage(); }

        //show the order
        private void bt_show_Click(object sender, EventArgs e) {
            string orderID = tb_orderID.Text;
            int status = 0;
            int payment_Method = 0;
            double subtotal = 0;
            double discount = 0;
            double received = 0;
            double total = 0;
            List<Item> items = new List<Item>();
            List<Combo> combos = new List<Combo>();

            //檢查是否輸入
            if (string.IsNullOrEmpty(orderID)) {
                errorProvider1.SetError(tb_orderID, lang.GetString("Order_id_is_required_"));
                return;
            }

            //get order info
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT OrderID, Charge, Status, Payment_Method FROM `order` WHERE OrderID = @id", conn);
                cmd.Parameters.AddWithValue("@id", orderID);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        received = reader.GetDouble("Charge");
                        status = reader.GetInt32("Status");
                        payment_Method = reader.GetInt32("Payment_Method");
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
                MySqlCommand cmd = new MySqlCommand("SELECT o.ItemID, o.Qty, o.Purchase_price, i.Name, i.Price FROM order_item o, item i " + "WHERE o.ItemID = i.ItemID AND o.OrderID = @id;", conn);
                cmd.Parameters.AddWithValue("@id", orderID);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        //create item obj
                        Item item = new Item(reader.GetString("ItemID"), reader.GetString("Name"), payment_Method == 2 ? reader.GetDouble("Price") : reader.GetDouble("Purchase_price"), //如果訂單尚未付款則使用物品價格, 否則使用下單時的價格
                            0, null, null, reader.GetInt32("Qty"));

                        items.Add(item); //add to list
                    }
                }

                reader.Close();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //get order combo
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT o.ComboID, o.Purchase_price, c.Price FROM order_combo o, combo c WHERE o.ComboID = c.ComboID AND o.OrderID = @id", conn);
                cmd.Parameters.AddWithValue("@id", orderID);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        //create item obj
                        Combo combo = new Combo(reader.GetString("ComboID"), null, payment_Method == 2 ? reader.GetDouble("Price") : reader.GetDouble("Purchase_price"), //如果訂單尚未付款則使用物品價格, 否則使用下單時的價格
                            null);

                        combos.Add(combo); //add to combo shopping cart
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
                foreach (Combo combo in combos) {
                    cmd.Parameters["@id"].Value = combo.Id;
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows) {
                        while (reader.Read()) {
                            combo.AddItem(items.Find(x => x.Id == reader.GetString("ItemID"))); //Add item to combo
                        }
                    }

                    reader.Close();
                }
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //計算價格
            //計算單件貨品價格
            foreach (Item item in items) {
                subtotal += item.GetTotalPrice();
            }

            //計算折扣價
            foreach (Combo combo in combos) {
                discount += combo.DiscountPrice();
            }

            //計算總價
            total = subtotal - discount;

            //set var
            this.received = received;
            this.orderID = orderID;
            this.total = total;

            //reset controls
            list_items.Items.Clear();
            bt_cancel.Enabled = true;
            bt_refund.Enabled = true;
            lb_cancel.Visible = false;
            lb_refund.Visible = false;
            lb_unpaid.Visible = false;
            tb_refund.Text = "";

            //UI update
            //item list view
            foreach (Item item in items) {
                ListViewItem listViewItem = new ListViewItem(new string[] {
                    "", item.Qty.ToString() //item qty
                }) { Text = item.Name, Name = item.Id};
                list_items.Items.Add(listViewItem);
            }

            //amount text box
            tb_received.Text = $@"{received:C}";
            tb_total.Text = $@"{total:C}";
            tb_subtotal.Text = $@"{subtotal:C}";

            //set controls status
            if (payment_Method == 2) {
                //just save order
                bt_refund.Enabled = false;
                lb_unpaid.Visible = true;
            }
            if (status == 5 || status == 6) {
                //is canceled
                bt_cancel.Enabled = false;
                bt_refund.Enabled = false;
                lb_cancel.Visible = true;
                if (status == 6) lb_refund.Visible = true; //if is refund
            }
        }

        //取消訂單但不退款
        private void bt_cancel_Click(object sender, EventArgs e) {
            //update order status
            try {
                MySqlCommand cmd = new MySqlCommand("UPDATE `order` SET Status = 5 WHERE OrderID = @id", conn);
                cmd.Parameters.AddWithValue("@id", orderID);
                cmd.ExecuteNonQuery();

                delete_worker();

                lb_cancel.Visible = true;
                bt_cancel.Enabled = false;
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        //取消訂單 & 退款
        private void bt_refund_Click(object sender, EventArgs e) {
            //update order status
            try {
                MySqlCommand cmd = new MySqlCommand("UPDATE `order` SET Status = 6 WHERE OrderID = @id", conn);
                cmd.Parameters.AddWithValue("@id", orderID);
                cmd.ExecuteNonQuery();

                delete_worker();

                lb_cancel.Visible = true;
                lb_refund.Visible = true;
                bt_cancel.Enabled = false;
                bt_refund.Enabled = false;

                double refund = (received < total) ? received : total; //如果未完全付款則退還已繳交款項, 否則的話退還全部款項
                tb_refund.Text = $@"{refund:C}";
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        //取消安排送貨和安裝
        private void delete_worker() {
            try {
                MySqlCommand cmd = new MySqlCommand("UPDATE delivery SET Status = 2 WHERE OrderID = @id;"
                                                    + "UPDATE installation SET Status = 1 = @id;", conn);
                cmd.Parameters.AddWithValue("@id", orderID);
                cmd.ExecuteNonQuery();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }
    }
}