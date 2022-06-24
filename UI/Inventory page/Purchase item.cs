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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string SQL = "SELECT * FROM `item` where `item`.Name = '"+listBox1.Text+"';";
            MySqlCommand cmd = new MySqlCommand(SQL, conn);
            MySqlDataReader myReader;

            try
            {
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString("Name");
                    string sPrice = myReader.GetString("Price");
                    string sDescription = "";
                    if (myReader["Description"] != DBNull.Value)
                    { 
                        sDescription = myReader.GetString("Description"); 
                    }
                        

                    tbName.Text = sName;
                    tbPirce.Text = sPrice;
                    tbDescription.Text = sDescription;

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }

        private void btPurchase_Click(object sender, EventArgs e)
        {

        }
    }
}
