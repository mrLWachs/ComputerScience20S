namespace ComputerScience20S
{
    partial class frmConditionalStatementsExample1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.chkSeeSum = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(612, 62);
            this.txtInput.TabIndex = 0;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(12, 98);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(612, 84);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "ENTER VALUES";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.Location = new System.Drawing.Point(12, 203);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(612, 84);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "COUNT VALUES";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(12, 299);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(612, 161);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Answer here...";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkSeeSum
            // 
            this.chkSeeSum.AutoSize = true;
            this.chkSeeSum.Checked = true;
            this.chkSeeSum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSeeSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSeeSum.Location = new System.Drawing.Point(22, 489);
            this.chkSeeSum.Name = "chkSeeSum";
            this.chkSeeSum.Size = new System.Drawing.Size(259, 59);
            this.chkSeeSum.TabIndex = 4;
            this.chkSeeSum.Text = "SEE SUM";
            this.chkSeeSum.UseVisualStyleBackColor = true;
            this.chkSeeSum.CheckedChanged += new System.EventHandler(this.chkSeeSum_CheckedChanged);
            // 
            // frmConditionalStatementsExample1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 575);
            this.Controls.Add(this.chkSeeSum);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConditionalStatementsExample1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EXAMPLE 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.CheckBox chkSeeSum;
    }
}

