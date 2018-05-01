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
    public partial class frmProgrammingExtras1Form1 : Form
    {

        private static frmProgrammingExtras1Form1 mainForm;

        public frmProgrammingExtras1Form1()
        {
            InitializeComponent();
        }

        private void tmrColors_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int red   = random.Next(0, 256);
            int green = random.Next(0, 256);
            int blue  = random.Next(0, 256);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void tmrChange_Tick(object sender, EventArgs e)
        {
            tmrChange.Enabled = false;
            frmProgrammingExtras1Form2 form2 = new frmProgrammingExtras1Form2();
            form2.Show();
            this.Hide();
        }

        public static void endExample()
        {
            mainForm.Close();
        }

        private void frmProgrammingExtras1Form1_Load(object sender, EventArgs e)
        {
            mainForm = this;
        }
    }
}
