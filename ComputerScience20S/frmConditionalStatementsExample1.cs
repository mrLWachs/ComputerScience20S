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

        // Declare some global variables...
        
        int sum = 0;        // adding a running total
        int count = 0;      // counts how many


        public frmConditionalStatementsExample1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
        
            // First, read the text from the textbox and "remember" that text in a variable 
            
            string value = txtInput.Text;
            
            // Now, make a "decision" using a "if" statement ....

            // if statements use round brackets ( ) they also use curley brackets { } and
            // they do NOT use a semicolon ";"
            
            if (value == "")
            {
            
                MessageBox.Show("You need to enter something");
                Application.Exit();
                
                // The code between { } brackets is said to be in a "block"
                // blocks of code are indented
                
            }
            else
            {
            
                // The "else" statement if written after the "{" bracket of 
                // the "if" and has its own block (and does not need a test)
                
                // Now convert the text into a number   
                
                int number = Convert.ToInt32(value);
                
                // Add that number to our global running sum using a line of code
                // we often use to add onto itself  
                
                sum = sum + number;
                
                // Also increase the global count by one (similar line of code)     
                
                count = count + 1;
                
                // Now display to the user
                
                lblOutput.Text = "sum = " + sum;
                
            }            
        }

        private void chkSeeSum_CheckedChanged(object sender, EventArgs e)
        {
        
            // Make a decision if the checkbox is checked, make the label visible, 
            // otherwise (else) make the label not visible (invisible)
            
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
            MessageBox.Show("You have entered " + count + " values");
        }
    }
}
