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

        public Accounting_page(MySqlConnection conn, Account_Details acc)
        {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Accounting_page_Load(object sender, EventArgs e)
        {

        }
    }
}
