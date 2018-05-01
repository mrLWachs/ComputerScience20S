using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScience20S
{
    public partial class frmLoopingExample1 : Form
    {
        public frmLoopingExample1()
        {
            InitializeComponent();
        }
        
        private void frmLoopingExample1_Load(object sender, EventArgs e)
        {
            // code to add to add some things into the combo box
            cboValues.Items.Add("10");
            cboValues.Items.Add("100");
            cboValues.Items.Add("1000");
            cboValues.Items.Add("10000");
            // also change the display text
            cboValues.Text = "0";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // clear out the list box (works on combo box)
            lstNumbers.Items.Clear();

            // random numbers...
            Random random = new Random();

            // needed variables

            int number = 0, guess = 0;
            // could use comma, don't recommend

            string value = cboValues.Text.Trim();
            // trim removes extras leading, or trailing spaces

            int max = Convert.ToInt32(value);
            // converted the text to a number

            int answer = random.Next(1, max + 1);
            // generate the random number to guess for

            // loop
            while (number != answer)
            {
                // count this as a guess
                guess++;
                // means guess = guess + 1

                number = random.Next(1, max + 1);
                // make a guess at the answer

                // show
                lstNumbers.Items.Add("Guess " + guess + " = " + number);
            }

            lblDisplay.Text = "It took " +
                guess + " guesses to find the number " +
                answer + " between 1 and " + max;

        }

    }
}
