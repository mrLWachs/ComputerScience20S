﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScience20S
{
    public partial class frmProgrammingExtras2 : Form
    {

        // Global variables/constants:

        const int KEY_END   = 27;
        const int KEY_UP    = 38; // "or" W - 87
        const int KEY_DOWN  = 40; // "or" S - 83
        const int KEY_LEFT  = 37; // "or" A - 65
        const int KEY_RIGHT = 39; // "or" D - 68

        const int MOVE_UP    = 1;
        const int MOVE_DOWN  = 2;
        const int MOVE_LEFT  = 3;
        const int MOVE_RIGHT = 4;
        const int STOPPED    = 0;

        // coordinates for pacman
        int pacmanTop    = 0;
        int pacmanBottom = 0;
        int pacmanLeft   = 0;
        int pacmanRight  = 0;
        int pacmanWidth  = 0;
        int pacmanHeight = 0;

        int pacmanDirection = 0;

        // coordinates for dot
        int dotTop = 0;
        int dotBottom = 0;
        int dotLeft = 0;
        int dotRight = 0;
        int dotWidth = 0;
        int dotHeight = 0;

        // coordinates for wall
        int wallTop = 0;
        int wallBottom = 0;
        int wallLeft = 0;
        int wallRight = 0;
        int wallWidth = 0;
        int wallHeight = 0;

        // coordinates for ghost
        int ghostTop = 0;
        int ghostBottom = 0;
        int ghostLeft = 0;
        int ghostRight = 0;
        int ghostWidth = 0;
        int ghostHeight = 0;
        

        public frmProgrammingExtras2()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if      (e.KeyValue == KEY_END)   this.Close();
            else if (e.KeyValue == KEY_DOWN)  pacmanDirection = MOVE_DOWN;
            else if (e.KeyValue == KEY_UP)    pacmanDirection = MOVE_UP;
            else if (e.KeyValue == KEY_LEFT)  pacmanDirection = MOVE_LEFT;
            else if (e.KeyValue == KEY_RIGHT) pacmanDirection = MOVE_RIGHT;
            else                              pacmanDirection = STOPPED;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getTheCoordinates();
            moveTheCoordinates();
            checkForCollisions();
            picPacman.Top = pacmanTop;
            picPacman.Left = pacmanLeft;
        }

        private void checkForCollisions()
        {
            // dot collision:
            if ((( pacmanLeft   >= dotLeft   && pacmanLeft   <= dotRight ) || 
                 ( pacmanRight  >= dotLeft   && pacmanRight  <= dotRight )) &&
                (( pacmanTop    >= dotTop    && pacmanTop    <= dotBottom ) ||
                 ( pacmanBottom >= dotTop    && pacmanBottom <= dotBottom)))
            {
                picDot.Visible = false;
            }
            else if ((( dotLeft   >= pacmanLeft   && dotLeft   <= pacmanRight) ||
                      ( dotRight  >= pacmanLeft   && dotRight  <= pacmanRight)) &&
                     (( dotTop    >= pacmanTop    && dotTop    <= pacmanBottom) ||
                      ( dotBottom >= pacmanTop && dotBottom <= pacmanBottom)))
            {
                picDot.Visible = false;
            }

            // ghost collision:
            if (((pacmanLeft >= ghostLeft && pacmanLeft <= ghostRight) ||
                 (pacmanRight >= ghostLeft && pacmanRight <= ghostRight)) &&
                ((pacmanTop >= ghostTop && pacmanTop <= ghostBottom) ||
                 (pacmanBottom >= ghostTop && pacmanBottom <= ghostBottom)))
            {
                this.Close();
            }
            else if (((ghostLeft >= pacmanLeft && ghostLeft <= pacmanRight) ||
                      (ghostRight >= pacmanLeft && ghostRight <= pacmanRight)) &&
                     ((ghostTop >= pacmanTop && ghostTop <= pacmanBottom) ||
                      (ghostBottom >= pacmanTop && ghostBottom <= pacmanBottom)))
            {
                this.Close();
            }

            // wall collision
            bool hittingWall = false;
            if (((pacmanLeft >= wallLeft && pacmanLeft <= wallRight) ||
                 (pacmanRight >= wallLeft && pacmanRight <= wallRight)) &&
                ((pacmanTop >= wallTop && pacmanTop <= wallBottom) ||
                 (pacmanBottom >= wallTop && pacmanBottom <= wallBottom)))
            {
                hittingWall = true;
            }
            else if (((wallLeft >= pacmanLeft && wallLeft <= pacmanRight) ||
                      (wallRight >= pacmanLeft && wallRight <= pacmanRight)) &&
                     ((wallTop >= pacmanTop && wallTop <= pacmanBottom) ||
                      (wallBottom >= pacmanTop && wallBottom <= pacmanBottom)))
            {
                hittingWall = true;
            }

            // wall reaction
            if (hittingWall == true)
            {
                if (pacmanDirection == MOVE_DOWN)
                {
                    pacmanTop = wallTop - pacmanHeight - 1;
                }
                else if (pacmanDirection == MOVE_UP)
                {
                    pacmanTop = wallBottom + 1;
                }
                else if (pacmanDirection == MOVE_LEFT)
                {
                    pacmanLeft = wallRight + 1;
                }
                else if (pacmanDirection == MOVE_RIGHT)
                {
                    pacmanLeft = wallLeft - pacmanWidth - 1;
                }
                pacmanBottom = pacmanTop + pacmanHeight;
                pacmanRight = pacmanLeft + pacmanWidth;
            }
        }
        
        private void moveTheCoordinates()
        {
            const int MOVE_AMOUNT = 2;
            if      (pacmanDirection == MOVE_UP)    pacmanTop  = pacmanTop  - MOVE_AMOUNT;
            else if (pacmanDirection == MOVE_DOWN)  pacmanTop  = pacmanTop  + MOVE_AMOUNT; 
            else if (pacmanDirection == MOVE_LEFT)  pacmanLeft = pacmanLeft - MOVE_AMOUNT; 
            else if (pacmanDirection == MOVE_RIGHT) pacmanLeft = pacmanLeft + MOVE_AMOUNT; 
            pacmanBottom = pacmanTop + pacmanHeight;
            pacmanRight = pacmanLeft + pacmanWidth;
        }

        private void getTheCoordinates()
        {
            pacmanTop = picPacman.Top;
            pacmanLeft = picPacman.Left;
            pacmanWidth = picPacman.Width;
            pacmanHeight = picPacman.Height;
            pacmanBottom = pacmanTop + pacmanHeight;
            pacmanRight = pacmanLeft + pacmanWidth;

            dotTop = picDot.Top;
            dotLeft = picDot.Left;
            dotWidth = picDot.Width;
            dotHeight = picDot.Height;
            dotBottom = dotTop + dotHeight;
            dotRight = dotLeft + dotWidth;

            wallTop = picWall.Top;
            wallLeft = picWall.Left;
            wallWidth = picWall.Width;
            wallHeight = picWall.Height;
            wallBottom = wallTop + wallHeight;
            wallRight = wallLeft + wallWidth;

            ghostTop = picGhost.Top;
            ghostLeft = picGhost.Left;
            ghostWidth = picGhost.Width;
            ghostHeight = picGhost.Height;
            ghostBottom = ghostTop + ghostHeight;
            ghostRight = ghostLeft + ghostWidth;
        }
    }
}
