using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.IT
{
    public partial class Account_Management : Form
    {
        public Account_Management()
        {
            InitializeComponent();
        }

        private void Account_Management_FormClosed(object sender, FormClosedEventArgs e) {
            Program.removePage();
        }

        private void Account_Management_Load(object sender, EventArgs e) {
            Program.addPage();
        }
    }
}
