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

namespace UI.Inventory_page
{

    public partial class Inventory_page : Form
    {
        private MySqlConnection conn;
        private Account_Details acc;
        public Inventory_page()
        {

            InitializeComponent();
        }

        private void warehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void purchaseItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
