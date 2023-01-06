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

        // Global Variables/Constants:

        const int REDS_TURN   = 1;
        const int BLACKS_TURN = 2;

        int turn = BLACKS_TURN;

        // Create an array (advanced way to remember data, or
        // variables, also it is like a list, group, etc. and it
        // generally uses a 'plural' word)

        PictureBox[,] board = new PictureBox[3,3];


        public frmProgrammingExtras3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Write a "verb" (action word) to signal to
            // Visual Studio that we are going to make a 
            // "Method" (aka function, procedure) - use two
            // round brackets at the end (before the ";")

            setupBoard();

            // Once the word is placed, a "lightbulb" may 
            // appear - click on the lightbulb and then
            // click on "Generate method..." to have Visual 
            // Studio write the code for you  
        }
        
        private void setupBoard()
        {
            // This is a method (advanced way to divide up the
            // logic/instructions/code, also known as a function,
            // action, procedure and it usually uses a 'verb')

            // Used the array and connect all the pictureboxes
            // to locations (row, column) in the array (matrix)

            board[0, 0] = pic1;
            board[0, 1] = pic2;
            board[0, 2] = pic3;
            board[1, 0] = pic4;
            board[1, 1] = pic5;
            board[1, 2] = pic6;
            board[2, 0] = pic7;
            board[2, 1] = pic8;
            board[2, 2] = pic9;

            // Set up some colors...

            this.BackColor = Color.White;

            // To use the array (matrix), use for loops
            // (nested for loops to go through all the
            // rows and columns)

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    board[row, column].BackColor = Color.Yellow;
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // use ("call") another method...
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

        private void clickOn(int row, int column)
        {
            // rename the code above (called 
            // parameters)

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

            checkForWins();

        }

        private void checkForWins()
        {
            // Methods can "call" (execute, run, use) other
            // methods

            bool gameOver = false;

            // Now check for all the win scenarios...

            if (gameOver == false) gameOver = checkAcross();
            if (gameOver == false) gameOver = checkDown();
            if (gameOver == false) gameOver = checkDiagonals();

            // Only if the game is over...

            if (gameOver == true)
            {
                Application.Exit();
            }
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
