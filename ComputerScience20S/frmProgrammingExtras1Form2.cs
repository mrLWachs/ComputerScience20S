using System;
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
    public partial class frmProgrammingExtras1Form2 : Form
    {
        public frmProgrammingExtras1Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Code to play the sound file, we use the open 
            // file dialog to have the user choose a file

            // A fun option, only filter in files that are
            // are "mp3" files
            openFileDialog1.Filter = "Sound Files|*.mp3";

            // Makes the dialog appear and choose a file
            openFileDialog1.ShowDialog();

            // Load the sound file into the player
            axWindowsMediaPlayer1.URL = openFileDialog1.FileName;

            // Play the sound
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Use the same code and change the filtering..
            openFileDialog1.Filter = "Video Files|*.mp4";
            openFileDialog1.ShowDialog();
            axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Hide the controls on the media player
            axWindowsMediaPlayer1.uiMode = "full";
            // "ui" is short for "user interface"
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.uiMode = "none";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Also code like..
            this.Close();

            // the code above only closes the current form
            // means the rest of the program (other forms)
            // could still be running...

            // switch to my last form
            Form3 form3 = new Form3();
            form3.Show();
        }
        
    }
}
