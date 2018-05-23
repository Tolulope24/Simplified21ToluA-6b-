namespace Simplified21ToluA_6b_
{
    partial class frmSimplified21
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
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(9, 148);
            this.btnHit.Margin = new System.Windows.Forms.Padding(2);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(56, 19);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            // 
            // btnStay
            // 
            this.btnStay.Location = new System.Drawing.Point(9, 180);
            this.btnStay.Margin = new System.Windows.Forms.Padding(2);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(56, 22);
            this.btnStay.TabIndex = 1;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(435, 337);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(56, 19);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(435, 10);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(56, 19);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmSimplified21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(500, 366);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSimplified21";
            this.Text = "Simplified 21";
            this.Load += new System.EventHandler(this.frmSimplified21_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnStart;
    }
}

