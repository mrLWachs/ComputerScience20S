using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScience20S
{
    class SimpleGameObject
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

        protected void recalaculate()
        {
            // calculate the other coordinate values
            right  = left + width;
            bottom = top  + height;
        }
        
    }
}
