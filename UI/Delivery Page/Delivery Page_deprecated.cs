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

namespace UI.Delivery_Page
{


    public partial class Delivery_Page_deprecated : Form
    {
        private MySqlConnection conn;
        private Account_Details acc; //comment
        public Delivery_Page_deprecated(MySqlConnection conn, Account_Details acc)
        {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
        }

        private void Delivery_Page_Load(object sender, EventArgs e) {
            Program.addPage();

            MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from delivery", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            DataGridView.DataSource = dtbl;


            MySqlDataAdapter sqlda1 = new MySqlDataAdapter("SELECT * FROM `delivery_team` Where Status = 0", conn);
            DataTable dtbl1 = new DataTable();
            sqlda1.Fill(dtbl1);
            dataGridView1.DataSource = dtbl1;

            MySqlDataAdapter sqlda2 = new MySqlDataAdapter("SELECT OrderId, Charged FROM `order`", conn);
            DataTable dtbl2 = new DataTable();
            sqlda2.Fill(dtbl2);
            dataGridView2.DataSource = dtbl2;


            MySqlDataAdapter sqlda3 = new MySqlDataAdapter("SELECT CustomerID, Customer_name FROM `customer`", conn);
            DataTable dtbl3 = new DataTable();
            sqlda3.Fill(dtbl3);
            dataGridView3.DataSource = dtbl3;
        }

        private void Delivery_Page_Closing(object sender, FormClosingEventArgs e) {
            Program.removePage();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Insertion
            
            MySqlCommand cmd = new MySqlCommand("INSERT INTO delivery Values (@OrderID, @Delivery_TeamID, @CustomerID, @Session,@Status);", conn);
            cmd.Parameters.AddWithValue("@OrderID", int.Parse(tx_ID.Text));
            cmd.Parameters.AddWithValue("@Delivery_TeamID", tx_TeamID.Text);
            cmd.Parameters.AddWithValue("@CustomerID", tx_CustomerID.Text);
            cmd.Parameters.AddWithValue("@Session", numericUpDown1.Text);
            cmd.Parameters.AddWithValue("@Status", numericUpDown2.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Insert success");
            MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from delivery", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            DataGridView.DataSource = dtbl;

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                tx_ID.Text = DataGridView.SelectedRows[0].Cells[0].Value.ToString();
                tx_TeamID.Text = DataGridView.SelectedRows[0].Cells[1].Value.ToString();
                tx_CustomerID.Text = DataGridView.SelectedRows[0].Cells[2].Value.ToString();
                numericUpDown1.Text = DataGridView.SelectedRows[0].Cells[3].Value.ToString();
                numericUpDown2.Text = DataGridView.SelectedRows[0].Cells[4].Value.ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Update
            MySqlCommand cmd = new MySqlCommand("update delivery set Session = @Session, Status = @Status where OrderID  = @OrderID;", conn);
            cmd.Parameters.AddWithValue("@OrderID", int.Parse(tx_ID.Text));
            cmd.Parameters.AddWithValue("@Session", numericUpDown1.Text);
            cmd.Parameters.AddWithValue("@Status", numericUpDown2.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Insert success");
            MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from delivery", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            DataGridView.DataSource = dtbl;




        }

        private void tx_TeamID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tx_TeamID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tx_ID.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tx_CustomerID.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void DataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
