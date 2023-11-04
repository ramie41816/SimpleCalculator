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
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            mcButton = new Button();
            formulaFlowLayoutPanel = new FlowLayoutPanel();
            textBox1 = new TextBox();
            secondOperandTextBox = new TextBox();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            controlPanel.SuspendLayout();
            formulaFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // appTitleLable
            // 
            appTitleLable.AutoSize = true;
            appTitleLable.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            appTitleLable.Location = new Point(12, 21);
            appTitleLable.Name = "appTitleLable";
            appTitleLable.Size = new Size(187, 23);
            appTitleLable.TabIndex = 1;
            appTitleLable.Text = "BASIC CALCULATOR";
            // 
            // controlPanel
            // 
            controlPanel.Controls.Add(button24);
            controlPanel.Controls.Add(button23);
            controlPanel.Controls.Add(button22);
            controlPanel.Controls.Add(button21);
            controlPanel.Controls.Add(button20);
            controlPanel.Controls.Add(button19);
            controlPanel.Controls.Add(button18);
            controlPanel.Controls.Add(button17);
            controlPanel.Controls.Add(button16);
            controlPanel.Controls.Add(button15);
            controlPanel.Controls.Add(button14);
            controlPanel.Controls.Add(button13);
            controlPanel.Controls.Add(button12);
            controlPanel.Controls.Add(button11);
            controlPanel.Controls.Add(button10);
            controlPanel.Controls.Add(button9);
            controlPanel.Controls.Add(button8);
            controlPanel.Controls.Add(button7);
            controlPanel.Controls.Add(button6);
            controlPanel.Controls.Add(button5);
            controlPanel.Controls.Add(button4);
            controlPanel.Controls.Add(button3);
            controlPanel.Controls.Add(button2);
            controlPanel.Controls.Add(button1);
            controlPanel.Controls.Add(mcButton);
            controlPanel.Location = new Point(12, 143);
            controlPanel.Name = "controlPanel";
            controlPanel.Size = new Size(294, 306);
            controlPanel.TabIndex = 3;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ActiveBorder;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(235, 70);
            button9.Name = "button9";
            button9.Size = new Size(56, 50);
            button9.TabIndex = 18;
            button9.Text = "x²";
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ActiveBorder;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(177, 70);
            button8.Name = "button8";
            button8.Size = new Size(52, 50);
            button8.TabIndex = 17;
            button8.Text = "√";
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveBorder;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(119, 70);
            button7.Name = "button7";
            button7.Size = new Size(52, 50);
            button7.TabIndex = 16;
            button7.Text = "±";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveBorder;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(61, 70);
            button6.Name = "button6";
            button6.Size = new Size(52, 50);
            button6.TabIndex = 15;
            button6.Text = "CE";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveBorder;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(3, 70);
            button5.Name = "button5";
            button5.Size = new Size(52, 50);
            button5.TabIndex = 14;
            button5.Text = "AC";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveBorder;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(227, 3);
            button4.Name = "button4";
            button4.Size = new Size(64, 61);
            button4.TabIndex = 13;
            button4.Text = "⌫";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(171, 3);
            button3.Name = "button3";
            button3.Size = new Size(50, 61);
            button3.TabIndex = 12;
            button3.Text = "MR";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(115, 3);
            button2.Name = "button2";
            button2.Size = new Size(50, 61);
            button2.TabIndex = 11;
            button2.Text = "M+";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(59, 3);
            button1.Name = "button1";
            button1.Size = new Size(50, 61);
            button1.TabIndex = 10;
            button1.Text = "M-";
            button1.UseVisualStyleBackColor = false;
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
            mcButton.Size = new Size(50, 61);
            mcButton.TabIndex = 0;
            mcButton.Text = "MC";
            mcButton.UseVisualStyleBackColor = false;
            // 
            // formulaFlowLayoutPanel
            // 
            formulaFlowLayoutPanel.Controls.Add(textBox1);
            formulaFlowLayoutPanel.Controls.Add(secondOperandTextBox);
            formulaFlowLayoutPanel.Location = new Point(12, 47);
            formulaFlowLayoutPanel.Name = "formulaFlowLayoutPanel";
            formulaFlowLayoutPanel.Size = new Size(294, 90);
            formulaFlowLayoutPanel.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(288, 36);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // secondOperandTextBox
            // 
            secondOperandTextBox.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            secondOperandTextBox.Location = new Point(3, 45);
            secondOperandTextBox.Name = "secondOperandTextBox";
            secondOperandTextBox.ReadOnly = true;
            secondOperandTextBox.Size = new Size(288, 41);
            secondOperandTextBox.TabIndex = 0;
            secondOperandTextBox.TabStop = false;
            secondOperandTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.Control;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Popup;
            button10.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(3, 126);
            button10.Name = "button10";
            button10.Size = new Size(52, 55);
            button10.TabIndex = 19;
            button10.Text = "AC";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.Control;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Popup;
            button11.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(61, 126);
            button11.Name = "button11";
            button11.Size = new Size(52, 55);
            button11.TabIndex = 20;
            button11.Text = "AC";
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.ActiveBorder;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Popup;
            button12.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button12.Location = new Point(119, 126);
            button12.Name = "button12";
            button12.Size = new Size(52, 55);
            button12.TabIndex = 21;
            button12.Text = "AC";
            button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = SystemColors.Control;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Popup;
            button13.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button13.Location = new Point(3, 187);
            button13.Name = "button13";
            button13.Size = new Size(52, 55);
            button13.TabIndex = 22;
            button13.Text = "AC";
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.Control;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Popup;
            button14.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button14.Location = new Point(61, 187);
            button14.Name = "button14";
            button14.Size = new Size(52, 55);
            button14.TabIndex = 23;
            button14.Text = "AC";
            button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.Control;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Popup;
            button15.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button15.Location = new Point(119, 187);
            button15.Name = "button15";
            button15.Size = new Size(52, 55);
            button15.TabIndex = 24;
            button15.Text = "AC";
            button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.Control;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Popup;
            button16.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button16.Location = new Point(3, 246);
            button16.Name = "button16";
            button16.Size = new Size(52, 55);
            button16.TabIndex = 25;
            button16.Text = "AC";
            button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            button17.BackColor = SystemColors.Control;
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatStyle = FlatStyle.Popup;
            button17.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button17.Location = new Point(61, 246);
            button17.Name = "button17";
            button17.Size = new Size(52, 55);
            button17.TabIndex = 26;
            button17.Text = "AC";
            button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            button18.BackColor = SystemColors.Control;
            button18.FlatAppearance.BorderSize = 0;
            button18.FlatStyle = FlatStyle.Popup;
            button18.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button18.Location = new Point(119, 246);
            button18.Name = "button18";
            button18.Size = new Size(52, 55);
            button18.TabIndex = 27;
            button18.Text = "AC";
            button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            button19.BackColor = SystemColors.ActiveBorder;
            button19.FlatAppearance.BorderSize = 0;
            button19.FlatStyle = FlatStyle.Popup;
            button19.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button19.Location = new Point(177, 126);
            button19.Name = "button19";
            button19.Size = new Size(52, 55);
            button19.TabIndex = 28;
            button19.Text = "÷";
            button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            button20.BackColor = SystemColors.ActiveBorder;
            button20.FlatAppearance.BorderSize = 0;
            button20.FlatStyle = FlatStyle.Popup;
            button20.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button20.Location = new Point(235, 126);
            button20.Name = "button20";
            button20.Size = new Size(56, 55);
            button20.TabIndex = 29;
            button20.Text = "%";
            button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            button21.BackColor = Color.DeepSkyBlue;
            button21.FlatAppearance.BorderSize = 0;
            button21.FlatStyle = FlatStyle.Popup;
            button21.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button21.Location = new Point(235, 187);
            button21.Name = "button21";
            button21.Size = new Size(56, 114);
            button21.TabIndex = 30;
            button21.Text = "=";
            button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            button22.BackColor = SystemColors.Control;
            button22.FlatAppearance.BorderSize = 0;
            button22.FlatStyle = FlatStyle.Popup;
            button22.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button22.Location = new Point(119, 126);
            button22.Name = "button22";
            button22.Size = new Size(52, 55);
            button22.TabIndex = 31;
            button22.Text = "AC";
            button22.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            button23.BackColor = SystemColors.ActiveBorder;
            button23.FlatAppearance.BorderSize = 0;
            button23.FlatStyle = FlatStyle.Popup;
            button23.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button23.Location = new Point(177, 187);
            button23.Name = "button23";
            button23.Size = new Size(52, 55);
            button23.TabIndex = 32;
            button23.Text = "−";
            button23.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            button24.BackColor = SystemColors.ActiveBorder;
            button24.FlatAppearance.BorderSize = 0;
            button24.FlatStyle = FlatStyle.Popup;
            button24.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button24.Location = new Point(177, 246);
            button24.Name = "button24";
            button24.Size = new Size(52, 55);
            button24.TabIndex = 33;
            button24.Text = "+";
            button24.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 456);
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
        private TextBox textBox1;
        private TextBox secondOperandTextBox;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button22;
        private Button button21;
        private Button button20;
        private Button button19;
        private Button button18;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button24;
        private Button button23;
    }
}