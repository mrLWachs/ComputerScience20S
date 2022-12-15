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
            // Code when the form first appears...

            // How do files work? - they have each have 3 "names" ...
                // 1 - "first"  name (for example "C:\Users\lawrence.wachs\Desktop") - or path, location
                // 2 - "middle" name (for example "sound")
                // 3 - "last"   name (for example ".wav") - or extension
            
            // Play a sound using only code (no media player on the design)

            // Create a sound file full name
            string first  = "C:\\Windows\\Media\\";
            string middle = "Windows Exclamation";
            string last   = ".wav";

            // Attach (concatinate) them together
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
