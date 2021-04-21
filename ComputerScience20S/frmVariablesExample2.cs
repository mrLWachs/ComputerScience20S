// This is the place you put a comment for every assignment 
// (starting with variables problem 3)


// NAME:        John Smith
// DATE:        October 16, 2017 at 9:30am
// TEACHER:     Mr. Wachs
// ASSIGNMENT:  Variables example
// PURPOSE:     More examples of variables code

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
    public partial class frmVariablesExample2 : Form
    {

        // This is the space we create global variables
        // always under the words "public partial class"
        // and the opening "{" curly bracket. Global 
        // variables are "alive" for all code and remember
        // their values for the entire run of the program

        string value = "";
        
        int number = 0;

        const int DOUBLE = 2;   // This is a constant
        

        public frmVariablesExample2()
        {
            InitializeComponent();
        }
        
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            // This code runs every time the textbox changes
            
            value = txtInput.Text;
            
            // The line above reads the text out of the textbox
            // and remembers it in the global variable "value"
            
            number = Convert.ToInt32(value);
            
            // The line above (a hard line to understand) means
            // it converts the text into a number (an integer)
            // from the value variable I used on the other line
            
            lblOutput.Text = "Number is " + number;
            
            // The line above takes the number variable and 
            // attaches it (concatinates) to some words in
            // quotes and puts all those words into the label
            
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            // This is a comment!
            
            number = number + 2;            
            lblOutput.Text = "Add 2 = " + number;
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            // This is the code for the add 4 button
            
            number = number + 4;
            lblOutput.Text = "Add 4 = " + number;
        }

        private void btnDoubleIt_Click(object sender, EventArgs e)
        {
            // This is the code for the double it button, all typing 
            // after the "//" characters is considered a comment
            // Comments can go on their own lines, or they can be
            // put after code at the end of the line
            number = number * DOUBLE;
            lblOutput.Text = "Double it = " + number;
        }
    }
}
