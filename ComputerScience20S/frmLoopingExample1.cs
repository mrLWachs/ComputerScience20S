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
            
            // Code to add things to the combo box...

            cboValues.Items.Add("10");
            cboValues.Items.Add("100");
            cboValues.Items.Add("1000");
            cboValues.Items.Add("10000");

            // Also change the text inside
            // (like a textbox)

            cboValues.Text = "0";

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            
            // Clear out the list box
            // (same code works on combobox)

            lstNumbers.Items.Clear();

            // Make a random number generator

            Random random = new Random();

            // Make some variables
            // (the comma is not recommended)

            int number = 0, guess = 0;

            // Another variable which reads from the combobox 
            // (like we did with textboxes)

            string value = cboValues.Text.Trim();

            // ".Trim()" removes any extra leading or trailing spaces
            // (at the beginning or the end)

            int max = Convert.ToInt32(value);

            // Converting the text to a number
            // (from the combobox)

            int answer = random.Next(1, max);

            // Generating a random answer 
            // (for the computer to guess)

            // The Loop code...

            while (number != answer)
            {

                // Count a guess 
                // (using the optional shorthand)
                
                guess++;
                
                // This shorthand means guess = guess + 1

                number = random.Next(1, max);

                // Making a guess for the number

                // Display that guess 
                // (in the listbox)

                lstNumbers.Items.Add("Guess " + guess + " = " + number);

            }

            // Show the user the final results...

            lblDisplay.Text = "It took me " + guess +
                " guesses to find the number " + answer +
                " between 1 and " + max;

        }

    }
}
