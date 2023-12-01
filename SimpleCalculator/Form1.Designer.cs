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
            percentageButton = new Button();
            oneOverXButton = new Button();
            decimalButton = new Button();
            zeroButton = new Button();
            nineButton = new Button();
            equalsButton = new Button();
            multiplicationButton = new Button();
            divisionButton = new Button();
            sixButton = new Button();
            fiveButton = new Button();
            fourButton = new Button();
            eightButton = new Button();
            sevenButton = new Button();
            squaredButton = new Button();
            squareRootButton = new Button();
            positiveNegativeButton = new Button();
            ceButton = new Button();
            acButton = new Button();
            backSpaceButton = new Button();
            mrButton = new Button();
            mPositiveButton = new Button();
            mNegativeButton = new Button();
            mcButton = new Button();
            secondOperandTextBox = new TextBox();
            panel_FormHeader = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            Minimized_Application = new PictureBox();
            Maximize_Application = new PictureBox();
            Exit_Application = new PictureBox();
            pictureBoxLogo = new PictureBox();
            tableLayoutPanel_Buttons_Upper = new TableLayoutPanel();
            additionButton = new Button();
            differenceButton = new Button();
            twoButton = new Button();
            oneButton = new Button();
            threeButton = new Button();
            tableLayoutPanel_Buttons_Lower = new TableLayoutPanel();
            tableLayoutPanel_MainControl = new TableLayoutPanel();
            tableLayoutPanel_Display = new TableLayoutPanel();
            currentOperandTextBox = new TextBox();
            panel_FormHeader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Minimized_Application).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Maximize_Application).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Exit_Application).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            tableLayoutPanel_Buttons_Upper.SuspendLayout();
            tableLayoutPanel_Buttons_Lower.SuspendLayout();
            tableLayoutPanel_MainControl.SuspendLayout();
            tableLayoutPanel_Display.SuspendLayout();
            SuspendLayout();
            // 
            // appTitleLable
            // 
            appTitleLable.AutoSize = true;
            appTitleLable.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            appTitleLable.Location = new Point(53, 33);
            appTitleLable.Name = "appTitleLable";
            appTitleLable.Size = new Size(135, 22);
            appTitleLable.TabIndex = 1;
            appTitleLable.Text = "CALCULATOR";
            // 
            // percentageButton
            // 
            percentageButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            percentageButton.BackColor = SystemColors.ActiveBorder;
            percentageButton.FlatAppearance.BorderSize = 0;
            percentageButton.FlatStyle = FlatStyle.Flat;
            percentageButton.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            percentageButton.Location = new Point(275, 137);
            percentageButton.Name = "percentageButton";
            percentageButton.Size = new Size(66, 61);
            percentageButton.TabIndex = 37;
            percentageButton.Text = "%";
            percentageButton.UseVisualStyleBackColor = false;
            percentageButton.Click += PercentageButton_Click;
            // 
            // oneOverXButton
            // 
            oneOverXButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            oneOverXButton.BackColor = SystemColors.ActiveBorder;
            oneOverXButton.FlatAppearance.BorderSize = 0;
            oneOverXButton.FlatStyle = FlatStyle.Flat;
            oneOverXButton.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            oneOverXButton.Location = new Point(207, 137);
            oneOverXButton.Name = "oneOverXButton";
            oneOverXButton.Size = new Size(62, 61);
            oneOverXButton.TabIndex = 36;
            oneOverXButton.Text = "1/x";
            oneOverXButton.UseVisualStyleBackColor = false;
            oneOverXButton.Click += OneOverXButton_Click;
            // 
            // decimalButton
            // 
            decimalButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            decimalButton.BackColor = Color.White;
            decimalButton.FlatAppearance.BorderSize = 0;
            decimalButton.FlatStyle = FlatStyle.Flat;
            decimalButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            decimalButton.Location = new Point(140, 3);
            decimalButton.Name = "decimalButton";
            decimalButton.Size = new Size(62, 67);
            decimalButton.TabIndex = 35;
            decimalButton.Text = ".";
            decimalButton.UseVisualStyleBackColor = false;
            decimalButton.Click += DecimalButton_Click;
            // 
            // zeroButton
            // 
            zeroButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            zeroButton.BackColor = Color.White;
            zeroButton.FlatAppearance.BorderSize = 0;
            zeroButton.FlatStyle = FlatStyle.Flat;
            zeroButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            zeroButton.Location = new Point(3, 3);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(131, 67);
            zeroButton.TabIndex = 34;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = false;
            zeroButton.Click += ZeroButton_Click;
            // 
            // nineButton
            // 
            nineButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nineButton.BackColor = Color.White;
            nineButton.FlatAppearance.BorderSize = 0;
            nineButton.FlatStyle = FlatStyle.Flat;
            nineButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            nineButton.Location = new Point(139, 137);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(62, 61);
            nineButton.TabIndex = 31;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = false;
            nineButton.Click += NineButton_Click;
            // 
            // equalsButton
            // 
            equalsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            equalsButton.BackColor = Color.DeepSkyBlue;
            equalsButton.FlatAppearance.BorderSize = 0;
            equalsButton.FlatStyle = FlatStyle.Flat;
            equalsButton.Font = new Font("Consolas", 25F, FontStyle.Bold, GraphicsUnit.Point);
            equalsButton.Location = new Point(208, 3);
            equalsButton.Name = "equalsButton";
            equalsButton.Size = new Size(133, 67);
            equalsButton.TabIndex = 30;
            equalsButton.Text = "=";
            equalsButton.UseVisualStyleBackColor = false;
            equalsButton.Click += EqualsButton_Click;
            // 
            // multiplicationButton
            // 
            multiplicationButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            multiplicationButton.BackColor = SystemColors.ActiveBorder;
            multiplicationButton.FlatAppearance.BorderSize = 0;
            multiplicationButton.FlatStyle = FlatStyle.Flat;
            multiplicationButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            multiplicationButton.Location = new Point(275, 204);
            multiplicationButton.Name = "multiplicationButton";
            multiplicationButton.Size = new Size(66, 61);
            multiplicationButton.TabIndex = 29;
            multiplicationButton.Text = "x";
            multiplicationButton.UseVisualStyleBackColor = false;
            multiplicationButton.Click += MultiplicationButton_Click;
            // 
            // divisionButton
            // 
            divisionButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            divisionButton.BackColor = SystemColors.ActiveBorder;
            divisionButton.FlatAppearance.BorderSize = 0;
            divisionButton.FlatStyle = FlatStyle.Flat;
            divisionButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            divisionButton.Location = new Point(207, 204);
            divisionButton.Name = "divisionButton";
            divisionButton.Size = new Size(62, 61);
            divisionButton.TabIndex = 28;
            divisionButton.Text = "÷";
            divisionButton.UseVisualStyleBackColor = false;
            divisionButton.Click += DivisionButton_Click;
            // 
            // sixButton
            // 
            sixButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sixButton.BackColor = Color.White;
            sixButton.FlatAppearance.BorderSize = 0;
            sixButton.FlatStyle = FlatStyle.Flat;
            sixButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            sixButton.Location = new Point(139, 204);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(62, 61);
            sixButton.TabIndex = 24;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = false;
            sixButton.Click += SixButton_Click;
            // 
            // fiveButton
            // 
            fiveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fiveButton.BackColor = Color.White;
            fiveButton.FlatAppearance.BorderSize = 0;
            fiveButton.FlatStyle = FlatStyle.Flat;
            fiveButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            fiveButton.Location = new Point(71, 204);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(62, 61);
            fiveButton.TabIndex = 23;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = false;
            fiveButton.Click += FiveButton_Click;
            // 
            // fourButton
            // 
            fourButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fourButton.BackColor = Color.White;
            fourButton.FlatAppearance.BorderSize = 0;
            fourButton.FlatStyle = FlatStyle.Flat;
            fourButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            fourButton.Location = new Point(3, 204);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(62, 61);
            fourButton.TabIndex = 22;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = false;
            fourButton.Click += FourButton_Click;
            // 
            // eightButton
            // 
            eightButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eightButton.BackColor = Color.White;
            eightButton.FlatAppearance.BorderSize = 0;
            eightButton.FlatStyle = FlatStyle.Flat;
            eightButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            eightButton.Location = new Point(71, 137);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(62, 61);
            eightButton.TabIndex = 20;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = false;
            eightButton.Click += EightButton_Click;
            // 
            // sevenButton
            // 
            sevenButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sevenButton.BackColor = Color.White;
            sevenButton.FlatAppearance.BorderSize = 0;
            sevenButton.FlatStyle = FlatStyle.Flat;
            sevenButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            sevenButton.Location = new Point(3, 137);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(62, 61);
            sevenButton.TabIndex = 19;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = false;
            sevenButton.Click += SevenButton_Click;
            // 
            // squaredButton
            // 
            squaredButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            squaredButton.BackColor = SystemColors.ActiveBorder;
            squaredButton.FlatAppearance.BorderSize = 0;
            squaredButton.FlatStyle = FlatStyle.Flat;
            squaredButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            squaredButton.Location = new Point(275, 70);
            squaredButton.Name = "squaredButton";
            squaredButton.Size = new Size(66, 61);
            squaredButton.TabIndex = 18;
            squaredButton.Text = "x²";
            squaredButton.UseVisualStyleBackColor = false;
            squaredButton.Click += SquaredButton_Click;
            // 
            // squareRootButton
            // 
            squareRootButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            squareRootButton.BackColor = SystemColors.ActiveBorder;
            squareRootButton.FlatAppearance.BorderSize = 0;
            squareRootButton.FlatStyle = FlatStyle.Flat;
            squareRootButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            squareRootButton.Location = new Point(207, 70);
            squareRootButton.Name = "squareRootButton";
            squareRootButton.Size = new Size(62, 61);
            squareRootButton.TabIndex = 17;
            squareRootButton.Text = "√";
            squareRootButton.UseVisualStyleBackColor = false;
            squareRootButton.Click += SquareRootButton_Click;
            // 
            // positiveNegativeButton
            // 
            positiveNegativeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            positiveNegativeButton.BackColor = SystemColors.ActiveBorder;
            positiveNegativeButton.FlatAppearance.BorderSize = 0;
            positiveNegativeButton.FlatStyle = FlatStyle.Flat;
            positiveNegativeButton.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point);
            positiveNegativeButton.Location = new Point(139, 70);
            positiveNegativeButton.Name = "positiveNegativeButton";
            positiveNegativeButton.Size = new Size(62, 61);
            positiveNegativeButton.TabIndex = 16;
            positiveNegativeButton.Text = "±";
            positiveNegativeButton.UseVisualStyleBackColor = false;
            positiveNegativeButton.Click += PositveNegativeButton_Click;
            // 
            // ceButton
            // 
            ceButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ceButton.BackColor = SystemColors.ActiveBorder;
            ceButton.FlatAppearance.BorderSize = 0;
            ceButton.FlatStyle = FlatStyle.Flat;
            ceButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ceButton.Location = new Point(71, 70);
            ceButton.Name = "ceButton";
            ceButton.Size = new Size(62, 61);
            ceButton.TabIndex = 15;
            ceButton.Text = "CE";
            ceButton.UseVisualStyleBackColor = false;
            ceButton.Click += CeButton_Click;
            // 
            // acButton
            // 
            acButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            acButton.BackColor = SystemColors.ActiveBorder;
            acButton.FlatAppearance.BorderSize = 0;
            acButton.FlatStyle = FlatStyle.Flat;
            acButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            acButton.Location = new Point(3, 70);
            acButton.Name = "acButton";
            acButton.Size = new Size(62, 61);
            acButton.TabIndex = 14;
            acButton.Text = "AC";
            acButton.UseVisualStyleBackColor = false;
            acButton.Click += AcButton_Click;
            // 
            // backSpaceButton
            // 
            backSpaceButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            backSpaceButton.BackColor = SystemColors.ActiveBorder;
            backSpaceButton.BackgroundImageLayout = ImageLayout.Stretch;
            backSpaceButton.FlatAppearance.BorderSize = 0;
            backSpaceButton.FlatStyle = FlatStyle.Flat;
            backSpaceButton.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point);
            backSpaceButton.ForeColor = Color.Black;
            backSpaceButton.Location = new Point(275, 3);
            backSpaceButton.Name = "backSpaceButton";
            backSpaceButton.Size = new Size(66, 61);
            backSpaceButton.TabIndex = 13;
            backSpaceButton.Text = "⌫";
            backSpaceButton.UseVisualStyleBackColor = false;
            backSpaceButton.Click += BackSpaceButton_Click;
            // 
            // mrButton
            // 
            mrButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mrButton.BackColor = Color.Red;
            mrButton.FlatAppearance.BorderSize = 0;
            mrButton.FlatStyle = FlatStyle.Flat;
            mrButton.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            mrButton.ForeColor = Color.White;
            mrButton.Location = new Point(207, 3);
            mrButton.Name = "mrButton";
            mrButton.Size = new Size(62, 61);
            mrButton.TabIndex = 12;
            mrButton.Text = "MR";
            mrButton.UseVisualStyleBackColor = false;
            mrButton.Click += MrButton_Click;
            // 
            // mPositiveButton
            // 
            mPositiveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mPositiveButton.BackColor = Color.Red;
            mPositiveButton.FlatAppearance.BorderSize = 0;
            mPositiveButton.FlatStyle = FlatStyle.Flat;
            mPositiveButton.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            mPositiveButton.ForeColor = Color.White;
            mPositiveButton.Location = new Point(139, 3);
            mPositiveButton.Name = "mPositiveButton";
            mPositiveButton.Size = new Size(62, 61);
            mPositiveButton.TabIndex = 11;
            mPositiveButton.Text = "M+";
            mPositiveButton.UseVisualStyleBackColor = false;
            mPositiveButton.Click += MPositiveButton_Click;
            // 
            // mNegativeButton
            // 
            mNegativeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mNegativeButton.BackColor = Color.Red;
            mNegativeButton.FlatAppearance.BorderSize = 0;
            mNegativeButton.FlatStyle = FlatStyle.Flat;
            mNegativeButton.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            mNegativeButton.ForeColor = Color.White;
            mNegativeButton.Location = new Point(71, 3);
            mNegativeButton.Name = "mNegativeButton";
            mNegativeButton.Size = new Size(62, 61);
            mNegativeButton.TabIndex = 10;
            mNegativeButton.Text = "M-";
            mNegativeButton.UseVisualStyleBackColor = false;
            mNegativeButton.Click += MNegativeButton_Click;
            // 
            // mcButton
            // 
            mcButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mcButton.AutoSize = true;
            mcButton.BackColor = Color.Red;
            mcButton.FlatAppearance.BorderSize = 0;
            mcButton.FlatStyle = FlatStyle.Flat;
            mcButton.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            mcButton.ForeColor = Color.White;
            mcButton.Location = new Point(3, 3);
            mcButton.Name = "mcButton";
            mcButton.Size = new Size(62, 61);
            mcButton.TabIndex = 0;
            mcButton.Text = "MC";
            mcButton.UseVisualStyleBackColor = false;
            mcButton.Click += McButton_Click;
            // 
            // secondOperandTextBox
            // 
            secondOperandTextBox.BackColor = SystemColors.ActiveBorder;
            secondOperandTextBox.BorderStyle = BorderStyle.None;
            secondOperandTextBox.Dock = DockStyle.Bottom;
            secondOperandTextBox.Enabled = false;
            secondOperandTextBox.Font = new Font("Consolas", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            secondOperandTextBox.Location = new Point(3, 12);
            secondOperandTextBox.MaxLength = 20;
            secondOperandTextBox.Name = "secondOperandTextBox";
            secondOperandTextBox.ReadOnly = true;
            secondOperandTextBox.Size = new Size(338, 34);
            secondOperandTextBox.TabIndex = 1;
            secondOperandTextBox.TabStop = false;
            secondOperandTextBox.TextAlign = HorizontalAlignment.Right;
            secondOperandTextBox.TextChanged += SecondOperandTextBox_TextChanged;
            // 
            // panel_FormHeader
            // 
            panel_FormHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel_FormHeader.Controls.Add(tableLayoutPanel1);
            panel_FormHeader.Controls.Add(pictureBoxLogo);
            panel_FormHeader.Controls.Add(appTitleLable);
            panel_FormHeader.Location = new Point(-7, -14);
            panel_FormHeader.Name = "panel_FormHeader";
            panel_FormHeader.Size = new Size(468, 63);
            panel_FormHeader.TabIndex = 4;
            panel_FormHeader.MouseDown += Panel_FormHeader_MouseDown;
            panel_FormHeader.MouseMove += Panel_FormHeader_MouseMove;
            panel_FormHeader.MouseUp += Panel_FormHeader_MouseUp;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(Minimized_Application, 0, 0);
            tableLayoutPanel1.Controls.Add(Maximize_Application, 1, 0);
            tableLayoutPanel1.Controls.Add(Exit_Application, 2, 0);
            tableLayoutPanel1.Location = new Point(264, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(110, 35);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // Minimized_Application
            // 
            Minimized_Application.Anchor = AnchorStyles.None;
            Minimized_Application.Image = Properties.Resources.minimize;
            Minimized_Application.Location = new Point(6, 5);
            Minimized_Application.Name = "Minimized_Application";
            Minimized_Application.Size = new Size(23, 25);
            Minimized_Application.SizeMode = PictureBoxSizeMode.StretchImage;
            Minimized_Application.TabIndex = 5;
            Minimized_Application.TabStop = false;
            Minimized_Application.Click += Minimized_Application_Click;
            Minimized_Application.MouseLeave += Minimized_Application_MouseLeave;
            Minimized_Application.MouseHover += Minimized_Application_MouseHover;
            // 
            // Maximize_Application
            // 
            Maximize_Application.Anchor = AnchorStyles.None;
            Maximize_Application.Image = Properties.Resources.maximize;
            Maximize_Application.Location = new Point(42, 5);
            Maximize_Application.Name = "Maximize_Application";
            Maximize_Application.Size = new Size(24, 25);
            Maximize_Application.SizeMode = PictureBoxSizeMode.StretchImage;
            Maximize_Application.TabIndex = 4;
            Maximize_Application.TabStop = false;
            Maximize_Application.Click += Maximize_Application_Click;
            Maximize_Application.MouseLeave += Maximize_Application_MouseLeave;
            Maximize_Application.MouseHover += Maximize_Application_MouseHover;
            // 
            // Exit_Application
            // 
            Exit_Application.Anchor = AnchorStyles.None;
            Exit_Application.Image = Properties.Resources.close;
            Exit_Application.Location = new Point(78, 5);
            Exit_Application.Name = "Exit_Application";
            Exit_Application.Size = new Size(25, 25);
            Exit_Application.SizeMode = PictureBoxSizeMode.StretchImage;
            Exit_Application.TabIndex = 3;
            Exit_Application.TabStop = false;
            Exit_Application.Click += Exit_Application_Click;
            Exit_Application.MouseLeave += Exit_Application_MouseLeave;
            Exit_Application.MouseHover += Exit_Application_MouseHover;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.SystemLogo;
            pictureBoxLogo.Location = new Point(22, 28);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(30, 30);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // tableLayoutPanel_Buttons_Upper
            // 
            tableLayoutPanel_Buttons_Upper.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel_Buttons_Upper.ColumnCount = 5;
            tableLayoutPanel_Buttons_Upper.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Buttons_Upper.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Buttons_Upper.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Buttons_Upper.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Buttons_Upper.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Buttons_Upper.Controls.Add(percentageButton, 4, 2);
            tableLayoutPanel_Buttons_Upper.Controls.Add(additionButton, 4, 4);
            tableLayoutPanel_Buttons_Upper.Controls.Add(oneOverXButton, 3, 2);
            tableLayoutPanel_Buttons_Upper.Controls.Add(differenceButton, 3, 4);
            tableLayoutPanel_Buttons_Upper.Controls.Add(mNegativeButton, 1, 0);
            tableLayoutPanel_Buttons_Upper.Controls.Add(mPositiveButton, 2, 0);
            tableLayoutPanel_Buttons_Upper.Controls.Add(multiplicationButton, 4, 3);
            tableLayoutPanel_Buttons_Upper.Controls.Add(twoButton, 1, 4);
            tableLayoutPanel_Buttons_Upper.Controls.Add(mrButton, 3, 0);
            tableLayoutPanel_Buttons_Upper.Controls.Add(oneButton, 0, 4);
            tableLayoutPanel_Buttons_Upper.Controls.Add(divisionButton, 3, 3);
            tableLayoutPanel_Buttons_Upper.Controls.Add(backSpaceButton, 4, 0);
            tableLayoutPanel_Buttons_Upper.Controls.Add(acButton, 0, 1);
            tableLayoutPanel_Buttons_Upper.Controls.Add(nineButton, 2, 2);
            tableLayoutPanel_Buttons_Upper.Controls.Add(ceButton, 1, 1);
            tableLayoutPanel_Buttons_Upper.Controls.Add(sixButton, 2, 3);
            tableLayoutPanel_Buttons_Upper.Controls.Add(positiveNegativeButton, 2, 1);
            tableLayoutPanel_Buttons_Upper.Controls.Add(fiveButton, 1, 3);
            tableLayoutPanel_Buttons_Upper.Controls.Add(squareRootButton, 3, 1);
            tableLayoutPanel_Buttons_Upper.Controls.Add(fourButton, 0, 3);
            tableLayoutPanel_Buttons_Upper.Controls.Add(squaredButton, 4, 1);
            tableLayoutPanel_Buttons_Upper.Controls.Add(sevenButton, 0, 2);
            tableLayoutPanel_Buttons_Upper.Controls.Add(eightButton, 1, 2);
            tableLayoutPanel_Buttons_Upper.Controls.Add(mcButton, 0, 0);
            tableLayoutPanel_Buttons_Upper.Controls.Add(threeButton, 2, 4);
            tableLayoutPanel_Buttons_Upper.Location = new Point(3, 108);
            tableLayoutPanel_Buttons_Upper.Name = "tableLayoutPanel_Buttons_Upper";
            tableLayoutPanel_Buttons_Upper.RowCount = 5;
            tableLayoutPanel_Buttons_Upper.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Buttons_Upper.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Buttons_Upper.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Buttons_Upper.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Buttons_Upper.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Buttons_Upper.Size = new Size(344, 335);
            tableLayoutPanel_Buttons_Upper.TabIndex = 5;
            // 
            // additionButton
            // 
            additionButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            additionButton.BackColor = SystemColors.ActiveBorder;
            additionButton.FlatAppearance.BorderSize = 0;
            additionButton.FlatStyle = FlatStyle.Flat;
            additionButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            additionButton.Location = new Point(275, 271);
            additionButton.Name = "additionButton";
            additionButton.Size = new Size(66, 61);
            additionButton.TabIndex = 33;
            additionButton.Text = "+";
            additionButton.UseVisualStyleBackColor = false;
            additionButton.Click += AdditionButton_Click;
            // 
            // differenceButton
            // 
            differenceButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            differenceButton.BackColor = SystemColors.ActiveBorder;
            differenceButton.FlatAppearance.BorderSize = 0;
            differenceButton.FlatStyle = FlatStyle.Flat;
            differenceButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            differenceButton.Location = new Point(207, 271);
            differenceButton.Name = "differenceButton";
            differenceButton.Size = new Size(62, 61);
            differenceButton.TabIndex = 32;
            differenceButton.Text = "−";
            differenceButton.UseVisualStyleBackColor = false;
            differenceButton.Click += DifferenceButton_Click;
            // 
            // twoButton
            // 
            twoButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            twoButton.BackColor = Color.White;
            twoButton.FlatAppearance.BorderSize = 0;
            twoButton.FlatStyle = FlatStyle.Flat;
            twoButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            twoButton.Location = new Point(71, 271);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(62, 61);
            twoButton.TabIndex = 26;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = false;
            twoButton.Click += TwoButton_Click;
            // 
            // oneButton
            // 
            oneButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            oneButton.BackColor = Color.White;
            oneButton.FlatAppearance.BorderSize = 0;
            oneButton.FlatStyle = FlatStyle.Flat;
            oneButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            oneButton.Location = new Point(3, 271);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(62, 61);
            oneButton.TabIndex = 25;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = false;
            oneButton.Click += OneButton_Click;
            // 
            // threeButton
            // 
            threeButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            threeButton.BackColor = Color.White;
            threeButton.FlatAppearance.BorderSize = 0;
            threeButton.FlatStyle = FlatStyle.Flat;
            threeButton.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            threeButton.Location = new Point(139, 271);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(62, 61);
            threeButton.TabIndex = 27;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = false;
            threeButton.Click += ThreeButton_Click;
            // 
            // tableLayoutPanel_Buttons_Lower
            // 
            tableLayoutPanel_Buttons_Lower.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel_Buttons_Lower.ColumnCount = 3;
            tableLayoutPanel_Buttons_Lower.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel_Buttons_Lower.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel_Buttons_Lower.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel_Buttons_Lower.Controls.Add(zeroButton, 0, 0);
            tableLayoutPanel_Buttons_Lower.Controls.Add(equalsButton, 2, 0);
            tableLayoutPanel_Buttons_Lower.Controls.Add(decimalButton, 1, 0);
            tableLayoutPanel_Buttons_Lower.Location = new Point(3, 449);
            tableLayoutPanel_Buttons_Lower.Name = "tableLayoutPanel_Buttons_Lower";
            tableLayoutPanel_Buttons_Lower.RowCount = 1;
            tableLayoutPanel_Buttons_Lower.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Buttons_Lower.Size = new Size(344, 73);
            tableLayoutPanel_Buttons_Lower.TabIndex = 6;
            // 
            // tableLayoutPanel_MainControl
            // 
            tableLayoutPanel_MainControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel_MainControl.ColumnCount = 1;
            tableLayoutPanel_MainControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_MainControl.Controls.Add(tableLayoutPanel_Display, 0, 0);
            tableLayoutPanel_MainControl.Controls.Add(tableLayoutPanel_Buttons_Lower, 0, 2);
            tableLayoutPanel_MainControl.Controls.Add(tableLayoutPanel_Buttons_Upper, 0, 1);
            tableLayoutPanel_MainControl.Location = new Point(15, 71);
            tableLayoutPanel_MainControl.Name = "tableLayoutPanel_MainControl";
            tableLayoutPanel_MainControl.RowCount = 3;
            tableLayoutPanel_MainControl.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel_MainControl.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel_MainControl.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel_MainControl.Size = new Size(350, 525);
            tableLayoutPanel_MainControl.TabIndex = 8;
            // 
            // tableLayoutPanel_Display
            // 
            tableLayoutPanel_Display.BackColor = SystemColors.Info;
            tableLayoutPanel_Display.ColumnCount = 1;
            tableLayoutPanel_Display.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel_Display.Controls.Add(currentOperandTextBox, 0, 1);
            tableLayoutPanel_Display.Controls.Add(secondOperandTextBox, 0, 0);
            tableLayoutPanel_Display.Dock = DockStyle.Fill;
            tableLayoutPanel_Display.Location = new Point(3, 3);
            tableLayoutPanel_Display.Name = "tableLayoutPanel_Display";
            tableLayoutPanel_Display.RowCount = 2;
            tableLayoutPanel_Display.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_Display.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel_Display.Size = new Size(344, 99);
            tableLayoutPanel_Display.TabIndex = 9;
            // 
            // currentOperandTextBox
            // 
            currentOperandTextBox.BackColor = SystemColors.ActiveCaption;
            currentOperandTextBox.BorderStyle = BorderStyle.None;
            currentOperandTextBox.Dock = DockStyle.Bottom;
            currentOperandTextBox.Font = new Font("Consolas", 27F, FontStyle.Bold, GraphicsUnit.Point);
            currentOperandTextBox.Location = new Point(0, 56);
            currentOperandTextBox.Margin = new Padding(0);
            currentOperandTextBox.MaxLength = 20;
            currentOperandTextBox.Name = "currentOperandTextBox";
            currentOperandTextBox.ReadOnly = true;
            currentOperandTextBox.Size = new Size(344, 43);
            currentOperandTextBox.TabIndex = 2;
            currentOperandTextBox.TabStop = false;
            currentOperandTextBox.TextAlign = HorizontalAlignment.Right;
            currentOperandTextBox.TextChanged += CurrentOperandTextBox_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(379, 609);
            ControlBox = false;
            Controls.Add(tableLayoutPanel_MainControl);
            Controls.Add(panel_FormHeader);
            Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(395, 625);
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            SizeChanged += MainForm_SizeChanged;
            KeyUp += MainForm_KeyUp;
            panel_FormHeader.ResumeLayout(false);
            panel_FormHeader.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Minimized_Application).EndInit();
            ((System.ComponentModel.ISupportInitialize)Maximize_Application).EndInit();
            ((System.ComponentModel.ISupportInitialize)Exit_Application).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            tableLayoutPanel_Buttons_Upper.ResumeLayout(false);
            tableLayoutPanel_Buttons_Upper.PerformLayout();
            tableLayoutPanel_Buttons_Lower.ResumeLayout(false);
            tableLayoutPanel_MainControl.ResumeLayout(false);
            tableLayoutPanel_Display.ResumeLayout(false);
            tableLayoutPanel_Display.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label appTitleLable;
        private Button mcButton;
        private TextBox secondOperandTextBox;
        private Button backSpaceButton;
        private Button mrButton;
        private Button mPositiveButton;
        private Button mNegativeButton;
        private Button squaredButton;
        private Button squareRootButton;
        private Button positiveNegativeButton;
        private Button ceButton;
        private Button acButton;
        private Button nineButton;
        private Button equalsButton;
        private Button multiplicationButton;
        private Button divisionButton;
        private Button sixButton;
        private Button fiveButton;
        private Button fourButton;
        private Button eightButton;
        private Button sevenButton;
        private Button decimalButton;
        private Button zeroButton;
        private Button percentageButton;
        private Button oneOverXButton;
        private Panel panel_FormHeader;
        private PictureBox pictureBoxLogo;
        private TableLayoutPanel tableLayoutPanel_Buttons_Upper;
        private TableLayoutPanel tableLayoutPanel_Buttons_Lower;
        private Button additionButton;
        private Button differenceButton;
        private Button threeButton;
        private Button twoButton;
        private Button oneButton;
        private TableLayoutPanel tableLayoutPanel_MainControl;
        private PictureBox Exit_Application;
        private PictureBox Minimized_Application;
        private PictureBox Maximize_Application;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox currentOperandTextBox;
        private TableLayoutPanel tableLayoutPanel_Display;
    }
}