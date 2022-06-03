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
            // Code to play the sound file

            // How do files work?

            // File have 3 names...
            // first name (for example "C:\Users\lawrence.wachs\Desktop") - or path, location
            // middle name (for example "sound")
            // last name (for example ".wav") - or extension

            // Use the open file dialog to choose a file
            // it will give us all three names

            // fun option, only filter in 
            // files that are "wav" files
            openFileDialog1.Filter = "Sound Files|*.wav";

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
            frmProgrammingExtras1Form3 form3 = new frmProgrammingExtras1Form3();
            form3.Show();
        }
        
    }
}
