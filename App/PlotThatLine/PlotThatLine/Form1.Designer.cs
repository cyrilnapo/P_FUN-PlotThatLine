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
            btcCheck = new CheckBox();
            xrpCheck = new CheckBox();
            solCheck = new CheckBox();
            bnbCheck = new CheckBox();
            avaxCheck = new CheckBox();
            clearBtn = new Button();
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
            ethCheck.Checked = true;
            ethCheck.CheckState = CheckState.Checked;
            ethCheck.Cursor = Cursors.Hand;
            ethCheck.ForeColor = Color.White;
            ethCheck.Location = new Point(88, 30);
            ethCheck.Name = "ethCheck";
            ethCheck.Size = new Size(77, 19);
            ethCheck.TabIndex = 1;
            ethCheck.Text = "Ethereum";
            ethCheck.UseVisualStyleBackColor = true;
            // 
            // btcCheck
            // 
            btcCheck.AutoSize = true;
            btcCheck.BackColor = Color.Transparent;
            btcCheck.Checked = true;
            btcCheck.CheckState = CheckState.Checked;
            btcCheck.Cursor = Cursors.Hand;
            btcCheck.ForeColor = Color.White;
            btcCheck.Location = new Point(88, 55);
            btcCheck.Name = "btcCheck";
            btcCheck.Size = new Size(63, 19);
            btcCheck.TabIndex = 2;
            btcCheck.Text = "Bitcoin";
            btcCheck.UseVisualStyleBackColor = false;
            // 
            // xrpCheck
            // 
            xrpCheck.AutoSize = true;
            xrpCheck.BackColor = Color.Transparent;
            xrpCheck.Checked = true;
            xrpCheck.CheckState = CheckState.Checked;
            xrpCheck.Cursor = Cursors.Hand;
            xrpCheck.ForeColor = Color.White;
            xrpCheck.Location = new Point(88, 80);
            xrpCheck.Name = "xrpCheck";
            xrpCheck.Size = new Size(47, 19);
            xrpCheck.TabIndex = 3;
            xrpCheck.Text = "XRP";
            xrpCheck.UseVisualStyleBackColor = false;
            // 
            // solCheck
            // 
            solCheck.AutoSize = true;
            solCheck.BackColor = Color.Transparent;
            solCheck.Checked = true;
            solCheck.CheckState = CheckState.Checked;
            solCheck.Cursor = Cursors.Hand;
            solCheck.ForeColor = Color.White;
            solCheck.Location = new Point(171, 30);
            solCheck.Name = "solCheck";
            solCheck.Size = new Size(61, 19);
            solCheck.TabIndex = 4;
            solCheck.Text = "Solana";
            solCheck.UseVisualStyleBackColor = false;
            // 
            // bnbCheck
            // 
            bnbCheck.AutoSize = true;
            bnbCheck.BackColor = Color.Transparent;
            bnbCheck.Checked = true;
            bnbCheck.CheckState = CheckState.Checked;
            bnbCheck.Cursor = Cursors.Hand;
            bnbCheck.ForeColor = Color.White;
            bnbCheck.Location = new Point(171, 55);
            bnbCheck.Name = "bnbCheck";
            bnbCheck.Size = new Size(49, 19);
            bnbCheck.TabIndex = 5;
            bnbCheck.Text = "BNB";
            bnbCheck.UseVisualStyleBackColor = false;
            // 
            // avaxCheck
            // 
            avaxCheck.AutoSize = true;
            avaxCheck.BackColor = Color.Transparent;
            avaxCheck.Checked = true;
            avaxCheck.CheckState = CheckState.Checked;
            avaxCheck.Cursor = Cursors.Hand;
            avaxCheck.ForeColor = Color.White;
            avaxCheck.Location = new Point(171, 80);
            avaxCheck.Name = "avaxCheck";
            avaxCheck.Size = new Size(81, 19);
            avaxCheck.TabIndex = 6;
            avaxCheck.Text = "Avalanche";
            avaxCheck.UseVisualStyleBackColor = false;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Segoe UI", 7F);
            clearBtn.Location = new Point(41, 47);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(34, 30);
            clearBtn.TabIndex = 7;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 20, 28);
            ClientSize = new Size(787, 535);
            Controls.Add(clearBtn);
            Controls.Add(avaxCheck);
            Controls.Add(bnbCheck);
            Controls.Add(solCheck);
            Controls.Add(xrpCheck);
            Controls.Add(btcCheck);
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
        private CheckBox btcCheck;
        private CheckBox xrpCheck;
        private CheckBox solCheck;
        private CheckBox bnbCheck;
        private CheckBox avaxCheck;
        private Button clearBtn;
    }
}
