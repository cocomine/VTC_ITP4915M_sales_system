using DocumentFormat.OpenXml.Spreadsheet;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Inventory_page
{
    public partial class Inventory_quantity : Form
    {
        private MySqlConnection conn;
        public Inventory_quantity(MySqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }



        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Inventory_quantity_Load(object sender, EventArgs e)
        {
            Program.addPage();

            MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from delivery", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;


        }

        private void Inventory_quantity_Closing(object sender, FormClosingEventArgs e)
        {
            Program.removePage();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
