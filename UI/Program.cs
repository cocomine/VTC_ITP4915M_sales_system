using ITP4915M.API;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    internal static class Program
    {
        private static MySqlConnection conn; //sql Connection
        private static int pageNum = 0;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //sql server ConnectionString
            string myConnectionString = "server=127.0.0.1;uid=root;" +
                "database=itp4915m_sales_system";

            //Connect sql
            try {
                conn = new MySqlConnection(myConnectionString);
                conn.Open();
                MessageBox.Show(myConnectionString+"\nSQL Connect!", "SQL", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //startup
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                new Login(conn).Show(); //show login page
                Application.Run();

            } catch (MySqlException ex) {
                MessageBox.Show(myConnectionString+"\n"+ex.Message, "SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Increase the number of windows
        /// </summary>
        public static void addPage() { pageNum += 1; }
        /// <summary>
        /// Reduce the number of windows<br></br>
        /// if 0, exit application
        /// </summary>
        public static void removePage() { 
            pageNum -= 1; 
            if (pageNum <= 0) Application.Exit(); 
        }

        /// <summary>After logging in, go to different pages according to the department</summary>
        /// <param name="acc">ITP4915M.API.Account_Details</param>
        public static void JumpPage(Account_Details acc) {
            Console.WriteLine(acc);
            switch (acc.Get_departmentID()) {
                case Department.Sales:
                    new Sales_page.Sales_Page().Show();
                    break;
                case Department.Inventory:
                    new Inventory_page.Inventory_page().Show();
                    break;
                case Department.Accounting:
                    new Accounting_page.Accounting_page().Show();
                    break;
                case Department.Technical_Support:
                    new Technical_Support_Page.Technical_Support_Page(conn, acc).Show();
                    break;
                case Department.IT:
                case Department.CEO:
                    new IT.Account_Management(conn, acc).Show();
                    break;
                case Department.Delivery:
                    new Delivery_Page.Delivery_Page(conn, acc).Show();
                    break;
                case Department.Installer:
                    new Installer_Page.Installer_Page(conn, acc).Show();
                    break;
                default:
                    MessageBox.Show("You are not in the right department.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                    break;
            }
        }
    }
}
