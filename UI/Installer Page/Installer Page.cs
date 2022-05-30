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

namespace UI.Installer_Page
{
    public partial class Installer_Page : Form {

        private MySqlConnection conn;
        private Account_Details acc;

        public Installer_Page() 
        {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
        }

        private void Installer_Page_FormClosed(object sender, FormClosedEventArgs e) {
            Program.removePage();
        }

        private void Installer_Page_Load(object sender, EventArgs e) {
            Program.addPage();

            MySqlCommand cmd = new MySqlCommand("SELECT * From installation AS i, customer AS c, " +
                "customer_detail AS cd WHERE i.CustomerID = c.CustomerID AND c.CustomerID = cd.CustomerID " +
                "AND i.CustomerID = cd.CustomerID;", conn);
            MySqlDataReader dataReader;

            try
            {
                conn.Open();
                dataReader = cmd.ExecuteReader();

                while(dataReader.Read())
                {
                    string order = dataReader.GetString("i.OrderID");
                    lb_order.Items.Add(order);
                }
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void myProfiToolStripMenuItem_Click(object sender, EventArgs e) {
            new My_Profile(conn, acc).Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lb_order_SelectedIndexChanged(object sender, EventArgs e) {
            MySqlCommand cmd = new MySqlCommand("SELECT * From installation AS i, customer AS c, " +
                "customer_detail AS cd WHERE i.OrderID = '" + lb_order.Text + "';", conn);
            MySqlDataReader dataReader;

            try
            {
                conn.Open();
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string cName = dataReader.GetString("c.Customer_name");
                    string cAddress = dataReader.GetString("cd.Address");
                    string cPhone = dataReader.GetInt32("c.Phone").ToString();
                    tb_customer_name.Text = cName;
                    tb_customer_address.Text = cAddress;
                    tb_customer_phone.Text = cPhone;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tb_customer_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_customer_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_customer_phone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
