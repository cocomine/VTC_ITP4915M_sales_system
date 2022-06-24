using ITP4915M.API;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using ITP4915M.IT;
using ITP4915M.Sales_page;
using UI;
using UI.Accounting_page;
using UI.Delivery_Page;
using UI.Installer_Page;
using UI.Inventory_page;
using UI.IT;
using UI.Sales_page;
using UI.Technical_Support_page;

namespace ITP4915M {
    public partial class Main_Menu : Form {
        private readonly Account_Details acc;
        private readonly string SQLConnectionString;
        private readonly MySqlConnection conn;

        public Main_Menu(string sqlConnectionString, Account_Details acc, MySqlConnection mySqlConnection) {
            this.acc = acc;
            SQLConnectionString = sqlConnectionString;
            conn = mySqlConnection;
            InitializeComponent();
        }

        private void Main_Menu_Load(object sender, EventArgs e) {
            Program.addPage();
            lb_name.Text = $"Hello! {acc.Get_fullRealName()} ({acc.Get_acoountID()})";
            menu.VerticalScroll.Value = 100;
            foreach (Control menuControl in menu.Controls) {
                if (menuControl is GroupBox gp) {
                    gp.Visible = false;
                }
            }

            //根據department 開放按鈕
            switch (acc.Get_departmentID()) {
                case Department.Sales:
                    gp_sales.Enabled = true;
                    gp_sales.Visible = true;
                    if (acc.Get_isManager()) bt_salesMange.Enabled = true;
                    break;
                case Department.Inventory:
                    gp_inventory.Enabled = true;
                    gp_inventory.Visible = true;
                    break;
                case Department.Accounting:
                    gp_accounting.Enabled = true;
                    gp_accounting.Visible = true;
                    break;
                case Department.Technical_Support:
                    gp_technical.Enabled = true;
                    gp_technical.Visible = true;
                    break;
                case Department.IT:
                case Department.CEO:
                    gp_admin.Enabled = true;
                    //Visible all GroupBox
                    foreach (Control menuControl in menu.Controls) {
                        if (menuControl is GroupBox gp) {
                            gp.Visible = true;
                        }
                    }
                    break;
                case Department.Delivery:
                    gp_delivery.Enabled = true;
                    gp_delivery.Visible = true;
                    if (acc.Get_isManager()) {
                        bt_arrangeTeam.Enabled = true;
                    }
                    break;
                case Department.Installer:
                    gp_install.Enabled = true;
                    gp_install.Visible = true;
                    break;
            }
        }

        //選擇功能
        private void bt_Menu_Click(object sender, EventArgs e) {
            MySqlConnection conn = null;
            Button bt = (Button)sender;

            //為頁面開啟新的sql connect
            try {
                conn = new MySqlConnection(SQLConnectionString);
                conn.Open();
            } catch (MySqlException ex) {
                MessageBox.Show(SQLConnectionString + "\n" + ex.Message, "SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (conn == null) return;

            //檢查點擊哪一個按鈕
            //Sales Department
            if (bt.Equals(bt_salesPage)) Program.OpenFrom(new Sales_Page(conn, acc));
            if (bt.Equals(bt_cancelOrder)) Program.OpenFrom(new Cancel_Order(conn, acc)); ;
            if (bt.Equals(bt_salesMange)) Program.OpenFrom(new Sales_Management(conn, acc));
            //Delivery Department
            if (bt.Equals(bt_delivery)) Program.OpenFrom(new Delivery_Team_Page(conn, acc));
            if (bt.Equals(bt_arrangeTeam)) Program.OpenFrom(new Arrange_Delivery_Page(conn, acc));
            //Installer Department
            if (bt.Equals(bt_install)) Program.OpenFrom(new Installer_Page(conn, acc));
            //Technical Support
            if (bt.Equals(bt_arrangeWorker)) Program.OpenFrom(new Arrange_installation(conn, acc));
            //Inventory Department
            if (bt.Equals(bt_inventoryQty)) Program.OpenFrom(new Inventory_page(conn, acc, new Inventory_quantity(conn)));
            if (bt.Equals(bt_itemRequest)) Program.OpenFrom(new Inventory_page(conn, acc, new Item_requested(conn)));
            if (bt.Equals(bt_purchaseItem)) Program.OpenFrom(new Inventory_page(conn, acc, new Purchase_item(conn)));
            //Accounting Department
            if (bt.Equals(bt_orderReport)) Program.OpenFrom(new Accounting_page(conn, acc, "Order_report"));
            if (bt.Equals(bt_purchaseReport)) Program.OpenFrom(new Accounting_page(conn, acc, "Purchase_report"));
            //IT / CEO
            if (bt.Equals(bt_account)) Program.OpenFrom(new Account_Management(conn, acc));
            if (bt.Equals(bt_deliveryGroup)) Program.OpenFrom(new Delivery_Team_Grouping(conn));
            if (bt.Equals(bt_assignSales)) Program.OpenFrom(new Sales_Staff_arrange(acc, conn));
        }

        //登出
        private void bt_logout_Click(object sender, EventArgs e) { Program.Logout(); }

        //我的資料
        private void bt_myprofile_Click(object sender, EventArgs e) { Program.OpenFrom(new My_Profile(conn, acc)); }

        private void Main_Menu_FormClosed(object sender, FormClosedEventArgs e) { Program.removePage(); }
    }
}