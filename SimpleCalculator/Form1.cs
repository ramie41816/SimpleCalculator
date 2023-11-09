using Microsoft.VisualBasic;
using System.Collections;

namespace SimpleCalculator
{
    public partial class MainForm : Form
    {

        private readonly int maxLength = 13;
        private decimal memory = 0;
        private bool operatorSet = false;
        private bool operationStart = false;
        private bool entryReset = false;
        private string? currentOperation;
        private readonly string specialFunctions = "equ|per|1/x|sqr|x2";
        private Operations system = new Operations();
        private Queue operationQueue = new Queue();


        public MainForm()
        {
            InitializeComponent();

            //Initialized Components
            currentOperandTextBox.Text = "0";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text != "0" && currentOperandTextBox.TextLength <= maxLength && !entryReset)
                currentOperandTextBox.Text += '0';
            else if (entryReset)
            {
                currentOperandTextBox.Text = "0";
                entryReset = false;
            }

            if (operatorSet)
                operationStart = true;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {

            if (currentOperandTextBox.Text == "0")
                currentOperandTextBox.Text = "1";
            else if (entryReset && String.Format("{0}", operationQueue.Peek()) == "equ")
            {
                system.reset();
                currentOperandTextBox.Text = "1";
                secondOperandTextBox.Text = "";
                entryReset = false;
            }
            else if (entryReset)
            {
                currentOperandTextBox.Text = "1";
                entryReset = false;
            }
            else if (currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '1';

            if (operatorSet)
                operationStart = true;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text == "0")
                currentOperandTextBox.Text = "2";
            else if (entryReset && specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
            {
                system.reset();
                currentOperandTextBox.Text = "2";
                secondOperandTextBox.Text = "";
                entryReset = false;
            }
            else if (entryReset)
            {
                currentOperandTextBox.Text = "2";
                entryReset = false;
            }
            else if (currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '2';

            if (operatorSet)
                operationStart = true;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text == "0")
                currentOperandTextBox.Text = "3";
            else if (entryReset && specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
            {
                system.reset();
                currentOperandTextBox.Text = "3";
                secondOperandTextBox.Text = "";
                entryReset = false;
            }
            else if (entryReset)
            {
                currentOperandTextBox.Text = "3";
                entryReset = false;
            }
            else if (currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '3';

            if (operatorSet)
                operationStart = true;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text == "0")
                currentOperandTextBox.Text = "4";
            else if (entryReset && specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
            {
                system.reset();
                currentOperandTextBox.Text = "4";
                secondOperandTextBox.Text = "";
                entryReset = false;
            }
            else if (entryReset)
            {
                currentOperandTextBox.Text = "4";
                entryReset = false;
            }
            else if (currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '4';

            if (operatorSet)
                operationStart = true;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text == "0")
                currentOperandTextBox.Text = "5";
            else if (entryReset && specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
            {
                system.reset();
                currentOperandTextBox.Text = "5";
                secondOperandTextBox.Text = "";
                entryReset = false;
            }
            else if (entryReset)
            {
                currentOperandTextBox.Text = "5";
                entryReset = false;
            }
            else if (currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '5';

            if (operatorSet)
                operationStart = true;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text == "0")
                currentOperandTextBox.Text = "6";
            else if (entryReset && specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
            {
                system.reset();
                currentOperandTextBox.Text = "6";
                secondOperandTextBox.Text = "";
                entryReset = false;
            }
            else if (entryReset)
            {
                currentOperandTextBox.Text = "6";
                entryReset = false;
            }
            else if (currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '6';

            if (operatorSet)
                operationStart = true;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text == "0")
                currentOperandTextBox.Text = "7";
            else if (entryReset && specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
            {
                system.reset();
                currentOperandTextBox.Text = "7";
                secondOperandTextBox.Text = "";
                entryReset = false;
            }
            else if (entryReset)
            {
                currentOperandTextBox.Text = "7";
                entryReset = false;
            }
            else if (currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '7';

            if (operatorSet)
                operationStart = true;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text == "0")
                currentOperandTextBox.Text = "8";
            else if (entryReset && specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
            {
                system.reset();
                currentOperandTextBox.Text = "8";
                secondOperandTextBox.Text = "";
                entryReset = false;
            }
            else if (entryReset)
            {
                currentOperandTextBox.Text = "8";
                entryReset = false;
            }
            else if (currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '8';

            if (operatorSet)
                operationStart = true;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text == "0")
                currentOperandTextBox.Text = "9";
            else if (entryReset && specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
            {
                system.reset();
                currentOperandTextBox.Text = "9";
                secondOperandTextBox.Text = "";
                entryReset = false;
            }
            else if (entryReset)
            {
                currentOperandTextBox.Text = "9";
                entryReset = false;
            }
            else if (currentOperandTextBox.TextLength <= maxLength)
                currentOperandTextBox.Text += '9';

            if (operatorSet)
                operationStart = true;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text.IndexOf('.') == -1 && !entryReset)
                currentOperandTextBox.Text += '.';
            else if (currentOperandTextBox.Text == "0")
                currentOperandTextBox.Text = "0.";
            else if (entryReset && specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
            {
                system.reset();
                currentOperandTextBox.Text = "0.";
                secondOperandTextBox.Text = "";
                entryReset = false;
            }
            else if (entryReset)
            {
                currentOperandTextBox.Text = "0.";
                entryReset = false;
            }

            if (operatorSet)
                operationStart = true;
        }

        private void backSpaceButton_Click(object sender, EventArgs e)
        {
            if (currentOperandTextBox.Text.Length > 1)
            {
                char[] content = currentOperandTextBox.Text.ToCharArray();
                content[currentOperandTextBox.Text.Length - 1] = '\0';
                currentOperandTextBox.Text = String.Join("", content);
            }
            else if (currentOperandTextBox.TextLength == 1 && currentOperandTextBox.Text[0] != '0')
                currentOperandTextBox.Text = "0";
        }

        private void additionButton_Click(object sender, EventArgs e)
        {

            if (operationQueue.Count > 0)
            {
                if (specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
                {
                    operationQueue.Dequeue();
                    operationStart = false;
                }
            }

            if (operationStart)
            {
                if (operationQueue.Count > 0)
                {
                    if (!specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
                    {
                        system.B = decimal.Parse(currentOperandTextBox.Text);
                    }
                    system.calculate(String.Format("{0}", operationQueue.Dequeue()));
                    secondOperandTextBox.Text = $"{system.C} + ";
                    currentOperandTextBox.Text = system.C.ToString();
                    operationQueue.Enqueue("add");

                    entryReset = true;
                }
            }
            else
            {
                operatorSet = true;
                entryReset = true;

                if (operationQueue.Count > 0)
                {
                    if (String.Format("{0}", operationQueue.Peek()) != "add")
                    {
                        operationQueue.Dequeue();
                        operationQueue.Enqueue("add");
                    }
                }
                else
                {
                    operationQueue.Enqueue("add");
                }

                system.A = decimal.Parse(currentOperandTextBox.Text);
                secondOperandTextBox.Text = $"{system.A} + ";
            }
        }

        private void differenceButton_Click(object sender, EventArgs e)
        {

            if (operationQueue.Count > 0)
            {
                if (specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
                {
                    operationQueue.Dequeue();
                    operationStart = false;
                }
            }

            if (operationStart)
            {
                if (operationQueue.Count > 0)
                {
                    if (!specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
                    {
                        system.B = decimal.Parse(currentOperandTextBox.Text);
                    }
                    system.calculate(String.Format("{0}", operationQueue.Dequeue()));
                    secondOperandTextBox.Text = $"{system.C} - ";
                    currentOperandTextBox.Text = system.C.ToString();
                    operationQueue.Enqueue("sub");

                    entryReset = true;
                }
            }
            else
            {
                operatorSet = true;
                entryReset = true;

                if (operationQueue.Count > 0)
                {
                    if (String.Format("{0}", operationQueue.Peek()) != "sub")
                    {
                        operationQueue.Dequeue();
                        operationQueue.Enqueue("sub");
                    }
                }
                else
                {
                    operationQueue.Enqueue("sub");
                }

                system.A = decimal.Parse(currentOperandTextBox.Text);
                secondOperandTextBox.Text = $"{system.A} - ";
            }
        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {

            if (operationQueue.Count > 0)
            {
                if (specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
                {
                    operationQueue.Dequeue();
                    operationStart = false;
                }
            }

            if (operationStart)
            {
                if (operationQueue.Count > 0)
                {
                    if (!specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
                    {
                        system.B = decimal.Parse(currentOperandTextBox.Text);
                    }
                    system.B = decimal.Parse(currentOperandTextBox.Text);
                    system.calculate(String.Format("{0}", operationQueue.Dequeue()));
                    secondOperandTextBox.Text = $"{system.C} × ";
                    currentOperandTextBox.Text = system.C.ToString();
                    operationQueue.Enqueue("mul");

                    entryReset = true;
                }
            }
            else
            {
                operatorSet = true;
                entryReset = true;

                if (operationQueue.Count > 0)
                {
                    if (String.Format("{0}", operationQueue.Peek()) != "mul")
                    {
                        operationQueue.Dequeue();
                        operationQueue.Enqueue("mul");
                    }
                }
                else
                {
                    operationQueue.Enqueue("mul");
                }

                system.A = decimal.Parse(currentOperandTextBox.Text);
                secondOperandTextBox.Text = $"{system.A} × ";
            }
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {

            if (operationQueue.Count > 0)
            {
                if (specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
                {
                    operationQueue.Dequeue();
                    operationStart = false;
                }
            }

            if (operationStart)
            {
                if (operationQueue.Count > 0)
                {
                    if (!specialFunctions.Contains(String.Format("{0}", operationQueue.Peek())))
                    {
                        system.B = decimal.Parse(currentOperandTextBox.Text);
                    }
                    system.B = decimal.Parse(currentOperandTextBox.Text);
                    system.calculate(String.Format("{0}", operationQueue.Dequeue()));
                    secondOperandTextBox.Text = $"{system.C} ÷ ";
                    currentOperandTextBox.Text = system.C.ToString();
                    operationQueue.Enqueue("div");

                    entryReset = true;
                }
            }
            else
            {
                operatorSet = true;
                entryReset = true;

                if (operationQueue.Count > 0)
                {
                    if (String.Format("{0}", operationQueue.Peek()) != "div")
                    {
                        operationQueue.Dequeue();
                        operationQueue.Enqueue("div");
                    }
                }
                else
                {
                    operationQueue.Enqueue("div");
                }

                system.A = decimal.Parse(currentOperandTextBox.Text);
                secondOperandTextBox.Text = $"{system.A} ÷ ";
            }
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {

            if (operationQueue.Count > 0)
            {

                if (String.Format("{0}", operationQueue.Peek()) != "equ")
                {
                    currentOperation = String.Format("{0}", operationQueue.Dequeue());

                    if (currentOperation == "x2")
                    {
                        secondOperandTextBox.Text = String.Format("({0})² = ", system.B);
                    }
                    else if (currentOperation == "sqr")
                    {
                        secondOperandTextBox.Text = String.Format("√({0}) = ", system.B);
                    }
                    else
                    {
                        system.B = decimal.Parse(currentOperandTextBox.Text);
                        system.calculate(currentOperation);
                        secondOperandTextBox.Text = String.Format("{0} {1} {2} = ", system.A, setOperator(), system.B);
                    }
                    operationQueue.Enqueue("equ");
                }
                else
                {
                    system.A = system.C;
                    system.calculate(currentOperation);
                }


                currentOperandTextBox.Text = $"{system.C}";
                entryReset = true;
            }
        }

        private void percentageButton_Click(object sender, EventArgs e)
        {

            if ("mul|div".Contains(String.Format("{0}", operationQueue.Peek())))
            {
                system.B = system.A;
                system.A = decimal.Parse(currentOperandTextBox.Text);
                system.calculate("div");
                currentOperandTextBox.Text = system.C.ToString();
                secondOperandTextBox.Text = String.Format("{0} {1} {2}", system.B, operationQueue.Dequeue(), system.C);
            }
            else if ("add|sub".Contains(String.Format("{0}", operationQueue.Peek())))
            {
                system.B = decimal.Parse(currentOperandTextBox.Text) / 100;
                system.calculate("mul");
                currentOperandTextBox.Text = system.C.ToString();
                secondOperandTextBox.Text = String.Format("{0} {1} {2}", system.B, operationQueue.Dequeue(), system.C);
            }

            entryReset = true;
            operationQueue.Enqueue("per");
        }

        private void oneOverXButton_Click(object sender, EventArgs e)
        {

            currentOperation = operationQueue.Count > 0 ? String.Format("{0}", operationQueue.Peek()) : "N/A";

            try
            {
                if (operationQueue.Count > 0 && !specialFunctions.Contains(currentOperation))
                {
                    system.B = decimal.Parse(currentOperandTextBox.Text);
                    system.calculate("1/x");
                    currentOperandTextBox.Text = system.C.ToString();
                    secondOperandTextBox.Text = String.Format("{0} + 1 / ({1})", system.A, system.B);
                }
                else
                {
                    system.A = 1;
                    system.B = decimal.Parse(currentOperandTextBox.Text);
                    system.calculate("1/x");
                    currentOperandTextBox.Text = system.C.ToString();
                    secondOperandTextBox.Text = String.Format("{0} / ({1})", system.A, system.B);
                }
            }
            catch (Exception)
            {
                currentOperandTextBox.Text = "Err";
            }

            operationStart = true;
            entryReset = true;
            operationQueue.Enqueue("1/x");
        }

        private void squareRootButton_Click(object sender, EventArgs e)
        {

            currentOperation = operationQueue.Count > 0 ? String.Format("{0}", operationQueue.Peek()) : "N/A";

            if (operationQueue.Count > 0 && !specialFunctions.Contains(currentOperation))
            {
                system.B = decimal.Parse(currentOperandTextBox.Text);
                system.calculate("sqr");
                currentOperandTextBox.Text = system.C.ToString();
                secondOperandTextBox.Text = String.Format("{0} + √({1})", system.A, system.B);
            }
            else
            {
                system.B = decimal.Parse(currentOperandTextBox.Text);
                system.calculate("sqr");
                currentOperandTextBox.Text = system.C.ToString();
                secondOperandTextBox.Text = String.Format("√({0})", system.B);
            }

            operationStart = true;
            entryReset = true;
            operationQueue.Enqueue("sqr");
        }

        private void squaredButton_Click(object sender, EventArgs e)
        {
            currentOperation = operationQueue.Count > 0 ? String.Format("{0}", operationQueue.Peek()) : "N/A";

            if (operationQueue.Count > 0 && !specialFunctions.Contains(currentOperation))
            {
                system.B = decimal.Parse(currentOperandTextBox.Text);
                system.calculate("x2");
                currentOperandTextBox.Text = system.C.ToString();
                secondOperandTextBox.Text = String.Format("{0} + ({1})²", system.A, system.B);
            }
            else
            {
                system.B = decimal.Parse(currentOperandTextBox.Text);
                system.calculate("x2");
                currentOperandTextBox.Text = system.C.ToString();
                secondOperandTextBox.Text = String.Format("({0})²", system.B);
            }

            operationStart = true;
            entryReset = true;
            operationQueue.Enqueue("x2");
        }

        private void positveNegativeButton_Click(object sender, EventArgs e)
        {
            decimal value = decimal.Parse(currentOperandTextBox.Text) * -1;
            currentOperandTextBox.Text = $"{value}";
        }

        private void currentOperandTextBox_TextChanged(object sender, EventArgs e)
        {
            string content = currentOperandTextBox.Text;
            char format = 'N';

            try
            {
                if (content.IndexOf('.') != -1 && decimal.Parse(content.Substring(content.IndexOf('.'))) != 0)
                {
                    if (content.Length > content.IndexOf('.') + 1)
                    {
                        int decimalPlaces = content.Substring(content.IndexOf('.') + 1).Length;

                        if (content.IndexOf('.') > maxLength)
                        {
                            format = 'E';
                        }

                        for (int i = decimalPlaces; i >= 0; i--)
                        {
                            if (content.IndexOf('.') + i <= maxLength)
                            {
                                decimalPlaces = i; break;
                            }
                        }

                        currentOperandTextBox.Text = decimal.Parse(content).ToString($"{format}{decimalPlaces}");
                    }
                }
                else
                {
                    if (content.Length > maxLength)
                    {
                        format = 'E';
                    }

                    currentOperandTextBox.Text = decimal.Parse(content).ToString($"{format}0");
                }
            }
            catch (Exception) { }
        }

        private void acButton_Click(object sender, EventArgs e)
        {
            currentOperandTextBox.Text = "0";
            secondOperandTextBox.Text = "";
            currentOperation = "";
            operationStart = false;
            operatorSet = false;
            entryReset = false;
            system.reset();
            operationQueue.Clear();
        }

        private void ceButton_Click(object sender, EventArgs e)
        {
            currentOperandTextBox.Text = "0";
        }

        private void mPositiveButton_Click(object sender, EventArgs e)
        {
            memory += decimal.Parse(currentOperandTextBox.Text);
        }

        private void mNegativeButton_Click(object sender, EventArgs e)
        {
            memory -= decimal.Parse(currentOperandTextBox.Text);
        }

        private void mcButton_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void mrButton_Click(object sender, EventArgs e)
        {
            currentOperandTextBox.Text = memory.ToString();
        }

        private char setOperator()
        {
            if (currentOperation == "add")
                return '+';
            else if (currentOperation == "sub")
                return '-';
            else if (currentOperation == "mul")
                return '×';
            else if (currentOperation == "div")
                return '÷';
            else if (currentOperation == "1/x")
                return '/';
            else if (currentOperation == "sqr")
                return '√';
            else
                return '\0';
        }
    }
}