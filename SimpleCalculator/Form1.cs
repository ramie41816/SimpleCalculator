using System.Collections;

namespace SimpleCalculator
{
    public partial class MainForm : Form
    {

        private readonly byte MAX_LENGTH = 19;
        private double memory = 0;

        private bool operator_is_set = false;
        private bool start_operation = false;
        private bool reset_entry = false;
        private bool clear = false;

        private double first_term = 0;
        private double second_term = 0;

        private Queue operations = new Queue();

        private string? current_operation;

        private char operator_symbol = '\0';

        public MainForm()
        {
            InitializeComponent();

            //Initialized Components
            currentOperandTextBox.Text = "0";
        }

        private void zeroButton_Click(object sender, EventArgs e)
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
            else if (currentOperandTextBox.Text.Length < MAX_LENGTH && currentOperandTextBox.Text != "0")
                currentOperandTextBox.Text += '0';

            if (operator_is_set)
                start_operation = true;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (reset_entry || currentOperandTextBox.Text == "0")
            {
                if (clear)
                {
                    Function("clear");
                    Function("enable");
                }

                currentOperandTextBox.Text = "1";

                reset_entry = false;
            }
            else if (currentOperandTextBox.Text.Length < MAX_LENGTH)
                currentOperandTextBox.Text += '1';

            if (operator_is_set)
                start_operation = true;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (reset_entry || currentOperandTextBox.Text == "0")
            {
                if (clear)
                {
                    Function("clear");
                    Function("enable");
                }

                currentOperandTextBox.Text = "2";

                reset_entry = false;
            }
            else if (currentOperandTextBox.Text.Length < MAX_LENGTH)
                currentOperandTextBox.Text += '2';

            if (operator_is_set)
                start_operation = true;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (reset_entry || currentOperandTextBox.Text == "0")
            {
                if (clear)
                {
                    Function("clear");
                    Function("enable");
                }

                currentOperandTextBox.Text = "3";

                reset_entry = false;
            }
            else if (currentOperandTextBox.Text.Length < MAX_LENGTH)
                currentOperandTextBox.Text += '3';

            if (operator_is_set)
                start_operation = true;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (reset_entry || currentOperandTextBox.Text == "0")
            {
                if (clear)
                {
                    Function("clear");
                    Function("enable");
                }

                currentOperandTextBox.Text = "4";

                reset_entry = false;
            }
            else if (currentOperandTextBox.Text.Length < MAX_LENGTH)
                currentOperandTextBox.Text += '4';

            if (operator_is_set)
                start_operation = true;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (reset_entry || currentOperandTextBox.Text == "0")
            {
                if (clear)
                {
                    Function("clear");
                    Function("enable");
                }

                currentOperandTextBox.Text = "5";

                reset_entry = false;
            }
            else if (currentOperandTextBox.Text.Length < MAX_LENGTH)
                currentOperandTextBox.Text += '5';

            if (operator_is_set)
                start_operation = true;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (reset_entry || currentOperandTextBox.Text == "0")
            {
                if (clear)
                {
                    Function("clear");
                    Function("enable");
                }

                currentOperandTextBox.Text = "6";

                reset_entry = false;
            }
            else if (currentOperandTextBox.Text.Length < MAX_LENGTH)
                currentOperandTextBox.Text += '6';

            if (operator_is_set)
                start_operation = true;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (reset_entry || currentOperandTextBox.Text == "0")
            {
                if (clear)
                {
                    Function("clear");
                    Function("enable");
                }

                currentOperandTextBox.Text = "7";

                reset_entry = false;
            }
            else if (currentOperandTextBox.Text.Length < MAX_LENGTH)
                currentOperandTextBox.Text += '7';

            if (operator_is_set)
                start_operation = true;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (reset_entry || currentOperandTextBox.Text == "0")
            {
                if (clear)
                {
                    Function("clear");
                    Function("enable");
                }

                currentOperandTextBox.Text = "8";

                reset_entry = false;
            }
            else if (currentOperandTextBox.Text.Length < MAX_LENGTH)
                currentOperandTextBox.Text += '8';

            if (operator_is_set)
                start_operation = true;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (reset_entry || currentOperandTextBox.Text == "0")
            {
                if (clear)
                {
                    Function("clear");
                    Function("enable");
                }

                currentOperandTextBox.Text = "9";

                reset_entry = false;
            }
            else if (currentOperandTextBox.Text.Length < MAX_LENGTH)
                currentOperandTextBox.Text += '9';

            if (operator_is_set)
                start_operation = true;
        }

        private void decimalButton_Click(object sender, EventArgs e)
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
            else if (currentOperandTextBox.Text.Length < MAX_LENGTH && currentOperandTextBox.Text.IndexOf('.') == -1)
                currentOperandTextBox.Text += '.';

