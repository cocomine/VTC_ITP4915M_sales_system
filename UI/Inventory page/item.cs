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
    public partial class Item : Form
    {
        private MySqlConnection conn;
        public Item(MySqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void Item_Closing(object sender, FormClosingEventArgs e)
        {
            Program.removePage();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            Program.addPage();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `item`", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ACS_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `item` Order by Price ASC", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void DESC_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `item` Order By Price DESC", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void serach1_Click(object sender, EventArgs e)
        {
            int spID = Int32.Parse(search1.Text.ToString());
            if (spID >= 0)
            {
                MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `item` where 	SupplierID = " + spID, conn);
                DataTable dtbl = new DataTable();
                sqlda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `item`", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `item` Order by Name ASC", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `item`", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void bt_desc_name_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `item` Order By Name DESC", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }
    }
}
