using ITP4915M.API;
using UI.Technical_Support_page;
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

namespace UI.Technical_Support_Page
{
    public partial class Technical_Support_Page : Form
    {
        private MySqlConnection conn;
        private Account_Details acc;

        public Technical_Support_Page(MySqlConnection conn, Account_Details acc)
        {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
        }

        private void arrangeInstallationWorkersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Arrange_installation(conn, acc).Show();
        }

        private void Technical_support_Load(object sender, EventArgs e)
        {
            Program.addPage();
        }
    }
}
