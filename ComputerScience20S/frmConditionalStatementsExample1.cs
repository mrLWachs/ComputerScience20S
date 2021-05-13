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
    public partial class frmConditionalStatementsExample1 : Form
    {

        // GLOBAL VARIABLES:
        // =================
        // Which are created under the words 
        // "public partial class..." 
        // AND after the opening curly bracket " { "

        int sum = 0;    // Used for adding up a running total
        int count = 0;  // Used to count how many


        public frmConditionalStatementsExample1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {        
            // The user has clicked this enter button...

            // Read the text out of the textbox, and store (remember it) in a variable
            // (note: we have seen this code before in the last unit - variables)

            string value = txtInput.Text;

            // Now make a "decision" (means we write an "if" statement) which asks 
            // the question: "Did the user leave the textbox empty?" and only 
            // react if they did...

            // NOTE: if statements do NOT use semicolons ";" but they DO use 
            // round brackets "( )" AND curly brackets "{ }" they also INDENT 
            // the code between the two curly brackets

            if (value == "")
            {

                MessageBox.Show("You need to enter something");
                Application.Exit();     // Shuts everything down

                // The code between { } brackets is said to be in a "block"
                // blocks of code are indented

            }
            else
            {
            
                // The "else" statement if written after the "{" bracket of 
                // the "if" and has its own block (and does not need a test)
                
                // Now going to convert into a number (seen before in last unit)

                int number = Convert.ToInt32(value);

                // Add that number to our global runnig sum, using a line of 
                // code that programmers often use to add a variable onto itself

                sum = sum + number;

                // Also increase the global count by one (similar line of code)

                count = count + 1;

                // Now display this to the user (code we have seen before)

                lblOutput.Text = "Sum = " + sum;
                
            }            
        }

        private void chkSeeSum_CheckedChanged(object sender, EventArgs e)
        {
        
            // Make a decision if the checkbox is checked (or not), if 
            // is it then make the label visible, otherwise (else) make
            // the label not visible (invisible)
            
            if (chkSeeSum.Checked == true)
            {
                lblOutput.Visible = true;
            }
            else
            {
                lblOutput.Visible = false;
            } 
            
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
        
            // Simple "if" to check (test) that at least one number
            // has been entered...
            
            if (count >= 1)
            {
                MessageBox.Show("You have entered " + count + " values");
            }
            
        }
    }
}
