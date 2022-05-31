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


    public partial class Delivery_Page : Form
    {
        private MySqlConnection conn;
        private Account_Details acc; //comment
        public Delivery_Page(MySqlConnection conn, Account_Details acc)
        {
            this.conn = conn;
            this.acc = acc;
            

            InitializeComponent();
        }

        private void Delivery_Page_Load(object sender, EventArgs e) {
            Program.addPage();



        }

        private void Delivery_Page_Closing(object sender, FormClosingEventArgs e) {
            Program.removePage();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Insertion
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO delivery Values (@OrderID, @Delivery_TeamID, @CustomerID, @Session,@Status);", conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(tx_ID.Text));
            cmd.Parameters.AddWithValue("@OrderID", int.Parse(tx_TeamID.Text));
            cmd.Parameters.AddWithValue("@Delivery_TeamID", int.Parse(tx_CustomerID.Text));
            cmd.Parameters.AddWithValue("@CustomerID", tx_CustomerID.Text);
            cmd.Parameters.AddWithValue("@Session", numericUpDown1.Text);
            cmd.Parameters.AddWithValue("@Status", checkBox1.Checked);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Insert success");

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from delivery", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);

        }
    }
}
