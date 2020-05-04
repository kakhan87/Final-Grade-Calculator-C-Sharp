//  Assignment #2 – A Course Final Grade Calculator Using a GUI
//
//  Author:     Karim Khan
//              03 April 2020
//
//  Purpose:        CPRG200 Assignment 2 Submission
//
//  Description:    Create Course Final Grade Calculator Application.
//
//                  The intent of this application is to provide a tool to instructors that they can use to 
//                  calculate the final mark of a course as both a percentage and letter grade. When run, the 
//                  application will display a window form with data entry fields for quiz marks, a midterm mark, 
//                  and a final examination mark. The final grade is calculated using the weightings of 20% for the 
//                  average of the quizzes, 30% for the midterm mark, and 50% for the final grade. The final grade 
//                  percentage mark is converted to a letter grade using the same table included a later section of 
//                  this document document. The application will allow the entry of an arbitrary number of quiz marks, 
//                  a single midterm mark and the final examination mark.Once these have been entered, a calculate button 
//                  would be pressed produce the final grade, which will be displayed in the window along with the corresponding 
//                  letter grade. Note that there is no maximum or minimum number of quizzes.
//                  A final grade cannot be calculated without either a midterm, a final examination, or at least one quiz mark. 
//                  If any component is missing when the calculation button is pressed, an appropriate error message will be produced.
//                  The application will give the user the option of allowing the lowest and the highest marks in the quiz category 
//                  to be dropped before the quiz average is calculated.This option will be available only if there are 5 (five) 
//                  or more quiz marks entered.
//                  A reset button must also be included to clear all previously entered data so that the grade for the next student 
//                  can be calculated. A quit button must be provided to gracefully terminate the program.
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class mainForm : Form
    {
        int quizCount = 0; // declare variable to count number of quiz entries, accessed in two methods (transferButton and calculateButton)
        int quizTotal = 0; // declare variable to sum up quiz marks, accessed in two methods (transferButton and calculateButton)
        int maximum; // declare variable to track the maximum quiz mark entered, accessed in two methods (transferButton and calculateButton)
        int minimum; // declare variable to track the minimum quiz mark entered, accessed in two methods (transferButton and calculateButton)

        public mainForm()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // gracefully terminates the program
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // once clicked, clears all fields

            multiLineROTextBox.Text = "";
            quizMarkTextBox.Text = "";
            midTermMarkTextBox.Text = "";
            finalExamMarkTextBox.Text = "";
            finalScoreLabel.Text = "";
            letterGradeLabel.Text = "";
            dropCheckBox.Checked = false;
        }

        private void transferTextButton_Click(object sender, EventArgs e)
        {
            int quizMarkEntry; //declare interger variable to ensure quiz marks are entered in whole number format 

            // get quiz marks

            if ( !int.TryParse(quizMarkTextBox.Text, out quizMarkEntry )) // data sanitization step, ensures user enters an integer mark
            {
                MessageBox.Show("Missing or invalid Quiz mark.");
                return; // return will exit the function when calling it - if no valid base length is provided, 
                        // it ends the method "void" and nothing below the return statement will be executed.
            }
            
            if ((quizMarkEntry) < 0 || (quizMarkEntry > 100)) // data sanitization step, ensures user enters a mark between 0 and 100
            {
                MessageBox.Show("Invalid Quiz mark, either non-numeric or out of range [0, 100].");
                return; // return will exit the function when calling it - if no valid base length is provided, 
                        // it ends the method "void" and nothing below the return statement will be executed.
            }
            else
            {
                // once valid data is entered into multiline textbox, dynamically calculate the quiz total and quiz count
                quizTotal += quizMarkEntry;
                quizCount += 1;
                multiLineROTextBox.AppendText(quizMarkTextBox.Text + Environment.NewLine);
                quizMarkTextBox.Text = "";
                quizMarkTextBox.Select();
            }
                                  
            // track the maximum and minimum quiz marks in order to drop them using the Checkbox control in the 
            // case when more than 5 quiz marks are entered

            if (quizCount == 1)
            {
                maximum = quizMarkEntry;
                minimum = quizMarkEntry;
            }
            else
            {
                if (quizMarkEntry > maximum)
                {
                    maximum = quizMarkEntry;
                }
                if (quizMarkEntry < minimum)
                {
                    minimum = quizMarkEntry;
                }
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double quizMarkAverage;// declare float variable to calculate average quiz and boost up student's letter grade if applicable
            int midTermMarkEntry; // declare interger variable to ensure mid-term mark is entered in whole number format 
            int finalMarkEntry; // declare interger variable to ensure quiz mark is entered in whole number format 
            double finalScore; // declare float variable to calculate final score and boost up student's letter grade if applicable
            string letterGrade; // declare string variable to display student's letter grade 

            if (quizCount == 0) // ensures at least one quiz mark is entered
            {
                MessageBox.Show("Missing Quiz mark - Must have at least one entry.");
                return;
            }
            // if more than 5 quizz marks are entered, activate the drop lowest/highest checkbox and calculate new average of quiz marks
            // otherwise, calculate average of quiz marks as normal

            if (quizCount >= 5 && dropCheckBox.Checked)
            {
                quizMarkAverage = (quizTotal - maximum - minimum) / (quizCount - 2);
            }
            else 
            {
                quizMarkAverage = (quizTotal) / (quizCount);
            }

            // get mid-term mark

            if ( !int.TryParse(midTermMarkTextBox.Text, out midTermMarkEntry )) // data sanitization step, ensures user enters an integer mark
            {
                MessageBox.Show("Missing, invalid, or non-integer Mid-Term mark.");
                return;
            }

            if ((midTermMarkEntry < 0) || (midTermMarkEntry > 100)) // data sanitization step, ensures user enters a mark between 0 and 100
            {
                MessageBox.Show("Invalid Mid-Term mark, either non-numeric or out of range [0, 100]."); 
                return;
            }

            // get final mark

            if (!int.TryParse(finalExamMarkTextBox.Text, out finalMarkEntry)) // data sanitization step, ensures user enters an integer mark
            {
                MessageBox.Show("Missing, invalid, or non-integer Final mark.");
                return;
            }

            if ((finalMarkEntry < 0) || (finalMarkEntry > 100)) // data sanitization step, ensures user enters a mark between 0 and 100
            {
                MessageBox.Show("Invalid Final mark, either non-numeric or out of range [0, 100].");
                return;
            }
       
            // do the calculation and update the results label

            if (quizCount >= 1)
            {
                finalScore = (quizMarkAverage / 100.0 * 20) + (midTermMarkEntry / 100.0 * 30) + (finalMarkEntry / 100.0 * 50);
            }
            else
            {
                MessageBox.Show("Missing Quiz mark(s) - Enter value.");
                return;
            }

            // determine letter grade

            if (finalScore >= 95)
            {
                letterGrade = "A+";
            }
            else if ((finalScore >= 90) && (finalScore <= 94))
            {
                letterGrade = "A";
            }
            else if ((finalScore >= 85) && (finalScore <= 89))
            {
                letterGrade = "A-";
            }
            else if ((finalScore >= 80) && (finalScore <= 84))
            {
                letterGrade = "B+";
            }
            else if ((finalScore >= 75) && (finalScore <= 79))
            {
                letterGrade = "B";
            }
            else if ((finalScore >= 70) && (finalScore <= 74))
            {
                letterGrade = "B-";
            }
            else if ((finalScore >= 67) && (finalScore <= 69))
            {
                letterGrade = "C+";
            }
            else if ((finalScore >= 64) && (finalScore <= 66))
            {
                letterGrade = "C";
            }
            else if ((finalScore >= 60) && (finalScore <= 63))
            {
                letterGrade = "C-";
            }
            else if ((finalScore >= 55) && (finalScore <= 59))
            {
                letterGrade = "D+";
            }
            else if ((finalScore >= 50) && (finalScore <= 54))
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }
            
            // display final score and letter grade

            finalScoreLabel.Text = $"{finalScore}";
            finalScoreLabel.Visible = true;
            letterGradeLabel.Text = $"{letterGrade}";
            letterGradeLabel.Visible = true;
        }

        private void checkBoxChanged(object sender, EventArgs e)
        {
            finalScoreLabel.Text = "";
            letterGradeLabel.Text = "";
        }
    }
}
