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
    public partial class Purchase_item : Form
    {
        private MySqlConnection conn;

        public Purchase_item(MySqlConnection conn) {
            this.conn = conn;
            InitializeComponent(); 
        }

        private void fill_listbow(){

            MySqlCommand cmd = new MySqlCommand("SELECT Distinct Name FROM `item`,`purchase_order`;", conn);
            MySqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString("Name");
                    listBox1.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }

        private void Purchase_item_Load(object sender, EventArgs e)
        {
            Program.addPage();
            fill_listbow();
        }

        private void Purchase_item_Cloing(object sender, FormClosingEventArgs e)
        {
            Program.removePage();
        }
    }
}
