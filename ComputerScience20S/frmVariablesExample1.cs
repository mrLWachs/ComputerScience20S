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
            string value = txtInput.Text;
            int number1 = Convert.ToInt32(value);
            int number2 = number1 + 10;
            double number3 = Convert.ToDouble(value);
            double number4 = number3 * 0.5;
            int number5 = (int)number4;
            double number6 = (double)number5;
            string answer = "Answer is " + number6;
            lblOutput.Text = answer;
        }
    }
}
