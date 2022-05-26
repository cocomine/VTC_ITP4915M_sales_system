using ITP4915M.API;
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
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT s.AccountID, s.FullRealName, a.Username, s.DepartmentID, s.isManager From staff AS s, account AS a WHERE s.AccountID = a.AcoountID", conn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

                DataSet ds_staff = new DataSet();
                adapter.Fill(ds_staff, "Staff List");

                ds_staff.Tables[0].Columns.Add("Department");
                for (int i = 0; i < ds_staff.Tables[0].Rows.Count; i++) {
                    ds_staff.Tables[0].Rows[i]["Department"] = Department.Get_DepartmentName((int) ds_staff.Tables[0].Rows[i]["DepartmentID"]);
                }
                ds_staff.Tables[0].Columns.Remove("DepartmentID");

                dataGrid_staffList.DataSource = ds_staff;
                dataGrid_staffList.DataMember = "Staff List";

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
    }
}
