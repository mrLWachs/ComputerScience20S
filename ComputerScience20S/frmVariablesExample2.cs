// NAME:        John Smith
// DATE:        October 16, 2017 at 9:30am
// TEACHER:     Mr. Wachs
// ASSIGNMENT:  Variables example
// PURPOSE:     more examples of variables

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

        // this area is for global variables

        string value = "";
        int number = 0;

        const int DOUBLE = 2;   // this is a constant
        

        public frmVariablesExample2()
        {
            InitializeComponent();
        }
        
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            value = txtInput.Text;
            number = Convert.ToInt32(value);
            lblOutput.Text = "Number is " + number;
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            number = number + 2;
            lblOutput.Text = "Add 2 = " + number;
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
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
