namespace ComputerScience20S
{
    partial class frmIntroductionToProgrammingExample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntroductionToProgrammingExample));
            this.lblHello = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.picSweaterVest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSweaterVest)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(215, 61);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(62, 13);
            this.lblHello.TabIndex = 1;
            this.lblHello.Text = "Hello World";
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnChange.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(72, 414);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(394, 85);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change the world";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // picSweaterVest
            // 
            this.picSweaterVest.Image = global::ComputerScience20S.Properties.Resources._1_5Dfdk1Y_lrlzng7pECGglg;
            this.picSweaterVest.Location = new System.Drawing.Point(96, 112);
            this.picSweaterVest.Name = "picSweaterVest";
            this.picSweaterVest.Size = new System.Drawing.Size(337, 270);
            this.picSweaterVest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSweaterVest.TabIndex = 0;
            this.picSweaterVest.TabStop = false;
            this.picSweaterVest.Visible = false;
            // 
            // frmIntroductionToProgrammingExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 529);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.picSweaterVest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIntroductionToProgrammingExample";
            this.Text = "Introduction To Programming Example";
            ((System.ComponentModel.ISupportInitialize)(this.picSweaterVest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSweaterVest;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnChange;
    }
}

