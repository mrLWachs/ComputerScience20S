using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
// NAME:        Mr. Wachs
// DATE:        October 16, 2017 at 9:30am
// TEACHER:     Mr. Wachs
// PURPOSE:     The main menu for all the Computer Science 20S examples
/// </summary>
namespace ComputerScience20S
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if      (rdbIntroToProgramming.Checked)       new frmIntroductionToProgrammingExample().Show();
            else if (rdbVariables1.Checked)               new frmVariablesExample1().Show();
            else if (rdbVariables2.Checked)               new frmVariablesExample2().Show();
            else if (rdbConditionals1.Checked)            new frmConditionalStatementsExample1().Show();
            else if (rdbConditionals2.Checked)            new frmConditionalStatementsExample2().Show();
            else if (rdbLooping1.Checked)                 new frmLoopingExample1().Show();
            else if (rdbLooping2.Checked)                 new frmLoopingExample2().Show();
            else if (rdbProgrammingExtras1.Checked)       new frmProgrammingExtras1Form1().Show();
            else if (rdbProgrammingExtras2.Checked)       new frmProgrammingExtras2().Show();
            else if (rdbProgrammingExtras3.Checked)       new frmProgrammingExtras3().Show();
            else if (rdbProgrammingExtras4.Checked)       new frmProgrammingExtras4().Show();
            else if (rdbAdvancedProgrammingExtras1.Checked) new frmAdvancedProgrammingExtras1().Show();
            else if (rdbAdvancedProgrammingExtras2.Checked) new frmAdvancedProgrammingExtras2().Show();
            else
            {
                MessageBox.Show( 
                    this, 
                    "Please make a selection!",
                    this.Text, 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

    }
}
