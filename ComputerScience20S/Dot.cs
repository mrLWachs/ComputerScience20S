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
        /// The image associated with this dot property
        /// </summary>
        private PictureBox image;

        /// <summary>
        /// Constructor sets class properties
        /// </summary>
        /// <param name="image">the image to associate with the property</param>
        public Dot(PictureBox image)
        {
            base.getCoordinates(image);
            this.image = image;
        }

        /// <summary>
        /// When a dot gets eaten by pacman
        /// </summary>
        public void getEaten()
        {
            image.Visible = false;
        }

        /// <summary>
        /// Determines if a dot is still in the game
        /// </summary>
        /// <returns>dot is in game (true), or not (false)</returns>
        public bool isAlive()
        {
            return image.Visible;
        }

    }
}
