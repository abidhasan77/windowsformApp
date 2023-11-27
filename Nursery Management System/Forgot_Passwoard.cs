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
    public partial class Forgot_Passwoard : Form
    {
        public Forgot_Passwoard()
        {
            InitializeComponent();
        }

        private void rbtnEmployee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Forgot_Passwoard_Load(object sender, EventArgs e)
        {

        }

        private void linklblBacktoLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }
    }
}
