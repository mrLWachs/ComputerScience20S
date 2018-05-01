using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience20S
{
    class Globals
    {

        // Global Constants across all forms for keyboard codes:
        public static int KEY_END   = 27;
        public static int KEY_UP    = 38; // W - 87
        public static int KEY_DOWN  = 40; // S - 83
        public static int KEY_LEFT  = 37; // A - 65
        public static int KEY_RIGHT = 39; // D - 68

        // Global Constants across all forms for tracking movement:
        public static int MOVE_UP    = 1;
        public static int MOVE_DOWN  = 2;
        public static int MOVE_LEFT  = 3;
        public static int MOVE_RIGHT = 4;
        public static int STOPPED    = 0;

        // Global Constants across all forms for movement amounts:
        public static int PACMAN_AMOUNT = 5;
        public static int GHOST_AMOUNT  = 7;
        
    }
}
