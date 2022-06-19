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
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource tblNameBs = new BindingSource();
        MySqlCommand SelectCommand;
        public Item_requested(MySqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void ItemID_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellCick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Item_requested_Closing(object sender, FormClosingEventArgs e)
        {

        }

        private void Item_requested_Load(object sender, EventArgs e)
        {

        }

        public void reload()
        {
            //Class for reload pages
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `inventory` ", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }
    }
}
