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
    public partial class Item : Form
    {
        private MySqlConnection conn;
        public Item(MySqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void Item_Closing(object sender, FormClosingEventArgs e)
        {
            Program.removePage();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            Program.addPage();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `item`", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = Guid.NewGuid().ToString();
            MySqlCommand cmd = new MySqlCommand("update `item` set ItemID = @ItemID, SupplierID= @SupplierID Name=@Name, Price=@Price, Type=@Type, Description=@Description);", conn);
            cmd.Parameters.AddWithValue("@ItemID", IID.Text);
            cmd.Parameters.AddWithValue("@SupplierID", SID.Text);
            cmd.Parameters.AddWithValue("@Name", Iname.Text);
            cmd.Parameters.AddWithValue("@Price", int.Parse(Price.Text));
            cmd.Parameters.AddWithValue("@Type", int.Parse(numericUpDown1.Text));
            cmd.Parameters.AddWithValue("@Description", Dec.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Insert success");
            MySqlDataAdapter sqlda = new MySqlDataAdapter("SELECT * FROM `item`", conn);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                SID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                Iname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                Price.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                numericUpDown1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                Dec.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
        }
    }
}
