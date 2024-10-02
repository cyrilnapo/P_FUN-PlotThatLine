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
            dateFromPicker = new DateTimePicker();
            dateToPicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            displayDatesBtn = new Button();
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
            ethCheck.Location = new Point(169, 30);
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
            btcCheck.Location = new Point(169, 55);
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
            xrpCheck.Location = new Point(169, 80);
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
            solCheck.Location = new Point(252, 30);
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
            bnbCheck.Location = new Point(252, 55);
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
            avaxCheck.Location = new Point(252, 80);
            avaxCheck.Name = "avaxCheck";
            avaxCheck.Size = new Size(81, 19);
            avaxCheck.TabIndex = 6;
            avaxCheck.Text = "Avalanche";
            avaxCheck.UseVisualStyleBackColor = false;
            // 
            // clearBtn
            // 
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.Font = new Font("Segoe UI", 7F);
            clearBtn.Location = new Point(117, 30);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(39, 65);
            clearBtn.TabIndex = 7;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // dateFromPicker
            // 
            dateFromPicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dateFromPicker.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateFromPicker.Cursor = Cursors.Hand;
            dateFromPicker.Font = new Font("Segoe UI", 14F);
            dateFromPicker.Format = DateTimePickerFormat.Short;
            dateFromPicker.Location = new Point(576, 30);
            dateFromPicker.Name = "dateFromPicker";
            dateFromPicker.RightToLeft = RightToLeft.No;
            dateFromPicker.Size = new Size(109, 32);
            dateFromPicker.TabIndex = 8;
            // 
            // dateToPicker
            // 
            dateToPicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dateToPicker.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Bold);
            dateToPicker.Cursor = Cursors.Hand;
            dateToPicker.Font = new Font("Segoe UI", 14F);
            dateToPicker.Format = DateTimePickerFormat.Short;
            dateToPicker.Location = new Point(576, 68);
            dateToPicker.Name = "dateToPicker";
            dateToPicker.RightToLeft = RightToLeft.No;
            dateToPicker.Size = new Size(109, 32);
            dateToPicker.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(509, 33);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 10;
            label1.Text = "From :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(533, 70);
            label2.Name = "label2";
            label2.Size = new Size(40, 25);
            label2.TabIndex = 11;
            label2.Text = "To :";
            // 
            // displayDatesBtn
            // 
            displayDatesBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            displayDatesBtn.Cursor = Cursors.Hand;
            displayDatesBtn.Font = new Font("Segoe UI", 7F);
            displayDatesBtn.Location = new Point(691, 51);
            displayDatesBtn.MaximumSize = new Size(44, 30);
            displayDatesBtn.MinimumSize = new Size(44, 30);
            displayDatesBtn.Name = "displayDatesBtn";
            displayDatesBtn.Size = new Size(44, 30);
            displayDatesBtn.TabIndex = 12;
            displayDatesBtn.Text = "Display";
            displayDatesBtn.UseVisualStyleBackColor = true;
            displayDatesBtn.Click += displayDatesBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 20, 28);
            ClientSize = new Size(787, 535);
            Controls.Add(displayDatesBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateToPicker);
            Controls.Add(dateFromPicker);
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
        private DateTimePicker dateFromPicker;
        private DateTimePicker dateToPicker;
        private Label label1;
        private Label label2;
        private Button displayDatesBtn;
    }
}
