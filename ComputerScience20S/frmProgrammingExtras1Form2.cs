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
            openFileDialog1.Filter = "Sound Files|*.wav";
            openFileDialog1.ShowDialog();
            axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
            axWindowsMediaPlayer1.uiMode = "full";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.uiMode = "none";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmProgrammingExtras1Form3 form3 = new frmProgrammingExtras1Form3();
            form3.Show();
            this.Close();
        }
        
    }
}
