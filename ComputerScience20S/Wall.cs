using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScience20S
{
    class Wall : SimpleGameObject
    {

        public Wall(PictureBox image)
        {
            base.getCoordinates(image);
            image.Visible = false;
        }

    }
}
