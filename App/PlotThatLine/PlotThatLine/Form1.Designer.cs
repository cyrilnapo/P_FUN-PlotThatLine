﻿namespace PlotThatLine
{
    partial class Form1
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
            viewData = new ScottPlot.FormsPlot();
            SuspendLayout();
            // 
            // viewData
            // 
            viewData.Location = new Point(13, 12);
            viewData.Margin = new Padding(4, 3, 4, 3);
            viewData.Name = "viewData";
            viewData.Size = new Size(1138, 653);
            viewData.TabIndex = 0;
            viewData.Load += viewData_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 20, 28);
            ClientSize = new Size(1164, 677);
            Controls.Add(viewData);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.FormsPlot viewData;
    }
}
