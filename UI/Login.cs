using ITP4915M.API;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        private MySqlConnection conn;

        public Login(MySqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e) {
            try {
                //get account Data
                MySqlCommand cmd = new MySqlCommand("SELECT a.Password, a.Enable, a.AcoountID, a.Username, s.FullRealName, s.DepartmentID, s.isManager FROM account AS a, staff AS s WHERE a.AcoountID = s.AccountID AND Username = @username", conn);
                cmd.Parameters.AddWithValue("@username", tb_username.Text);
                MySqlDataReader accountData = cmd.ExecuteReader();

                //check account is exist
                if (!accountData.HasRows) {
                    MessageBox.Show("User does not exist.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else {
                    while (accountData.Read()) {
                        //check account Enable
                        if (!accountData.GetBoolean("Enable")) {
                            MessageBox.Show("User does not enable.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            accountData.Close();
                            return;
                        }

                        //hash password
                        SHA512 sha512 = new SHA512Managed();
                        byte[] data = Encoding.UTF8.GetBytes(tb_password.Text);
                        byte[] hash = sha512.ComputeHash(data);
                        String password = BitConverter.ToString(hash).Replace("-", "").ToLower();
                        //Console.WriteLine(password);

                        //check password
                        if (password.Equals(accountData.GetString("Password"))) {
                            //password pass
                            MessageBox.Show("Welcome back "+ accountData.GetString("FullRealName") + ".", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Account_Details acc = new Account_Details(accountData.GetString("AcoountID"), accountData.GetString("Username"), accountData.GetString("FullRealName"), accountData.GetInt32("DepartmentID"), accountData.GetBoolean("isManager"));
                            accountData.Close(); //need close Reader fist
                            Program.JumpPage(acc); //go to other pages
                            this.Close(); //close this Form
                        } else {
                            //password faild
                            MessageBox.Show("Incorrect password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    accountData.Close();
                }
            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e) {
            Program.removePage();
        }

        private void Login_Load(object sender, EventArgs e) {
            Program.addPage();
        }
    }
}
