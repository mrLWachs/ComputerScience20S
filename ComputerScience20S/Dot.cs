using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScience20S
{
    class Dot : SimpleGameObject
    {
        private PictureBox image;

        public Dot(PictureBox image)
        {
            base.getCoordinates(image);
            this.image = image;
        }

        public void getEaten()
        {
            image.Visible = false;
        }

        public bool isAlive()
        {
            return image.Visible;
        }

    }
}
