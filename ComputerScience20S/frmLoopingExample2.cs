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
    public partial class frmLoopingExample2 : Form
    {

        // Global variables/constants:
        int width = 0;
        int height = 0;

        // This acts as a 'gap' between the circles we will draw
        // and any other things we are moving around
        const int SPACER = 5;


        public frmLoopingExample2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Another way to close (exit) one form
            this.Close();
        }

        private void frmExample_Load(object sender, EventArgs e)
        {        
            // Set the form's background color
            this.BackColor = Color.Black;

            // Set the form to have no border
            this.FormBorderStyle = FormBorderStyle.None;

            // Set the form to be maximized (full screen)
            this.WindowState = FormWindowState.Maximized;

            // Get (and remember in our global variables) the width and 
            // height of the screen (the form now fills the screen) - the
            // keyword "this" refers to "this form"
            width = this.Width;
            height = this.Height;

            // Set the button over to the right of the screen width
            // based on the values we just got in our global variables
            btnExit.Left = width - btnExit.Width - SPACER;
            btnExit.Top = 0 + SPACER;

            // "Left" is the same as "X" coordinate
            // "Top" is the same as "Y" coordinate

            // Move the run button to match up with the exit button
            btnRun.Left = width - btnRun.Width - SPACER;
            btnRun.Top = btnExit.Top + btnExit.Height + SPACER;

            // Move the up down size selector to match up with the run button
            nudSize.Left = width - nudSize.Width - SPACER;
            nudSize.Top = btnRun.Top + btnRun.Height + SPACER;

            // Set the minimum and maximum of the circles radius we can draw
            nudSize.Minimum = SPACER;
            nudSize.Maximum = height - (SPACER * 2);            
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // Show the user a color choosing dialog box
            cdbColor.ShowDialog();

            // Create a "color variable" (remembers a color) for the chooser
            Color color = cdbColor.Color;

            // Create a surface to draw on (we are working with other 
            // people's code to do a lot of the graphics drawing)
            Graphics surface = this.CreateGraphics();

            // "this" again means "this form"

            // Clear (wipe) the surface to a color to draw on
            surface.Clear(Color.Black);

            // Create a "pen" to draw the outside (line) of a circle
            Pen pen = new Pen(Color.White, 1);

            // Create a "brush" to fill in the circle with color
            Brush brush = new SolidBrush(color);

            // Make a variable for the size of the circles
            int size = (int)nudSize.Value;

            // Make a variable for how far apart the circles are
            int move = size + SPACER;

            // Make a variable for the max number of circles we can 
            // draw going down ("Y" axis)
            int maxY = height - size - SPACER;

            // Make a variable for the max number of circles we can 
            // draw going across ("X" axis)
            int maxX = width - size - SPACER;

            // Use the "for" loop to repeatitively draw circles
            for (int y = SPACER; y <= maxY; y = y + move)
            {
                // "Nest" a loop inside our loop
                for (int x = SPACER; x <= maxX; x = x + move)
                {
                    // Now draw the inside of the circle (fill)
                    surface.FillEllipse(brush, x, y, size, size);

                    // Now draw the outside (line) of the circle
                    surface.DrawEllipse(pen, x, y, size, size);

                }
            }
        }
    }
}
