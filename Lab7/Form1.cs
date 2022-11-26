/**
 *  Grading ID:  L8486
 *  Class:       CIS 199-75
 *  Lab:         7
 *  Due date:    11/17/19
 *  Description: Calculates the Net Present Value formula from Finance to calculate how much money you need to invest today to earn a certain amount in the future.
 **/

using System;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Description:     Upon being clicked, input validation is performed, then calls another method to calcluate a value, then finally updates a result label.
        // Pre-Condition:   The range for futureValTextBox.Text, aprTextBox.Text, yearsTextBox.Text is: [0,infinity)
        // Post-Condition:  Updates Present Value Textbox to display expected result.
        private void calcButton_Click(object sender, EventArgs e)
        {
            double futureVal;   // Future value taken from textbox
            double rate;        // APR taken from textbox
            int years;          // Indecated years from textbox
            double presentVal;  // Calculated result returned from GetPresent method

            if (double.TryParse(futureValTextBox.Text, out futureVal) && futureVal >= 0)
            {
                if (double.TryParse(aprTextBox.Text, out rate) && rate >= 0)
                {
                    if (int.TryParse(yearsTextBox.Text, out years) && years >= 0)
                    {
                        // Pre-Condition fulfilled
                        presentVal = GetPresentVal(futureVal, rate, years); // Calls GetPresentVal method
                        presentValResultLabel.Text = $"{presentVal:C}";     // Updates result label
                        futureValTextBox.Select();
                    }
                    else
                        MessageBox.Show("No. of Years is invalid!");
                }
                else
                    MessageBox.Show("Annual Interest Rate is invalid!");
            }
            else
                MessageBox.Show("Future Value is invalid!");

        }

        // Pre-Condition:   f >= 0, r >=0 , n >= 0
        // Post-Condition:  Returns a non-negative double
        private static double GetPresentVal(double f, double r, int n)
        { 
            double p = f / Math.Pow(1 + r, n);
            return p;
        }
    }
}
