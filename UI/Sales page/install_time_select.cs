using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M.Sales_page {
    public partial class Install_time_select : Form {

        public DateTime DateTime { get; set; }

        public Install_time_select(DateTime delivery_DateTime) {
            this.DateTime = delivery_DateTime;
            InitializeComponent();
        }

        private void delivery_time_select_Load(object sender, EventArgs e) {
            dt_date.Value = DateTime.AddDays(3); //set today + 3day
            dt_date.MinDate = DateTime.AddDays(3); //set min today + 3day
            dt_date.MaxDate = DateTime.AddMonths(5); //set max today + 5month
        }

        //save
        private void bt_save_Click(object sender, EventArgs e) {
            DateTime = dt_date.Value; //日期

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
