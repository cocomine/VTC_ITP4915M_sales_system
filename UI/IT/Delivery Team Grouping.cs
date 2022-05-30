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
using UI;

namespace ITP4915M.IT {
    public partial class Delivery_Team_Grouping : Form {

        private MySqlConnection conn;

        public Delivery_Team_Grouping(MySqlConnection conn) {
            this.conn = conn;
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Delivery_Team_Grouping_Load(object sender, EventArgs e) {
            Program.addPage();


        }

        private void Delivery_Team_Grouping_FormClosed(object sender, FormClosedEventArgs e) {
            Program.removePage();
        }
    }
}
