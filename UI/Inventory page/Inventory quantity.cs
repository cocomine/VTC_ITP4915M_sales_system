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
        //initializing
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
            //connect database to dataGridView
            Program.addPage();
            da.SelectCommand = new MySqlCommand("SELECT * FROM `inventory`", conn);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            tblNameBs.DataSource = ds.Tables[0];
            textBox1.DataBindings.Add(new Binding("Text", tblNameBs, "ItemID"));




    

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
            // buuton:Next
            tblNameBs.MoveNext();
            dataGridView1.ClearSelection();
            dataGridView1.Rows[tblNameBs.Position].Selected = true;
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            // buuton:Previous
            tblNameBs.MovePrevious();
            dataGridView1.ClearSelection();
            dataGridView1.Rows[tblNameBs.Position].Selected = true;
        }

        private void First_Click(object sender, EventArgs e)
        {
            // buuton:First
            tblNameBs.MoveFirst();
            dataGridView1.ClearSelection();
            dataGridView1.Rows[tblNameBs.Position].Selected = true;
        }

        private void Last_Click(object sender, EventArgs e)
        {
            // buuton:Last
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
                    // Search StoreWarehouseID

                    MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `inventory` where 	StoreWarehouseID  = " + comboBox1.Text, conn);
                    DataTable dtbl = new DataTable();
                    dtbl.Clear();
                    sqlda.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                    


                }
            }catch(Exception ea)
            {
                //error message
                MessageBox.Show("Please select one StoreWarehouseID", "顯示");
            }


            }

        private void btDelete_Click(object sender, EventArgs e)
        {

            //delete button
            MySqlDataAdapter sqlda1 = new MySqlDataAdapter("DELETE FROM `inventory` WHERE `inventory`.`ItemID` = '" + textBox1.Text+"'", conn);
            DataTable dtbl1 = new DataTable();
            dtbl1.Clear();
            sqlda1.Fill(dtbl1);
            dataGridView1.DataSource = dtbl1;
            MessageBox.Show("Delete success", "顯示");
            reload();
        }

        private void dataGridView1_CellCick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //show Id in ItemID textbox
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reload();
        }

        public void reload()
        {
            //Class for reload pages
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `inventory` ", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void btDelete_Click_1(object sender, EventArgs e)
        {
            MySqlDataAdapter sqlda = new MySqlDataAdapter("DELETE FROM `inventory` WHERE `inventory`.`ItemID` = '" + textBox1.Text + "';", conn);
            DataTable dtbl = new DataTable();
            dtbl.Clear();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;

            reload();
        }
    }
    }

