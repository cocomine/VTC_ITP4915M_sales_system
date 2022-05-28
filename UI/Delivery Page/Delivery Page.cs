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

namespace UI.Delivery_Page
{


    public partial class Delivery_Page : Form
    {
        private MySqlConnection conn;
        private Account_Details acc; //comment
        public Delivery_Page(MySqlConnection conn, Account_Details acc)
        {
            this.conn = conn;
            this.acc = acc;
            InitializeComponent();
        }

        private void Delivery_Page_Load(object sender, EventArgs e) {
            Program.addPage();

            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * from delivery", conn);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

        }

        private void Delivery_Page_Closing(object sender, FormClosingEventArgs e) {
            Program.removePage();
        }



        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
