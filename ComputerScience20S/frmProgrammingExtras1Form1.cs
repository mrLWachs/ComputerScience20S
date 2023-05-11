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
            
            // The timer runs like a loop, running this code
            // over and over again - while the Enabled property
            // is set to true. It runs based on time in milliseconds
                // 1 second of real time = 1000 milliseconds
                // 2 seconds of real time = 2000 milliseconds
                // 10 seconds of real time = 10,000 milliseconds
                // 1/2 second of real time = 500 milliseconds

            // Create a random number generator
            // and create random colors

            Random random = new Random();

            // create three variables for the 3 colors
            int red   = random.Next(0, 256);
            int green = random.Next(0, 256);
            int blue  = random.Next(0, 256);

            // Assign these random values to the background
            // color of our current form
            this.BackColor = Color.FromArgb(red, green, blue);
            
        }

        private void tmrChange_Tick(object sender, EventArgs e)
        {
            // This timer waits for it's interval and then
            // runs this code...

            
            // To add another form to a project, go to the menu:
                // Project -> Add Form
            
            // Now to write the code to shift over to
            // that new form, we first...

            // Write code to "create" the second form
            frmProgrammingExtras1Form2 form2 = new frmProgrammingExtras1Form2();

            // We "show" the other form (that we just created)
            form2.Show();
            
            // Then, we "hide" our current form (make it dissappear)
            this.Hide();
        
            // And we also need to shut off the timer
            // (so more forms are not created and shown)
            tmrAnimate.Enabled = false;
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
