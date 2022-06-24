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

        MySqlDataAdapter da1 = new MySqlDataAdapter();
        DataSet ds1 = new DataSet();
        BindingSource tblNameBs1 = new BindingSource();
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
            Program.removePage();
        }

        private void Item_requested_Load(object sender, EventArgs e)
        {
            Program.addPage();
            da.SelectCommand = new MySqlCommand("SELECT `request_item`.`RequestID`, `request_item`.`ItemID`, `request_item`.`Qty`, `inventory`.`Qty`FROM `request_item`, `inventory` WHERE `request_item`.ItemID=`inventory`.ItemID ORDER BY `RequestID` ASC", conn);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            tblNameBs.DataSource = ds.Tables[0];
            textBox2.DataBindings.Add(new Binding("Text", tblNameBs, "Qty"));
            textBox1.DataBindings.Add(new Binding("Text", tblNameBs, "ItemID"));
            textBox3.DataBindings.Add(new Binding("Text", tblNameBs, "Qty"));

        }

        public void reload()
        {
            //Class for reload pages
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `request_item` ORDER BY `RequestID` ASC ", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            tblNameBs.MoveNext();
            dataGridView1.ClearSelection();
            dataGridView1.Rows[tblNameBs.Position].Selected = true;
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            tblNameBs.MovePrevious();
            dataGridView1.ClearSelection();
            dataGridView1.Rows[tblNameBs.Position].Selected = true;
        }

        private void Last_Click(object sender, EventArgs e)
        {
            tblNameBs.MoveLast();
            dataGridView1.ClearSelection();
            dataGridView1.Rows[tblNameBs.Position].Selected = true;
        }

        private void First_Click(object sender, EventArgs e)
        {
            tblNameBs.MoveFirst();
            dataGridView1.ClearSelection();
            dataGridView1.Rows[tblNameBs.Position].Selected = true;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != null && comboBox1.Text != "")
            {
                // Search StoreWarehouseID

                MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT `request_item`.`RequestID`, `request_item`.`ItemID`, `request_item`.`Qty`, `inventory`.`Qty`FROM `request_item`, `inventory` WHERE `request_item`.ItemID=`inventory`.ItemID And fromWarehouseID  = " + comboBox1.Text, conn);
                DataTable dtbl = new DataTable();
                dtbl.Clear();
                sqlda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

            String ItemID = textBox1.Text;
            MySqlDataAdapter sqlda1 = new MySqlDataAdapter("UPDATE `inventory` SET `Qty` = '" + textBox3.Text + "' WHERE `inventory`.`ItemID` = '"+ItemID+"';", conn);
            DataTable dtbl1 = new DataTable();
            dtbl1.Clear();
            sqlda1.Fill(dtbl1);
            dataGridView1.DataSource = dtbl1;

            sqlda1 = new MySqlDataAdapter("DELETE FROM `request_item` WHERE `request_item`.`ItemID` = '"+ ItemID + "';", conn);
            dtbl1 = new DataTable();
            dtbl1.Clear();
            sqlda1.Fill(dtbl1);
            dataGridView1.DataSource = dtbl1;

            reload();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //show Id in ItemID textbox & request textBox
                //ItemID
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                //currentQty
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                //Qty
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reload();
        }
    }
}
