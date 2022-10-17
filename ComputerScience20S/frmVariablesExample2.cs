
// This is a comment - you make comments by typing "//" and then
// typing and everything after the two "//" is considered a
// comment. Comments are NOT code, they appear in green, they
// are used to leave notes to yourself or other programmers
// (or teachers), and you can write what you want because the
// computer ignores comments

// I encourage you to add as many comments to your code as you
// like (it will help you learn) you will never lose marks for
// OVER commenting code

// What is REQUIRED (for marks) in comments is the following
// comment at the top of all programming solutions
// (assignments) starting with variables assignment 3 and
// ongoing...


// NAME:            Your name
// DATE:            October 2022
// TEACHER:         Mr. Wachs
// ASSIGNMENT:      Variables Example 2
// PURPOSE:         Here you can type what the assignment was
//                  (be brief) and/or tell me how the assignment
//                  went for you (like a journal) ~ 1 sentence

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
        
        // Global variables can NOT be assigned complicated
        // values (like reading from a textbox) when created
        // they can only be assigned simple values
        
        int number = 0;

        const int DOUBLE = 2;   // This is a constant
        
        // Constants are 'variables' that do NOT change (in
        // other words, the value stays 'constant'). They are
        // created (declared) the same way as other variables,
        // but use the word "const" at the front of the line to
        // 'lock' the variable value. They also use a different
        // style and write in ALL_CAPS (with a underscore if 
        // you need to separate words)
        

        public frmVariablesExample2()
        {
            InitializeComponent();
        }
        
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            // This is how you make a comment, by typing "//" and
            // then typing whatever you want. Comments are NOT
            // code, so you don't have to worry about what you type.
            // They are used to leave notes to yourself or other
            // programmers (or teachers)
            
            // The code for the textbox, and it runs every time the
            // textbox changes in some way by the user typing in
            // the textbox

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
            // This is the code for the adding 2 button, all typing
            // after the "//" characters is considered a comment
            // commments can go on their own lines, or they can
            // be put after code at the end of the line

            number = number + 2;

            lblOutput.Text = "Add 2 = " + number;

            // You often see code where a variable "changes" itself
            // like the line "number = number + 2;" where the variable
            // adds on to itself
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            // This is the code for the add 4 button
            number = number + 4;
            lblOutput.Text = "Add 4 = " + number;
        }

        private void btnDoubleIt_Click(object sender, EventArgs e)
        {
            number = number * DOUBLE;
            lblOutput.Text = "Double it = " + number;
        }
        
    }
}
