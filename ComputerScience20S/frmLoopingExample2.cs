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

        // Global variables and constants...

        int width = 0;
        int height = 0;

        // This constant will act as a 'gap' between what we will be 
        // using this program to do: drawing circles on the screen
        // (and anything else drawn/moving on the screen) to fill up   
        // the screen. This is measured in "pixels"

        const int SPACER = 5;
        
        
        public frmLoopingExample2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Another way to code an exit button, like:
            // Application.Exit();

            this.Close();

            // or even just "Close();"
            // But that line will exit ("close") ONE form, and
            // the "Application.Exit();" line closes everything!
        }

        private void frmExample_Load(object sender, EventArgs e)
        {        
            // When the form first loads up.... We can add code
            // here to change the some of the same properties as 
            // we do using the designer
            
            // REMINDER: to bring up autocomplete (any time)
            // press "CTRL + SPACE" if you are having trouble  
            // with some of the specifics of the coding
            
            // Set the form's background color to black
            this.BackColor = Color.Black;

            // Set the form to have no border
            this.FormBorderStyle = FormBorderStyle.None;

            // Set the form to be maximized (full screen)
            this.WindowState = FormWindowState.Maximized;

            // Get ("retrieve") and remember (in our global variables)
            // the width and height of "this" form (as now the form has 
            // changed size to fill the screen). The keyword "this"
            // refers to "this form"
            
            width = this.Width;
            height = this.Height;

            // To move (position) objects (like a button, etc.)
            // you can use the (x, y) coordinate system like in math
            // (geometry) - another way in C# is like this...
            
            // Set the exit button over to the right of the screen
            // (based on the global variable values)

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

            // Set the minimum and maximum of the size of the circles
            // (the radius of the circles) to draw
            
            nudSize.Minimum = SPACER;
            nudSize.Maximum = height - (SPACER * 2);            
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // This button will ask the user what color to draw the circles
            // (the color inside, filling the circle) use a "fancy" dialog
            // box (like the MessageBox) then it will fill up the screen drawing
            // as many circles as it can based on the size the user choose in the
            // numeric up/down
        
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

            // The "for" loop has three parts:
                // what to START at
                // what to STOP at
                // what to CHANGE by
            // Uses round and curley brackets (like the while loop)
            // Uses two ";" semi-colons

            // Visual Studio can help write a for loop by doing this:
                // Type "for"
                // Press the "TAB" key twice

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
