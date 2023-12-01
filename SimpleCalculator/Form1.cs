using System.Collections;

namespace SimpleCalculator
{
    public partial class MainForm : Form
    {
        //Movable Form Variables
        private bool drag = false;
        private Point starting_point;

        //Current Operand Textbox Details
        private byte MAX_LENGTH = 20;
        private byte LENGTH_LIMIT = 17;
        private float FONT_SIZE = 27F;

        //Second Operatnd Textbox Details
        private byte S_LENGTH_LIMIT = 20;
        private float S_FONT_SIZE = 21.75F;

        private double memory = 0;

        private bool operator_is_set = false;
        private bool start_operation = false;
        private bool reset_entry = false;
        private bool clear = false;

        private Queue operations = new();

        private string? current_operation;
        public MainForm()
        {
            InitializeComponent();

            //Initialized Components
            currentOperandTextBox.Text = "0";
        }

        //
        // Entries Function
        //
        private void InputEntry(char c)
        {
            if (reset_entry || currentOperandTextBox.Text == "0")
            {
                if (clear)
                {
                    Function("clear");
                    Function("enable");
                }

                currentOperandTextBox.Text = c.ToString();

                reset_entry = false;
            }
            else if (currentOperandTextBox.Text.Length < MAX_LENGTH - 1)
                currentOperandTextBox.Text += c;

            if (operator_is_set)
                start_operation = true;
        }

        private void EqualsEntry()
        {
            if (operations.Count > 0)
            {
                if (operations.Peek()?.ToString() != "equ")
                {
                    current_operation = operations.Dequeue()?.ToString();
                    Arithmetic.y = double.Parse(currentOperandTextBox.Text);
                    currentOperandTextBox.Text = Arithmetic.Operation(current_operation);
                    start_operation = false;
                    operator_is_set = false;
                    operations.Clear();
                    operations.Enqueue("equ");
                    clear = true;
                }
                else
                {
                    Arithmetic.x = double.Parse(currentOperandTextBox.Text);
                    currentOperandTextBox.Text = Arithmetic.Operation(current_operation);
                }

                secondOperandTextBox.Text = FormatString(string.Format("{0} {1} {2} = ", Arithmetic.x, Arithmetic.sign, Arithmetic.y));
            }
            else
                secondOperandTextBox.Text = FormatString(string.Format("{0} = ", currentOperandTextBox.Text));

            reset_entry = true;
        }

