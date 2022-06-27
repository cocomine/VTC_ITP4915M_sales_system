using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Inventory_page {
    public partial class Inventory_quantity : Form {
        //initializing
        private MySqlConnection conn;
        private MySqlDataAdapter da = new MySqlDataAdapter();
        private DataSet ds = new DataSet();
        private BindingSource tblNameBs = new BindingSource();

        public Inventory_quantity(MySqlConnection conn) {
            this.conn = conn;
            InitializeComponent();
        }

        private void Inventory_quantity_Load(object sender, EventArgs e) {
            //connect database to dataGridView

            da.SelectCommand = new MySqlCommand("SELECT * FROM `inventory`", conn);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            tblNameBs.DataSource = ds.Tables[0];
            textBox1.DataBindings.Add(new Binding("Text", tblNameBs, "ItemID"));

            fill_comboBox();
        }

        private void fill_comboBox()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT ID FROM `storewarehouse`;", conn);
            MySqlDataReader myReader;

            try
            {
                //fill listbox
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string sID = myReader.GetString("ID");
                    comboBox1.Items.Add(sID);
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void Next_Click(object sender, EventArgs e) {
            // buuton:Next
            try
            {
                tblNameBs.MoveNext();
                dataGridView1.ClearSelection();
                dataGridView1.Rows[tblNameBs.Position].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    }

        private void Previous_Click(object sender, EventArgs e) {
            // buuton:Previous
            try
            {
                tblNameBs.MovePrevious();
                dataGridView1.ClearSelection();
                dataGridView1.Rows[tblNameBs.Position].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void First_Click(object sender, EventArgs e) {
            // buuton:First
            try
            {
                tblNameBs.MoveFirst();
            dataGridView1.ClearSelection();
            dataGridView1.Rows[tblNameBs.Position].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Last_Click(object sender, EventArgs e) {
            // buuton:Last
            try {
                tblNameBs.MoveLast();
                dataGridView1.ClearSelection();
                dataGridView1.Rows[tblNameBs.Position].Selected = true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search_Click(object sender, EventArgs e) {
            try {
                if (comboBox1.Text != null && comboBox1.Text != "")
                {
                    // Search StoreWarehouseID
                    string ID = "";

                    ID = comboBox1.Text;

                    MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `inventory` where 	StoreWarehouseID  = " + ID, conn);
                    DataTable dtbl = new DataTable();
                    dtbl.Clear();
                    sqlda.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
                
            } catch (Exception ea) {
                //error message
                MessageBox.Show("Please select one StoreWarehouseID", "顯示");
            }

        }

        private void dataGridView1_CellCick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                //show Id in ItemID textbox
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e) { reload(); }

        public void reload() {
            //Class for reload pages
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `inventory` ", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void btDelete_Click_1(object sender, EventArgs e) {
            MySqlDataAdapter sqlda = new MySqlDataAdapter("DELETE FROM `inventory` WHERE `inventory`.`ItemID` = '" + textBox1.Text + "';", conn);
            DataTable dtbl = new DataTable();
            dtbl.Clear();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            MessageBox.Show("Deleted");

            reload();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSet_Click(object sender, EventArgs e)
        {
            try
            {
                int Qty = int.Parse(numericUpDown1.Text);
                MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `inventory` where Qty <= " + Qty + " order by Qty ASC;", conn);
                DataTable dtbl = new DataTable();
                dtbl.Clear();
                sqlda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}