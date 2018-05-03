using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// This represents a dot in the game of Pacman
/// </summary>
namespace ComputerScience20S
{
    class Dot : SimpleGameObject
    {

        /// <summary>
        /// Constructor sets class properties
        /// </summary>
        /// <param name="hitbox">the image to associate with the property</param>
        public Dot(PictureBox hitbox)
        {
            base.getCoordinates(hitbox);
        }

        /// <summary>
        /// When a dot gets eaten by pacman
        /// </summary>
        public void getEaten()
        {
            base.hitbox.Visible = false;
        }

        /// <summary>
        /// Determines if a dot is still in the game
        /// </summary>
        /// <returns>dot is in game (true), or not (false)</returns>
        public bool isAlive()
        {
            return base.hitbox.Visible;
        }

    }
}
