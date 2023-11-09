using System.Drawing.Design;

namespace SimpleCalculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            appTitleLable = new Label();
            controlPanel = new Panel();
            percentageButton = new Button();
            oneOverXButton = new Button();
            decimalButton = new Button();
            zeroButton = new Button();
            additionButton = new Button();
            differenceButton = new Button();
            nineButton = new Button();
            equalsButton = new Button();
            multiplicationButton = new Button();
            divisionButton = new Button();
            threeButton = new Button();
            twoButton = new Button();
            oneButton = new Button();
            sixButton = new Button();
            fiveButton = new Button();
            fourButton = new Button();
            eightButton = new Button();
            sevenButton = new Button();
            squaredButton = new Button();
            squareRootButton = new Button();
            positveNegativeButton = new Button();
            ceButton = new Button();
            acButton = new Button();
            backSpaceButton = new Button();
            mrButton = new Button();
            mPositiveButton = new Button();
            mNegativeButton = new Button();
            mcButton = new Button();
            formulaFlowLayoutPanel = new FlowLayoutPanel();
            currentOperandTextBox = new TextBox();
            secondOperandTextBox = new TextBox();
            controlPanel.SuspendLayout();
            formulaFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // appTitleLable
            // 
            appTitleLable.AutoSize = true;
            appTitleLable.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            appTitleLable.Location = new Point(12, 9);
            appTitleLable.Name = "appTitleLable";
            appTitleLable.Size = new Size(187, 23);
            appTitleLable.TabIndex = 1;
            appTitleLable.Text = "BASIC CALCULATOR";
            // 
            // controlPanel
            // 
            controlPanel.Controls.Add(percentageButton);
            controlPanel.Controls.Add(oneOverXButton);
            controlPanel.Controls.Add(decimalButton);
            controlPanel.Controls.Add(zeroButton);
            controlPanel.Controls.Add(additionButton);
            controlPanel.Controls.Add(differenceButton);
            controlPanel.Controls.Add(nineButton);
            controlPanel.Controls.Add(equalsButton);
            controlPanel.Controls.Add(multiplicationButton);
            controlPanel.Controls.Add(divisionButton);
            controlPanel.Controls.Add(threeButton);
            controlPanel.Controls.Add(twoButton);
            controlPanel.Controls.Add(oneButton);
            controlPanel.Controls.Add(sixButton);
            controlPanel.Controls.Add(fiveButton);
            controlPanel.Controls.Add(fourButton);
            controlPanel.Controls.Add(eightButton);
            controlPanel.Controls.Add(sevenButton);
            controlPanel.Controls.Add(squaredButton);
            controlPanel.Controls.Add(squareRootButton);
            controlPanel.Controls.Add(positveNegativeButton);
            controlPanel.Controls.Add(ceButton);
            controlPanel.Controls.Add(acButton);
            controlPanel.Controls.Add(backSpaceButton);
            controlPanel.Controls.Add(mrButton);
            controlPanel.Controls.Add(mPositiveButton);
            controlPanel.Controls.Add(mNegativeButton);
            controlPanel.Controls.Add(mcButton);
            controlPanel.Location = new Point(12, 131);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(294, 355);
            controlPanel.TabIndex = 3;
            // 
            // percentageButton
            // 
            percentageButton.BackColor = SystemColors.ActiveBorder;
            percentageButton.FlatAppearance.BorderSize = 0;
            percentageButton.FlatStyle = FlatStyle.Popup;
            percentageButton.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            percentageButton.Location = new Point(235, 117);
            percentageButton.Name = "percentageButton";
            percentageButton.Size = new Size(56, 55);
            percentageButton.TabIndex = 37;
            percentageButton.Text = "%";
            percentageButton.UseVisualStyleBackColor = false;
            percentageButton.Click += percentageButton_Click;
            // 
            // oneOverXButton
            // 
            oneOverXButton.BackColor = SystemColors.ActiveBorder;
            oneOverXButton.FlatAppearance.BorderSize = 0;
            oneOverXButton.FlatStyle = FlatStyle.Popup;
            oneOverXButton.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            oneOverXButton.Location = new Point(177, 117);
            oneOverXButton.Name = "oneOverXButton";
            oneOverXButton.Size = new Size(52, 55);
            oneOverXButton.TabIndex = 36;
            oneOverXButton.Text = "1/x";
            oneOverXButton.UseVisualStyleBackColor = false;
            oneOverXButton.Click += oneOverXButton_Click;
            // 
            // decimalButton
            // 
            decimalButton.BackColor = SystemColors.Control;
            decimalButton.FlatAppearance.BorderSize = 0;
            decimalButton.FlatStyle = FlatStyle.Popup;
            decimalButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            decimalButton.Location = new Point(119, 300);
            decimalButton.Name = "decimalButton";
            decimalButton.Size = new Size(52, 52);
            decimalButton.TabIndex = 35;
            decimalButton.Text = ".";
            decimalButton.UseVisualStyleBackColor = false;
            decimalButton.Click += decimalButton_Click;
            // 
            // zeroButton
            // 
            zeroButton.BackColor = SystemColors.Control;
            zeroButton.FlatAppearance.BorderSize = 0;
            zeroButton.FlatStyle = FlatStyle.Popup;
            zeroButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            zeroButton.Location = new Point(3, 300);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(110, 52);
            zeroButton.TabIndex = 34;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = false;
            zeroButton.Click += zeroButton_Click;
            // 
            // additionButton
            // 
            additionButton.BackColor = SystemColors.ActiveBorder;
            additionButton.FlatAppearance.BorderSize = 0;
            additionButton.FlatStyle = FlatStyle.Popup;
            additionButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            additionButton.Location = new Point(235, 239);
            additionButton.Name = "additionButton";
            additionButton.Size = new Size(56, 55);
            additionButton.TabIndex = 33;
            additionButton.Text = "+";
            additionButton.UseVisualStyleBackColor = false;
            additionButton.Click += additionButton_Click;
            // 
            // differenceButton
            // 
            differenceButton.BackColor = SystemColors.ActiveBorder;
            differenceButton.FlatAppearance.BorderSize = 0;
            differenceButton.FlatStyle = FlatStyle.Popup;
            differenceButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            differenceButton.Location = new Point(177, 239);
            differenceButton.Name = "differenceButton";
            differenceButton.Size = new Size(52, 55);
            differenceButton.TabIndex = 32;
            differenceButton.Text = "−";
            differenceButton.UseVisualStyleBackColor = false;
            differenceButton.Click += differenceButton_Click;
            // 
            // nineButton
            // 
            nineButton.BackColor = SystemColors.Control;
            nineButton.FlatAppearance.BorderSize = 0;
            nineButton.FlatStyle = FlatStyle.Popup;
            nineButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            nineButton.Location = new Point(119, 117);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(52, 55);
            nineButton.TabIndex = 31;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = false;
            nineButton.Click += nineButton_Click;
            // 
            // equalsButton
            // 
            equalsButton.BackColor = Color.DeepSkyBlue;
            equalsButton.FlatAppearance.BorderSize = 0;
            equalsButton.FlatStyle = FlatStyle.Popup;
            equalsButton.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            equalsButton.Location = new Point(177, 300);
            equalsButton.Name = "equalsButton";
            equalsButton.Size = new Size(114, 52);
            equalsButton.TabIndex = 30;
            equalsButton.Text = "=";
            equalsButton.UseVisualStyleBackColor = false;
            equalsButton.Click += equalsButton_Click;
            // 
            // multiplicationButton
            // 
            multiplicationButton.BackColor = SystemColors.ActiveBorder;
            multiplicationButton.FlatAppearance.BorderSize = 0;
            multiplicationButton.FlatStyle = FlatStyle.Popup;
            multiplicationButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            multiplicationButton.Location = new Point(235, 178);
            multiplicationButton.Name = "multiplicationButton";
            multiplicationButton.Size = new Size(56, 55);
            multiplicationButton.TabIndex = 29;
            multiplicationButton.Text = "x";
            multiplicationButton.UseVisualStyleBackColor = false;
            multiplicationButton.Click += multiplicationButton_Click;
            // 
            // divisionButton
            // 
            divisionButton.BackColor = SystemColors.ActiveBorder;
            divisionButton.FlatAppearance.BorderSize = 0;
            divisionButton.FlatStyle = FlatStyle.Popup;
            divisionButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            divisionButton.Location = new Point(177, 178);
            divisionButton.Name = "divisionButton";
            divisionButton.Size = new Size(52, 55);
            divisionButton.TabIndex = 28;
            divisionButton.Text = "÷";
            divisionButton.UseVisualStyleBackColor = false;
            divisionButton.Click += divisionButton_Click;
            // 
            // threeButton
            // 
            threeButton.BackColor = SystemColors.Control;
            threeButton.FlatAppearance.BorderSize = 0;
            threeButton.FlatStyle = FlatStyle.Popup;
            threeButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            threeButton.Location = new Point(119, 239);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(52, 55);
            threeButton.TabIndex = 27;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = false;
            threeButton.Click += threeButton_Click;
            // 
            // twoButton
            // 
            twoButton.BackColor = SystemColors.Control;
            twoButton.FlatAppearance.BorderSize = 0;
            twoButton.FlatStyle = FlatStyle.Popup;
            twoButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            twoButton.Location = new Point(61, 239);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(52, 55);
            twoButton.TabIndex = 26;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = false;
            twoButton.Click += twoButton_Click;
            // 
            // oneButton
            // 
            oneButton.BackColor = SystemColors.Control;
            oneButton.FlatAppearance.BorderSize = 0;
            oneButton.FlatStyle = FlatStyle.Popup;
            oneButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            oneButton.Location = new Point(3, 239);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(52, 55);
            oneButton.TabIndex = 25;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = false;
            oneButton.Click += oneButton_Click;
            // 
            // sixButton
            // 
            sixButton.BackColor = SystemColors.Control;
            sixButton.FlatAppearance.BorderSize = 0;
            sixButton.FlatStyle = FlatStyle.Popup;
            sixButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            sixButton.Location = new Point(119, 178);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(52, 55);
            sixButton.TabIndex = 24;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = false;
            sixButton.Click += sixButton_Click;
            // 
            // fiveButton
            // 
            fiveButton.BackColor = SystemColors.Control;
            fiveButton.FlatAppearance.BorderSize = 0;
            fiveButton.FlatStyle = FlatStyle.Popup;
            fiveButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            fiveButton.Location = new Point(61, 178);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(52, 55);
            fiveButton.TabIndex = 23;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = false;
            fiveButton.Click += fiveButton_Click;
            // 
            // fourButton
            // 
            fourButton.BackColor = SystemColors.Control;
            fourButton.FlatAppearance.BorderSize = 0;
            fourButton.FlatStyle = FlatStyle.Popup;
            fourButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            fourButton.Location = new Point(3, 178);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(52, 55);
            fourButton.TabIndex = 22;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = false;
            fourButton.Click += fourButton_Click;
            // 
            // eightButton
            // 
            eightButton.BackColor = SystemColors.Control;
            eightButton.FlatAppearance.BorderSize = 0;
            eightButton.FlatStyle = FlatStyle.Popup;
            eightButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            eightButton.Location = new Point(61, 117);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(52, 55);
            eightButton.TabIndex = 20;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = false;
            eightButton.Click += eightButton_Click;
            // 
            // sevenButton
            // 
            sevenButton.BackColor = SystemColors.Control;
            sevenButton.FlatAppearance.BorderSize = 0;
            sevenButton.FlatStyle = FlatStyle.Popup;
            sevenButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            sevenButton.Location = new Point(3, 117);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(52, 55);
            sevenButton.TabIndex = 19;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = false;
            sevenButton.Click += sevenButton_Click;
            // 
            // squaredButton
            // 
            squaredButton.BackColor = SystemColors.ActiveBorder;
            squaredButton.FlatAppearance.BorderSize = 0;
            squaredButton.FlatStyle = FlatStyle.Popup;
            squaredButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            squaredButton.Location = new Point(235, 61);
            squaredButton.Name = "squaredButton";
            squaredButton.Size = new Size(56, 50);
            squaredButton.TabIndex = 18;
            squaredButton.Text = "x²";
            squaredButton.UseVisualStyleBackColor = false;
            squaredButton.Click += squaredButton_Click;
            // 
            // squareRootButton
            // 
            squareRootButton.BackColor = SystemColors.ActiveBorder;
            squareRootButton.FlatAppearance.BorderSize = 0;
            squareRootButton.FlatStyle = FlatStyle.Popup;
            squareRootButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            squareRootButton.Location = new Point(177, 61);
            squareRootButton.Name = "squareRootButton";
            squareRootButton.Size = new Size(52, 50);
            squareRootButton.TabIndex = 17;
            squareRootButton.Text = "√";
            squareRootButton.UseVisualStyleBackColor = false;
            squareRootButton.Click += squareRootButton_Click;
            // 
            // positveNegativeButton
            // 
            positveNegativeButton.BackColor = SystemColors.ActiveBorder;
            positveNegativeButton.FlatAppearance.BorderSize = 0;
            positveNegativeButton.FlatStyle = FlatStyle.Popup;
            positveNegativeButton.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point);
            positveNegativeButton.Location = new Point(119, 61);
            positveNegativeButton.Name = "positveNegativeButton";
            positveNegativeButton.Size = new Size(52, 50);
            positveNegativeButton.TabIndex = 16;
            positveNegativeButton.Text = "±";
            positveNegativeButton.UseVisualStyleBackColor = false;
            positveNegativeButton.Click += positveNegativeButton_Click;
            // 
            // ceButton
            // 
            ceButton.BackColor = SystemColors.ActiveBorder;
            ceButton.FlatAppearance.BorderSize = 0;
            ceButton.FlatStyle = FlatStyle.Popup;
            ceButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ceButton.Location = new Point(61, 61);
            ceButton.Name = "ceButton";
            ceButton.Size = new Size(52, 50);
            ceButton.TabIndex = 15;
            ceButton.Text = "CE";
            ceButton.UseVisualStyleBackColor = false;
            ceButton.Click += ceButton_Click;
            // 
            // acButton
            // 
            acButton.BackColor = SystemColors.ActiveBorder;
            acButton.FlatAppearance.BorderSize = 0;
            acButton.FlatStyle = FlatStyle.Popup;
            acButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            acButton.Location = new Point(3, 61);
            acButton.Name = "acButton";
            acButton.Size = new Size(52, 50);
            acButton.TabIndex = 14;
            acButton.Text = "AC";
            acButton.UseVisualStyleBackColor = false;
            acButton.Click += acButton_Click;
            // 
            // backSpaceButton
            // 
            backSpaceButton.BackColor = SystemColors.ActiveBorder;
            backSpaceButton.BackgroundImageLayout = ImageLayout.Stretch;
            backSpaceButton.FlatAppearance.BorderSize = 0;
            backSpaceButton.FlatStyle = FlatStyle.Popup;
            backSpaceButton.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point);
            backSpaceButton.ForeColor = Color.Black;
            backSpaceButton.Location = new Point(227, 3);
            backSpaceButton.Name = "backSpaceButton";
            backSpaceButton.Size = new Size(64, 52);
            backSpaceButton.TabIndex = 13;
            backSpaceButton.Text = "⌫";
            backSpaceButton.UseVisualStyleBackColor = false;
            backSpaceButton.Click += backSpaceButton_Click;
            // 
            // mrButton
            // 
            mrButton.BackColor = Color.Red;
            mrButton.FlatAppearance.BorderSize = 0;
            mrButton.FlatStyle = FlatStyle.Popup;
            mrButton.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            mrButton.ForeColor = Color.White;
            mrButton.Location = new Point(171, 3);
            mrButton.Name = "mrButton";
            mrButton.Size = new Size(50, 52);
            mrButton.TabIndex = 12;
            mrButton.Text = "MR";
            mrButton.UseVisualStyleBackColor = false;
            mrButton.Click += mrButton_Click;
            // 
            // mPositiveButton
            // 
            mPositiveButton.BackColor = Color.Red;
            mPositiveButton.FlatAppearance.BorderSize = 0;
            mPositiveButton.FlatStyle = FlatStyle.Popup;
            mPositiveButton.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            mPositiveButton.ForeColor = Color.White;
            mPositiveButton.Location = new Point(115, 3);
            mPositiveButton.Name = "mPositiveButton";
            mPositiveButton.Size = new Size(50, 52);
            mPositiveButton.TabIndex = 11;
            mPositiveButton.Text = "M+";
            mPositiveButton.UseVisualStyleBackColor = false;
            mPositiveButton.Click += mPositiveButton_Click;
            // 
            // mNegativeButton
            // 
            mNegativeButton.BackColor = Color.Red;
            mNegativeButton.FlatAppearance.BorderSize = 0;
            mNegativeButton.FlatStyle = FlatStyle.Popup;
            mNegativeButton.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            mNegativeButton.ForeColor = Color.White;
            mNegativeButton.Location = new Point(59, 3);
            mNegativeButton.Name = "mNegativeButton";
            mNegativeButton.Size = new Size(50, 52);
            mNegativeButton.TabIndex = 10;
            mNegativeButton.Text = "M-";
            mNegativeButton.UseVisualStyleBackColor = false;
            mNegativeButton.Click += mNegativeButton_Click;
            // 
            // mcButton
            // 
            mcButton.BackColor = Color.Red;
            mcButton.FlatAppearance.BorderSize = 0;
            mcButton.FlatStyle = FlatStyle.Popup;
            mcButton.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            mcButton.ForeColor = Color.White;
            mcButton.Location = new Point(3, 3);
            mcButton.Name = "mcButton";
            mcButton.Size = new Size(50, 52);
            mcButton.TabIndex = 0;
            mcButton.Text = "MC";
            mcButton.UseVisualStyleBackColor = false;
            mcButton.Click += mcButton_Click;
            // 
            // formulaFlowLayoutPanel
            // 
            formulaFlowLayoutPanel.Controls.Add(currentOperandTextBox);
            formulaFlowLayoutPanel.Controls.Add(secondOperandTextBox);
            formulaFlowLayoutPanel.FlowDirection = FlowDirection.BottomUp;
            formulaFlowLayoutPanel.Location = new Point(15, 35);
            formulaFlowLayoutPanel.Name = "formulaFlowLayoutPanel";
            formulaFlowLayoutPanel.Size = new Size(288, 90);
            formulaFlowLayoutPanel.TabIndex = 0;
            // 
            // currentOperandTextBox
            // 
            currentOperandTextBox.BorderStyle = BorderStyle.None;
            currentOperandTextBox.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            currentOperandTextBox.Location = new Point(3, 43);
            currentOperandTextBox.MaxLength = 14;
            currentOperandTextBox.Name = "currentOperandTextBox";
            currentOperandTextBox.ReadOnly = true;
            currentOperandTextBox.Size = new Size(283, 44);
            currentOperandTextBox.TabIndex = 0;
            currentOperandTextBox.TabStop = false;
            currentOperandTextBox.Text = "0";
            currentOperandTextBox.TextAlign = HorizontalAlignment.Right;
            currentOperandTextBox.TextChanged += currentOperandTextBox_TextChanged;
            // 
            // secondOperandTextBox
            // 
            secondOperandTextBox.BorderStyle = BorderStyle.None;
            secondOperandTextBox.Enabled = false;
            secondOperandTextBox.Font = new Font("Consolas", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            secondOperandTextBox.Location = new Point(3, 3);
            secondOperandTextBox.MaxLength = 14;
            secondOperandTextBox.Name = "secondOperandTextBox";
            secondOperandTextBox.ReadOnly = true;
            secondOperandTextBox.Size = new Size(283, 34);
            secondOperandTextBox.TabIndex = 1;
            secondOperandTextBox.TabStop = false;
            secondOperandTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 498);
            Controls.Add(controlPanel);
            Controls.Add(formulaFlowLayoutPanel);
            Controls.Add(appTitleLable);
            Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            controlPanel.ResumeLayout(false);
            formulaFlowLayoutPanel.ResumeLayout(false);
            formulaFlowLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label appTitleLable;
        private Panel controlPanel;
        private Button mcButton;
        private FlowLayoutPanel formulaFlowLayoutPanel;
        private TextBox secondOperandTextBox;
        private Button backSpaceButton;
        private Button mrButton;
        private Button mPositiveButton;
        private Button mNegativeButton;
        private Button squaredButton;
        private Button squareRootButton;
        private Button positveNegativeButton;
        private Button ceButton;
        private Button acButton;
        private Button nineButton;
        private Button equalsButton;
        private Button multiplicationButton;
        private Button divisionButton;
        private Button threeButton;
        private Button twoButton;
        private Button oneButton;
        private Button sixButton;
        private Button fiveButton;
        private Button fourButton;
        private Button eightButton;
        private Button sevenButton;
        private Button additionButton;
        private Button differenceButton;
        private Button decimalButton;
        private Button zeroButton;
        private Button percentageButton;
        private Button oneOverXButton;
        private TextBox currentOperandTextBox;
    }
}