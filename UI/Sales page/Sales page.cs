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
            Item item = new Item("abc", 11.1, ItemType.Common);
            Item item2 = new Item("def", 15.1, ItemType.Large_and_install, "553341", "rfhrdsfhdr", 5);
            Console.WriteLine(item);
            Console.WriteLine(item2);
            Combo combo = new Combo("fff-Combo", 44.0, "dgsdg");
            combo.AddItem(item);
            combo.AddItem(item2);
            Console.WriteLine(combo);
        }

        private void button2_Click(object sender, EventArgs e) {
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
    }
}
