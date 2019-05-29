using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder_10_2
{
    public partial class frmLunchOrder : Form
    {
        public frmLunchOrder()
        {
            InitializeComponent();
        }

        /*
       Drew Watson
       Jupin
       Component based
       Fall 17
       lab3
       10-2
        */

        //All the labels
        private String burgerT1 = "Lettuce, tomato, and onions", burgerT2 = "Ketchup, mustard, mayo", burgerT3 = "French fries";
        private String pizzaT1 = "Pepperoni", pizzaT2 = "Sausage", pizzaT3 = "Olives";
        private String saladT1 = "Crutons", saladT2 = "Bacon bits", saladT3 = "Bread sticks";
        private String addOn1 = "Add on items($.75/each)", addOn2 = "Add on items($.50/each)", addOn3 = "Add on items($.25/each)";

        //All the prices, main course then addons
        private double[] burgerP = {  6.95 ,  0.75  };
        private double[] pizzaP = { 5.95 ,  0.50  };
        private double[] saladP = { 4.95 ,  0.25  };

        //Tax constant
        private const double tax = 0.0775;

   
        
        //Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Places order
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            double mainCourse = 0, addOn = 0,orderTotal=0,subTotal=0,addOnTotal=0, taxTotal=0;

            //Checks the radio button
            if (rdoButtonHamburger.Checked == true)
            {
                //Sets the maincourse and addon prices
                mainCourse = burgerP[0];
                addOn = burgerP[1];

                //If-else statements check to see which addons to add
                if(chkBoxOne.Checked == true)
                {
                    addOnTotal += addOn;
                }

                if (chkBoxTwo.Checked == true)
                {
                    addOnTotal += addOn;
                }

                if (chkBoxThree.Checked == true)
                {
                    addOnTotal += addOn;
                }

                //Calculations
                subTotal = addOnTotal + mainCourse;
                taxTotal = tax * subTotal;
                orderTotal = taxTotal +subTotal;

                //Display
                txtBoxOrderTotal.Text = orderTotal.ToString("c");
                txtBoxSubtotal.Text = subTotal.ToString("c");
                txtBoxTax.Text = taxTotal.ToString("c");
               
            }

            //Checks the second radio button
            else if (rdoButtonPizza.Checked == true)
            {
                //Sets the maincourse and addon prices
                mainCourse = pizzaP[0];
                addOn = pizzaP[1];

                //If-else statements check to see which addons to add
                if (chkBoxOne.Checked == true)
                {
                    addOnTotal += addOn;
                }

                if (chkBoxTwo.Checked == true)
                {
                    addOnTotal += addOn;
                }

                if (chkBoxThree.Checked == true)
                {
                    addOnTotal += addOn;
                }

                //Calculations
                subTotal = addOnTotal + mainCourse;
                taxTotal = tax * subTotal;
                orderTotal = taxTotal + subTotal;

                //Display
                txtBoxOrderTotal.Text = orderTotal.ToString("c");
                txtBoxSubtotal.Text = subTotal.ToString("c");
                txtBoxTax.Text = taxTotal.ToString("c");
            }

            //Checks the last radio button
            else if (rdoButtonSalad.Checked == true)
            {
                //Sets the maincourse and addon prices
                mainCourse = pizzaP[0];
                addOn = pizzaP[1];

                //If-else statements check to see which addons to add
                if (chkBoxOne.Checked == true)
                {
                    addOnTotal += addOn;
                }

                if (chkBoxTwo.Checked == true)
                {
                    addOnTotal += addOn;
                }

                if (chkBoxThree.Checked == true)
                {
                    addOnTotal += addOn;
                }

                //Calculations
                subTotal = addOnTotal + mainCourse;
                taxTotal = tax * subTotal;
                orderTotal = taxTotal + subTotal;

                //Display
                txtBoxOrderTotal.Text = orderTotal.ToString("c");
                txtBoxSubtotal.Text = subTotal.ToString("c");
                txtBoxTax.Text = taxTotal.ToString("c");
            }
        }

        //When form loads sets the main course radio button to be checked by default
        private void frmLunchOrder_Load(object sender, EventArgs e)
        {
            rdoButtonHamburger.Checked = true;
        }

        //Clears total text boxes
        private void clearTotals()
        {
            txtBoxOrderTotal.Clear();
            txtBoxTax.Clear();
            txtBoxSubtotal.Clear();
        }

        //Clears addon check boxes
        private void clearAddOns()
        {
            chkBoxOne.Checked = false;
            chkBoxTwo.Checked = false;
            chkBoxThree.Checked = false;

        }

        //Clears totals when addons are checked or unchecked
        private void addOnItem_CheckChanged(object sender, EventArgs e)
        {
            clearTotals();

        }

        //Sets the addons when the main course is selected
        private void mainCourse_CheckedChanged(object sender, EventArgs e)
        {
            
            //Checks the first radio button
            if (rdoButtonHamburger.Checked == true)
            {
                //Sets the addon labels text, check box texts and clears the addons and totals when a main course is selected
                grpBoxAddOnItems.Text = addOn1;
                chkBoxOne.Text = burgerT1;
                chkBoxTwo.Text = burgerT2;
                chkBoxThree.Text = burgerT3;
                clearTotals();
                clearAddOns();
            }

            //Sets the addon labels text, check box texts and clears the addons and totals when a main course is selected
            else if (rdoButtonPizza.Checked == true)
            {
                grpBoxAddOnItems.Text = addOn2;
                chkBoxOne.Text = pizzaT1;
                chkBoxTwo.Text = pizzaT2;
                chkBoxThree.Text = pizzaT3;
                clearTotals();
                clearAddOns();
            }

            //Sets the addon labels text, check box texts and clears the addons and totals when a main course is selected
            else if (rdoButtonSalad.Checked == true)
            {
                grpBoxAddOnItems.Text = addOn3;
                chkBoxOne.Text = saladT1;
                chkBoxTwo.Text = saladT2;
                chkBoxThree.Text = saladT3;
                clearTotals();
                clearAddOns();
            }
        }
    }
}
