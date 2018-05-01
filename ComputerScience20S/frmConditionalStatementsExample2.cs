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
        // global variables:

        int guesses = 0;
        int number1 = 0;
        int number2 = 0;

        // globals have to start as 0 or "" nothing


        public frmConditionalStatementsExample2()
        {
            InitializeComponent();
        }

        private void frmExample2_Load(object sender, EventArgs e)
        {
            // the "focus" means it "goes" to that thing
            txtFirst.Focus();
            
            // pick 2 random #s

            // creates a random number generator
            Random random = new Random();           

            //now use it
            number1 = random.Next(1, 6);
            number2 = random.Next(1, 4);
            // remember the second number is always one more            
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {

            // get the user guesses from the textboxes

            // do two things at once, get the textbox text and convert at once
            int guess1 = Convert.ToInt32(txtFirst.Text);
            int guess2 = Convert.ToInt32(txtSecond.Text);

            // variables to remember if we guesses each:
            bool gotFirst = false;
            bool gotSecond = false;

            // now check the number vs. the guess
            if (guess1 == number1)
            {
                gotFirst = true;
                lblFirst.Text = "Correct!";
            }
            else if (guess1 < number1)
            {
                lblFirst.Text = "Too low";
            }
            else if (guess1 > number1)
            {
                lblFirst.Text = "Too high";
            }

            // now second number (use copy/paste and find/replace) speeds up coding
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

            // check to see if we are done
            if (gotFirst == true && gotSecond == true)
            {
                // && means "and"
                MessageBox.Show("You win!");
            }
            else if (gotFirst == true || gotSecond == true)
            {
                // || means "or"
                MessageBox.Show("You got one!");
                guesses = guesses + 1;
            }
            else
            {
                guesses = guesses + 1;
            }

            lblNumber.Text = "Number of Guesses = " + guesses;
        }
    }
}
