using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITP4915M.API;

namespace UI.Sales_page {
    public partial class Customer_info : Form {
        private MySqlConnection conn;
        private Lang lang;

        public string CustomerID { get; set; }

        public Customer_info(MySqlConnection conn) {
            this.conn = conn;
            CustomerID = null;
            InitializeComponent();
            lang = new Lang(typeof(Customer_info));
        }

        private void Customer_info_Load(object sender, EventArgs e) {
            Program.addPage();
        }

        //save Customer info
        private void bt_save_Click(object sender, EventArgs e) {
            //Validate
            if (!ValidateChildren(ValidationConstraints.Enabled)) {
                return;
            }

            //指派變數
            string Name = tb_Name.Text;
            string Phone = tb_Phone.Text;
            string Address = tb_address.Text;

            //檢查是否存在相同的客戶
            try {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer WHERE Phone = @Phone AND Customer_name LIKE @name", conn);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@name", Name);
                MySqlDataReader reader = cmd.ExecuteReader();

                //有相同的客戶
                if (reader.HasRows) {
                    while (reader.Read()) {
                        DialogResult result = MessageBox.Show(String.Format(lang.GetString("Find_existing_matching_customer"),
                            reader.GetString("Customer_name"), reader.GetString("Phone"), reader.GetString("Address")),
                            lang.GetString("Match_customer"), MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes) {
                            //確認使用
                            CustomerID = reader.GetString("CustomerID");
                            Name = reader.GetString("Customer_name");
                            Phone = reader.GetString("Phone");
                            Address = reader.GetString("Address");
                            break;
                        }
                    }
                }
                reader.Close();
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            //update database
            if (CustomerID == null) {
                CustomerID = Guid.NewGuid().ToString(); //generation id

                //加入記錄
                try {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `customer` (`CustomerID`, `Phone`, `Customer_name`, `Address`) VALUES (@CustomerID, @Phone, @Customer_name, @Address)", conn);
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    cmd.Parameters.AddWithValue("@Customer_name", Name);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.ExecuteNonQuery();
                } catch (MySqlException ex) {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Customer_info_FormClosed(object sender, FormClosedEventArgs e) {
            Program.removePage();
        }

        //Validate
        private void tb_Validating(object sender, CancelEventArgs e) {
            TextBoxBase tb = (TextBoxBase)sender;

            //if Empty
            if (String.IsNullOrEmpty(tb.Text)) {
                e.Cancel = true;
                errorProvider1.SetError(tb, lang.GetString("Please_fill_information"));
                tb.BackColor = Color.LightCoral;
            }


            if (sender.Equals(tb_Phone)) {
                //Console.WriteLine(tb_Phone.Text);
                Regex rex = new Regex("^[0-9]{4}-[0-9]{4}$");
                if (!rex.IsMatch(tb.Text)) {
                    e.Cancel = true;
                    errorProvider1.SetError(tb, lang.GetString("Incorrect_phone_format"));
                    tb.BackColor = Color.LightCoral;
                }
            }
        }

        private void Change_back_color(object sender, EventArgs e) {
            TextBoxBase tb = (TextBoxBase)sender;
            tb.BackColor = SystemColors.Window;
            errorProvider1.SetError(tb, "");
        }
    }
}
