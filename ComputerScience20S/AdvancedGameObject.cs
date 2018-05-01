using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScience20S
{
    class AdvancedGameObject
    {
        // global variables to this class tracking coordinates:
        public int left;
        public int right;
        public int top;
        public int bottom;
        public int width;
        public int height;
        public int direction;

        // global link to the picturebox on the other form
        public PictureBox hitbox;

        public void getCoordinates(PictureBox picturebox)
        {
            // link the pictruebox to the hitbox
            hitbox = picturebox;
            updateCoordinates();
        }

        public void updateCoordinates()
        {
            // get all coordinate values from the hitbox (picturebox)
            left   = hitbox.Left;
            top    = hitbox.Top;
            width  = hitbox.Width;
            height = hitbox.Height;
            recalaculate();
        }

        private void recalaculate()
        {
            // calculate the other coordinate values
            right = left + width;
            bottom = top + height;
        }

        public bool isColliding(AdvancedGameObject target)
        {
            // collision detection code to see if the 2 rectangles overlap
            if ((( left   >= target.left && left   <= target.right  )   ||
                 ( right  >= target.left && right  <= target.right  ))  &&
                (( top    >= target.top  && top    <= target.bottom )   ||
                 ( bottom >= target.top  && bottom <= target.bottom )))
            {
                return true;
            }
            else if ((( target.left   >= left && target.left   <= right  )   ||
                      ( target.right  >= left && target.right  <= right  ))  &&
                     (( target.top    >= top  && target.top    <= bottom )   ||
                      ( target.bottom >= top  && target.bottom <= bottom )))
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
            if      (direction == Globals.MOVE_UP)    top  = top  - amount;
            else if (direction == Globals.MOVE_DOWN)  top  = top  + amount;
            else if (direction == Globals.MOVE_LEFT)  left = left - amount;
            else if (direction == Globals.MOVE_RIGHT) left = left + amount;
            recalaculate();
        }

        public void stickTo(AdvancedGameObject target)
        {
            // adjust the coordinates based on direction to stick to an object
            if      (direction == Globals.MOVE_UP)    top  = target.bottom + 1;
            else if (direction == Globals.MOVE_DOWN)  top  = target.top - height - 1;
            else if (direction == Globals.MOVE_LEFT)  left = target.right + 1;
            else if (direction == Globals.MOVE_RIGHT) left = target.left - width - 1;
            recalaculate();
        }

        public void bounceOff(AdvancedGameObject target)
        {
            // adjust the coordinates to stick and then randomly bounce off an object
            stickTo(target);
            Random random = new Random();
            direction = random.Next(1, 5);
        }

    }
}
