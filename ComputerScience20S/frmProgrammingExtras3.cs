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
    public partial class frmProgrammingExtras3 : Form
    {

        // Global variables/constants:

        const int REDS_TURN   = 1;
        const int BLACKS_TURN = 2;

        int turn = BLACKS_TURN;

        // 2D array (matrix) of picture boxes
        PictureBox[,] board = new PictureBox[3,3];


        public frmProgrammingExtras3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // put designer picture boxes into the global array
            board[0, 0] = pictureBox1;
            board[0, 1] = pictureBox2;
            board[0, 2] = pictureBox3;
            board[1, 0] = pictureBox4;
            board[1, 1] = pictureBox5;
            board[1, 2] = pictureBox6;
            board[2, 0] = pictureBox7;
            board[2, 1] = pictureBox8;
            board[2, 2] = pictureBox9;

            // set colors
            this.BackColor = Color.White;
            
            // nested for loops used to traverse 2D arrays
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    board[r, c].BackColor = Color.Yellow;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // call the method
            clickOn(0,  0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            clickOn(0, 1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            clickOn(0, 2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            clickOn(1, 0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            clickOn(1, 1);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            clickOn(1, 2);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            clickOn(2, 0);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            clickOn(2, 1);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            clickOn(2, 2);
        }

        // this is a method, a new concept usually covered in the CS30S course
        private void clickOn(int row, int column)
        {
            if (turn == REDS_TURN)
            {
                board[row, column].BackColor = Color.Red;
                turn = BLACKS_TURN;
            }
            else if (turn == BLACKS_TURN)
            {
                board[row, column].BackColor = Color.Black;
                turn = REDS_TURN;
            }
            board[row, column].Enabled = false;
            checkForWin();
        }

        // another method
        private void checkForWin()
        {
            bool gameOver = false;
            if (gameOver == false) gameOver = checkAcross();
            if (gameOver == false) gameOver = checkDown();
            if (gameOver == false) gameOver = checkDiagonals();
            if (gameOver) this.Close();
        }

        private bool checkDiagonals()
        {
            if (board[0, 0].BackColor == board[1, 1].BackColor &&
                board[0, 0].BackColor == board[2, 2].BackColor)
            {
                if (board[1, 1].BackColor == Color.Red)
                {
                    MessageBox.Show("Red wins diagonally going down");
                    return true;
                }
                else if (board[1, 1].BackColor == Color.Black)
                {
                    MessageBox.Show("Black wins diagonally going down");
                    return true;
                }
            }
            else if (board[0, 2].BackColor == board[1, 1].BackColor &&
                     board[0, 2].BackColor == board[2, 0].BackColor)
            {
                if (board[1, 1].BackColor == Color.Red)
                {
                    MessageBox.Show("Red wins diagonally going up");
                    return true;
                }
                else if (board[1, 1].BackColor == Color.Black)
                {
                    MessageBox.Show("Black wins diagonally going up");
                    return true;
                }
            }
            return false;
        }
        
        private bool checkDown()
        {
            for (int column = 0; column < 3; column++)
            {
                if (board[0, column].BackColor == board[1, column].BackColor &&
                    board[0, column].BackColor == board[2, column].BackColor)
                {
                    if (board[0, column].BackColor == Color.Red)
                    {
                        MessageBox.Show("Red wins down on column " + (column+1));
                        return true;
                    }
                    else if (board[0, column].BackColor == Color.Black)
                    {
                        MessageBox.Show("Black wins down on column " + (column + 1));
                        return true;
                    }
                }
            }
            return false;
        }

        private bool checkAcross()
        {
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0].BackColor == board[row, 1].BackColor &&
                    board[row, 0].BackColor == board[row, 2].BackColor)
                {
                    if (board[row, 0].BackColor == Color.Red)
                    {
                        MessageBox.Show("Red wins across on row " + (row + 1));
                        return true;
                    }
                    else if (board[row, 0].BackColor == Color.Black)
                    {
                        MessageBox.Show("Black wins across on row " + (row + 1));
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
