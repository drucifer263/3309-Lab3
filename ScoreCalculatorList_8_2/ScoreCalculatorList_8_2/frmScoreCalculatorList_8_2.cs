using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculatorList_8_2
{
    public partial class frmScoreCalculatorList_8_2 : Form
    {
        public frmScoreCalculatorList_8_2()
        {
            InitializeComponent();
        }

        /*
       Drew Watson
       Jupin
       Component based
       Fall 17
       lab3
       8-2
        */

        int scoreTotal = 0;
        List<int> scores = new List<int>();

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Calculates scores
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int score = 0;
            int average = 0;
            int count = 0;

            try {
                //Converts scores and adds them to list
                score = Convert.ToInt32(txtScore.Text);
                scores.Add(score);

                //Gets the elements in list and puts them in count
                count = scores.Count;

                //Calculates score total 
                scoreTotal = scoreTotal + score;

                //Calculates average scores, could have just used the count variable here but didnt for some reason 
                average = scoreTotal / scores.Count;

                //Displays the results and changes focus
                txtScoreTotal.Text = Convert.ToString(scoreTotal);
                txtScoreCount.Text = Convert.ToString(count);
                txtAverage.Text = Convert.ToString(average);

                txtScore.Focus();
            }

            //Catches any format errors
            catch (FormatException)
            {
                MessageBox.Show("Invalid Number Format, Please try again.");
            }
        }

        //Clears the scores
        private void btnClearScore_Click(object sender, EventArgs e)
        {
            scoreTotal = 0;
            scores.Clear();

            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";
            txtScore.Text = "";

            txtScore.Focus();
        }

        //Displayes the sorted scores
        private void btnDisplayScores_Click(object sender, EventArgs e)
        {
            string numberString = "";

            //Sorts the list
            scores.Sort();

            for (int i = 0; i < scores.Count; i++)
            {
                //Will not display any null or zero scores
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
