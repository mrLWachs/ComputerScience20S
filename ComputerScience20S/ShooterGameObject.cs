using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// ShooterGameObject - description...
/// </summary>
namespace ComputerScience20S
{
    class ShooterGameObject
    {

        public PictureBox image;

        public int left, right, top, bottom, width, height,
                   middleX, middleY, amount, direction;

        public ShooterGameObject(PictureBox image, int amount, int direction)
        {
            this.image = image;
            this.amount = amount;
            this.direction = direction;
            update();
        }

        public void update()
        {
            left = image.Left;
            top = image.Top;
            width = image.Width;
            height = image.Height;
            recalculate();
        }

        public void redraw()
        {
            image.Left = left;
            image.Top = top;
        }

        public void recalculate()
        {
            right = left + width;
            bottom = top + height;
            middleX = left + (width / 2);
            middleY = top + (height / 2);
        }

        public bool isColliding(ShooterGameObject target)
        {
            if (((this.left >= target.left && this.left <= target.right) ||
                 (this.right >= target.left && this.right <= target.right)) &&
                ((this.top >= target.top && this.top <= target.bottom) ||
                 (this.bottom >= target.top && this.bottom <= target.bottom)))
            {
                return true;
            }
            else if (((target.left >= this.left && target.left <= this.right) ||
                      (target.right >= this.left && target.right <= this.right)) &&
                     ((target.top >= this.top && target.top <= this.bottom) ||
                      (target.bottom >= this.top && target.bottom <= this.bottom)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void stickTo(ShooterGameObject target)
        {
            if (direction == Directions.LEFT) left = target.right + 1;
            else if (direction == Directions.RIGHT) left = target.left - width - 1;
            else if (direction == Directions.UP) top = target.bottom + 1;
            else if (direction == Directions.DOWN) top = target.top - height - 1;
        }

        public void bounceOff(ShooterGameObject target)
        {
            if (direction == Directions.LEFT) direction = Directions.RIGHT;
            else if (direction == Directions.RIGHT) direction = Directions.LEFT;
            else if (direction == Directions.UP) direction = Directions.DOWN;
            else if (direction == Directions.DOWN) direction = Directions.UP;
        }

        public void move()
        {
            update();
            if (direction == Directions.LEFT) left = left - amount;
            else if (direction == Directions.RIGHT) left = left + amount;
            else if (direction == Directions.UP) top = top - amount;
            else if (direction == Directions.DOWN) top = top + amount;
            recalculate();
        }

        public void centerOn(ShooterGameObject target)
        {
            left = target.middleX - (width / 2);
            top = target.middleY - (height / 2);
            recalculate();
        }

    }
}
