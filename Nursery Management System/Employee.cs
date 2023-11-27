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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            EEmployee eEmployee = new EEmployee();
            OEmployee oEmployee = new OEmployee();

            int count = 0;  //9 = 9
            string output = "Please fill up all/ recheck sections!";
            double testDouble;
            int testInt;

            string test = txtName.Text;            // -----------------Insert _ Name = Abid [0] - [4]
            bool flag = false;

            /* for (int i = 0; i < test.Length; i++)
             {
                 flag = int.TryParse(txtName.Text, out i);  //int or not? true/false
                 if (flag == true)
                 {
                     break;
                 }
             } */

            flag = test.All(c => Char.IsLetter(c) || c == ' ');

            if (!flag || string.IsNullOrEmpty(test))  //int or null both input invalid
            {
                output = output + "\nEnter valid name without any symbols or number.";
            }
            else
            {
                eEmployee.Name = txtName.Text;
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
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "E"))  //IsNotNull? and 'E' in first
            {
                eEmployee.ID = txtId.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nInput a valid ID in Number starts with E.";
            }

            if (rbtnMale.Checked)          //---------------------------Insert _ Gender
            {
                eEmployee.Gender = rbtnMale.Text;
                rbtnFemale.Checked = false;
                rbtnOther.Checked = false;
                count++;
            }
            else if (rbtnFemale.Checked)
            {
                eEmployee.Gender = rbtnFemale.Text;
                rbtnMale.Checked = false;
                rbtnOther.Checked = false;
                count++;
            }
            else
            {
                eEmployee.Gender = rbtnOther.Text;
                rbtnFemale.Checked = false;
                rbtnMale.Checked = false;
                count++;  // count = 3
            }

            DateTime testDate = dateOfBirth.Value;   //------------------------Insert Date Time
            DateTime adult = new DateTime(2003, 07, 17);
            if (testDate < adult)
            {
                eEmployee.DoB = dateOfBirth.Value;
                count++; //count = 4
            }
            else
            {
                output = output + "\nSelect Date of Birth correctly.\n'Must be adult or 18 years old to be an employee'";
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
            } */

            if ((test.All(Char.IsLetterOrDigit)) && !string.IsNullOrEmpty(test))  // all are numbers and not null 
            {
                eEmployee.Phone = txtPhone.Text;
                count++; //count = 5
            }
            else
            {
                output = output + "\nEnter Valid Phone Number.";
            }

            /*else
            {
                output = output + "\nEnter Valid Phone Number.";
            }*/


            test = txtAddress.Text;   //------------------------Insert _Address
            if (string.IsNullOrEmpty(test))  // is it null?
            {
                output = output + "\nEnter Address.";
            }
            else
            {
                eEmployee.Address = txtAddress.Text;
                count++;  // Count = 6
            }


            test = comboBoxRole.Text;   //--------------------------------Insert Role
            if (string.IsNullOrEmpty(test))   //is it null?
            {
                output = output + "\nSelect Role.";
            }
            else
            {
                eEmployee.Role = comboBoxRole.Text;
                count++;  //Count = 7
            }

            flag = false;
            test = txtSalary.Text;                 // -----------------Insert _ Salary

            for (int i = 0; i < test.Length; i++)
            {
                flag = int.TryParse(txtSalary.Text, out i);
                if (flag == false)
                {
                    break;
                }
            }

            if (flag && !string.IsNullOrEmpty(test))   // all are integers and not null = 0
            {
                testDouble = Convert.ToDouble(txtSalary.Text);   //Convert into double to check = 0 

                if (testDouble > 0)
                {
                    eEmployee.Salary = Convert.ToDouble(txtSalary.Text);
                    count++;  //count = 8 
                }
                else
                {
                    output = output + "\nEnter Valid Salary.";
                }
            }
            else
            {
                output = output + "\nEnter Valid Salary.";
            }


            test = txtPasswoard.Text;   ////////////////////////Insert Password
            int length = test.Length;
            if (string.IsNullOrEmpty(test))  //is it null?
            {
                output = output + "\nEnter Password.";
            }
            else
            {
                if (length > 5)
                {
                    eEmployee.Password = txtPasswoard.Text;
                    count++;  //count = 9
                }
                else
                {
                    output = output + "\nEnter Password at least 6 letters.";
                }
            }

            //EntUser entUser = entEmployee;

            if (count == 9) // ------- all conditions are fullfilled
            {
                int check = oEmployee.Insert(eEmployee);

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

        private void btnShow_Click(object sender, EventArgs e)
        {
            OEmployee oEmployee = new OEmployee();
            SqlDataAdapter sqlDataAdapter = oEmployee.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataViewEmployee.DataSource = dataTable;
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'theNurseryManagementSystemDataSet.TEmployee' table. You can move, or remove it, as needed.
            this.tEmployeeTableAdapter.Fill(this.theNurseryManagementSystemDataSet.TEmployee);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            EEmployee eEmployee = new EEmployee();
            OEmployee oEmployee = new OEmployee();

            int count = 0;  //9 = 9
            string output = "Please fill up all/ recheck sections!";
            double testDouble;
            int testInt;

            string test = txtName.Text;            // -----------------Insert _ Name = Abid [0] - [4]
            bool flag = false;

            /* for (int i = 0; i < test.Length; i++)
             {
                 flag = int.TryParse(txtName.Text, out i);  //int or not? true/false
                 if (flag == true)
                 {
                     break;
                 }
             } */

            flag = test.All(c => Char.IsLetter(c) || c == ' ');

            if (!flag || string.IsNullOrEmpty(test))  //int or null both input invalid
            {
                output = output + "\nEnter valid name without any symbols or number.";
            }
            else
            {
                eEmployee.Name = txtName.Text;
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
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "E"))  //IsNotNull? and 'E' in first
            {
                eEmployee.ID = txtId.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nInput a valid ID in Number starts with E.";
            }

            if (rbtnMale.Checked)          //---------------------------Insert _ Gender
            {
                eEmployee.Gender = rbtnMale.Text;
                rbtnFemale.Checked = false;
                rbtnOther.Checked = false;
                count++;
            }
            else if (rbtnFemale.Checked)
            {
                eEmployee.Gender = rbtnFemale.Text;
                rbtnMale.Checked = false;
                rbtnOther.Checked = false;
                count++;
            }
            else
            {
                eEmployee.Gender = rbtnOther.Text;
                rbtnFemale.Checked = false;
                rbtnMale.Checked = false;
                count++;  // count = 3
            }

            DateTime testDate = dateOfBirth.Value;   //------------------------Insert Date Time
            DateTime adult = new DateTime(2003, 07, 17);
            if (testDate < adult)
            {
                eEmployee.DoB = dateOfBirth.Value;
                count++; //count = 4
            }
            else
            {
                output = output + "\nSelect Date of Birth correctly.\n'Must be adult or 18 years old to be an employee'";
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
                eEmployee.Phone = txtPhone.Text;
                count++; //count = 5
            }
            else
            {
                output = output + "\nEnter Valid Phone Number.";
            }

            /*else
            {
                output = output + "\nEnter Valid Phone Number.";
            }*/


            test = txtAddress.Text;   //------------------------Insert _Address
            if (string.IsNullOrEmpty(test))  // is it null?
            {
                output = output + "\nEnter Address.";
            }
            else
            {
                eEmployee.Address = txtAddress.Text;
                count++;  // Count = 6
            }


            test = comboBoxRole.Text;   //--------------------------------Insert Role
            if (string.IsNullOrEmpty(test))   //is it null?
            {
                output = output + "\nSelect Role.";
            }
            else
            {
                eEmployee.Role = comboBoxRole.Text;
                count++;  //Count = 7
            }

            flag = false;
            test = txtSalary.Text;                 // -----------------Insert _ Salary

            for (int i = 0; i < test.Length; i++)
            {
                flag = int.TryParse(txtSalary.Text, out i);
                if (flag == false)
                {
                    break;
                }
            }

            if (flag && !string.IsNullOrEmpty(test))   // all are integers and not null = 0
            {
                testDouble = Convert.ToDouble(txtSalary.Text);   //Convert into double to check = 0 

                if (testDouble > 0)
                {
                    eEmployee.Salary = Convert.ToDouble(txtSalary.Text);
                    count++;  //count = 8 
                }
                else
                {
                    output = output + "\nEnter Valid Salary.";
                }
            }
            else
            {
                output = output + "\nEnter Valid Salary.";
            }


            test = txtPasswoard.Text;   ////////////////////////Insert Password
            int length = test.Length;
            if (string.IsNullOrEmpty(test))  //is it null?
            {
                output = output + "\nEnter Password.";
            }
            else
            {
                if (length > 5)
                {
                    eEmployee.Password = txtPasswoard.Text;
                    count++;  //count = 9
                }
                else
                {
                    output = output + "\nEnter Password at least 6 letters.";
                }
            }

            //EntUser eUser = eEmployee;

            if (count == 9) // ------- all conditions are fullfilled
            {
                int check = oEmployee.Update(eEmployee);

                if (check > 0)
                {
                    MessageBox.Show("Updated!");
                    count = 0;
                    output = "Please fill up/Recheck all sections!";
                }
                else
                {
                    MessageBox.Show("Update Failed!");
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
