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
        
        int sum = 0;
        int count = 0;


        public frmConditionalStatementsExample1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // remember what's in the textbox
            string value = txtInput.Text;
            
            // make a decision
            if (value == "")
            {
                // code between { } brackets is said to be in a "block"
                MessageBox.Show("You need to enter something");
                Application.Exit();
            }
            else
            {
                int number = Convert.ToInt32(value);
                sum = sum + number;
                count = count + 1;
                lblOutput.Text = "sum = " + sum;
            }            
        }

        private void chkSeeSum_CheckedChanged(object sender, EventArgs e)
        {
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
