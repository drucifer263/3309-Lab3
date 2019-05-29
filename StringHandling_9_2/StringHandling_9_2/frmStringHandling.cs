using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling_9_2
{
    public partial class frmStringHandling : Form
    {
        public frmStringHandling()
        {
            InitializeComponent();
        }

        /*
       Drew Watson
       Jupin
       Component based
       Fall 17
       lab3
       9-2
        */

        //Parses the email address
        private void btnParse_Click(object sender, EventArgs e)
        {
            String email = "", username="", domain="";
            int indexOfC =0, indexOfValid = 0;
            
            //Gets string from textbox 
            email = txtBoxEmail.Text;

            //Removes spaces
            email = email.Trim();
            
            //Returns true if @ symbol is in string
            indexOfValid = email.IndexOf("@");
            
            //Validates to see if @ is in address
            if(indexOfValid == -1)
            {
                MessageBox.Show("This is not a valid email address","Error");
            }

            else
            {
                //Gets the index of the @
                indexOfC = email.IndexOf("@");

                //Breaks the address into a substring before @
                username = email.Substring(0,indexOfC);

                //Breaks the address into a substring after @
                domain = email.Substring(indexOfC+1);

                //Dispalys the result
                MessageBox.Show("Username: " + username+"\n\n"+"Domain name: "+ domain,"Parsed String");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Formats the address
        private void btnFormat_Click(object sender, EventArgs e)
        {
            String address = "", city = "", state = "", zip = "";
            int lengthOfCity = 0, indexOfState = 0;

            //Gets the city string 
            city = txtBoxCity.Text;

            //Finds the length of the city string
            lengthOfCity = city.Length;

            //Gets the state string
            state = txtBoxState.Text;

            //Converts the state string to Uppercase
            state = state.ToUpper();
            
            //Gets the  zip code string
            zip  = txtBoxZip.Text;

            //Concates all the strings into a single string address
            address = city + state + zip;

            //Inserts a comma and space at the end of the city string within address
            address = address.Insert(lengthOfCity,", ");

            //Finds the index of the state string
            indexOfState = address.IndexOf(state);
            

            //Inserts a space after the state
            address = address.Insert(indexOfState + 2," ");
            
            //Displays address
            MessageBox.Show("City, State, Zip: "+address,"Formatted String");
        }
    }
}
