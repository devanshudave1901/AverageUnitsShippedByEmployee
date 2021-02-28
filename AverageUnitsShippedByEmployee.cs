// Author - Devanshu Dave
// Date - 25/02/2021
// Student ID - 100785733   
// Description - This application which will calculate the average of three emplyoees and the overall average of three employess.







using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageUnitsShippedByEmployee
{
    public partial class AverageUnitsShippedByEmployee : Form
    {
        // constants Declared for Number of Employees as int data type assigned the 3 value to it
        const int NumberofEmployees = 3;
        // constants Declared for Number of Days as int data type assigned the 7(This much days are allowed) value to it
        const int NumberofDays = 7;


        // Declared the SHipedday(the present day) to 1 and assigned the int data type to it
        int shipedday = 1;
        // Declared the current employee to 1 and assigned the int data type to it.
        int currentEmployee = 1;


        //   int totalUnitsShiped = 0;
        // 2D Array been declared for entryarray which has number of employees(1) and number of days in it.
        int[,] entryArray = new int[NumberofEmployees  , NumberofDays ];

        // array for textBox has been declared with employeeTextBoxes variable.
        TextBox[] employeeTextBoxes;
        // array for Label has been declared with employeeAverages variable.
        Label[]  employeeAverages;

        Label[] fontlabel;
        // form loaded
        public AverageUnitsShippedByEmployee()
        {
            InitializeComponent();
            // array emplyeeTextBoxes which will have the inputs from the user in it.
            employeeTextBoxes = new TextBox[] { textBoxEmployee1PastInputs, textBoxEmployee2PastInputs, textBoxEmployee3PastInputs };
            // array Emplyoee averages which will have the average of each employe stored in it and is the label type.
            employeeAverages = new Label[]  { labelEmployee1AverageOutput, labelEmployee2AverageOutput, labelEmployee3AverageOutput };

          //  fontlabel = new Label[] { labelEmployee1, labelEmployee2, labelEmployee3 };
        }

        /// <summary>
        /// This button will accept the input from the user to perform the functionality inn which it will available till the user 
        /// enters all emplyoees. This will Take the user and put it in the entry area where all inputs will be displayed and to calculate all employee 
        /// average along with overall
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonToEnterClick(object sender, EventArgs e) 
        {
            // constant declared for minimum units as int data variable and assigned it to 0.
            const int MininimunUnits = 0;
            // Decalared constant for Maximum units and assigned the value of 5000 as a int data type
            const int MaximumUnits = 5000;
            // Constant declared for MaximumDays as 7 as data type gives as int.
            const int MaximumDays = 7;
            
            // Functionality part

            //If else used for the validate the user's input.
            // user is only allowed to enter whole number.
           // so here we used try parse and with int and it will take from entry array we declared above and will use here as the input
           // comes from the user. 
            if (int.TryParse(textBoxUnitsInput.Text, out entryArray[currentEmployee - 1, shipedday - 1]))
            {
                // Now if the user enters valid input as a whole number. Now its time for validating the input in the range or not.
                if (entryArray[currentEmployee - 1 , shipedday -1 ] >= MininimunUnits && 
                    entryArray[currentEmployee -1, shipedday - 1] <= MaximumUnits)
                {
                    // to enter the input in the text boxes 

                    employeeTextBoxes[currentEmployee -1 ].Text += entryArray[currentEmployee -1 , shipedday -1 ] + "\r\n";
                    //labelEmployee1.Font = new Font(this.Font, FontStyle.Bold);
                    //labelEmployee1.Font = new Font(this.Font, FontStyle.Regular);
                    // Using if to know that we have entered for 7 dyas.
                    if ( shipedday++ >= NumberofDays )
                    {
                        // employee total is set to 0 with int data type
                        double employeeTotal = 0;
                        // Calculation for the averages for all employee using for loop
                        for (int day = 0; day  < NumberofDays; day++)
                        {
                            employeeTotal += entryArray[currentEmployee -1 , day ];

                           
                        //    fontlabel[currentEmployee + 1].Font = new Font(this.Font, FontStyle.Regular);
                        }
                        // printing.
                        employeeAverages[currentEmployee - 1].Text = "Average: " + Math.Round((float)employeeTotal /  NumberofDays, 4).ToString("0.00");
                      //  employeeAverages[currentEmployee - 1].Font = new Font(this.Font, FontStyle.Bold);
                        // So this shiedday us set to 1 again and which will tell that system has to take the input for next emplyee
                        shipedday = 1;
                        // currentempoyee incremeantation
                        currentEmployee++;
                    }
                    // check if we entered all emplyees
                    if (currentEmployee > NumberofEmployees)
                    {
                        // sum is decalred with double data type and set to 0;
                        double sum = 0;
                        //double sum1;

                        // overall calculation part.
                        // using for each loop the overall average has been calculated.
                        // so for each and we have set the condition as int averaging in the array named entry array.
                        // which will take the value and look in the  entry array.
                        foreach (int averaging in entryArray)
                        {
                            // this will add and assign the value to the sum
                            // loop will come again add and will assign to sum.
                            // full way - sum = sum + averaging.
                            // the loop will have it till it takes the value from each index.
                            sum += averaging;
                        }
                        // this is to calculate the average.
                        // which the total will be divided by the entryArray lenght( method) which willbe used to divide that to sum(total).
                        sum = sum / entryArray.Length;

                        // Printing the result and also rounding to 2 decimal
                        labelOverallAverageOutput.Text = " Average per Day " + Math.Round(sum,2).ToString("0.00");


                        // shipedday set to 1 when the all employees has entered 
                        shipedday = 1;
                        // Current employee to 0 when all employes has entered
                        currentEmployee = 0;
                        // past inputs for first emplyee box has been set to non displaying by putting enable = false.
                        textBoxEmployee1PastInputs.Enabled = false;
                        // past inputs for second emplyee box has been set to non displaying by putting enable = false.
                        textBoxEmployee2PastInputs.Enabled = false;
                        // past inputs for third emplyee box has been set to non displaying by putting enable = false.
                        textBoxEmployee3PastInputs.Enabled = false;

                        // unit input set to non accepting when all employees entry has been done
                        textBoxUnitsInput.Enabled = false;
                        // button to enter will be off
                        buttonToEnter.Enabled = false;
                        // reset button will be focused
                        buttontoReset.Focus();
                        // input box empty
                        textBoxUnitsInput.Text = "";


                    }
                    // this is to display day no in the top -(day 1, day 2 etc...)
                    labelDay.Text = "Day" + (shipedday);
                    

                }
                // if not in the range then this error will be shown
                else
                {
                    // message box to be set and the error msg too.
                    MessageBox.Show("Enter a value between " + MininimunUnits + "and" + MaximumUnits + "." + " Invalid Entry!");
                    // input box is set to selectall
                    textBoxUnitsInput.SelectAll();
                    // input box is set to be focused
                    textBoxUnitsInput.Focus();
                    // input box is set to clear
                    textBoxUnitsInput.Clear();

                }


            }
            // if not numeric or whole number than this 
            else
            {
                // message box has been set along with message error
                MessageBox.Show("Enter a Numeric Number or a Valid Numeric Input", " Invalid Entry");
                // input box is set to selectall
                textBoxUnitsInput.SelectAll();
                // input box is set to be focused
                textBoxUnitsInput.Focus();
                // input box is set to be clear
                textBoxUnitsInput.Clear();


            }
        }
        /// <summary>
        /// tHIS is to reset the form whole form will be clear and will be available to use.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonToResetClick(object sender, EventArgs e)
        {
            // reset form function been called
            ResetForm();

        }
        /// <summary>
        /// This exits the form when user clicks the exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonToExitClick(object sender, EventArgs e)
        {
            // close()
            Close();
        }

        // reset form function
        private void ResetForm()
        {
            // input box been set to be cleat
            textBoxUnitsInput.Clear();
            // all past inputs entered by the user in previous will be set to clear (for 1, 2 , 3)
            textBoxEmployee1PastInputs.Clear();
            textBoxEmployee2PastInputs.Clear();
            textBoxEmployee3PastInputs.Clear();

            // all average output for each will set to empty ( for emplyoee 1,2,3 average output boxes)
            labelEmployee1AverageOutput.Text = String.Empty;
            labelEmployee2AverageOutput.Text = String.Empty;
            labelEmployee3AverageOutput.Text = String.Empty;
            labelOverallAverageOutput.Text = String.Empty;
            // shepped day back to 1
            shipedday = 1;
           


            // unit box which takes input will be back to the state where it will take input.
            textBoxUnitsInput.Enabled = true;
            // button to enter to set to be entered enable.
            buttonToEnter.Enabled = true;
            // input box is set to be focus when reset button is clicked
            textBoxUnitsInput.Focus();
            // this is to set day back to 1.
            labelDay.Text = "Day" + shipedday;
            // bold the label 
            labelEmployee1.Font =new Font(this.Font,FontStyle.Bold);
            labelEmployee2.Font =new Font(this.Font,FontStyle.Regular);
            labelEmployee3.Font =new Font(this.Font,FontStyle.Regular);


        }

    }
}
