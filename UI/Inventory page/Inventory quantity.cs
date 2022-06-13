using DocumentFormat.OpenXml.Spreadsheet;
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

namespace UI.Inventory_page
{
    public partial class Inventory_quantity : Form
    {
        private MySqlConnection conn;
        MySqlDataAdapter da = new MySqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource tblNameBs = new BindingSource();
        MySqlCommand SelectCommand;

        public Inventory_quantity(MySqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }



        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Inventory_quantity_Load(object sender, EventArgs e)
        {
            Program.addPage();
            da.SelectCommand = new MySqlCommand("SELECT * FROM `inventory`", conn);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            tblNameBs.DataSource = ds.Tables[0];
            textBox1.DataBindings.Add(new Binding("Text", tblNameBs, "ItemID"));

            //ComboBox


    

        }

        private void Inventory_quantity_Closing(object sender, FormClosingEventArgs e)
        {
            Program.removePage();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }


        private void ItemID_Click(object sender, EventArgs e)
        {

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

        private void First_Click(object sender, EventArgs e)
        {
            tblNameBs.MoveFirst();
            dataGridView1.ClearSelection();
            dataGridView1.Rows[tblNameBs.Position].Selected = true;
        }

        private void Last_Click(object sender, EventArgs e)
        {
            tblNameBs.MoveLast();
            dataGridView1.ClearSelection();
            dataGridView1.Rows[tblNameBs.Position].Selected = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != null && comboBox1.Text != "")
                {
                    MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `inventory` where 	StoreWarehouseID  = " + comboBox1.Text, conn);
                    DataTable dtbl = new DataTable();
                    sqlda.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
            }catch(Exception ea)
            {
                MessageBox.Show("Please select one StoreWarehouseID", "顯示");
            }


            }

        private void btDelete_Click(object sender, EventArgs e)
        {


            MySqlDataAdapter sqlda1 = new MySqlDataAdapter("DELETE FROM `inventory` WHERE `inventory`.`ItemID` = '" + textBox1.Text+"'", conn);
            DataTable dtbl1 = new DataTable();
            sqlda1.Fill(dtbl1);
            dataGridView1.DataSource = dtbl1;

            sqlda1 = new MySqlDataAdapter("SELECT * FROM `inventory`  " + comboBox1.Text, conn);
            dtbl1 = new DataTable();
            sqlda1.Fill(dtbl1);
            dataGridView1.DataSource = dtbl1;
        }
    }
    }

