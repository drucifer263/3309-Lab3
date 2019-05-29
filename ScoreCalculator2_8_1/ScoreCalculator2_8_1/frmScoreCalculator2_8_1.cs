using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator2_8_1
{
    public partial class frmScoreCalculator2_8_1 : Form
    {
        public frmScoreCalculator2_8_1()
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

        int scoreTotal = 0;
        int scoreCount = 0;
        int[] scores = new int[20];

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int score = 0;
            int average = 0;

            /*
            Got tired of accidentally entering a letter and VS freezing
            decided to put and exception handler in.
            */
            try {

                //Gets the scores from the txtbox and converts them
                score = Convert.ToInt32(txtScore.Text);
                
                //Adds each element from score into the array and then increments
                scores[scoreCount] = score;
                scoreCount++;

                //Adds the scores together
                scoreTotal = scoreTotal + score;

                //Calculates the average score
                average = scoreTotal / scoreCount;

                //Displays the scores, score count and average and shifts the focus
                txtScoreTotal.Text = Convert.ToString(scoreTotal);
                txtScoreCount.Text = Convert.ToString(scoreCount);
                txtAverage.Text = Convert.ToString(average);

                txtScore.Focus();
            }

            //Catches format error if entry is not a valid number
            catch (FormatException)
            {
                MessageBox.Show("Invalid Number Format, Please try again.");
            }
        }

        //Clears the scores in the array
        private void btnClearScore_Click(object sender, EventArgs e)
        {
            int[] cleared = new int[20];

            //Just copy a new blank array into the old one and clear the count and total 
            Array.Copy(cleared,scores,cleared.Length);
            scoreTotal = 0;
            scoreCount = 0;

            //Clear the txt boxes
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";
            txtScore.Text = "";
            
            //Shifts the focus
            txtScore.Focus();
        }

        //Sorts and displays the scores
        private void btnDisplayScores_Click(object sender, EventArgs e)
        {
            /*
            LOL BUBLE SORT FOR NOW; compares one element at a time 
            Time Complexity: O(n^2)
            */

            string numberString = "";
            int j=0, k=0, temp = 0;

            for (k=j+1;k<scores.Length;k++)
            {
                for ( j=0;j < scores.Length-1;j++)
                {
                    if(scores[j]>scores[k])
                    {
                        temp = scores[k];
                        scores[k] = scores[j];
                        scores[j] = temp;
                    }
                }
            }

            /*
            Prints scores; essentially it concats the scores with a string
            and sends them to a message box    
            */
            for (int i = 0; i < scores.Length; i++)
            {
                //Will not print out scores that are null or zero
                if (scores[i] != 0)
                {
                    numberString += scores[i] + "\n";
                }
            }

            MessageBox.Show(numberString, "Scores");
            txtScore.Focus();
        }
       
    }
}
