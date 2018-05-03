using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// The global environmental values in the game of pacman
/// </summary>
namespace ComputerScience20S
{
    class PacmanGlobals
    {

        /// <summary>
        /// global constants for the total number of ghosts
        /// </summary>
        public static int GHOSTS = 4;

        /// <summary>
        /// global constants for the total number of walls
        /// </summary>
        public static int WALLS  = 44;

        /// <summary>
        /// global constants for the total number of dots
        /// </summary>
        public static int DOTS   = 245;

        /// <summary>
        /// The Blinky type of ghost
        /// </summary>
        public static int BLINKY = 0;

        /// <summary>
        /// The Inky type of ghost
        /// </summary>
        public static int INKY   = 1;

        /// <summary>
        /// The Pinky type of ghost
        /// </summary>
        public static int PINKY  = 2;

        /// <summary>
        /// The Clyde type of ghost
        /// </summary>
        public static int CLYDE  = 3;

        /// <summary>
        /// The amount a ghost moves
        /// </summary>
        public static int GHOST_AMOUNT = 7;

        /// <summary>
        /// The amount pacman moves
        /// </summary>
        public const int PACMAN_AMOUNT = 5;

    }
}
