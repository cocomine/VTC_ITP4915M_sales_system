﻿using ITP4915M.API;
using MySql.Data.MySqlClient;
using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        private MySqlConnection conn;
        private Lang lang;

        public Login(MySqlConnection conn)
        {
            this.conn = conn;
            lang = new Lang(typeof(Login));
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
                    MessageBox.Show(lang.GetString("Login_404"), lang.GetString("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else {
                    while (accountData.Read()) {
                        //check account Enable
                        if (!accountData.GetBoolean("Enable")) {
                            MessageBox.Show(lang.GetString("Login_403"), lang.GetString("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            accountData.Close();
                            return;
                        }

                        //hash password
                        SHA512 sha512 = new SHA512Managed();
                        String[] pws = accountData.GetString("Password").Split('.'); //Split salt & password
                        byte[] data = Encoding.UTF8.GetBytes(pws[0]+tb_password.Text.Trim());
                        byte[] hash = sha512.ComputeHash(data); //hash
                        String password = BitConverter.ToString(hash).Replace("-", "").ToLower();
                        Console.WriteLine(password);

                        //check password
                        if (password.Equals(pws[1])) {
                            //password pass
                            MessageBox.Show(string.Format(lang.GetString("Welcome_back__0__"), accountData.GetString("FullRealName")), lang.GetString("Welcome"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Account_Details acc = new Account_Details(accountData.GetString("AcoountID"), accountData.GetString("Username"), accountData.GetString("FullRealName"), accountData.GetInt32("DepartmentID"), accountData.GetBoolean("isManager"));
                            accountData.Close(); //need close Reader fist
                            Program.JumpPage(acc); //go to other pages
                            this.Close(); //close this Form
                        } else {
                            //password faild
                            MessageBox.Show(lang.GetString("Login_403"), lang.GetString("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                accountData.Close();
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

        private void Login_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) { //Enter key hit
                btn_login_Click(sender, e);
            }
        }
    }
}
