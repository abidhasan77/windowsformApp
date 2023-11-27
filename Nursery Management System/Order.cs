using NurseryDataAccessLayer.Entities;
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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void lblPlantAmount_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            EOrder eOrder = new EOrder();
            OOrder oOrder = new OOrder();


            int count = 0;  //5 = 5
            string output = "Please fill up all/ recheck sections!";
            double testDouble;
            int testInt;

            string test ;            // -----------------Insert _ Name = Abid [0] - [4]
            bool flag = false;



            flag = false;
            test = txtOrderID.Text;
            for (int i =1; i< test.Length; i++ )
            {
                flag = Char.IsDigit(test[i]);
                if(flag == false)
                {
                    break;
                }
            }


            //test = txtCustomerID.Text;                    // ------------------------Insert _ ID (!null) = something
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "C"))  //IsNotNull? and 'C' in first
            {
                eOrder.OrderId = txtOrderID.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nInput a valid Order ID in Number starts with C.";
            }


            ///////////////////////////////
            ///

            if (rbtnPending.Checked)          //---------------------------Insert _ Orer Status
            {
                eOrder.OrderStatus = rbtnDelivered.Text;
                rbtnDelivered.Checked = false;
                rbtnPending.Checked = false;
                count++;
            }
            else if (rbtnDelivered.Checked)
            {
                eOrder.OrderStatus = rbtnDelivered.Text;
                rbtnPending.Checked = false;
                rbtnPending.Checked = false;
                count++;
            }
            else
            {
                eOrder.OrderStatus = rbtnInProcess.Text;
                rbtnPending.Checked = false;
                rbtnDelivered.Checked = false;          
                count++;  // count = 3
            }

            /////////////////////////////////////
            ///

            flag = false;
            test = txtCustomerID.Text;
            for (int i = 1; i < test.Length; i++)
            {
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }

            //test = txtCustomerID.Text;                    // ------------------------Insert _ ID (!null) = something
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "E"))  //IsNotNull? and 'E' in first
            {
                eOrder.CustomerId = txtCustomerID.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nInput a valid ID starts with E.";
            }


            /////////////////////////////////////
            ///
            flag = false;
            test = txtPlantID.Text;
            for (int i = 1; i < test.Length; i++)
            {
                flag = Char.IsDigit(test[i]);
                if (flag == false)
                {
                    break;
                }
            }

           // test = txtPlantID.Text;                    // ------------------------Insert _ ID (!null) = something
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "P"))  //IsNotNull? and 'E' in first
            {
                eOrder.PlantId = txtPlantID.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nInput a valid ID in Number starts with P.";
            }

            //////////////////////////////////
            ///

            //flag = false;
            test = txtPlantAmount.Text;                 // -----------------Insert _ Salary

           /* for (int i = 0; i < test.Length; i++)
            {
                flag = int.TryParse(txtPlantAmount.Text, out i);
                if (flag == false)
                {
                    break;
                }
            }*/

            if ((test.All(Char.IsLetterOrDigit)) && !string.IsNullOrEmpty(test))   // all are integers and not null = 0
            {
                testInt = eOrder.PlantAmount = Convert.ToInt32(txtPlantAmount.Text);   //Convert into double to check = 0 

                if (testInt > 0)
                {
                    eOrder.PlantAmount = Convert.ToInt32(txtPlantAmount.Text);

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

            ////////////////////////////////////////////////////
            ///
            flag = false;
            bool flag2 = true;
            test = txtTotalPrice.Text;               // -----------------Insert _ Price 
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
                testDouble = Convert.ToDouble(txtTotalPrice.Text);

                if (testDouble > 0)
                {
                    eOrder.TotalPrice = Convert.ToDouble(txtTotalPrice.Text);
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
                int check = oOrder.Insert(eOrder);

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            EOrder eOrder = new EOrder();
            OOrder oOrder = new OOrder();


            int count = 0;  //5 = 5
            string output = "Please fill up all/ recheck sections!";
            double testDouble;
            int testInt;

            string test;            // -----------------Insert _ Name = Abid [0] - [4]
            bool flag = false;


            test = txtCustomerID.Text;                    // ------------------------Insert _ ID (!null) = something
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "C"))  //IsNotNull? and 'C' in first
            {
                eOrder.CustomerId = txtCustomerID.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nInput a valid ID starts with C.";
            }


            ///////////////////////////////
            ///

            if (rbtnPending.Checked)          //---------------------------Insert _ Orer Status
            {
                eOrder.OrderStatus = rbtnDelivered.Text;
                rbtnDelivered.Checked = false;
                rbtnPending.Checked = false;
                count++;
            }
            else if (rbtnDelivered.Checked)
            {
                eOrder.OrderStatus = rbtnDelivered.Text;
                rbtnPending.Checked = false;
                rbtnPending.Checked = false;
                count++;
            }
            else
            {
                eOrder.OrderStatus = rbtnInProcess.Text;
                rbtnPending.Checked = false;
                rbtnDelivered.Checked = false;
                count++;  // count = 3
            }

            /////////////////////////////////////
            ///


            test = txtCustomerID.Text;                    // ------------------------Insert _ ID (!null) = something
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "E"))  //IsNotNull? and 'E' in first
            {
                eOrder.CustomerId = txtCustomerID.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nInput a valid ID starts with E.";
            }


            /////////////////////////////////////
            ///

            test = txtPlantID.Text;                    // ------------------------Insert _ ID (!null) = something
            if ((!string.IsNullOrEmpty(test)) && (test.Substring(0, 1) == "P"))  //IsNotNull? and 'E' in first
            {
                eOrder.PlantId = txtPlantID.Text;
                count++;  //count = 2
            }
            else
            {
                output = output + "\nInput a valid ID starts with P.";
            }

            //////////////////////////////////
            ///

           // flag = false;
            test = txtPlantAmount.Text;                 // -----------------Insert _ Salary

           /* for (int i = 0; i < test.Length; i++)
            {
                flag = int.TryParse(txtPlantAmount.Text, out i);
                if (flag == false)
                {
                    break;
                }
            } */

            if ((test.All(Char.IsLetterOrDigit)) && !string.IsNullOrEmpty(test))   // all are integers and not null = 0
            {
                testInt = eOrder.PlantAmount = Convert.ToInt32(txtPlantAmount.Text);   //Convert into double to check = 0 

                if (testInt > 0)
                {
                    eOrder.PlantAmount = Convert.ToInt32(txtPlantAmount.Text);

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

            ////////////////////////////////////////////////////
            ///

            flag = false;
            bool flag2 = true;
            test = txtTotalPrice.Text;               // -----------------Insert _ Price 
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
                testDouble = Convert.ToDouble(txtTotalPrice.Text);

                if (testDouble > 0)
                {
                    eOrder.TotalPrice = Convert.ToDouble(txtTotalPrice.Text);
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
                int check = oOrder.Update(eOrder);

                if (check > 0)
                {
                    MessageBox.Show("Updated!");
                    count = 0;
                    output = "Please fill up/Recheck all sections!";
                }
                else
                {
                    MessageBox.Show("Updated Failed!");
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

        }
    }
}

