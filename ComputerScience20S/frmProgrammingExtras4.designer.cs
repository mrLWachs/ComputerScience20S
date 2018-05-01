namespace ComputerScience20S
{
    partial class frmProgrammingExtras4
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
            this.picEnemy = new System.Windows.Forms.PictureBox();
            this.picBullet = new System.Windows.Forms.PictureBox();
            this.picBase1 = new System.Windows.Forms.PictureBox();
            this.picBase2 = new System.Windows.Forms.PictureBox();
            this.picBase3 = new System.Windows.Forms.PictureBox();
            this.picBase4 = new System.Windows.Forms.PictureBox();
            this.picBase5 = new System.Windows.Forms.PictureBox();
            this.tmrShoot = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemy = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase5)).BeginInit();
            this.SuspendLayout();
            // 
            // picEnemy
            // 
            this.picEnemy.BackColor = System.Drawing.Color.Red;
            this.picEnemy.Location = new System.Drawing.Point(252, 0);
            this.picEnemy.Name = "picEnemy";
            this.picEnemy.Size = new System.Drawing.Size(42, 50);
            this.picEnemy.TabIndex = 0;
            this.picEnemy.TabStop = false;
            // 
            // picBullet
            // 
            this.picBullet.BackColor = System.Drawing.Color.White;
            this.picBullet.Location = new System.Drawing.Point(266, 321);
            this.picBullet.Name = "picBullet";
            this.picBullet.Size = new System.Drawing.Size(15, 18);
            this.picBullet.TabIndex = 1;
            this.picBullet.TabStop = false;
            // 
            // picBase1
            // 
            this.picBase1.BackColor = System.Drawing.Color.Blue;
            this.picBase1.Location = new System.Drawing.Point(17, 346);
            this.picBase1.Name = "picBase1";
            this.picBase1.Size = new System.Drawing.Size(88, 92);
            this.picBase1.TabIndex = 2;
            this.picBase1.TabStop = false;
            // 
            // picBase2
            // 
            this.picBase2.BackColor = System.Drawing.Color.Blue;
            this.picBase2.Location = new System.Drawing.Point(124, 346);
            this.picBase2.Name = "picBase2";
            this.picBase2.Size = new System.Drawing.Size(88, 92);
            this.picBase2.TabIndex = 3;
            this.picBase2.TabStop = false;
            // 
            // picBase3
            // 
            this.picBase3.BackColor = System.Drawing.Color.Yellow;
            this.picBase3.Location = new System.Drawing.Point(231, 346);
            this.picBase3.Name = "picBase3";
            this.picBase3.Size = new System.Drawing.Size(88, 92);
            this.picBase3.TabIndex = 4;
            this.picBase3.TabStop = false;
            // 
            // picBase4
            // 
            this.picBase4.BackColor = System.Drawing.Color.Blue;
            this.picBase4.Location = new System.Drawing.Point(338, 346);
            this.picBase4.Name = "picBase4";
            this.picBase4.Size = new System.Drawing.Size(88, 92);
            this.picBase4.TabIndex = 5;
            this.picBase4.TabStop = false;
            // 
            // picBase5
            // 
            this.picBase5.BackColor = System.Drawing.Color.Blue;
            this.picBase5.Location = new System.Drawing.Point(445, 346);
            this.picBase5.Name = "picBase5";
            this.picBase5.Size = new System.Drawing.Size(88, 92);
            this.picBase5.TabIndex = 6;
            this.picBase5.TabStop = false;
            // 
            // tmrShoot
            // 
            this.tmrShoot.Interval = 1;
            this.tmrShoot.Tick += new System.EventHandler(this.tmrShoot_Tick);
            // 
            // tmrEnemy
            // 
            this.tmrEnemy.Enabled = true;
            this.tmrEnemy.Interval = 1;
            this.tmrEnemy.Tick += new System.EventHandler(this.tmrEnemy_Tick);
            // 
            // frmProgrammingExtras4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(547, 437);
            this.Controls.Add(this.picBase5);
            this.Controls.Add(this.picBase4);
            this.Controls.Add(this.picBase3);
            this.Controls.Add(this.picBase2);
            this.Controls.Add(this.picBase1);
            this.Controls.Add(this.picBullet);
            this.Controls.Add(this.picEnemy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProgrammingExtras4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missle Command";
            this.Load += new System.EventHandler(this.frmProgrammingExtras4_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmProgrammingExtras4_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.picEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picEnemy;
        private System.Windows.Forms.PictureBox picBullet;
        private System.Windows.Forms.PictureBox picBase1;
        private System.Windows.Forms.PictureBox picBase2;
        private System.Windows.Forms.PictureBox picBase3;
        private System.Windows.Forms.PictureBox picBase4;
        private System.Windows.Forms.PictureBox picBase5;
        private System.Windows.Forms.Timer tmrShoot;
        private System.Windows.Forms.Timer tmrEnemy;
    }
}

