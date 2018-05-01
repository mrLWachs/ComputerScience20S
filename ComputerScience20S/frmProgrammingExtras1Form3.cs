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
            string filename = "C:\\Windows\\WinSxS\\amd64_microsoft-windows-shell-sounds" + "" +
                "_31bf3856ad364e35_10.0.16299.15_none_39fea82526ae0a51\\Windows Logoff Sound.wav";
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = filename;
            player.Play();
        }
    }
}
