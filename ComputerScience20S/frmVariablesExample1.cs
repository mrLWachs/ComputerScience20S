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
    public partial class frmVariablesExample1 : Form
    {
        public frmVariablesExample1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            string value1 = txtInput1.Text;
            int number1 = Convert.ToInt32(value1);
            int number2 = number1 * 2;
            string answer1 = "Double the number is " + number2;
            lblOutput1.Text = answer1;

            string value2 = txtInput2.Text;
            double number3 = Convert.ToDouble(value2);
            double number4 = number3 * 0.5;
            string answer2 = "Half the number is " + number4;            
            lblOutput2.Text = answer2;

            int number5 = (int)number4;
            double number6 = (double)number5;
            
        }
    }
}