            if (operator_is_set)
                start_operation = true;
        }

        private void backSpaceButton_Click(object sender, EventArgs e)
        {
            char[] current_stream = currentOperandTextBox.Text.ToCharArray();

            if (current_stream.Length > 1)
            {
                current_stream[current_stream.Length - 1] = '\0';
            }
            else
            {
                if (current_stream[0] != '0')
                    current_stream[0] = '0';
            }

            currentOperandTextBox.Text = string.Join("", current_stream);
        }

        private void additionButton_Click(object sender, EventArgs e)
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

        private void differenceButton_Click(object sender, EventArgs e)
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

        private void multiplicationButton_Click(object sender, EventArgs e)
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

        private void divisionButton_Click(object sender, EventArgs e)
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

        private void equalsButton_Click(object sender, EventArgs e)
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

        private void percentageButton_Click(object sender, EventArgs e)
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

        private void oneOverXButton_Click(object sender, EventArgs e)
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

        private void squareRootButton_Click(object sender, EventArgs e)
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

        private void squaredButton_Click(object sender, EventArgs e)
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

        private void positveNegativeButton_Click(object sender, EventArgs e)
        {
            currentOperandTextBox.Text = currentOperandTextBox.Text != "0" ? (double.Parse(currentOperandTextBox.Text) * -1).ToString() : "0";
        }

        private void currentOperandTextBox_TextChanged(object sender, EventArgs e)
        {
            string current_stream = currentOperandTextBox.Text;

            if (double.TryParse(current_stream, out double value))
            {
                int decimal_place = current_stream.IndexOf('.') != -1 ? current_stream.Substring(current_stream.IndexOf('.') + 1).Length : -1;

                if (decimal_place > 0 && current_stream.IndexOf('E') == -1)
                    current_stream = double.Parse(current_stream).ToString($"N{decimal_place}");
                else if (decimal_place > 0 && current_stream.IndexOf('E') != -1 || current_stream.Length > MAX_LENGTH)
                    current_stream = double.Parse(current_stream).ToString($"E7");
                else if (decimal_place == -1)
                    current_stream = double.Parse(current_stream).ToString("N0");

                currentOperandTextBox.Text = current_stream;
            }

            // Adjust the Font size if the current text field have a size of 13 or greater
            if (currentOperandTextBox.Text.Length > 13)
            {
                float font_size = 27.75F * (13F / currentOperandTextBox.Text.Length);
                currentOperandTextBox.Font = new Font("Consolas", font_size, FontStyle.Bold, GraphicsUnit.Point);
            }
            else
            {
                currentOperandTextBox.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }

        private void secondOperandTextBox_TextChanged(object sender, EventArgs e)
        {
            if (secondOperandTextBox.Text.Length > 16)
            {
                float font_size = 21.75F * (16F / secondOperandTextBox.Text.Length);
                secondOperandTextBox.Font = new Font("Consolas", font_size, FontStyle.Bold, GraphicsUnit.Point);
            }
            else
            {
                secondOperandTextBox.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }

        private void acButton_Click(object sender, EventArgs e)
        {
            Function("enable");
            Function("clear");
            first_term = 0;
            second_term = 0;
            reset_entry = true;
            operator_is_set = false;
            start_operation = false;
            operations.Clear();
            currentOperandTextBox.Text = "0";
        }

        private void ceButton_Click(object sender, EventArgs e)
        {
            if (!clear)
            {
                reset_entry = true;
                currentOperandTextBox.Text = "0";
            }
            else
                acButton_Click(sender, e);
        }

        private void mPositiveButton_Click(object sender, EventArgs e)
        {
            Arithmetic.x = memory;
            Arithmetic.y = double.Parse(currentOperandTextBox.Text);
            memory = double.Parse(Arithmetic.Operation("add"));
            secondOperandTextBox.Text = string.Format("Memory = {0}", memory);

            clear = true;
            reset_entry = true;
        }

        private void mNegativeButton_Click(object sender, EventArgs e)
        {
            Arithmetic.x = memory;
            Arithmetic.y = double.Parse(currentOperandTextBox.Text);
            memory = double.Parse(Arithmetic.Operation("sub"));
            secondOperandTextBox.Text = string.Format("Memory = {0}", memory);

            clear = true;
            reset_entry = true;
        }

        private void mcButton_Click(object sender, EventArgs e)
        {
            memory = 0;
            secondOperandTextBox.Text = string.Format("Memory = {0}", memory);

            clear = true;
            reset_entry = true;
        }

        private void mrButton_Click(object sender, EventArgs e)
        {
            if (memory != 0)
            {
                secondOperandTextBox.Text = "Memory = ";
                currentOperandTextBox.Text = memory.ToString();
            }
        }

        private string FormatString(string args)
        {
            char[] delimiter = {'+', '-', '×', '÷', '='};
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

        private void Function(string ? set)
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
    }
}