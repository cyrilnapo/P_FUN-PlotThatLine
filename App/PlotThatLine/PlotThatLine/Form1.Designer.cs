namespace PlotThatLine
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
            ethCheck = new CheckBox();
            btcChek = new CheckBox();
            SuspendLayout();
            // 
            // viewData
            // 
            viewData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            viewData.AutoSize = true;
            viewData.Location = new Point(40, 100);
            viewData.Margin = new Padding(4, 3, 4, 3);
            viewData.Name = "viewData";
            viewData.Size = new Size(705, 423);
            viewData.TabIndex = 0;
            // 
            // ethCheck
            // 
            ethCheck.AutoSize = true;
            ethCheck.ForeColor = Color.White;
            ethCheck.Location = new Point(120, 38);
            ethCheck.Name = "ethCheck";
            ethCheck.Size = new Size(77, 19);
            ethCheck.TabIndex = 1;
            ethCheck.Text = "Ethereum";
            ethCheck.UseVisualStyleBackColor = true;
            // 
            // btcChek
            // 
            btcChek.AutoSize = true;
            btcChek.BackColor = Color.Transparent;
            btcChek.ForeColor = Color.White;
            btcChek.Location = new Point(120, 63);
            btcChek.Name = "btcChek";
            btcChek.Size = new Size(63, 19);
            btcChek.TabIndex = 2;
            btcChek.Text = "Bitcoin";
            btcChek.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 20, 28);
            ClientSize = new Size(787, 535);
            Controls.Add(btcChek);
            Controls.Add(ethCheck);
            Controls.Add(viewData);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.FormsPlot viewData;
        private CheckBox ethCheck;
        private CheckBox btcChek;
    }
}
