namespace TrafficLights
{
    partial class Form1
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
            this.pictureRed = new System.Windows.Forms.PictureBox();
            this.pictureYellow = new System.Windows.Forms.PictureBox();
            this.pictureGreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureRed
            // 
            this.pictureRed.Location = new System.Drawing.Point(45, 25);
            this.pictureRed.Name = "pictureRed";
            this.pictureRed.Size = new System.Drawing.Size(100, 100);
            this.pictureRed.TabIndex = 0;
            this.pictureRed.TabStop = false;
            // 
            // pictureYellow
            // 
            this.pictureYellow.Location = new System.Drawing.Point(45, 131);
            this.pictureYellow.Name = "pictureYellow";
            this.pictureYellow.Size = new System.Drawing.Size(100, 100);
            this.pictureYellow.TabIndex = 1;
            this.pictureYellow.TabStop = false;
            // 
            // pictureGreen
            // 
            this.pictureGreen.Location = new System.Drawing.Point(45, 237);
            this.pictureGreen.Name = "pictureGreen";
            this.pictureGreen.Size = new System.Drawing.Size(100, 100);
            this.pictureGreen.TabIndex = 2;
            this.pictureGreen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 366);
            this.Controls.Add(this.pictureGreen);
            this.Controls.Add(this.pictureYellow);
            this.Controls.Add(this.pictureRed);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureRed;
        private System.Windows.Forms.PictureBox pictureYellow;
        private System.Windows.Forms.PictureBox pictureGreen;
    }
}

