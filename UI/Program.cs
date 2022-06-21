using ITP4915M.API;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ITP4915M;

namespace UI
{
    internal static class Program
    {
        private static MySqlConnection conn; //sql Connection
        private static int pageNum = 0;
        private static readonly string SQLConnectionString = "server=127.0.0.1;uid=root;database=itp4915m_sales_system"; //sql server ConnectionString

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Connect sql
            try {
                conn = new MySqlConnection(SQLConnectionString);
                conn.Open();
                //MessageBox.Show(myConnectionString+"\nSQL Connect!", "SQL", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //startup
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                new Login(conn).Show(); //show login page
                Application.Run();

            } catch (MySqlException ex) {
                MessageBox.Show(SQLConnectionString+"\n"+ex.Message, "SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        /// <summary>After logging in, go to menu page</summary>
        /// <param name="acc">ITP4915M.API.Account_Details</param>
        public static void JumpPage(Account_Details acc) {
            Console.WriteLine(acc);
            new Main_Menu(SQLConnectionString, acc, conn).Show();
        }

        //open form
        public static void OpenFrom(Form form) {
            //get opened forms
            FormCollection forms = Application.OpenForms;
            Form oldForm = forms[form.Name];

            //check have same form opened
            if (oldForm == null) {
                form.Show(); //not have same
            } else {
                oldForm.Focus(); //have same
                form.Dispose();
            }
        }

        //logout, show login form
        public static void Logout() {
            //get opened forms
            FormCollection forms = Application.OpenForms;
            List<Form> form_list = forms.Cast<Form>().ToList();

            addPage(); //防止結束程式
            form_list.ForEach(form => form.Close()); //關閉所有視窗
            new Login(conn).Show(); //跳出登入視窗
            removePage(); //恢復正確計數
        }
    }
}
