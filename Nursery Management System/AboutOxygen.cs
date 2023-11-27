using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class AboutOxygen : Form
    {
        public AboutOxygen()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBacktoDashboard_Click(object sender, EventArgs e)
        {
            new DashboardAdmin().Show();
            this.Hide();
        }
    }
}
