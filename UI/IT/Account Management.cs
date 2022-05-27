using ITP4915M.API;
using ITP4915M.IT;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.IT
{
    public partial class Account_Management : Form
    {
        private MySqlConnection conn;
        private Account_Details acc;
        private Dictionary<string, Binding> binding = new Dictionary<string, Binding>();
        public Account_Management(MySqlConnection conn, Account_Details acc)
        {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
        }

        private void Account_Management_FormClosed(object sender, FormClosedEventArgs e) {
            Program.removePage();
        }

        private void Account_Management_Load(object sender, EventArgs e) {
            Program.addPage();
            cb_filter_department.SelectedIndex = 0;
            cb_Filter_Enable.SelectedIndex = 0;
            cb_Filter_isManager.SelectedIndex = 0;

            try {
                //SelectCommand
                adapter.SelectCommand = new MySqlCommand("SELECT s.AccountID, s.FullRealName, a.Username, s.DepartmentID, s.isManager, a.Enable From staff AS s, account AS a WHERE s.AccountID = a.AcoountID", conn);
                //DeleteCommand
                MySqlCommand cmd = new MySqlCommand("DELETE FROM account WHERE AcoountID = @id", conn);
                MySqlParameter parameter = cmd.Parameters.Add("@id", MySqlDbType.VarChar, 10, "AccountID");
                parameter.SourceVersion = DataRowVersion.Original;
                adapter.DeleteCommand = cmd;
                //UpdateCommand
                cmd = new MySqlCommand("UPDATE account SET Username = @Username, Enable = @Enable WHERE AcoountID = @id; UPDATE staff SET FullRealName = @FullRealName, isManager = @isManager, DepartmentID = @DepartmentID WHERE AccountID = @id", conn);
                cmd.Parameters.Add("@Username", MySqlDbType.VarChar, 10, "Username");
                cmd.Parameters.Add("@Enable", MySqlDbType.Int32, 10, "Enable");
                cmd.Parameters.Add("@FullRealName", MySqlDbType.VarChar, 10, "FullRealName");
                cmd.Parameters.Add("@isManager", MySqlDbType.Int32, 10, "isManager");
                cmd.Parameters.Add("@DepartmentID", MySqlDbType.Int32, 10, "DepartmentID");
                parameter = cmd.Parameters.Add("@id", MySqlDbType.VarChar, 10, "AccountID");
                parameter.SourceVersion = DataRowVersion.Original;
                adapter.UpdateCommand = cmd;

                adapter.Fill(ds_staff, "Staff_List"); //fill dataset

                //get Department Name
                ds_staff.Tables[0].Columns.Add("Department");
                for (int i = 0; i < ds_staff.Tables[0].Rows.Count; i++) {
                    ds_staff.Tables[0].Rows[i]["Department"] = Department.Get_DepartmentName((int) ds_staff.Tables[0].Rows[i]["DepartmentID"]);
                }
                ds_staff.Tables[0].Columns["DepartmentID"].ColumnMapping = MappingType.Hidden; //hide DepartmentID Column
                ds_staff.Tables[0].Columns["Username"].Unique = true; //set Unique

                //binding data Source
                bindingSource1.DataSource = ds_staff;
                bindingSource1.DataMember = "Staff_List";
                dataGrid_staffList.DataSource = bindingSource1;

                //Binding textbox
                tb_id.DataBindings.Add("Text", bindingSource1, "AccountID", true);
                binding.Add(tb_full_name.Name, tb_full_name.DataBindings.Add("Text", bindingSource1, "FullRealName", true, DataSourceUpdateMode.Never));
                binding.Add(tb_username.Name, tb_username.DataBindings.Add("Text", bindingSource1, "Username", true, DataSourceUpdateMode.Never));
                cb_department.DataBindings.Add("SelectedItem", bindingSource1, "Department", true);
                cb_department.DataBindings.Add("Tag", bindingSource1, "DepartmentID", true);
                cb_is_manager.DataBindings.Add("Checked", bindingSource1, "isManager", true);
                cb_enable.DataBindings.Add("Checked", bindingSource1, "Enable", true);

            } catch (MySqlException ex) {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e) {
            new My_Profile(conn, acc).Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Create_account_Click(object sender, EventArgs e) {
            //create account
            DialogResult dialogResult = new Create_Account(conn).ShowDialog();
            Console.WriteLine(dialogResult);
            if (dialogResult == DialogResult.OK) {
                //Console.WriteLine("ok");
                ds_staff.Tables[0].Clear();
                adapter.Fill(ds_staff, "Staff_List"); //fill dataset
            }
        }

        private void bt_del_account_Click(object sender, EventArgs e) {
            //delete account
            DialogResult result = MessageBox.Show("Are you sure delete seleect user?", "Delete account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //confirm del                                                                                                                  //if confirm
            if (result == DialogResult.Yes) { //confirm
                bindingSource1.RemoveCurrent();
                adapter.Update(ds_staff, "Staff_List");
            }
        }

        private void Search_change(object sender, EventArgs e) {
            //search
            //search text 
            String filter = String.Format("(AccountID LIKE '%{0}%' OR FullRealName LIKE '%{0}%' OR Username LIKE '%{0}%')", tb_serach.Text);

            //filter department
            if (cb_filter_department.SelectedIndex > 0) {
                filter += String.Format(" AND Department = '{0}'", cb_filter_department.SelectedItem.ToString());
            }
            //filter isManager
            if (cb_Filter_isManager.SelectedIndex > 0) {
                if (cb_Filter_isManager.SelectedIndex == 1) filter += " AND isManager = 1";
                else filter += " AND isManager = 0";
            }
            //filter Enable
            if (cb_Filter_Enable.SelectedIndex > 0) {
                if (cb_Filter_Enable.SelectedIndex == 1) filter += " AND Enable = 1";
                else filter += " AND Enable = 0";
            }
            //Console.WriteLine(filter);
            bindingSource1.Filter = filter;
        }

        private void bt_save_Click(object sender, EventArgs e) {
            //save change
            DialogResult result = MessageBox.Show("Are you sure save all change?", "Delete account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //confirm update
            if (result == DialogResult.Yes) { //confirm
                adapter.Update(ds_staff, "Staff_List");
            }
        }

        private void tb_department_SelectedIndexChanged(object sender, EventArgs e) {
            //sync update department id
            int new_department = cb_department.SelectedIndex + 1;
            cb_department.Tag = new_department;
        }

        private void bt_reset_pass_Click(object sender, EventArgs e) {
            //reset password
            DialogResult result = MessageBox.Show("Are you sure reset this user password?", "Delete account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //confirm reset
            if (result == DialogResult.Yes) { //confirm
                String newPass = tb_id.Text + tb_username.Text;

                //generation salt
                var rng = new RNGCryptoServiceProvider();
                byte[] random = new byte[16];
                rng.GetNonZeroBytes(random);
                String salt = BitConverter.ToString(random).Replace("-", "").ToLower();
                //Console.WriteLine(salt);

                //hash password
                SHA512 sha512 = new SHA512Managed();
                byte[] data = Encoding.UTF8.GetBytes(salt + newPass);
                byte[] hash = sha512.ComputeHash(data); //hash
                String password = salt + "." + BitConverter.ToString(hash).Replace("-", "").ToLower();

                //update database
                try {
                    MySqlCommand cmd = new MySqlCommand("UPDATE account SET Password = @password WHERE AcoountID = @acoountID", conn);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@acoountID", tb_id.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User ("+ tb_id.Text + ") Reset successfully!\nNew password is: AcoountID+Username", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Information); //ok msg
                } catch (MySqlException ex) {
                    Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
                }
            }
        }

        private void dataGrid_staffList_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            //Handler DataError
            MessageBox.Show(e.Exception.Message, "發生錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Change_back_normal(object sender, EventArgs e) {
            //clear error
            TextBox tb = (TextBox)sender;
            tb.BackColor = SystemColors.Window;
            errorProvider1.SetError(tb, "");
        }

        private void tb_Validating(object sender, CancelEventArgs e) {
            //Validating
            TextBox tb = (TextBox)sender;

            //if Empty
            if (String.IsNullOrEmpty(tb.Text)) {
                e.Cancel = true;
                tb.Focus();
                errorProvider1.SetError(tb, "Please fill information");
                tb.BackColor = Color.LightCoral;
            }

            //if format does not match
            if (tb.Equals(tb_username)) {
                Regex rex = new Regex("^[A-za-z]+$");
                if (!rex.IsMatch(tb.Text)) {
                    e.Cancel = true;
                    tb.Focus();
                    errorProvider1.SetError(tb, "Only letters are accepted");
                    tb.BackColor = Color.LightCoral;
                }
            }
            if (tb.Equals(tb_full_name)) {
                Regex rex = new Regex("^[A-za-z\\s]+$");
                if (!rex.IsMatch(tb.Text)) {
                    e.Cancel = true;
                    tb.Focus();
                    errorProvider1.SetError(tb, "Only letters are accepted");
                    tb.BackColor = Color.LightCoral;
                }
            }
        }

        private void tb_Validated(object sender, EventArgs e) {
            //if Validated will update
            TextBox tb = (TextBox)sender;
            binding[tb.Name].WriteValue();
        }
    }
}
