using ITP4915M.API;
using ITP4915M.IT;
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

namespace UI.IT
{
    public partial class Account_Management : Form
    {
        private MySqlConnection conn;
        private Account_Details acc;
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

            try {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT s.AccountID, s.FullRealName, a.Username, s.DepartmentID, s.isManager, a.Enable From staff AS s, account AS a WHERE s.AccountID = a.AcoountID", conn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

                DataSet ds_staff = new DataSet();
                adapter.Fill(ds_staff, "Staff List");

                ds_staff.Tables[0].Columns.Add("Department");
                for (int i = 0; i < ds_staff.Tables[0].Rows.Count; i++) {
                    ds_staff.Tables[0].Rows[i]["Department"] = Department.Get_DepartmentName((int) ds_staff.Tables[0].Rows[i]["DepartmentID"]);
                }
                ds_staff.Tables[0].Columns.Remove("DepartmentID");

                bindingSource1.DataSource = ds_staff;
                bindingSource1.DataMember = "Staff List";
                dataGrid_staffList.DataSource = bindingSource1;

                tb_full_name.DataBindings.Add(new Binding("Text", bindingSource1, "FullRealName", true));
                tb_username.DataBindings.Add(new Binding("Text", bindingSource1, "Username", true));
                tb_department.DataBindings.Add(new Binding("SelectedItem", bindingSource1, "Department", true));
                cb_is_manager.DataBindings.Add(new Binding("Checked", bindingSource1, "isManager", true));
                cb_enable.DataBindings.Add(new Binding("Checked", bindingSource1, "Enable", true));

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
            new Create_Account().Show();
        }

        private void bt_del_account_Click(object sender, EventArgs e) {
            //MessageBox.Show("test");
            if(dataGrid_staffList.SelectedRows.Count > 0) {
                List<string> list = new List<string>();
                for (int i = 0;i< dataGrid_staffList.SelectedRows.Count; i++) {
                    list.Add(dataGrid_staffList.SelectedRows[i].Cells["AccountID"].Value.ToString());
                }
                MessageBox.Show(list.Count.ToString());
            } else if(dataGrid_staffList.SelectedCells.Count > 0) {
                List<string> list = new List<string>();
                for (int i = 0; i < dataGrid_staffList.SelectedCells.Count; i++) {
                    String id = dataGrid_staffList.Rows[dataGrid_staffList.SelectedCells[i].RowIndex].Cells["AccountID"].Value.ToString();
                    if(!list.Contains(id)) list.Add(id);
                }
                MessageBox.Show(list.Count.ToString());
            }
        }

        private void Search_change(object sender, EventArgs e) {
            bindingSource1.Filter = String.Format("AccountID LIKE '%{0}%' OR FullRealName LIKE '%{0}%' OR Username LIKE '%{0}%'", tb_serach.Text);
        }
    }
}
