﻿using System;
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
        // Global variables area..............................................................

        // First some constants (so that any "numbers" have a better meaning in code).........

        // Constants to "represent" the four movements of the game............................
        const int STOPPED    = 0;                   // For when the game first starts
        const int MOVE_UP    = 1;
        const int MOVE_DOWN  = 2;
        const int MOVE_LEFT  = 3;
        const int MOVE_RIGHT = 4;

        const int MOVE_AMOUNT = 5;                  // How much a character moves in pixels

        // Constants for the key pressed on the keyboard they are stored as numbers...........
        const int KEY_END   = 27;                   // Escape key
        const int KEY_UP    = 38;                   // Up arrow key    (or "W" would be 87)
        const int KEY_DOWN  = 40;                   // Down arrow key  (or "S" would be 83)
        const int KEY_LEFT  = 37;                   // Left arrow key  (or "A" would be 65)
        const int KEY_RIGHT = 39;                   // Right arrow key (or "D" would be 68)

        // Variables remembers 4 "edges" of the rectangle (or "hitbox" or "bounding" box).....
        int pacmanTop    = 0;
        int pacmanBottom = 0;
        int pacmanLeft   = 0;
        int pacmanRight  = 0;

        // Variables to calculate the far "edges".............................................
        int pacmanWidth  = 0;
        int pacmanHeight = 0;

        // Also one more variable for pacman to track the movement
        // (potentially could also be made for each ghost)....................................

        int pacmanDirection = STOPPED;

        // To complete the variables for the other three game objects (wall, dot, and ghost)
        // it is easier to select the variable code for pacman (using mouse or holding shift
        // and using arrow keys) and copying and pasting the code (CTRL + C for copy then
        // CTRL + V for paste) and then do a "find and replace" by pressing CTRL + H and
        // doing the correct settings (match case, not whole word, and in selection) and
        // replacing all the instances in the selection.......................................

        // Coordinates for wall 1.............................................................
        int wall1Top    = 0;
        int wall1Bottom = 0;
        int wall1Left   = 0;
        int wall1Right  = 0;
        int wall1Width  = 0;
        int wall1Height = 0;

        // Coordinates for ghost 1............................................................
        int ghost1Top    = 0;
        int ghost1Bottom = 0;
        int ghost1Left   = 0;
        int ghost1Right  = 0;
        int ghost1Width  = 0;
        int ghost1Height = 0;

        // Coordinates for dot 1..............................................................
        int dot1Top    = 0;
        int dot1Bottom = 0;
        int dot1Left   = 0;
        int dot1Right  = 0;
        int dot1Width  = 0;
        int dot1Height = 0;
        
        
        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_KeyDown(object sender, KeyEventArgs e)
        {
            // By going to the form, then the properties window, then clicking on the
            // "lightning bolt" at the top of the properties window, scroll down to "KeyDown"
            // and double click to get to this code... this code runs when the user presses
            // a key..........................................................................

            // Get a key value (an integer) and store in a variable...........................
            int key = e.KeyValue;

            // Check what to do with that key code value......................................
            if      (key == KEY_END)   Application.Exit();
            else if (key == KEY_UP)    pacmanDirection = MOVE_UP;
            else if (key == KEY_DOWN)  pacmanDirection = MOVE_DOWN;
            else if (key == KEY_LEFT)  pacmanDirection = MOVE_LEFT;
            else if (key == KEY_RIGHT) pacmanDirection = MOVE_RIGHT;

            // Not using the curly brackets is an option! (no marks given or taken away for
            // not using them)................................................................
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            // The timer that runs the game...................................................
            // (All the actions will be explained in stages using comments)

            // (1) Get all the Coordinates:
            //     ===========================================================================
            //     We need to fill up all the global variables with the proper values from 
            //     where the objects currently are on the screen

            // The top, left, width, and height come from the picturebox......................
            pacmanTop    = picPacman.Top;
            pacmanLeft   = picPacman.Left;
            pacmanWidth  = picPacman.Width;
            pacmanHeight = picPacman.Height;

            // The bottom and the right are calculated........................................
            pacmanRight  = pacmanLeft + pacmanWidth;
            pacmanBottom = pacmanTop  + pacmanHeight;

            // The dot........................................................................
            dot1Top    = picDot1.Top;
            dot1Left   = picDot1.Left;
            dot1Width  = picDot1.Width;
            dot1Height = picDot1.Height;
            dot1Right  = dot1Left + dot1Width;
            dot1Bottom = dot1Top  + dot1Height;

            // The wall.......................................................................
            wall1Top    = picWall1.Top;
            wall1Left   = picWall1.Left;
            wall1Width  = picWall1.Width;
            wall1Height = picWall1.Height;
            wall1Right  = wall1Left + wall1Width;
            wall1Bottom = wall1Top  + wall1Height;

            // The ghost......................................................................
            ghost1Top    = picGhost1.Top;
            ghost1Left   = picGhost1.Left;
            ghost1Width  = picGhost1.Width;
            ghost1Height = picGhost1.Height;
            ghost1Right  = ghost1Left + ghost1Width;
            ghost1Bottom = ghost1Top  + ghost1Height;

            // (2) Move the Pacman coordinates:
            //     ===========================================================================
            //     We move some of the coordinates (Pacman, and potentially the ghost) - based 
            //     on the direction the user set when the user preseed down a key (e.g. we
            //     move the pacman coordinates up when the user presses the up key)

            if      (pacmanDirection == MOVE_UP)    pacmanTop  = pacmanTop  - MOVE_AMOUNT;
            else if (pacmanDirection == MOVE_DOWN)  pacmanTop  = pacmanTop  + MOVE_AMOUNT;
            else if (pacmanDirection == MOVE_LEFT)  pacmanLeft = pacmanLeft - MOVE_AMOUNT;
            else if (pacmanDirection == MOVE_RIGHT) pacmanLeft = pacmanLeft + MOVE_AMOUNT;

            // Recalculate the other coordinates..............................................
            pacmanRight  = pacmanLeft + pacmanWidth;
            pacmanBottom = pacmanTop  + pacmanHeight;

            // (3) Collision Detection and Collision Reaction:
            //     ===========================================================================
            //     We will be checking a few different collision detections meaning are
            //     "touching" the hitbox, bounding rectangles overlapping with each other.
            //     Then, once a collision is detected, we need to "react" in various ways

            // *** 3a -> Pacman Vs. Dot:
            //     ---------------------------------------------------------------------------
            //     if pacman collides with the dot, make the dot disappear

            // First, the simple way that is "built-in" to a picturebox object in C# - less
            // versitile (Meaning it won't transfer over to other programming environments) -
            // using the dot as an example (when pacman touches the dot the dot disappears)...

            // The collision detection........................................................
            // Using a "Rectangle" object built into C# that we ca retrieve from the two
            // picturebox objects, then use a built in actio to see if those two rectangles
            // are "intersecting" meaning "overlapping" or "touching" or "colliding"
            Rectangle pacmanHitbox = picPacman.Bounds;
            Rectangle dotHitBox    = picDot1.Bounds;
            if (pacmanHitbox.IntersectsWith(dotHitBox) == true)
            {
                picDot1.Visible = false;                // The collision reaction.............
            }

            // *** 3b -> Pacman Vs. Ghost:
            //     ---------------------------------------------------------------------------
            //     if pacman collides with the ghost, game over

            // Second, the more versitile (transferable to any programming environment) way
            // using our variables and math...................................................

            // Check if pacman is "touching" the ghost (the collision detection)..............
            if ( ( ( pacmanLeft   >= ghost1Left && pacmanLeft   <= ghost1Right  ) ||
                   ( pacmanRight  >= ghost1Left && pacmanRight  <= ghost1Right  ) ) &&
                 ( ( pacmanTop    >= ghost1Top  && pacmanTop    <= ghost1Bottom ) ||
                   ( pacmanBottom >= ghost1Top  && pacmanBottom <= ghost1Bottom ) ) )
            {
                Application.Exit();                // The collision reaction..................
            }
            else if ( ( ( ghost1Left   >= pacmanLeft && ghost1Left   <= pacmanRight  ) ||
                        ( ghost1Right  >= pacmanLeft && ghost1Right  <= pacmanRight  ) ) &&
                      ( ( ghost1Top    >= pacmanTop  && ghost1Top    <= pacmanBottom ) ||
                        ( ghost1Bottom >= pacmanTop  && ghost1Bottom <= pacmanBottom ) ) )
            {
                // This is "two-way" collision detection, "seeing" if pacman touches the
                // ghost, then is the ghost touching pacman (this is necessary when you have
                // two rectangles of different sizes).........................................
                Application.Exit();
            }

            // *** 3c -> Pacman Vs. Wall:
            //     ---------------------------------------------------------------------------
            //     if pacman collides with the wall, stop pacman at the wall

            // Collsion detection for the wall, again using the more complicated collison
            // detection, but I will use copy and paste (CTRL + C, CTRL + V) and find and
            // replace (CTRL + H) to make my typing easier. But, before doing the collison
            // detection, create a boolean variable (flag) start assuming pacman is not
            // touching the wall..............................................................

            bool touchingWall = false;

            // Collision detection............................................................
            if ( ( ( pacmanLeft   >= wall1Left && pacmanLeft   <= wall1Right  ) ||
                   ( pacmanRight  >= wall1Left && pacmanRight  <= wall1Right  ) ) &&
                 ( ( pacmanTop    >= wall1Top  && pacmanTop    <= wall1Bottom ) ||
                   ( pacmanBottom >= wall1Top  && pacmanBottom <= wall1Bottom ) ) )
            {
                touchingWall = true;
            }
            else if ( ( ( wall1Left   >= pacmanLeft && wall1Left   <= pacmanRight ) ||
                        ( wall1Right  >= pacmanLeft && wall1Right  <= pacmanRight ) ) &&
                      ( ( wall1Top    >= pacmanTop  && wall1Top    <= pacmanBottom ) ||
                        ( wall1Bottom >= pacmanTop  && wall1Bottom <= pacmanBottom ) ) )
            {
                touchingWall = true;
            }

            // Collision reaction (to hitting a wall).........................................
            if (touchingWall == true)
            {
                // Pacman's position (coordinates/variables) will change depending on which
                // direction pacman was moving................................................

                // A nested if statement
                if      (pacmanDirection == MOVE_UP)    pacmanTop  = wall1Bottom + 1;
                else if (pacmanDirection == MOVE_DOWN)  pacmanTop  = wall1Top    - pacmanHeight - 1;
                else if (pacmanDirection == MOVE_LEFT)  pacmanLeft = wall1Right  + 1;
                else if (pacmanDirection == MOVE_RIGHT) pacmanLeft = wall1Left   - pacmanWidth  - 1;
            }

            // (4) Move the Pacman picturebox:
            //     ===========================================================================
            //     Redraw pacman on the form in the new location from coordinates

            picPacman.Left = pacmanLeft;
            picPacman.Top  = pacmanTop;
        }
    }
}
