using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITP4915M.API;

namespace ITP4915M.Sales_page {
    public partial class Delivery_time_select : Form {

        public DateTime Date { get; set; }
        public int Time { get; set; }
        private Lang lang;

        public Delivery_time_select() {
            InitializeComponent();
            lang = new Lang(typeof(Delivery_time_select));
        }

        private void delivery_time_select_Load(object sender, EventArgs e) {
            dt_date.Value = DateTime.Now.AddDays(3); //set today + 3day
            dt_date.MinDate = DateTime.Now.AddDays(3); //set min today + 3day
            dt_date.MaxDate = DateTime.Now.AddMonths(5); //set max today + 5month
        }

        //save
        private void bt_save_Click(object sender, EventArgs e) {
            //Validate
            if (cb_time.SelectedIndex < 0) {
                errorProvider1.SetError(cb_time, lang.GetString("Please_select_a_time_period"));
                cb_time.BackColor = Color.LightCoral;
                return;
            }

            Date = dt_date.Value; //日期
            Time = cb_time.SelectedIndex; //時段

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
