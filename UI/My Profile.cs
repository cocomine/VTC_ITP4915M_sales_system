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


        }

        private void My_Profile_Closing(object sender, FormClosingEventArgs e) {
            Program.removePage();
        }
    }
}
