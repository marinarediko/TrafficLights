﻿namespace TrafficLights
{
    partial class TrafficLights
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
            this.RedLight = new System.Windows.Forms.PictureBox();
            this.YellowLight = new System.Windows.Forms.PictureBox();
            this.GreenLight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RedLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).BeginInit();
            this.SuspendLayout();
            // 
            // RedLight
            // 
            this.RedLight.Location = new System.Drawing.Point(45, 25);
            this.RedLight.Name = "RedLight";
            this.RedLight.Size = new System.Drawing.Size(100, 100);
            this.RedLight.TabIndex = 0;
            this.RedLight.TabStop = false;
            // 
            // YellowLight
            // 
            this.YellowLight.Location = new System.Drawing.Point(45, 131);
            this.YellowLight.Name = "YellowLight";
            this.YellowLight.Size = new System.Drawing.Size(100, 100);
            this.YellowLight.TabIndex = 1;
            this.YellowLight.TabStop = false;
            // 
            // GreenLight
            // 
            this.GreenLight.Location = new System.Drawing.Point(45, 237);
            this.GreenLight.Name = "GreenLight";
            this.GreenLight.Size = new System.Drawing.Size(100, 100);
            this.GreenLight.TabIndex = 2;
            this.GreenLight.TabStop = false;
            // 
            // TrafficLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 366);
            this.Controls.Add(this.GreenLight);
            this.Controls.Add(this.YellowLight);
            this.Controls.Add(this.RedLight);
            this.Name = "TrafficLights";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RedLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RedLight;
        private System.Windows.Forms.PictureBox YellowLight;
        private System.Windows.Forms.PictureBox GreenLight;
    }
}

