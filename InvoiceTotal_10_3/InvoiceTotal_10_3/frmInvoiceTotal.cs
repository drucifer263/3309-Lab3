using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal_10_3
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        /*
       Drew Watson
       Jupin
       Component based
       Fall 17
       lab3
       10-3
        */

        //Origanally a  constant
        decimal salesTaxPct = 7.75m;

        //Closes form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Calculates Invoice, most code taken from exercise 10-3, the instructions said to modify existing code
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Test to see if data is valid
            if (IsValidData())
            {
                
                //takes the input
                decimal productTotal = Convert.ToDecimal(txtBoxProductTotal.Text);
                decimal discountPercent = .0m;

                //Sets the discount amount
                if (productTotal < 100)
                    discountPercent = .0m;
                else if (productTotal >= 100 && productTotal < 250)
                    discountPercent = .1m;
                else if (productTotal >= 250)
                    discountPercent = .25m;

                //Calculates Totals
                decimal discountAmount = productTotal * discountPercent;
                decimal subtotal = productTotal - discountAmount;
                decimal tax = subtotal * salesTaxPct / 100;
                decimal total = subtotal + tax;

                //Displays results
                txtBoxDiscount.Text = discountAmount.ToString("c");
                txtBoxSubtotal.Text = subtotal.ToString("c");
                txtBoxTax.Text = tax.ToString("c");
                txtBoxTotal.Text = total.ToString("c");

                //Changes foccus back to product total box
                txtBoxProductTotal.Focus();
            }
        }

        //Checks that all validation is true
        public bool IsValidData()
        {
            return
                IsPresent(txtBoxProductTotal, "Subtotal") &&
                IsDecimal(txtBoxProductTotal, "Subtotal") &&
                IsWithinRange(txtBoxProductTotal, "Subtotal", 0, 1000000);
        }

        //Checks that there is a value in the product text box
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

        //Checks that product text box is a decimal value
        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        //Checks that the product total in the text box is between 0 and 1000000
        public bool IsWithinRange(TextBox textBox, string name,
            decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number <= min || number >= max)
            {
                MessageBox.Show(name + " must be between " + min +
                    " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        //If changePercent button is clicked a new form is created
        private void btnChangePercent_Click(object sender, EventArgs e)
        {
            //Sales Tax form created
            Form salesTaxForm = new frmSalesTax();

            //Assigns selected button to the value of the sales form dialog result
            DialogResult selectedButton = salesTaxForm.ShowDialog();

            //Checks that the ok button has been clicked
            try {
                    if (selectedButton == DialogResult.OK)
                    {
                        //Converts tag from sales tax form to a decimal
                        salesTaxPct = Convert.ToDecimal(salesTaxForm.Tag);
                        
                        //Changes label on Invoice total lblTax to tax that is passed as tag from sales tax form and converted to a string
                        lblTax.Text = "Tax(" + salesTaxForm.Tag.ToString() + "%)";
                    }
                }

            //Catches null reference if no sales tax is enter in the sales tax form
            catch (NullReferenceException)
            {
                MessageBox.Show("Re-enter tax percentage", "Tax percentage error");
            }
        }
    }
}
