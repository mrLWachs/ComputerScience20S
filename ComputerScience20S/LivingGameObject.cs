using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// This represents a 'living' game character
/// </summary>
namespace ComputerScience20S
{
    class LivingGameObject : SimpleGameObject
    {

        // Global Constants across all forms for keyboard codes:
        public const int KEY_END   = 27;
        public const int KEY_UP    = 38; // W - 87
        public const int KEY_DOWN  = 40; // S - 83
        public const int KEY_LEFT  = 37; // A - 65
        public const int KEY_RIGHT = 39; // D - 68

        // Global Constants across all forms for tracking movement:
        public const int MOVE_UP    = 1;
        public const int MOVE_DOWN  = 2;
        public const int MOVE_LEFT  = 3;
        public const int MOVE_RIGHT = 4;
        public const int STOPPED    = 0;

        public void keyPress(Form form, KeyEventArgs e)
        {
            // get keyboard code and check against the Globals class values:
            if      (e.KeyValue == KEY_END)   form.Close();
            else if (e.KeyValue == KEY_DOWN)  base.direction = MOVE_DOWN;
            else if (e.KeyValue == KEY_UP)    base.direction = MOVE_UP;
            else if (e.KeyValue == KEY_LEFT)  base.direction = MOVE_LEFT;
            else if (e.KeyValue == KEY_RIGHT) base.direction = MOVE_RIGHT;
        }

        public bool isColliding(SimpleGameObject target)
        {
            // collision detection code to see if the 2 rectangles overlap
            if (((left   >= target.left && left   <= target.right) ||
                 (right  >= target.left && right  <= target.right)) &&
                ((top    >= target.top  && top    <= target.bottom) ||
                 (bottom >= target.top  && bottom <= target.bottom)))
            {
                return true;
            }
            else if (((target.left   >= left && target.left   <= right) ||
                      (target.right  >= left && target.right  <= right)) &&
                     ((target.top    >= top  && target.top    <= bottom) ||
                      (target.bottom >= top  && target.bottom <= bottom)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void move(int amount)
        {
            // based on amount and direction, adjust the coordinates for a movement
            if      (direction == MOVE_UP)    top  = top  - amount;
            else if (direction == MOVE_DOWN)  top  = top  + amount;
            else if (direction == MOVE_LEFT)  left = left - amount;
            else if (direction == MOVE_RIGHT) left = left + amount;
            base.recalaculate();
        }

        public void stickTo(SimpleGameObject target)
        {
            // adjust the coordinates based on direction to stick to an object
            if      (direction == MOVE_UP)    top  = target.bottom + 1;
            else if (direction == MOVE_DOWN)  top  = target.top    - height - 1;
            else if (direction == MOVE_LEFT)  left = target.right  + 1;
            else if (direction == MOVE_RIGHT) left = target.left   - width - 1;
            base.recalaculate();
        }

        public void bounceOff(SimpleGameObject target)
        {
            // adjust the coordinates to stick and then randomly bounce off an object
            stickTo(target);
            direction = randomDirection();
        }

        public int randomDirection()
        {
            Random random = new Random();
            return random.Next(MOVE_UP, MOVE_RIGHT + 1);
        }

    }
}
