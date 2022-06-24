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

namespace UI.Inventory_page
{
    public partial class Purchase_item : Form
    {
        private MySqlConnection conn;

        public Purchase_item(MySqlConnection conn) {
            this.conn = conn;
            InitializeComponent();
        }

        private void Purchase_item_Load(object sender, EventArgs e)
        {
            Program.addPage();
        }

        private void Purchase_item_Cloing(object sender, FormClosingEventArgs e)
        {
            Program.removePage();
        }
    }
}
