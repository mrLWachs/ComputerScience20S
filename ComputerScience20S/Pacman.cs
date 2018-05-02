using ComputerScience20S.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScience20S
{
    class Pacman : LivingGameObject
    {

        // Global Constants across all forms for movement amounts:
        private const int PACMAN_AMOUNT = 5;

        private Dot[] dots;
        private Wall[] walls;

        // flag variables to track animation state
        private bool isOpen = false;


        public Pacman(PictureBox hitbox)
        {
            base.getCoordinates(hitbox);
            base.hitbox = hitbox;
        }

        public void assign(Dot[] dots)
        {
            this.dots = dots;
        }

        public void assign(Wall[] walls)
        {
            this.walls = walls;
        }

        public void action()
        {
            // update the coordaintes of where pacman currently is
            updateCoordinates();

            // now move those coordinates an amount
            base.move(PACMAN_AMOUNT);

            // loop through all dots and check for collision
            for (int i = 0; i < dots.Length; i++)
            {
                // if collision has occured, and dot is not already invisible, make invisible
                if (dots[i].isAlive())
                {
                    if (isColliding(dots[i]))
                    {
                        dots[i].getEaten();
                    }
                }
            }

            // loop through all walls and check for collision
            for (int i = 0; i < walls.Length; i++)
            {
                // if collision has occured, stick pacman to that wall
                if (isColliding(walls[i]))
                {
                    stickTo(walls[i]);
                }
            }

            // now redraw pacman in his final position
            hitbox.Top = base.top;
            hitbox.Left = base.left;
        }

        public void animate()
        {
            // every tick of the timer
            if (isOpen == true)
            {
                // mouth should be set to be closed (it was open)
                // change the image and set the flag to closed
                hitbox.Image = Resources.pacmanResting;
                isOpen = false;
            }
            else if (isOpen == false)
            {
                // mouth should be set to be open (it was closed)
                // change the image and set the flag to closed
                // but set the image based on the direction
                if (direction == MOVE_LEFT)
                {
                    hitbox.Image = Resources.pacmanLeft;
                }
                else if (direction == MOVE_RIGHT)
                {
                    hitbox.Image = Resources.pacmanRight;
                }
                else if (direction == MOVE_UP)
                {
                    hitbox.Image = Resources.pacmanUp;
                }
                else if (direction == MOVE_DOWN)
                {
                    hitbox.Image = Resources.pacmanDown;
                }
                isOpen = true;
            }
        }
    }
}
