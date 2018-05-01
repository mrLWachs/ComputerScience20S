using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerScience20S
{
    public partial class frmProgrammingExtras4 : Form
    {
        // Global variables/constants:

        int mouseX = 0;
        int mouseY = 0;
        int startX = 0;
        int startY = 0;

        const int BULLET_MOVE_AMOUNT = 1;
        const int ENEMY_MOVE_AMOUNT  = 1;
        const int MAX_BASES          = 5;



        // class objects (advanced content from CS30S):
        GameObject bullet = new GameObject();
        GameObject enemy = new GameObject();
        GameObject[] bases = new GameObject[MAX_BASES];

        PictureBox[] baseImages = new PictureBox[MAX_BASES];

        public frmProgrammingExtras4()
        {
            InitializeComponent();
        }

        private void frmProgrammingExtras4_Load(object sender, EventArgs e)
        {
            // load picture boxes into arrays
            baseImages[0] = picBase1;
            baseImages[1] = picBase2;
            baseImages[2] = picBase3;
            baseImages[3] = picBase4;
            baseImages[4] = picBase5;
            // create class objects
            for (int i = 0; i < baseImages.Length; i++)
            {
                bases[i] = new GameObject();
                bases[i].getCoordinates(baseImages[i]);
            }
            // position objects on screen
            picEnemy.Visible = false;
            startX = bases[4].left + (bases[4].width / 2) - (picBullet.Width / 2);
            startY = bases[4].top  - picBullet.Height;
            picBullet.Left = startX;
            picBullet.Top  = startY;
        }
        
        private void frmProgrammingExtras4_MouseClick(object sender, MouseEventArgs e)
        {
            // mouse click code
            if (tmrShoot.Enabled == false)
            {
                // timer is not running, get current mouse position (x,y)
                mouseX = e.X;
                mouseY = e.Y;
                // start bullet timer
                tmrShoot.Enabled = true;
            }
        }

        private void tmrShoot_Tick(object sender, EventArgs e)
        {
            // get current bullet and enemy coordinates
            bullet.getCoordinates(picBullet);
            enemy.getCoordinates(picEnemy);
            // start calculating bullet location
            int move = BULLET_MOVE_AMOUNT;
            bool atLocation = false;
            if (mouseX <= startX)
            {
                move = move * -BULLET_MOVE_AMOUNT;
            }
            if (bullet.y > mouseY)
            {
                bullet.getSlope(mouseY, mouseX);
                bullet.x = bullet.x + move;
                bullet.y = bullet.getY();
            }
            else
            {
                atLocation = true;
            }
            bullet.recalculate();
            // check for collision with enemies
            bool hitEnemy = bullet.isColliding(enemy);
            if (hitEnemy == true || atLocation == true)
            {
                // enemy hit, reaction
                tmrShoot.Enabled = false;
                bullet.x = startX;
                bullet.y = startY;
                if (hitEnemy == true)
                {
                    picEnemy.Visible = false;
                }
            }
            // redraw bullet at position
            picBullet.Left = bullet.x;
            picBullet.Top = bullet.y;
        }

        private void tmrEnemy_Tick(object sender, EventArgs e)
        {
            // get current enemy coordinates
            enemy.getCoordinates(picEnemy);
            int startingLocation = 0;
            if (picEnemy.Visible == false)
            {
                // reset enemy to spawn at a new location
                Random random = new Random();
                startingLocation = random.Next(0, this.Width - enemy.width);
                enemy.x = startingLocation;
                enemy.y = 0;
                picEnemy.Visible = true;
            }
            else
            {
                // move enemy down
                enemy.y = enemy.y + ENEMY_MOVE_AMOUNT;
                enemy.recalculate();
                if (enemy.bottom >= this.Height)
                {
                    //past screen bottom
                    picEnemy.Visible = false;
                }
                for (int i = 0; i < bases.Length; i++)
                {
                    if (enemy.isColliding(bases[i]) && baseImages[i].Visible == true)
                    {
                        // hit a base
                        baseImages[i].Visible = false;
                        picEnemy.Visible = false;
                    }
                }
            }
            // redraw enemy on screen
            picEnemy.Left = enemy.x;
            picEnemy.Top = enemy.y;
        }

    }
}
