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
    public partial class Item_requested : Form
    {
        private MySqlConnection conn;
        public Item_requested(MySqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void Item_requested_Closing(object sender, FormClosingEventArgs e)
        {
            Program.removePage();
        }

        private void Item_requested_Load(object sender, EventArgs e)
        {
            Program.addPage();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `request_item`", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void serach1_Click(object sender, EventArgs e)
        {
            int rqID = Int32.Parse(search1.Text.ToString());
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `request_item` where RequestID = " + rqID, conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void normal_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `request_item`", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void ACS_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `request_item` Order by Qty ASC", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void DESC_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `request_item` Order By Qty DESC", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void search2_Click(object sender, EventArgs e)
        {
            int WhID = Int32.Parse(rc2.Text);
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `request_item` where fromWarehouseID  = " + WhID, conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }
    }
}
