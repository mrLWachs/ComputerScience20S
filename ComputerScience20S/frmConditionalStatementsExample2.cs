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
        // Global Variables:

        int number1 = 0;        // Remembers the first number
        int number2 = 0;        // Remembers the second number
        int guesses = 0;        // Remembers how many guesses the user has made
        
        // Global variables (or "globals") have to start as 0
        // for integers and doubles or "" (nothing) for strings


        public frmConditionalStatementsExample2()
        {
            InitializeComponent();
        }

        private void frmExample2_Load(object sender, EventArgs e)
        {
            // This is the code that runs before the form 
            // appears, you get to it by double clicking the form

            // Welcome the user
            
            MessageBox.Show("Hi, time to guess...");

            // Pick 2 random numbers and store them in our globals
            // by first creating a random number generator
            
            Random random = new Random();

            // Now use it (remember the second number is always one more)

            number1 = random.Next(1, 6);
            number2 = random.Next(1, 4);

            // Set the "focus" (means the program "goes" to that thing)
            
            txtFirst.Focus();          
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            // Retrieve the user guesses from the textboxes...
            // This time we will do two things at once, get the textbox 
            // text and convert the text into a number all in one line
            
            int guess1 = Convert.ToInt32(txtFirst.Text);
            int guess2 = Convert.ToInt32(txtSecond.Text);

            // Create True/False boolean variables to remember if we 
            // guess each (these are also known as "flags")

            bool gotFirst = false;
            bool gotSecond = false;

            // Now we check the first number vs. the first guess...

            if (guess1 == number1)
            {
                // User guessed it, flag it and tell user                
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

            // Check to see if we are done, using combined logic...

            if (gotFirst == true && gotSecond == true)
            {
                // The symbols "&&" means "AND" logically 
                // Meaning both things have to be true for the entire
                // test to be true

                MessageBox.Show("You win!");
            }
            else if (gotFirst == true || gotSecond == true)
            {
                //  The symbols "||" means "OR" logically
                // Meaning either of the two things can be true for the 
                // entire test to be true

                MessageBox.Show("You got one!");

                // Count this as a guess
                guesses = guesses + 1;
            }
            else
            {
                // Count this as a guess
                guesses = guesses + 1;
            }

            // Display the guesses to the user...

            lblNumber.Text = "Number of Guesses = " + guesses;
        }
    }
}
