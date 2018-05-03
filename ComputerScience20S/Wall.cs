using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// This represents a wall in the game of Pacman
/// </summary>
namespace ComputerScience20S
{
    class Wall : SimpleGameObject
    {

        /// <summary>
        /// Constructor sets class properties
        /// </summary>
        /// <param name="hitbox">the image to associate with the property</param>
        public Wall(PictureBox hitbox)
        {
            base.getCoordinates(hitbox);
            base.hitbox.Visible = false;
        }

    }
}
