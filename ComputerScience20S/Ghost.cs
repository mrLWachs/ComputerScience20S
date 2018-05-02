using ComputerScience20S.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// This represents a ghost in the game of Pacman
/// </summary>
namespace ComputerScience20S
{
    class Ghost : LivingGameObject
    {

        /// <summary>
        /// The amount a ghost moves
        /// </summary>
        private const int GHOST_AMOUNT = 7;
        /// <summary>
        /// The 4 types of ghosts
        /// </summary>
        private const int BLINKY = 0;
        private const int INKY   = 1;
        private const int PINKY  = 2;
        private const int CLYDE  = 3;

        private Pacman pacman;
        private Wall[] walls;

        private int ghostType;

        // flag variables to track animation state
        private bool isOpen = false;


        public Ghost(PictureBox hitbox, int ghostType)
        {
            base.getCoordinates(hitbox);
            base.direction = base.randomDirection();
            this.ghostType = ghostType;
        }

        public void assign(Wall[] walls)
        {
            this.walls = walls;
        }

        public void assign(Pacman pacman)
        {
            this.pacman = pacman;
        }

        public bool action()
        {
            // update the coordaintes of where this ghost currently is
            updateCoordinates();

            // now move this ghost's coordinates an amount
            move(GHOST_AMOUNT);

            // loop through all walls and check for collision
            for (int j = 0; j < walls.Length; j++)
            {
                // if collision has occured, bounce this ghost off that wall
                if (isColliding(walls[j]))
                {
                    bounceOff(walls[j]);
                }
            }

            // now redraw this ghost in his final position
            hitbox.Top = base.top;
            hitbox.Left = base.left;

            // check for collision with pacman, if occurs stop the game
            return isColliding(pacman);

        }

        public void animate()
        {
            // every tick of the timer
            if (isOpen == true)
            {
                // mouth should be set to be closed (it was open)
                // change the image and set the flag to closed
                if      (ghostType == BLINKY) hitbox.Image = Resources.BlinkyClosed;
                else if (ghostType == INKY)   hitbox.Image = Resources.InkyClosed;
                else if (ghostType == PINKY)  hitbox.Image = Resources.PinkyClosed;
                else if (ghostType == CLYDE)  hitbox.Image = Resources.ClydeClosed;
                isOpen = false;
            }
            else if (isOpen == false)
            {
                // mouth should be set to be open (it was closed)
                // change the image and set the flag to closed
                if      (ghostType == BLINKY) hitbox.Image = Resources.BlinkyOpen;
                else if (ghostType == INKY)   hitbox.Image = Resources.InkyOpen;
                else if (ghostType == PINKY)  hitbox.Image = Resources.PinkyOpen;
                else if (ghostType == CLYDE)  hitbox.Image = Resources.ClydeOpen;
                isOpen = true;
            }
        }

    }
}
