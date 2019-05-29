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
    public partial class frmSalesTax : Form
    {
        public frmSalesTax()
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Takes sakes tax and send it to the invoice form
        private void btnOk_Click(object sender, EventArgs e)
        {
            decimal salesTax=0;

            //Validates data
            if (IsValidData())
            {
                //Takes sales tax and places it into a object tag to be retrieved later
                salesTax = Convert.ToDecimal(txtBoxSalesTaxPct.Text);
                this.Tag = salesTax;
                this.DialogResult = DialogResult.OK;
            } 

        }

        //Validates data
        public bool IsValidData()
        {
            return
                IsPresent(txtBoxSalesTaxPct, "Sales tax percent") &&
                IsDecimal(txtBoxSalesTaxPct, "Sales tax percent") &&
                IsWithinRange(txtBoxSalesTaxPct, "Sales tax percent", 0, 10);
        }

        //Makes sure txt box isnt empty
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

        //Makes sure txt box has a decimal
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

        //Makes sure that the numbers in txtbox are in range 0-10  non inclusive
        public bool IsWithinRange(TextBox textBox, string name,
            decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number <= min || number >= max)
            {
                MessageBox.Show(name + " must be between " + min +
                    " and " + max + " (noninclusive).", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
