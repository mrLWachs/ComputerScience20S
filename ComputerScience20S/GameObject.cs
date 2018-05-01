using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerScience20S
{
    class GameObject
    {
        // classes advanced topic (from CS30S course)

        public int left      = 0;
        public int right     = 0;
        public int top       = 0;
        public int bottom    = 0;
        public int width     = 0;
        public int height    = 0;
        public int direction = 0;
        public int x         = 0;
        public int y         = 0;

        private double m = 0;
        private double b = 0;
        
        public void getCoordinates(PictureBox image)
        {
            // get images current coordinates
            x      = image.Left;
            y      = image.Top;
            width  = image.Width;
            height = image.Height;
            recalculate();
        }

        public void recalculate()
        {
            // calculate other coordinate values
            left   = x;
            top    = y;
            right  = left + width;
            bottom = top  + height;
        }


        public void getSlope(int y1, int x1)
        {
            // slope of a line equation
            m = (y1 - y) / (x1 - x);
            b = y - (m * x);
        }

        public int getY()
        {
            return (int)(m * x + b);
        }


        public bool isColliding(GameObject target)
        {
            // check for rectangle overlap collision
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
    }
}
