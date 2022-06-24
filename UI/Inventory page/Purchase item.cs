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
                //fill listbox
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
                    //listBox connect textbox
                    string sName = myReader.GetString("Name");
                    string sPrice = myReader.GetString("Price");
                    string sDescription = "";
                    if (myReader["Description"] != DBNull.Value)
                    { 
                        sDescription = myReader.GetString("Description"); 
                    }
                    string sID = myReader.GetString("ItemID");


                    tbName.Text = sName;
                    tbPirce.Text = sPrice;
                    tbDescription.Text = sDescription;
                    tbID.Text=sID;

                    
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
            //set values
            Random rnd = new Random();
            int PurchaseID = rnd.Next(1000000, 10000000);
            int Qty = Int32.Parse(tbQty.Text);
            DateTime now = DateTime.Now;
            string ItemID = tbID.Text;

            //add item
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `purchase_order` VALUES ("+ PurchaseID + ", '"+now+"', '"+ ItemID + "', " +Qty+");", conn);
            MySqlDataReader myReader;
            
            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Purchased");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
    }
}
