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
        /// Association with a pacman object
        /// </summary>
        private Pacman pacman;

        /// <summary>
        /// Association with the wall objects
        /// </summary>
        private Wall[] walls;

        /// <summary>
        /// the type of ghost this object is
        /// </summary>
        private int ghostType;

        /// <summary>
        /// flag variables to track animation state
        /// </summary>
        private bool isOpen = false;


        /// <summary>
        /// Constructor sets class properties
        /// </summary>
        /// <param name="hitbox">the image to associate with the property</param>
        /// <param name="ghostType">whihc type of ghost this is</param>
        public Ghost(PictureBox hitbox, int ghostType)
        {
            base.getCoordinates(hitbox);

            // start the ghost in a random direction
            base.direction = base.randomDirection();

            // set the type of ghost
            this.ghostType = ghostType;
        }

        /// <summary>
        /// Associates this ghost with the wall objects
        /// </summary>
        /// <param name="walls">the wall objects to associate with</param>
        public void assign(Wall[] walls)
        {
            this.walls = walls;
        }

        /// <summary>
        /// Associates this ghost with the pacman object
        /// </summary>
        /// <param name="pacman">the pacman object to associate with</param>
        public void assign(Pacman pacman)
        {
            this.pacman = pacman;
        }

        /// <summary>
        /// The action for this ghost
        /// </summary>
        /// <returns>If the ghost hits pacman (true), or not (false)</returns>
        public bool action()
        {
            // update the coordaintes of where this ghost currently is
            updateCoordinates();

            // now move this ghost's coordinates an amount
            move(PacmanGlobals.GHOST_AMOUNT);

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

        /// <summary>
        /// The visual animation for this ghost
        /// </summary>
        public void animate()
        {
            // every tick of the timer
            if (isOpen == true)
            {
                // mouth should be set to be closed (it was open)
                // change the image and set the flag to closed
                if      (ghostType == PacmanGlobals.BLINKY) hitbox.Image = Resources.BlinkyClosed;
                else if (ghostType == PacmanGlobals.INKY)   hitbox.Image = Resources.InkyClosed;
                else if (ghostType == PacmanGlobals.PINKY)  hitbox.Image = Resources.PinkyClosed;
                else if (ghostType == PacmanGlobals.CLYDE)  hitbox.Image = Resources.ClydeClosed;
                isOpen = false;
            }
            else if (isOpen == false)
            {
                // mouth should be set to be open (it was closed)
                // change the image and set the flag to closed
                if      (ghostType == PacmanGlobals.BLINKY) hitbox.Image = Resources.BlinkyOpen;
                else if (ghostType == PacmanGlobals.INKY)   hitbox.Image = Resources.InkyOpen;
                else if (ghostType == PacmanGlobals.PINKY)  hitbox.Image = Resources.PinkyOpen;
                else if (ghostType == PacmanGlobals.CLYDE)  hitbox.Image = Resources.ClydeOpen;
                isOpen = true;
            }
        }

    }
}
