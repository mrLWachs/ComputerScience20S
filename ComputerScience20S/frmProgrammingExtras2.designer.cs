namespace ComputerScience20S
{
    partial class frmProgrammingExtras2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picPacman = new System.Windows.Forms.PictureBox();
            this.picWall = new System.Windows.Forms.PictureBox();
            this.picGhost = new System.Windows.Forms.PictureBox();
            this.picDot = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDot)).BeginInit();
            this.SuspendLayout();
            // 
            // picPacman
            // 
            this.picPacman.BackColor = System.Drawing.Color.Yellow;
            this.picPacman.Location = new System.Drawing.Point(494, 80);
            this.picPacman.Name = "picPacman";
            this.picPacman.Size = new System.Drawing.Size(73, 57);
            this.picPacman.TabIndex = 0;
            this.picPacman.TabStop = false;
            // 
            // picWall
            // 
            this.picWall.BackColor = System.Drawing.Color.Navy;
            this.picWall.Location = new System.Drawing.Point(332, 285);
            this.picWall.Name = "picWall";
            this.picWall.Size = new System.Drawing.Size(445, 87);
            this.picWall.TabIndex = 0;
            this.picWall.TabStop = false;
            // 
            // picGhost
            // 
            this.picGhost.BackColor = System.Drawing.Color.Green;
            this.picGhost.Location = new System.Drawing.Point(512, 493);
            this.picGhost.Name = "picGhost";
            this.picGhost.Size = new System.Drawing.Size(84, 78);
            this.picGhost.TabIndex = 0;
            this.picGhost.TabStop = false;
            // 
            // picDot
            // 
            this.picDot.BackColor = System.Drawing.Color.White;
            this.picDot.Location = new System.Drawing.Point(236, 188);
            this.picDot.Name = "picDot";
            this.picDot.Size = new System.Drawing.Size(30, 29);
            this.picDot.TabIndex = 0;
            this.picDot.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmProgrammingExtras2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(972, 675);
            this.Controls.Add(this.picDot);
            this.Controls.Add(this.picGhost);
            this.Controls.Add(this.picWall);
            this.Controls.Add(this.picPacman);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProgrammingExtras2";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picPacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPacman;
        private System.Windows.Forms.PictureBox picWall;
        private System.Windows.Forms.PictureBox picGhost;
        private System.Windows.Forms.PictureBox picDot;
        private System.Windows.Forms.Timer timer1;
    }
}

