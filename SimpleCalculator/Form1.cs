using Microsoft.VisualBasic;
using System.Collections;
using System.Configuration;
using System.Drawing.Design;
using System.Drawing.Text;
using System.Globalization;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Security.Policy;

namespace SimpleCalculator
{
    public partial class MainForm : Form
    {

        private readonly byte MAX_LENGTH = 20;
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
                    erase("clear");

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
                    erase("clear");

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
                    erase("clear");

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
                    erase("clear");

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
                    erase("clear");

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
                    erase("clear");

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
                    erase("clear");

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
                    erase("clear");

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
                    erase("clear");

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
                    erase("clear");

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
                    secondOperandTextBox.Text = "";

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

            currentOperandTextBox.Text = String.Join("", current_stream);
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            if (operator_is_set && operations.Peek()?.ToString() != "equ")
            {
                if (start_operation)
                {
                    second_term = double.Parse(currentOperandTextBox.Text);
                    currentOperandTextBox.Text = Operation(operations.Dequeue()?.ToString());
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
                operations.Enqueue("add");
            }

            first_term = double.Parse(currentOperandTextBox.Text);;
            secondOperandTextBox.Text = String.Format("{0} + ", first_term);
            reset_entry = true;
        }

        private void differenceButton_Click(object sender, EventArgs e)
        {
            if (operator_is_set && operations.Peek()?.ToString() != "equ")
            {
                if (start_operation)
                {
                    second_term = double.Parse(currentOperandTextBox.Text);
                    currentOperandTextBox.Text = Operation(operations.Dequeue()?.ToString());
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
                operations.Enqueue("sub");
            }

            first_term = double.Parse(currentOperandTextBox.Text); ;
            secondOperandTextBox.Text = String.Format("{0} - ", first_term);
            reset_entry = true;
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            if (operator_is_set && operations.Peek()?.ToString() != "equ")
            {
                if (start_operation)
                {
                    second_term = double.Parse(currentOperandTextBox.Text);
                    currentOperandTextBox.Text = Operation(operations.Dequeue()?.ToString());
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
                operations.Enqueue("mul");
            }

            first_term = double.Parse(currentOperandTextBox.Text); ;
            secondOperandTextBox.Text = String.Format("{0} × ", first_term);
            reset_entry = true;
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            if (operator_is_set && operations.Peek()?.ToString() != "equ")
            {
                if (start_operation)
                {
                    second_term = double.Parse(currentOperandTextBox.Text);
                    currentOperandTextBox.Text = Operation(operations.Dequeue()?.ToString());
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
                operations.Enqueue("div");
            }

            first_term = double.Parse(currentOperandTextBox.Text); ;
            secondOperandTextBox.Text = String.Format("{0} ÷ ", first_term);
            reset_entry = true;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {   
            if (operations.Count > 0)
            {
                if (String.Format("{0}", operations.Peek()) != "equ")
                {
                    current_operation = String.Format("{0}", operations.Dequeue());
                    second_term = double.Parse(currentOperandTextBox.Text);
                    currentOperandTextBox.Text = Operation(current_operation);
                    start_operation = false;
                    operator_is_set = false;
                    operations.Clear();
                    operations.Enqueue("equ");

                    clear = true;
                }   
                else
                {
                    first_term = double.Parse(currentOperandTextBox.Text);
                    currentOperandTextBox.Text = Operation(current_operation);
                }

                secondOperandTextBox.Text = String.Format("{0} {1} {2} = ", first_term, operator_symbol ,second_term);
            }
            else
                secondOperandTextBox.Text = String.Format("{0} = ", currentOperandTextBox.Text);

            reset_entry = true;
        }

        private void percentageButton_Click(object sender, EventArgs e)
        {
            if (operations.Count > 0 && operations.Peek()?.ToString() != "equ")
            {
                string ? mode = operations.Dequeue()?.ToString();

                second_term = double.Parse(currentOperandTextBox.Text) / 100;

                if (mode == "add" || mode == "sub")
                {
                    second_term = double.Parse(Operation("mul"));
                    currentOperandTextBox.Text = mode == "add" ? Operation("add") : Operation("sub");
                }
                else if (mode == "mul" || mode == "div")
                    currentOperandTextBox.Text = mode == "mul" ? Operation("mul") : Operation("div");

                secondOperandTextBox.Text = String.Format("{0} {1} {2} = ", first_term, operator_symbol, second_term);

                operator_is_set = false;
                reset_entry = true;
                clear = true;
            }
        }

        private void oneOverXButton_Click(object sender, EventArgs e)
        {
            second_term = double.Parse(currentOperandTextBox.Text);

            if (operations.Count > 0 && operations.Peek()?.ToString() != "equ")
                secondOperandTextBox.Text += String.Format("1 / ({0})", second_term);
            else
                secondOperandTextBox.Text = String.Format("1 / ({0})", second_term);

            currentOperandTextBox.Text = Operation("inv");

            reset_entry = true;
        }

        private void squareRootButton_Click(object sender, EventArgs e)
        {
            second_term = double.Parse(currentOperandTextBox.Text);

            if (operations.Count > 0 && operations.Peek()?.ToString() != "equ")
                secondOperandTextBox.Text += String.Format("√({0})", second_term);
            else
                secondOperandTextBox.Text = String.Format("√({0})", second_term);

            currentOperandTextBox.Text = Operation("sqrt");

            reset_entry = true;
        }

        private void squaredButton_Click(object sender, EventArgs e)
        {
            second_term = double.Parse(currentOperandTextBox.Text);

            if (operations.Count > 0 && operations.Peek()?.ToString() != "equ")
                secondOperandTextBox.Text += String.Format("({0})²", second_term);
            else
                secondOperandTextBox.Text = String.Format("({0})²", second_term);

            currentOperandTextBox.Text = Operation("sqrd");

            reset_entry = true;
        }

        private void positveNegativeButton_Click(object sender, EventArgs e)
        {
            currentOperandTextBox.Text = Arithmetic.mul(double.Parse(currentOperandTextBox.Text), -1).ToString();
        }

        private void currentOperandTextBox_TextChanged(object sender, EventArgs e)
        {
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
            // Adjust the Font size if the current text field have a size of 18 or greater
            if (secondOperandTextBox.Text.Length > 18)
            {
                float font_size = 21.75F * (18F / secondOperandTextBox.Text.Length);
                secondOperandTextBox.Font = new Font("Consolas", font_size, FontStyle.Bold, GraphicsUnit.Point);
            }
            else
            {
                secondOperandTextBox.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }
        private void acButton_Click(object sender, EventArgs e)
        {
            first_term = 0;
            second_term = 0;
            reset_entry = true;
            operator_is_set = false;
            start_operation = false;
            operations.Clear();
            currentOperandTextBox.Text = "0";
            secondOperandTextBox.Text = "";
        }

        private void ceButton_Click(object sender, EventArgs e)
        {
            reset_entry = true;
            currentOperandTextBox.Text = "0";
        }

        private void mPositiveButton_Click(object sender, EventArgs e)
        {
            first_term = memory;
            second_term = double.Parse(currentOperandTextBox.Text);
            memory = double.Parse(Operation("add"));
            secondOperandTextBox.Text = String.Format("Memory = {0}", memory);

            clear = true;
            reset_entry = true;
        }

        private void mNegativeButton_Click(object sender, EventArgs e)
        {
            first_term = memory;
            second_term = double.Parse(currentOperandTextBox.Text);
            memory = double.Parse(Operation("sub"));
            secondOperandTextBox.Text = String.Format("Memory = {0}", memory);

            clear = true;
            reset_entry = true;
        }

        private void mcButton_Click(object sender, EventArgs e)
        {
            memory = 0;
            secondOperandTextBox.Text = String.Format("Memory = {0}", memory);

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

        private string Operation(string ? set)
        {
            string result = "";

            switch (set)
            {
                case "add":
                    operator_symbol = '+';
                    return Arithmetic.add(first_term, second_term).ToString();
                case "sub":
                    operator_symbol = '-';
                    return Arithmetic.sub(first_term, second_term).ToString();
                case "mul":
                    operator_symbol = '×';
                    return Arithmetic.mul(first_term, second_term).ToString();

                case "sqrt":
                    return Arithmetic.sqrt(second_term).ToString();

                case "sqrd":
                    return Arithmetic.sqrd(second_term).ToString();

                case "div":

                    operator_symbol = '÷';

                    result = Arithmetic.div(first_term, second_term).ToString();

                    if (result != "∞")
                        return result;
                    else
                    {
                        clear = true;
                        return "Can't Divide by Zero!";
                    }

                case "inv":

                    operator_symbol = '÷';

                    result = Arithmetic.div(1, second_term).ToString();

                    if (result != "∞")
                        return result;
                    else
                    {
                        clear = true;
                        return "Can't Divide by Zero!";
                    }

                default:
                    return "0";
            }
        }

        private void erase(string ? set)
        {
            switch (set)
            {
                case "clear":
                    secondOperandTextBox.Text = "";
                    clear = false;
                    return;
                case "reset":
                    currentOperandTextBox.Text = "0";
                    reset_entry = false;
                    return;

                default:
                    return;
            }
        }
    }
}