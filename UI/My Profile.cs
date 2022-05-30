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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class My_Profile : Form
    {
        private MySqlConnection conn;
        private Account_Details acc;
        public My_Profile(MySqlConnection conn, Account_Details acc)
        {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
        }

        private void My_Profile_Load(object sender, EventArgs e) {
            Program.addPage();

            //setup textbox
            tb_FullName.Text = acc.Get_fullRealName();
            tb_Username.Text = acc.Get_username();
            tb_Department.Text = Department.Get_DepartmentName(acc.Get_departmentID());
            cb_DepartmentHead.Checked = acc.Get_isManager();
        }

        private void My_Profile_Closing(object sender, FormClosingEventArgs e) {
            Program.removePage();
        }

        private void btn_Save_Click(object sender, EventArgs e) {
            bool isChange = false;
            if (!tb_Username.Text.Equals(acc.Get_username())) {
                //if username is change
                //update database
                try {
                    MySqlCommand cmd = new MySqlCommand("UPDATE account SET Username = @username WHERE AcoountID = @acoountID", conn);
                    cmd.Parameters.AddWithValue("@username", tb_Username.Text);
                    cmd.Parameters.AddWithValue("@acoountID", acc.Get_acoountID());
                    MySqlDataReader usernameData = cmd.ExecuteReader();
                    usernameData.Close();

                    //set changed
                    isChange = true;
                    acc.Set_username(tb_Username.Text);
                } catch (MySqlException ex) {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }
            }
            if (!tb_Password.Text.Equals("")) {
                //if password is change
                //generation salt
                var rng = new RNGCryptoServiceProvider();
                byte[] random = new byte[16];
                rng.GetNonZeroBytes(random);
                String salt = BitConverter.ToString(random).Replace("-", "").ToLower();
                //Console.WriteLine(salt);

                //hash password
                SHA512 sha512 = new SHA512Managed();
                byte[] data = Encoding.UTF8.GetBytes(salt+tb_Password.Text.Trim());
                byte[] hash = sha512.ComputeHash(data); //hash
                String password = salt+"."+BitConverter.ToString(hash).Replace("-", "").ToLower();

                //update database
                try {
                    MySqlCommand cmd = new MySqlCommand("UPDATE account SET Password = @password WHERE AcoountID = @acoountID", conn);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@acoountID", acc.Get_acoountID());
                    MySqlDataReader passwordData = cmd.ExecuteReader();
                    passwordData.Close();

                    isChange = true; //set changed
                } catch (MySqlException ex) {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }
            }
            if(isChange) MessageBox.Show("Change save!", "My Profile", MessageBoxButtons.OK, MessageBoxIcon.Information); //show Message is change
            this.Close();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) { //Enter key hit
                btn_Save_Click(sender, e);
            }
        }

        private void tb_Username_Validating(object sender, CancelEventArgs e) {
            TextBox tb = (TextBox)sender;
            //if Empty
            if (String.IsNullOrEmpty(tb.Text)) {
                e.Cancel = true;
                tb.Focus();
                errorProvider1.SetError(tb, "Please fill information");
                tb.BackColor = Color.LightCoral;
            }

            //if format does not match
            Regex rex = new Regex("^[A-za-z]+$");
            if (!rex.IsMatch(tb.Text)) {
                e.Cancel = true;
                tb.Focus();
                errorProvider1.SetError(tb, "Only letters are accepted");
                tb.BackColor = Color.LightCoral;
            }
        }
    }
}
