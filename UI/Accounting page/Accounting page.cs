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

namespace UI.Accounting_page
{
    public partial class Accounting_page : Form {
        private MySqlConnection conn;
        private Account_Details acc;
        private MySqlDataAdapter adapter = new MySqlDataAdapter();
        private DataSet dataSet = new DataSet();
        private BindingSource bindingSource = new BindingSource();

        public Accounting_page(MySqlConnection conn, Account_Details acc)
        {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Program.Logout();
        }

        private void Accounting_page_Load(object sender, EventArgs e) {
            Program.addPage();
        }

        private void Accounting_page_FormClosed(object sender, FormClosedEventArgs e) {
            Program.removePage();
        }

        //order report
        private void orderReportToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                //SelectCommand
                MySqlCommand cmd = new MySqlCommand("SELECT OrderID AS 'Order ID', Payment_Method AS 'Payment Method', Charge, finalTotal AS 'Total', DateTime AS 'Date' FROM `order` WHERE Status = 2;", conn);
                adapter.SelectCommand = cmd;

                //fill dataset
                dataSet.Clear();
                adapter.Fill(dataSet, "Order_report");

                //binding data Source
                bindingSource.DataSource = dataSet;
                bindingSource.DataMember = "Order_report";
                dgv_report.Columns.Clear();
                dgv_report.DataSource = bindingSource;

                bt_output.Enabled = true;
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                //SelectCommand
                MySqlCommand cmd = new MySqlCommand("SELECT p.PurchaseID AS 'Purchase ID', p.DateTime AS 'Date', p.ItemID AS 'Item ID', i.Name AS 'Item', s.Name AS 'Supplier', p.Qty FROM purchase_order p, item i, supplier s WHERE p.ItemID = i.ItemID AND i.SupplierID = s.SupplierID;", conn);
                adapter.SelectCommand = cmd;

                //fill dataset
                dataSet.Clear();
                adapter.Fill(dataSet, "Order_report");

                //binding data Source
                bindingSource.DataSource = dataSet;
                bindingSource.DataMember = "Order_report";
                dgv_report.DataSource = bindingSource;

                bt_output.Enabled = true;
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }
    }
}
