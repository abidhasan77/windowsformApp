using NurseryDataAccessLayer.Operations;
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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void linklblForgotPasswoard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Forgot_Passwoard().Show();
            this.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            OTesting oTesting = new OTesting();
            bool flag;
            DataTable dataTable = new DataTable();


            if (oTesting.AvailablitiyIDPassword(txtID.Text, txtPasswoard.Text))
            {
                dataTable = oTesting.TestIDPasword(txtID.Text, txtPasswoard.Text);
                string id = dataTable.Rows[0][1].ToString();
                string password = dataTable.Rows[0][8].ToString();

                MessageBox.Show(id);
                MessageBox.Show(password);

                if (id == txtID.Text && password == txtPasswoard.Text)
                {
                    MessageBox.Show("Success!");
                }
                else
                {
                    MessageBox.Show("Check your ID or Password");
                }
            }
            else
            {
                MessageBox.Show("Check your ID or Password");
            }

        }
    }
}
