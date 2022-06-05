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
using UI;

namespace ITP4915M.IT {
    public partial class Create_Account : Form {
        private MySqlConnection conn;
        public Create_Account(MySqlConnection conn) {
            this.conn = conn;
            InitializeComponent();
        }

        private void bt_create_Click(object sender, EventArgs e) {
            //create account
            //Validate
            if (!ValidateChildren(ValidationConstraints.Enabled)) {
                return;
            }

            //generation id
            String id = DateTime.Now.ToString("yyyyMMddss");

            //generation password
            String newPass = id + tb_username.Text;

            //generation salt
            var rng = new RNGCryptoServiceProvider();
            byte[] random = new byte[16];
            rng.GetNonZeroBytes(random);
            String salt = BitConverter.ToString(random).Replace("-", "").ToLower();

            //hash password
            SHA512 sha512 = new SHA512Managed();
            byte[] data = Encoding.UTF8.GetBytes(salt + newPass);
            byte[] hash = sha512.ComputeHash(data); //hash
            String password = salt + "." + BitConverter.ToString(hash).Replace("-", "").ToLower();

            //update database
            try {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO account (AcoountID, Username, Password, Enable) VALUES (@id, @Username, @Password, @Enable); INSERT INTO staff (AccountID, DepartmentID, FullRealName, isManager) VALUES (@id, @DepartmentID, @FullRealName, @isManager);", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Username", tb_username.Text);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Enable", cb_enable.Checked);
                cmd.Parameters.AddWithValue("@DepartmentID", cb_department.SelectedIndex+1);
                cmd.Parameters.AddWithValue("@FullRealName", tb_FullRealName.Text.Trim());
                cmd.Parameters.AddWithValue("@isManager", cb_isManager.Checked);
                cmd.ExecuteNonQuery();

                MessageBox.Show("User (" + id + ") create successfully!\nPassword is: AcoountID+Username", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Information); //ok msg
                DialogResult = DialogResult.OK;
                this.Close();
            } catch (MySqlException ex) {
                MessageBox.Show("Username already exists, please choose another name", "Already exists.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        private void Create_Account_Load(object sender, EventArgs e) {
            Program.addPage();
            cb_department.SelectedIndex = 0;
        }

        private void Create_Account_FormClosed(object sender, FormClosedEventArgs e) {
            Program.removePage();
        }

        private void Change_back_color(object sender, EventArgs e) {
            TextBox tb = (TextBox) sender;
            tb.BackColor = SystemColors.Window;
            errorProvider1.SetError(tb, "");
        }

        private void tb_Validating(object sender, CancelEventArgs e) {
            //Validating
            TextBox tb = (TextBox) sender;

            //if Empty
            if (String.IsNullOrEmpty(tb.Text)) {
                e.Cancel = true;
                errorProvider1.SetError(tb, "Please fill information");
                tb.BackColor = Color.LightCoral;
            }

            //if format does not match
            if (tb.Equals(tb_username)) {
                Regex rex = new Regex("^[A-za-z0-9]+$");
                if (!rex.IsMatch(tb.Text)) {
                    e.Cancel = true;
                    errorProvider1.SetError(tb, "Only letters or number are accepted");
                    tb.BackColor = Color.LightCoral;
                }
            }
            if (tb.Equals(tb_FullRealName)) {
                Regex rex = new Regex("^[A-za-z\\s]+$");
                if (!rex.IsMatch(tb.Text)) {
                    e.Cancel = true;
                    errorProvider1.SetError(tb, "Only letters are accepted");
                    tb.BackColor = Color.LightCoral;
                }
             }
        }
    }
}
