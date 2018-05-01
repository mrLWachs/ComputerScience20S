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

        // Global Variables/Constants:

        const int SPACER = 2;

        int width = 0;
        int height = 0;


        public frmLoopingExample2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExample_Load(object sender, EventArgs e)
        {
            // set the form's background color to black
            this.BackColor = Color.Black;

            // set the form to have no border and maximized (full screen)
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            // get and remember the height and width of the form (screen)
            width = frmLoopingExample2.ActiveForm.Width;
            height = frmLoopingExample2.ActiveForm.Height;

            // position the exit button based on this new size
            btnExit.Top = SPACER;
            btnExit.Left = width - btnExit.Width - SPACER;

            // position the run button based on the exit button
            btnRun.Top = btnExit.Top + btnExit.Height + SPACER;
            btnRun.Left = width - btnRun.Width - SPACER;

            // position the up/down number based on the run button
            nudSize.Top = btnRun.Top + btnRun.Height + SPACER;
            nudSize.Left = width - nudSize.Width - SPACER;

            // set the min and max of the circles to draw based on size
            nudSize.Maximum = height - SPACER * 2;
            nudSize.Minimum = SPACER;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // show the color chooser dialog box
            cdbColor.ShowDialog();

            // create a color from the chooser
            Color color = cdbColor.Color;

            // create a surface to draw on
            Graphics surface = this.CreateGraphics();

            // clear that surface for a new drawing
            surface.Clear(Color.Black);

            // create a "pen" to draw the outside of a circle
            Pen pen = new Pen(Color.White, 1);

            // create a "brush" to fill in the circle with color
            Brush brush = new SolidBrush(color);
            
            // make variable for size of the circles
            int size = (int)nudSize.Value;

            // make variable for how far apart the circles are
            int move = size + SPACER;

            // make variable for the max number of circles we can make going down
            int maxY = height - size - SPACER;

            // make variable for the max number of circles we can make going across
            int maxX = width - size - SPACER;

            // use for loops (nested) to keep drawing circles
            for (int y = SPACER; y <= maxY; y = y + move)
            {
                for (int x = SPACER; x <= maxX; x = x + move)
                {
                    // now draw the outside line of the circle
                    surface.FillEllipse(brush, x, y, size, size);

                    // draw the inside color for the circle
                    surface.DrawEllipse(pen, x, y, size, size);
                }
            }
        }
    }
}
