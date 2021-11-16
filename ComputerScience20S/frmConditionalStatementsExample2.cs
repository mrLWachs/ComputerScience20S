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
    public partial class frmConditionalStatementsExample2 : Form
    {
        // Global Variable Area:
        // =====================

        int number1 = 0;        // Remembers the first number
        int number2 = 0;        // Remembers the second number
        int guesses = 0;        // Remembers how many guesses the user has made
        
        // Global variables (or "globals") have to start at 0 (zero)
        // for integer and doubles or "" (nothing) for strings


        public frmConditionalStatementsExample2()
        {
            InitializeComponent();
        }

        private void frmExample2_Load(object sender, EventArgs e)
        {
            // This is the code that runs before the form appears
            // you get to this code by double clicking an empty
            // spot on the form (I recommend the bottom right corner)

            // Welcome the user:
            
            MessageBox.Show("Hi, time to guess...");

            // Pick 2 random numbers and store them (remember them) in
            // out globals but first we need to create a random number
            // generator to do this...

            // The following line creates a random number generator:
            
            Random random = new Random();

            // Now use the generator...
            // (remember the 2nd number is always one more)

            number1 = random.Next(1, 6);
            number2 = random.Next(1, 4);

            // Set the "focus" (means the program "goes" to that thing)
            txtFirst.Focus();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            // Code for the Guess button...

            // Retrieve the user's guess from the two textboxes
            // this means we get the "text" then convert it to
            // a number (we have done this in the last unit) - 
            // this time we will do it all at once in one line

            int guess1 = Convert.ToInt32(txtFirst.Text);
            int guess2 = Convert.ToInt32(txtSecond.Text);

            // TIP: You can bring "autocomplete" (intellisense)
            // back by pressing CTRL + SPACE

            // Create True/False boolean variables to remember
            // if we gussed each (these are known as "flags")

            bool gotFirst = false;
            bool gotSecond = false;

            // Now we check the first number vs. the first guess
            // using a conditional (if) statement

            if (guess1 == number1)
            {
                // User got the first, flag it and tell the user
                gotFirst = true;
                lblFirst.Text = "Correct!";
            }
            else if (guess1 < number1)
            {
                // Give the user a hint
                lblFirst.Text = "Too low";
            }
            else if (guess1 > number1)
            {
                // Give the user another hint
                lblFirst.Text = "Too high";
            }

            // The "else if" makes the code decide multiple "conditions"
            // or multiple "decisions". You can add as many "else if" (each
            // with its own 'test') as you want. You also have the option to
            // add a "else" at the end (but that is not necessary)

            // Now the same logic all over again, but with the second number
            // and the second text box. TIP: use the copy/paste (CTRL + C 
            // and CTRL + V) and find/replace (CTRL + H) to speed up coding

            if (guess2 == number2)
            {
                gotSecond = true;
                lblSecond.Text = "Correct!";
            }
            else if (guess2 < number2)
            {
                lblSecond.Text = "Too low";
            }
            else if (guess2 > number2)
            {
                lblSecond.Text = "Too high";
            }

            // Check to see if we are done (meaning we got both)
            // using some combined logic

            if (gotFirst == true && gotSecond == true)
            {
                // The symbol "&&" means "AND" logically
                // Meaning BOTH things have to be true for the 
                // entire test to be true

                MessageBox.Show("You win!");
                Application.Exit();
            }
            else if (gotFirst == true || gotSecond == true)
            {
                // The symbols "||" means "OR" logically
                // Meaning EITHER of the two things can be true for the 
                // entire test to be true

                MessageBox.Show("You got one!");

                // count this as a guess
                guesses = guesses + 1;
            }
            else
            {
                guesses = guesses + 1;
            }

            // Display the guesses to the user...
            lblNumber.Text = "Number of guesses = " + guesses;
        }
    }
}
