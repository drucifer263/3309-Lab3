using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertLength_10_1
{
    public partial class frmConvertLength : Form
    {
        public frmConvertLength()
        {
            InitializeComponent();
        }

        /*
        Drew Watson
        Jupin
        Component based
        Fall 17
        lab3
        10-1
         */
        //Global variable we had to use
        string[,] conversionTable = {
            {"Miles to kilometers", "Miles", "Kilometers", "1.6093"},
            {"Kilometers to miles", "Kilometers", "Miles", "0.6214"},
            {"Feet to meters", "Feet", "Meters", "0.3048"},
            {"Meters to feet", "Meters", "Feet", "3.2808"},
            {"Inches to centimeters", "Inches", "Centimeters", "2.54"},
            {"Centimeters to inches", "Centimeters", "Inches", "0.3937"}
        };

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Calculates the conversions
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool present, valid;
            int selection = 0;
            decimal inputConversion =0,result =0,multiplier=0;
            
            //Puts the combo box index into a variable
            selection = cmbBoxConversion.SelectedIndex;
           
            //Test to see if there is an entry and a decimal in the conversion field
            present = IsPresent(txtBoxInput,lblEntry.Text);
            valid = IsDecimal(txtBoxInput, lblEntry.Text);

            //Will loop as long as there is something in the entry box and it is a decimal
            //Origanlly this was an if statement but I wanted to do something different
             while(present == true & valid == true )
            { 
                
                //Converts the input to a decimal
                inputConversion = Convert.ToDecimal(txtBoxInput.Text);

                //Switch statement selects a multiplier from array depending on combo box choice
                //Made selection the index because it always changes with the selection, I could have put the numbers also
                switch (selection)
                {
                    case 0:
                        multiplier = Convert.ToDecimal(conversionTable[selection, 3]);
                        result = inputConversion * multiplier;
                        txtBoxOutput.Text = result.ToString("n2");
                        present = false;
                        break;


                    case 1:
                        multiplier = Convert.ToDecimal(conversionTable[selection, 3]);
                        result = inputConversion * multiplier;
                        txtBoxOutput.Text = result.ToString("n2");
                        present = false;
                        break;

                    case 2:
                        multiplier = Convert.ToDecimal(conversionTable[selection, 3]);
                        result = inputConversion * multiplier;
                        txtBoxOutput.Text = result.ToString("n2");
                        present = false;
                        break;

                    case 3:
                        multiplier = Convert.ToDecimal(conversionTable[selection, 3]);
                        result = inputConversion * multiplier;
                        txtBoxOutput.Text = result.ToString("n2");
                        present = false;
                        break;

                    case 4:
                        multiplier = Convert.ToDecimal(conversionTable[selection, 3]);
                        result = inputConversion * multiplier;
                        txtBoxOutput.Text = result.ToString("n2");
                        present = false;
                        break;

                    case 5:
                        multiplier = Convert.ToDecimal(conversionTable[selection, 3]);
                        result = inputConversion * multiplier;
                        txtBoxOutput.Text = result.ToString("n2");
                        present = false;
                        break;
                }

            }
          }

        //Checks to see if there is anything in the text box
        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        //Checks to see if the text box is a decimal value
        public bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        //Operations done when main form loads
        private void frmConvertLength_Load(object sender, EventArgs e)
        {


            //Loads the combo box with the first elements in the conversionTable array
            for (int i = 0; i < conversionTable.GetLength(0); i++)
            {
                cmbBoxConversion.Items.Add(conversionTable[i, 0]);

            }

            //Sets default values for combo box and labels
            cmbBoxConversion.SelectedIndex = 0;
            lblEntry.Text = conversionTable[0, 1];
            lblResult.Text = conversionTable[0, 2];

        }

        //Operations done when combo box is changed
        private void cmbBoxConversion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int menu = 0;

            //Gets the index of the currently selected item in combo box
            menu = cmbBoxConversion.SelectedIndex;

            //Switch statement changes labels depending on the combo box item
            switch (menu)
            {
                case 0:
                    lblEntry.Text = conversionTable[0, 1];
                    lblResult.Text = conversionTable[0, 2];
                    txtBoxInput.Focus();
                    txtBoxOutput.Clear();
                    break;


                case 1:
                    lblEntry.Text = conversionTable[1, 1];
                    lblResult.Text = conversionTable[1, 2];
                    txtBoxInput.Focus();
                    txtBoxOutput.Clear();
                    break;

                case 2:
                    lblEntry.Text = conversionTable[2, 1];
                    lblResult.Text = conversionTable[2, 2];
                    txtBoxInput.Focus();
                    txtBoxOutput.Clear();
                    break;

                case 3:
                    lblEntry.Text = conversionTable[3, 1];
                    lblResult.Text = conversionTable[3, 2];
                    txtBoxInput.Focus();
                    txtBoxOutput.Clear();
                    break;

                case 4:
                    lblEntry.Text = conversionTable[4, 1];
                    lblResult.Text = conversionTable[4, 2];
                    txtBoxInput.Focus();
                    txtBoxOutput.Clear();
                    break;

                case 5:
                    lblEntry.Text = conversionTable[5, 1];
                    lblResult.Text = conversionTable[5, 2];
                    txtBoxInput.Focus();
                    txtBoxOutput.Clear();
                    break;
                    
            }
        }

    }
}
