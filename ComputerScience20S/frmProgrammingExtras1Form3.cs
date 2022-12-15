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
            // This line shuts down all forms
            Application.Exit();
        }

        private void frmProgrammingExtras1Form3_Load(object sender, EventArgs e)
        {
            // Code for when the form first appears...

            // Play a good-bye sound using ONLY code and no media player
            // on the design

            // How do files work? - they have each have 3 "names" ...
                // 1: "first"  name - ex. "C:\Users\" (or path, directory, location)
                // 2: "middle" name - ex. "sound"     (the user usually enters this)
                // 3: "last"   name - ex. ".wav"      (or extension, file type)

            // Create a sound file full name
            string first  = "C:\\Windows\\Media\\";
            string middle = "Windows Exclamation";
            string last   = ".wav";

            // Attach (concatinate) the names together
            string name = first + middle + last;

            // Create a sound player using code
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            // Connect the player to the sound file
            player.SoundLocation = name;

            // Make the player play the sound file
            player.Play();
        }
    }
}
