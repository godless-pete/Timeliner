﻿namespace Timeliner
{
    partial class TimelinerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timelineControl1 = new Timeliner.Controls.TimelineControl();
            this.SuspendLayout();
            // 
            // timelineControl1
            // 
            this.timelineControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timelineControl1.BackColor = System.Drawing.Color.Honeydew;
            this.timelineControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timelineControl1.Location = new System.Drawing.Point(26, 18);
            this.timelineControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timelineControl1.Name = "timelineControl1";
            this.timelineControl1.Size = new System.Drawing.Size(649, 258);
            this.timelineControl1.TabIndex = 0;
            // 
            // TimelinerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.timelineControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TimelinerForm";
            this.Text = "Timeliner";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.TimelineControl timelineControl1;
    }
}
