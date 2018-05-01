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
    public partial class frmIntroductionToProgrammingExample : Form
    {
        public frmIntroductionToProgrammingExample()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            lblHello.Text = "I've changed the world";
            picSweaterVest.Visible = true;
            btnChange.Enabled = false;
            frmIntroductionToProgrammingExample.ActiveForm.WindowState = FormWindowState.Maximized;
            lblHello.Font = new Font("Algerian", 30);
            lblHello.Font = new Font(lblHello.Font, FontStyle.Underline);
        }
    }
}

