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
    public partial class Plants : Form
    {
        public Plants() 
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EPlants ePlants = new EPlants();
            OPlants oPlants = new OPlants();

            int count = 0;  //5 = 5
            string output = "Please fill up all/ recheck sections!";
            double testDouble;
            int testInt;

            string test = txtName.Text;            // -----------------Insert _ Name = Abid [0] - [4]
            bool flag = false;

            flag =  test.All(c => Char.IsLetter(c) || c == ' ');

            if (!flag || string.IsNullOrEmpty(test))  //int or null both input invalid
            {
                output = output + "\nEnter valid name without any integer or number.";
            }
            else
            {
                ePlants.Name = txtName.Text;
                count++;  //count = 1
            } // end

            //////////////////////////////////
            ///

            test = txtId.Text;                    // ------------------------Insert _ ID (!null) = something
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "P"))  //IsNotNull? and 'P' in first
            {
                ePlants.Id = txtId.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nInput a valid ID starts with P.";
            }

            //////////////////////
            ///
            test = comboBoxCategory.Text;   //--------------------------------Insert Role
            if (string.IsNullOrEmpty(test))   //is it null?
            {
                output = output + "\nSelect Role.";
            }
            else
            {
                ePlants.Category = comboBoxCategory.Text;
                count++;  //Count = 7
            }

            ////////////////////////////////////
            
            //flag = false;
            test = txtAmount.Text;                 // -----------------Insert _ Salary

            /*for (int i = 0; i < test.Length; i++)
            {
                flag = int.TryParse(txtAmount.Text, out i);
                if (flag == false)
                {
                    break;
                }
            }*/

            if ((test.All(Char.IsLetterOrDigit)) && !string.IsNullOrEmpty(test))   // all are integers and not null = 0
            {
                testInt = ePlants.Amount = Convert.ToInt32(txtAmount.Text);   //Convert into double to check = 0 

                if (testInt > 0)
                {
                    ePlants.Amount = Convert.ToInt32(txtAmount.Text);
                    
                    count++;  //count = 8 
                }
                else
                {
                    output = output + "\nEnter Valid Amount.";
                }
            }
            else
            {
                output = output + "\nEnter Valid Amount.";
            }

            ///////////////////////////////////////////////////////
            ///
            flag = false;
            bool flag2 = true;
            test = txtPrice.Text;               // -----------------Insert _ Price 
            int dot = 0;

            for (int i = 0; i < test.Length; i++)  // this for loop is checking amount of '.'
            {

                if (Char.IsPunctuation(test[i]))
                {
                    dot++;
                }
                if (dot > 1)
                {
                    flag2 = false;
                }

            }

            flag = test.All(c => Char.IsDigit(c) || c == '.');    //this is checking is it only digit and '.'

            if (flag && !string.IsNullOrEmpty(test) && flag2)
            {
                testDouble = Convert.ToDouble(txtPrice.Text);

                if (testDouble > 0)
                {
                    ePlants.Price = Convert.ToDouble(txtPrice.Text);
                    count++;
                }
                else
                {
                    output = output + "\nEnter Valid Price.";
                }
            }
            else
            {
                output = output + "\nEnter Valid Price.";
            }

            
            /////////////////////////

            if (count == 5) // ------- all conditions are fullfilled
            {
                int check = oPlants.Insert(ePlants);

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



        

        private void Plants_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'theNurseryManagementSystemDataSet2.TPlant' table. You can move, or remove it, as needed.
            this.tPlantTableAdapter.Fill(this.theNurseryManagementSystemDataSet2.TPlant);

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            OPlants oPlants = new OPlants();
            SqlDataAdapter sqlDataAdapter = oPlants.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataViewPlants.DataSource = dataTable;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EPlants ePlants = new EPlants();
            OPlants oPlants = new OPlants();

            int count = 0;  //5 = 5
            string output = "Please fill up all/ recheck sections!";
            double testDouble;
            int testInt;

            string test = txtName.Text;            // -----------------Insert _ Name = Atia [0] - [4]

            bool flag = false;

            flag = test.All(c => Char.IsLetter(c) || c == ' ');


            if (!flag || string.IsNullOrEmpty(test))  //int or null both input invalid
            {
                output = output + "\nEnter valid name without any integer or number.";
            }
            else
            {
                ePlants.Name = txtName.Text;
                count++;  //count = 1
            } // end

            //////////////////////////////////
            ///

            test = txtId.Text;                    // ------------------------Insert _ ID (!null) = something
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "P"))  //IsNotNull? and 'P' in first
            {
                ePlants.Id = txtId.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nInput a valid ID starts with P.";
            }

            //////////////////////
            ///
            test = comboBoxCategory.Text;   //--------------------------------Insert Role
            if (string.IsNullOrEmpty(test))   //is it null?
            {
                output = output + "\nSelect Role.";
            }
            else
            {
                ePlants.Category = comboBoxCategory.Text;
                count++;  //Count = 7
            }

            ////////////////////////////////////

            //flag = false;
            test = txtAmount.Text;                 // -----------------Insert _ Salary

            /*for (int i = 0; i < test.Length; i++)
            {
                flag = int.TryParse(txtAmount.Text, out i);
                if (flag == false)
                {
                    break;
                }
            }*/

            if (flag && !string.IsNullOrEmpty(test))   // all are integers and not null = 0
            {
                testInt = ePlants.Amount = Convert.ToInt32(txtAmount.Text);   //Convert into double to check = 0 

                if (testInt > 0)
                {
                    ePlants.Amount = Convert.ToInt32(txtAmount.Text);

                    count++;  //count = 8 
                }
                else
                {
                    output = output + "\nEnter Valid Amount.";
                }
            }
            else
            {
                output = output + "\nEnter Valid Amount.";
            }

            ///////////////////////////////////////////////////////
            ///

            flag = false;
            test = txtPrice.Text;                 // -----------------Insert _ Salary

            for (int i = 0; i < test.Length; i++)
            {
                flag = int.TryParse(txtPrice.Text, out i);
                if (flag == false)
                {
                    break;
                }
            }

            if (flag && !string.IsNullOrEmpty(test))   // all are integers and not null = 0
            {
                testDouble = ePlants.Price = Convert.ToDouble(txtPrice.Text);   //Convert into double to check = 0 

                if (testDouble > 0)
                {
                    ePlants.Price = Convert.ToDouble(txtPrice.Text);

                    count++;  //count = 8 
                }
                else
                {
                    output = output + "\nEnter Valid Price.";
                }
            }
            else
            {
                output = output + "\nEnter Valid  Price.";
            }

            /////////////////////////

            if (count == 5) // ------- all conditions are fullfilled
            {
                int check = oPlants.Update(ePlants);

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

