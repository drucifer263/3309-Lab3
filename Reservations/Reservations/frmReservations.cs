using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservations
{
    public partial class frmReservations : Form
    {
        public frmReservations()
        {
            InitializeComponent();
        }
        /*
       Drew Watson
       Jupin
       Component based
       Fall 17
       lab3
       9-1
        */
        const decimal averagePricePerNight = 120;
        const decimal weekendPricePerNight = 150;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            DateTime arrival = new DateTime(), departure = new DateTime();
            DateTime now, fiveYears;
            TimeSpan dateDifference;
            String  arrivalString = "", departureString = "";
            int days = 0, extraDays = 0, normalDays =0, count =0;
            decimal totalPrice = 0, averagePrice = 0;
            DayOfWeek dayOfWeek;

            //Gets the input from txtboxes
            arrivalString = txtArrivalDate.Text;
            departureString = txtDepartureDate.Text;
            
            //Gets todays date and the date 5 years from today
            now = DateTime.Today;
            fiveYears = now.AddYears(5);

            //Validation check, gets sent variable from above
            if (IsValidData(now, fiveYears))
            {
            
            //Parses the strings into datetime variables
            arrival = DateTime.Parse(arrivalString);
            departure = DateTime.Parse(departureString);

            //Gets the difference in days for while loop
            dateDifference = departure.Subtract(arrival);
            days = dateDifference.Days;

            //Places the arrival date's day of week into variable
            dayOfWeek = arrival.DayOfWeek;

                //While loop that itierates while count is less than days
                while (count < days)
                {
                    //Test to see what the day of week is
                    if (dayOfWeek == DayOfWeek.Friday | dayOfWeek == DayOfWeek.Saturday)
                    {
                        //Counts the days that are extra priced
                        extraDays++;

                    }

                    else
                    {
                        //Counts all the other days 
                        normalDays++;

                    }

                    //Adds an extra day to the arrival date
                    arrival = arrival.AddDays(1);

                    //Places the day of week of the next day into dayOfWeek
                    dayOfWeek = arrival.DayOfWeek;

                    //Increments to keep track of the number of days
                    count++;
                }

                //Adds the extra day pricing with the normal day pricing
                totalPrice = (extraDays * weekendPricePerNight) + (normalDays * averagePricePerNight);

                //Adds the normal and extra days to get the number of days, a bit unneccessary but it double checks that my calculations were correct above
                days = extraDays + normalDays;

                //Calculates average pricing
                averagePrice = totalPrice / days;

                //Displays and formats the results
                txtNumberNights.Text = Convert.ToString(days);
                txtTotalPrice.Text = totalPrice.ToString("c");
                txtAveragePerNight.Text = averagePrice.ToString("c");
            }
        }

        //Validates data
        public bool IsValidData(DateTime now, DateTime fiveYears)
        {
            return
                IsPresent(txtArrivalDate, txtDepartureDate, "Arrival", "Departure") &&
                IsDateTime(txtArrivalDate, txtDepartureDate, "Arrival", "Departure") &&
                IsWithinRange(txtArrivalDate, txtDepartureDate, "Arrival", "Departure", now, fiveYears)&&
                CheckDates(txtArrivalDate, txtDepartureDate, "Arrival", "Departure");
        }

        //Checks to make sure the text boxes arent blank
        public bool IsPresent(TextBox textBox, TextBox textBox2, string name, string name2)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }

            if (textBox2.Text == "")
            {
                MessageBox.Show(name2 + " is a required field.", "Entry Error");
                textBox2.Focus();
                return false;
            }
            return true;
        }

        //Checks that the dates in the text boxes are valid
        public bool IsDateTime(TextBox textBox, TextBox textBox2, string name, string name2)
        {

            DateTime date,date2;

            if (DateTime.TryParse(textBox.Text, out date) & DateTime.TryParse(textBox2.Text, out date2))
            {
                return true;
            }

            else
            {
                MessageBox.Show(name +" or "+ name2 + " must be a valid date.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        //Checks that the dates entered in the text box are between today and 5 years from now
        public bool IsWithinRange(TextBox textBox, TextBox textBox2, string name, string name2,
            DateTime min, DateTime max)
        {
            DateTime date,date2;
           
            date = DateTime.Parse(textBox.Text);
            date2 = DateTime.Parse(textBox2.Text);

            if (date < min || date > max)
            {
                MessageBox.Show(name + " must be between " + min +
                    " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }

            if (date2 < min || date2 > max)
            {
                MessageBox.Show(name2 + " must be between " + min +
                    " and " + max + ".", "Entry Error");
                textBox2.Focus();
                return false;
            }

            return true; 
        }

        //Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Default values placed into textboxes when reservations form is loaded 
        private void frmReservations_Load(object sender, EventArgs e)
        {
            
            String defaultArrival="", defaultDeparture="";
            DateTime currentDate,threeDayslater;
            
            //Gets current date and 3 days later
            currentDate = DateTime.Today;
            threeDayslater = currentDate.AddDays(3);

            //Converts current date and 3 days later to a string
            defaultArrival = currentDate.ToShortDateString();
            defaultDeparture = threeDayslater.ToShortDateString();

            //Places dates in text boxes
            txtArrivalDate.Text = defaultArrival;
            txtDepartureDate.Text = defaultDeparture;
        }

        //Checks to make sure that the departure is after the arrival
        private bool CheckDates(TextBox textBox, TextBox textBox2, string name, string name2)
        {
            if ( DateTime.Parse(textBox.Text) < DateTime.Parse(textBox2.Text))
            {
                return true;
            }

            else
            {
                MessageBox.Show("The " + name2 + " has to be after the " + name + " date.", "Date Error");
                textBox.Focus();
                return false;
            }
            
        }
    }
}
