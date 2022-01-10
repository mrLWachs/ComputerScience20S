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
    public partial class frmProgrammingExtras1Form3 : Form
    {
        public frmProgrammingExtras1Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            frmProgrammingExtras1Form1.endExample();
        }

        private void frmProgrammingExtras1Form3_Load(object sender, EventArgs e)
        {
            // Create a path to a sound file the computer can play
            string filename = "C:\\Windows\\Media\\Windows Exclamation.wav";
            
            // Create a sound player using purely code
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            
            // Connect the player to the sound file
            player.SoundLocation = filename;
            
            // Make the player play the sound file
            player.Play();
        }
    }
}
