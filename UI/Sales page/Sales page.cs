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

namespace UI.Sales_page
{
    public partial class Sales_Page : Form
    {
        private MySqlConnection conn;
        private Account_Details acc;
        public Sales_Page(MySqlConnection conn, Account_Details acc)
        {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
        }

        private void Sales_Page_Load(object sender, EventArgs e) {
            Program.addPage();

            //setup AutoComplete
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT Name, ItemID From item WHERE Name LIKE @name", conn);
                cmd.Parameters.AddWithValue("@name", "%" + tb_add_name.Text + "%");
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
            //add by name

        }
    }
}
