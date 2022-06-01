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

namespace UI.Technical_Support_page
{
    public partial class Arrange_installation : Form
    {
        private MySqlConnection conn;
        private Account_Details acc;

        public Arrange_installation(MySqlConnection conn, Account_Details acc) {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
        }

        private void Arrange_installation_FormClosed(object sender, FormClosedEventArgs e) {
            Program.removePage();
        }

        private void Arrange_installation_Load(object sender, EventArgs e) {
            Program.addPage();

           // try {

         //   }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void lb_order_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