        //
        // Mouse to Form Entries
        //
        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs || e is KeyEventArgs)
            {
                if (reset_entry || currentOperandTextBox.Text == "0")
                {
                    if (clear)
                    {
                        Function("clear");
                        Function("enable");
                    }

                    if (currentOperandTextBox.Text.IndexOf('.') == -1)
                        currentOperandTextBox.Text = "0.";

                    reset_entry = false;
                    clear = false;
                }
                else if (currentOperandTextBox.Text.Length < (MAX_LENGTH - 1) && currentOperandTextBox.Text.IndexOf('.') == -1)
                    currentOperandTextBox.Text += '.';

                if (operator_is_set)
                    start_operation = true;
            }
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs || e is KeyEventArgs)
            {
                if (reset_entry)
                {
                    if (clear)
                    {
                        Function("clear");
                        Function("enable");
                    }

                    currentOperandTextBox.Text = "0";
                    reset_entry = false;
                }
                else if (currentOperandTextBox.Text.Length < (MAX_LENGTH - 1) && currentOperandTextBox.Text != "0")
                    currentOperandTextBox.Text += '0';

                if (operator_is_set)
                    start_operation = true;
            }
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
                InputEntry('1');
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
                InputEntry('2');
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
                InputEntry('3');
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
                InputEntry('4');
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
                InputEntry('5');
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
                InputEntry('6');
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
                InputEntry('7');
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
                InputEntry('8');
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
                InputEntry('9');
        }

        private void BackSpaceButton_Click(object sender, EventArgs e)
        {
            char[] current_stream = currentOperandTextBox.Text.ToCharArray();

            if (e is MouseEventArgs || e is KeyEventArgs)
            {
                if (current_stream.Length > 1)
                {
                    current_stream[current_stream.Length - 1] = '\0';
                }
                else if (current_stream[0] != '0')
                {
                    current_stream[0] = '0';
                }
            }

            currentOperandTextBox.Text = string.Join("", current_stream);
        }

        //
        // Operations
        //

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            if (operator_is_set && operations.Peek()?.ToString() != "equ")
            {
                if (start_operation)
                {
                    Arithmetic.y = double.Parse(currentOperandTextBox.Text);
                    currentOperandTextBox.Text = Arithmetic.Operation(operations.Dequeue()?.ToString());
                    start_operation = false;
                    operations.Enqueue("add");
                }
            }
            else
            {
                if (operations.Count > 0)
                    operations.Dequeue();

                clear = false;
                operator_is_set = true;
                Arithmetic.sign = '+';
                operations.Enqueue("add");
            }

            Arithmetic.x = double.Parse(currentOperandTextBox.Text);
            secondOperandTextBox.Text = FormatString(string.Format("{0} + ", Arithmetic.x));
            reset_entry = true;
        }

        private void DifferenceButton_Click(object sender, EventArgs e)
        {
            if (operator_is_set && operations.Peek()?.ToString() != "equ")
            {
                if (start_operation)
                {
                    Arithmetic.y = double.Parse(currentOperandTextBox.Text);
                    currentOperandTextBox.Text = Arithmetic.Operation(operations.Dequeue()?.ToString());
                    start_operation = false;
                    operations.Enqueue("sub");
                }
            }
            else
            {
                if (operations.Count > 0)
                    operations.Dequeue();

                clear = false;
                operator_is_set = true;
                Arithmetic.sign = '-';
                operations.Enqueue("sub");
            }

            Arithmetic.x = double.Parse(currentOperandTextBox.Text);
            secondOperandTextBox.Text = FormatString(string.Format("{0} - ", Arithmetic.x));
            reset_entry = true;
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            if (operator_is_set && operations.Peek()?.ToString() != "equ")
            {
                if (start_operation)
                {
                    Arithmetic.y = double.Parse(currentOperandTextBox.Text);
                    currentOperandTextBox.Text = Arithmetic.Operation(operations.Dequeue()?.ToString());
                    start_operation = false;
                    operations.Enqueue("mul");
                }
            }
            else
            {
                if (operations.Count > 0)
                    operations.Dequeue();

                clear = false;
                operator_is_set = true;
                Arithmetic.sign = '×';
                operations.Enqueue("mul");
            }

            Arithmetic.x = double.Parse(currentOperandTextBox.Text);
            secondOperandTextBox.Text = FormatString(string.Format("{0} × ", Arithmetic.x));
            reset_entry = true;
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            if (operator_is_set && operations.Peek()?.ToString() != "equ")
            {
                if (start_operation)
                {
                    Arithmetic.y = double.Parse(currentOperandTextBox.Text);
                    currentOperandTextBox.Text = Arithmetic.Operation(operations.Dequeue()?.ToString());
                    start_operation = false;
                    operations.Enqueue("div");
                }
            }
            else
            {
                if (operations.Count > 0)
                    operations.Dequeue();

                clear = false;
                operator_is_set = true;
                Arithmetic.sign = '÷';
                operations.Enqueue("div");
            }

            Arithmetic.x = double.Parse(currentOperandTextBox.Text);
            secondOperandTextBox.Text = FormatString(string.Format("{0} ÷ ", Arithmetic.x));
            reset_entry = true;
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (e is EventArgs || e is KeyEventArgs)
                EqualsEntry();
        }

        //
        // Special Operations
        //

        private void PercentageButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
            {
                if (operations.Count > 0 && operations.Peek()?.ToString() != "equ")
                {
                    string? mode = operations.Dequeue()?.ToString();

                    Arithmetic.y = double.Parse(currentOperandTextBox.Text) / 100;

                    if (mode == "add" || mode == "sub")
                    {
                        Arithmetic.y = double.Parse(Arithmetic.Operation("mul"));
                        currentOperandTextBox.Text = Arithmetic.Operation(mode);
                    }
                    else if (mode == "mul" || mode == "div")
                        currentOperandTextBox.Text = Arithmetic.Operation(mode);

                    secondOperandTextBox.Text = string.Format("{0} {1} {2} = ", Arithmetic.x, Arithmetic.sign, Arithmetic.y);

                    operator_is_set = false;
                    reset_entry = true;
                    clear = true;
                }
            }
        }

        private void OneOverXButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
            {
                string value;

                if (operations.Count > 0)
                {
                    Arithmetic.y = double.Parse(currentOperandTextBox.Text);
                    secondOperandTextBox.Text = FormatString($"{Arithmetic.x} {Arithmetic.sign} 1 / ({Arithmetic.y})");
                    value = (1 / Arithmetic.y).ToString();
                }
                else
                {
                    Arithmetic.x = double.Parse(currentOperandTextBox.Text);
                    secondOperandTextBox.Text = FormatString($"1 / ({Arithmetic.x})");
                    value = (1 / Arithmetic.x).ToString();
                }

                if (value == "∞")
                {
                    Function("disable");
                    currentOperandTextBox.Text = "Can't Divide by Zero";
                }
                else
                    currentOperandTextBox.Text = value;
            }
        }

        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
            {
                if (operations.Count > 0)
                {
                    Arithmetic.y = double.Parse(currentOperandTextBox.Text);
                    secondOperandTextBox.Text = FormatString($"{Arithmetic.x} {Arithmetic.sign} √({Arithmetic.y})");
                    currentOperandTextBox.Text = Math.Sqrt(Arithmetic.y).ToString();
                }
                else
                {
                    Arithmetic.x = double.Parse(currentOperandTextBox.Text);
                    secondOperandTextBox.Text = FormatString($"√({Arithmetic.x})");
                    currentOperandTextBox.Text = Math.Sqrt(Arithmetic.x).ToString();
                }
            }
        }

        private void SquaredButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
            {
                string value;

                if (operations.Count > 0)
                {
                    Arithmetic.y = double.Parse(currentOperandTextBox.Text);
                    secondOperandTextBox.Text = FormatString($"{Arithmetic.x} {Arithmetic.sign} ({Arithmetic.y})²");
                    value = Math.Pow(Arithmetic.y, 2).ToString();
                }
                else
                {
                    Arithmetic.x = double.Parse(currentOperandTextBox.Text);
                    secondOperandTextBox.Text = FormatString($"({Arithmetic.x})²");
                    value = Math.Pow(Arithmetic.x, 2).ToString();
                }

                if (value == "∞")
                {
                    Function("disable");
                    currentOperandTextBox.Text = "Overflow";
                }
                else
                    currentOperandTextBox.Text = value;
            }
        }

        private void PositveNegativeButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
                currentOperandTextBox.Text = currentOperandTextBox.Text != "0" ? (double.Parse(currentOperandTextBox.Text) * -1).ToString() : "0";
        }

        //
        // Memory Configuration
        //
        private void MPositiveButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
                memoryConfiguration("add");
        }

        private void MNegativeButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
                memoryConfiguration("sub");
        }

        private void McButton_Click(object sender, EventArgs e)
        {
            if (memory != 0 && e is MouseEventArgs)
                memoryConfiguration("ClearMemory");
        }

        private void MrButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
                memoryConfiguration("ReadMemory");
        }

        private void memoryConfiguration(string mode)
        {
            if (mode == "add" || mode == "sub")
            {
                Arithmetic.x = memory;
                Arithmetic.y = double.Parse(currentOperandTextBox.Text);
                memory = double.Parse(Arithmetic.Operation(mode));
                secondOperandTextBox.Text = string.Format("Memory = {0}", memory);

                clear = true;
                reset_entry = true;
            }
            else if (mode == "ClearMemory")
            {
                memory = 0;
                secondOperandTextBox.Text = "Memory Cleared";

                clear = true;
                reset_entry = true;
            }
            else if (mode == "ReadMemory")
            {
                secondOperandTextBox.Text = "Memory = ";
                currentOperandTextBox.Text = memory.ToString();
            }
        }

        //
        // Display Configuration
        //

        private void CurrentOperandTextBox_TextChanged(object sender, EventArgs e)
        {
            string current_stream = currentOperandTextBox.Text;

            if (double.TryParse(current_stream, out _))
            {
                int decimal_place = current_stream.IndexOf('.') != -1 ? current_stream.Substring(current_stream.IndexOf('.') + 1).Length : -1;

                if (decimal_place > 0 && !current_stream.Contains('E'))
                    current_stream = double.Parse(current_stream).ToString($"N{decimal_place}");
                else if (decimal_place > 0 && current_stream.Contains('E') || current_stream.Length >= MAX_LENGTH)
                    current_stream = double.Parse(current_stream).ToString($"E10");
                else if (decimal_place == -1)
                    current_stream = double.Parse(current_stream).ToString("N0");

                currentOperandTextBox.Text = current_stream;
            }

            // Adjust the font size if the size of text field for first operand exceeded the LENGTH_LIMIT

            ReSize();
        }

        private void SecondOperandTextBox_TextChanged(object sender, EventArgs e)
        {
            // Adjust the font size if the size of text field for first operand exceeded the S_LENGTH_LIMIT

            ReSize();
        }

        private static string FormatString(string args)
        {
            char[] delimiter = { '+', '-', '×', '÷', '=' };
            string[] stream = args.Trim().Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            if (stream.Length == 1 && args.Length > 18)
            {
                return args.Replace(Arithmetic.x.ToString(), Arithmetic.x.ToString("E7"));
            }
            else if (stream.Length > 1 && args.Length > 18)
            {
                if (Arithmetic.x.ToString().Length > 7 && Arithmetic.y.ToString().Length <= 7)
                    return args.Replace(Arithmetic.x.ToString(), Arithmetic.x.ToString($"E4"));
                else if (Arithmetic.y.ToString().Length > 7 && Arithmetic.x.ToString().Length <= 7)
                    return args.Replace(Arithmetic.y.ToString(), Arithmetic.y.ToString($"E4"));
                else
                    return args.Replace(Arithmetic.x.ToString(), Arithmetic.x.ToString("E2"))
                               .Replace(Arithmetic.y.ToString(), Arithmetic.y.ToString("E2"));
            }
            else
                return args;
        }

        //
        // Clear Data Entries, Buttons Availability Configuration
        //
        private void AcButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
            {
                Function("enable");
                Function("clear");
                reset_entry = true;
                operator_is_set = false;
                start_operation = false;
                operations.Clear();
                currentOperandTextBox.Text = "0";
            }
        }

        private void CeButton_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs)
            {
                if (!clear)
                {
                    reset_entry = true;
                    currentOperandTextBox.Text = "0";
                }
                else
                    AcButton_Click(sender, e);
            }
        }

        private void Function(string? set)
        {
            switch (set)
            {
                case "clear":
                    secondOperandTextBox.Text = "";
                    clear = true;
                    return;
                case "disable":
                    clear = true;
                    reset_entry = true;
                    start_operation = false;
                    operator_is_set = false;
                    additionButton.Enabled = false;
                    differenceButton.Enabled = false;
                    multiplicationButton.Enabled = false;
                    divisionButton.Enabled = false;
                    oneOverXButton.Enabled = false;
                    squaredButton.Enabled = false;
                    squareRootButton.Enabled = false;
                    mPositiveButton.Enabled = false;
                    mNegativeButton.Enabled = false;
                    mcButton.Enabled = false;
                    mrButton.Enabled = false;
                    percentageButton.Enabled = false;
                    positiveNegativeButton.Enabled = false;
                    return;
                case "enable":
                    additionButton.Enabled = true;
                    differenceButton.Enabled = true;
                    multiplicationButton.Enabled = true;
                    divisionButton.Enabled = true;
                    oneOverXButton.Enabled = true;
                    squaredButton.Enabled = true;
                    squareRootButton.Enabled = true;
                    mPositiveButton.Enabled = true;
                    mNegativeButton.Enabled = true;
                    mcButton.Enabled = true;
                    mrButton.Enabled = true;
                    percentageButton.Enabled = true;
                    positiveNegativeButton.Enabled = true;
                    return;
                default:
                    return;
            }
        }

        //
        // Interactive UI Section && Navigation Functionalities
        //
        private void Panel_FormHeader_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            starting_point = new Point(e.X, e.Y);
        }

        private void Panel_FormHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
                Location = new Point(PointToScreen(e.Location).X - starting_point.X,
                                 PointToScreen(e.Location).Y - starting_point.Y);
        }

        private void Panel_FormHeader_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Exit_Application_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_Application_MouseHover(object sender, EventArgs e)
        {
            Exit_Application.Size = new Size(30, 30);
        }

        private void Exit_Application_MouseLeave(object sender, EventArgs e)
        {
            Exit_Application.Size = new Size(25, 25);
        }

        private void Maximize_Application_MouseHover(object sender, EventArgs e)
        {
            Maximize_Application.Size = new Size(30, 30);
        }

        private void Maximize_Application_MouseLeave(object sender, EventArgs e)
        {
            Maximize_Application.Size = new Size(25, 25);
        }

        private void Maximize_Application_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                Maximize_Application.Image = Properties.Resources.restore;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                Maximize_Application.Image = Properties.Resources.maximize;
                WindowState = FormWindowState.Normal;

            }

            ReSize();
        }

        private void Minimized_Application_MouseHover(object sender, EventArgs e)
        {
            Minimized_Application.Size = new Size(30, 30);
        }

        private void Minimized_Application_MouseLeave(object sender, EventArgs e)
        {
            Minimized_Application.Size = new Size(25, 25);
        }

        private void Minimized_Application_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
                ZeroButton_Click(sender, e);
            else if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
                InputEntry('1');
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
                InputEntry('2');
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
                InputEntry('3');
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
                InputEntry('4');
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
                InputEntry('5');
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
                InputEntry('6');
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
                InputEntry('7');
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
                InputEntry('8');
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
                InputEntry('9');
            else if (e.KeyCode == Keys.Decimal)
                DecimalButton_Click(sender, e);
            else if (e.KeyCode == Keys.Add)
                AdditionButton_Click(sender, e);
            else if (e.KeyCode == Keys.Subtract)
                DifferenceButton_Click(sender, e);
            else if (e.KeyCode == Keys.Multiply)
                MultiplicationButton_Click(sender, e);
            else if (e.KeyCode == Keys.Divide)
                DivisionButton_Click(sender, e);
            else if (e.KeyCode == Keys.Enter)
                EqualsEntry();
            else if (e.KeyCode == Keys.Back)
                BackSpaceButton_Click(sender, e);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            ReSize();
        }

        private void ReSize()
        {
            if (Width > MinimumSize.Width || Height > MinimumSize.Height)
            {
                float x_ratio = (float)Width / MinimumSize.Width;
                float y_ratio = (float)Height / MinimumSize.Height;

                float ratio = x_ratio >= y_ratio ? y_ratio : x_ratio;

                FONT_SIZE = 27F * ratio;
                S_FONT_SIZE = 21.75F * ratio;
                LENGTH_LIMIT = (byte)(17 * ratio);
                S_LENGTH_LIMIT = (byte)(20 * ratio);
            }
            else if (Width == MinimumSize.Width && Height == MinimumSize.Height)
            {
                FONT_SIZE = 27F;
                S_FONT_SIZE = 21.75F;
                LENGTH_LIMIT = 17;
                S_LENGTH_LIMIT = 20;

                if (currentOperandTextBox.Text.Length > LENGTH_LIMIT)
                    FONT_SIZE = 27F * ((float)LENGTH_LIMIT / currentOperandTextBox.Text.Length);
                if (secondOperandTextBox.Text.Length > S_LENGTH_LIMIT)
                    S_FONT_SIZE = 21.75F * ((float)S_LENGTH_LIMIT / secondOperandTextBox.Text.Length);
            }

            currentOperandTextBox.Font = new Font("Consolas", FONT_SIZE, FontStyle.Bold, GraphicsUnit.Point);
            secondOperandTextBox.Font = new Font("Consolas", S_FONT_SIZE, FontStyle.Bold, GraphicsUnit.Point);
        }
    }
}