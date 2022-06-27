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

namespace ITP4915M.Inventory_page
{
    public partial class Record_of_Inward_Received_Goods : Form
    {
        private MySqlConnection conn;
        private MySqlDataAdapter da = new MySqlDataAdapter();
        private DataSet ds = new DataSet();
        private BindingSource tblNameBs = new BindingSource();
        public Record_of_Inward_Received_Goods(MySqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void Record_of_Inward_Received_Goods_Load(object sender, EventArgs e)
        {
            da.SelectCommand = new MySqlCommand("SELECT * FROM `purchase_order`", conn);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            tblNameBs.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
