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
    public partial class frmProgrammingExtras2 : Form
    {

        // Global variables section...

        // constants (so that any "numbers" have a better meaning in code)

        const int STOPPED = 0;

        const int MOVE_UP    = 1;
        const int MOVE_DOWN  = 2;
        const int MOVE_LEFT  = 3;
        const int MOVE_RIGHT = 4;

        // constants for the key pressed on the keyboard
        // they are stored as numbers

        const int KEY_END   = 27;     // Escape key
        const int KEY_UP    = 38;     // Up arrow key    (or "W" would be 87)
        const int KEY_DOWN  = 40;     // Down arrow key  (or "S" would be 83)
        const int KEY_LEFT  = 37;     // Left arrow key  (or "A" would be 65)
        const int KEY_RIGHT = 39;     // Right arrow key (or "D" would be 68)

        // Variables (to track movement and where things are)
        // using geometry and cartesian plane (x,y) coordinates

        // coordinate variables for pacman

        // Variables for each "edge" of the rectangle
        
        int pacmanTop    = 0;
        int pacmanBottom = 0;
        int pacmanLeft   = 0;
        int pacmanRight  = 0;

        // Variables to calculate the far "edges"
        
        int pacmanWidth  = 0;
        int pacmanHeight = 0;

        // Also one more variable for pacman 
        // to track the movement (potentially 
        // could also be made for each ghost)
        
        int pacmanDirection = STOPPED;

        // To complete the variables for the other three
        // game objects (wall, dot, and ghost) it is easier to
        // select the variable code for pacman (using mouse or
        // holding shift and using arrow keys) and copying
        // and pasting the code (CTRL + C for copy then 
        // CTRL + V for paste) and then do a "find and 
        // replace" by pressing CTRL + H and doing the correct
        // settings (match case, not whole word, and in selection)
        // and replacing all the instances in the selection

        // coordinates for dot1
        int dot1Top    = 0;
        int dot1Bottom = 0;
        int dot1Left   = 0;
        int dot1Right  = 0;
        int dot1Width  = 0;
        int dot1Height = 0;

        // coordinates for wall1
        int wall1Top    = 0;
        int wall1Bottom = 0;
        int wall1Left   = 0;
        int wall1Right  = 0;
        int wall1Width  = 0;
        int wall1Height = 0;

        // coordinates for ghost1
        int ghost1Top    = 0;
        int ghost1Bottom = 0;
        int ghost1Left   = 0;
        int ghost1Right  = 0;
        int ghost1Width  = 0;
        int ghost1Height = 0;
        

        public frmProgrammingExtras2()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // By going to the form, then the properties window, then
            // clicking on the "lightning bolt" at the top of the 
            // properties window, scroll down to "KeyDown" and double
            // click to get to this code... this code runs when the user
            // presses a key

            if      (e.KeyValue == KEY_END)   Application.Exit();
            else if (e.KeyValue == KEY_DOWN)  pacmanDirection = MOVE_DOWN;
            else if (e.KeyValue == KEY_UP)    pacmanDirection = MOVE_UP;
            else if (e.KeyValue == KEY_LEFT)  pacmanDirection = MOVE_LEFT;
            else if (e.KeyValue == KEY_RIGHT) pacmanDirection = MOVE_RIGHT;

            // Not using the curly brackets is an option! (no marks given
            // or taken away for not using them)
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // The timer that runs the game, creates a
            // "game loop" that controls the game logic
            // and updates the logic every 100 milliseconds
            // or whichever interval you set...
        
            // The timer that runs the game

            // (1) Get the coordinates of all four things (objects) - which
            //     are: Pacman, Wall 1, Dot 1, and Ghost 1 (where are they 
            //     at this moment in time)

            // Getting pacman's current location (coordinates)
            pacmanTop    = picPacman.Top;
            pacmanLeft   = picPacman.Left;
            pacmanWidth  = picPacman.Width;
            pacmanHeight = picPacman.Height;
            // The other two coordinates, I calculate
            pacmanBottom = pacmanTop  + pacmanHeight;
            pacmanRight  = pacmanLeft + pacmanWidth;

            // Getting ghost's current location (coordinates)
            ghost1Top = picGhost1.Top;
            ghost1Left = picGhost1.Left;
            ghost1Width = picGhost1.Width;
            ghost1Height = picGhost1.Height;
            // The other two coordinates, I calculate
            ghost1Bottom = ghost1Top + ghost1Height;
            ghost1Right = ghost1Left + ghost1Width;

            // Getting dot's current location (coordinates)
            dot1Top = picDot1.Top;
            dot1Left = picDot1.Left;
            dot1Width = picDot1.Width;
            dot1Height = picDot1.Height;
            // The other two coordinates, I calculate
            dot1Bottom = dot1Top + dot1Height;
            dot1Right = dot1Left + dot1Width;

            // Getting wall's current location (coordinates)
            wall1Top = picWall1.Top;
            wall1Left = picWall1.Left;
            wall1Width = picWall1.Width;
            wall1Height = picWall1.Height;
            // The other two coordinates, I calculate
            wall1Bottom = wall1Top + wall1Height;
            wall1Right = wall1Left + wall1Width;        
                
            // (2) Move some of the coordinates (Pacman, potentially the
            //     ghost) - based on the direction the user set when the
            //     user preseed down a key (e.g. we move the pacman 
            //     coordinates up when the user presses the up key)

            if      (pacmanDirection == MOVE_UP)    pacmanTop  = pacmanTop  - MOVE_AMOUNT;
            else if (pacmanDirection == MOVE_DOWN)  pacmanTop  = pacmanTop  + MOVE_AMOUNT;
            else if (pacmanDirection == MOVE_LEFT)  pacmanLeft = pacmanLeft - MOVE_AMOUNT;
            else if (pacmanDirection == MOVE_RIGHT) pacmanLeft = pacmanLeft + MOVE_AMOUNT;

            // The other two coordinates, I recalculate
            pacmanBottom = pacmanTop  + pacmanHeight;
            pacmanRight  = pacmanLeft + pacmanWidth;
            
            // (3) Collision detection - is pacman "touching" with:
            //     dot (collsion reaction - dot disappears), ghost
            //     (game over), wall (stop pacman at wall)

            // check if pacman is touching the dot? (if so, make the dot disappear)            
            if ((( pacmanLeft   >= dot1Left && pacmanLeft   <= dot1Right ) ||
                 ( pacmanRight  >= dot1Left && pacmanRight  <= dot1Right )) &&
                (( pacmanTop    >= dot1Top  && pacmanTop    <= dot1Bottom) ||
                 ( pacmanBottom >= dot1Top  && pacmanBottom <= dot1Bottom)))
            {
                picDot1.Visible = false;
            }
            else if ((( dot1Left   >= pacmanLeft && dot1Left   <= pacmanRight ) ||
                      ( dot1Right  >= pacmanLeft && dot1Right  <= pacmanRight )) &&
                     (( dot1Top    >= pacmanTop  && dot1Top    <= pacmanBottom) ||
                      ( dot1Bottom >= pacmanTop  && dot1Bottom <= pacmanBottom )))
            {
                picDot1.Visible = false;
            }

            // check if pacman is touching the ghost? (if so, end the game)
            if (((pacmanLeft >= ghost1Left && pacmanLeft <= ghost1Right) ||
                 (pacmanRight >= ghost1Left && pacmanRight <= ghost1Right)) &&
                ((pacmanTop >= ghost1Top && pacmanTop <= ghost1Bottom) ||
                 (pacmanBottom >= ghost1Top && pacmanBottom <= ghost1Bottom)))
            {
                Application.Exit();
            }
            else if (((ghost1Left >= pacmanLeft && ghost1Left <= pacmanRight) ||
                      (ghost1Right >= pacmanLeft && ghost1Right <= pacmanRight)) &&
                     ((ghost1Top >= pacmanTop && ghost1Top <= pacmanBottom) ||
                      (ghost1Bottom >= pacmanTop && ghost1Bottom <= pacmanBottom)))
            {
                Application.Exit();
            }

            // check if pacman is touching the wall? (if so...
            // stop pacman: depends on which direction pacman is going)

            // Create a boolean (flag) variable - assume Pacman is not touching
            bool touchingWall = false;

            // check if pacman is touching the wall? (if so, flag it)
            if (((pacmanLeft >= wall1Left && pacmanLeft <= wall1Right) ||
                 (pacmanRight >= wall1Left && pacmanRight <= wall1Right)) &&
                ((pacmanTop >= wall1Top && pacmanTop <= wall1Bottom) ||
                 (pacmanBottom >= wall1Top && pacmanBottom <= wall1Bottom)))
            {
                touchingWall = true;
            }
            else if (((wall1Left >= pacmanLeft && wall1Left <= pacmanRight) ||
                      (wall1Right >= pacmanLeft && wall1Right <= pacmanRight)) &&
                     ((wall1Top >= pacmanTop && wall1Top <= pacmanBottom) ||
                      (wall1Bottom >= pacmanTop && wall1Bottom <= pacmanBottom)))
            {
                touchingWall = true;
            }

            // React to a collion with the wall if Pacman touched
            if (touchingWall == true)
            {
                // Pacman's position will change depending on which direction
                // pacman was moving
                if      (pacmanDirection == MOVE_DOWN)  pacmanTop  = wall1Top    - pacmanHeight - 1;
                else if (pacmanDirection == MOVE_UP)    pacmanTop  = wall1Bottom + 1;
                else if (pacmanDirection == MOVE_LEFT)  pacmanLeft = wall1Right  + 1;
                else if (pacmanDirection == MOVE_RIGHT) pacmanLeft = wall1Left   - pacmanWidth  - 1;
            }

            // (4) Redraw pacman on the form in the new location
            //     from coordinates

            picPacman.Left = pacmanLeft;
            picPacman.Top = pacmanTop;
            
        }
        
    }
}
