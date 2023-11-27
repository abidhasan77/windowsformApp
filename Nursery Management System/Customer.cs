using NurseryDataAccessLayer.Entities;
using NurseryDataAccessLayer.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{ 
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {


            ECustomer eCustomer = new ECustomer();
            OCustomer oCustomer = new OCustomer();


            int count = 0;  //5 = 5
            string output = "Please fill up all/ recheck sections!";
            double testDouble;
            int testInt;

            string test = txtName.Text;            // -----------------Insert _ Name = Abid [0] - [4]
            bool flag = false;

            flag = test.All(c => Char.IsLetter(c) || c == ' ');

            if (!flag || string.IsNullOrEmpty(test))  //int or null both input invalid
            {
                output = output + "\nEnter valid name without any integer or number.";
            }
            else
            {
                eCustomer.Name = txtName.Text;
                count++;  //count = 1
            } // end


            flag = false;
            test = txtId.Text;
            for (int i = 1; i < test.Length; i++)
            {
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }

            //test = txtId.Text;                    // ------------------------Insert _ ID (!null) = something
            if ((test.All(Char.IsLetterOrDigit)) &&(!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "C"))  //IsNotNull? and 'C' in first
            {
                eCustomer.Id = txtId.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nInput a valid ID starts with C.";
            }


            if (rbtnMale.Checked)          //---------------------------Insert _ Gender
            {
                eCustomer.Gender = rbtnMale.Text;
                rbtnFemale.Checked = false;
                rbtnOther.Checked = false;
                count++;
            }
            else if (rbtnFemale.Checked)
            {
                eCustomer.Gender = rbtnFemale.Text;
                rbtnMale.Checked = false;
                rbtnOther.Checked = false;
                count++;
            }
            else
            {
                eCustomer.Gender = rbtnOther.Text;
                rbtnFemale.Checked = false;
                rbtnMale.Checked = false;
                count++;  // count = 3
            }


            test = txtAddress.Text;   //------------------------Insert _Address
            if (string.IsNullOrEmpty(test))  // is it null?
            {
                output = output + "\nEnter Address.";
            }
            else
            {
                eCustomer.Address = txtAddress.Text;
                count++;  // Count = 6
            }

            //flag = false;
            test = txtPhone.Text;               // -----------------Insert _ Phone Number

            /*for (int i = 0; i < test.Length; i++)
            {
                flag = int.TryParse(txtPhone.Text, out i);  // true - number / integer
                if (flag == false)
                {
                    break;
                }
            }*/

            if ((test.All(Char.IsLetterOrDigit)) && !string.IsNullOrEmpty(test))  // all are numbers and not null 
            {
                eCustomer.Phone = Convert.ToDouble(txtPhone.Text);
                count++; //count = 5
            }
            else
            {
                output = output + "\nEnter Valid Phone Number.";
            }





            if (count == 5) // ------- all conditions are fullfilled
            {
                int check = oCustomer.Insert(eCustomer);

                if (check > 0)
                {
                    MessageBox.Show("Inserted!");
                    count = 0;
                    output = "Please fill up/Recheck all sections!";
                }
                else
                {
                    MessageBox.Show("Insertion Failed!");
                    count = 0;
                    output = "Please fill up/Recheck all sections!";
                }
            }
            else
            {
                MessageBox.Show(output);
                count = 0;//--------------------------------------------------count must be zero to reset
                output = "Please fill up/Recheck all sections!"; //------------------- reset to default
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'theNurseryManagementSystemDataSet1.TCustomer' table. You can move, or remove it, as needed.
            this.tCustomerTableAdapter.Fill(this.theNurseryManagementSystemDataSet1.TCustomer);

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            OCustomer oCustomer = new OCustomer();
            SqlDataAdapter sqlDataAdapter = oCustomer.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataViewCustomer.DataSource = dataTable;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ECustomer eCustomer = new ECustomer();
            OCustomer oCustomer = new OCustomer();


            int count = 0;  //5 = 5
            string output = "Please fill up all/ recheck sections!";
            double testDouble;
            int testInt;

            string test = txtName.Text;            // -----------------Insert _ Name = Abid [0] - [4]
            bool flag = false;

            flag = test.All(char.IsLetter);

            if (!flag || string.IsNullOrEmpty(test))  //int or null both input invalid
            {
                output = output + "\nEnter valid name without any integer or number.";
            }
            else
            {
                eCustomer.Name = txtName.Text;
                count++;  //count = 1
            } // end

            /////////////////////////////
            ///


            flag = false;
            test = txtId.Text;
            for (int i = 1; i < test.Length; i++)
            {
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }


            // test = txtId.Text;                    // ------------------------Insert _ ID (!null) = something
            if ((test.All(Char.IsLetterOrDigit)) && (!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "C"))  //IsNotNull? and 'C' in first
            {
                eCustomer.Id = txtId.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nInput a valid ID starts with C.";
            }

            ////////////////

            if (rbtnMale.Checked)          //---------------------------Insert _ Gender
            {
                eCustomer.Gender = rbtnMale.Text;
                rbtnFemale.Checked = false;
                rbtnOther.Checked = false;
                count++;
            }
            else if (rbtnFemale.Checked)
            {
                eCustomer.Gender = rbtnFemale.Text;
                rbtnMale.Checked = false;
                rbtnOther.Checked = false;
                count++;
            }
            else
            {
                eCustomer.Gender = rbtnOther.Text;
                rbtnFemale.Checked = false;
                rbtnMale.Checked = false;
                count++;  // count = 3
            }


            test = txtAddress.Text;   //------------------------Insert _Address
            if (string.IsNullOrEmpty(test))  // is it null?
            {
                output = output + "\nEnter Address.";
            }
            else
            {
                eCustomer.Address = txtAddress.Text;
                count++;  // Count = 4
            }

            //flag = false;
            test = txtPhone.Text;               // -----------------Insert _ Phone Number

           /* for (int i = 0; i < test.Length; i++)
            {
                flag = int.TryParse(txtPhone.Text, out i);  // true - number / integer
                if (flag == false)
                {
                    break;
                }
            } */

            if ((test.All(Char.IsLetterOrDigit))  && !string.IsNullOrEmpty(test))  // all are numbers and not null 
            {
                eCustomer.Phone = Convert.ToDouble(txtPhone.Text);
                count++; //count = 5
            }
            else
            {
                output = output + "\nEnter Valid Phone Number.";
            }





            if (count == 5) // ------- all conditions are fullfilled
            {
                int check = oCustomer.Update(eCustomer);

                if (check > 0)
                {
                    MessageBox.Show("Updated!");
                    count = 0;
                    output = "Please fill up/Recheck all sections!";
                }
                else
                {
                    MessageBox.Show("Update  Failed!");
                    count = 0;
                    output = "Please fill up/Recheck all sections!";
                }
            }
            else
            {
                MessageBox.Show(output);
                count = 0;//--------------------------------------------------count must be zero to reset
                output = "Please fill up/Recheck all sections!"; //------------------- reset to default
            }



        }
    }
}
